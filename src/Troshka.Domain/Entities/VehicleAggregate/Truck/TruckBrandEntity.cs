namespace Troshka.Domain.Entities.VehicleAggregate.Truck
{
    public class MotorcycleBrandEntity : BaseEntity
    {
        public string Name { get; set; }
        public string CategoryId { get; set; }
        public virtual CategoryEntity Category { get; set; }
    }
}
