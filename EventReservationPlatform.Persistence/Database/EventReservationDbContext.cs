using EventReservationPlatform.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventReservationPlatform.Persistence.Database
{
    public class EventReservationDbContext
    {
        public EventReservationDbContext()
        {
            Rooms = new List<Room>();
        }

        public IList<Room> Rooms { get; set; }
    }
}
