using EventReservationPlatform.Core.Entities;
using EventReservationPlatform.Core.Interface.Repositories;
using EventReservationPlatform.Persistence.Auth;
using EventReservationPlatform.Persistence.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventReservationPlatform.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly EventReservationDbContext _dbContext;

        public UserRepository(EventReservationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Guid> CreateAsync(User user)
        {
            user.Password = await EncryptPassword.Encrypt(user.Password);
            
            _dbContext.Add(user);

            await _dbContext.SaveChangesAsync();

            return user.Id;
        }



        public async Task<User> GetByEmail(string email)
        {
            var user = await _dbContext
                .Users
                .FirstOrDefaultAsync(u => u.Email == email);

            return user;

        }
    }
}
