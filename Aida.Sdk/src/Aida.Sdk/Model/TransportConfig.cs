/*
 * aida
 *
 * 1.0.703.2
 *
 * The version of the OpenAPI document: 1.0.703.2
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
    /// TransportConfig
    /// </summary>
    [DataContract(Name = "TransportConfig")]
    public partial class TransportConfig : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransportConfig" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="serialPorts">serialPorts.</param>
        /// <param name="xliType">xliType.</param>
        /// <param name="feeders">feeders.</param>
        /// <param name="slaveId">slaveId.</param>
        public TransportConfig(string type = default(string), List<string> serialPorts = default(List<string>), string xliType = default(string), List<string> feeders = default(List<string>), int slaveId = default(int))
        {
            this.Type = type;
            this.SerialPorts = serialPorts;
            this.XliType = xliType;
            this.Feeders = feeders;
            this.SlaveId = slaveId;
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets SerialPorts
        /// </summary>
        [DataMember(Name = "serialPorts", EmitDefaultValue = true)]
        public List<string> SerialPorts { get; set; }

        /// <summary>
        /// Gets or Sets XliType
        /// </summary>
        [DataMember(Name = "xliType", EmitDefaultValue = true)]
        public string XliType { get; set; }

        /// <summary>
        /// Gets or Sets Feeders
        /// </summary>
        [DataMember(Name = "feeders", EmitDefaultValue = true)]
        public List<string> Feeders { get; set; }

        /// <summary>
        /// Gets or Sets SlaveId
        /// </summary>
        [DataMember(Name = "slaveId", EmitDefaultValue = false)]
        public int SlaveId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransportConfig {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SerialPorts: ").Append(SerialPorts).Append("\n");
            sb.Append("  XliType: ").Append(XliType).Append("\n");
            sb.Append("  Feeders: ").Append(Feeders).Append("\n");
            sb.Append("  SlaveId: ").Append(SlaveId).Append("\n");
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
