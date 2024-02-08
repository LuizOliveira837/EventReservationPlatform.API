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
    public class LocationRepository : ILocationRepository
    {
        public readonly EventReservationDbContext _dbContext;
        public LocationRepository(EventReservationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Guid> CreateAsync(Location location)
        {
            await _dbContext
                .Locations
                .AddAsync(location);

            await _dbContext.SaveChangesAsync();

            return location.Id;
        }

        public async Task<Location> GetById(Guid id)
        {
            var location = await _dbContext
                .Locations
                .FirstOrDefaultAsync(location => location.Id == id);

            return location;

        }

        public async Task UpdateAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
