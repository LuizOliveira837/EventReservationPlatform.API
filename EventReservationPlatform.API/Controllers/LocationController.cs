using EventReservationPlatform.Application.Services;
using EventReservationPlatform.Core.Dtos.LocationDtos;
using EventReservationPlatform.Core.Interface.Services;
using Microsoft.AspNetCore.Mvc;

namespace EventReservationPlatform.API.Controllers
{
    [ApiController]
    [Route("api/v1/locations")]
    public class LocationController : Controller
    {
        private readonly ILocationService _service;

        public LocationController(ILocationService service)
        {
            _service = service;
            
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return View();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var locationView = await _service.GetByIdAsync(id);
            return Ok(locationView);
        }

        [HttpPost]
        public async Task<IActionResult> Post(RequestNewLocationDto request)
        {
            var id = await _service.CreateLocation(request);

            return CreatedAtAction(nameof(GetById), new { id }, request);
        }


        [HttpPut]
        public async Task<IActionResult> Post(RequestUpdateLocationDto request)
        {
            await _service.UpdateLocation(request);

            return Ok();

        }
    }
}
