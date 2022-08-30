using Cocktails.Models;
using Cocktails.Models.Request;


namespace Cocktails.Repositories
{

    public class GlassesRepo 
    {
        private CocktailsContext _context = new CocktailsContext();

        public Glass Create(CreateGlassRequest request )
        {
            Glass newGlass = new Glass 
            {
                Name = request.Name,
                ImageUrl = request.ImageUrl 
            };
            var insertedGlass = _context.Glasses.Add(newGlass);
            _context.SaveChanges();
            return newGlass;
        }

        public Glass GetGlassById( int id) 
        {
            return _context.Glasses.Single( g => g.Id == id);
        }
    }
}