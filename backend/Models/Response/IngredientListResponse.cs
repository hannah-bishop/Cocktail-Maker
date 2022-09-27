namespace Cocktails.Models.Response 
{
    public class IngredientsListItemResponse 
    {
        public int Id { get; set; }
        public string? Name { get; set ;}
        public ICollection<AllergenIngredient> AllergenIngredient { get; set ;}
        public int AvailabilityScoring { get; set ;}
        
        public IngredientsListItemResponse( Ingredient ingredient )
        {
            Id = ingredient.Id;
            Name = ingredient.Name;
            AllergenIngredient = ingredient.AllergenIngredient;
            AvailabilityScoring = ingredient.Availability;
        }

        public class IngredientListResponse 
        {
            public List<IngredientsListItemResponse> IngredientsList { get; set; }
            
            public IngredientListResponse( IEnumerable<Ingredient> items)
            {
                IngredientsList = items.Select(item => new IngredientsListItemResponse(item)).ToList();
            }
        }
    }
}