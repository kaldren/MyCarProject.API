using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Troshka.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class VehicleCategorySeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name", "TrackId" },
                values: new object[,]
                {
                    { "+anw2XCegEum+n3Zpk8qMw", new DateTimeOffset(new DateTime(2023, 2, 17, 16, 56, 58, 164, DateTimeKind.Unspecified).AddTicks(2155), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Trucks", "22be0fce-5cac-44ed-a8d6-7353e8b965a0" },
                    { "+TF9QeWmPkS9RyswlvcZNQ", new DateTimeOffset(new DateTime(2023, 2, 17, 16, 56, 58, 164, DateTimeKind.Unspecified).AddTicks(2134), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cars", "38c3d2fc-60b7-4d47-a559-bc60f01f83d4" },
                    { "9aVA1JCCYk68566yYlGMIQ", new DateTimeOffset(new DateTime(2023, 2, 17, 16, 56, 58, 164, DateTimeKind.Unspecified).AddTicks(2158), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Caravans", "7735c177-391d-4edc-b218-fe94ee749c62" },
                    { "bqt/UknBx0WD583CsHealA", new DateTimeOffset(new DateTime(2023, 2, 17, 16, 56, 58, 164, DateTimeKind.Unspecified).AddTicks(2160), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Boats", "52cc2849-1e77-4f1c-8ed2-153b25dac540" },
                    { "iiffXggXIU2rVWXyJSKFjg", new DateTimeOffset(new DateTime(2023, 2, 17, 16, 56, 58, 164, DateTimeKind.Unspecified).AddTicks(2140), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Buses", "61f26a65-2742-456d-86c1-bc2ccc7a4464" },
                    { "ur7v/wV+M0+w3x/oqCkMfQ", new DateTimeOffset(new DateTime(2023, 2, 17, 16, 56, 58, 164, DateTimeKind.Unspecified).AddTicks(2152), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Motorcycles", "8a3f387e-7ded-4382-9ca9-fbbb734ce2bb" },
                    { "xrFvMuRzvUKegqz/cBMNbw", new DateTimeOffset(new DateTime(2023, 2, 17, 16, 56, 58, 164, DateTimeKind.Unspecified).AddTicks(2164), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Construction", "1c806990-ed95-4183-b662-46e3414c4553" },
                    { "zS0aIEnxWU+mlNEP/KCa/Q", new DateTimeOffset(new DateTime(2023, 2, 17, 16, 56, 58, 164, DateTimeKind.Unspecified).AddTicks(2167), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Agriciltural", "d0dea161-e1ae-48dd-b0c2-ba7aff41747a" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "+anw2XCegEum+n3Zpk8qMw");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "+TF9QeWmPkS9RyswlvcZNQ");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "9aVA1JCCYk68566yYlGMIQ");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "bqt/UknBx0WD583CsHealA");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "iiffXggXIU2rVWXyJSKFjg");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "ur7v/wV+M0+w3x/oqCkMfQ");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "xrFvMuRzvUKegqz/cBMNbw");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "zS0aIEnxWU+mlNEP/KCa/Q");
        }
    }
}
