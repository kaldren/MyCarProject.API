using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.Identity.Web.Resource;
using System.ComponentModel.DataAnnotations;
using Troshka.API.Models.Response.Car;
using Troshka.API.Models.Response.Offer;
using Troshka.API.Models.Response.Vehicle;
using Troshka.Application.Car.Models;
using Troshka.Application.Category.Queries;
using Troshka.Application.Offer.Models;
using Troshka.Application.Offer.Queries.GetSingleCarOffer;
using Troshka.Domain.Entities.VehicleAggregate.Car;
using Troshka.Infrastructure.Data;

namespace Troshka.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/offers/[controller]")]
    [RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
    public class CarsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        private readonly TroshkaDbContext _troshkaRepo;

        public CarsController(IMediator mediator, IMapper mapper, TroshkaDbContext troshkaRepo)
        {
            _mediator = mediator;
            _mapper = mapper;
            _troshkaRepo = troshkaRepo;
        }
        /// <summary>
        /// Get list of car offers
        /// </summary>
        /// <returns>The car offers</returns>
        [HttpGet]
        [EnableQuery(PageSize = 5)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [AllowAnonymous]
        public IQueryable<CarOfferEntity> GetCarOffer()
        {
            return _troshkaRepo.CarOffer;
        }

        /// <summary>
        /// Get offer by <paramref name="offerId"/>
        /// </summary>
        /// <param name="offerId">The Id of the offer</param>
        /// <returns>The offer</returns>
        [HttpGet("{offerId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [AllowAnonymous]
        public async Task<ActionResult<CarOfferResponseModel>> GetCarOffer([FromRoute][Required] string offerId)
        {
            CarOfferModel offerModel = await _mediator.Send(new GetSingleCarOfferQuery() { OfferId = offerId });

            if (offerModel == null)
                return NotFound();

            return Ok(_mapper.Map<CarOfferResponseModel>(offerModel));
        }

        /// <summary>
        /// Get offer images by <paramref name="offerId"/>
        /// </summary>
        /// <param name="offerId">The Id of the offer</param>
        /// <returns>The offer</returns>
        [HttpGet("{offerId}/images")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [AllowAnonymous]
        public async Task<ActionResult<ICollection<CarOfferImagesResponseModel>>> GetCarOfferImages([FromRoute][Required] string offerId)
        {
            return Ok(new List<CarOfferImagesResponseModel>
            {
                new CarOfferImagesResponseModel { ImageUrl = "https://www.topgear.com/sites/default/files/images/cars-road-test/2020/10/b75822a12266632af610f622fab9525d/audiuk00028059_audi_a6_saloon_50_tfsi_e_.jpg"},
                new CarOfferImagesResponseModel { ImageUrl = "https://carsguide-res.cloudinary.com/image/upload/f_auto,fl_lossy,q_auto,t_cg_hero_large/v1/editorial/2020-Audi-A6-55-TFSI-Quattro-S-Line-sedan-black-James-Cleary-1200x800p-%281%29.jpg"},
                new CarOfferImagesResponseModel { ImageUrl = "https://www.autocar.co.uk/sites/autocar.co.uk/files/1-audi-a6-tfsie-2022-road-test-review-lead.jpg"},
            });
        }

        /// <summary>
        /// Get brands by <paramref name="categoryId"/>
        /// </summary>
        /// <param name="categoryId">Category Id</param>
        /// <returns>Brands</returns>
        [HttpGet("brands")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [AllowAnonymous]
        public async Task<ActionResult<ICollection<CategoryResponseModel>>> GetCarBrands()
        {
            ICollection<CarBrandModel> categoryModel = await _mediator.Send(new GetCarBrandsQuery() { });

            if (categoryModel == null)
                return NotFound();

            return Ok(_mapper.Map<ICollection<CarBrandResponseModel>>(categoryModel));
        }
    }
}
