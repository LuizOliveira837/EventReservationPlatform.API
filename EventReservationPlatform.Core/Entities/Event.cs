using EventReservationPlatform.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventReservationPlatform.Core.Entities
{
    public class Event
    {
        public Event(EventTypeEnum eventType, DateTime startTime, DateTime endTime)
        {
            Participants = new List<Participant>();
            EventType = eventType;
            StartTime = startTime;
            EndTime = endTime;
        }

        public Guid Id { get; set; }
        public IList<Participant> Participants { get; set; }
        public EventTypeEnum EventType { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public SocialMedia SocialMedia { get; set; }
    }
}
