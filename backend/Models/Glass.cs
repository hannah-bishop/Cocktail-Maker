namespace Cocktails.Models 
{
    public class Glass
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ImageUrl { get; set; }
        public List<Cocktail>? Cocktails { get; set; }
    }
}