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

        public Task<IList<Room>> GetAllRoomsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Room> GetByIdAsync(Guid Id)
        {
            var room =  DbContext
                .Rooms
                .Single(r => r.Id == Id);

            return room;
        }

        public void ToogleStatusAsync(RequestToggleRoomDto requestToggleRoomDto)
        {
            throw new NotImplementedException();
        }
    }
}
