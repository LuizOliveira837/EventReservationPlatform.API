using EventReservationPlatform.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventReservationPlatform.Core.Dtos
{
    public class ResponseViewRoomDto
    {
        public ResponseViewRoomDto(string name, int capacity, Location location)
        {
            Name = name;
            Capacity = capacity;
            Location = location;
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public Location Location { get; set; }
    }
}
