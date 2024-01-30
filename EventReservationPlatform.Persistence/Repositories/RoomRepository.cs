using EventReservationPlatform.Core.Dtos;
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
    public class RoomRepository : IRoomRepository
    {
        public readonly EventReservationDbContext DbContext;
        
        public RoomRepository(EventReservationDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public async Task<ResponseNewRoomDto> CreateRoomAsync(Room room)
        {
            await DbContext.Rooms.AddAsync(room);
            await DbContext.SaveChangesAsync();
            return new ResponseNewRoomDto(room.Id);
        }

        public async Task<IList<Room>> GetAllRoomsAsync()
        {
            var rooms =  await DbContext
               .Rooms
               .ToListAsync();

            return rooms;
        }

        public async Task<Room> GetByIdAsync(Guid Id)
        {
            var room = await DbContext
                .Rooms
                .FirstOrDefaultAsync(r => r.Id == Id);

            return room;
        }

        public async Task UpdateRoomAsync()
        {
            await DbContext.SaveChangesAsync();
        }


    }
}
