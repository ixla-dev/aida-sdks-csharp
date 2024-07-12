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
    /// SamLightOptions
    /// </summary>
    [DataContract(Name = "SamLightOptions")]
    public partial class SamLightOptions : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SamLightOptions" /> class.
        /// </summary>
        /// <param name="prefixEntities">prefixEntities.</param>
        /// <param name="optic">optic.</param>
        public SamLightOptions(bool prefixEntities = default(bool), SamlightOpticSettings optic = default(SamlightOpticSettings))
        {
            this.PrefixEntities = prefixEntities;
            this.Optic = optic;
        }

        /// <summary>
        /// Gets or Sets PrefixEntities
        /// </summary>
        [DataMember(Name = "prefixEntities", EmitDefaultValue = true)]
        public bool PrefixEntities { get; set; }

        /// <summary>
        /// Gets or Sets Optic
        /// </summary>
        [DataMember(Name = "optic", EmitDefaultValue = false)]
        public SamlightOpticSettings Optic { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SamLightOptions {\n");
            sb.Append("  PrefixEntities: ").Append(PrefixEntities).Append("\n");
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
