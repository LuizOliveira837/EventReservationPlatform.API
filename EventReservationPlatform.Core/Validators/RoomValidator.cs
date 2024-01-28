using EventReservationPlatform.Core.Dtos;
using EventReservationPlatform.Core.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventReservationPlatform.Core.Validators
{
    public class RoomValidator : AbstractValidator<Room>
    {
        public RoomValidator()
        {
            RuleFor(rf => rf.Capacity)
                .NotEmpty()
                .WithMessage("The Capacity don't can to be empty")
                .GreaterThan(1)
                .WithMessage("The Capacity has to be greater than 1");

            RuleFor(rf => rf.RoomName) 
                .NotEmpty()
                .WithMessage("The RoomName don't can to be empty")
                .Length(8,40)
                .WithMessage("The length RoomName has to be between 8 and 40");

            RuleFor(rf => rf.LocationId)
                .NotEmpty()
                .WithMessage("The LocationId don't can to be empty");

        }
    }

}
