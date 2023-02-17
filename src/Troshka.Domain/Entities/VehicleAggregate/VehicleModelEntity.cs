namespace Troshka.Domain.Entities.VehicleAggregate
{
    public class VehicleModelEntity : BaseEntity
    {
        public string Name { get; set; }

        public VehicleBrandEntity Brand { get; set; }
    }
}
