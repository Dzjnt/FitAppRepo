using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FitApp.DataAccess.Migrations
{
    public partial class UpdateProductIngredientRecipe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IngredientId",
                table: "Recipes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Recipes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Carbs",
                table: "Ingredients",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Fats",
                table: "Ingredients",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Ingredients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Ingredients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "Protein",
                table: "Ingredients",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "RecipeId",
                table: "Ingredients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "Ingredients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_IngredientId",
                table: "Recipes",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_ProductId",
                table: "Recipes",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_IngredientId",
                table: "Product",
                column: "IngredientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Ingredients_IngredientId",
                table: "Recipes",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Product_ProductId",
                table: "Recipes",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Ingredients_IngredientId",
                table: "Recipes");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Product_ProductId",
                table: "Recipes");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_IngredientId",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_ProductId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "IngredientId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Carbs",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "Fats",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "Protein",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "RecipeId",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "Ingredients");
        }
    }
}
