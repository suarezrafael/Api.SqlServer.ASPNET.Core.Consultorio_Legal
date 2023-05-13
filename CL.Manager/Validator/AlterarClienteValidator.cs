using CL.Core.Shared.ModelViews;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CL.Manager.Validator
{
    public class AlterarClienteValidator : AbstractValidator<AlteraCliente>
    {
        public AlterarClienteValidator()
        {
            RuleFor(p => p.Id).NotNull().NotEmpty().GreaterThan(0);
            Include(new NovoClienteValidator());
        }
    }
}
