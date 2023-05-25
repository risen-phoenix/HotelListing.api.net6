using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelListing.api.Migrations
{
    /// <inheritdoc />
    public partial class SeededCountriesAndHotels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[,]
                {
                    { 1, "South Africa", "SA" },
                    { 2, "United Kingdom", "UK" },
                    { 3, "Netherlands", "NL" },
                    { 4, "New Zealand", "NZ" },
                    { 5, "United States", "US" },
                    { 6, "Thailand", "TB" }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CountryId", "Name", "Rating" },
                values: new object[,]
                {
                    { 1, "Cape Town", 1, "Lagoon Beach Hotel & Spa ", 3.7000000000000002 },
                    { 2, "Hluhluwe iMfolozi Park, 3815, KwaNompondo", 1, "Rhino Ridge Safari Lodge", 4.7000000000000002 },
                    { 3, "Liverpool", 2, "INNSiDE by Meliá", 4.0999999999999996 },
                    { 4, "York", 2, "Sandburn Hall", 4.2000000000000002 },
                    { 5, "London", 2, "Ritz Hotel", 5.0 },
                    { 6, "Amsterdam", 3, "Met Hotel Amsterdam", 4.0 },
                    { 7, "Groningen", 3, "The Market Hotel", 4.0999999999999996 },
                    { 8, "Zandvoort", 3, "Hotel Bell", 4.0 },
                    { 9, "Wellington", 4, "James Cook Hotel Grand Chancellor", 3.5 },
                    { 10, "Christchurch", 4, "Sudima Hotel Christchurch Airport", 3.7999999999999998 },
                    { 11, "Key West", 5, "The Capitana", 4.2000000000000002 },
                    { 12, "Perimeter Center, Atlanta", 5, "Hyatt House", 4.0999999999999996 },
                    { 13, "Orlando", 5, "Fairfield by Marriott Inn & Suites", 4.0999999999999996 },
                    { 14, "Chiang Mai Old TOwn, Chiang Mai", 6, "El Barrio Lanna- SHA Extra Plus", 4.0 },
                    { 15, "Sathorn, Bangkok", 6, "Eastin Grand Hotel", 4.0999999999999996 },
                    { 16, "Patong Beach, Phuket", 6, "The Royal Paradise Hotel & Spa", 4.0 },
                    { 17, "Auckland", 4, "Novotel Auckland", 4.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
