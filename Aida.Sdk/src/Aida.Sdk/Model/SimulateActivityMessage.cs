/*
 * aida
 *
 * 1.0.721-rc.9+f020d61fcb6ef6ebe31e8b3974d429a24c2e10d0
 *
 * The version of the OpenAPI document: 1.0.721-rc.9+f020d61fcb6ef6ebe31e8b3974d429a24c2e10d0
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
    /// SimulateActivityMessage
    /// </summary>
    [DataContract(Name = "SimulateActivityMessage")]
    public partial class SimulateActivityMessage : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets MessageType
        /// </summary>
        [DataMember(Name = "messageType", EmitDefaultValue = false)]
        public MessageType? MessageType { get; set; }

        /// <summary>
        /// Gets or Sets JobStatus
        /// </summary>
        [DataMember(Name = "jobStatus", EmitDefaultValue = false)]
        public JobStatus? JobStatus { get; set; }

        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name = "errorCode", EmitDefaultValue = false)]
        public JobErrorCodes? ErrorCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SimulateActivityMessage" /> class.
        /// </summary>
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
        /// <param name="discriminator">discriminator.</param>
        public SimulateActivityMessage(string sourceJobInstanceId = default(string), string machineName = default(string), string machineSerial = default(string), string hostName = default(string), string jobId = default(string), string batchId = default(string), string correlationId = default(string), string messageId = default(string), string workflowInstanceId = default(string), string workflowInstanceName = default(string), MessageType? messageType = default(MessageType?), JobStatus? jobStatus = default(JobStatus?), JobErrorCodes? errorCode = default(JobErrorCodes?), Dictionary<string, Object> additionalMetadata = default(Dictionary<string, Object>), bool documentProduced = default(bool), bool destructiveOperationExecuted = default(bool), string discriminator = default(string))
        {
            this.SourceJobInstanceId = sourceJobInstanceId;
            this.MachineName = machineName;
            this.MachineSerial = machineSerial;
            this.HostName = hostName;
            this.JobId = jobId;
            this.BatchId = batchId;
            this.CorrelationId = correlationId;
            this.MessageId = messageId;
            this.WorkflowInstanceId = workflowInstanceId;
            this.WorkflowInstanceName = workflowInstanceName;
            this.MessageType = messageType;
            this.JobStatus = jobStatus;
            this.ErrorCode = errorCode;
            this.AdditionalMetadata = additionalMetadata;
            this.DocumentProduced = documentProduced;
            this.DestructiveOperationExecuted = destructiveOperationExecuted;
            this.Discriminator = discriminator;
        }

        /// <summary>
        /// Gets or Sets SourceJobInstanceId
        /// </summary>
        [DataMember(Name = "sourceJobInstanceId", EmitDefaultValue = true)]
        public string SourceJobInstanceId { get; set; }

        /// <summary>
        /// Gets or Sets MachineName
        /// </summary>
        [DataMember(Name = "machineName", EmitDefaultValue = true)]
        public string MachineName { get; set; }

        /// <summary>
        /// Gets or Sets MachineSerial
        /// </summary>
        [DataMember(Name = "machineSerial", EmitDefaultValue = true)]
        public string MachineSerial { get; set; }

        /// <summary>
        /// Gets or Sets HostName
        /// </summary>
        [DataMember(Name = "hostName", EmitDefaultValue = true)]
        public string HostName { get; set; }

        /// <summary>
        /// Gets or Sets JobId
        /// </summary>
        [DataMember(Name = "jobId", EmitDefaultValue = true)]
        public string JobId { get; set; }

        /// <summary>
        /// Gets or Sets BatchId
        /// </summary>
        [DataMember(Name = "batchId", EmitDefaultValue = true)]
        public string BatchId { get; set; }

        /// <summary>
        /// Gets or Sets CorrelationId
        /// </summary>
        [DataMember(Name = "correlationId", EmitDefaultValue = true)]
        public string CorrelationId { get; set; }

        /// <summary>
        /// Gets or Sets MessageId
        /// </summary>
        [DataMember(Name = "messageId", EmitDefaultValue = true)]
        public string MessageId { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowInstanceId
        /// </summary>
        [DataMember(Name = "workflowInstanceId", EmitDefaultValue = true)]
        public string WorkflowInstanceId { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowInstanceName
        /// </summary>
        [DataMember(Name = "workflowInstanceName", EmitDefaultValue = true)]
        public string WorkflowInstanceName { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalMetadata
        /// </summary>
        [DataMember(Name = "additionalMetadata", EmitDefaultValue = true)]
        public Dictionary<string, Object> AdditionalMetadata { get; set; }

        /// <summary>
        /// Gets or Sets DocumentProduced
        /// </summary>
        [DataMember(Name = "documentProduced", EmitDefaultValue = true)]
        public bool DocumentProduced { get; set; }

        /// <summary>
        /// Gets or Sets DestructiveOperationExecuted
        /// </summary>
        [DataMember(Name = "destructiveOperationExecuted", EmitDefaultValue = true)]
        public bool DestructiveOperationExecuted { get; set; }

        /// <summary>
        /// Gets or Sets Discriminator
        /// </summary>
        [DataMember(Name = "discriminator", EmitDefaultValue = true)]
        public string Discriminator { get; set; }

        /// <summary>
        /// Gets or Sets DurationMilliseconds
        /// </summary>
        [DataMember(Name = "durationMilliseconds", EmitDefaultValue = false)]
        public int DurationMilliseconds { get; private set; }

        /// <summary>
        /// Returns false as DurationMilliseconds should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDurationMilliseconds()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SimulateActivityMessage {\n");
            sb.Append("  SourceJobInstanceId: ").Append(SourceJobInstanceId).Append("\n");
            sb.Append("  MachineName: ").Append(MachineName).Append("\n");
            sb.Append("  MachineSerial: ").Append(MachineSerial).Append("\n");
            sb.Append("  HostName: ").Append(HostName).Append("\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  BatchId: ").Append(BatchId).Append("\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  WorkflowInstanceId: ").Append(WorkflowInstanceId).Append("\n");
            sb.Append("  WorkflowInstanceName: ").Append(WorkflowInstanceName).Append("\n");
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
            sb.Append("  JobStatus: ").Append(JobStatus).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  AdditionalMetadata: ").Append(AdditionalMetadata).Append("\n");
            sb.Append("  DocumentProduced: ").Append(DocumentProduced).Append("\n");
            sb.Append("  DestructiveOperationExecuted: ").Append(DestructiveOperationExecuted).Append("\n");
            sb.Append("  Discriminator: ").Append(Discriminator).Append("\n");
            sb.Append("  DurationMilliseconds: ").Append(DurationMilliseconds).Append("\n");
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
