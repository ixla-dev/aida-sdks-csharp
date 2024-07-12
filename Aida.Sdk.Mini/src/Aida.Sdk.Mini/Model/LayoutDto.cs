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
    /// LayoutDto
    /// </summary>
    [DataContract(Name = "LayoutDto")]
    public partial class LayoutDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="file">file.</param>
        /// <param name="entities">entities.</param>
        /// <param name="autoPosSettings">autoPosSettings.</param>
        /// <param name="canBeDeleted">canBeDeleted.</param>
        public LayoutDto(int? id = default(int?), string name = default(string), DateTime? createdAt = default(DateTime?), DateTime? updatedAt = default(DateTime?), FileDto file = default(FileDto), List<ScannerEntityDto> entities = default(List<ScannerEntityDto>), List<JobTemplateLayoutAutoPosSettingsDto> autoPosSettings = default(List<JobTemplateLayoutAutoPosSettingsDto>), bool canBeDeleted = default(bool))
        {
            this.Id = id;
            this.Name = name;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.File = file;
            this.Entities = entities;
            this.AutoPosSettings = autoPosSettings;
            this.CanBeDeleted = canBeDeleted;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

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
        /// Gets or Sets File
        /// </summary>
        [DataMember(Name = "file", EmitDefaultValue = false)]
        public FileDto File { get; set; }

        /// <summary>
        /// Gets or Sets Entities
        /// </summary>
        [DataMember(Name = "entities", EmitDefaultValue = true)]
        public List<ScannerEntityDto> Entities { get; set; }

        /// <summary>
        /// Gets or Sets AutoPosSettings
        /// </summary>
        [DataMember(Name = "autoPosSettings", EmitDefaultValue = true)]
        public List<JobTemplateLayoutAutoPosSettingsDto> AutoPosSettings { get; set; }

        /// <summary>
        /// Gets or Sets CanBeDeleted
        /// </summary>
        [DataMember(Name = "canBeDeleted", EmitDefaultValue = true)]
        public bool CanBeDeleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LayoutDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  Entities: ").Append(Entities).Append("\n");
            sb.Append("  AutoPosSettings: ").Append(AutoPosSettings).Append("\n");
            sb.Append("  CanBeDeleted: ").Append(CanBeDeleted).Append("\n");
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
