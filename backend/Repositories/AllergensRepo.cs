using Cocktails.Models;
using Cocktails.Models.Request;


namespace Cocktails.Repositories
{

    public class AllergensRepo 
    {
        private CocktailsContext _context = new CocktailsContext();

        public Allergen Create(CreateAllergenRequest request )
        {
            Allergen newAllergen = new Allergen 
            {
                Name = request.Name 
            };
            var insertedAllergen = _context.Allergens.Add(newAllergen);
            _context.SaveChanges();
            return newAllergen;
        }
    }
}