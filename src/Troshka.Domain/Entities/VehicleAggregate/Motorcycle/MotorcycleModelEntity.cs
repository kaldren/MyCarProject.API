namespace Troshka.Domain.Entities.VehicleAggregate.Motorcycle
{
    public class MotorcycleModelEntity : BaseEntity
    {
        public string Name { get; set; }
        public string MotorcycleBrandId { get; set; }
        public virtual MotorcycleBrandEntity MotorcycleBrand { get; set; }
    }
}
