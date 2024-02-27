using EventReservationPlatform.Core.Entities;
using EventReservationPlatform.Core.Interface.Repositories;
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
            _dbContext.Add(user);

            await _dbContext.SaveChangesAsync();

            return user.Id;
        }
    }
}
