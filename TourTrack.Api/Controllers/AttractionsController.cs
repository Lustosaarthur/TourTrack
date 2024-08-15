using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TourTrack.Api.Repositories.Main;
using TourTrack.Models;

namespace TourTrack.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttractionsController : ControllerBase
    {
        private readonly IAttractionRepository _repository;

        public AttractionsController(IAttractionRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAttractions()
        {
            try
            {
                var pontosTuristicos = _repository.GetAttractions();
                if(pontosTuristicos == null)
                 return NotFound();
                else
                    return Ok(pontosTuristicos);
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{CountryId}/GetAttractionByCountry")]
        public IActionResult GetAttractionByCountry(int CountryId)
        {
            try
            {
                var pontoTuristicos = _repository.GetAttractionByCountry(CountryId);
                if (pontoTuristicos == null)
                    return NotFound();
                else
                    return Ok(pontoTuristicos);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{id:int}")]
        public IActionResult GetAttractionById(int id)
        {
            try
            {
                var pontoTuristico = _repository.GetAttractionById(id);
                if (pontoTuristico == null)
                    return NotFound();
                else
                    return Ok(pontoTuristico);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{rating}/GetAttractionsByRating")]
        public IActionResult GetAttractionsByRating(double rating)
        {
            try
            {
                var pontosTuristicos = _repository.GetAttractionsByRating(rating);
                if (pontosTuristicos == null)
                    return NotFound();
                else
                    return Ok(pontosTuristicos);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("GetRecomended")]
        public IActionResult GetRecomendedAttractions()
        {
            try
            {
                var pontosTuristicos = _repository.GetRecomendedAttractions();
                if (pontosTuristicos == null)
                    return NotFound();
                else
                    return Ok(pontosTuristicos);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
