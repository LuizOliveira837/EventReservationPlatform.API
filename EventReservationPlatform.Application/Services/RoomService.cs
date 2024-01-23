using EventReservationPlatform.Core.Dtos;
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
    public class RoomService : IRoomService
    {
        public readonly IRoomRepository RoomRepository;
        public RoomService(IRoomRepository roomRepository)
        {
            RoomRepository = roomRepository;
        }

        public async Task<ResponseNewRoomDto> CreateRoom(RequestNewRoomDto requestNewRoomDto)
        {
            var room = requestNewRoomDto.Adapt<Room>(); 

            var result = await RoomRepository.CreateRoomAsync(room);

            return result;
        }

        public async Task<IList<ResponseViewRoomDto>> GetAllRooms()
        {
            var rooms = await RoomRepository.GetAllRoomsAsync();

            var viewRomms = rooms.Adapt<IList<ResponseViewRoomDto>>();

            return viewRomms;

        }

        public async Task<ResponseViewRoomDto> GetById(Guid Id)
        {
            var room = await RoomRepository.GetByIdAsync(Id);

            var viewRomm = room.Adapt<ResponseViewRoomDto>();

            return viewRomm;
        }

        public async Task ToogleStatus(RequestToggleRoomDto requestToggleRoomDto)
        {
            var room = await RoomRepository.GetByIdAsync(requestToggleRoomDto.Id);

            await RoomRepository.ToogleStatusAsync(requestToggleRoomDto.Id);

        }

        public async Task UpdateRoom(RequestUpdateRoomDto requestUpdateRoomDto)
        {
            await RoomRepository.UpdateRoomAsync(requestUpdateRoomDto);
        }
    }
}
