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
    /// ExternalProcessCompletedMessage
    /// </summary>
    [DataContract(Name = "ExternalProcessCompletedMessage")]
    public partial class ExternalProcessCompletedMessage : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets RequiredAction
        /// </summary>
        [DataMember(Name = "requiredAction", EmitDefaultValue = false)]
        public WorkflowAction? RequiredAction { get; set; }

        /// <summary>
        /// Gets or Sets Outcome
        /// </summary>
        [DataMember(Name = "outcome", EmitDefaultValue = false)]
        public ExternalProcessOutcome? Outcome { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalProcessCompletedMessage" /> class.
        /// </summary>
        /// <param name="errorReason">errorReason.</param>
        /// <param name="workflowInstanceId">workflowInstanceId.</param>
        /// <param name="requiredAction">requiredAction.</param>
        /// <param name="outcome">outcome.</param>
        public ExternalProcessCompletedMessage(string errorReason = default(string), string workflowInstanceId = default(string), WorkflowAction? requiredAction = default(WorkflowAction?), ExternalProcessOutcome? outcome = default(ExternalProcessOutcome?))
        {
            this.ErrorReason = errorReason;
            this.WorkflowInstanceId = workflowInstanceId;
            this.RequiredAction = requiredAction;
            this.Outcome = outcome;
        }

        /// <summary>
        /// Gets or Sets ErrorReason
        /// </summary>
        [DataMember(Name = "errorReason", EmitDefaultValue = true)]
        public string ErrorReason { get; set; }

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
            sb.Append("class ExternalProcessCompletedMessage {\n");
            sb.Append("  ErrorReason: ").Append(ErrorReason).Append("\n");
            sb.Append("  WorkflowInstanceId: ").Append(WorkflowInstanceId).Append("\n");
            sb.Append("  RequiredAction: ").Append(RequiredAction).Append("\n");
            sb.Append("  Outcome: ").Append(Outcome).Append("\n");
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
