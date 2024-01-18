using EventReservationPlatform.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EventReservationPlatform.Core.Entities
{
    public class Participant : User
    {
        public Participant(string name, string lastName, string email, string cellPhone, string Password, StatusEntity status, Enterprise enterprise, Credential credentials)
            : base(name, lastName, email, cellPhone, Password, status)
        {
            Enterprise = enterprise;
            this.credentials = credentials;
        }

        public Enterprise Enterprise { get; set; }

        public Credential credentials { get; set; }



    }
}
