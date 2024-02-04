using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventReservationPlatform.Core.Dtos.LocationDtos
{
    public class ResponseViewLocationDto
    {
        public ResponseViewLocationDto(string cEP, string address, int number, string complement)
        {
            CEP = cEP;
            Address = address;
            Number = number;
            Complement = complement;
        }

        public string CEP { get; set; }
        public string Address { get; set; }
        public int Number { get; set; }
        public string Complement { get; set; }

    }
}
