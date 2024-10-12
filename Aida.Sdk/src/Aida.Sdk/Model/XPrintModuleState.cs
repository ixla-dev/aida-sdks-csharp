/*
 * aida
 *
 * 1.0.713
 *
 * The version of the OpenAPI document: 1.0.713
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = Aida.Sdk.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Model
{
    /// <summary>
    /// XPrintModuleState
    /// </summary>
    [DataContract(Name = "XPrintModuleState")]
    public partial class XPrintModuleState : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets MainSystemStatus
        /// </summary>
        [DataMember(Name = "mainSystemStatus", EmitDefaultValue = false)]
        public XPrintMainSystemStatus? MainSystemStatus { get; set; }

        /// <summary>
        /// Gets or Sets MainSubSystemStatus
        /// </summary>
        [DataMember(Name = "mainSubSystemStatus", EmitDefaultValue = false)]
        public XPrintMainSubsystemStatus? MainSubSystemStatus { get; set; }

        /// <summary>
        /// Gets or Sets SystemTemperatureStatus
        /// </summary>
        [DataMember(Name = "systemTemperatureStatus", EmitDefaultValue = false)]
        public XPrintSystemTemperatureStatus? SystemTemperatureStatus { get; set; }

        /// <summary>
        /// Gets or Sets PrintHeadTemperatureStatus
        /// </summary>
        [DataMember(Name = "printHeadTemperatureStatus", EmitDefaultValue = false)]
        public XPrintPrintHeadTemperatureStatus? PrintHeadTemperatureStatus { get; set; }

        /// <summary>
        /// Gets or Sets TransportAxisStatus
        /// </summary>
        [DataMember(Name = "transportAxisStatus", EmitDefaultValue = false)]
        public XPrintTransportAxisStatus? TransportAxisStatus { get; set; }

        /// <summary>
        /// Gets or Sets HeadAxisStatus
        /// </summary>
        [DataMember(Name = "headAxisStatus", EmitDefaultValue = false)]
        public XPrintHeadAxisStatus? HeadAxisStatus { get; set; }

        /// <summary>
        /// Gets or Sets CappingStationStatus
        /// </summary>
        [DataMember(Name = "cappingStationStatus", EmitDefaultValue = false)]
        public XPrintCappingStationStatus? CappingStationStatus { get; set; }

        /// <summary>
        /// Gets or Sets PowerSupplyStatus
        /// </summary>
        [DataMember(Name = "powerSupplyStatus", EmitDefaultValue = false)]
        public XPrintPowerSupplyStatus? PowerSupplyStatus { get; set; }

        /// <summary>
        /// Gets or Sets Doors
        /// </summary>
        [DataMember(Name = "doors", EmitDefaultValue = false)]
        public XPrintDoorStatusFlags? Doors { get; set; }

        /// <summary>
        /// Gets or Sets ClosedPhotoSensors
        /// </summary>
        [DataMember(Name = "closedPhotoSensors", EmitDefaultValue = false)]
        public XPrintPhotoSensors? ClosedPhotoSensors { get; set; }

        /// <summary>
        /// Gets or Sets TransportAxisPosition
        /// </summary>
        [DataMember(Name = "transportAxisPosition", EmitDefaultValue = false)]
        public XPrintTransportAxisPositionFlags? TransportAxisPosition { get; set; }

        /// <summary>
        /// Gets or Sets HeadAxisPositions
        /// </summary>
        [DataMember(Name = "headAxisPositions", EmitDefaultValue = false)]
        public XPrintHeadAxisPositionFlags? HeadAxisPositions { get; set; }

        /// <summary>
        /// Gets or Sets CappingInfo
        /// </summary>
        [DataMember(Name = "cappingInfo", EmitDefaultValue = false)]
        public XPrintCappingInfo? CappingInfo { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="XPrintModuleState" /> class.
        /// </summary>
        /// <param name="moduleId">moduleId.</param>
        /// <param name="statusChangeId">statusChangeId.</param>
        /// <param name="hardwareRevision">hardwareRevision.</param>
        /// <param name="firmwareRevision">firmwareRevision.</param>
        /// <param name="mainSystemStatus">mainSystemStatus.</param>
        /// <param name="mainSubSystemStatus">mainSubSystemStatus.</param>
        /// <param name="systemTemperatureStatus">systemTemperatureStatus.</param>
        /// <param name="printHeadTemperatureStatus">printHeadTemperatureStatus.</param>
        /// <param name="transportAxisStatus">transportAxisStatus.</param>
        /// <param name="headAxisStatus">headAxisStatus.</param>
        /// <param name="cappingStationStatus">cappingStationStatus.</param>
        /// <param name="powerSupplyStatus">powerSupplyStatus.</param>
        /// <param name="doors">doors.</param>
        /// <param name="closedPhotoSensors">closedPhotoSensors.</param>
        /// <param name="transportAxisPosition">transportAxisPosition.</param>
        /// <param name="headAxisPositions">headAxisPositions.</param>
        /// <param name="cappingInfo">cappingInfo.</param>
        /// <param name="transportBoardSerialNumber">transportBoardSerialNumber.</param>
        /// <param name="vacuumPressure">vacuumPressure.</param>
        /// <param name="heaterTemperature">heaterTemperature.</param>
        /// <param name="heaterTemperatureSet">heaterTemperatureSet.</param>
        /// <param name="printHeadTemperature">printHeadTemperature.</param>
        /// <param name="boardTemperature">boardTemperature.</param>
        /// <param name="boardTemperature2">boardTemperature2.</param>
        /// <param name="internalSystemTemperature">internalSystemTemperature.</param>
        /// <param name="transportAxisMotorRaw">transportAxisMotorRaw.</param>
        /// <param name="headAxisMotorRaw">headAxisMotorRaw.</param>
        /// <param name="transportAxisEncoderPosition">transportAxisEncoderPosition.</param>
        /// <param name="headAxisEncoderPosition">headAxisEncoderPosition.</param>
        /// <param name="feedback12V">feedback12V.</param>
        /// <param name="feedback24V">feedback24V.</param>
        /// <param name="feedback48V">feedback48V.</param>
        /// <param name="printInProgress">printInProgress.</param>
        public XPrintModuleState(int moduleId = default(int), int statusChangeId = default(int), string hardwareRevision = default(string), string firmwareRevision = default(string), XPrintMainSystemStatus? mainSystemStatus = default(XPrintMainSystemStatus?), XPrintMainSubsystemStatus? mainSubSystemStatus = default(XPrintMainSubsystemStatus?), XPrintSystemTemperatureStatus? systemTemperatureStatus = default(XPrintSystemTemperatureStatus?), XPrintPrintHeadTemperatureStatus? printHeadTemperatureStatus = default(XPrintPrintHeadTemperatureStatus?), XPrintTransportAxisStatus? transportAxisStatus = default(XPrintTransportAxisStatus?), XPrintHeadAxisStatus? headAxisStatus = default(XPrintHeadAxisStatus?), XPrintCappingStationStatus? cappingStationStatus = default(XPrintCappingStationStatus?), XPrintPowerSupplyStatus? powerSupplyStatus = default(XPrintPowerSupplyStatus?), XPrintDoorStatusFlags? doors = default(XPrintDoorStatusFlags?), XPrintPhotoSensors? closedPhotoSensors = default(XPrintPhotoSensors?), XPrintTransportAxisPositionFlags? transportAxisPosition = default(XPrintTransportAxisPositionFlags?), XPrintHeadAxisPositionFlags? headAxisPositions = default(XPrintHeadAxisPositionFlags?), XPrintCappingInfo? cappingInfo = default(XPrintCappingInfo?), string transportBoardSerialNumber = default(string), float vacuumPressure = default(float), float heaterTemperature = default(float), float heaterTemperatureSet = default(float), float printHeadTemperature = default(float), float boardTemperature = default(float), float boardTemperature2 = default(float), float internalSystemTemperature = default(float), int transportAxisMotorRaw = default(int), int headAxisMotorRaw = default(int), int transportAxisEncoderPosition = default(int), int headAxisEncoderPosition = default(int), float feedback12V = default(float), float feedback24V = default(float), float feedback48V = default(float), bool printInProgress = default(bool))
        {
            this.ModuleId = moduleId;
            this.StatusChangeId = statusChangeId;
            this.HardwareRevision = hardwareRevision;
            this.FirmwareRevision = firmwareRevision;
            this.MainSystemStatus = mainSystemStatus;
            this.MainSubSystemStatus = mainSubSystemStatus;
            this.SystemTemperatureStatus = systemTemperatureStatus;
            this.PrintHeadTemperatureStatus = printHeadTemperatureStatus;
            this.TransportAxisStatus = transportAxisStatus;
            this.HeadAxisStatus = headAxisStatus;
            this.CappingStationStatus = cappingStationStatus;
            this.PowerSupplyStatus = powerSupplyStatus;
            this.Doors = doors;
            this.ClosedPhotoSensors = closedPhotoSensors;
            this.TransportAxisPosition = transportAxisPosition;
            this.HeadAxisPositions = headAxisPositions;
            this.CappingInfo = cappingInfo;
            this.TransportBoardSerialNumber = transportBoardSerialNumber;
            this.VacuumPressure = vacuumPressure;
            this.HeaterTemperature = heaterTemperature;
            this.HeaterTemperatureSet = heaterTemperatureSet;
            this.PrintHeadTemperature = printHeadTemperature;
            this.BoardTemperature = boardTemperature;
            this.BoardTemperature2 = boardTemperature2;
            this.InternalSystemTemperature = internalSystemTemperature;
            this.TransportAxisMotorRaw = transportAxisMotorRaw;
            this.HeadAxisMotorRaw = headAxisMotorRaw;
            this.TransportAxisEncoderPosition = transportAxisEncoderPosition;
            this.HeadAxisEncoderPosition = headAxisEncoderPosition;
            this.Feedback12V = feedback12V;
            this.Feedback24V = feedback24V;
            this.Feedback48V = feedback48V;
            this.PrintInProgress = printInProgress;
        }

        /// <summary>
        /// Gets or Sets ModuleId
        /// </summary>
        [DataMember(Name = "moduleId", EmitDefaultValue = false)]
        public int ModuleId { get; set; }

        /// <summary>
        /// Gets or Sets StatusChangeId
        /// </summary>
        [DataMember(Name = "statusChangeId", EmitDefaultValue = false)]
        public int StatusChangeId { get; set; }

        /// <summary>
        /// Gets or Sets HardwareRevision
        /// </summary>
        [DataMember(Name = "hardwareRevision", EmitDefaultValue = true)]
        public string HardwareRevision { get; set; }

        /// <summary>
        /// Gets or Sets FirmwareRevision
        /// </summary>
        [DataMember(Name = "firmwareRevision", EmitDefaultValue = true)]
        public string FirmwareRevision { get; set; }

        /// <summary>
        /// Gets or Sets TransportBoardSerialNumber
        /// </summary>
        [DataMember(Name = "transportBoardSerialNumber", EmitDefaultValue = true)]
        public string TransportBoardSerialNumber { get; set; }

        /// <summary>
        /// Gets or Sets VacuumPressure
        /// </summary>
        [DataMember(Name = "vacuumPressure", EmitDefaultValue = false)]
        public float VacuumPressure { get; set; }

        /// <summary>
        /// Gets or Sets HeaterTemperature
        /// </summary>
        [DataMember(Name = "heaterTemperature", EmitDefaultValue = false)]
        public float HeaterTemperature { get; set; }

        /// <summary>
        /// Gets or Sets HeaterTemperatureSet
        /// </summary>
        [DataMember(Name = "heaterTemperatureSet", EmitDefaultValue = false)]
        public float HeaterTemperatureSet { get; set; }

        /// <summary>
        /// Gets or Sets PrintHeadTemperature
        /// </summary>
        [DataMember(Name = "printHeadTemperature", EmitDefaultValue = false)]
        public float PrintHeadTemperature { get; set; }

        /// <summary>
        /// Gets or Sets BoardTemperature
        /// </summary>
        [DataMember(Name = "boardTemperature", EmitDefaultValue = false)]
        public float BoardTemperature { get; set; }

        /// <summary>
        /// Gets or Sets BoardTemperature2
        /// </summary>
        [DataMember(Name = "boardTemperature2", EmitDefaultValue = false)]
        public float BoardTemperature2 { get; set; }

        /// <summary>
        /// Gets or Sets InternalSystemTemperature
        /// </summary>
        [DataMember(Name = "internalSystemTemperature", EmitDefaultValue = false)]
        public float InternalSystemTemperature { get; set; }

        /// <summary>
        /// Gets or Sets TransportAxisMotorRaw
        /// </summary>
        [DataMember(Name = "transportAxisMotorRaw", EmitDefaultValue = false)]
        public int TransportAxisMotorRaw { get; set; }

        /// <summary>
        /// Gets or Sets HeadAxisMotorRaw
        /// </summary>
        [DataMember(Name = "headAxisMotorRaw", EmitDefaultValue = false)]
        public int HeadAxisMotorRaw { get; set; }

        /// <summary>
        /// Gets or Sets TransportAxisEncoderPosition
        /// </summary>
        [DataMember(Name = "transportAxisEncoderPosition", EmitDefaultValue = false)]
        public int TransportAxisEncoderPosition { get; set; }

        /// <summary>
        /// Gets or Sets HeadAxisEncoderPosition
        /// </summary>
        [DataMember(Name = "headAxisEncoderPosition", EmitDefaultValue = false)]
        public int HeadAxisEncoderPosition { get; set; }

        /// <summary>
        /// Gets or Sets Feedback12V
        /// </summary>
        [DataMember(Name = "feedback12V", EmitDefaultValue = false)]
        public float Feedback12V { get; set; }

        /// <summary>
        /// Gets or Sets Feedback24V
        /// </summary>
        [DataMember(Name = "feedback24V", EmitDefaultValue = false)]
        public float Feedback24V { get; set; }

        /// <summary>
        /// Gets or Sets Feedback48V
        /// </summary>
        [DataMember(Name = "feedback48V", EmitDefaultValue = false)]
        public float Feedback48V { get; set; }

        /// <summary>
        /// Gets or Sets PrintInProgress
        /// </summary>
        [DataMember(Name = "printInProgress", EmitDefaultValue = true)]
        public bool PrintInProgress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class XPrintModuleState {\n");
            sb.Append("  ModuleId: ").Append(ModuleId).Append("\n");
            sb.Append("  StatusChangeId: ").Append(StatusChangeId).Append("\n");
            sb.Append("  HardwareRevision: ").Append(HardwareRevision).Append("\n");
            sb.Append("  FirmwareRevision: ").Append(FirmwareRevision).Append("\n");
            sb.Append("  MainSystemStatus: ").Append(MainSystemStatus).Append("\n");
            sb.Append("  MainSubSystemStatus: ").Append(MainSubSystemStatus).Append("\n");
            sb.Append("  SystemTemperatureStatus: ").Append(SystemTemperatureStatus).Append("\n");
            sb.Append("  PrintHeadTemperatureStatus: ").Append(PrintHeadTemperatureStatus).Append("\n");
            sb.Append("  TransportAxisStatus: ").Append(TransportAxisStatus).Append("\n");
            sb.Append("  HeadAxisStatus: ").Append(HeadAxisStatus).Append("\n");
            sb.Append("  CappingStationStatus: ").Append(CappingStationStatus).Append("\n");
            sb.Append("  PowerSupplyStatus: ").Append(PowerSupplyStatus).Append("\n");
            sb.Append("  Doors: ").Append(Doors).Append("\n");
            sb.Append("  ClosedPhotoSensors: ").Append(ClosedPhotoSensors).Append("\n");
            sb.Append("  TransportAxisPosition: ").Append(TransportAxisPosition).Append("\n");
            sb.Append("  HeadAxisPositions: ").Append(HeadAxisPositions).Append("\n");
            sb.Append("  CappingInfo: ").Append(CappingInfo).Append("\n");
            sb.Append("  TransportBoardSerialNumber: ").Append(TransportBoardSerialNumber).Append("\n");
            sb.Append("  VacuumPressure: ").Append(VacuumPressure).Append("\n");
            sb.Append("  HeaterTemperature: ").Append(HeaterTemperature).Append("\n");
            sb.Append("  HeaterTemperatureSet: ").Append(HeaterTemperatureSet).Append("\n");
            sb.Append("  PrintHeadTemperature: ").Append(PrintHeadTemperature).Append("\n");
            sb.Append("  BoardTemperature: ").Append(BoardTemperature).Append("\n");
            sb.Append("  BoardTemperature2: ").Append(BoardTemperature2).Append("\n");
            sb.Append("  InternalSystemTemperature: ").Append(InternalSystemTemperature).Append("\n");
            sb.Append("  TransportAxisMotorRaw: ").Append(TransportAxisMotorRaw).Append("\n");
            sb.Append("  HeadAxisMotorRaw: ").Append(HeadAxisMotorRaw).Append("\n");
            sb.Append("  TransportAxisEncoderPosition: ").Append(TransportAxisEncoderPosition).Append("\n");
            sb.Append("  HeadAxisEncoderPosition: ").Append(HeadAxisEncoderPosition).Append("\n");
            sb.Append("  Feedback12V: ").Append(Feedback12V).Append("\n");
            sb.Append("  Feedback24V: ").Append(Feedback24V).Append("\n");
            sb.Append("  Feedback48V: ").Append(Feedback48V).Append("\n");
            sb.Append("  PrintInProgress: ").Append(PrintInProgress).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
