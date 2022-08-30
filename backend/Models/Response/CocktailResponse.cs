namespace Cocktails.Models.Response
{
    public class CocktailResponse
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Glass? Glass { get; set; }
        public string? ImageUrl { get; set; }
        public bool Alcoholic { get; set; }

        public CocktailResponse(Cocktail cocktail)
        {
            Id = cocktail.Id;
            Name = cocktail.Name;
            ImageUrl = cocktail.ImageUrl;
            Glass = cocktail.Glass;
            Alcoholic =cocktail.Alcoholic;
        }
    }
}