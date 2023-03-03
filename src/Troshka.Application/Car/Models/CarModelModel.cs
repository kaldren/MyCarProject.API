namespace Troshka.Application.Car.Models
{
    public class CarModelModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string CarBrandId { get; set; }
        public CarBrandModel CarBrand { get; set; }
    }
}
