namespace Troshka.API.Models.Response.Offer
{
    public class CarOfferResponseModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string OwnerDisplayName { get; set; }
        public string OwnerPhoneNumber { get; set; }
        public bool OwnerIsDisplayNamePublic { get; set; }
        public string SpecificationYear { get; set; }
        public string SpecificationHorsePowers { get; set; }
        public string SpecificationMileage { get; set; }
        public bool SpecificationIsRegistered { get; set; }
        public DateTimeOffset SpecificationFirstRegistration { get; set; }
        public string SpecificationEngineName { get; set; }
        public string SpecificationEuroName { get; set; }
        public string SpecificationTransmissionName { get; set; }
        public string SpecificationColorName { get; set; }
        public int SpecificationSeatsValue { get; set; }
        public string SpecificationDoorsName { get; set; }
        public string SpecificationInteriorMaterialName { get; set; }
        public string SpecificationInteriorColorName { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public string CategoryName { get; set; }

        public bool EquipmentHasABS { get; set; }
        public bool EquipmentHasESP { get; set; }
        public bool EquipmentHasASR { get; set; }
        public bool EquipmentHasHillStartAssist { get; set; }
        public bool EquipmentHasFatigueWarningSystem { get; set; }
        public bool EquipmentHasLaneChangeAssist { get; set; }
        public bool EquipmentHasBlindSpotAssist { get; set; }
        public bool EquipmentHasNightVisionAssist { get; set; }
        public bool EquipmentHasEmergencyBrakeAssist { get; set; }
        public bool EquipmentHasEmergencyCallSystem { get; set; }
        public bool EquipmentHasTrafficSignRecognition { get; set; }
        public bool EquipmentHasCruiseControl { get; set; }
        public bool EquipmentHasAdaptiveCruiseControl { get; set; }
        public bool EquipmentHasSpeedLimitControlSystem { get; set; }
        public bool EquipmentHasDistanceWarningSystem { get; set; }
        public bool EquipmentHasDriverAirbag { get; set; }
        public bool EquipmentHasFrontAirbags { get; set; }
        public bool EquipmentHasFrontAndSideAirbags { get; set; }
        public bool EquipmentHasFrontAndSideAndMoreAirbags { get; set; }
        public bool EquipmentHasIsofix { get; set; }
        public bool EquipmentHasBiXenonHeadlights { get; set; }
        public bool EquipmentHasLaserHeadlights { get; set; }
        public bool EquipmentHasLedHeadlights { get; set; }
        public bool EquipmentHasXenonHeadlights { get; set; }
        public bool EquipmentHasHeadlightWasherSystem { get; set; }
        public bool EquipmentHasGlareFreeHighBeamHeadlights { get; set; }
        public bool EquipmentHasHighBeamAssist { get; set; }
        public bool EquipmentHasAdaptiveCorneringLights { get; set; }
        public bool EquipmentHasAdaptiveLighting { get; set; }
        public bool EquipmentHasFogLamps { get; set; }
        public bool EquipmentHasAlarm { get; set; }
        public bool EquipmentHasEngineImobilizer { get; set; }

        // Comfort
        public bool EquipmentHasAirConditioner { get; set; }
        public bool EquipmentHasClimateControl { get; set; }
        public bool EquipmentHasHeatedWindshield { get; set; }
        public bool EquipmentHasHeatedSteeringWheel { get; set; }
        public bool EquipmentHasSelfSteeringSystems { get; set; }
        public bool EquipmentHasFrontParkAssistant { get; set; }
        public bool EquipmentHasRearParkAssistant { get; set; }
        public bool EquipmentHasCameraAssistant { get; set; }
        public bool EquipmentHas360DegreeCameraAssistant { get; set; }
        public bool EquipmentHasFrontHeatedSeats { get; set; }
        public bool EquipmentHasBackHeatedSeats { get; set; }
        public bool EquipmentHasFrontAdjustableSeats { get; set; }
        public bool EquipmentHasBackAdjustableSeats { get; set; }
        public bool EquipmentHasSportSeats { get; set; }
        public bool EquipmentHasArmRest { get; set; }
        public bool EquipmentHasMassageSeats { get; set; }
        public bool EquipmentHasSeatVentilation { get; set; }
        public bool EquipmentHasElectricWindows { get; set; }
        public bool EquipmentHasElectricSideMirror { get; set; }
        public bool EquipmentHasElectricTailgate { get; set; }
        public bool EquipmentHasCentralLocking { get; set; }
        public bool EquipmentHasKeylessCentralLocking { get; set; }
        public bool EquipmentHasLightSensor { get; set; }
        public bool EquipmentHasRainSensor { get; set; }
        public bool EquipmentHasPowerAssistedSteering { get; set; }
        public bool EquipmentHasAmbientLighting { get; set; }
        public bool EquipmentHasLeatherSteeringWheel { get; set; }

        // Devices
        public bool EquipmentHasRadio { get; set; }
        public bool EquipmentHasCDPlayer { get; set; }
        public bool EquipmentHasTV { get; set; }
        public bool EquipmentHasNavigationSystem { get; set; }
        public bool EquipmentHasSoundSystem { get; set; }
        public bool EquipmentHasTouchScreen { get; set; }
        public bool EquipmentHasVoiceControl { get; set; }
        public bool EquipmentHasMultifunctionSteeringWheel { get; set; }
        public bool EquipmentHasHandsfreeKit { get; set; }
        public bool EquipmentHasUSBPort { get; set; }
        public bool EquipmentHasBluetooth { get; set; }
        public bool EquipmentHasAppleCarPlay { get; set; }
        public bool EquipmentHasAndroidAuto { get; set; }
        public bool EquipmentHasOnboardComputer { get; set; }
        public bool EquipmentHasHeadupDisplay { get; set; }
        public bool EquipmentHasDigitalCockpit { get; set; }

        // Other
        public bool EquipmentHasSummerTires { get; set; }
        public bool EquipmentHasWinterTires { get; set; }
        public bool EquipmentHasAllSeasonTires { get; set; }
        public bool EquipmentHasEmergencyTire { get; set; }
        public bool EquipmentHasEmergencyTireKit { get; set; }
        public bool EquipmentHasPanoramicRoof { get; set; }
    }
}
