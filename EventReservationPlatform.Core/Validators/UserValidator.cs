using EventReservationPlatform.Core.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventReservationPlatform.Core.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(user => user.Name)
                .NotEmpty()
                .WithMessage("The Name don't can to be empty");

            RuleFor(user => user.LastName)
                .NotEmpty()
                .WithMessage("The Last Name don't can to be empty");

            RuleFor(user => user.Email)
                .NotEmpty()
                .WithMessage("The Email don't can to be empty")
                .Matches("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,6}$")
                .WithMessage("Email invalid");

            RuleFor(user => user.Password)
                .NotEmpty()
                .WithMessage("The Password don't can to be empty")
                .Matches("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^a-zA-Z\\d]).{6,12}$")
                .WithMessage("Password invalid");




        }
    }
}
