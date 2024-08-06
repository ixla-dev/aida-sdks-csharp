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
    /// TransportState
    /// </summary>
    [DataContract(Name = "TransportState")]
    public partial class TransportState : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransportState" /> class.
        /// </summary>
        /// <param name="isExecutingCommand">isExecutingCommand.</param>
        /// <param name="modules">modules.</param>
        /// <param name="occupiedPositions">occupiedPositions.</param>
        /// <param name="feeders">feeders.</param>
        public TransportState(bool isExecutingCommand = default(bool), List<TransportModuleState> modules = default(List<TransportModuleState>), List<TransportPosition> occupiedPositions = default(List<TransportPosition>), List<FeederState> feeders = default(List<FeederState>))
        {
            this.IsExecutingCommand = isExecutingCommand;
            this.Modules = modules;
            this.OccupiedPositions = occupiedPositions;
            this.Feeders = feeders;
        }

        /// <summary>
        /// Gets or Sets IsExecutingCommand
        /// </summary>
        [DataMember(Name = "isExecutingCommand", EmitDefaultValue = true)]
        public bool IsExecutingCommand { get; set; }

        /// <summary>
        /// Gets or Sets Modules
        /// </summary>
        [DataMember(Name = "modules", EmitDefaultValue = true)]
        public List<TransportModuleState> Modules { get; set; }

        /// <summary>
        /// Gets or Sets OccupiedPositions
        /// </summary>
        [DataMember(Name = "occupiedPositions", EmitDefaultValue = true)]
        public List<TransportPosition> OccupiedPositions { get; set; }

        /// <summary>
        /// Gets or Sets Feeders
        /// </summary>
        [DataMember(Name = "feeders", EmitDefaultValue = true)]
        public List<FeederState> Feeders { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransportState {\n");
            sb.Append("  IsExecutingCommand: ").Append(IsExecutingCommand).Append("\n");
            sb.Append("  Modules: ").Append(Modules).Append("\n");
            sb.Append("  OccupiedPositions: ").Append(OccupiedPositions).Append("\n");
            sb.Append("  Feeders: ").Append(Feeders).Append("\n");
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
