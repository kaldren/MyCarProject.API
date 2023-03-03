using Troshka.Domain.Entities.OwnerAggregate;
using Troshka.Domain.Entities.RegionAggregate;

namespace Troshka.Domain.Entities.VehicleAggregate.Car
{
    public class CarOfferEntity : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual OwnerEntity Owner { get; set; }
        public virtual CarSpecificationEntity Specification { get; set; }
        public virtual CarEquipmentEntity Equipment { get; set; }
        public virtual CarCoupeEntity Coupe { get; set; }
        public virtual CarFuelTypeEntity FuelType { get; set; }
        public virtual RegionEntity Region { get; set; }
        public virtual LocationEntity Location { get; set; }
    }
}
