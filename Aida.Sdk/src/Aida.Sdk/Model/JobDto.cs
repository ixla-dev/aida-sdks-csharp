/*
 * aida
 *
 * 1.0.703.1
 *
 * The version of the OpenAPI document: 1.0.703.1
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
    /// JobDto
    /// </summary>
    [DataContract(Name = "JobDto")]
    public partial class JobDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets JobStatus
        /// </summary>
        [DataMember(Name = "jobStatus", EmitDefaultValue = false)]
        public JobStatus? JobStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="JobDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="completedAt">completedAt.</param>
        /// <param name="jobStatus">jobStatus.</param>
        /// <param name="workflowStatus">workflowStatus.</param>
        /// <param name="workflowInstanceId">workflowInstanceId.</param>
        public JobDto(int id = default(int), DateTime? createdAt = default(DateTime?), DateTime? updatedAt = default(DateTime?), DateTime? completedAt = default(DateTime?), JobStatus? jobStatus = default(JobStatus?), string workflowStatus = default(string), string workflowInstanceId = default(string))
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.CompletedAt = completedAt;
            this.JobStatus = jobStatus;
            this.WorkflowStatus = workflowStatus;
            this.WorkflowInstanceId = workflowInstanceId;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", EmitDefaultValue = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets CompletedAt
        /// </summary>
        [DataMember(Name = "completedAt", EmitDefaultValue = true)]
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowStatus
        /// </summary>
        [DataMember(Name = "workflowStatus", EmitDefaultValue = true)]
        public string WorkflowStatus { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowInstanceId
        /// </summary>
        [DataMember(Name = "workflowInstanceId", EmitDefaultValue = true)]
        public string WorkflowInstanceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JobDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CompletedAt: ").Append(CompletedAt).Append("\n");
            sb.Append("  JobStatus: ").Append(JobStatus).Append("\n");
            sb.Append("  WorkflowStatus: ").Append(WorkflowStatus).Append("\n");
            sb.Append("  WorkflowInstanceId: ").Append(WorkflowInstanceId).Append("\n");
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
