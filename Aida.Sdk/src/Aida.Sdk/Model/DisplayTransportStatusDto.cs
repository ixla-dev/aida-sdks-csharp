/*
 * aida
 *
 * 1.0.703.4
 *
 * The version of the OpenAPI document: 1.0.703.4
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
    /// DisplayTransportStatusDto
    /// </summary>
    [DataContract(Name = "DisplayTransportStatusDto")]
    public partial class DisplayTransportStatusDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayTransportStatusDto" /> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="closedPhotoSensors">closedPhotoSensors.</param>
        /// <param name="doors">doors.</param>
        /// <param name="firmwareRevision">firmwareRevision.</param>
        /// <param name="hardwareRevision">hardwareRevision.</param>
        /// <param name="positions">positions.</param>
        public DisplayTransportStatusDto(string status = default(string), string closedPhotoSensors = default(string), string doors = default(string), string firmwareRevision = default(string), string hardwareRevision = default(string), string positions = default(string))
        {
            this.Status = status;
            this.ClosedPhotoSensors = closedPhotoSensors;
            this.Doors = doors;
            this.FirmwareRevision = firmwareRevision;
            this.HardwareRevision = hardwareRevision;
            this.Positions = positions;
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets ClosedPhotoSensors
        /// </summary>
        [DataMember(Name = "closedPhotoSensors", EmitDefaultValue = true)]
        public string ClosedPhotoSensors { get; set; }

        /// <summary>
        /// Gets or Sets Doors
        /// </summary>
        [DataMember(Name = "doors", EmitDefaultValue = true)]
        public string Doors { get; set; }

        /// <summary>
        /// Gets or Sets FirmwareRevision
        /// </summary>
        [DataMember(Name = "firmwareRevision", EmitDefaultValue = true)]
        public string FirmwareRevision { get; set; }

        /// <summary>
        /// Gets or Sets HardwareRevision
        /// </summary>
        [DataMember(Name = "hardwareRevision", EmitDefaultValue = true)]
        public string HardwareRevision { get; set; }

        /// <summary>
        /// Gets or Sets Positions
        /// </summary>
        [DataMember(Name = "positions", EmitDefaultValue = true)]
        public string Positions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DisplayTransportStatusDto {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ClosedPhotoSensors: ").Append(ClosedPhotoSensors).Append("\n");
            sb.Append("  Doors: ").Append(Doors).Append("\n");
            sb.Append("  FirmwareRevision: ").Append(FirmwareRevision).Append("\n");
            sb.Append("  HardwareRevision: ").Append(HardwareRevision).Append("\n");
            sb.Append("  Positions: ").Append(Positions).Append("\n");
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
