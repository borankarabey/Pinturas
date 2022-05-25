using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pinturas.DataAccess.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: true),
                    Discount = table.Column<double>(type: "float", nullable: true),
                    Descriptipn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Cubism" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Expressionism" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Impressionism" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Post-Impressionism" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Descriptipn", "Discount", "ImageUrl", "ModifiedDate", "Name", "Price" },
                values: new object[,]
                {
                 { 1, 2, null, 0.10, "Edvard Munch, National Gallery of Norway", "https://commons.wikimedia.org/wiki/File:Edvard_Munch_-_The_Scream_-_Google_Art_Project.jpg", null, "The Scream", 130.0},
                 { 2, 2, null, 0.15, "Amedeo Modigliani, Private Collection", "https://bayaiyi.com/wp-content/uploads/2020/06/Jeanne-Hebuterne-with-Necklace.jpg", null, "Jeanne Hébuterne with Hat and Necklace", 110.0},
                 { 3, 4, null, 0.10, "Vincent van Gogh, Museum of Modern Art", "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ea/Van_Gogh_-_Starry_Night_-_Google_Art_Project.jpg/1024px-Van_Gogh_-_Starry_Night_-_Google_Art_Project.jpg", null, "The Starry Night", 180.0},
                 { 4, 4, null, 0.05, "Paul Cezanne, Musee d'Orsay", "https://upload.wikimedia.org/wikipedia/commons/6/69/Les_Joueurs_de_cartes%2C_par_Paul_C%C3%A9zanne.jpg", null, "Les Joueurs de Cartes", 190.0},
                 { 5, 1, null, 0.10, "Pablo Picasso, Museo Nacional Centro de Arte Reina Sofia", "https://upload.wikimedia.org/wikipedia/tr/7/7f/Picasso_Guernica.jpg", null, "Guernica", 220.0},
                 { 6, 1, null, 0.15, "Diego Rivera, MALBA", "https://upload.wikimedia.org/wikipedia/commons/1/11/Ram%C3%B3nG%C3%B3mezdelaSerna.JPG", null, "Portrait of Ramón Gómez de la Serna", 105.0},
                 { 7, 3, null, 0.05, "Claude Monet, Metropolitan Museum of Art", "https://upload.wikimedia.org/wikipedia/commons/a/a0/Claude_Monet_-_Jardin_%C3%A0_Sainte-Adresse.jpg", null, "Garden at Sainte-Adresse", 160.0},
                 { 8, 3, null, 0.10, "Edouard Manet, Musee d'Orsay", "https://upload.wikimedia.org/wikipedia/commons/9/90/Edouard_Manet_-_Luncheon_on_the_Grass_-_Google_Art_Project.jpg", null, "The Luncheon on the Grass", 150.0},
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
