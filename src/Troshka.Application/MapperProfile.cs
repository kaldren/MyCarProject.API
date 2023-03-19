using AutoMapper;
using Troshka.Application.Car.Models;
using Troshka.Application.Category.Models;
using Troshka.Application.Offer.Models;
using Troshka.Application.Owner.Models;
using Troshka.Domain.Entities.OwnerAggregate;
using Troshka.Domain.Entities.RegionAggregate;
using Troshka.Domain.Entities.VehicleAggregate;
using Troshka.Domain.Entities.VehicleAggregate.Car;

namespace Troshka.Application
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            #region Car
            CreateMap<CarBrandEntity, CarBrandModel>();
            CreateMap<CarCategoryEntity, CarCategoryModel>();
            CreateMap<CarColorEntity, CarColorModel>();
            CreateMap<CarDoorsEntity, CarDoorsModel>();
            CreateMap<CarEngineEntity, CarEngineModel>();
            CreateMap<CarTransmissionEntity, CarTransmissionModel>();
            CreateMap<CarEquipmentEntity, CarEquipmentModel>();
            CreateMap<CarEuroStandardEntity, CarEuroStandardModel>();
            CreateMap<CarInteriorMaterialEntity, CarInteriorMaterialModel>();
            CreateMap<CarModelEntity, CarModelModel>();
            CreateMap<CarOfferEntity, CarOfferModel>();
            CreateMap<CarSeatsEntity, CarSeatsModel>();
            CreateMap<CarSpecificationEntity, CarSpecificationModel>();
            CreateMap<CarTransmissionEntity, CarTransmissionModel>();
            #endregion Car

            CreateMap<CategoryEntity, CategoryModel>();
            CreateMap<OwnerEntity, OwnerModel>();
            CreateMap<RegionEntity, RegionModel>();
            CreateMap<LocationEntity, LocationModel>();
        }
    }
}
