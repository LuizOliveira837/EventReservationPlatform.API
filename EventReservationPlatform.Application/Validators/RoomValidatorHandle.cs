using EventReservationPlatform.Core.Dtos;
using EventReservationPlatform.Core.Entities;
using EventReservationPlatform.Core.Validators;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventReservationPlatform.Application.Validators
{
    public static class RoomValidatorHandle
    {

        public static void RoomIsValid(Room newRoom)
        {
            IValidator<Room> newRoomValidator = new RoomValidator();
            var result = newRoomValidator.Validate(newRoom);

            if (!result.IsValid) throw new Exception(result.Errors.FirstOrDefault().ToString());
        }


        public static void LocationIsValid(Location newLocation)
        {
            IValidator<Location> newLocationValidator = new LocationValidator();
            var result = newLocationValidator.Validate(newLocation);

            if (!result.IsValid) throw new Exception(result.Errors.FirstOrDefault().ToString());
        }

        public static void UserIsValid(User newUser)
        {
            IValidator<User> newLocationValidator = new UserValidator();
            var result = newLocationValidator.Validate(newUser);

            if (!result.IsValid) throw new Exception(result.Errors.FirstOrDefault().ToString());
        }
    }
}
