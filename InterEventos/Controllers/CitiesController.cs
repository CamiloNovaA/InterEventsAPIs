using Microsoft.AspNetCore.Mvc;
using Models.Entities;
using Models.Interfaces;

namespace InterEventsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly ICitiesServices _citiesServices;

        public CitiesController(ICitiesServices citiesServices)
        {
            _citiesServices = citiesServices;
        }

        [HttpGet]
        [Route("GetCities")]
        public async Task<IActionResult> GetSuscriptions()
        {
            List<City> register = await _citiesServices.GetCities();
            return Ok(register);
        }
    }
}