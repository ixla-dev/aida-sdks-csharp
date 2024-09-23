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
using System.ComponentModel.DataAnnotations;
using FileParameter = Aida.Sdk.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Model
{
    /// <summary>
    /// WorkflowSchedulerStateDto
    /// </summary>
    [DataContract(Name = "WorkflowSchedulerStateDto")]
    public partial class WorkflowSchedulerStateDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public WorkflowSchedulerStatus? Status { get; set; }

        /// <summary>
        /// Gets or Sets StopReason
        /// </summary>
        [DataMember(Name = "stopReason", EmitDefaultValue = false)]
        public WorkflowSchedulerStopReason? StopReason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowSchedulerStateDto" /> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="stopReason">stopReason.</param>
        /// <param name="errors">errors.</param>
        /// <param name="stopSourceJobId">stopSourceJobId.</param>
        /// <param name="queueSize">queueSize.</param>
        /// <param name="queuedOrderIds">queuedOrderIds.</param>
        /// <param name="errorDetails">errorDetails.</param>
        /// <param name="lastLoadedItemId">lastLoadedItemId.</param>
        /// <param name="upTimeSeconds">upTimeSeconds.</param>
        /// <param name="workflowTypeName">workflowTypeName.</param>
        /// <param name="sessionId">sessionId.</param>
        public WorkflowSchedulerStateDto(WorkflowSchedulerStatus? status = default(WorkflowSchedulerStatus?), WorkflowSchedulerStopReason? stopReason = default(WorkflowSchedulerStopReason?), List<WorkflowSchedulerErrorCodes> errors = default(List<WorkflowSchedulerErrorCodes>), string stopSourceJobId = default(string), int queueSize = default(int), List<int> queuedOrderIds = default(List<int>), string errorDetails = default(string), int lastLoadedItemId = default(int), int upTimeSeconds = default(int), string workflowTypeName = default(string), string sessionId = default(string))
        {
            this.Status = status;
            this.StopReason = stopReason;
            this.Errors = errors;
            this.StopSourceJobId = stopSourceJobId;
            this.QueueSize = queueSize;
            this.QueuedOrderIds = queuedOrderIds;
            this.ErrorDetails = errorDetails;
            this.LastLoadedItemId = lastLoadedItemId;
            this.UpTimeSeconds = upTimeSeconds;
            this.WorkflowTypeName = workflowTypeName;
            this.SessionId = sessionId;
        }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", EmitDefaultValue = true)]
        public List<WorkflowSchedulerErrorCodes> Errors { get; set; }

        /// <summary>
        /// Gets or Sets StopSourceJobId
        /// </summary>
        [DataMember(Name = "stopSourceJobId", EmitDefaultValue = true)]
        public string StopSourceJobId { get; set; }

        /// <summary>
        /// Gets or Sets QueueSize
        /// </summary>
        [DataMember(Name = "queueSize", EmitDefaultValue = false)]
        public int QueueSize { get; set; }

        /// <summary>
        /// Gets or Sets QueuedOrderIds
        /// </summary>
        [DataMember(Name = "queuedOrderIds", EmitDefaultValue = true)]
        public List<int> QueuedOrderIds { get; set; }

        /// <summary>
        /// Gets or Sets ErrorDetails
        /// </summary>
        [DataMember(Name = "errorDetails", EmitDefaultValue = true)]
        public string ErrorDetails { get; set; }

        /// <summary>
        /// Gets or Sets LastLoadedItemId
        /// </summary>
        [DataMember(Name = "lastLoadedItemId", EmitDefaultValue = false)]
        public int LastLoadedItemId { get; set; }

        /// <summary>
        /// Gets or Sets UpTimeSeconds
        /// </summary>
        [DataMember(Name = "upTimeSeconds", EmitDefaultValue = false)]
        public int UpTimeSeconds { get; set; }

        /// <summary>
        /// Gets or Sets CurrentJobTemplateName
        /// </summary>
        [DataMember(Name = "currentJobTemplateName", EmitDefaultValue = true)]
        public string CurrentJobTemplateName { get; private set; }

        /// <summary>
        /// Returns false as CurrentJobTemplateName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCurrentJobTemplateName()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CurrentJobTemplateId
        /// </summary>
        [DataMember(Name = "currentJobTemplateId", EmitDefaultValue = true)]
        public int? CurrentJobTemplateId { get; private set; }

        /// <summary>
        /// Returns false as CurrentJobTemplateId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCurrentJobTemplateId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets WorkflowTypeName
        /// </summary>
        [DataMember(Name = "workflowTypeName", EmitDefaultValue = true)]
        public string WorkflowTypeName { get; set; }

        /// <summary>
        /// Gets or Sets SessionId
        /// </summary>
        [DataMember(Name = "sessionId", EmitDefaultValue = true)]
        public string SessionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkflowSchedulerStateDto {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StopReason: ").Append(StopReason).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  StopSourceJobId: ").Append(StopSourceJobId).Append("\n");
            sb.Append("  QueueSize: ").Append(QueueSize).Append("\n");
            sb.Append("  QueuedOrderIds: ").Append(QueuedOrderIds).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  LastLoadedItemId: ").Append(LastLoadedItemId).Append("\n");
            sb.Append("  UpTimeSeconds: ").Append(UpTimeSeconds).Append("\n");
            sb.Append("  CurrentJobTemplateName: ").Append(CurrentJobTemplateName).Append("\n");
            sb.Append("  CurrentJobTemplateId: ").Append(CurrentJobTemplateId).Append("\n");
            sb.Append("  WorkflowTypeName: ").Append(WorkflowTypeName).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
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
