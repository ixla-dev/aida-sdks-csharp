/*
 * aida-mini
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
using FileParameter = Aida.Sdk.Mini.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Mini.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Mini.Model
{
    /// <summary>
    /// OcrSettingsDto
    /// </summary>
    [DataContract(Name = "OcrSettingsDto")]
    public partial class OcrSettingsDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets PageSegmentationMode
        /// </summary>
        [DataMember(Name = "pageSegmentationMode", EmitDefaultValue = false)]
        public PageSegmentationMode? PageSegmentationMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OcrSettingsDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="roi">roi.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="pageSegmentationMode">pageSegmentationMode.</param>
        /// <param name="whiteList">whiteList.</param>
        /// <param name="blackList">blackList.</param>
        /// <param name="languages">languages.</param>
        /// <param name="multiply">multiply.</param>
        /// <param name="threshold">threshold.</param>
        /// <param name="rotation">rotation.</param>
        /// <param name="matchPattern">matchPattern.</param>
        /// <param name="meanConfidenceThreshold">meanConfidenceThreshold.</param>
        /// <param name="imageAcquisitionPreset">imageAcquisitionPreset.</param>
        /// <param name="scannerId">scannerId.</param>
        /// <param name="cameraId">cameraId.</param>
        /// <param name="canBeDeleted">canBeDeleted.</param>
        public OcrSettingsDto(int id = default(int), string name = default(string), RectangleDto roi = default(RectangleDto), DateTime? createdAt = default(DateTime?), DateTime? updatedAt = default(DateTime?), PageSegmentationMode? pageSegmentationMode = default(PageSegmentationMode?), string whiteList = default(string), string blackList = default(string), string languages = default(string), int? multiply = default(int?), int? threshold = default(int?), double? rotation = default(double?), string matchPattern = default(string), double? meanConfidenceThreshold = default(double?), string imageAcquisitionPreset = default(string), string scannerId = default(string), string cameraId = default(string), bool canBeDeleted = default(bool))
        {
            this.Id = id;
            this.Name = name;
            this.Roi = roi;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.PageSegmentationMode = pageSegmentationMode;
            this.WhiteList = whiteList;
            this.BlackList = blackList;
            this.Languages = languages;
            this.Multiply = multiply;
            this.Threshold = threshold;
            this.Rotation = rotation;
            this.MatchPattern = matchPattern;
            this.MeanConfidenceThreshold = meanConfidenceThreshold;
            this.ImageAcquisitionPreset = imageAcquisitionPreset;
            this.ScannerId = scannerId;
            this.CameraId = cameraId;
            this.CanBeDeleted = canBeDeleted;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Roi
        /// </summary>
        [DataMember(Name = "roi", EmitDefaultValue = false)]
        public RectangleDto Roi { get; set; }

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
        /// Gets or Sets WhiteList
        /// </summary>
        [DataMember(Name = "whiteList", EmitDefaultValue = true)]
        public string WhiteList { get; set; }

        /// <summary>
        /// Gets or Sets BlackList
        /// </summary>
        [DataMember(Name = "blackList", EmitDefaultValue = true)]
        public string BlackList { get; set; }

        /// <summary>
        /// Gets or Sets Languages
        /// </summary>
        [DataMember(Name = "languages", EmitDefaultValue = true)]
        public string Languages { get; set; }

        /// <summary>
        /// Gets or Sets Multiply
        /// </summary>
        [DataMember(Name = "multiply", EmitDefaultValue = true)]
        public int? Multiply { get; set; }

        /// <summary>
        /// Gets or Sets Threshold
        /// </summary>
        [DataMember(Name = "threshold", EmitDefaultValue = true)]
        public int? Threshold { get; set; }

        /// <summary>
        /// Gets or Sets Rotation
        /// </summary>
        [DataMember(Name = "rotation", EmitDefaultValue = true)]
        public double? Rotation { get; set; }

        /// <summary>
        /// Gets or Sets MatchPattern
        /// </summary>
        [DataMember(Name = "matchPattern", EmitDefaultValue = true)]
        public string MatchPattern { get; set; }

        /// <summary>
        /// Gets or Sets MeanConfidenceThreshold
        /// </summary>
        [DataMember(Name = "meanConfidenceThreshold", EmitDefaultValue = true)]
        public double? MeanConfidenceThreshold { get; set; }

        /// <summary>
        /// Gets or Sets ImageAcquisitionPreset
        /// </summary>
        [DataMember(Name = "imageAcquisitionPreset", EmitDefaultValue = true)]
        public string ImageAcquisitionPreset { get; set; }

        /// <summary>
        /// Gets or Sets ScannerId
        /// </summary>
        [DataMember(Name = "scannerId", EmitDefaultValue = true)]
        public string ScannerId { get; set; }

        /// <summary>
        /// Gets or Sets CameraId
        /// </summary>
        [DataMember(Name = "cameraId", EmitDefaultValue = true)]
        public string CameraId { get; set; }

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
            sb.Append("class OcrSettingsDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Roi: ").Append(Roi).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  PageSegmentationMode: ").Append(PageSegmentationMode).Append("\n");
            sb.Append("  WhiteList: ").Append(WhiteList).Append("\n");
            sb.Append("  BlackList: ").Append(BlackList).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            sb.Append("  Multiply: ").Append(Multiply).Append("\n");
            sb.Append("  Threshold: ").Append(Threshold).Append("\n");
            sb.Append("  Rotation: ").Append(Rotation).Append("\n");
            sb.Append("  MatchPattern: ").Append(MatchPattern).Append("\n");
            sb.Append("  MeanConfidenceThreshold: ").Append(MeanConfidenceThreshold).Append("\n");
            sb.Append("  ImageAcquisitionPreset: ").Append(ImageAcquisitionPreset).Append("\n");
            sb.Append("  ScannerId: ").Append(ScannerId).Append("\n");
            sb.Append("  CameraId: ").Append(CameraId).Append("\n");
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
