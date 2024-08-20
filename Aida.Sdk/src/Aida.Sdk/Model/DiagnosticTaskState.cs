/*
 * aida
 *
 * 1.0.703.2
 *
 * The version of the OpenAPI document: 1.0.703.2
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
    /// DiagnosticTaskState
    /// </summary>
    [DataContract(Name = "DiagnosticTaskState")]
    public partial class DiagnosticTaskState : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public DiagnosticTaskType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticTaskState" /> class.
        /// </summary>
        /// <param name="title">title.</param>
        /// <param name="type">type.</param>
        /// <param name="activities">activities.</param>
        /// <param name="currentActivity">currentActivity.</param>
        /// <param name="errorReason">errorReason.</param>
        public DiagnosticTaskState(string title = default(string), DiagnosticTaskType? type = default(DiagnosticTaskType?), List<DiagnosticActivity> activities = default(List<DiagnosticActivity>), DiagnosticActivity currentActivity = default(DiagnosticActivity), string errorReason = default(string))
        {
            this.Title = title;
            this.Type = type;
            this.Activities = activities;
            this.CurrentActivity = currentActivity;
            this.ErrorReason = errorReason;
        }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Activities
        /// </summary>
        [DataMember(Name = "activities", EmitDefaultValue = true)]
        public List<DiagnosticActivity> Activities { get; set; }

        /// <summary>
        /// Gets or Sets IsRunning
        /// </summary>
        [DataMember(Name = "isRunning", EmitDefaultValue = true)]
        public bool IsRunning { get; private set; }

        /// <summary>
        /// Returns false as IsRunning should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsRunning()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CurrentActivity
        /// </summary>
        [DataMember(Name = "currentActivity", EmitDefaultValue = false)]
        public DiagnosticActivity CurrentActivity { get; set; }

        /// <summary>
        /// Gets or Sets TotalActivitiesCount
        /// </summary>
        [DataMember(Name = "totalActivitiesCount", EmitDefaultValue = false)]
        public int TotalActivitiesCount { get; private set; }

        /// <summary>
        /// Returns false as TotalActivitiesCount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTotalActivitiesCount()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CompletedActivitiesCount
        /// </summary>
        [DataMember(Name = "completedActivitiesCount", EmitDefaultValue = false)]
        public int CompletedActivitiesCount { get; private set; }

        /// <summary>
        /// Returns false as CompletedActivitiesCount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCompletedActivitiesCount()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets FailedActivitiesCount
        /// </summary>
        [DataMember(Name = "failedActivitiesCount", EmitDefaultValue = false)]
        public int FailedActivitiesCount { get; private set; }

        /// <summary>
        /// Returns false as FailedActivitiesCount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFailedActivitiesCount()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets IdleActivitiesCount
        /// </summary>
        [DataMember(Name = "idleActivitiesCount", EmitDefaultValue = false)]
        public int IdleActivitiesCount { get; private set; }

        /// <summary>
        /// Returns false as IdleActivitiesCount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIdleActivitiesCount()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets AverageExecutionTime
        /// </summary>
        [DataMember(Name = "averageExecutionTime", EmitDefaultValue = false)]
        public double AverageExecutionTime { get; private set; }

        /// <summary>
        /// Returns false as AverageExecutionTime should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAverageExecutionTime()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ErrorReason
        /// </summary>
        [DataMember(Name = "errorReason", EmitDefaultValue = true)]
        public string ErrorReason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DiagnosticTaskState {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Activities: ").Append(Activities).Append("\n");
            sb.Append("  IsRunning: ").Append(IsRunning).Append("\n");
            sb.Append("  CurrentActivity: ").Append(CurrentActivity).Append("\n");
            sb.Append("  TotalActivitiesCount: ").Append(TotalActivitiesCount).Append("\n");
            sb.Append("  CompletedActivitiesCount: ").Append(CompletedActivitiesCount).Append("\n");
            sb.Append("  FailedActivitiesCount: ").Append(FailedActivitiesCount).Append("\n");
            sb.Append("  IdleActivitiesCount: ").Append(IdleActivitiesCount).Append("\n");
            sb.Append("  AverageExecutionTime: ").Append(AverageExecutionTime).Append("\n");
            sb.Append("  ErrorReason: ").Append(ErrorReason).Append("\n");
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
