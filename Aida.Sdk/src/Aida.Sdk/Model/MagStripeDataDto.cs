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
    /// MagStripeDataDto
    /// </summary>
    [DataContract(Name = "MagStripeDataDto")]
    public partial class MagStripeDataDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MagStripeDataDto" /> class.
        /// </summary>
        /// <param name="track1">track1.</param>
        /// <param name="track2">track2.</param>
        /// <param name="track3">track3.</param>
        public MagStripeDataDto(string track1 = default(string), string track2 = default(string), string track3 = default(string))
        {
            this.Track1 = track1;
            this.Track2 = track2;
            this.Track3 = track3;
        }

        /// <summary>
        /// Gets or Sets Track1
        /// </summary>
        [DataMember(Name = "track1", EmitDefaultValue = true)]
        public string Track1 { get; set; }

        /// <summary>
        /// Gets or Sets Track2
        /// </summary>
        [DataMember(Name = "track2", EmitDefaultValue = true)]
        public string Track2 { get; set; }

        /// <summary>
        /// Gets or Sets Track3
        /// </summary>
        [DataMember(Name = "track3", EmitDefaultValue = true)]
        public string Track3 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MagStripeDataDto {\n");
            sb.Append("  Track1: ").Append(Track1).Append("\n");
            sb.Append("  Track2: ").Append(Track2).Append("\n");
            sb.Append("  Track3: ").Append(Track3).Append("\n");
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
