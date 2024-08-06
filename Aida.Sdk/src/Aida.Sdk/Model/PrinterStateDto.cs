/*
 * aida
 *
 * 1.0.703.1
 *
 * The version of the OpenAPI document: 1.0.703.1
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
        /// Gets or Sets Positions
        /// </summary>
        [DataMember(Name = "positions", EmitDefaultValue = false)]
        public TransportAxisPositionFlags? Positions { get; set; }

        /// <summary>
        /// Gets or Sets HeadPosition
        /// </summary>
        [DataMember(Name = "headPosition", EmitDefaultValue = false)]
        public HeadAxisPositionFlags? HeadPosition { get; set; }

        /// <summary>
        /// Gets or Sets TransportStatus
        /// </summary>
        [DataMember(Name = "transportStatus", EmitDefaultValue = false)]
        public XPrintTransportStatus? TransportStatus { get; set; }

        /// <summary>
        /// Gets or Sets InkLevelStatus
        /// </summary>
        [DataMember(Name = "inkLevelStatus", EmitDefaultValue = false)]
        public InkLevelStatusFlags? InkLevelStatus { get; set; }

        /// <summary>
        /// Gets or Sets SystemStatus
        /// </summary>
        [DataMember(Name = "systemStatus", EmitDefaultValue = false)]
        public SystemStatusFlags? SystemStatus { get; set; }

        /// <summary>
        /// Gets or Sets DoorsStatus
        /// </summary>
        [DataMember(Name = "doorsStatus", EmitDefaultValue = false)]
        public XPrintDoorStatus? DoorsStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PrinterStateDto" /> class.
        /// </summary>
        /// <param name="vacuumPressureMillibar">vacuumPressureMillibar.</param>
        /// <param name="positions">positions.</param>
        /// <param name="headPosition">headPosition.</param>
        /// <param name="temperatureReadings">temperatureReadings.</param>
        /// <param name="voltageReadings">voltageReadings.</param>
        /// <param name="transportStatus">transportStatus.</param>
        /// <param name="inkLevelStatus">inkLevelStatus.</param>
        /// <param name="systemStatus">systemStatus.</param>
        /// <param name="doorsStatus">doorsStatus.</param>
        /// <param name="xAxis">xAxis.</param>
        /// <param name="yAxis">yAxis.</param>
        public PrinterStateDto(float vacuumPressureMillibar = default(float), TransportAxisPositionFlags? positions = default(TransportAxisPositionFlags?), HeadAxisPositionFlags? headPosition = default(HeadAxisPositionFlags?), TemperatureReadingsDto temperatureReadings = default(TemperatureReadingsDto), VoltageReadingsDto voltageReadings = default(VoltageReadingsDto), XPrintTransportStatus? transportStatus = default(XPrintTransportStatus?), InkLevelStatusFlags? inkLevelStatus = default(InkLevelStatusFlags?), SystemStatusFlags? systemStatus = default(SystemStatusFlags?), XPrintDoorStatus? doorsStatus = default(XPrintDoorStatus?), int xAxis = default(int), int yAxis = default(int))
        {
            this.VacuumPressureMillibar = vacuumPressureMillibar;
            this.Positions = positions;
            this.HeadPosition = headPosition;
            this.TemperatureReadings = temperatureReadings;
            this.VoltageReadings = voltageReadings;
            this.TransportStatus = transportStatus;
            this.InkLevelStatus = inkLevelStatus;
            this.SystemStatus = systemStatus;
            this.DoorsStatus = doorsStatus;
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
            sb.Append("  Positions: ").Append(Positions).Append("\n");
            sb.Append("  HeadPosition: ").Append(HeadPosition).Append("\n");
            sb.Append("  TemperatureReadings: ").Append(TemperatureReadings).Append("\n");
            sb.Append("  VoltageReadings: ").Append(VoltageReadings).Append("\n");
            sb.Append("  TransportStatus: ").Append(TransportStatus).Append("\n");
            sb.Append("  InkLevelStatus: ").Append(InkLevelStatus).Append("\n");
            sb.Append("  SystemStatus: ").Append(SystemStatus).Append("\n");
            sb.Append("  DoorsStatus: ").Append(DoorsStatus).Append("\n");
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
