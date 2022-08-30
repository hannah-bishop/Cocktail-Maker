namespace Cocktails.Models 
{
    public class Allergen 
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<AllergenIngredient>? AllergenIngredient { get; set; }
    }
}