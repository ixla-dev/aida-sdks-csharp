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
    /// NameValidationResultDto
    /// </summary>
    [DataContract(Name = "NameValidationResultDto")]
    public partial class NameValidationResultDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NameValidationResultDto" /> class.
        /// </summary>
        /// <param name="input">input.</param>
        /// <param name="valid">valid.</param>
        /// <param name="suggested">suggested.</param>
        /// <param name="errors">errors.</param>
        public NameValidationResultDto(string input = default(string), bool valid = default(bool), string suggested = default(string), List<NameValidationErrorReason> errors = default(List<NameValidationErrorReason>))
        {
            this.Input = input;
            this.Valid = valid;
            this.Suggested = suggested;
            this.Errors = errors;
        }

        /// <summary>
        /// Gets or Sets Input
        /// </summary>
        [DataMember(Name = "input", EmitDefaultValue = true)]
        public string Input { get; set; }

        /// <summary>
        /// Gets or Sets Valid
        /// </summary>
        [DataMember(Name = "valid", EmitDefaultValue = true)]
        public bool Valid { get; set; }

        /// <summary>
        /// Gets or Sets Suggested
        /// </summary>
        [DataMember(Name = "suggested", EmitDefaultValue = true)]
        public string Suggested { get; set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", EmitDefaultValue = true)]
        public List<NameValidationErrorReason> Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NameValidationResultDto {\n");
            sb.Append("  Input: ").Append(Input).Append("\n");
            sb.Append("  Valid: ").Append(Valid).Append("\n");
            sb.Append("  Suggested: ").Append(Suggested).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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