using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace kunstgalerij.Migrations
{
    public partial class AAA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artworks",
                keyColumn: "ArtworkId",
                keyValue: new Guid("5f47cb09-d869-4883-ae07-03c2ff4b1fe6"));

            migrationBuilder.DeleteData(
                table: "Artworks",
                keyColumn: "ArtworkId",
                keyValue: new Guid("ecfbc5d8-8490-4802-ab40-e6998a842115"));

            migrationBuilder.DeleteData(
                table: "Artworks",
                keyColumn: "ArtworkId",
                keyValue: new Guid("ee760b35-50a4-47c3-987a-ae2db5f044f9"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("5f47cb09-d869-4883-ae07-03c2ff4b1fe6"), 1, 2, "artwork test", 1889 });

            migrationBuilder.InsertData(
                table: "Artworks",
                columns: new[] { "ArtworkId", "ArtistId", "Price", "Title", "Year" },
                values: new object[] { new Guid("ee760b35-50a4-47c3-987a-ae2db5f044f9"), 1, 500000, "artwork test number 2", 1881 });

            migrationBuilder.InsertData(
                table: "Artworks",
                columns: new[] { "ArtworkId", "ArtistId", "Price", "Title", "Year" },
                values: new object[] { new Guid("ecfbc5d8-8490-4802-ab40-e6998a842115"), 2, 8000000, "artwork test number 3", 1996 });
        }
    }
}
