/*
 * aida-mini
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
using FileParameter = Aida.Sdk.Mini.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Mini.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Mini.Model
{
    /// <summary>
    /// JobTemplateLayoutAutoPosSettingsDto
    /// </summary>
    [DataContract(Name = "JobTemplateLayoutAutoPosSettingsDto")]
    public partial class JobTemplateLayoutAutoPosSettingsDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobTemplateLayoutAutoPosSettingsDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="index">index.</param>
        /// <param name="layoutId">layoutId.</param>
        /// <param name="jobTemplateId">jobTemplateId.</param>
        /// <param name="layoutName">layoutName.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="threshold">threshold.</param>
        /// <param name="debugUrl">debugUrl.</param>
        /// <param name="templateMatchingConfiguration">templateMatchingConfiguration.</param>
        public JobTemplateLayoutAutoPosSettingsDto(int id = default(int), int index = default(int), int layoutId = default(int), int jobTemplateId = default(int), string layoutName = default(string), string displayName = default(string), float? threshold = default(float?), string debugUrl = default(string), TemplateMatchingConfigurationDto templateMatchingConfiguration = default(TemplateMatchingConfigurationDto))
        {
            this.Id = id;
            this.Index = index;
            this.LayoutId = layoutId;
            this.JobTemplateId = jobTemplateId;
            this.LayoutName = layoutName;
            this.DisplayName = displayName;
            this.Threshold = threshold;
            this.DebugUrl = debugUrl;
            this.TemplateMatchingConfiguration = templateMatchingConfiguration;
        }

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
        /// Gets or Sets LayoutId
        /// </summary>
        [DataMember(Name = "layoutId", EmitDefaultValue = false)]
        public int LayoutId { get; set; }

        /// <summary>
        /// Gets or Sets JobTemplateId
        /// </summary>
        [DataMember(Name = "jobTemplateId", EmitDefaultValue = false)]
        public int JobTemplateId { get; set; }

        /// <summary>
        /// Gets or Sets LayoutName
        /// </summary>
        [DataMember(Name = "layoutName", EmitDefaultValue = true)]
        public string LayoutName { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Threshold
        /// </summary>
        [DataMember(Name = "threshold", EmitDefaultValue = true)]
        public float? Threshold { get; set; }

        /// <summary>
        /// Gets or Sets DebugUrl
        /// </summary>
        [DataMember(Name = "debugUrl", EmitDefaultValue = true)]
        public string DebugUrl { get; set; }

        /// <summary>
        /// Gets or Sets TemplateMatchingConfiguration
        /// </summary>
        [DataMember(Name = "templateMatchingConfiguration", EmitDefaultValue = false)]
        public TemplateMatchingConfigurationDto TemplateMatchingConfiguration { get; set; }

        /// <summary>
        /// Gets or Sets IsConfigured
        /// </summary>
        [DataMember(Name = "isConfigured", EmitDefaultValue = true)]
        public bool IsConfigured { get; private set; }

        /// <summary>
        /// Returns false as IsConfigured should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsConfigured()
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
            sb.Append("class JobTemplateLayoutAutoPosSettingsDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  LayoutId: ").Append(LayoutId).Append("\n");
            sb.Append("  JobTemplateId: ").Append(JobTemplateId).Append("\n");
            sb.Append("  LayoutName: ").Append(LayoutName).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Threshold: ").Append(Threshold).Append("\n");
            sb.Append("  DebugUrl: ").Append(DebugUrl).Append("\n");
            sb.Append("  TemplateMatchingConfiguration: ").Append(TemplateMatchingConfiguration).Append("\n");
            sb.Append("  IsConfigured: ").Append(IsConfigured).Append("\n");
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
