using Business.Core.Validations.Documentos;
using Business.Models;
using FluentValidation;

namespace Business.Validations
{
    public class FaturaValidation : AbstractValidator<Fatura>
    {
        public FaturaValidation()
        {
            RuleFor(f => CepValidation.Validar(f.CEP)).Equal(true)
                   .WithMessage("O CEP fornecido é inválido.")
                   .NotEmpty().WithMessage("O campo {PropertyName}, deve ser fornecido!");

            RuleFor(f => f.ValorFatura)
               .GreaterThan(0)
               .WithMessage("O campo {PropertyName} precisa ser maior que {ComparisonValue}");

            RuleFor(f => f.NumeroPaginas)
              .GreaterThan(0)
              .WithMessage("O campo {PropertyName} precisa ser maior que {ComparisonValue}");
        }
    }
}
