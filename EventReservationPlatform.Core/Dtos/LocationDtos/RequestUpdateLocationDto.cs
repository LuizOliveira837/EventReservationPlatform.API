using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventReservationPlatform.Core.Dtos.LocationDtos
{
    public class RequestUpdateLocationDto
    {
        public RequestUpdateLocationDto(Guid id, string cEP, string address, int number, string complement)
        {
            Id = id;
            CEP = cEP;
            Address = address;
            Number = number;
            Complement = complement;
        }

        public Guid Id { get; set; }
        public string CEP { get; set; }
        public string Address { get; set; }
        public int Number { get; set; }
        public string Complement { get; set; }
    }
}
