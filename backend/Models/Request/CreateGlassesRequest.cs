using System.ComponentModel.DataAnnotations;

namespace Cocktails.Models.Request
{
    public class CreateGlassRequest
    {
        [Required]
        [StringLength(70)]
        public string? Name { get; set ;}

        [Required]
        public string? ImageUrl { get; set; }
    }
}