using EventReservationPlatform.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventReservationPlatform.Core.Entities
{
    public class Credential
    {
        public Credential(int eventId, Participant participant, int participantId)
        {
            EventId = eventId;
            Participant = participant;
            ParticipantId = participantId;
        }

        public Guid Id { get; set; }
        public virtual Event Event { get; set; }
        public int EventId { get; set; }
        public virtual  Participant Participant { get; set; }
        public int ParticipantId { get; set; }
    }
}
