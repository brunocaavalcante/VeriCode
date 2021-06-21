using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class Fatura
    {
       public string NomeCliente { get; set; }
       public string CEP { get; set; }
       public string RuaComComplemento { get; set; }
       public string Bairro { get; set; }
       public string Cidade { get; set; }
       public string Estado { get; set; }
       public decimal ValorFatura { get; set; }
       public int NumeroPaginas { get; set; }
    }
}
