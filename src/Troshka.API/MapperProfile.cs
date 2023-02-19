using AutoMapper;
using Troshka.API.Models.Response.Offer;
using Troshka.Application.Offer.Models;

namespace Troshka.API
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            #region Car
            CreateMap<CarOfferModel, CarOfferResponseModel>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name))
                .ForMember(dest => dest.BrandName, opt => opt.MapFrom(src => src.Specification.Brand.Name))
                .ForMember(dest => dest.ModelName, opt => opt.MapFrom(src => src.Specification.Model.Name))
                .ForMember(dest => dest.OwnerDisplayName, opt => opt.MapFrom(src => src.Owner.DisplayName));
            #endregion Car
        }
    }
}
