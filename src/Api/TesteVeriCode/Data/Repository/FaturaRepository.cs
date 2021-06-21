using Business.Interfaces;
using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class FaturaRepository : IFaturaRepository
    {
        public virtual async Task<List<Fatura>> RetornaFaturas()
        {
            var lista = new List<Fatura>();
            int i = 0;
            try
            {
                var lines = System.IO.File.ReadAllLines(@"C:\Users\bruno\Documents\Projetos\DesafioVeriCode\src\Api\TesteVeriCode\Data\BaseDados\Base.txt");
                foreach (string line in lines)
                {

                    var item = line.Split(';');
                    var fatura = new Fatura();
                    fatura.NomeCliente = item[0].ToString();
                    fatura.CEP = item[1].ToString();
                    fatura.RuaComComplemento = item[2].ToString();
                    fatura.Bairro = item[3].ToString();
                    fatura.Cidade = item[4].ToString();
                    fatura.Estado = item[5].ToString();
                    fatura.ValorFatura = Convert.ToDecimal(item[6].ToString().Replace(".", ","));
                    fatura.NumeroPaginas = Convert.ToInt32(item[7].ToString());
                    lista.Add(fatura);
                    i++;
                }
            }
            catch (Exception ex)
            {

            }

            return await Task.FromResult(lista);
        }
    }
}
