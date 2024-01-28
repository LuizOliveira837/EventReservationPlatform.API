using EventReservationPlatform.Core.Entities;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventReservationPlatform.Core.Dtos
{
    public class RequestUpdateRoomDto
    {
        [AdaptIgnore]
        public Guid Id { get; set; }
        public string RoomName { get; set; }
        public int Capacity { get; set; }
        public Guid LocationId { get; set; }

    }
}
