using EventReservationPlatform.Core.Dtos.UserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventReservationPlatform.Core.Interface.Services
{
    public interface IUserService
    {
        public Task<Guid> CreateUser(RequestNewUserDTO requestNewUserDTO);
    }
}
