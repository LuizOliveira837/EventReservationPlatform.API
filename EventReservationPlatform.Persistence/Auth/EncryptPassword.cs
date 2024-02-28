using EventReservationPlatform.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using Microsoft.IdentityModel.JsonWebTokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EventReservationPlatform.Persistence.Auth
{
    public static class EncryptPassword
    {
        public static string SecretKey = "THISISASECRETKEY";
        public static async Task<string> Encrypt(string password)
        {
            var encryptedPassword = BCrypt.Net.BCrypt.HashPassword(password,12);
            return encryptedPassword;
        } 


        public static async Task<bool> Verify(string password, string encryptedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, encryptedPassword);
        }

       

    }



}
