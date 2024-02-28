using EventReservationPlatform.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventReservationPlatform.Core.Interface.Repositories
{
    public interface IUserRepository
    {

        public Task<Guid> CreateAsync(User user);
        public Task<User> GetByEmail(string email);
    }
}
