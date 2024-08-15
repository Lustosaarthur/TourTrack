using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TourTrack.Api.Repositories.Main;
using TourTrack.Models;

namespace TourTrack.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccommodationController : ControllerBase
    {
        private readonly IAccommodationRepository _repository;

        public AccommodationController(IAccommodationRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAccommodations()
        {
            try
            {
                var hoteis = _repository.GetAccommodations();
                if(hoteis == null)
                    return NotFound();
                else
                    return Ok(hoteis);
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);  
            }
        }

        [HttpGet("{id:int}")]
        public IActionResult GetAccommodationById(int id)
        {
            try
            {
                var hotel = _repository.GetAccommodationById(id);
                if(hotel == null)
                    return NotFound();
                else
                    return Ok(hotel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{AttractionId}/GetAttractionByCountry")]
        public IActionResult GetAccommodationByAttraction(int AttractionId)
        {
            try
            {
                var hotelPorAtração = _repository.GetAccommodationByAttraction(AttractionId);
                if(hotelPorAtração == null)
                    return NotFound();
                else
                    return Ok(hotelPorAtração);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        } 

        [HttpGet("GetRandomHotels")]
        public IActionResult GetRandomHotels()
        {
            try
            {
                var hotelPorAtração = _repository.GetRandomHotels();
                if (hotelPorAtração == null)
                    return NotFound();
                else
                    return Ok(hotelPorAtração);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
