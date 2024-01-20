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
        public ResponseViewRoomDto(string name, int capacity, Guid locationId, StatusEntity status)
        {
            Name = name;
            Capacity = capacity;
            LocationId = locationId;
            Status = status;
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public virtual Location Location { get; set; }
        public Guid LocationId { get; set; }
        public StatusEntity Status { get; }
    }
}
