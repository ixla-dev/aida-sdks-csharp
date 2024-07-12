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
    /// WebhookTargetTestResultDto
    /// </summary>
    [DataContract(Name = "WebhookTargetTestResultDto")]
    public partial class WebhookTargetTestResultDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name = "errorCode", EmitDefaultValue = false)]
        public WebhookMessageErrorCode? ErrorCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookTargetTestResultDto" /> class.
        /// </summary>
        /// <param name="webhookTargetId">webhookTargetId.</param>
        /// <param name="success">success.</param>
        /// <param name="url">url.</param>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="httpStatusCode">httpStatusCode.</param>
        public WebhookTargetTestResultDto(int webhookTargetId = default(int), bool success = default(bool), string url = default(string), WebhookMessageErrorCode? errorCode = default(WebhookMessageErrorCode?), int httpStatusCode = default(int))
        {
            this.WebhookTargetId = webhookTargetId;
            this.Success = success;
            this.Url = url;
            this.ErrorCode = errorCode;
            this.HttpStatusCode = httpStatusCode;
        }

        /// <summary>
        /// Gets or Sets WebhookTargetId
        /// </summary>
        [DataMember(Name = "webhookTargetId", EmitDefaultValue = false)]
        public int WebhookTargetId { get; set; }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name = "success", EmitDefaultValue = true)]
        public bool Success { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets HttpStatusCode
        /// </summary>
        [DataMember(Name = "httpStatusCode", EmitDefaultValue = false)]
        public int HttpStatusCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebhookTargetTestResultDto {\n");
            sb.Append("  WebhookTargetId: ").Append(WebhookTargetId).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  HttpStatusCode: ").Append(HttpStatusCode).Append("\n");
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
