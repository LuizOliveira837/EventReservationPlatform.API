using EventReservationPlatform.Core.Dtos;
using EventReservationPlatform.Core.Interface.Services;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

namespace EventReservationPlatform.API.Controllers
{
    [ApiController]
    [Route("api/v1")]
    public class RoomController : ControllerBase
    {
        public IRoomService RoomService { get; set; }
        public RoomController(IRoomService roomService)
        {
            RoomService = roomService;
        }


        [HttpGet]
        [Route("Rooms")]
        public async Task<ActionResult> GetAll()
        {
            var rooms = await RoomService.GetAllRooms();

            return Ok(rooms);


        }

        [HttpGet]
        [Route("Rooms/{id}")]
        public async Task<ActionResult> Get(Guid id)
        {
            var room = await RoomService.GetById(id);

            return Ok(room);
        }

        [HttpPost]
        [Route("Rooms/New")]
        public async Task<ActionResult> Post(RequestNewRoomDto requestNewRoomDto)
        {
            var result = await RoomService.CreateRoom(requestNewRoomDto);

            return Ok(result.Id);
        }

        [HttpPut]
        [Route("Rooms/Update")]
        public async Task<ActionResult> Update(RequestUpdateRoomDto requestUpdateRoomDto)
        {
            await RoomService.UpdateRoom(requestUpdateRoomDto);
            return Ok();
        }

        [HttpPut]
        [Route("Rooms/Toggle/{id}")]
        public async Task<ActionResult> Toggle(Guid Id)
        {
            await RoomService.ToogleStatus(new RequestToggleRoomDto(Id));
            return Ok();
        }

    }
}
