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
    /// JobTemplateLayoutDto
    /// </summary>
    [DataContract(Name = "JobTemplateLayoutDto")]
    public partial class JobTemplateLayoutDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobTemplateLayoutDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="layout">layout.</param>
        /// <param name="index">index.</param>
        /// <param name="layoutId">layoutId.</param>
        /// <param name="jobTemplateId">jobTemplateId.</param>
        /// <param name="supportSide">supportSide.</param>
        /// <param name="mirrorX">mirrorX.</param>
        /// <param name="mirrorY">mirrorY.</param>
        /// <param name="autoPosSettings">autoPosSettings.</param>
        public JobTemplateLayoutDto(int id = default(int), LayoutDto layout = default(LayoutDto), int index = default(int), int layoutId = default(int), int jobTemplateId = default(int), string supportSide = default(string), bool? mirrorX = default(bool?), bool? mirrorY = default(bool?), List<JobTemplateLayoutAutoPosSettingsDto> autoPosSettings = default(List<JobTemplateLayoutAutoPosSettingsDto>))
        {
            this.Id = id;
            this.Layout = layout;
            this.Index = index;
            this.LayoutId = layoutId;
            this.JobTemplateId = jobTemplateId;
            this.SupportSide = supportSide;
            this.MirrorX = mirrorX;
            this.MirrorY = mirrorY;
            this.AutoPosSettings = autoPosSettings;
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
        public LayoutDto Layout { get; set; }

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
        /// Gets or Sets MirrorX
        /// </summary>
        [DataMember(Name = "mirrorX", EmitDefaultValue = true)]
        public bool? MirrorX { get; set; }

        /// <summary>
        /// Gets or Sets MirrorY
        /// </summary>
        [DataMember(Name = "mirrorY", EmitDefaultValue = true)]
        public bool? MirrorY { get; set; }

        /// <summary>
        /// Gets or Sets AutoPosSettings
        /// </summary>
        [DataMember(Name = "autoPosSettings", EmitDefaultValue = true)]
        public List<JobTemplateLayoutAutoPosSettingsDto> AutoPosSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JobTemplateLayoutDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Layout: ").Append(Layout).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  LayoutId: ").Append(LayoutId).Append("\n");
            sb.Append("  JobTemplateId: ").Append(JobTemplateId).Append("\n");
            sb.Append("  SupportSide: ").Append(SupportSide).Append("\n");
            sb.Append("  MirrorX: ").Append(MirrorX).Append("\n");
            sb.Append("  MirrorY: ").Append(MirrorY).Append("\n");
            sb.Append("  AutoPosSettings: ").Append(AutoPosSettings).Append("\n");
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
