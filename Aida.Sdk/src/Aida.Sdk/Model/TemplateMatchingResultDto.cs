/*
 * aida
 *
 * 1.0.713
 *
 * The version of the OpenAPI document: 1.0.713
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
    /// TemplateMatchingResultDto
    /// </summary>
    [DataContract(Name = "TemplateMatchingResultDto")]
    public partial class TemplateMatchingResultDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateMatchingResultDto" /> class.
        /// </summary>
        /// <param name="occurrences">occurrences.</param>
        /// <param name="any">any.</param>
        /// <param name="best">best.</param>
        public TemplateMatchingResultDto(List<TemplateMatchOccurence> occurrences = default(List<TemplateMatchOccurence>), bool any = default(bool), TemplateMatchOccurence best = default(TemplateMatchOccurence))
        {
            this.Occurrences = occurrences;
            this.Any = any;
            this.Best = best;
        }

        /// <summary>
        /// Gets or Sets Occurrences
        /// </summary>
        [DataMember(Name = "occurrences", EmitDefaultValue = true)]
        public List<TemplateMatchOccurence> Occurrences { get; set; }

        /// <summary>
        /// Gets or Sets Any
        /// </summary>
        [DataMember(Name = "any", EmitDefaultValue = true)]
        public bool Any { get; set; }

        /// <summary>
        /// Gets or Sets Best
        /// </summary>
        [DataMember(Name = "best", EmitDefaultValue = false)]
        public TemplateMatchOccurence Best { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TemplateMatchingResultDto {\n");
            sb.Append("  Occurrences: ").Append(Occurrences).Append("\n");
            sb.Append("  Any: ").Append(Any).Append("\n");
            sb.Append("  Best: ").Append(Best).Append("\n");
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
