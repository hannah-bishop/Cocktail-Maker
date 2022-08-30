using Cocktails.Models;
using Cocktails.Models.Request;
using Cocktails.Repositories;

namespace Cocktails.Services 
{

     public class GlassesService 
    {
        private GlassesRepo _glassRepo = new GlassesRepo();

        public Glass Create(CreateGlassRequest request)
        {
            return _glassRepo.Create(request);
        }
    }
}