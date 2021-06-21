using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.ViewModels
{
    public class FaturaViewModel
    {
        public string NomeCliente { get; set; }
        public string CEP { get; set; }
        public string RuaComComplemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public double ValorFatura { get; set; }
        public int NumeroPaginas { get; set; }
    }
}
