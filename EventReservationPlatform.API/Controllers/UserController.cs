using EventReservationPlatform.Core.Dtos.UserDtos;
using EventReservationPlatform.Core.Interface.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EventReservationPlatform.API.Controllers
{
    [ApiController]
    [Route("api/v1/Users")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        [Authorize]
        [Route("/{id}")]
        public async Task<ActionResult> Get(Guid id)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> Post(RequestNewUserDTO requestNewUserDTO)
        {
            var id = await _service.CreateUser(requestNewUserDTO);

            return Ok(requestNewUserDTO);
        }

        [HttpPost]
        [Route("/autentication")]
        public async Task<ActionResult> Auth(RequestLoginUserDTO requestLoginUserDTO)
        {

            var token = await _service.Autentication(requestLoginUserDTO);
            return Ok(token);
        }

        [HttpPut]
        public async Task<ActionResult> Put()
        {
            return Ok();
        }

    }
}
