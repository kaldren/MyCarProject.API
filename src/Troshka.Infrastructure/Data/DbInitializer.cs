using Microsoft.Extensions.Logging;
using shortid;
using shortid.Configuration;
using Troshka.Domain.Entities.OwnerAggregate;
using Troshka.Domain.Entities.VehicleAggregate.Car;

namespace Troshka.Infrastructure.Data;

public static class DbInitializer
{
    public static void Initialize(TroshkaDbContext TroshkaDbContext, ILogger logger)
    {
        var audiBrandAudi = TroshkaDbContext.CarBrand.Single(p => p.Name == "Audi");
        var audiModelA6 = TroshkaDbContext.CarModel.Single(p => p.Name == "A6");
        var engine = TroshkaDbContext.CarEngine.Single(p => p.Name == "Diesel");
        var euroStandard = TroshkaDbContext.CarEuroStandard.Single(p => p.Name == "Euro 6");
        var color = TroshkaDbContext.CarColor.Single(p => p.Name == "Black");
        var doors = TroshkaDbContext.CarDoors.Single(p => p.Name == "4/5");
        var seats = TroshkaDbContext.CarSeats.Single(p => p.Value == 5);
        var interiorMaterial = TroshkaDbContext.CarInteriorMaterial.Single(p => p.Name == "Leather");
        var interiorColor = TroshkaDbContext.CarColor.Single(p => p.Name == "Black");
        var transmissionAutomatic = TroshkaDbContext.CarTransmission.Single(p => p.Name == "Automatic");
        var transmissionManual = TroshkaDbContext.CarTransmission.Single(p => p.Name == "Manual");
        var coupe = TroshkaDbContext.CarCoupe.Single(p => p.Name == "Sedan");
        var fuelType = TroshkaDbContext.CarFuelType.Single(p => p.Name == "Diesel");
        var region = TroshkaDbContext.Region.Single(p => p.Name == "Велико Търново");
        var location = TroshkaDbContext.Location.Single(p => p.Name == "гр. Горна Оряховица");

        var regionSofia = TroshkaDbContext.Region.Single(p => p.Name == "София");
        var locationBankya = TroshkaDbContext.Location.Single(p => p.Name == "гр. Банкя");

        var bmwBrandBmw = TroshkaDbContext.CarBrand.Single(p => p.Name == "BMW");
        var bmwModelX6 = TroshkaDbContext.CarModel.Single(p => p.Name == "X6");

        var opelBrandOpel = TroshkaDbContext.CarBrand.Single(p => p.Name == "Opel");
        var opelModelAstra = TroshkaDbContext.CarModel.Single(p => p.Name == "Astra" && p.CarBrandId == opelBrandOpel.Id);

        // Create one car offer
        for (int i = 0; i < 50; i++)
        {
            var offer = new CarOfferEntity
            {
                Id = ShortId.Generate(new GenerationOptions(useNumbers: true, useSpecialCharacters: false, length: 20)),
                Title = "Audi A6 TDI QUATTRO",
                Price = 26500,
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                Owner = new OwnerEntity
                {
                    DisplayName = "Kaloyan Drenski",
                    Phone = "0888 77 88 77",
                    IsDisplayNamePublic = true,
                },
                Specification = new CarSpecificationEntity
                {
                    HorsePowers = 245,
                    Mileage = 150000,
                    Engine = engine,
                    Euro = euroStandard,
                    Color = color,
                    Seats = seats,
                    Doors = doors,
                    BrandId = audiBrandAudi.Id,
                    ModelId = audiModelA6.Id,
                    Year = 2014,
                    FirstRegistration = DateTimeOffset.UtcNow.AddYears(-8),
                    IsRegistered = true,
                    InteriorMaterial = interiorMaterial,
                    InteriorColor = interiorColor,
                    Transmission = transmissionAutomatic
                },
                Equipment = new CarEquipmentEntity
                {
                    Has360DegreeCameraAssistant = true,
                    HasABS = true,
                    HasAdaptiveCorneringLights = true,
                    HasAdaptiveCruiseControl = true,
                    HasAdaptiveLighting = true,
                    HasAirConditioner = true,
                    HasAlarm = true,
                    HasAllSeasonTires = true,
                    HasAndroidAuto = true,
                    HasBackAdjustableSeats = true,
                    HasBackHeatedSeats = true,
                    HasBluetooth = true,
                    HasCameraAssistant = true,
                    HasCentralLocking = true,
                    HasClimateControl = true,
                    HasCruiseControl = true,
                    HasBlindSpotAssist = true,
                    HasDriverAirbag = true,
                    HasEmergencyBrakeAssist = true,
                    HasHeadupDisplay = true,
                    HasKeylessCentralLocking = true,
                    HasMassageSeats = true,
                    HasPanoramicRoof = true,
                    HasXenonHeadlights = true,
                },
                Coupe = coupe,
                FuelType = fuelType,
                Region = region,
                Location = location
            };

            TroshkaDbContext.CarOffer.Add(offer);
        }

        // Create one car offer
        for (int i = 0; i < 5; i++)
        {
            var offer = new CarOfferEntity
            {
                Id = ShortId.Generate(new GenerationOptions(useNumbers: true, useSpecialCharacters: false, length: 20)),
                Title = "BMW X6",
                Price = 32400,
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                Owner = new OwnerEntity
                {
                    DisplayName = "Kaloyan Drenski",
                    Phone = "0888 77 88 77",
                    IsDisplayNamePublic = true,
                },
                Specification = new CarSpecificationEntity
                {
                    HorsePowers = 345,
                    Mileage = 250000,
                    Engine = engine,
                    Euro = euroStandard,
                    Color = color,
                    Seats = seats,
                    Doors = doors,
                    BrandId = bmwBrandBmw.Id,
                    ModelId = bmwModelX6.Id,
                    Year = 2014,
                    FirstRegistration = DateTimeOffset.UtcNow.AddYears(-3),
                    IsRegistered = true,
                    InteriorMaterial = interiorMaterial,
                    InteriorColor = interiorColor,
                    Transmission = transmissionAutomatic
                },
                Equipment = new CarEquipmentEntity
                {
                    Has360DegreeCameraAssistant = true,
                    HasABS = true,
                    HasAdaptiveCorneringLights = true,
                    HasAdaptiveCruiseControl = true,
                    HasAdaptiveLighting = true,
                    HasAirConditioner = true,
                    HasAlarm = true,
                    HasAllSeasonTires = true,
                    HasAndroidAuto = true,
                    HasBackAdjustableSeats = true,
                    HasBackHeatedSeats = true,
                    HasBluetooth = true,
                    HasCameraAssistant = true,
                    HasCentralLocking = true,
                    HasClimateControl = true,
                    HasCruiseControl = true,
                    HasBlindSpotAssist = true,
                    HasDriverAirbag = true,
                    HasEmergencyBrakeAssist = true,
                    HasHeadupDisplay = true,
                    HasKeylessCentralLocking = true,
                    HasMassageSeats = true,
                    HasPanoramicRoof = true,
                    HasXenonHeadlights = true,
                },
                Coupe = coupe,
                FuelType = fuelType,
                Region = regionSofia,
                Location = locationBankya
            };

            TroshkaDbContext.CarOffer.Add(offer);
        }

        // Create one car offer
        for (int i = 0; i < 5; i++)
        {
            var offer = new CarOfferEntity
            {
                Id = ShortId.Generate(new GenerationOptions(useNumbers: true, useSpecialCharacters: false, length: 20)),
                Title = "Opel Astra",
                Price = 9500,
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                Owner = new OwnerEntity
                {
                    DisplayName = "Kaloyan Drenski",
                    Phone = "0888 77 88 77",
                    IsDisplayNamePublic = true,
                },
                Specification = new CarSpecificationEntity
                {
                    HorsePowers = 110,
                    Mileage = 450000,
                    Engine = engine,
                    Euro = euroStandard,
                    Color = color,
                    Seats = seats,
                    Doors = doors,
                    BrandId = opelBrandOpel.Id,
                    ModelId = opelModelAstra.Id,
                    Year = 2014,
                    FirstRegistration = DateTimeOffset.UtcNow.AddYears(-5),
                    IsRegistered = true,
                    InteriorMaterialId = interiorMaterial.Id,
                    InteriorMaterial = interiorMaterial,
                    InteriorColorId = interiorColor.Id,
                    InteriorColor = interiorColor,
                    TransmissionId = transmissionManual.Id,
                    Transmission = transmissionManual
                },
                Equipment = new CarEquipmentEntity
                {
                    Has360DegreeCameraAssistant = true,
                    HasABS = true,
                    HasAdaptiveCorneringLights = true,
                    HasAdaptiveCruiseControl = true,
                    HasAdaptiveLighting = true,
                    HasAirConditioner = true,
                    HasAlarm = true,
                    HasAllSeasonTires = true,
                    HasAndroidAuto = true,
                    HasBackAdjustableSeats = true,
                    HasBackHeatedSeats = true,
                    HasBluetooth = true,
                    HasCameraAssistant = true,
                    HasCentralLocking = true,
                    HasClimateControl = true,
                    HasCruiseControl = true,
                    HasBlindSpotAssist = true,
                    HasDriverAirbag = true,
                    HasEmergencyBrakeAssist = true,
                    HasHeadupDisplay = true,
                    HasKeylessCentralLocking = true,
                    HasMassageSeats = true,
                    HasPanoramicRoof = true,
                    HasXenonHeadlights = true,
                },
                Coupe = coupe,
                FuelType = fuelType,
                Region = regionSofia,
                Location = locationBankya
            };

            TroshkaDbContext.CarOffer.Add(offer);
        }

        TroshkaDbContext.SaveChanges();
    }
}
