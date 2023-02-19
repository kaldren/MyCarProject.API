namespace Troshka.Domain.Entities.VehicleAggregate.Car
{
    public class CarSpecificationEntity : BaseEntity
    {
        public int HorsePowers { get; set; }
        public int Mileage { get; set; }
        public string Engine { get; set; }
        public int Euro { get; set; }
        public string Transmission { get; set; }
        public string Color { get; set; }
        public int Seats { get; set; }
        public string Doors { get; set; }
        public string BrandId { get; set; }
        public virtual CarBrandEntity Brand { get; set; }
        public string ModelId { get; set; }
        public virtual CarModelEntity Model { get; set; }
        public int Year { get; set; }
        public DateTimeOffset FirstRegistration { get; set; }
        public bool IsRegistered { get; set; }
        public string InteriorMaterial { get; set; }
        public string InteriorColor { get; set; }
    }
}
