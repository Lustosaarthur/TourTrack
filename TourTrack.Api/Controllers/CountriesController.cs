using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TourTrack.Api.Repositories.Main;

namespace TourTrack.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly ICountryRepository _repository;

        public CountriesController(ICountryRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public  IActionResult GetCountries()
        {
            try
            {
                var Países =  _repository.GetCountries();
                if (Países == null)
                    return NotFound();
                else
                    return Ok(Países);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{id:int}")]
        public IActionResult GetCountryById(int id)
        {
            try
            {
                var País = _repository.GetCountryById(id);
                if (País == null)
                    return NotFound();
                else
                    return Ok(País);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
