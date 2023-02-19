namespace Troshka.Application.Car.Models
{
    public class CarSpecificationModel
    {
        public int Year { get; set; }
        public int HorsePowers { get; set; }
        public int Mileage { get; set; }
        public bool IsRegistered { get; set; }
        public string FirstRegistration { get; set; }
        public CarEngineModel Engine { get; set; }
        public CarEuroStandardModel Euro { get; set; }
        public CarTransmissionModel Transmission { get; set; }
        public CarColorModel Color { get; set; }
        public CarSeatsModel Seats { get; set; }
        public CarDoorsModel Doors { get; set; }
        public CarInteriorMaterialModel InteriorMaterial { get; set; }
        public CarColorModel InteriorColor { get; set; }
        public string BrandId { get; set; }
        public CarBrandModel Brand { get; set; }
        public string ModelId { get; set; }
        public CarModelModel Model { get; set; }
    }
}
