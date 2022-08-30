using Microsoft.AspNetCore.Mvc;
using Cocktails.Services;
using Cocktails.Models.Request;

namespace Cocktails.Controllers 
{
    [ApiController]
    [Route("/allergens")]

    public class AllergenController : Controller
    {
        private readonly ILogger<AllergenController> _logger;
        private readonly AllergensService _allergens;

        public AllergenController(ILogger<AllergenController> logger){
            _logger = logger;
            _allergens = new AllergensService();
        }

        public IActionResult CreateAllergen([FromBody] CreateAllergenRequest allergenRequest) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            var newAllergen = _allergens.Create(allergenRequest);

            return Created("/api", newAllergen);

        }
    }


}