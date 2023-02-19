using Microsoft.Extensions.Logging;
using Troshka.Domain.Entities.OwnerAggregate;
using Troshka.Domain.Entities.VehicleAggregate.Car;

namespace Troshka.Infrastructure.Data;

public static class DbInitializer
{
    public static void Initialize(TroshkaDbContext TroshkaDbContext, ILogger logger)
    {
        var audiBrandAudi = TroshkaDbContext.CarBrand.SingleOrDefault(p => p.Name == "Audi");
        var audiModelA6 = TroshkaDbContext.CarModel.SingleOrDefault(p => p.Name == "A6");

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
                Engine = "Diesel",
                Euro = 6,
                Color = "Black",
                Seats = 7,
                Doors = "4/5",
                BrandId = audiBrandAudi.Id,
                ModelId = audiModelA6.Id,
                Year = 2014,
                FirstRegistration = DateTimeOffset.UtcNow.AddYears(-8),
                IsRegistered = true,
                InteriorMaterial = "Leather",
                InteriorColor = "Black"
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
