using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;
using System.ComponentModel.DataAnnotations;
using Troshka.API.Models;
using Troshka.API.Models.Response.Vehicle;

namespace Troshka.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    [RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
    public class VehiclesController : ControllerBase
    {
        /// <summary>
        /// Get vehicle by <paramref name="vehicleId"/>
        /// </summary>
        /// <param name="vehicleId">Vehicle Id</param>
        /// <returns>Vehicle</returns>
        [HttpGet("{vehicleId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [AllowAnonymous]
        public async Task<ActionResult<VehicleResponseModel>> GetVehicleData([FromRoute][Required] long vehicleId)
        {
            Thread.Sleep(150);

            var vehicle = new VehicleResponseModel
            {
                TechnicalSpecification = new VehicleSpecification
                {
                    Brand = "Audi",
                    Category = "Лек автомобил",
                    Color = "Черен",
                    Description = "\r\nПЕРФЕКТНО ТЕХНИЧЕСКО СЪСТОЯНИЕ - облужена на 125 000 км. + нови преди и задна накладки, подгряване и обдухване + памет на предни и задни дедалки, Серво затваряне на врати и багажник, Седалки Panamera Turbo с Finna Nappa кожа, Табло и врати с Finna Nappa кожа, Безключов достъп и запалвне, BOSE музика, Пияно лак пакет, Алкантара таван, 360 градуса камери към парктроника, 19 цола оригинални джанти със зимни гуми и летни гуми, Печка, Летни стелки оригинални, Два ключа + дистанционно за печката, ВЪЗМОЖЕН СОБСТВЕН ЛИЗИНГ ЗА КЛИЕНТИ НА АГРО ХАУС БУРГАС, РАМА: WP0ZZZ97ZHL131627Amazing car, must see!",
                    Doors = "4(5)",
                    Engine = "Дизел",
                    Euro = 6,
                    FirstRegistration = DateTime.Now.AddYears(-6).ToString("yyyy MMMM"),
                    InteriorColor = "Син",
                    InteriorMaterial = "Алкантара",
                    IsRegistered = true,
                    Mileage = 195000,
                    Model = "A6",
                    Price = 24500,
                    Seats = 5,
                    Transmission = "Автоматик",
                    Year = 2015
                },
                Equipment = new VehicleEquipment
                {
                    Has360DegreeCameraAssistant = true,
                    HasABS = true,
                    HasAdaptiveCorneringLights = true,
                    HasAdaptiveCruiseControl = true,
                    HasAdaptiveLighting = true,
                    HasAirConditioner = true,
                    HasAlarm = true,
                    HasAllSeasonTires = true,
                    HasAndroidAuto = true,
                    HasBackAdjustableSeats = true,
                    HasBackHeatedSeats = true,
                    HasBluetooth = true,
                    HasCameraAssistant = true,
                    HasCentralLocking = true,
                    HasClimateControl = true,
                    HasCruiseControl = true,
                    HasBlindSpotAssist = true,
                    HasDriverAirbag = true,
                    HasEmergencyBrakeAssist = true,
                    HasHeadupDisplay = true,
                    HasKeylessCentralLocking = true,
                    HasMassageSeats = true,
                    HasPanoramicRoof = true,
                    HasXenonHeadlights = true,
                }
            };

            return Ok(vehicle);
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
        public async Task<ActionResult<ICollection<VehicleImageResponseModel>>> GetVehicleImages([FromRoute][Required] long vehicleId)
        {
            Thread.Sleep(750);

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
        public async Task<ActionResult<VehicleOwnerResponseModel>> GetVehicleOwner([FromRoute][Required] long vehicleId)
        {
            Thread.Sleep(50);

            return Ok(new VehicleOwnerResponseModel
            {
                DisplayName = "Kaloyan Drenski",
                Phone = "0888 77 88 77"
            });
        }
    }
}
