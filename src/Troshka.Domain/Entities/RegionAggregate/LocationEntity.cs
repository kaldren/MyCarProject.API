using Troshka.Domain.Entities.VehicleAggregate;

namespace Troshka.Domain.Entities.RegionAggregate;

public class LocationEntity : BaseEntity
{
    public string Name { get; set; }

    public string RegionId { get; set; }
    public virtual RegionEntity Region { get; set; }
}