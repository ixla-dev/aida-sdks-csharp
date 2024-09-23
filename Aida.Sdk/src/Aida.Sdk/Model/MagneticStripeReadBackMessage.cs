/*
 * aida
 *
 * 1.0.704.0
 *
 * The version of the OpenAPI document: 1.0.704.0
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
    /// MagneticStripeReadBackMessage
    /// </summary>
    [DataContract(Name = "MagneticStripeReadBackMessage")]
    [JsonConverter(typeof(JsonSubtypes), "Discriminator")]
    public partial class MagneticStripeReadBackMessage : WorkflowMessage, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MagneticStripeReadBackMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MagneticStripeReadBackMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MagneticStripeReadBackMessage" /> class.
        /// </summary>
        /// <param name="track1Base64">track1Base64.</param>
        /// <param name="track2Base64">track2Base64.</param>
        /// <param name="track3Base64">track3Base64.</param>
        /// <param name="discriminator">discriminator (required) (default to &quot;MagneticStripeReadBackMessage&quot;).</param>
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
        public MagneticStripeReadBackMessage(string track1Base64 = default(string), string track2Base64 = default(string), string track3Base64 = default(string), string discriminator = @"MagneticStripeReadBackMessage", string sourceJobInstanceId = default(string), string machineName = default(string), string machineSerial = default(string), string hostName = default(string), string jobId = default(string), string batchId = default(string), string correlationId = default(string), string messageId = default(string), string workflowInstanceId = default(string), string workflowInstanceName = default(string), MessageType? messageType = default(MessageType?), JobStatus? jobStatus = default(JobStatus?), JobErrorCodes? errorCode = default(JobErrorCodes?), Dictionary<string, Object> additionalMetadata = default(Dictionary<string, Object>), bool documentProduced = default(bool), bool destructiveOperationExecuted = default(bool)) : base(discriminator, sourceJobInstanceId, machineName, machineSerial, hostName, jobId, batchId, correlationId, messageId, workflowInstanceId, workflowInstanceName, messageType, jobStatus, errorCode, additionalMetadata, documentProduced, destructiveOperationExecuted)
        {
            this.Track1Base64 = track1Base64;
            this.Track2Base64 = track2Base64;
            this.Track3Base64 = track3Base64;
        }

        /// <summary>
        /// Gets or Sets Track1Base64
        /// </summary>
        [DataMember(Name = "track1Base64", EmitDefaultValue = true)]
        public string Track1Base64 { get; set; }

        /// <summary>
        /// Gets or Sets Track2Base64
        /// </summary>
        [DataMember(Name = "track2Base64", EmitDefaultValue = true)]
        public string Track2Base64 { get; set; }

        /// <summary>
        /// Gets or Sets Track3Base64
        /// </summary>
        [DataMember(Name = "track3Base64", EmitDefaultValue = true)]
        public string Track3Base64 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MagneticStripeReadBackMessage {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Track1Base64: ").Append(Track1Base64).Append("\n");
            sb.Append("  Track2Base64: ").Append(Track2Base64).Append("\n");
            sb.Append("  Track3Base64: ").Append(Track3Base64).Append("\n");
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
