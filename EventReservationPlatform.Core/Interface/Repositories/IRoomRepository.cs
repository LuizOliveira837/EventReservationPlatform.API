using EventReservationPlatform.Core.Dtos.Room;
using EventReservationPlatform.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventReservationPlatform.Core.Interface.Repositories
{
    public interface IRoomRepository
    {
        public Task<IList<Room>> GetAllAsync();
        public Task<Room> GetByIdAsync(Guid Id);
        public Task<ResponseNewRoomDto> CreateAsync(Room room);
        public Task UpdateAsync();
    }
}
