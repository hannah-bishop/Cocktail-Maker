using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    public partial class FixingInitalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Allergens_Ingredients_IngredientId",
                table: "Allergens");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Cocktails_CocktailId",
                table: "Ingredients");

            migrationBuilder.DropIndex(
                name: "IX_Ingredients_CocktailId",
                table: "Ingredients");

            migrationBuilder.DropIndex(
                name: "IX_Allergens_IngredientId",
                table: "Allergens");

            migrationBuilder.DropColumn(
                name: "CocktailId",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "IngredientId",
                table: "Allergens");

            migrationBuilder.CreateTable(
                name: "AllergenIngredient",
                columns: table => new
                {
                    AllergensId = table.Column<int>(type: "int", nullable: false),
                    IngredientsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllergenIngredient", x => new { x.AllergensId, x.IngredientsId });
                    table.ForeignKey(
                        name: "FK_AllergenIngredient_Allergens_AllergensId",
                        column: x => x.AllergensId,
                        principalTable: "Allergens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AllergenIngredient_Ingredients_IngredientsId",
                        column: x => x.IngredientsId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CocktailIngredient",
                columns: table => new
                {
                    CocktailsId = table.Column<int>(type: "int", nullable: false),
                    IngredientsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CocktailIngredient", x => new { x.CocktailsId, x.IngredientsId });
                    table.ForeignKey(
                        name: "FK_CocktailIngredient_Cocktails_CocktailsId",
                        column: x => x.CocktailsId,
                        principalTable: "Cocktails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CocktailIngredient_Ingredients_IngredientsId",
                        column: x => x.IngredientsId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AllergenIngredient_IngredientsId",
                table: "AllergenIngredient",
                column: "IngredientsId");

            migrationBuilder.CreateIndex(
                name: "IX_CocktailIngredient_IngredientsId",
                table: "CocktailIngredient",
                column: "IngredientsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllergenIngredient");

            migrationBuilder.DropTable(
                name: "CocktailIngredient");

            migrationBuilder.AddColumn<int>(
                name: "CocktailId",
                table: "Ingredients",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IngredientId",
                table: "Allergens",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_CocktailId",
                table: "Ingredients",
                column: "CocktailId");

            migrationBuilder.CreateIndex(
                name: "IX_Allergens_IngredientId",
                table: "Allergens",
                column: "IngredientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Allergens_Ingredients_IngredientId",
                table: "Allergens",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Cocktails_CocktailId",
                table: "Ingredients",
                column: "CocktailId",
                principalTable: "Cocktails",
                principalColumn: "Id");
        }
    }
}
