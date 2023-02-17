using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Troshka.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class VehicleCategorySeedv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name", "TrackId" },
                values: new object[,]
                {
                    { "bc_KpKlapX_q", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 1, 52, 503, DateTimeKind.Unspecified).AddTicks(2665), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cars", "b507ead3-6d90-4646-8b54-e3ac95bc97bf" },
                    { "DWsRuHgNKycU", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 1, 52, 503, DateTimeKind.Unspecified).AddTicks(2673), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Buses", "404afcf4-f89a-45d3-806c-3a78b5b3aa81" },
                    { "gP--hcxsYl", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 1, 52, 503, DateTimeKind.Unspecified).AddTicks(2722), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Construction", "b40704b5-9c81-4c94-b940-4f7a6b4e616b" },
                    { "hLobnwwIjtEX", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 1, 52, 503, DateTimeKind.Unspecified).AddTicks(2687), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Caravans", "7925a525-0823-416f-a256-a412b169de53" },
                    { "K_jDvK-uGpug", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 1, 52, 503, DateTimeKind.Unspecified).AddTicks(2682), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Trucks", "4a22860e-d1e6-458d-916f-09ee1c4523b8" },
                    { "LYEMPyYyP", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 1, 52, 503, DateTimeKind.Unspecified).AddTicks(2726), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Agriciltural", "f234e706-19b0-4057-8a40-42499faf83cc" },
                    { "raECclCDG", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 1, 52, 503, DateTimeKind.Unspecified).AddTicks(2717), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Boats", "3ab7b6a6-7549-4e1a-90d6-446a7aefe37a" },
                    { "VRqeN-nn", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 1, 52, 503, DateTimeKind.Unspecified).AddTicks(2677), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Motorcycles", "720c2d15-e779-4a8b-acaa-7b383ee0fec7" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "bc_KpKlapX_q");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "DWsRuHgNKycU");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "gP--hcxsYl");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "hLobnwwIjtEX");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "K_jDvK-uGpug");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "LYEMPyYyP");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "raECclCDG");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "VRqeN-nn");

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
    }
}
