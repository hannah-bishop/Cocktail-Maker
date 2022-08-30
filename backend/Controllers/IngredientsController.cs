using Microsoft.AspNetCore.Mvc;
using Cocktails.Services;
using Cocktails.Models.Request;

namespace Cocktails.Controllers 
{
    [ApiController]
    [Route("/ingredients")]

    public class IngredientController : Controller
    {
        private readonly ILogger<IngredientController> _logger;
        private readonly IngredientsService _ingredients;

        public IngredientController(ILogger<IngredientController> logger){
            _logger = logger;
            _ingredients = new IngredientsService();
        }

        public IActionResult CreateIngredient([FromBody] CreateIngredientRequest ingredientRequest) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            var newIngredient = _ingredients.Create(ingredientRequest);

            return Created("/api", newIngredient);

        }
    }


}