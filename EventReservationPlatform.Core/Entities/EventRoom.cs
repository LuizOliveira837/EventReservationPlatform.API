using EventReservationPlatform.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventReservationPlatform.Core.Entities
{
    public class EventRoom
    {
        public EventRoom(int eventId, int roomId, DateTime startDate, DateTime endDate, StatusEntity status)
        {
            EventId = eventId;
            RoomId = roomId;
            StartDate = startDate;
            EndDate = endDate;
            Status = status;
        }

        public Guid Id { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
        public int RoomId { get; set; }
        public virtual Room Room { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public StatusEntity Status { get; set; }
    }
}
