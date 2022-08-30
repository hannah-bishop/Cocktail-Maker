using Cocktails.Models;
using Cocktails.Models.Request;
using Cocktails.Repositories;

namespace Cocktails.Services 
{

     public class CocktailsService 
    {
        private CocktailsRepo _cocktailsRepo = new CocktailsRepo();

        public Cocktail Create(CreateCocktailRequest request)
        {
            return _cocktailsRepo.Create(request);
        }

        public List<Cocktail> GetCocktailByIngredientId(int ingredientId)
        {
            return _cocktailsRepo.GetCocktailByIngredientId(ingredientId);
        }

        public List<Cocktail> GetCocktailByIngredientIdList(List<int> ingredientIdList)
        {
            return _cocktailsRepo.GetCocktailByIngredientIdList(ingredientIdList);
        }

        public List<Cocktail> GetCocktailByIngredientIdListExclusive(List<int> ingredientIdList)
        {
            return _cocktailsRepo.GetCocktailByIngredientIdListExclusive(ingredientIdList);
        }
    }
}