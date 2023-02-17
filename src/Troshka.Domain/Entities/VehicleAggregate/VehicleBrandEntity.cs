namespace Troshka.Domain.Entities.VehicleAggregate
{
    public class VehicleBrandEntity : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<VehicleModelEntity> Models { get; set; }
    }
}
