using AutoMapper;
using Troshka.API.Models.Response.Car;
using Troshka.API.Models.Response.Offer;
using Troshka.API.Models.Response.Vehicle;
using Troshka.Application.Car.Models;
using Troshka.Application.Category.Models;
using Troshka.Application.Offer.Models;

namespace Troshka.API
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            #region Car
            CreateMap<CarBrandModel, CarBrandResponseModel>();
            CreateMap<CarModelModel, CarModelResponseModel>();
            CreateMap<CarEngineModel, CarEngineResponseModel>();
            CreateMap<CarTransmissionModel, CarTransmissionResponseModel>();
            CreateMap<CarOfferModel, CarOfferResponseModel>()
            // Specification
            .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
            .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
            .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
            .ForMember(dest => dest.OwnerDisplayName, opt => opt.MapFrom(src => src.Owner.DisplayName))
            .ForMember(dest => dest.OwnerPhone, opt => opt.MapFrom(src => src.Owner.Phone))
            .ForMember(dest => dest.OwnerIsDisplayNamePublic, opt => opt.MapFrom(src => src.Owner.IsDisplayNamePublic))
            .ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Specification.Year))
            .ForMember(dest => dest.HorsePowers, opt => opt.MapFrom(src => src.Specification.HorsePowers))
            .ForMember(dest => dest.Mileage, opt => opt.MapFrom(src => src.Specification.Mileage))
            .ForMember(dest => dest.IsRegistered, opt => opt.MapFrom(src => src.Specification.IsRegistered))
            .ForMember(dest => dest.FirstRegistration, opt => opt.MapFrom(src => src.Specification.FirstRegistration))
            .ForMember(dest => dest.EngineName, opt => opt.MapFrom(src => src.Specification.Engine.Name))
            .ForMember(dest => dest.EuroName, opt => opt.MapFrom(src => src.Specification.Euro.Name))
            .ForMember(dest => dest.TransmissionName, opt => opt.MapFrom(src => src.Specification.Transmission.Name))
            .ForMember(dest => dest.ColorName, opt => opt.MapFrom(src => src.Specification.Color.Name))
            .ForMember(dest => dest.SeatsValue, opt => opt.MapFrom(src => src.Specification.Seats.Value))
            .ForMember(dest => dest.DoorsName, opt => opt.MapFrom(src => src.Specification.Doors.Name))
            .ForMember(dest => dest.InteriorMaterialName, opt => opt.MapFrom(src => src.Specification.InteriorMaterial.Name))
            .ForMember(dest => dest.InteriorColorName, opt => opt.MapFrom(src => src.Specification.InteriorColor.Name))
            .ForMember(dest => dest.BrandName, opt => opt.MapFrom(src => src.Specification.Brand.Name))
            .ForMember(dest => dest.ModelName, opt => opt.MapFrom(src => src.Specification.Model.Name))
            // Equipment
            .ForMember(dest => dest.HasABS, opt => opt.MapFrom(src => src.Equipment.HasABS))
            .ForMember(dest => dest.HasESP, opt => opt.MapFrom(src => src.Equipment.HasESP))
            .ForMember(dest => dest.HasASR, opt => opt.MapFrom(src => src.Equipment.HasASR))
            .ForMember(dest => dest.HasHillStartAssist, opt => opt.MapFrom(src => src.Equipment.HasHillStartAssist))
            .ForMember(dest => dest.HasFatigueWarningSystem, opt => opt.MapFrom(src => src.Equipment.HasFatigueWarningSystem))
            .ForMember(dest => dest.HasLaneChangeAssist, opt => opt.MapFrom(src => src.Equipment.HasLaneChangeAssist))
            .ForMember(dest => dest.HasBlindSpotAssist, opt => opt.MapFrom(src => src.Equipment.HasBlindSpotAssist))
            .ForMember(dest => dest.HasNightVisionAssist, opt => opt.MapFrom(src => src.Equipment.HasNightVisionAssist))
            .ForMember(dest => dest.HasEmergencyBrakeAssist, opt => opt.MapFrom(src => src.Equipment.HasEmergencyBrakeAssist))
            .ForMember(dest => dest.HasEmergencyCallSystem, opt => opt.MapFrom(src => src.Equipment.HasEmergencyCallSystem))
            .ForMember(dest => dest.HasTrafficSignRecognition, opt => opt.MapFrom(src => src.Equipment.HasTrafficSignRecognition))
            .ForMember(dest => dest.HasCruiseControl, opt => opt.MapFrom(src => src.Equipment.HasCruiseControl))
            .ForMember(dest => dest.HasAdaptiveCruiseControl, opt => opt.MapFrom(src => src.Equipment.HasAdaptiveCruiseControl))
            .ForMember(dest => dest.HasSpeedLimitControlSystem, opt => opt.MapFrom(src => src.Equipment.HasSpeedLimitControlSystem))
            .ForMember(dest => dest.HasDistanceWarningSystem, opt => opt.MapFrom(src => src.Equipment.HasDistanceWarningSystem))
            .ForMember(dest => dest.HasDriverAirbag, opt => opt.MapFrom(src => src.Equipment.HasDriverAirbag))
            .ForMember(dest => dest.HasFrontAirbags, opt => opt.MapFrom(src => src.Equipment.HasFrontAirbags))
            .ForMember(dest => dest.HasFrontAndSideAirbags, opt => opt.MapFrom(src => src.Equipment.HasFrontAndSideAirbags))
            .ForMember(dest => dest.HasFrontAndSideAndMoreAirbags, opt => opt.MapFrom(src => src.Equipment.HasFrontAndSideAndMoreAirbags))
            .ForMember(dest => dest.HasIsofix, opt => opt.MapFrom(src => src.Equipment.HasIsofix))
            .ForMember(dest => dest.HasBiXenonHeadlights, opt => opt.MapFrom(src => src.Equipment.HasBiXenonHeadlights))
            .ForMember(dest => dest.HasLaserHeadlights, opt => opt.MapFrom(src => src.Equipment.HasLaserHeadlights))
            .ForMember(dest => dest.HasLedHeadlights, opt => opt.MapFrom(src => src.Equipment.HasLedHeadlights))
            .ForMember(dest => dest.HasXenonHeadlights, opt => opt.MapFrom(src => src.Equipment.HasXenonHeadlights))
            .ForMember(dest => dest.HasHeadlightWasherSystem, opt => opt.MapFrom(src => src.Equipment.HasHeadlightWasherSystem))
            .ForMember(dest => dest.HasGlareFreeHighBeamHeadlights, opt => opt.MapFrom(src => src.Equipment.HasGlareFreeHighBeamHeadlights))
            .ForMember(dest => dest.HasHighBeamAssist, opt => opt.MapFrom(src => src.Equipment.HasHighBeamAssist))
            .ForMember(dest => dest.HasAdaptiveCorneringLights, opt => opt.MapFrom(src => src.Equipment.HasAdaptiveCorneringLights))
            .ForMember(dest => dest.HasAdaptiveLighting, opt => opt.MapFrom(src => src.Equipment.HasAdaptiveLighting))
            .ForMember(dest => dest.HasFogLamps, opt => opt.MapFrom(src => src.Equipment.HasFogLamps))
            .ForMember(dest => dest.HasAlarm, opt => opt.MapFrom(src => src.Equipment.HasAlarm))
            .ForMember(dest => dest.HasEngineImobilizer, opt => opt.MapFrom(src => src.Equipment.HasEngineImobilizer))
            .ForMember(dest => dest.HasAirConditioner, opt => opt.MapFrom(src => src.Equipment.HasAirConditioner))
            .ForMember(dest => dest.HasClimateControl, opt => opt.MapFrom(src => src.Equipment.HasClimateControl))
            .ForMember(dest => dest.HasHeatedWindshield, opt => opt.MapFrom(src => src.Equipment.HasHeatedWindshield))
            .ForMember(dest => dest.HasHeatedSteeringWheel, opt => opt.MapFrom(src => src.Equipment.HasHeatedSteeringWheel))
            .ForMember(dest => dest.HasSelfSteeringSystems, opt => opt.MapFrom(src => src.Equipment.HasSelfSteeringSystems))
            .ForMember(dest => dest.HasFrontParkAssistant, opt => opt.MapFrom(src => src.Equipment.HasFrontParkAssistant))
            .ForMember(dest => dest.HasRearParkAssistant, opt => opt.MapFrom(src => src.Equipment.HasRearParkAssistant))
            .ForMember(dest => dest.HasCameraAssistant, opt => opt.MapFrom(src => src.Equipment.HasCameraAssistant))
            .ForMember(dest => dest.Has360DegreeCameraAssistant, opt => opt.MapFrom(src => src.Equipment.Has360DegreeCameraAssistant))
            .ForMember(dest => dest.HasFrontHeatedSeats, opt => opt.MapFrom(src => src.Equipment.HasFrontHeatedSeats))
            .ForMember(dest => dest.HasBackHeatedSeats, opt => opt.MapFrom(src => src.Equipment.HasBackHeatedSeats))
            .ForMember(dest => dest.HasFrontAdjustableSeats, opt => opt.MapFrom(src => src.Equipment.HasFrontAdjustableSeats))
            .ForMember(dest => dest.HasBackAdjustableSeats, opt => opt.MapFrom(src => src.Equipment.HasBackAdjustableSeats))
            .ForMember(dest => dest.HasSportSeats, opt => opt.MapFrom(src => src.Equipment.HasSportSeats))
            .ForMember(dest => dest.HasArmRest, opt => opt.MapFrom(src => src.Equipment.HasArmRest))
            .ForMember(dest => dest.HasMassageSeats, opt => opt.MapFrom(src => src.Equipment.HasMassageSeats))
            .ForMember(dest => dest.HasSeatVentilation, opt => opt.MapFrom(src => src.Equipment.HasSeatVentilation))
            .ForMember(dest => dest.HasElectricWindows, opt => opt.MapFrom(src => src.Equipment.HasElectricWindows))
            .ForMember(dest => dest.HasElectricSideMirror, opt => opt.MapFrom(src => src.Equipment.HasElectricSideMirror))
            .ForMember(dest => dest.HasElectricTailgate, opt => opt.MapFrom(src => src.Equipment.HasElectricTailgate))
            .ForMember(dest => dest.HasCentralLocking, opt => opt.MapFrom(src => src.Equipment.HasCentralLocking))
            .ForMember(dest => dest.HasKeylessCentralLocking, opt => opt.MapFrom(src => src.Equipment.HasKeylessCentralLocking))
            .ForMember(dest => dest.HasLightSensor, opt => opt.MapFrom(src => src.Equipment.HasLightSensor))
            .ForMember(dest => dest.HasRainSensor, opt => opt.MapFrom(src => src.Equipment.HasRainSensor))
            .ForMember(dest => dest.HasPowerAssistedSteering, opt => opt.MapFrom(src => src.Equipment.HasPowerAssistedSteering))
            .ForMember(dest => dest.HasAmbientLighting, opt => opt.MapFrom(src => src.Equipment.HasAmbientLighting))
            .ForMember(dest => dest.HasLeatherSteeringWheel, opt => opt.MapFrom(src => src.Equipment.HasLeatherSteeringWheel))
            .ForMember(dest => dest.HasRadio, opt => opt.MapFrom(src => src.Equipment.HasRadio))
            .ForMember(dest => dest.HasCDPlayer, opt => opt.MapFrom(src => src.Equipment.HasCDPlayer))
            .ForMember(dest => dest.HasTV, opt => opt.MapFrom(src => src.Equipment.HasTV))
            .ForMember(dest => dest.HasNavigationSystem, opt => opt.MapFrom(src => src.Equipment.HasNavigationSystem))
            .ForMember(dest => dest.HasSoundSystem, opt => opt.MapFrom(src => src.Equipment.HasSoundSystem))
            .ForMember(dest => dest.HasTouchScreen, opt => opt.MapFrom(src => src.Equipment.HasTouchScreen))
            .ForMember(dest => dest.HasVoiceControl, opt => opt.MapFrom(src => src.Equipment.HasVoiceControl))
            .ForMember(dest => dest.HasMultifunctionSteeringWheel, opt => opt.MapFrom(src => src.Equipment.HasMultifunctionSteeringWheel))
            .ForMember(dest => dest.HasHandsfreeKit, opt => opt.MapFrom(src => src.Equipment.HasHandsfreeKit))
            .ForMember(dest => dest.HasUSBPort, opt => opt.MapFrom(src => src.Equipment.HasUSBPort))
            .ForMember(dest => dest.HasBluetooth, opt => opt.MapFrom(src => src.Equipment.HasBluetooth))
            .ForMember(dest => dest.HasAppleCarPlay, opt => opt.MapFrom(src => src.Equipment.HasAppleCarPlay))
            .ForMember(dest => dest.HasAndroidAuto, opt => opt.MapFrom(src => src.Equipment.HasAndroidAuto))
            .ForMember(dest => dest.HasOnboardComputer, opt => opt.MapFrom(src => src.Equipment.HasOnboardComputer))
            .ForMember(dest => dest.HasHeadupDisplay, opt => opt.MapFrom(src => src.Equipment.HasHeadupDisplay))
            .ForMember(dest => dest.HasDigitalCockpit, opt => opt.MapFrom(src => src.Equipment.HasDigitalCockpit))
            .ForMember(dest => dest.HasSummerTires, opt => opt.MapFrom(src => src.Equipment.HasSummerTires))
            .ForMember(dest => dest.HasWinterTires, opt => opt.MapFrom(src => src.Equipment.HasWinterTires))
            .ForMember(dest => dest.HasAllSeasonTires, opt => opt.MapFrom(src => src.Equipment.HasAllSeasonTires))
            .ForMember(dest => dest.HasEmergencyTire, opt => opt.MapFrom(src => src.Equipment.HasEmergencyTire))
            .ForMember(dest => dest.HasEmergencyTireKit, opt => opt.MapFrom(src => src.Equipment.HasEmergencyTireKit))
            .ForMember(dest => dest.HasPanoramicRoof, opt => opt.MapFrom(src => src.Equipment.HasPanoramicRoof));
            #endregion Car

            #region Vehicles (Generic)
            CreateMap<CategoryModel, CategoryResponseModel>();
            CreateMap<RegionModel, RegionResponseModel>();
            CreateMap<LocationModel, LocationResponseModel>();
            #endregion Vehicles (Generic)
        }
    }
}
