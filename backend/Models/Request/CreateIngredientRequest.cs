using System.ComponentModel.DataAnnotations;

namespace Cocktails.Models.Request
{
    public class CreateIngredientRequest
    {
        [Required]
        [StringLength(70)]
        public string? Name { get; set ;}

        public List<int> AllergenId { get; set ;}

        [Required]
        [Range (1,5)]
        public int AvailabilityScoring { get; set ;}
    }
}