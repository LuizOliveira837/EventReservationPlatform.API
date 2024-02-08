using EventReservationPlatform.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventReservationPlatform.Core.Interface.Repositories
{
    public interface ILocationRepository
    {
        public Task<Guid> CreateAsync(Location location);
        public Task<Location> GetById(Guid id);
        public Task UpdateAsync();
    }
}
