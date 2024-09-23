/*
 * aida
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
using FileParameter = Aida.Sdk.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Model
{
    /// <summary>
    /// InkjetTemperaturesDto
    /// </summary>
    [DataContract(Name = "InkjetTemperaturesDto")]
    public partial class InkjetTemperaturesDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InkjetTemperaturesDto" /> class.
        /// </summary>
        /// <param name="heaterTemperatureSet">heaterTemperatureSet.</param>
        /// <param name="heaterTemperature">heaterTemperature.</param>
        /// <param name="printheadTemperature">printheadTemperature.</param>
        /// <param name="boardTemperature">boardTemperature.</param>
        public InkjetTemperaturesDto(float heaterTemperatureSet = default(float), float heaterTemperature = default(float), float printheadTemperature = default(float), float boardTemperature = default(float))
        {
            this.HeaterTemperatureSet = heaterTemperatureSet;
            this.HeaterTemperature = heaterTemperature;
            this.PrintheadTemperature = printheadTemperature;
            this.BoardTemperature = boardTemperature;
        }

        /// <summary>
        /// Gets or Sets HeaterTemperatureSet
        /// </summary>
        [DataMember(Name = "heaterTemperatureSet", EmitDefaultValue = false)]
        public float HeaterTemperatureSet { get; set; }

        /// <summary>
        /// Gets or Sets HeaterTemperature
        /// </summary>
        [DataMember(Name = "heaterTemperature", EmitDefaultValue = false)]
        public float HeaterTemperature { get; set; }

        /// <summary>
        /// Gets or Sets PrintheadTemperature
        /// </summary>
        [DataMember(Name = "printheadTemperature", EmitDefaultValue = false)]
        public float PrintheadTemperature { get; set; }

        /// <summary>
        /// Gets or Sets BoardTemperature
        /// </summary>
        [DataMember(Name = "boardTemperature", EmitDefaultValue = false)]
        public float BoardTemperature { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InkjetTemperaturesDto {\n");
            sb.Append("  HeaterTemperatureSet: ").Append(HeaterTemperatureSet).Append("\n");
            sb.Append("  HeaterTemperature: ").Append(HeaterTemperature).Append("\n");
            sb.Append("  PrintheadTemperature: ").Append(PrintheadTemperature).Append("\n");
            sb.Append("  BoardTemperature: ").Append(BoardTemperature).Append("\n");
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
