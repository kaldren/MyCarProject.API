using Troshka.Domain.Entities.OwnerAggregate;

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
    }
}
