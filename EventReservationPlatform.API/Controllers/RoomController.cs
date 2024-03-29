﻿using EventReservationPlatform.Core.Dtos.Room;
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
        public async Task<ActionResult> GetById(Guid id)
        {
            var room = await RoomService.GetById(id);

            return Ok(room);
        }

        [HttpPost]
        [Route("Rooms")]
        public async Task<ActionResult> Post(RequestNewRoomDto requestNewRoomDto)
        {
            var result = await RoomService.CreateRoom(requestNewRoomDto);

            return CreatedAtAction(nameof(GetById), new { id = result.Id }, requestNewRoomDto);
        }

        [HttpPut]
        [Route("Rooms")]
        public async Task<ActionResult> Update(RequestUpdateRoomDto requestUpdateRoomDto)
        {
            await RoomService.UpdateRoom(requestUpdateRoomDto);
            return Ok();
        }

        [HttpPut]
        [Route("Rooms/Toggle")]
        public async Task<ActionResult> Toggle(RequestToggleRoomDto id)
        {
            await RoomService.ToogleStatus(id);
            return Ok();
        }

    }
}
