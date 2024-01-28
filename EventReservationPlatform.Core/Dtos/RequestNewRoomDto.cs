using EventReservationPlatform.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventReservationPlatform.Core.Dtos
{
    public class RequestNewRoomDto
    {
        public RequestNewRoomDto(string roomName, int capacity, Guid locationId)
        {
            RoomName = roomName;
            Capacity = capacity;
            LocationId = locationId;
        }

        public string RoomName { get; set; }
        public int Capacity { get; set; }
        public Guid LocationId { get; set; }
    }
}
