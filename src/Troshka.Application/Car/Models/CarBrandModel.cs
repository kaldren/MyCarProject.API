using Troshka.Application.Category.Models;

namespace Troshka.Application.Car.Models
{
    public class CarBrandModel
    {
        public string Name { get; set; }
        public string CategoryId { get; set; }
        public CategoryModel Category { get; set; }
    }
}
