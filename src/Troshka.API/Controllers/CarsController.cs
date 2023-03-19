using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.Graph;
using Microsoft.Identity.Client;
using Microsoft.Identity.Web;
using Microsoft.Identity.Web.Resource;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using Troshka.API.Models.Request;
using Troshka.API.Models.Response.Car;
using Troshka.API.Models.Response.Offer;
using Troshka.Application.Car.Models;
using Troshka.Application.Car.Queries;
using Troshka.Application.Offer.Models;
using Troshka.Application.Offer.Queries.GetSingleCarOffer;
using Troshka.Domain.Entities.VehicleAggregate.Car;
using Troshka.Infrastructure.Data;
using Troshka.Infrastructure.Interfaces;

namespace Troshka.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    [RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
    public class CarsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        private readonly TroshkaDbContext _troshkaRepo;
        private readonly ITokenAcquisition _tokenAcquisition;
        private readonly IMsGraphService _msGraphService;
        private readonly IConfiguration _config;

        public CarsController(IMediator mediator, IMapper mapper, TroshkaDbContext troshkaRepo, ITokenAcquisition tokenAcquisition, IMsGraphService msGraphService, IConfiguration config)
        {
            _mediator = mediator;
            _mapper = mapper;
            _troshkaRepo = troshkaRepo;
            _tokenAcquisition = tokenAcquisition;
            _msGraphService = msGraphService;
            _config = config;
        }
        /// <summary>
        /// Get list of car offers
        /// </summary>
        /// <returns>The car offers</returns>
        [HttpGet("offers")]
        [EnableQuery(PageSize = 10, MaxNodeCount = 1000)]
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
        [HttpGet("offers/{offerId}")]
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
        [HttpGet("offers/{offerId}/images")]
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
        /// Get all car brands
        /// </summary>
        /// <returns>All car brands</returns>
        [HttpGet("brands")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [AllowAnonymous]
        public async Task<ActionResult<ICollection<CarBrandResponseModel>>> GetCarBrands()
        {
            ICollection<CarBrandModel> carBrand = await _mediator.Send(new GetCarBrandsQuery() { });

            if (carBrand == null)
                return NotFound();

            return Ok(_mapper.Map<ICollection<CarBrandResponseModel>>(carBrand));
        }

        /// <summary>
        /// Get all car models by brandId
        /// </summary>
        /// <returns>All car models</returns>
        [HttpGet("brands/{brandId}/models")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [AllowAnonymous]
        public async Task<ActionResult<ICollection<CarModelResponseModel>>> GetCarModels([FromRoute][Required] string brandId)
        {
            ICollection<CarModelModel> carModel = await _mediator.Send(new GetCarModelsQuery() { BrandId = brandId });

            if (carModel == null)
                return NotFound();

            return Ok(_mapper.Map<ICollection<CarModelResponseModel>>(carModel));
        }

        /// <summary>
        /// Get all car engines
        /// </summary>
        /// <returns>All car models</returns>
        [HttpGet("engines")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [AllowAnonymous]
        public async Task<ActionResult<ICollection<CarEngineResponseModel>>> GetCarEnginesModels()
        {
            ICollection<CarEngineModel> carEngineModel = await _mediator.Send(new GetCarEnginesModelQuery());

            if (carEngineModel == null)
                return NotFound();

            return Ok(_mapper.Map<ICollection<CarEngineResponseModel>>(carEngineModel));
        }

        /// <summary>
        /// Get all car transmissions
        /// </summary>
        /// <returns>All car transmissions</returns>
        [HttpGet("transmissions")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [AllowAnonymous]
        public async Task<ActionResult<ICollection<CarTransmissionResponseModel>>> GetCarTransmissionModels()
        {
            ICollection<CarTransmissionModel> carTransmissionModel = await _mediator.Send(new GetCarTransmissionModelQuery());

            if (carTransmissionModel == null)
                return NotFound();

            return Ok(_mapper.Map<ICollection<CarTransmissionResponseModel>>(carTransmissionModel));
        }

        /// <summary>
        /// Get all car transmissions
        /// </summary>
        /// <returns>All car transmissions</returns>
        [HttpGet("categories")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [AllowAnonymous]
        public async Task<ActionResult<ICollection<CarCategoryResponseModel>>> GetCategories()
        {
            ICollection<CarCategoryModel> standardModel = await _mediator.Send(new GetCarCategoriesQuery());

            if (standardModel == null)
                return NotFound();

            return Ok(_mapper.Map<ICollection<CarCategoryResponseModel>>(standardModel));
        }

        /// <summary>
        /// Get euro standard
        /// </summary>
        /// <returns>Euro standards</returns>
        [HttpGet("euro")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [AllowAnonymous]
        public async Task<ActionResult<ICollection<CarEuroStandardResponseModel>>> GetVehicleEuroStandard()
        {
            ICollection<CarEuroStandardModel> standardModel = await _mediator.Send(new GetCarEuroStandardsQuery());

            if (standardModel == null)
                return NotFound();

            return Ok(_mapper.Map<ICollection<CarEuroStandardResponseModel>>(standardModel));
        }

        /// <summary>
        /// Post new car offer
        /// </summary>
        [HttpPost("offers")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [AllowAnonymous]
        public async Task<ActionResult<CarOfferResponseModel>> CreateCarOffer([FromBody][Required] CreateCarOfferRequestModel model)
        {
            var graphClient = new GraphServiceClient(new DelegateAuthenticationProvider(async (requestMessage) =>
            {
                var app = ConfidentialClientApplicationBuilder
                    .Create(_config["AzureAd:ClientId"])
                    .WithClientSecret(_config["AzureAd:ClientSecret"])
                    .WithAuthority(new Uri($"{_config["AzureAd:Instance"]}/{_config["AzureAd:TenantId"]}"))
                    .Build();

                try
                {
                    var authResult = await app.AcquireTokenForClient(new string[] { "https://graph.microsoft.com/.default" })
                        .ExecuteAsync();
                    requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", authResult.AccessToken);

                }
                catch (MsalUiRequiredException ex)
                {
                    // The application doesn't have sufficient permissions.
                    // - Did you declare enough app permissions during app creation?
                    // - Did the tenant admin grant permissions to the application?
                }
                catch (MsalServiceException ex) when (ex.Message.Contains("AADSTS70011"))
                {
                    // Invalid scope. The scope has to be in the form "https://resourceurl/.default"
                    // Mitigation: Change the scope to be as expected.
                }
                catch (Exception ex)
                {

                }

            }));

            var users = await graphClient.Users
                .Request()
                .Select(u => new
                {
                    u.Id,
                    u.DisplayName,
                    u.UserPrincipalName,
                    u.Mail,
                    u.JobTitle
                })
                .GetAsync();

            var userTenant = User.GetTenantId();
            var graphAccessToken = await _tokenAcquisition.GetAccessTokenForUserAsync(new string[] { "https://graph.microsoft.com/.default" }, tenantId: userTenant);
            var x = await _msGraphService.GetUsersAsync(graphAccessToken);
            return null;
        }
    }
}
