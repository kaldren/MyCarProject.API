namespace Troshka.Domain.Entities.VehicleAggregate.Truck
{
    public class MotorcycleModelEntity : BaseEntity
    {
        public string Name { get; set; }
        public string TruckBrandId { get; set; }
        public virtual MotorcycleBrandEntity TruckBrand { get; set; }
    }
}
