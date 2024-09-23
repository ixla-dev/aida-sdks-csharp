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
    /// JobInstance
    /// </summary>
    [DataContract(Name = "JobInstance")]
    public partial class JobInstance : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets JobStatus
        /// </summary>
        [DataMember(Name = "jobStatus", EmitDefaultValue = false)]
        public JobStatus? JobStatus { get; set; }

        /// <summary>
        /// Gets or Sets ErrorCodes
        /// </summary>
        [DataMember(Name = "errorCodes", EmitDefaultValue = false)]
        public JobErrorCodes? ErrorCodes { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="JobInstance" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="jobId">jobId.</param>
        /// <param name="workflowInstanceId">workflowInstanceId.</param>
        /// <param name="correlationId">correlationId.</param>
        /// <param name="sessionId">sessionId.</param>
        /// <param name="batchId">batchId.</param>
        /// <param name="jobStatus">jobStatus.</param>
        /// <param name="errorCodes">errorCodes.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="startedAt">startedAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="finishedAt">finishedAt.</param>
        /// <param name="persoOperations">persoOperations.</param>
        /// <param name="executingOperationId">executingOperationId.</param>
        /// <param name="currentPositionId">currentPositionId.</param>
        /// <param name="documentProduced">documentProduced.</param>
        public JobInstance(int id = default(int), string jobId = default(string), string workflowInstanceId = default(string), string correlationId = default(string), string sessionId = default(string), string batchId = default(string), JobStatus? jobStatus = default(JobStatus?), JobErrorCodes? errorCodes = default(JobErrorCodes?), DateTime createdAt = default(DateTime), DateTime? startedAt = default(DateTime?), DateTime? updatedAt = default(DateTime?), DateTime? finishedAt = default(DateTime?), List<PersoOperationInstance> persoOperations = default(List<PersoOperationInstance>), string executingOperationId = default(string), string currentPositionId = default(string), bool documentProduced = default(bool))
        {
            this.Id = id;
            this.JobId = jobId;
            this.WorkflowInstanceId = workflowInstanceId;
            this.CorrelationId = correlationId;
            this.SessionId = sessionId;
            this.BatchId = batchId;
            this.JobStatus = jobStatus;
            this.ErrorCodes = errorCodes;
            this.CreatedAt = createdAt;
            this.StartedAt = startedAt;
            this.UpdatedAt = updatedAt;
            this.FinishedAt = finishedAt;
            this.PersoOperations = persoOperations;
            this.ExecutingOperationId = executingOperationId;
            this.CurrentPositionId = currentPositionId;
            this.DocumentProduced = documentProduced;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets JobId
        /// </summary>
        [DataMember(Name = "jobId", EmitDefaultValue = true)]
        public string JobId { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowInstanceId
        /// </summary>
        [DataMember(Name = "workflowInstanceId", EmitDefaultValue = true)]
        public string WorkflowInstanceId { get; set; }

        /// <summary>
        /// Gets or Sets CorrelationId
        /// </summary>
        [DataMember(Name = "correlationId", EmitDefaultValue = true)]
        public string CorrelationId { get; set; }

        /// <summary>
        /// Gets or Sets SessionId
        /// </summary>
        [DataMember(Name = "sessionId", EmitDefaultValue = true)]
        public string SessionId { get; set; }

        /// <summary>
        /// Gets or Sets BatchId
        /// </summary>
        [DataMember(Name = "batchId", EmitDefaultValue = true)]
        public string BatchId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets StartedAt
        /// </summary>
        [DataMember(Name = "startedAt", EmitDefaultValue = true)]
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", EmitDefaultValue = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets FinishedAt
        /// </summary>
        [DataMember(Name = "finishedAt", EmitDefaultValue = true)]
        public DateTime? FinishedAt { get; set; }

        /// <summary>
        /// Gets or Sets PersoOperations
        /// </summary>
        [DataMember(Name = "persoOperations", EmitDefaultValue = true)]
        public List<PersoOperationInstance> PersoOperations { get; set; }

        /// <summary>
        /// Gets or Sets ExecutingOperationId
        /// </summary>
        [DataMember(Name = "executingOperationId", EmitDefaultValue = true)]
        public string ExecutingOperationId { get; set; }

        /// <summary>
        /// Gets or Sets CurrentPositionId
        /// </summary>
        [DataMember(Name = "currentPositionId", EmitDefaultValue = true)]
        public string CurrentPositionId { get; set; }

        /// <summary>
        /// Gets or Sets DocumentProduced
        /// </summary>
        [DataMember(Name = "documentProduced", EmitDefaultValue = true)]
        public bool DocumentProduced { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JobInstance {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  WorkflowInstanceId: ").Append(WorkflowInstanceId).Append("\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  BatchId: ").Append(BatchId).Append("\n");
            sb.Append("  JobStatus: ").Append(JobStatus).Append("\n");
            sb.Append("  ErrorCodes: ").Append(ErrorCodes).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  StartedAt: ").Append(StartedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  FinishedAt: ").Append(FinishedAt).Append("\n");
            sb.Append("  PersoOperations: ").Append(PersoOperations).Append("\n");
            sb.Append("  ExecutingOperationId: ").Append(ExecutingOperationId).Append("\n");
            sb.Append("  CurrentPositionId: ").Append(CurrentPositionId).Append("\n");
            sb.Append("  DocumentProduced: ").Append(DocumentProduced).Append("\n");
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
