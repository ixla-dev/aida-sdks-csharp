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
    /// AutoPosConfigSummaryModel
    /// </summary>
    [DataContract(Name = "AutoPosConfigSummaryModel")]
    public partial class AutoPosConfigSummaryModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoPosConfigSummaryModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="isConfigured">isConfigured.</param>
        /// <param name="threshold">threshold.</param>
        /// <param name="templateMatchingConfigurationId">templateMatchingConfigurationId.</param>
        public AutoPosConfigSummaryModel(int id = default(int), string displayName = default(string), bool isConfigured = default(bool), float threshold = default(float), int templateMatchingConfigurationId = default(int))
        {
            this.Id = id;
            this.DisplayName = displayName;
            this.IsConfigured = isConfigured;
            this.Threshold = threshold;
            this.TemplateMatchingConfigurationId = templateMatchingConfigurationId;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets IsConfigured
        /// </summary>
        [DataMember(Name = "isConfigured", EmitDefaultValue = true)]
        public bool IsConfigured { get; set; }

        /// <summary>
        /// Gets or Sets Threshold
        /// </summary>
        [DataMember(Name = "threshold", EmitDefaultValue = false)]
        public float Threshold { get; set; }

        /// <summary>
        /// Gets or Sets TemplateMatchingConfigurationId
        /// </summary>
        [DataMember(Name = "templateMatchingConfigurationId", EmitDefaultValue = false)]
        public int TemplateMatchingConfigurationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutoPosConfigSummaryModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  IsConfigured: ").Append(IsConfigured).Append("\n");
            sb.Append("  Threshold: ").Append(Threshold).Append("\n");
            sb.Append("  TemplateMatchingConfigurationId: ").Append(TemplateMatchingConfigurationId).Append("\n");
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
