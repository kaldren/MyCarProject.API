namespace Troshka.Domain.Entities.VehicleAggregate.Car
{
    public class CarBrandEntity : BaseEntity
    {
        public string Name { get; set; }
        public string CategoryId { get; set; }
        public virtual CategoryEntity Category { get; set; }
    }
}
