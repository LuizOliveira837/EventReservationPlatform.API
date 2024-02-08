using EventReservationPlatform.Core.Dtos.LocationDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventReservationPlatform.Core.Interface.Services
{
    public interface ILocationService
    {

        public Task<ResponseViewLocationDto> GetByIdAsync(Guid id);
        public Task<Guid> CreateLocation(RequestNewLocationDto request);
        public Task UpdateLocation(RequestUpdateLocationDto request);
    }
}
