using Microsoft.AspNetCore.Mvc;
using Cocktails.Services;
using Cocktails.Models.Request;
using Cocktails.Models.Response;

namespace Cocktails.Controllers 
{
    [ApiController]
    [Route("/cocktails")]

    public class CocktailController : Controller
    {
        private readonly ILogger<CocktailController> _logger;
        private readonly CocktailsService _cocktails;

        public CocktailController(ILogger<CocktailController> logger){
            _logger = logger;
            _cocktails = new CocktailsService();
        }

        [HttpPost("")]
        public ActionResult<CocktailResponse> CreateCocktail([FromBody] CreateCocktailRequest cocktailRequest) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            var newCocktail = _cocktails.Create(cocktailRequest);

            return new CocktailResponse(newCocktail);

        }

        [HttpGet("{id}")]
        public IActionResult GetCocktailByIngredientId([FromRoute] int id) {

            var cocktailList = _cocktails.GetCocktailByIngredientId(id);

            return Created("/api", cocktailList);

        }

        [HttpGet()]
        public IActionResult GetCocktailByIngredientIdList([FromQuery] int[] id) {

            List<int> listIds = id.ToList();
            var cocktailList = _cocktails.GetCocktailByIngredientIdList(listIds);

            return Created("/api", cocktailList);

        }

        [HttpGet("exclusive")]
        public IActionResult GetCocktailByIngredientIdListExclusive([FromQuery] int[] id) {

            List<int> listIds = id.ToList();
            var cocktailList = _cocktails.GetCocktailByIngredientIdListExclusive(listIds);

            return Created("/api", cocktailList);

        }
    }


}