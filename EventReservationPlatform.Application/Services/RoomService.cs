using EventReservationPlatform.Core.Dtos;
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

        public Task<ResponseNewRoomDto> CreateRoom(RequestNewRoomDto requestNewRoomDto)
        {
            throw new NotImplementedException();
        }

        public Task<IList<ResponseViewRoomDto>> GetAllRooms()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseViewRoomDto> GetById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public void ToogleStatus(RequestToggleRoomDto requestToggleRoomDto)
        {
            throw new NotImplementedException();
        }
    }
}
