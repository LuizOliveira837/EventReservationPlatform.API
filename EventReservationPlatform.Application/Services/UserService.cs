using EventReservationPlatform.Application.Validators;
using EventReservationPlatform.Core.Dtos.UserDtos;
using EventReservationPlatform.Core.Entities;
using EventReservationPlatform.Core.Interface.Repositories;
using EventReservationPlatform.Core.Interface.Services;
using FluentValidation;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventReservationPlatform.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }
        public async Task<Guid> CreateUser(RequestNewUserDTO requestNewUserDTO)
        {

            User user = requestNewUserDTO.Adapt<User>();

            RoomValidatorHandle.UserIsValid(user);


            var id = await _repository.CreateAsync(user);


            return id;
        }
    }
}
