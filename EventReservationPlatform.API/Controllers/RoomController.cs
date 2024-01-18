using Microsoft.AspNetCore.Mvc;

namespace EventReservationPlatform.API.Controllers
{
    [ApiController]
    [Route("api/room")]
    public class RoomController : ControllerBase
    {
        public RoomController()
        {
            
        }


        [HttpGet]
        public ActionResult Index()
        {
            return Ok("Ola mundo");
        }
    }
}
