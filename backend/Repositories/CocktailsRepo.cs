using Cocktails.Models;
using Cocktails.Models.Request;
using Microsoft.EntityFrameworkCore;

namespace Cocktails.Repositories
{

    public class CocktailsRepo 
    {
        private CocktailsContext _context = new CocktailsContext();

        public ICollection<CocktailIngredient> CreateIngredientsIdList(CreateCocktailRequest request )
        {
            List<CocktailIngredient> cocktailIngredient = new List<CocktailIngredient>();

            request.IngredientId.ForEach( ingredient => 
            {CocktailIngredient newCocktailIngredient = new CocktailIngredient{
                IngredientId = ingredient
            };
            cocktailIngredient.Add(newCocktailIngredient);
            });

            return cocktailIngredient;

        }

        public Cocktail Create(CreateCocktailRequest request )
        {
           
            Cocktail newCocktail = new Cocktail 
            {
                Name = request.Name,
                CocktailIngredient = CreateIngredientsIdList(request),
                ImageUrl = request.ImageUrl,
                Alcoholic = request.isAlcoholic
            };
            Glass glass = _context.Glasses.Where(g => g.Id==request.GlassId).Single();
            newCocktail.Glass = glass;

            var insertedIngredient = _context.Cocktails.Add(newCocktail);
            _context.SaveChanges();
            return newCocktail;
        }

        public List<Cocktail> GetCocktailByIngredientId(int ingredientId)
        {
            List<int> cocktailIdList = new List<int>();

            List<CocktailIngredient> cocktail =  _context.CocktailIngredient
                .Where(i => i.IngredientId ==ingredientId).ToList();

            for (int i = 0; i < cocktail.Count ; i++)
            {
                int cocktailid = cocktail[i].CocktailId;
                cocktailIdList.Add(cocktailid);
            }
            
            List<Cocktail> cocktailsList = new List<Cocktail>();
            for (int i = 0; i < cocktailIdList.Count; i++)
            {
                Cocktail cocktailForList =  _context.Cocktails.Where(c => c.Id == cocktailIdList[i]).Include(g => g.Glass).Single();
                cocktailsList.Add(cocktailForList);
            }

            return cocktailsList;
            
        }

        public List<Cocktail> GetCocktailByIngredientIdList(List<int> ingredientIdList)
        {
            List<int> cocktailIdList = new List<int>();

            ingredientIdList.ForEach(ingredientId => {
                List<CocktailIngredient> cocktail =  _context.CocktailIngredient
                    .Where(i => i.IngredientId == ingredientId).ToList();

            for (int i = 0; i < cocktail.Count ; i++)
            {
                int cocktailid = cocktail[i].CocktailId;
                cocktailIdList.Add(cocktailid);
            }
            });
           
            
            List<Cocktail> cocktailsList = new List<Cocktail>();
            List<int> uniqueList = cocktailIdList.Distinct().ToList();
            while( uniqueList.Count >0)
            {
                Cocktail cocktailForList =  _context.Cocktails.Where(c => c.Id == uniqueList[0]).Include(g => g.Glass).Single();
                cocktailsList.Add(cocktailForList);
                uniqueList.Remove(uniqueList[0]);
            }

            return cocktailsList;
            
        }

        public List<Cocktail> GetCocktailByIngredientIdListExclusive(List<int> ingredientIdList)
        {
            List<int> cocktailIdList = new List<int>();

            ingredientIdList.ForEach(ingredientId => {
                List<CocktailIngredient> cocktail =  _context.CocktailIngredient
                    .Where(i => i.IngredientId == ingredientId).ToList();

                    for (int i = 0; i < cocktail.Count ; i++)
                    {
                        int cocktailid = cocktail[i].CocktailId;
                        cocktailIdList.Add(cocktailid);
                    }
                });
          
                List<int> completeCocktails = new List<int>();
                cocktailIdList.ForEach( cocktailId => {
                    List<int> listOfCocktailId = cocktailIdList.FindAll(element => element == cocktailId);
                    List<CocktailIngredient> ingredientsForCocktail = _context.CocktailIngredient
                    .Where(c => c.CocktailId == cocktailId).ToList();
                    if (listOfCocktailId.Count() == ingredientsForCocktail.Count())
                    {
                        completeCocktails.Add(listOfCocktailId[0]);
                    };
            });

            List<Cocktail> cocktailsList = new List<Cocktail>();
            List<int> uniqueList = completeCocktails.Distinct().ToList();
            while( uniqueList.Count >0)
            {
                Cocktail cocktailForList =  _context.Cocktails
                .Where(c => c.Id == uniqueList[0])
                .Include(g => g.Glass)
                .Single();
                cocktailsList.Add(cocktailForList);
                uniqueList.Remove(uniqueList[0]);
            }

            return cocktailsList;
            
        }
    }
}