using System.ComponentModel.DataAnnotations;

namespace Cocktails.Models.Request
{
    public class CreateAllergenRequest
    {
        [Required]
        [StringLength(70)]
        public string? Name { get; set ;}
    }
}