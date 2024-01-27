using EventReservationPlatform.Core.Dtos;
using EventReservationPlatform.Core.Entities;
using EventReservationPlatform.Core.Interface.Repositories;
using EventReservationPlatform.Persistence.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventReservationPlatform.Persistence.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        public readonly EventReservationDbContext DbContext;
        
        public RoomRepository(EventReservationDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public async Task<ResponseNewRoomDto> CreateRoomAsync(Room room)
        {
            DbContext.Rooms.Add(room);

            return new ResponseNewRoomDto(room.Id);
        }

        public async Task<IList<Room>> GetAllRoomsAsync()
        {
            var rooms =  DbContext
               .Rooms;

            return rooms;
        }

        public async Task<Room> GetByIdAsync(Guid Id)
        {
            var room = DbContext
                .Rooms
                .FirstOrDefault(r => r.Id == Id);

            return room;
        }

        public async Task ToogleStatusAsync(Guid Id)
        {
            var room = await GetByIdAsync(Id);

            room.ToggleStatus();
        }

        public async Task UpdateRoomAsync(RequestUpdateRoomDto requestUpdateRoomDto)
        {
            var room = await GetByIdAsync(requestUpdateRoomDto.Id);

            room.LocationId = requestUpdateRoomDto.LocationId;
            room.Name = requestUpdateRoomDto.Name;
            room.Capacity = requestUpdateRoomDto.Capacity;
        }


    }
}
