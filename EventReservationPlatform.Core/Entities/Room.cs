using EventReservationPlatform.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventReservationPlatform.Core.Entities
{
    public class Room
    {
        public Room(string name, int capacity, Location location)
        {
            Name = name;
            Capacity = capacity;
            Location = location;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public Location Location { get; set; }



    }
}
