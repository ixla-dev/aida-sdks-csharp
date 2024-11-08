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
    /// PersoOperationInstanceDto
    /// </summary>
    [DataContract(Name = "PersoOperationInstanceDto")]
    public partial class PersoOperationInstanceDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public PersoOperationStatus? Status { get; set; }

        /// <summary>
        /// Gets or Sets Outcome
        /// </summary>
        [DataMember(Name = "outcome", EmitDefaultValue = false)]
        public PersoOperationOutcome? Outcome { get; set; }

        /// <summary>
        /// Gets or Sets OperationType
        /// </summary>
        [DataMember(Name = "operationType", EmitDefaultValue = false)]
        public PersoOperationTypes? OperationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PersoOperationInstanceDto" /> class.
        /// </summary>
        /// <param name="jobInstanceId">jobInstanceId.</param>
        /// <param name="id">id.</param>
        /// <param name="index">index.</param>
        /// <param name="operationId">operationId.</param>
        /// <param name="name">name.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="startedAt">startedAt.</param>
        /// <param name="finishedAt">finishedAt.</param>
        /// <param name="status">status.</param>
        /// <param name="outcome">outcome.</param>
        /// <param name="operationType">operationType.</param>
        public PersoOperationInstanceDto(int jobInstanceId = default(int), int id = default(int), int index = default(int), string operationId = default(string), string name = default(string), string displayName = default(string), DateTime? createdAt = default(DateTime?), DateTime? updatedAt = default(DateTime?), DateTime? startedAt = default(DateTime?), DateTime? finishedAt = default(DateTime?), PersoOperationStatus? status = default(PersoOperationStatus?), PersoOperationOutcome? outcome = default(PersoOperationOutcome?), PersoOperationTypes? operationType = default(PersoOperationTypes?))
        {
            this.JobInstanceId = jobInstanceId;
            this.Id = id;
            this.Index = index;
            this.OperationId = operationId;
            this.Name = name;
            this.DisplayName = displayName;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.StartedAt = startedAt;
            this.FinishedAt = finishedAt;
            this.Status = status;
            this.Outcome = outcome;
            this.OperationType = operationType;
        }

        /// <summary>
        /// Gets or Sets JobInstanceId
        /// </summary>
        [DataMember(Name = "jobInstanceId", EmitDefaultValue = false)]
        public int JobInstanceId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Index
        /// </summary>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public int Index { get; set; }

        /// <summary>
        /// Gets or Sets OperationId
        /// </summary>
        [DataMember(Name = "operationId", EmitDefaultValue = true)]
        public string OperationId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        /// <example>2019-12-10T10:06:50.466318Z</example>
        [DataMember(Name = "createdAt", EmitDefaultValue = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        /// <example>2019-12-10T10:06:50.466318Z</example>
        [DataMember(Name = "updatedAt", EmitDefaultValue = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets StartedAt
        /// </summary>
        /// <example>2019-12-10T10:06:50.466318Z</example>
        [DataMember(Name = "startedAt", EmitDefaultValue = true)]
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Gets or Sets FinishedAt
        /// </summary>
        /// <example>2019-12-10T10:06:50.466318Z</example>
        [DataMember(Name = "finishedAt", EmitDefaultValue = true)]
        public DateTime? FinishedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PersoOperationInstanceDto {\n");
            sb.Append("  JobInstanceId: ").Append(JobInstanceId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  OperationId: ").Append(OperationId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  StartedAt: ").Append(StartedAt).Append("\n");
            sb.Append("  FinishedAt: ").Append(FinishedAt).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Outcome: ").Append(Outcome).Append("\n");
            sb.Append("  OperationType: ").Append(OperationType).Append("\n");
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
