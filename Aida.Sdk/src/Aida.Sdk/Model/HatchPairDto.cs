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
    /// HatchPairDto
    /// </summary>
    [DataContract(Name = "HatchPairDto")]
    public partial class HatchPairDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HatchPairDto" /> class.
        /// </summary>
        /// <param name="index">index.</param>
        /// <param name="name">name.</param>
        /// <param name="hatch1">hatch1.</param>
        /// <param name="hatch2">hatch2.</param>
        public HatchPairDto(int? index = default(int?), string name = default(string), HatchSettingsDto hatch1 = default(HatchSettingsDto), HatchSettingsDto hatch2 = default(HatchSettingsDto))
        {
            this.Index = index;
            this.Name = name;
            this.Hatch1 = hatch1;
            this.Hatch2 = hatch2;
        }

        /// <summary>
        /// Gets or Sets Index
        /// </summary>
        [DataMember(Name = "index", EmitDefaultValue = true)]
        public int? Index { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Hatch1
        /// </summary>
        [DataMember(Name = "hatch1", EmitDefaultValue = false)]
        public HatchSettingsDto Hatch1 { get; set; }

        /// <summary>
        /// Gets or Sets Hatch2
        /// </summary>
        [DataMember(Name = "hatch2", EmitDefaultValue = false)]
        public HatchSettingsDto Hatch2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HatchPairDto {\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Hatch1: ").Append(Hatch1).Append("\n");
            sb.Append("  Hatch2: ").Append(Hatch2).Append("\n");
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
