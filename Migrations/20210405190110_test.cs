﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace kunstgalerij.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    ArtistId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birthplace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.ArtistId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Artworks",
                columns: table => new
                {
                    ArtworkId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    ArtistId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artworks", x => x.ArtworkId);
                    table.ForeignKey(
                        name: "FK_Artworks_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "ArtistId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArtworkImages",
                columns: table => new
                {
                    ArtworkImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArtworkId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtworkImages", x => x.ArtworkImageId);
                    table.ForeignKey(
                        name: "FK_ArtworkImages_Artworks_ArtworkId",
                        column: x => x.ArtworkId,
                        principalTable: "Artworks",
                        principalColumn: "ArtworkId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryArtworks",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ArtworkId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryArtworks", x => new { x.CategoryId, x.ArtworkId });
                    table.ForeignKey(
                        name: "FK_CategoryArtworks_Artworks_ArtworkId",
                        column: x => x.ArtworkId,
                        principalTable: "Artworks",
                        principalColumn: "ArtworkId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryArtworks_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Age", "Birthplace", "FirstName", "Gender", "Name", "description" },
                values: new object[,]
                {
                    { 1, 37, "The Netherlands", "Vincent", "man", "van Gogh", "Vincent Willem van Gogh was een Nederlands kunstschilder. Zijn werk valt onder het postimpressionisme, een kunststroming die het negentiende-eeuwse impressionisme opvolgde. Van Gogh wordt gezien als een van de grootste schilders van de 19e eeuw." },
                    { 2, 92, "Spain", "Pablo", "man", "Picasso", "He was a draftsman, sculptor and jewelry designer. He was also one of the most famous Spanish painters." }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Modern" },
                    { 2, "Classic" },
                    { 3, "Abstract" },
                    { 4, "figuratief" },
                    { 5, "landscape" },
                    { 6, "portrait" }
                });

            migrationBuilder.InsertData(
                table: "Artworks",
                columns: new[] { "ArtworkId", "ArtistId", "Price", "Title", "Year" },
                values: new object[] { new Guid("25fe1594-ddaf-46de-89f9-7166f1bc1a89"), 1, 2, "artwork test", 1889 });

            migrationBuilder.InsertData(
                table: "Artworks",
                columns: new[] { "ArtworkId", "ArtistId", "Price", "Title", "Year" },
                values: new object[] { new Guid("47895766-5d8f-4685-94ba-17dd9403b0ec"), 1, 500000, "artwork test number 2", 1881 });

            migrationBuilder.InsertData(
                table: "Artworks",
                columns: new[] { "ArtworkId", "ArtistId", "Price", "Title", "Year" },
                values: new object[] { new Guid("098db663-88a1-486e-86a8-34237f5a5f84"), 2, 8000000, "artwork test number 3", 1996 });

            migrationBuilder.CreateIndex(
                name: "IX_ArtworkImages_ArtworkId",
                table: "ArtworkImages",
                column: "ArtworkId");

            migrationBuilder.CreateIndex(
                name: "IX_Artworks_ArtistId",
                table: "Artworks",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryArtworks_ArtworkId",
                table: "CategoryArtworks",
                column: "ArtworkId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtworkImages");

            migrationBuilder.DropTable(
                name: "CategoryArtworks");

            migrationBuilder.DropTable(
                name: "Artworks");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Artists");
        }
    }
}