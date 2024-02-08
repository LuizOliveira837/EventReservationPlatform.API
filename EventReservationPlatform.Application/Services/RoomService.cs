using EventReservationPlatform.Application.Validators;
using EventReservationPlatform.Core.Dtos.Room;
using EventReservationPlatform.Core.Dtos.RoomDtos;
using EventReservationPlatform.Core.Entities;
using EventReservationPlatform.Core.Exceptions;
using EventReservationPlatform.Core.Interface.Repositories;
using EventReservationPlatform.Core.Interface.Services;
using EventReservationPlatform.Core.Validators;
using FluentValidation;
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

            RoomValidatorHandle.RoomIsValid(room);

            var result = await RoomRepository.CreateAsync(room);

            return result;
        }

        public async Task<IList<ResponseViewRoomDto>> GetAllRooms()
        {
            var rooms = await RoomRepository.GetAllAsync();

            var viewRomms = rooms.Adapt<IList<ResponseViewRoomDto>>();

            return viewRomms;

        }

        public async Task<ResponseViewRoomDto> GetById(Guid id)
        {
            var room = await RoomRepository.GetByIdAsync(id);

            if (room is null) throw new NotFoundByIdException("Room", id);

            var viewRomm = room.Adapt<ResponseViewRoomDto>();

            return viewRomm;
        }

        public async Task ToogleStatus(RequestToggleRoomDto requestToggleRoomDto)
        {
            var room = await RoomRepository.GetByIdAsync(requestToggleRoomDto.Id);

            if (room is null) throw new NotFoundByIdException("Room", requestToggleRoomDto.Id);

            room.ToggleStatus();

            await RoomRepository.UpdateAsync();

        }

        public async Task UpdateRoom(RequestUpdateRoomDto requestUpdateRoomDto)
        {
            var room = await RoomRepository.GetByIdAsync(requestUpdateRoomDto.Id);

            room = requestUpdateRoomDto.Adapt(room);

            RoomValidatorHandle.RoomIsValid(room);

            await RoomRepository.UpdateAsync();
        }
    }
}
