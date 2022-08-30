namespace Cocktails.Models 
{
    public class AllergenIngredient 
    {
        public int AllergenId { get; set; }
        public Allergen? Allergen { get; set; }
        public int IngredientId { get; set; }
        public Ingredient? Ingredient { get; set; }
    }
}