using Troshka.Domain.Entities.VehicleAggregate;

namespace Troshka.Domain.Entities.OwnerAggregate
{
    public class OwnerEntity : BaseEntity
    {
        public string DisplayName { get; set; }
        public string Phone { get; set; }
        public bool IsDisplayNamePublic { get; set; }
        public ICollection<VehicleEntity> Vehicles { get; set; }
    }
}
