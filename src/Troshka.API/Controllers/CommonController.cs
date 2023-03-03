using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;
using System.ComponentModel.DataAnnotations;
using Troshka.API.Models.Response.Vehicle;
using Troshka.Application.Category.Models;
using Troshka.Application.Category.Queries;
using Troshka.Application.Offer.Models;
using Troshka.Application.Region.Queries;

namespace Troshka.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    [RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
    public class CommonController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public CommonController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        /// <summary>
        /// Get vehicle by <paramref name="vehicleId"/>
        /// </summary>
        /// <param name="vehicleId">Vehicle Id</param>
        /// <returns>Vehicle</returns>
        [HttpGet("categories")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [AllowAnonymous]
        public async Task<ActionResult<ICollection<CategoryResponseModel>>> GetVehicleCategories()
        {
            ICollection<CategoryModel> categoryModel = await _mediator.Send(new GetCategoriesQuery());

            if (categoryModel == null)
                return NotFound();

            return Ok(_mapper.Map<ICollection<CategoryResponseModel>>(categoryModel));
        }

        /// <summary>
        /// Get vehicle images by <paramref name="vehicleId"/>
        /// </summary>
        /// <param name="vehicleId">Vehicle Id</param>
        /// <returns>Images of the vehicle</returns>
        [HttpGet("{vehicleId}/images")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [AllowAnonymous]
        public async Task<ActionResult<ICollection<VehicleImageResponseModel>>> GetVehicleImages([FromRoute][Required] string vehicleId)
        {
            return Ok(new List<VehicleImageResponseModel>
            {
                new VehicleImageResponseModel { ImageUrl = "https://www.topgear.com/sites/default/files/images/cars-road-test/2020/10/b75822a12266632af610f622fab9525d/audiuk00028059_audi_a6_saloon_50_tfsi_e_.jpg"},
                new VehicleImageResponseModel { ImageUrl = "https://carsguide-res.cloudinary.com/image/upload/f_auto,fl_lossy,q_auto,t_cg_hero_large/v1/editorial/2020-Audi-A6-55-TFSI-Quattro-S-Line-sedan-black-James-Cleary-1200x800p-%281%29.jpg"},
                new VehicleImageResponseModel { ImageUrl = "https://www.autocar.co.uk/sites/autocar.co.uk/files/1-audi-a6-tfsie-2022-road-test-review-lead.jpg"},
            });
        }

        /// <summary>
        /// Get vehicle owner / creator of the ad by <paramref name="vehicleId"/>
        /// </summary>
        /// <param name="vehicleId">The Id of the vehicle</param>
        /// <returns>Vehicle owner information</returns>
        [HttpGet("{vehicleId}/owner")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [AllowAnonymous]
        public async Task<ActionResult<VehicleOwnerResponseModel>> GetVehicleOwner([FromRoute][Required] string vehicleId)
        {
            return Ok(new VehicleOwnerResponseModel
            {
                Id = "dasfsdcasxc",
                DisplayName = "Kaloyan Drenski",
                Phone = "0888 77 88 77"
            });
        }

        /// <summary>
        /// Get location by Area Id
        /// </summary>
        /// <returns>All locations in given area</returns>
        [HttpGet("regions/{regionId}/locations")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [AllowAnonymous]
        public async Task<ActionResult<ICollection<LocationResponseModel>>> GetLocations([FromRoute][Required] string regionId)
        {
            ICollection<LocationModel> locationsModel = await _mediator.Send(new GetLocationsQuery() { RegionId = regionId });

            if (locationsModel == null)
                return NotFound();

            return Ok(_mapper.Map<ICollection<LocationResponseModel>>(locationsModel));
        }
    }
}
