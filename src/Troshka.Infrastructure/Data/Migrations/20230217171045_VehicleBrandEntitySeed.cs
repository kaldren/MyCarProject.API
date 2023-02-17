using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Troshka.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class VehicleBrandEntitySeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Brands",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name", "TrackId" },
                values: new object[,]
                {
                    { "_Ms-WkPsooeJ", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(941), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Hyundai", "6d5fa995-293b-47f6-a872-037ccdd3124d" },
                    { "_mvdo-pxgc", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Jeep", "d7c6b54d-d3d8-410b-a1a4-4c042ef2bae6" },
                    { "_WbvIvo-", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(1142), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SsangYong", "d6b5969d-1447-4248-adb1-514bca27d2f2" },
                    { "adDXcpxzEYK", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(929), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Honda", "c2ba46c0-325e-4137-95af-eaef32ed76d4" },
                    { "bEGxLtsn", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(1115), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rolls-Royce", "4c4f82f9-de0c-4c54-a3b8-4fe9712f336f" },
                    { "bsLqjtGt", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(983), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Lada", "d9575f11-6749-42cb-bb3a-a21973b88935" },
                    { "BudrdBpszrMjD", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(1049), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "McLaren", "e30825e1-8f1b-42e1-b02a-ee65389f1e15" },
                    { "CEDJKRXwXgbs", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(1007), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Lotus", "68f0e2f0-202a-404e-86c3-0936f1a1e411" },
                    { "d_Rk-qRe", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(910), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ferrari", "8786a951-642b-4515-9f51-25c08f04d521" },
                    { "dNHHjxGa_HwU", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(845), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Chevrolet", "b7d0b0d2-d66e-4890-8c83-beb784cbefff" },
                    { "DrhIdDKrVYlA", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(1146), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Subaru", "994f5ace-e2cf-4d92-81c4-0287c4046313" },
                    { "e-pdeaXRM", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(873), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Dodge", "239bbbe8-a1ea-47b5-bf18-e1690e9eebe8" },
                    { "EjvUoNWHcaSwI", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(920), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Fisker", "30bc3c12-3df4-46c3-b93c-e10fefdc9369" },
                    { "eSUIcvfTK", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(830), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Bugatti", "7bad6ceb-40dd-425e-9c31-fb3e683a2135" },
                    { "fBrvut-xMR", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(915), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Fiat", "bb04ae49-5eee-487a-b02a-1f45a3dc9009" },
                    { "ftCncgtJnU", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(1133), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Skoda", "e60d8a41-a360-470e-898a-dc1b19f6d034" },
                    { "guMxEpFzeEJC", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(1152), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Suzuki", "f188ef5d-76fd-4c6a-9861-597ae069973c" },
                    { "hCcvlhUAGCL", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(792), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Audi", "1740a469-184e-4a5c-bb56-f4fc9eaf2bc8" },
                    { "hClvKpDLfQXL", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(1017), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Maybach", "a06fd209-7e70-4d32-a75c-442f6a821f1f" },
                    { "HnqlfQ_omT", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(863), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Daewoo", "21e0ef24-73a0-4491-92a8-9366fefc9c8c" },
                    { "HPrCUIHuPD", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(1003), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Lexus", "1185ba16-ef2f-469c-81c6-39dddf085dc9" },
                    { "HzyhvIxjBNIG-", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(1124), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Saab", "eb1036bb-d759-427b-9f36-8bad6ff66a61" },
                    { "IXWqrmw_vFbfg", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(1013), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Maserati", "60f93483-49cb-4c3d-acae-7e37ccdead21" },
                    { "JPhGDJue", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(796), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Bentley", "3af2453c-31e0-459d-afa2-8655e4fe3c89" },
                    { "JsgmukQhWtK", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(992), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Lancia", "73647a4e-b6fa-417a-b71a-143af32d15ca" },
                    { "JUNSVoaRzEdWf", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(1184), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tesla", "0a10e15c-521d-4f16-8991-8cf78191ebba" },
                    { "kMmVeJ_dNV", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(859), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Dacia", "5149a02a-b4d2-4247-a683-389a87f2d375" },
                    { "kNqtPYyD", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(1059), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "MG", "053c4868-3ed5-4253-9442-1a2a43a240c3" },
                    { "krwqQxxSLQJM", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(1076), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Opel", "00624377-1c7a-45d1-981f-cf745f2438aa" },
                    { "KYGApHqK", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(945), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Infiniti", "a7642376-8792-4039-b340-c342017d3978" },
                    { "LhBVXBnYwQtEL", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Daihatsu", "53e3d410-1ec3-43ce-b21f-9c2e534c0d06" },
                    { "MPRpAUF_aI", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(779), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Alfa Romeo", "71814763-9ba8-4f3d-abf6-9ad6f6d5f87a" },
                    { "MyYPnUtd_rv", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(1119), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rover", "f523b208-b029-43bb-be94-91ff42a3a197" },
                    { "nJqNBwPSFV_wl", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(801), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "BMW", "12a48c76-2088-4a35-b4a0-58f35f7f90f8" },
                    { "oz-eCFfVKWwR", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(905), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "DS", "1378011d-7d4d-4a73-85e3-c988409e46e7" },
                    { "pINf_LbrtY_g", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(1109), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Renault", "a5569390-c4c7-4292-b53b-c1f102c7804d" },
                    { "RqQVjbXT", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(979), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Kia", "522f25d8-fd83-4bb1-b1b6-0068cee60943" },
                    { "RyueuQwTQU", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(925), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ford", "6971f470-b840-4d5d-a4fa-d242f4df243d" },
                    { "SmNtrHIwjPkUm", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Volkswagen", "6a99b438-f0ba-44fb-bae5-5b3b27f30344" },
                    { "TofUvaccxIIuM", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(840), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cadillac", "82b19ac8-d80f-4e2f-88db-b352012a054f" },
                    { "TXYkfdRwS", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(1198), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Volvo", "acc55060-7289-4e63-9188-4a78b9db9dd8" },
                    { "U-QRGpbKpt", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(987), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Lamborghini", "447a0c3c-7ebc-4a81-9fbe-85fbd8fa7d94" },
                    { "UdrvUFWy", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(1138), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Smart", "b9435e99-f414-4511-aac3-805c063e45f8" },
                    { "uHgEHxUsU", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(1071), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Nissan", "c4243588-8d5b-4f5d-aea5-284882418943" },
                    { "uHqXPsFyVA", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(849), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Chrysler", "d0e19f63-f2c3-44ea-9403-edd4aeb4cd08" },
                    { "UrWBjbTuU", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(1079), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Peugeot", "82786282-73f6-48c4-bffc-3400f2f6b800" },
                    { "VRvjvXPkH", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(1067), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mitsubishi", "fdeb821f-c2ad-4e3e-b58f-c30be046b071" },
                    { "VTgUkCvl", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(949), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Jaguar", "d75054e7-5f45-4c17-9ae1-cf42412d28db" },
                    { "VtrgWMgFpw", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(787), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Aston Martin", "f72282d2-1944-47d1-9623-c52257b534be" },
                    { "vWFIjDh_ASvTY", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(1044), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mazda", "ab881e99-3948-4fd6-a865-60b5ce41b39a" },
                    { "wRYdG-LhEj", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(1128), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Seat", "3f99ccb5-4fb5-49d0-9bdd-2c2c1eb652e8" },
                    { "XHvxYnzEo", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(1054), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mercedes-Benz", "ff1c458b-032e-4dc0-aa22-2a77d9d6b1fa" },
                    { "XTEnczEXrjyaA", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(998), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Land Rover", "ec3a6481-a2f3-4b95-af1d-5b53660e6475" },
                    { "YaYccIHN", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(1083), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Porsche", "d4662a9b-4e7b-4f83-a183-490b81be0549" },
                    { "YjqDSpQG_bme", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(1064), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mini", "3f58e325-9c87-48e2-b098-1b1231acda9f" },
                    { "YQjVAUWnmd_ud", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(880), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Donkervoort", "9d8832cc-407c-40a2-9079-e7de3c30b06a" },
                    { "ySzDtWHfoBfXb", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(934), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Hummer", "a5171697-945f-4322-9d7b-9f2726a7b3a0" },
                    { "yutIPMNDUeS", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(1189), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Toyota", "6b08568c-08d9-4b17-b266-2392a948bf2c" },
                    { "zoepVfpx_Y", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 973, DateTimeKind.Unspecified).AddTicks(854), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Citroen", "c81ea159-9e85-4986-8d5b-62a96bcd6993" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name", "TrackId" },
                values: new object[,]
                {
                    { "-KydSfGDYoo", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 971, DateTimeKind.Unspecified).AddTicks(4940), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Boats", "9f99a701-7bab-41ad-886d-8fccb62b7c1b" },
                    { "BQkJDKuf", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 971, DateTimeKind.Unspecified).AddTicks(4900), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Motorcycles", "c8db04de-65f2-49ee-b32d-faa55f39b2c6" },
                    { "gmsxFfxmQoGC", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 971, DateTimeKind.Unspecified).AddTicks(4895), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Buses", "967e0804-5e7e-40e2-8667-df127257bdc5" },
                    { "nTKVyFGuFWl", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 971, DateTimeKind.Unspecified).AddTicks(4887), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cars", "0d6662a7-3a7f-4257-bfd1-27abaeb00661" },
                    { "qkeDjmzNRM", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 971, DateTimeKind.Unspecified).AddTicks(4935), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Caravans", "7e22bedb-9c39-4201-a00e-e488dab51703" },
                    { "RQCBXSdWdUjDT", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 971, DateTimeKind.Unspecified).AddTicks(4930), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Trucks", "e2b298e6-9b27-4b13-ad94-769e76e9478e" },
                    { "wBAfnVDJHa", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 971, DateTimeKind.Unspecified).AddTicks(4957), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Agriciltural", "1654a414-f9a0-4a3e-89f9-ea7b175e046d" },
                    { "XtgKcvgqsck", new DateTimeOffset(new DateTime(2023, 2, 17, 17, 10, 44, 971, DateTimeKind.Unspecified).AddTicks(4952), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Construction", "afcadd1c-f933-4fe3-9632-00930c11a951" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "_Ms-WkPsooeJ");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "_mvdo-pxgc");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "_WbvIvo-");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "adDXcpxzEYK");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "bEGxLtsn");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "bsLqjtGt");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "BudrdBpszrMjD");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "CEDJKRXwXgbs");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "d_Rk-qRe");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "dNHHjxGa_HwU");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "DrhIdDKrVYlA");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "e-pdeaXRM");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "EjvUoNWHcaSwI");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "eSUIcvfTK");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "fBrvut-xMR");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "ftCncgtJnU");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "guMxEpFzeEJC");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "hCcvlhUAGCL");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "hClvKpDLfQXL");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "HnqlfQ_omT");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "HPrCUIHuPD");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "HzyhvIxjBNIG-");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "IXWqrmw_vFbfg");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "JPhGDJue");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "JsgmukQhWtK");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "JUNSVoaRzEdWf");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "kMmVeJ_dNV");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "kNqtPYyD");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "krwqQxxSLQJM");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "KYGApHqK");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "LhBVXBnYwQtEL");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "MPRpAUF_aI");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "MyYPnUtd_rv");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "nJqNBwPSFV_wl");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "oz-eCFfVKWwR");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "pINf_LbrtY_g");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "RqQVjbXT");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "RyueuQwTQU");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "SmNtrHIwjPkUm");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "TofUvaccxIIuM");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "TXYkfdRwS");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "U-QRGpbKpt");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "UdrvUFWy");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "uHgEHxUsU");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "uHqXPsFyVA");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "UrWBjbTuU");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "VRvjvXPkH");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "VTgUkCvl");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "VtrgWMgFpw");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "vWFIjDh_ASvTY");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "wRYdG-LhEj");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "XHvxYnzEo");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "XTEnczEXrjyaA");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "YaYccIHN");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "YjqDSpQG_bme");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "YQjVAUWnmd_ud");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "ySzDtWHfoBfXb");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "yutIPMNDUeS");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: "zoepVfpx_Y");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "-KydSfGDYoo");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "BQkJDKuf");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "gmsxFfxmQoGC");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "nTKVyFGuFWl");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "qkeDjmzNRM");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "RQCBXSdWdUjDT");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "wBAfnVDJHa");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "XtgKcvgqsck");

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
    }
}
