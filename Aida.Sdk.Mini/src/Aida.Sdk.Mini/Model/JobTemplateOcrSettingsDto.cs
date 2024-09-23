/*
 * aida-mini
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
using FileParameter = Aida.Sdk.Mini.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Mini.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Mini.Model
{
    /// <summary>
    /// JobTemplateOcrSettingsDto
    /// </summary>
    [DataContract(Name = "JobTemplateOcrSettingsDto")]
    public partial class JobTemplateOcrSettingsDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets SupportSide
        /// </summary>
        [DataMember(Name = "supportSide", EmitDefaultValue = false)]
        public SupportSide? SupportSide { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="JobTemplateOcrSettingsDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="jobTemplateId">jobTemplateId.</param>
        /// <param name="ocrSettingsId">ocrSettingsId.</param>
        /// <param name="name">name.</param>
        /// <param name="runBeforeMark">runBeforeMark.</param>
        /// <param name="resultFieldName">resultFieldName.</param>
        /// <param name="sendWebhookNotification">sendWebhookNotification.</param>
        /// <param name="supportSide">supportSide.</param>
        /// <param name="ocrSettings">ocrSettings.</param>
        public JobTemplateOcrSettingsDto(int id = default(int), int jobTemplateId = default(int), int ocrSettingsId = default(int), string name = default(string), bool? runBeforeMark = default(bool?), string resultFieldName = default(string), bool sendWebhookNotification = default(bool), SupportSide? supportSide = default(SupportSide?), OcrSettingsDto ocrSettings = default(OcrSettingsDto))
        {
            this.Id = id;
            this.JobTemplateId = jobTemplateId;
            this.OcrSettingsId = ocrSettingsId;
            this.Name = name;
            this.RunBeforeMark = runBeforeMark;
            this.ResultFieldName = resultFieldName;
            this.SendWebhookNotification = sendWebhookNotification;
            this.SupportSide = supportSide;
            this.OcrSettings = ocrSettings;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets JobTemplateId
        /// </summary>
        [DataMember(Name = "jobTemplateId", EmitDefaultValue = false)]
        public int JobTemplateId { get; set; }

        /// <summary>
        /// Gets or Sets OcrSettingsId
        /// </summary>
        [DataMember(Name = "ocrSettingsId", EmitDefaultValue = false)]
        public int OcrSettingsId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets RunBeforeMark
        /// </summary>
        [DataMember(Name = "runBeforeMark", EmitDefaultValue = true)]
        public bool? RunBeforeMark { get; set; }

        /// <summary>
        /// Gets or Sets ResultFieldName
        /// </summary>
        [DataMember(Name = "resultFieldName", EmitDefaultValue = true)]
        public string ResultFieldName { get; set; }

        /// <summary>
        /// Gets or Sets SendWebhookNotification
        /// </summary>
        [DataMember(Name = "sendWebhookNotification", EmitDefaultValue = true)]
        public bool SendWebhookNotification { get; set; }

        /// <summary>
        /// Gets or Sets OcrSettings
        /// </summary>
        [DataMember(Name = "ocrSettings", EmitDefaultValue = false)]
        public OcrSettingsDto OcrSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JobTemplateOcrSettingsDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  JobTemplateId: ").Append(JobTemplateId).Append("\n");
            sb.Append("  OcrSettingsId: ").Append(OcrSettingsId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RunBeforeMark: ").Append(RunBeforeMark).Append("\n");
            sb.Append("  ResultFieldName: ").Append(ResultFieldName).Append("\n");
            sb.Append("  SendWebhookNotification: ").Append(SendWebhookNotification).Append("\n");
            sb.Append("  SupportSide: ").Append(SupportSide).Append("\n");
            sb.Append("  OcrSettings: ").Append(OcrSettings).Append("\n");
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
