using Microsoft.AspNetCore.Mvc;
using Cocktails.Services;
using Cocktails.Models.Request;
using static Cocktails.Models.Response.IngredientsListItemResponse;
using Microsoft.AspNetCore.Cors;

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

        [EnableCors("MyCorsPolicy")]
        [HttpGet("")]
        public ActionResult<IngredientListResponse> FetchAllIngredients() 
        {
          
            var ingredientList = _ingredients.FetchAllIngredients();

            return new IngredientListResponse(ingredientList);

        }
    }

}