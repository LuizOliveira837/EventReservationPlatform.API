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
        public static IValidator<Room> NewRoomValidate { get; set; }

        public static void RoomIsValid(Room newRoom)
        {
            NewRoomValidate = new RoomValidator();
            var result = NewRoomValidate.Validate(newRoom);

            if (!result.IsValid) throw new Exception(result.Errors.FirstOrDefault().ToString());
        }
    }
}
