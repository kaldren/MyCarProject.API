using Troshka.Application.Car.Models;
using Troshka.Application.Category.Models;
using Troshka.Application.Owner.Models;

namespace Troshka.Application.Offer.Models
{
    public class CarOfferModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public OwnerModel Owner { get; set; }
        public CarSpecificationModel Specification { get; set; }
        public CarEquipmentModel Equipment { get; set; }
        public CategoryModel Category { get; set; }
    }
}
