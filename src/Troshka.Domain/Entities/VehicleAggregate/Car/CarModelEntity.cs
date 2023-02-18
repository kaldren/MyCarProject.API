namespace Troshka.Domain.Entities.VehicleAggregate.Car
{
    public class CarModelEntity
    {
        public string Name { get; set; }
        public string CarBrandId { get; set; }
        public virtual CarBrandEntity CarBrand { get; set; }
    }
}
