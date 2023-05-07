using CL.Core.Domain;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CL.Manager.Validator
{
    public class ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator()
        {
            RuleFor(r => r.Nome).NotNull().NotEmpty().MinimumLength(10).MaximumLength(150);
            RuleFor(r => r.DataNascimento).NotNull().NotEmpty().LessThan(DateTime.Now).GreaterThan(DateTime.Now.AddYears(-130));
            RuleFor(r => r.Documento).NotNull().NotEmpty().MinimumLength(4).MaximumLength(14);
            RuleFor(r => r.Telefone).NotNull().NotEmpty().Matches("[2-9][0-9]{10}").WithMessage("O telefome deve ter o formato [2-9][0-9]{10}");
            RuleFor(r => r.Sexo).NotNull().NotEmpty().Must(IsMorF).WithMessage("Sexo precisa ser M ou F");

        }

        private bool IsMorF(char sexo)
        {
            return sexo == 'M' || sexo == 'F';
        }
    }
}
