using EventReservationPlatform.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventReservationPlatform.Core.Dtos.UserDtos
{
    public class RequestNewUserDTO
    {
        public RequestNewUserDTO(string name, string lastName, string email, string cellPhone, string password, StatusEntity status)
        {
            Name = name;
            LastName = lastName;
            Email = email;
            CellPhone = cellPhone;
            Password = password;
            Status = status;
        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string CellPhone { get; set; }
        public string Password { get; set; }
        public StatusEntity Status { get; set; }
    }
}
