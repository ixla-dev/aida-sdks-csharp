/*
 * aida-mini
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
using FileParameter = Aida.Sdk.Mini.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Mini.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Mini.Model
{
    /// <summary>
    /// JobTemplateInkjetLayoutDto
    /// </summary>
    [DataContract(Name = "JobTemplateInkjetLayoutDto")]
    public partial class JobTemplateInkjetLayoutDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobTemplateInkjetLayoutDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="layout">layout.</param>
        /// <param name="index">index.</param>
        /// <param name="layoutId">layoutId.</param>
        /// <param name="jobTemplateId">jobTemplateId.</param>
        /// <param name="supportSide">supportSide.</param>
        /// <param name="printSettings">printSettings.</param>
        public JobTemplateInkjetLayoutDto(int id = default(int), InkjetLayoutDto layout = default(InkjetLayoutDto), int index = default(int), int layoutId = default(int), int jobTemplateId = default(int), string supportSide = default(string), PrintSettingsDto printSettings = default(PrintSettingsDto))
        {
            this.Id = id;
            this.Layout = layout;
            this.Index = index;
            this.LayoutId = layoutId;
            this.JobTemplateId = jobTemplateId;
            this.SupportSide = supportSide;
            this.PrintSettings = printSettings;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Layout
        /// </summary>
        [DataMember(Name = "layout", EmitDefaultValue = false)]
        public InkjetLayoutDto Layout { get; set; }

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
        /// Gets or Sets SupportSide
        /// </summary>
        [DataMember(Name = "supportSide", EmitDefaultValue = true)]
        public string SupportSide { get; set; }

        /// <summary>
        /// Gets or Sets PrintSettings
        /// </summary>
        [DataMember(Name = "printSettings", EmitDefaultValue = false)]
        public PrintSettingsDto PrintSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JobTemplateInkjetLayoutDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Layout: ").Append(Layout).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  LayoutId: ").Append(LayoutId).Append("\n");
            sb.Append("  JobTemplateId: ").Append(JobTemplateId).Append("\n");
            sb.Append("  SupportSide: ").Append(SupportSide).Append("\n");
            sb.Append("  PrintSettings: ").Append(PrintSettings).Append("\n");
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
