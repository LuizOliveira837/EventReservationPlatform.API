using EventReservationPlatform.Application.Validators;
using EventReservationPlatform.Core.Dtos.UserDtos;
using EventReservationPlatform.Core.Entities;
using EventReservationPlatform.Core.Interface.Repositories;
using EventReservationPlatform.Core.Interface.Services;
using EventReservationPlatform.Persistence.Auth;
using FluentValidation;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace EventReservationPlatform.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly Autenticate _autenticate;

        public UserService(IUserRepository repository, Autenticate autenticate)
        {
            _repository = repository;
            _autenticate = autenticate;
        }

        public async Task<string> Autentication(RequestLoginUserDTO requestNewUserDTO)
        {
            var user = await _repository.GetByEmail(requestNewUserDTO.Email);

            if (user == null) throw new Exception("The email is not linked to any user");

            var passwordIsValid = await EncryptPassword.Verify(requestNewUserDTO.Password, user.Password);

            if (!passwordIsValid) throw new Exception("Credentials Invalid");

            var token = await _autenticate.GenerationToken(user);

            return token;

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
