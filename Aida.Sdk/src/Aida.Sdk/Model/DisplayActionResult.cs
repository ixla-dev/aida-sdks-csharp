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
    /// DisplayActionResult
    /// </summary>
    [DataContract(Name = "DisplayActionResult")]
    public partial class DisplayActionResult : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public DisplayErrors? Errors { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayActionResult" /> class.
        /// </summary>
        /// <param name="succeeded">succeeded.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="errors">errors.</param>
        public DisplayActionResult(bool succeeded = default(bool), string errorMessage = default(string), DisplayErrors? errors = default(DisplayErrors?))
        {
            this.Succeeded = succeeded;
            this.ErrorMessage = errorMessage;
            this.Errors = errors;
        }

        /// <summary>
        /// Gets or Sets Succeeded
        /// </summary>
        [DataMember(Name = "succeeded", EmitDefaultValue = true)]
        public bool Succeeded { get; set; }

        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name = "errorMessage", EmitDefaultValue = true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DisplayActionResult {\n");
            sb.Append("  Succeeded: ").Append(Succeeded).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
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