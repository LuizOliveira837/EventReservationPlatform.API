using EventReservationPlatform.Core.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventReservationPlatform.Core.Validators
{
    public class LocationValidator : AbstractValidator<Location>
    {
        public LocationValidator()
        {
            RuleFor(lo => lo.Address)
                .NotEmpty()
                .NotNull()
                .WithMessage("Addres do  not can to be empty or null");

            RuleFor(lo => lo.Number)
                .NotEmpty()
                .NotNull()
                .WithMessage("Number do not can to be empty or null");

            RuleFor(lo => lo.CEP)
                .NotNull()
                .WithMessage("CEP do not can to be empty or null")
                .Matches("^\\d{8}$")
                .WithMessage("CEP invalid");

        }



  
    }
}
