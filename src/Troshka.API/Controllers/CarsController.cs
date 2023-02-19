using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;
using System.ComponentModel.DataAnnotations;
using Troshka.Application.Offer.Models;
using Troshka.Application.Offer.Queries.GetSingleCarOffer;

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

        public CarsController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
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
        public async Task<ActionResult<CarOfferModel>> GetCarOffer([FromRoute][Required] string offerId)
        {
            CarOfferModel offerModel = await _mediator.Send(new GetSingleCarOfferQuery() { OfferId = offerId });

            if (offerModel == null)
                return NotFound();

            return Ok(offerModel);
        }
    }
}
