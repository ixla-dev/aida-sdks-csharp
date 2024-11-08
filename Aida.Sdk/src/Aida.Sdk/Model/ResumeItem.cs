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
    /// ResumeItem
    /// </summary>
    [DataContract(Name = "ResumeItem")]
    public partial class ResumeItem : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResumeItem" /> class.
        /// </summary>
        /// <param name="jobInstanceId">jobInstanceId.</param>
        /// <param name="jobId">jobId.</param>
        /// <param name="correlationId">correlationId.</param>
        /// <param name="workflowInstanceId">workflowInstanceId.</param>
        public ResumeItem(int jobInstanceId = default(int), string jobId = default(string), string correlationId = default(string), string workflowInstanceId = default(string))
        {
            this.JobInstanceId = jobInstanceId;
            this.JobId = jobId;
            this.CorrelationId = correlationId;
            this.WorkflowInstanceId = workflowInstanceId;
        }

        /// <summary>
        /// Gets or Sets JobInstanceId
        /// </summary>
        [DataMember(Name = "jobInstanceId", EmitDefaultValue = false)]
        public int JobInstanceId { get; set; }

        /// <summary>
        /// Gets or Sets JobId
        /// </summary>
        [DataMember(Name = "jobId", EmitDefaultValue = true)]
        public string JobId { get; set; }

        /// <summary>
        /// Gets or Sets CorrelationId
        /// </summary>
        [DataMember(Name = "correlationId", EmitDefaultValue = true)]
        public string CorrelationId { get; set; }

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
            sb.Append("class ResumeItem {\n");
            sb.Append("  JobInstanceId: ").Append(JobInstanceId).Append("\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
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
