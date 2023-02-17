namespace Troshka.Domain.Entities.VehicleAggregate
{
    // Ex: Automobile, motorcycle, truck...
    public class VehicleCategoryEntity : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<VehicleEntity> Vehicles { get; set; }
    }
}
