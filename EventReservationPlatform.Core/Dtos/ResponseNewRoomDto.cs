using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventReservationPlatform.Core.Dtos
{
    public class ResponseNewRoomDto
    {

        public ResponseNewRoomDto(Guid id)
        {
            Id = id;
        }

        public ResponseNewRoomDto() { }

        public readonly Guid Id;


    }
}
