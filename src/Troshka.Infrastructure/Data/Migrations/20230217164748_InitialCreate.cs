using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Troshka.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    TrackId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DateUpdated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DateDeleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    TrackId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DateUpdated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DateDeleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDisplayNamePublic = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    TrackId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DateUpdated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DateDeleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrandId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    TrackId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DateUpdated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DateDeleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Models_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    HorsePowers = table.Column<int>(type: "int", nullable: false),
                    Mileage = table.Column<int>(type: "int", nullable: false),
                    Engine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Euro = table.Column<int>(type: "int", nullable: false),
                    Transmission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Seats = table.Column<int>(type: "int", nullable: false),
                    Doors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstRegistration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsRegistered = table.Column<bool>(type: "bit", nullable: false),
                    InteriorMaterial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InteriorColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasABS = table.Column<bool>(type: "bit", nullable: false),
                    HasESP = table.Column<bool>(type: "bit", nullable: false),
                    HasASR = table.Column<bool>(type: "bit", nullable: false),
                    HasHillStartAssist = table.Column<bool>(type: "bit", nullable: false),
                    HasFatigueWarningSystem = table.Column<bool>(type: "bit", nullable: false),
                    HasLaneChangeAssist = table.Column<bool>(type: "bit", nullable: false),
                    HasBlindSpotAssist = table.Column<bool>(type: "bit", nullable: false),
                    HasNightVisionAssist = table.Column<bool>(type: "bit", nullable: false),
                    HasEmergencyBrakeAssist = table.Column<bool>(type: "bit", nullable: false),
                    HasEmergencyCallSystem = table.Column<bool>(type: "bit", nullable: false),
                    HasTrafficSignRecognition = table.Column<bool>(type: "bit", nullable: false),
                    HasCruiseControl = table.Column<bool>(type: "bit", nullable: false),
                    HasAdaptiveCruiseControl = table.Column<bool>(type: "bit", nullable: false),
                    HasSpeedLimitControlSystem = table.Column<bool>(type: "bit", nullable: false),
                    HasDistanceWarningSystem = table.Column<bool>(type: "bit", nullable: false),
                    HasDriverAirbag = table.Column<bool>(type: "bit", nullable: false),
                    HasFrontAirbags = table.Column<bool>(type: "bit", nullable: false),
                    HasFrontAndSideAirbags = table.Column<bool>(type: "bit", nullable: false),
                    HasFrontAndSideAndMoreAirbags = table.Column<bool>(type: "bit", nullable: false),
                    HasIsofix = table.Column<bool>(type: "bit", nullable: false),
                    HasBiXenonHeadlights = table.Column<bool>(type: "bit", nullable: false),
                    HasLaserHeadlights = table.Column<bool>(type: "bit", nullable: false),
                    HasLedHeadlights = table.Column<bool>(type: "bit", nullable: false),
                    HasXenonHeadlights = table.Column<bool>(type: "bit", nullable: false),
                    HasHeadlightWasherSystem = table.Column<bool>(type: "bit", nullable: false),
                    HasGlareFreeHighBeamHeadlights = table.Column<bool>(type: "bit", nullable: false),
                    HasHighBeamAssist = table.Column<bool>(type: "bit", nullable: false),
                    HasAdaptiveCorneringLights = table.Column<bool>(type: "bit", nullable: false),
                    HasAdaptiveLighting = table.Column<bool>(type: "bit", nullable: false),
                    HasFogLamps = table.Column<bool>(type: "bit", nullable: false),
                    HasAlarm = table.Column<bool>(type: "bit", nullable: false),
                    HasEngineImobilizer = table.Column<bool>(type: "bit", nullable: false),
                    HasAirConditioner = table.Column<bool>(type: "bit", nullable: false),
                    HasClimateControl = table.Column<bool>(type: "bit", nullable: false),
                    HasHeatedWindshield = table.Column<bool>(type: "bit", nullable: false),
                    HasHeatedSteeringWheel = table.Column<bool>(type: "bit", nullable: false),
                    HasSelfSteeringSystems = table.Column<bool>(type: "bit", nullable: false),
                    HasFrontParkAssistant = table.Column<bool>(type: "bit", nullable: false),
                    HasRearParkAssistant = table.Column<bool>(type: "bit", nullable: false),
                    HasCameraAssistant = table.Column<bool>(type: "bit", nullable: false),
                    Has360DegreeCameraAssistant = table.Column<bool>(type: "bit", nullable: false),
                    HasFrontHeatedSeats = table.Column<bool>(type: "bit", nullable: false),
                    HasBackHeatedSeats = table.Column<bool>(type: "bit", nullable: false),
                    HasFrontAdjustableSeats = table.Column<bool>(type: "bit", nullable: false),
                    HasBackAdjustableSeats = table.Column<bool>(type: "bit", nullable: false),
                    HasSportSeats = table.Column<bool>(type: "bit", nullable: false),
                    HasArmRest = table.Column<bool>(type: "bit", nullable: false),
                    HasMassageSeats = table.Column<bool>(type: "bit", nullable: false),
                    HasSeatVentilation = table.Column<bool>(type: "bit", nullable: false),
                    HasElectricWindows = table.Column<bool>(type: "bit", nullable: false),
                    HasElectricSideMirror = table.Column<bool>(type: "bit", nullable: false),
                    HasElectricTailgate = table.Column<bool>(type: "bit", nullable: false),
                    HasCentralLocking = table.Column<bool>(type: "bit", nullable: false),
                    HasKeylessCentralLocking = table.Column<bool>(type: "bit", nullable: false),
                    HasLightSensor = table.Column<bool>(type: "bit", nullable: false),
                    HasRainSensor = table.Column<bool>(type: "bit", nullable: false),
                    HasPowerAssistedSteering = table.Column<bool>(type: "bit", nullable: false),
                    HasAmbientLighting = table.Column<bool>(type: "bit", nullable: false),
                    HasLeatherSteeringWheel = table.Column<bool>(type: "bit", nullable: false),
                    HasRadio = table.Column<bool>(type: "bit", nullable: false),
                    HasCDPlayer = table.Column<bool>(type: "bit", nullable: false),
                    HasTV = table.Column<bool>(type: "bit", nullable: false),
                    HasNavigationSystem = table.Column<bool>(type: "bit", nullable: false),
                    HasSoundSystem = table.Column<bool>(type: "bit", nullable: false),
                    HasTouchScreen = table.Column<bool>(type: "bit", nullable: false),
                    HasVoiceControl = table.Column<bool>(type: "bit", nullable: false),
                    HasMultifunctionSteeringWheel = table.Column<bool>(type: "bit", nullable: false),
                    HasHandsfreeKit = table.Column<bool>(type: "bit", nullable: false),
                    HasUSBPort = table.Column<bool>(type: "bit", nullable: false),
                    HasBluetooth = table.Column<bool>(type: "bit", nullable: false),
                    HasAppleCarPlay = table.Column<bool>(type: "bit", nullable: false),
                    HasAndroidAuto = table.Column<bool>(type: "bit", nullable: false),
                    HasOnboardComputer = table.Column<bool>(type: "bit", nullable: false),
                    HasHeadupDisplay = table.Column<bool>(type: "bit", nullable: false),
                    HasDigitalCockpit = table.Column<bool>(type: "bit", nullable: false),
                    HasSummerTires = table.Column<bool>(type: "bit", nullable: false),
                    HasWinterTires = table.Column<bool>(type: "bit", nullable: false),
                    HasAllSeasonTires = table.Column<bool>(type: "bit", nullable: false),
                    HasEmergencyTire = table.Column<bool>(type: "bit", nullable: false),
                    HasEmergencyTireKit = table.Column<bool>(type: "bit", nullable: false),
                    HasPanoramicRoof = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    TrackId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DateUpdated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DateDeleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicles_Owners_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owners",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Models_BrandId",
                table: "Models",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_CategoryId",
                table: "Vehicles",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_OwnerId",
                table: "Vehicles",
                column: "OwnerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Owners");
        }
    }
}
