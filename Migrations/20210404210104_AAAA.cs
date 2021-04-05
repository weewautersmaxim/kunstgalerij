using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace kunstgalerij.Migrations
{
    public partial class AAAA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artworks",
                keyColumn: "ArtworkId",
                keyValue: new Guid("121ddbb5-1418-400b-bb76-132e9d6cb29e"));

            migrationBuilder.DeleteData(
                table: "Artworks",
                keyColumn: "ArtworkId",
                keyValue: new Guid("a75fd501-c2ab-420b-babc-af18a4036580"));

            migrationBuilder.DeleteData(
                table: "Artworks",
                keyColumn: "ArtworkId",
                keyValue: new Guid("bf533d0f-e1e9-40a8-97b9-0908cc460a31"));

            migrationBuilder.InsertData(
                table: "Artworks",
                columns: new[] { "ArtworkId", "ArtistId", "Price", "Title", "Year" },
                values: new object[] { new Guid("c51ef354-5a68-4090-83e6-f8173acc8328"), 1, 2, "artwork test", 1889 });

            migrationBuilder.InsertData(
                table: "Artworks",
                columns: new[] { "ArtworkId", "ArtistId", "Price", "Title", "Year" },
                values: new object[] { new Guid("2ed0001a-707d-45e0-80ac-828bd5e1398a"), 1, 500000, "artwork test number 2", 1881 });

            migrationBuilder.InsertData(
                table: "Artworks",
                columns: new[] { "ArtworkId", "ArtistId", "Price", "Title", "Year" },
                values: new object[] { new Guid("12fe5737-a9fb-4627-9493-4ce2a620edce"), 2, 8000000, "artwork test number 3", 1996 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artworks",
                keyColumn: "ArtworkId",
                keyValue: new Guid("12fe5737-a9fb-4627-9493-4ce2a620edce"));

            migrationBuilder.DeleteData(
                table: "Artworks",
                keyColumn: "ArtworkId",
                keyValue: new Guid("2ed0001a-707d-45e0-80ac-828bd5e1398a"));

            migrationBuilder.DeleteData(
                table: "Artworks",
                keyColumn: "ArtworkId",
                keyValue: new Guid("c51ef354-5a68-4090-83e6-f8173acc8328"));

            migrationBuilder.InsertData(
                table: "Artworks",
                columns: new[] { "ArtworkId", "ArtistId", "Price", "Title", "Year" },
                values: new object[] { new Guid("121ddbb5-1418-400b-bb76-132e9d6cb29e"), 1, 2, "artwork test", 1889 });

            migrationBuilder.InsertData(
                table: "Artworks",
                columns: new[] { "ArtworkId", "ArtistId", "Price", "Title", "Year" },
                values: new object[] { new Guid("a75fd501-c2ab-420b-babc-af18a4036580"), 1, 500000, "artwork test number 2", 1881 });

            migrationBuilder.InsertData(
                table: "Artworks",
                columns: new[] { "ArtworkId", "ArtistId", "Price", "Title", "Year" },
                values: new object[] { new Guid("bf533d0f-e1e9-40a8-97b9-0908cc460a31"), 2, 8000000, "artwork test number 3", 1996 });
        }
    }
}
