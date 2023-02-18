namespace Troshka.Domain.Entities.VehicleAggregate
{
    public class VehicleBrandEntity : BaseEntity
    {
        public string Name { get; set; }

        public string CategoryId { get; set; }
        public virtual CategoryEntity Category { get; set; }

        public virtual ICollection<VehicleModelEntity> Models { get; set; }
    }
}
