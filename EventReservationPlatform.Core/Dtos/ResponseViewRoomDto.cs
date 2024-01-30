using EventReservationPlatform.Core.Entities;
using EventReservationPlatform.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventReservationPlatform.Core.Dtos
{
    public class ResponseViewRoomDto
    {
        public ResponseViewRoomDto()
        {
        }
        public ResponseViewRoomDto(string roomName, int capacity, string status)
        {
            RoomName = roomName;
            Capacity = capacity;
            Status = status;

            
        }

        public string RoomName { get; set; }
        public int Capacity { get; set; }
        public virtual Location Location { get; set; }
        public string Status { get; set; }
    }
}
