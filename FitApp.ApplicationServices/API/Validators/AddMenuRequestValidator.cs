using FitApp.ApplicationServices.API.Domain;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitApp.ApplicationServices.API.Validators
{
    public class AddMenuRequestValidator : AbstractValidator<AddMenuRequest>
    {
        public AddMenuRequestValidator()
        {
            this.RuleFor(r => r.Number)
                .NotNull()
                .WithMessage("Number cannot be null value");
        }
    }
}
