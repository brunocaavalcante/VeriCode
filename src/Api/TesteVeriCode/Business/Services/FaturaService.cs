using Business.Core.Services;
using Business.Interfaces;
using Business.Models;
using Business.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class FaturaService : BaseService, IFaturaService
    {
        private readonly IFaturaRepository repository;
        public FaturaService(IFaturaRepository faturaRepository)
        {
            repository = faturaRepository;
        }

        public async Task<List<Fatura>> Processar()
        {
            var listaProcessada = new List<Fatura>();
            var lista = await repository.RetornaFaturas();

            foreach (var item in lista)
            {
                if (ValidaFatura(item))
                {
                    if (ValidaSeImpar(item)) item.NumeroPaginas += 1;
                    listaProcessada.Add(item);
                }
            }
            return await Task.FromResult(listaProcessada.OrderBy(f => f.NumeroPaginas).ToList());
        }

        private bool ValidaFatura(Fatura item)
        {
            return ExecutarValidacao(new FaturaValidation(), item);
        }

        private bool ValidaSeImpar(Fatura item)
        {
            return item.NumeroPaginas % 2 == 1;
        }
    }
}
