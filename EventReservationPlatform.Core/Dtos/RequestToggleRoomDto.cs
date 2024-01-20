using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventReservationPlatform.Core.Dtos
{
    public class RequestToggleRoomDto
    {
        public RequestToggleRoomDto(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
