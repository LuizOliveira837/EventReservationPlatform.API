using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventReservationPlatform.Core.Entities
{
    public class SocialMedia
    {
        public SocialMedia(int eventId, Event @event, string? site, string? instagram, string? facebook, string? whatsApp, string? others)
        {
            EventId = eventId;
            Event = @event;
            Site = site;
            Instagram = instagram;
            Facebook = facebook;
            WhatsApp = whatsApp;
            Others = others;
        }

        public Guid Id { get; set; }
        public int EventId { get; set; }
        public virtual Event Event { get; set; }
        public string? Site { get; set; }
        public string? Instagram { get; set; }
        public string? Facebook { get; set; }
        public string? WhatsApp { get; set; }
        public string? Others { get; set; }
    }
}
