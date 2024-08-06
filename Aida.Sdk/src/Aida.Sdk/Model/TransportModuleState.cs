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
    /// TransportModuleState
    /// </summary>
    [DataContract(Name = "TransportModuleState")]
    public partial class TransportModuleState : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ModuleStatus
        /// </summary>
        [DataMember(Name = "moduleStatus", EmitDefaultValue = false)]
        public TransportModuleStatus? ModuleStatus { get; set; }

        /// <summary>
        /// Gets or Sets ModuleType
        /// </summary>
        [DataMember(Name = "moduleType", EmitDefaultValue = false)]
        public TransportModuleType? ModuleType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransportModuleState" /> class.
        /// </summary>
        /// <param name="moduleId">moduleId.</param>
        /// <param name="serialNumber">serialNumber.</param>
        /// <param name="varConfiguration">varConfiguration.</param>
        /// <param name="moduleStatus">moduleStatus.</param>
        /// <param name="moduleType">moduleType.</param>
        /// <param name="photoSensors">photoSensors.</param>
        public TransportModuleState(int moduleId = default(int), string serialNumber = default(string), TransportModuleConfiguration varConfiguration = default(TransportModuleConfiguration), TransportModuleStatus? moduleStatus = default(TransportModuleStatus?), TransportModuleType? moduleType = default(TransportModuleType?), List<PhotoSensor> photoSensors = default(List<PhotoSensor>))
        {
            this.ModuleId = moduleId;
            this.SerialNumber = serialNumber;
            this.VarConfiguration = varConfiguration;
            this.ModuleStatus = moduleStatus;
            this.ModuleType = moduleType;
            this.PhotoSensors = photoSensors;
        }

        /// <summary>
        /// Gets or Sets ModuleId
        /// </summary>
        [DataMember(Name = "moduleId", EmitDefaultValue = false)]
        public int ModuleId { get; set; }

        /// <summary>
        /// Gets or Sets SerialNumber
        /// </summary>
        [DataMember(Name = "serialNumber", EmitDefaultValue = true)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Gets or Sets VarConfiguration
        /// </summary>
        [DataMember(Name = "configuration", EmitDefaultValue = false)]
        public TransportModuleConfiguration VarConfiguration { get; set; }

        /// <summary>
        /// Gets or Sets PhotoSensors
        /// </summary>
        [DataMember(Name = "photoSensors", EmitDefaultValue = true)]
        public List<PhotoSensor> PhotoSensors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransportModuleState {\n");
            sb.Append("  ModuleId: ").Append(ModuleId).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  VarConfiguration: ").Append(VarConfiguration).Append("\n");
            sb.Append("  ModuleStatus: ").Append(ModuleStatus).Append("\n");
            sb.Append("  ModuleType: ").Append(ModuleType).Append("\n");
            sb.Append("  PhotoSensors: ").Append(PhotoSensors).Append("\n");
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
