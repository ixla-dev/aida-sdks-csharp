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
    /// WorkflowAuditEntryDto
    /// </summary>
    [DataContract(Name = "WorkflowAuditEntryDto")]
    public partial class WorkflowAuditEntryDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowAuditEntryDto" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="jobTemplateId">jobTemplateId.</param>
        /// <param name="workflowId">workflowId.</param>
        /// <param name="recordId">recordId.</param>
        /// <param name="sessionId">sessionId.</param>
        /// <param name="operation">operation.</param>
        /// <param name="layoutName">layoutName.</param>
        /// <param name="ocrName">ocrName.</param>
        /// <param name="autoposName">autoposName.</param>
        /// <param name="webhookName">webhookName.</param>
        /// <param name="sourcePosition">sourcePosition.</param>
        /// <param name="position">position.</param>
        /// <param name="success">success.</param>
        /// <param name="elapsedMs">elapsedMs.</param>
        /// <param name="result">result.</param>
        public WorkflowAuditEntryDto(string description = default(string), int jobTemplateId = default(int), string workflowId = default(string), int recordId = default(int), string sessionId = default(string), string operation = default(string), string layoutName = default(string), string ocrName = default(string), string autoposName = default(string), string webhookName = default(string), string sourcePosition = default(string), string position = default(string), bool? success = default(bool?), long? elapsedMs = default(long?), string result = default(string))
        {
            this.Description = description;
            this.JobTemplateId = jobTemplateId;
            this.WorkflowId = workflowId;
            this.RecordId = recordId;
            this.SessionId = sessionId;
            this.Operation = operation;
            this.LayoutName = layoutName;
            this.OcrName = ocrName;
            this.AutoposName = autoposName;
            this.WebhookName = webhookName;
            this.SourcePosition = sourcePosition;
            this.Position = position;
            this.Success = success;
            this.ElapsedMs = elapsedMs;
            this.Result = result;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        public DateTime Timestamp { get; private set; }

        /// <summary>
        /// Returns false as Timestamp should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTimestamp()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets JobTemplateId
        /// </summary>
        [DataMember(Name = "jobTemplateId", EmitDefaultValue = false)]
        public int JobTemplateId { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowId
        /// </summary>
        [DataMember(Name = "workflowId", EmitDefaultValue = true)]
        public string WorkflowId { get; set; }

        /// <summary>
        /// Gets or Sets RecordId
        /// </summary>
        [DataMember(Name = "recordId", EmitDefaultValue = false)]
        public int RecordId { get; set; }

        /// <summary>
        /// Gets or Sets SessionId
        /// </summary>
        [DataMember(Name = "sessionId", EmitDefaultValue = true)]
        public string SessionId { get; set; }

        /// <summary>
        /// Gets or Sets Operation
        /// </summary>
        [DataMember(Name = "operation", EmitDefaultValue = true)]
        public string Operation { get; set; }

        /// <summary>
        /// Gets or Sets LayoutName
        /// </summary>
        [DataMember(Name = "layoutName", EmitDefaultValue = true)]
        public string LayoutName { get; set; }

        /// <summary>
        /// Gets or Sets OcrName
        /// </summary>
        [DataMember(Name = "ocrName", EmitDefaultValue = true)]
        public string OcrName { get; set; }

        /// <summary>
        /// Gets or Sets AutoposName
        /// </summary>
        [DataMember(Name = "autoposName", EmitDefaultValue = true)]
        public string AutoposName { get; set; }

        /// <summary>
        /// Gets or Sets WebhookName
        /// </summary>
        [DataMember(Name = "webhookName", EmitDefaultValue = true)]
        public string WebhookName { get; set; }

        /// <summary>
        /// Gets or Sets SourcePosition
        /// </summary>
        [DataMember(Name = "sourcePosition", EmitDefaultValue = true)]
        public string SourcePosition { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name = "position", EmitDefaultValue = true)]
        public string Position { get; set; }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name = "success", EmitDefaultValue = true)]
        public bool? Success { get; set; }

        /// <summary>
        /// Gets or Sets ElapsedMs
        /// </summary>
        [DataMember(Name = "elapsedMs", EmitDefaultValue = true)]
        public long? ElapsedMs { get; set; }

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name = "result", EmitDefaultValue = true)]
        public string Result { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkflowAuditEntryDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  JobTemplateId: ").Append(JobTemplateId).Append("\n");
            sb.Append("  WorkflowId: ").Append(WorkflowId).Append("\n");
            sb.Append("  RecordId: ").Append(RecordId).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  LayoutName: ").Append(LayoutName).Append("\n");
            sb.Append("  OcrName: ").Append(OcrName).Append("\n");
            sb.Append("  AutoposName: ").Append(AutoposName).Append("\n");
            sb.Append("  WebhookName: ").Append(WebhookName).Append("\n");
            sb.Append("  SourcePosition: ").Append(SourcePosition).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  ElapsedMs: ").Append(ElapsedMs).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
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
