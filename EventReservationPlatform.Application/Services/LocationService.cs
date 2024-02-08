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
        public async Task<ResponseViewLocationDto> GetByIdAsync(Guid id)
        {
            var location = await _locationRepository.GetById(id);

            if (location == null) throw new Exception("Location not found");

            var locationView = location.Adapt<ResponseViewLocationDto>();

            return locationView;
        }

        public async Task<Guid> CreateLocation(RequestNewLocationDto request)
        {
            var newLocation = request.Adapt<Location>();

            RoomValidatorHandle.LocationIsValid(newLocation);

            var id = await _locationRepository.CreateAsync(newLocation);

            return id;
        }

        public async Task UpdateLocation(RequestUpdateLocationDto request)
        {
            var location = await _locationRepository.GetById(request.Id);

            if (location == null) throw new Exception("Location not found");

            var updateLocation = request.Adapt(location);

            RoomValidatorHandle.LocationIsValid(updateLocation);

            await _locationRepository.UpdateAsync();


        }
    }
}
