using Cocktails.Models;
using Cocktails.Models.Request;
using Cocktails.Repositories;

namespace Cocktails.Services 
{

     public class IngredientsService 
    {
        private IngredientsRepo _ingredientsRepo = new IngredientsRepo();

        public Ingredient Create(CreateIngredientRequest request)
        {
            return _ingredientsRepo.Create(request);
        }

        public IEnumerable<Ingredient> FetchAllIngredients()
        {
            return _ingredientsRepo.FetchAllIngredients();
        }
    }
}