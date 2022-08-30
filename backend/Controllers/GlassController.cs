using Microsoft.AspNetCore.Mvc;
using Cocktails.Services;
using Cocktails.Models.Request;

namespace Cocktails.Controllers 
{
    [ApiController]
    [Route("/glasses")]

    public class GlassController : Controller
    {
        private readonly ILogger<GlassController> _logger;
        private readonly GlassesService _glasses;

        public GlassController(ILogger<GlassController> logger){
            _logger = logger;
            _glasses = new GlassesService();
        }

        public IActionResult CreateGlass([FromBody] CreateGlassRequest glassRequest) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            var newGlasses = _glasses.Create(glassRequest);

            return Created("/api", newGlasses);

        }
    }


}