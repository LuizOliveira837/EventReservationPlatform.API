using EventReservationPlatform.Core.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace EventReservationPlatform.API.Controllers
{
    [ApiController]
    [Route("api/v1")]
    public class RoomController : ControllerBase
    {
        public RoomController()
        {
            
        }


        [HttpGet]
        [Route("Rooms")]
        public ActionResult GetAll()
        {
            return Ok("Ola mundo");
        }

        [HttpGet]
        [Route("Rooms/{id}")]
        public ActionResult Get(Guid id)
        {
            return Ok("Ola mundo");
        }

        [HttpPost]
        [Route("Rooms/New/{id}")]
        public ActionResult Post(RequestNewRoomDto requestNewRoomDto)
        {
            return Ok(requestNewRoomDto);
        }

        [HttpPut]
        [Route("Rooms/Update/{id}")]
        public ActionResult Update(RequestUpdateRoomDto requestUpdateRoomDto)
        {
            return Ok(requestUpdateRoomDto);
        }

        [HttpDelete]
        [Route("Rooms/Delete/{id}")]
        public ActionResult Delete(RequestDeleteRoomDto requestUpdateRoomDto)
        {
            return Ok(requestUpdateRoomDto);
        }
    }
}
