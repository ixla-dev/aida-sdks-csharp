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
    /// LaserBoardConfig
    /// </summary>
    [DataContract(Name = "LaserBoardConfig")]
    public partial class LaserBoardConfig : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LaserBoardConfig" /> class.
        /// </summary>
        /// <param name="boardType">boardType.</param>
        /// <param name="serialPortName">serialPortName.</param>
        /// <param name="slaveId">slaveId.</param>
        public LaserBoardConfig(string boardType = default(string), string serialPortName = default(string), int slaveId = default(int))
        {
            this.BoardType = boardType;
            this.SerialPortName = serialPortName;
            this.SlaveId = slaveId;
        }

        /// <summary>
        /// Gets or Sets BoardType
        /// </summary>
        [DataMember(Name = "boardType", EmitDefaultValue = true)]
        public string BoardType { get; set; }

        /// <summary>
        /// Gets or Sets SerialPortName
        /// </summary>
        [DataMember(Name = "serialPortName", EmitDefaultValue = true)]
        public string SerialPortName { get; set; }

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
            sb.Append("class LaserBoardConfig {\n");
            sb.Append("  BoardType: ").Append(BoardType).Append("\n");
            sb.Append("  SerialPortName: ").Append(SerialPortName).Append("\n");
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
