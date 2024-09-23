/*
 * aida-mini
 *
 * 1.0.704.0
 *
 * The version of the OpenAPI document: 1.0.704.0
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
    /// SystemInfoStatusDto
    /// </summary>
    [DataContract(Name = "SystemInfoStatusDto")]
    public partial class SystemInfoStatusDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemInfoStatusDto" /> class.
        /// </summary>
        /// <param name="serialNumber">serialNumber.</param>
        /// <param name="systemModel">systemModel.</param>
        /// <param name="ipAddress">ipAddress.</param>
        /// <param name="serverVersion">serverVersion.</param>
        public SystemInfoStatusDto(string serialNumber = default(string), string systemModel = default(string), string ipAddress = default(string), string serverVersion = default(string))
        {
            this.SerialNumber = serialNumber;
            this.SystemModel = systemModel;
            this.IpAddress = ipAddress;
            this.ServerVersion = serverVersion;
        }

        /// <summary>
        /// Gets or Sets SerialNumber
        /// </summary>
        [DataMember(Name = "serialNumber", EmitDefaultValue = true)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Gets or Sets SystemModel
        /// </summary>
        [DataMember(Name = "systemModel", EmitDefaultValue = true)]
        public string SystemModel { get; set; }

        /// <summary>
        /// Gets or Sets IpAddress
        /// </summary>
        [DataMember(Name = "ipAddress", EmitDefaultValue = true)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or Sets ServerVersion
        /// </summary>
        [DataMember(Name = "serverVersion", EmitDefaultValue = true)]
        public string ServerVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SystemInfoStatusDto {\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  SystemModel: ").Append(SystemModel).Append("\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  ServerVersion: ").Append(ServerVersion).Append("\n");
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
