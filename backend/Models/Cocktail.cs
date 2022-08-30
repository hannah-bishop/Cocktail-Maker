namespace Cocktails.Models 
{
    public class Cocktail
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ImageUrl { get; set; }
        public ICollection<CocktailIngredient>? CocktailIngredient { get; set; }
        public Glass? Glass { get; set; }
        public bool Alcoholic { get; set; }
    }
}