using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business.Core.Validations.Documentos
{
    public class CepValidation
    {
        private const int Tamanho = 8;
        public static bool Validar(string cep)
        {
            cep = RemoveEspacoEmBranco(cep);
            if (TamanhoValido(cep) && !TemDigitosRepetidos(cep)) return true;

            return false;
        }

        private static bool TamanhoValido(string valor)
        {           
            return valor.Length == Tamanho;
        }

        private static bool TemDigitosRepetidos(string valor)
        {
            string[] invalidNumbers =
            {
                "00000000",
                "11111111",
                "22222222",
                "33333333",
                "44444444",
                "55555555",
                "66666666",
                "77777777",
                "88888888",
                "99999999"
            };
            return invalidNumbers.Contains(valor);
        }

        private static string RemoveEspacoEmBranco(string valor)
        {
            return valor.Replace(" ", "");
        }
    }
}
