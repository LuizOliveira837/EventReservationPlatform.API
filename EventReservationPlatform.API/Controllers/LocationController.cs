using EventReservationPlatform.Application.Services;
using EventReservationPlatform.Core.Dtos.LocationDtos;
using EventReservationPlatform.Core.Interface.Services;
using Microsoft.AspNetCore.Mvc;

namespace EventReservationPlatform.API.Controllers
{
    [ApiController]
    [Route("api/v1")]
    public class LocationController : Controller
    {
        private readonly ILocationService _service;

        public LocationController(ILocationService service)
        {
            _service = service;
            
        }
        [HttpGet]
        [Route("/locations")]
        public IActionResult GetAll()
        {
            return View();
        }

        [HttpGet]
        [Route("/locations/{id}")]
        public IActionResult GetById(Guid id)
        {
            return Ok();
        }

        [HttpPost]
        [Route("/locations/New")]
        public async Task<IActionResult> Post(RequestNewLocationDto request)
        {
            var id = await _service.CreateLocation(request);
            return Ok(id);
        }
    }
}
