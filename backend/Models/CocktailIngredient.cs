namespace Cocktails.Models 
{
    public class CocktailIngredient 
    {
        public int CocktailId { get; set; }
        public Cocktail? Cocktail { get; set; }
        public int IngredientId { get; set; }
        public Ingredient? Ingredient { get; set; }
    }
}