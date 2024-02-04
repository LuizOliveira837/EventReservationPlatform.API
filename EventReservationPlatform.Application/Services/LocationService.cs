using EventReservationPlatform.Application.Validators;
using EventReservationPlatform.Core.Dtos.LocationDtos;
using EventReservationPlatform.Core.Entities;
using EventReservationPlatform.Core.Interface.Repositories;
using EventReservationPlatform.Core.Interface.Services;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventReservationPlatform.Application.Services
{
    public class LocationService : ILocationService
    {
        public readonly ILocationRepository _locationRepository;
        public LocationService(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }
        public Task<ResponseViewLocationDto> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<Guid> CreateLocation(RequestNewLocationDto request)
        {
            var newLocation = request.Adapt<Location>();

            RoomValidatorHandle.LocationIsValid(newLocation);

            var id = await _locationRepository.CreateLocationAsync(newLocation);

            return id;
        }
    }
}
