using EventReservationPlatform.Core.Dtos.Room;
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
        public readonly EventReservationDbContext _dbContext;
        
        public RoomRepository(EventReservationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<ResponseNewRoomDto> CreateAsync(Room room)
        {
            await _dbContext.Rooms.AddAsync(room);
            await _dbContext.SaveChangesAsync();
            return new ResponseNewRoomDto(room.Id);
        }

        public async Task<IList<Room>> GetAllAsync()
        {
            var rooms =  await _dbContext
               .Rooms
               .Include(ro=> ro.Location)
               .ToListAsync();

            return rooms;
        }

        public async Task<Room> GetByIdAsync(Guid Id)
        {
            var room = await _dbContext
                .Rooms
                .Include(ro=> ro.Location)
                .FirstOrDefaultAsync(r => r.Id == Id);

            return room;
        }

        public async Task UpdateAsync()
        {
            await _dbContext.SaveChangesAsync();
        }


    }
}
