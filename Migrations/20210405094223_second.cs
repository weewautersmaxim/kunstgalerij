using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace kunstgalerij.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artworks",
                keyColumn: "ArtworkId",
                keyValue: new Guid("03d39b66-fcf6-4ef3-833f-77f0a1c13dac"));

            migrationBuilder.DeleteData(
                table: "Artworks",
                keyColumn: "ArtworkId",
                keyValue: new Guid("42c3ebc8-393f-450d-bcdb-380227c0af77"));

            migrationBuilder.DeleteData(
                table: "Artworks",
                keyColumn: "ArtworkId",
                keyValue: new Guid("6b933e92-46f4-4302-a9d9-953c4fc3ae34"));

            migrationBuilder.InsertData(
                table: "Artworks",
                columns: new[] { "ArtworkId", "ArtistId", "Price", "Title", "Year" },
                values: new object[] { new Guid("a1463c2d-b82a-4c32-a93d-140418c55e2b"), 1, 2, "artwork test", 1889 });

            migrationBuilder.InsertData(
                table: "Artworks",
                columns: new[] { "ArtworkId", "ArtistId", "Price", "Title", "Year" },
                values: new object[] { new Guid("fd0a5d7b-ccf5-4087-b365-818f7d51ec50"), 1, 500000, "artwork test number 2", 1881 });

            migrationBuilder.InsertData(
                table: "Artworks",
                columns: new[] { "ArtworkId", "ArtistId", "Price", "Title", "Year" },
                values: new object[] { new Guid("02396e68-2a44-44a3-b1b1-6760c9ca498d"), 2, 8000000, "artwork test number 3", 1996 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artworks",
                keyColumn: "ArtworkId",
                keyValue: new Guid("02396e68-2a44-44a3-b1b1-6760c9ca498d"));

            migrationBuilder.DeleteData(
                table: "Artworks",
                keyColumn: "ArtworkId",
                keyValue: new Guid("a1463c2d-b82a-4c32-a93d-140418c55e2b"));

            migrationBuilder.DeleteData(
                table: "Artworks",
                keyColumn: "ArtworkId",
                keyValue: new Guid("fd0a5d7b-ccf5-4087-b365-818f7d51ec50"));

            migrationBuilder.InsertData(
                table: "Artworks",
                columns: new[] { "ArtworkId", "ArtistId", "Price", "Title", "Year" },
                values: new object[] { new Guid("03d39b66-fcf6-4ef3-833f-77f0a1c13dac"), 1, 2, "artwork test", 1889 });

            migrationBuilder.InsertData(
                table: "Artworks",
                columns: new[] { "ArtworkId", "ArtistId", "Price", "Title", "Year" },
                values: new object[] { new Guid("42c3ebc8-393f-450d-bcdb-380227c0af77"), 1, 500000, "artwork test number 2", 1881 });

            migrationBuilder.InsertData(
                table: "Artworks",
                columns: new[] { "ArtworkId", "ArtistId", "Price", "Title", "Year" },
                values: new object[] { new Guid("6b933e92-46f4-4302-a9d9-953c4fc3ae34"), 2, 8000000, "artwork test number 3", 1996 });
        }
    }
}
