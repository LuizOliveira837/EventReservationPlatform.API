using EventReservationPlatform.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventReservationPlatform.Core.Interface.Services
{
    public interface IRoomService
    {
        public Task<IList<ResponseViewRoomDto>> GetAllRooms();
        public Task<ResponseViewRoomDto> GetById(Guid Id);
        public Task<ResponseNewRoomDto> CreateRoom(RequestNewRoomDto requestNewRoomDto);
        public void ToogleStatus(RequestToggleRoomDto requestToggleRoomDto);
    }
}
