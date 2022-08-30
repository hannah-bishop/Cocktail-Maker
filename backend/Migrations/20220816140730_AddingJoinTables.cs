using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    public partial class AddingJoinTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AllergenIngredient_Allergens_AllergensId",
                table: "AllergenIngredient");

            migrationBuilder.DropForeignKey(
                name: "FK_AllergenIngredient_Ingredients_IngredientsId",
                table: "AllergenIngredient");

            migrationBuilder.DropForeignKey(
                name: "FK_CocktailIngredient_Cocktails_CocktailsId",
                table: "CocktailIngredient");

            migrationBuilder.DropForeignKey(
                name: "FK_CocktailIngredient_Ingredients_IngredientsId",
                table: "CocktailIngredient");

            migrationBuilder.RenameColumn(
                name: "IngredientsId",
                table: "CocktailIngredient",
                newName: "IngredientId");

            migrationBuilder.RenameColumn(
                name: "CocktailsId",
                table: "CocktailIngredient",
                newName: "CocktailId");

            migrationBuilder.RenameIndex(
                name: "IX_CocktailIngredient_IngredientsId",
                table: "CocktailIngredient",
                newName: "IX_CocktailIngredient_IngredientId");

            migrationBuilder.RenameColumn(
                name: "IngredientsId",
                table: "AllergenIngredient",
                newName: "IngredientId");

            migrationBuilder.RenameColumn(
                name: "AllergensId",
                table: "AllergenIngredient",
                newName: "AllergenId");

            migrationBuilder.RenameIndex(
                name: "IX_AllergenIngredient_IngredientsId",
                table: "AllergenIngredient",
                newName: "IX_AllergenIngredient_IngredientId");

            migrationBuilder.AddForeignKey(
                name: "FK_AllergenIngredient_Allergens_AllergenId",
                table: "AllergenIngredient",
                column: "AllergenId",
                principalTable: "Allergens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AllergenIngredient_Ingredients_IngredientId",
                table: "AllergenIngredient",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CocktailIngredient_Cocktails_CocktailId",
                table: "CocktailIngredient",
                column: "CocktailId",
                principalTable: "Cocktails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CocktailIngredient_Ingredients_IngredientId",
                table: "CocktailIngredient",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AllergenIngredient_Allergens_AllergenId",
                table: "AllergenIngredient");

            migrationBuilder.DropForeignKey(
                name: "FK_AllergenIngredient_Ingredients_IngredientId",
                table: "AllergenIngredient");

            migrationBuilder.DropForeignKey(
                name: "FK_CocktailIngredient_Cocktails_CocktailId",
                table: "CocktailIngredient");

            migrationBuilder.DropForeignKey(
                name: "FK_CocktailIngredient_Ingredients_IngredientId",
                table: "CocktailIngredient");

            migrationBuilder.RenameColumn(
                name: "IngredientId",
                table: "CocktailIngredient",
                newName: "IngredientsId");

            migrationBuilder.RenameColumn(
                name: "CocktailId",
                table: "CocktailIngredient",
                newName: "CocktailsId");

            migrationBuilder.RenameIndex(
                name: "IX_CocktailIngredient_IngredientId",
                table: "CocktailIngredient",
                newName: "IX_CocktailIngredient_IngredientsId");

            migrationBuilder.RenameColumn(
                name: "IngredientId",
                table: "AllergenIngredient",
                newName: "IngredientsId");

            migrationBuilder.RenameColumn(
                name: "AllergenId",
                table: "AllergenIngredient",
                newName: "AllergensId");

            migrationBuilder.RenameIndex(
                name: "IX_AllergenIngredient_IngredientId",
                table: "AllergenIngredient",
                newName: "IX_AllergenIngredient_IngredientsId");

            migrationBuilder.AddForeignKey(
                name: "FK_AllergenIngredient_Allergens_AllergensId",
                table: "AllergenIngredient",
                column: "AllergensId",
                principalTable: "Allergens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AllergenIngredient_Ingredients_IngredientsId",
                table: "AllergenIngredient",
                column: "IngredientsId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CocktailIngredient_Cocktails_CocktailsId",
                table: "CocktailIngredient",
                column: "CocktailsId",
                principalTable: "Cocktails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CocktailIngredient_Ingredients_IngredientsId",
                table: "CocktailIngredient",
                column: "IngredientsId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
