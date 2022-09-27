using Cocktails.Models;
using Cocktails.Models.Request;


namespace Cocktails.Repositories
{

    public class IngredientsRepo 
    {
        private CocktailsContext _context = new CocktailsContext();

        public ICollection<AllergenIngredient> CreateAllergenIdList(CreateIngredientRequest request )
        {
            List<AllergenIngredient> allergenIngredient = new List<AllergenIngredient>();

            request.AllergenId.ForEach( allergen => 
            {AllergenIngredient newAllergenIngredient = new AllergenIngredient{
                AllergenId = allergen
            };
            allergenIngredient.Add(newAllergenIngredient);
            });

            return allergenIngredient;

        }

        public Ingredient Create(CreateIngredientRequest request )
        {

            
            Ingredient newIngredient = new Ingredient 
            {
                Name = request.Name,
                AllergenIngredient = CreateAllergenIdList(request),
                Availability = request.AvailabilityScoring
            };
            var insertedIngredient = _context.Ingredients.Add(newIngredient);
            _context.SaveChanges();
            return newIngredient;
        }

        public IEnumerable<Ingredient> FetchAllIngredients() 
        {
            return _context.Ingredients;
        }
    }
}