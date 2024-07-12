/*
 * aida
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
using FileParameter = Aida.Sdk.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Model
{
    /// <summary>
    /// TemperatureReadingsDto
    /// </summary>
    [DataContract(Name = "TemperatureReadingsDto")]
    public partial class TemperatureReadingsDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemperatureReadingsDto" /> class.
        /// </summary>
        /// <param name="printHeadTemperatureCelsius">printHeadTemperatureCelsius.</param>
        /// <param name="heaterTemperatureCelsius">heaterTemperatureCelsius.</param>
        /// <param name="internalTemperatureCelsius">internalTemperatureCelsius.</param>
        /// <param name="board1TemperatureCelsius">board1TemperatureCelsius.</param>
        /// <param name="board2TemperatureCelsius">board2TemperatureCelsius.</param>
        public TemperatureReadingsDto(float printHeadTemperatureCelsius = default(float), float heaterTemperatureCelsius = default(float), float internalTemperatureCelsius = default(float), float board1TemperatureCelsius = default(float), float board2TemperatureCelsius = default(float))
        {
            this.PrintHeadTemperatureCelsius = printHeadTemperatureCelsius;
            this.HeaterTemperatureCelsius = heaterTemperatureCelsius;
            this.InternalTemperatureCelsius = internalTemperatureCelsius;
            this.Board1TemperatureCelsius = board1TemperatureCelsius;
            this.Board2TemperatureCelsius = board2TemperatureCelsius;
        }

        /// <summary>
        /// Gets or Sets PrintHeadTemperatureCelsius
        /// </summary>
        [DataMember(Name = "printHeadTemperatureCelsius", EmitDefaultValue = false)]
        public float PrintHeadTemperatureCelsius { get; set; }

        /// <summary>
        /// Gets or Sets HeaterTemperatureCelsius
        /// </summary>
        [DataMember(Name = "heaterTemperatureCelsius", EmitDefaultValue = false)]
        public float HeaterTemperatureCelsius { get; set; }

        /// <summary>
        /// Gets or Sets InternalTemperatureCelsius
        /// </summary>
        [DataMember(Name = "internalTemperatureCelsius", EmitDefaultValue = false)]
        public float InternalTemperatureCelsius { get; set; }

        /// <summary>
        /// Gets or Sets Board1TemperatureCelsius
        /// </summary>
        [DataMember(Name = "board1TemperatureCelsius", EmitDefaultValue = false)]
        public float Board1TemperatureCelsius { get; set; }

        /// <summary>
        /// Gets or Sets Board2TemperatureCelsius
        /// </summary>
        [DataMember(Name = "board2TemperatureCelsius", EmitDefaultValue = false)]
        public float Board2TemperatureCelsius { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TemperatureReadingsDto {\n");
            sb.Append("  PrintHeadTemperatureCelsius: ").Append(PrintHeadTemperatureCelsius).Append("\n");
            sb.Append("  HeaterTemperatureCelsius: ").Append(HeaterTemperatureCelsius).Append("\n");
            sb.Append("  InternalTemperatureCelsius: ").Append(InternalTemperatureCelsius).Append("\n");
            sb.Append("  Board1TemperatureCelsius: ").Append(Board1TemperatureCelsius).Append("\n");
            sb.Append("  Board2TemperatureCelsius: ").Append(Board2TemperatureCelsius).Append("\n");
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
