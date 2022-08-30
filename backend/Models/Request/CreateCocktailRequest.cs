using System.ComponentModel.DataAnnotations;

namespace Cocktails.Models.Request
{
    public class CreateCocktailRequest
    {
        [Required]
        [StringLength(70)]
        public string? Name { get; set ;}
        [Required]
        public string? ImageUrl { get; set ;}
        [Required]
        public int GlassId { get; set; }
        [Required]
        public bool isAlcoholic { get; set; }
        [Required]
        public List<int> IngredientId { get; set ;}

    }
}