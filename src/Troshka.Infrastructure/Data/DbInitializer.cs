using Microsoft.Extensions.Logging;
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
        var transmission = TroshkaDbContext.CarTransmission.Single(p => p.Name == "Automatic");

        // Create one car offer
        var offer = new CarOfferEntity
        {
            Title = "Audi A6 TDI QUATTRO",
            Price = 26500,
            Description = "Винаги обслужвано навреме. Реални километри. Проверка в сервиз по ваш избор!",
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
                Transmission = transmission
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
            }
        };

        TroshkaDbContext.CarOffer.Add(offer);
        TroshkaDbContext.SaveChanges();
    }
}
