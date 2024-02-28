using EventReservationPlatform.Core.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EventReservationPlatform.Persistence.Auth
{
    public  class Autenticate
    {
        private  IConfiguration _configuration;


        public Autenticate(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<string> GenerationToken(User user)
        {
            var secretKeyInBinary = Encoding.UTF8.GetBytes(_configuration["jwt:SecretKey"]);

            var skey = new SymmetricSecurityKey(secretKeyInBinary);

            var SignedCredential = new SigningCredentials(skey, SecurityAlgorithms.HmacSha256Signature);

            var claims = new ClaimsIdentity(new[]
            {
                 new Claim("Name",user.Name),
                 new Claim("Email",user.Email)
            });

            var expires = DateTime.UtcNow.AddDays(1);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = claims,
                Expires = expires,
                Issuer = "EventReservationAPI",
                SigningCredentials = SignedCredential,
            };
            //initiate the token handler 
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenJwt = tokenHandler.CreateToken(tokenDescriptor);
            var token = tokenHandler.WriteToken(tokenJwt);

            return token;
        }
    }
}
