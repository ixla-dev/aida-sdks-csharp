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
    /// SamLightOptionsDto
    /// </summary>
    [DataContract(Name = "SamLightOptionsDto")]
    public partial class SamLightOptionsDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SamLightOptionsDto" /> class.
        /// </summary>
        /// <param name="prefixEntityNames">prefixEntityNames.</param>
        /// <param name="optic">optic.</param>
        public SamLightOptionsDto(bool? prefixEntityNames = default(bool?), SamlightOpticSettingsDto optic = default(SamlightOpticSettingsDto))
        {
            this.PrefixEntityNames = prefixEntityNames;
            this.Optic = optic;
        }

        /// <summary>
        /// Gets or Sets PrefixEntityNames
        /// </summary>
        [DataMember(Name = "prefixEntityNames", EmitDefaultValue = true)]
        public bool? PrefixEntityNames { get; set; }

        /// <summary>
        /// Gets or Sets Optic
        /// </summary>
        [DataMember(Name = "optic", EmitDefaultValue = false)]
        public SamlightOpticSettingsDto Optic { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SamLightOptionsDto {\n");
            sb.Append("  PrefixEntityNames: ").Append(PrefixEntityNames).Append("\n");
            sb.Append("  Optic: ").Append(Optic).Append("\n");
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
