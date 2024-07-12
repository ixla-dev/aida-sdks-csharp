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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using FileParameter = Aida.Sdk.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Model
{
    /// <summary>
    /// EncoderLoadedMessage
    /// </summary>
    [DataContract(Name = "EncoderLoadedMessage")]
    [JsonConverter(typeof(JsonSubtypes), "Discriminator")]
    public partial class EncoderLoadedMessage : WorkflowMessage, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EncoderLoadedMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EncoderLoadedMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EncoderLoadedMessage" /> class.
        /// </summary>
        /// <param name="encoderId">encoderId.</param>
        /// <param name="encoderIndex">encoderIndex.</param>
        /// <param name="callbackUrl">callbackUrl.</param>
        /// <param name="discriminator">discriminator (required) (default to &quot;EncoderLoadedMessage&quot;).</param>
        /// <param name="sourceJobInstanceId">sourceJobInstanceId.</param>
        /// <param name="machineName">machineName.</param>
        /// <param name="machineSerial">machineSerial.</param>
        /// <param name="hostName">hostName.</param>
        /// <param name="jobId">jobId.</param>
        /// <param name="batchId">batchId.</param>
        /// <param name="correlationId">correlationId.</param>
        /// <param name="messageId">messageId.</param>
        /// <param name="workflowInstanceId">workflowInstanceId.</param>
        /// <param name="workflowInstanceName">workflowInstanceName.</param>
        /// <param name="messageType">messageType.</param>
        /// <param name="jobStatus">jobStatus.</param>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="additionalMetadata">additionalMetadata.</param>
        /// <param name="documentProduced">documentProduced.</param>
        /// <param name="destructiveOperationExecuted">destructiveOperationExecuted.</param>
        public EncoderLoadedMessage(string encoderId = default(string), int encoderIndex = default(int), string callbackUrl = default(string), string discriminator = @"EncoderLoadedMessage", string sourceJobInstanceId = default(string), string machineName = default(string), string machineSerial = default(string), string hostName = default(string), string jobId = default(string), string batchId = default(string), string correlationId = default(string), string messageId = default(string), string workflowInstanceId = default(string), string workflowInstanceName = default(string), MessageType? messageType = default(MessageType?), JobStatus? jobStatus = default(JobStatus?), JobErrorCodes? errorCode = default(JobErrorCodes?), Dictionary<string, Object> additionalMetadata = default(Dictionary<string, Object>), bool documentProduced = default(bool), bool destructiveOperationExecuted = default(bool)) : base(discriminator, sourceJobInstanceId, machineName, machineSerial, hostName, jobId, batchId, correlationId, messageId, workflowInstanceId, workflowInstanceName, messageType, jobStatus, errorCode, additionalMetadata, documentProduced, destructiveOperationExecuted)
        {
            this.EncoderId = encoderId;
            this.EncoderIndex = encoderIndex;
            this.CallbackUrl = callbackUrl;
        }

        /// <summary>
        /// Gets or Sets EncoderId
        /// </summary>
        [DataMember(Name = "encoderId", EmitDefaultValue = true)]
        public string EncoderId { get; set; }

        /// <summary>
        /// Gets or Sets EncoderIndex
        /// </summary>
        [DataMember(Name = "encoderIndex", EmitDefaultValue = false)]
        public int EncoderIndex { get; set; }

        /// <summary>
        /// Gets or Sets CallbackUrl
        /// </summary>
        [DataMember(Name = "callbackUrl", EmitDefaultValue = true)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EncoderLoadedMessage {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  EncoderId: ").Append(EncoderId).Append("\n");
            sb.Append("  EncoderIndex: ").Append(EncoderIndex).Append("\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach (var x in base.BaseValidate(validationContext))
            {
                yield return x;
            }
            yield break;
        }
    }

}
