/*
 * aida
 *
 * 1.0.721-rc.9+f020d61fcb6ef6ebe31e8b3974d429a24c2e10d0
 *
 * The version of the OpenAPI document: 1.0.721-rc.9+f020d61fcb6ef6ebe31e8b3974d429a24c2e10d0
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
    /// PrinterStateDto
    /// </summary>
    [DataContract(Name = "PrinterStateDto")]
    public partial class PrinterStateDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets XPrintHeadPosition
        /// </summary>
        [DataMember(Name = "xPrintHeadPosition", EmitDefaultValue = false)]
        public XPrintHeadAxisPositionFlags? XPrintHeadPosition { get; set; }

        /// <summary>
        /// Gets or Sets Positions
        /// </summary>
        [DataMember(Name = "positions", EmitDefaultValue = false)]
        public XPrintTransportAxisPositionFlags? Positions { get; set; }

        /// <summary>
        /// Gets or Sets DoorsStatusFlags
        /// </summary>
        [DataMember(Name = "doorsStatusFlags", EmitDefaultValue = false)]
        public XPrintDoorStatusFlags? DoorsStatusFlags { get; set; }

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
        /// Initializes a new instance of the <see cref="PrinterStateDto" /> class.
        /// </summary>
        /// <param name="vacuumPressureMillibar">vacuumPressureMillibar.</param>
        /// <param name="xPrintHeadPosition">xPrintHeadPosition.</param>
        /// <param name="positions">positions.</param>
        /// <param name="temperatureReadings">temperatureReadings.</param>
        /// <param name="voltageReadings">voltageReadings.</param>
        /// <param name="doorsStatusFlags">doorsStatusFlags.</param>
        /// <param name="mainSystemStatus">mainSystemStatus.</param>
        /// <param name="mainSubSystemStatus">mainSubSystemStatus.</param>
        /// <param name="xAxis">xAxis.</param>
        /// <param name="yAxis">yAxis.</param>
        public PrinterStateDto(float vacuumPressureMillibar = default(float), XPrintHeadAxisPositionFlags? xPrintHeadPosition = default(XPrintHeadAxisPositionFlags?), XPrintTransportAxisPositionFlags? positions = default(XPrintTransportAxisPositionFlags?), TemperatureReadingsDto temperatureReadings = default(TemperatureReadingsDto), VoltageReadingsDto voltageReadings = default(VoltageReadingsDto), XPrintDoorStatusFlags? doorsStatusFlags = default(XPrintDoorStatusFlags?), XPrintMainSystemStatus? mainSystemStatus = default(XPrintMainSystemStatus?), XPrintMainSubsystemStatus? mainSubSystemStatus = default(XPrintMainSubsystemStatus?), int xAxis = default(int), int yAxis = default(int))
        {
            this.VacuumPressureMillibar = vacuumPressureMillibar;
            this.XPrintHeadPosition = xPrintHeadPosition;
            this.Positions = positions;
            this.TemperatureReadings = temperatureReadings;
            this.VoltageReadings = voltageReadings;
            this.DoorsStatusFlags = doorsStatusFlags;
            this.MainSystemStatus = mainSystemStatus;
            this.MainSubSystemStatus = mainSubSystemStatus;
            this.XAxis = xAxis;
            this.YAxis = yAxis;
        }

        /// <summary>
        /// Gets or Sets VacuumPressureMillibar
        /// </summary>
        [DataMember(Name = "vacuumPressureMillibar", EmitDefaultValue = false)]
        public float VacuumPressureMillibar { get; set; }

        /// <summary>
        /// Gets or Sets TemperatureReadings
        /// </summary>
        [DataMember(Name = "temperatureReadings", EmitDefaultValue = false)]
        public TemperatureReadingsDto TemperatureReadings { get; set; }

        /// <summary>
        /// Gets or Sets VoltageReadings
        /// </summary>
        [DataMember(Name = "voltageReadings", EmitDefaultValue = false)]
        public VoltageReadingsDto VoltageReadings { get; set; }

        /// <summary>
        /// Gets or Sets XAxis
        /// </summary>
        [DataMember(Name = "xAxis", EmitDefaultValue = false)]
        public int XAxis { get; set; }

        /// <summary>
        /// Gets or Sets YAxis
        /// </summary>
        [DataMember(Name = "yAxis", EmitDefaultValue = false)]
        public int YAxis { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PrinterStateDto {\n");
            sb.Append("  VacuumPressureMillibar: ").Append(VacuumPressureMillibar).Append("\n");
            sb.Append("  XPrintHeadPosition: ").Append(XPrintHeadPosition).Append("\n");
            sb.Append("  Positions: ").Append(Positions).Append("\n");
            sb.Append("  TemperatureReadings: ").Append(TemperatureReadings).Append("\n");
            sb.Append("  VoltageReadings: ").Append(VoltageReadings).Append("\n");
            sb.Append("  DoorsStatusFlags: ").Append(DoorsStatusFlags).Append("\n");
            sb.Append("  MainSystemStatus: ").Append(MainSystemStatus).Append("\n");
            sb.Append("  MainSubSystemStatus: ").Append(MainSubSystemStatus).Append("\n");
            sb.Append("  XAxis: ").Append(XAxis).Append("\n");
            sb.Append("  YAxis: ").Append(YAxis).Append("\n");
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
