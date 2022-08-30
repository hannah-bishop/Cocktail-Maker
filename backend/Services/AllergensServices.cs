using Cocktails.Models;
using Cocktails.Models.Request;
using Cocktails.Repositories;

namespace Cocktails.Services 
{

     public class AllergensService 
    {
        private AllergensRepo _allergenRepo = new AllergensRepo();

        public Allergen Create(CreateAllergenRequest request)
        {
            return _allergenRepo.Create(request);
        }
    }
}