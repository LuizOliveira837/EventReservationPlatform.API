﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventReservationPlatform.Core.Dtos.UserDtos
{
    public class RequestLoginUserDTO
    {
        public  string Email { get; set; }
        public  string Password { get; set; }

        public RequestLoginUserDTO(string email, string password) {

            Email = email;
            Password = password;
        
        }
    }
}