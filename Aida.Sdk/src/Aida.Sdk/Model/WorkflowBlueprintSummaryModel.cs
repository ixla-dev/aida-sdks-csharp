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
    /// WorkflowBlueprintSummaryModel
    /// </summary>
    [DataContract(Name = "WorkflowBlueprintSummaryModel")]
    public partial class WorkflowBlueprintSummaryModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowBlueprintSummaryModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="versionId">versionId.</param>
        /// <param name="name">name.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="description">description.</param>
        /// <param name="varVersion">varVersion.</param>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="isSingleton">isSingleton.</param>
        /// <param name="isPublished">isPublished.</param>
        /// <param name="isLatest">isLatest.</param>
        /// <param name="isDisabled">isDisabled.</param>
        public WorkflowBlueprintSummaryModel(string id = default(string), string versionId = default(string), string name = default(string), string displayName = default(string), string description = default(string), int varVersion = default(int), string tenantId = default(string), bool isSingleton = default(bool), bool isPublished = default(bool), bool isLatest = default(bool), bool isDisabled = default(bool))
        {
            this.Id = id;
            this.VersionId = versionId;
            this.Name = name;
            this.DisplayName = displayName;
            this.Description = description;
            this.VarVersion = varVersion;
            this.TenantId = tenantId;
            this.IsSingleton = isSingleton;
            this.IsPublished = isPublished;
            this.IsLatest = isLatest;
            this.IsDisabled = isDisabled;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets VersionId
        /// </summary>
        [DataMember(Name = "versionId", EmitDefaultValue = true)]
        public string VersionId { get; set; }

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
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets VarVersion
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int VarVersion { get; set; }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets IsSingleton
        /// </summary>
        [DataMember(Name = "isSingleton", EmitDefaultValue = true)]
        public bool IsSingleton { get; set; }

        /// <summary>
        /// Gets or Sets IsPublished
        /// </summary>
        [DataMember(Name = "isPublished", EmitDefaultValue = true)]
        public bool IsPublished { get; set; }

        /// <summary>
        /// Gets or Sets IsLatest
        /// </summary>
        [DataMember(Name = "isLatest", EmitDefaultValue = true)]
        public bool IsLatest { get; set; }

        /// <summary>
        /// Gets or Sets IsDisabled
        /// </summary>
        [DataMember(Name = "isDisabled", EmitDefaultValue = true)]
        public bool IsDisabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkflowBlueprintSummaryModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  VersionId: ").Append(VersionId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  IsSingleton: ").Append(IsSingleton).Append("\n");
            sb.Append("  IsPublished: ").Append(IsPublished).Append("\n");
            sb.Append("  IsLatest: ").Append(IsLatest).Append("\n");
            sb.Append("  IsDisabled: ").Append(IsDisabled).Append("\n");
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
