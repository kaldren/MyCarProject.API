namespace Troshka.Domain.Entities.VehicleAggregate.Car
{
    public class CarSpecificationEntity : BaseEntity
    {
        public int Year { get; set; }
        public int HorsePowers { get; set; }
        public int Mileage { get; set; }
        public bool IsRegistered { get; set; }
        public DateTimeOffset FirstRegistration { get; set; }
        public string EngineId { get; set; }
        public virtual CarEngineEntity Engine { get; set; }
        public string EuroId { get; set; }
        public virtual CarEuroStandardEntity Euro { get; set; }
        public string TransmissionId { get; set; }
        public virtual CarTransmissionEntity Transmission { get; set; }
        public string ColorId { get; set; }
        public virtual CarColorEntity Color { get; set; }
        public string SeatsId { get; set; }
        public virtual CarSeatsEntity Seats { get; set; }
        public string DoorsId { get; set; }
        public virtual CarDoorsEntity Doors { get; set; }
        public string InteriorMaterialId { get; set; }
        public virtual CarInteriorMaterialEntity InteriorMaterial { get; set; }
        public string InteriorColorId { get; set; }
        public virtual CarColorEntity InteriorColor { get; set; }
        public string BrandId { get; set; }
        public virtual CarBrandEntity Brand { get; set; }
        public string ModelId { get; set; }
        public virtual CarModelEntity Model { get; set; }
        public string CoupeId { get; set; }
        public virtual CarCoupeEntity Coupe { get; set; }
        public virtual string FuelTypeId { get; set; }
        public virtual CarFuelTypeEntity FuelType { get; set; }
    }
}
