namespace Cocktails.Models 
{
    public class Ingredient
    {
        public int Id { get; set; }

        public string? Name {  get; set; }

        public ICollection<AllergenIngredient>? AllergenIngredient { get; set; }

        public ICollection<CocktailIngredient>? CocktailIngredient { get; set; }

        public int Availability { get; set; }
    }
}