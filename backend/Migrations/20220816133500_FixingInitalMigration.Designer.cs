// <auto-generated />
using System;
using Cocktails;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace backend.Migrations
{
    [DbContext(typeof(CocktailsContext))]
    [Migration("20220816133500_FixingInitalMigration")]
    partial class FixingInitalMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AllergenIngredient", b =>
                {
                    b.Property<int>("AllergensId")
                        .HasColumnType("int");

                    b.Property<int>("IngredientsId")
                        .HasColumnType("int");

                    b.HasKey("AllergensId", "IngredientsId");

                    b.HasIndex("IngredientsId");

                    b.ToTable("AllergenIngredient");
                });

            modelBuilder.Entity("CocktailIngredient", b =>
                {
                    b.Property<int>("CocktailsId")
                        .HasColumnType("int");

                    b.Property<int>("IngredientsId")
                        .HasColumnType("int");

                    b.HasKey("CocktailsId", "IngredientsId");

                    b.HasIndex("IngredientsId");

                    b.ToTable("CocktailIngredient");
                });

            modelBuilder.Entity("Cocktails.Models.Allergen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Allergens");
                });

            modelBuilder.Entity("Cocktails.Models.Cocktail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Alcoholic")
                        .HasColumnType("bit");

                    b.Property<int?>("GlassId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GlassId");

                    b.ToTable("Cocktails");
                });

            modelBuilder.Entity("Cocktails.Models.Glass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Glasses");
                });

            modelBuilder.Entity("Cocktails.Models.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Availability")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("AllergenIngredient", b =>
                {
                    b.HasOne("Cocktails.Models.Allergen", null)
                        .WithMany()
                        .HasForeignKey("AllergensId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cocktails.Models.Ingredient", null)
                        .WithMany()
                        .HasForeignKey("IngredientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CocktailIngredient", b =>
                {
                    b.HasOne("Cocktails.Models.Cocktail", null)
                        .WithMany()
                        .HasForeignKey("CocktailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cocktails.Models.Ingredient", null)
                        .WithMany()
                        .HasForeignKey("IngredientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cocktails.Models.Cocktail", b =>
                {
                    b.HasOne("Cocktails.Models.Glass", "Glass")
                        .WithMany("Cocktails")
                        .HasForeignKey("GlassId");

                    b.Navigation("Glass");
                });

            modelBuilder.Entity("Cocktails.Models.Glass", b =>
                {
                    b.Navigation("Cocktails");
                });
#pragma warning restore 612, 618
        }
    }
}
