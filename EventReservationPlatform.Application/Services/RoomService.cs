using EventReservationPlatform.Core.Dtos;
using EventReservationPlatform.Core.Entities;
using EventReservationPlatform.Core.Interface.Repositories;
using EventReservationPlatform.Core.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventReservationPlatform.Application.Services
{
    public class RoomService : IRoomService
    {
        public readonly IRoomRepository RoomRepository;
        public RoomService(IRoomRepository roomRepository)
        {
            RoomRepository = roomRepository;
        }

        public async Task<ResponseNewRoomDto> CreateRoom(RequestNewRoomDto requestNewRoomDto)
        {
            var room = new Room(
                requestNewRoomDto.Name,
                requestNewRoomDto.Capacity,
                requestNewRoomDto.LocationId
                );

            var result = await RoomRepository.CreateRoomAsync(room);

            return result;
        }

        public Task<IList<ResponseViewRoomDto>> GetAllRooms()
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseViewRoomDto> GetById(Guid Id)
        {
            var room = await RoomRepository.GetByIdAsync(Id);

            return new ResponseViewRoomDto(
                 room.Name
                ,room.Capacity
                ,room.LocationId
                ,room.Status
                );
        }

        public async Task ToogleStatus(RequestToggleRoomDto requestToggleRoomDto)
        {
            var room = await  RoomRepository.GetByIdAsync(requestToggleRoomDto.Id);

            room.ToggleStatus();
        }
    }
}
