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
    /// ScannerEntityMarkFlagsDto
    /// </summary>
    [DataContract(Name = "ScannerEntityMarkFlagsDto")]
    public partial class ScannerEntityMarkFlagsDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScannerEntityMarkFlagsDto" /> class.
        /// </summary>
        /// <param name="markContour">markContour.</param>
        /// <param name="markHatch">markHatch.</param>
        public ScannerEntityMarkFlagsDto(bool? markContour = default(bool?), bool? markHatch = default(bool?))
        {
            this.MarkContour = markContour;
            this.MarkHatch = markHatch;
        }

        /// <summary>
        /// Gets or Sets MarkContour
        /// </summary>
        [DataMember(Name = "markContour", EmitDefaultValue = true)]
        public bool? MarkContour { get; set; }

        /// <summary>
        /// Gets or Sets MarkHatch
        /// </summary>
        [DataMember(Name = "markHatch", EmitDefaultValue = true)]
        public bool? MarkHatch { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScannerEntityMarkFlagsDto {\n");
            sb.Append("  MarkContour: ").Append(MarkContour).Append("\n");
            sb.Append("  MarkHatch: ").Append(MarkHatch).Append("\n");
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
