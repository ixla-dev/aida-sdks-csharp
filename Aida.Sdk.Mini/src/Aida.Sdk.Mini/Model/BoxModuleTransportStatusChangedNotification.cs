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
    /// BoxModuleTransportStatusChangedNotification
    /// </summary>
    [DataContract(Name = "BoxModuleTransportStatusChangedNotification")]
    public partial class BoxModuleTransportStatusChangedNotification : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets PreviousStatus
        /// </summary>
        [DataMember(Name = "previousStatus", EmitDefaultValue = false)]
        public BoxModuleTransportStatus? PreviousStatus { get; set; }

        /// <summary>
        /// Gets or Sets CurrentStatus
        /// </summary>
        [DataMember(Name = "currentStatus", EmitDefaultValue = false)]
        public BoxModuleTransportStatus? CurrentStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BoxModuleTransportStatusChangedNotification" /> class.
        /// </summary>
        /// <param name="nodeId">nodeId.</param>
        /// <param name="previousStatus">previousStatus.</param>
        /// <param name="currentStatus">currentStatus.</param>
        /// <param name="moduleId">moduleId.</param>
        /// <param name="modbusId">modbusId.</param>
        public BoxModuleTransportStatusChangedNotification(string nodeId = default(string), BoxModuleTransportStatus? previousStatus = default(BoxModuleTransportStatus?), BoxModuleTransportStatus? currentStatus = default(BoxModuleTransportStatus?), string moduleId = default(string), int modbusId = default(int))
        {
            this.NodeId = nodeId;
            this.PreviousStatus = previousStatus;
            this.CurrentStatus = currentStatus;
            this.ModuleId = moduleId;
            this.ModbusId = modbusId;
        }

        /// <summary>
        /// Gets or Sets NodeId
        /// </summary>
        [DataMember(Name = "nodeId", EmitDefaultValue = true)]
        public string NodeId { get; set; }

        /// <summary>
        /// Gets or Sets ModuleId
        /// </summary>
        [DataMember(Name = "moduleId", EmitDefaultValue = true)]
        public string ModuleId { get; set; }

        /// <summary>
        /// Gets or Sets ModbusId
        /// </summary>
        [DataMember(Name = "modbusId", EmitDefaultValue = false)]
        public int ModbusId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BoxModuleTransportStatusChangedNotification {\n");
            sb.Append("  NodeId: ").Append(NodeId).Append("\n");
            sb.Append("  PreviousStatus: ").Append(PreviousStatus).Append("\n");
            sb.Append("  CurrentStatus: ").Append(CurrentStatus).Append("\n");
            sb.Append("  ModuleId: ").Append(ModuleId).Append("\n");
            sb.Append("  ModbusId: ").Append(ModbusId).Append("\n");
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
