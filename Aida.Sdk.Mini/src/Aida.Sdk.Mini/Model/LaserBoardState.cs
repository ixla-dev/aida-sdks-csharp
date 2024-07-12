/*
 * aida-mini
 *
 * 1.0.700.1
 *
 * The version of the OpenAPI document: 1.0.700.1
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
using FileParameter = Aida.Sdk.Mini.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Mini.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Mini.Model
{
    /// <summary>
    /// LaserBoardState
    /// </summary>
    [DataContract(Name = "LaserBoardState")]
    public partial class LaserBoardState : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets LaserPen
        /// </summary>
        [DataMember(Name = "laserPen", EmitDefaultValue = false)]
        public DeviceToggleState? LaserPen { get; set; }

        /// <summary>
        /// Gets or Sets RedPointer
        /// </summary>
        [DataMember(Name = "redPointer", EmitDefaultValue = false)]
        public DeviceToggleState? RedPointer { get; set; }

        /// <summary>
        /// Gets or Sets Illumination
        /// </summary>
        [DataMember(Name = "illumination", EmitDefaultValue = false)]
        public DeviceToggleState? Illumination { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LaserBoardState" /> class.
        /// </summary>
        /// <param name="serialNumber">serialNumber.</param>
        /// <param name="firmwareVersion">firmwareVersion.</param>
        /// <param name="hardwareType">hardwareType.</param>
        /// <param name="systemType">systemType.</param>
        /// <param name="interlocks">interlocks.</param>
        /// <param name="laserPen">laserPen.</param>
        /// <param name="redPointer">redPointer.</param>
        /// <param name="illumination">illumination.</param>
        public LaserBoardState(string serialNumber = default(string), string firmwareVersion = default(string), string hardwareType = default(string), string systemType = default(string), List<InterlockStatus> interlocks = default(List<InterlockStatus>), DeviceToggleState? laserPen = default(DeviceToggleState?), DeviceToggleState? redPointer = default(DeviceToggleState?), DeviceToggleState? illumination = default(DeviceToggleState?))
        {
            this.SerialNumber = serialNumber;
            this.FirmwareVersion = firmwareVersion;
            this.HardwareType = hardwareType;
            this.SystemType = systemType;
            this.Interlocks = interlocks;
            this.LaserPen = laserPen;
            this.RedPointer = redPointer;
            this.Illumination = illumination;
        }

        /// <summary>
        /// Gets or Sets SerialNumber
        /// </summary>
        [DataMember(Name = "serialNumber", EmitDefaultValue = true)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Gets or Sets FirmwareVersion
        /// </summary>
        [DataMember(Name = "firmwareVersion", EmitDefaultValue = true)]
        public string FirmwareVersion { get; set; }

        /// <summary>
        /// Gets or Sets HardwareType
        /// </summary>
        [DataMember(Name = "hardwareType", EmitDefaultValue = true)]
        public string HardwareType { get; set; }

        /// <summary>
        /// Gets or Sets SystemType
        /// </summary>
        [DataMember(Name = "systemType", EmitDefaultValue = true)]
        public string SystemType { get; set; }

        /// <summary>
        /// Gets or Sets Interlocks
        /// </summary>
        [DataMember(Name = "interlocks", EmitDefaultValue = true)]
        public List<InterlockStatus> Interlocks { get; set; }

        /// <summary>
        /// Gets or Sets HasOpenInterlocks
        /// </summary>
        [DataMember(Name = "hasOpenInterlocks", EmitDefaultValue = true)]
        public bool HasOpenInterlocks { get; private set; }

        /// <summary>
        /// Returns false as HasOpenInterlocks should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeHasOpenInterlocks()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LaserBoardState {\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  FirmwareVersion: ").Append(FirmwareVersion).Append("\n");
            sb.Append("  HardwareType: ").Append(HardwareType).Append("\n");
            sb.Append("  SystemType: ").Append(SystemType).Append("\n");
            sb.Append("  Interlocks: ").Append(Interlocks).Append("\n");
            sb.Append("  LaserPen: ").Append(LaserPen).Append("\n");
            sb.Append("  RedPointer: ").Append(RedPointer).Append("\n");
            sb.Append("  Illumination: ").Append(Illumination).Append("\n");
            sb.Append("  HasOpenInterlocks: ").Append(HasOpenInterlocks).Append("\n");
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
