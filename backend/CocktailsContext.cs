using Microsoft.EntityFrameworkCore;
using Cocktails.Models;

namespace Cocktails
{
    public class CocktailsContext : DbContext
    {
        public DbSet<Allergen> Allergens { get; set; }
        public DbSet<Cocktail> Cocktails { get; set; }
        public DbSet<Glass> Glasses { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<AllergenIngredient> AllergenIngredient { get; set; }
        public DbSet<CocktailIngredient> CocktailIngredient { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LocalHost;Database=Cocktails;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AllergenIngredient>()
                .HasKey(bc => new { bc.AllergenId, bc.IngredientId });  
            modelBuilder.Entity<AllergenIngredient>()
                .HasOne(bc => bc.Allergen)
                .WithMany(b => b.AllergenIngredient)
                .HasForeignKey(bc => bc.AllergenId);  
            modelBuilder.Entity<AllergenIngredient>()
                .HasOne(bc => bc.Ingredient)
                .WithMany(c => c.AllergenIngredient)
                .HasForeignKey(bc => bc.IngredientId);

            modelBuilder.Entity<CocktailIngredient>()
                .HasKey(bc => new { bc.CocktailId, bc.IngredientId });  
            modelBuilder.Entity<CocktailIngredient>()
                .HasOne(bc => bc.Cocktail)
                .WithMany(b => b.CocktailIngredient)
                .HasForeignKey(bc => bc.CocktailId);  
            modelBuilder.Entity<CocktailIngredient>()
                .HasOne(bc => bc.Ingredient)
                .WithMany(c => c.CocktailIngredient)
                .HasForeignKey(bc => bc.IngredientId);
        

            
        }
        
    }
}