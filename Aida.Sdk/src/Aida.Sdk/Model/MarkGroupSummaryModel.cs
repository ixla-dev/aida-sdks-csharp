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
    /// MarkGroupSummaryModel
    /// </summary>
    [DataContract(Name = "MarkGroupSummaryModel")]
    public partial class MarkGroupSummaryModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkGroupSummaryModel" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="layoutName">layoutName.</param>
        /// <param name="positionId">positionId.</param>
        /// <param name="scannerId">scannerId.</param>
        /// <param name="supportSide">supportSide.</param>
        /// <param name="offsetX">offsetX.</param>
        /// <param name="offsetY">offsetY.</param>
        /// <param name="mirrorX">mirrorX.</param>
        /// <param name="mirrorY">mirrorY.</param>
        /// <param name="entities">entities.</param>
        /// <param name="autoPosSettings">autoPosSettings.</param>
        public MarkGroupSummaryModel(string name = default(string), string layoutName = default(string), string positionId = default(string), string scannerId = default(string), string supportSide = default(string), double offsetX = default(double), double offsetY = default(double), bool mirrorX = default(bool), bool mirrorY = default(bool), List<string> entities = default(List<string>), List<AutoPosConfigSummaryModel> autoPosSettings = default(List<AutoPosConfigSummaryModel>))
        {
            this.Name = name;
            this.LayoutName = layoutName;
            this.PositionId = positionId;
            this.ScannerId = scannerId;
            this.SupportSide = supportSide;
            this.OffsetX = offsetX;
            this.OffsetY = offsetY;
            this.MirrorX = mirrorX;
            this.MirrorY = mirrorY;
            this.Entities = entities;
            this.AutoPosSettings = autoPosSettings;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets LayoutName
        /// </summary>
        [DataMember(Name = "layoutName", EmitDefaultValue = true)]
        public string LayoutName { get; set; }

        /// <summary>
        /// Gets or Sets PositionId
        /// </summary>
        [DataMember(Name = "positionId", EmitDefaultValue = true)]
        public string PositionId { get; set; }

        /// <summary>
        /// Gets or Sets ScannerId
        /// </summary>
        [DataMember(Name = "scannerId", EmitDefaultValue = true)]
        public string ScannerId { get; set; }

        /// <summary>
        /// Gets or Sets SupportSide
        /// </summary>
        [DataMember(Name = "supportSide", EmitDefaultValue = true)]
        public string SupportSide { get; set; }

        /// <summary>
        /// Gets or Sets OffsetX
        /// </summary>
        [DataMember(Name = "offsetX", EmitDefaultValue = false)]
        public double OffsetX { get; set; }

        /// <summary>
        /// Gets or Sets OffsetY
        /// </summary>
        [DataMember(Name = "offsetY", EmitDefaultValue = false)]
        public double OffsetY { get; set; }

        /// <summary>
        /// Gets or Sets MirrorX
        /// </summary>
        [DataMember(Name = "mirrorX", EmitDefaultValue = true)]
        public bool MirrorX { get; set; }

        /// <summary>
        /// Gets or Sets MirrorY
        /// </summary>
        [DataMember(Name = "mirrorY", EmitDefaultValue = true)]
        public bool MirrorY { get; set; }

        /// <summary>
        /// Gets or Sets Entities
        /// </summary>
        [DataMember(Name = "entities", EmitDefaultValue = true)]
        public List<string> Entities { get; set; }

        /// <summary>
        /// Gets or Sets AutoPosSettings
        /// </summary>
        [DataMember(Name = "autoPosSettings", EmitDefaultValue = true)]
        public List<AutoPosConfigSummaryModel> AutoPosSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MarkGroupSummaryModel {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LayoutName: ").Append(LayoutName).Append("\n");
            sb.Append("  PositionId: ").Append(PositionId).Append("\n");
            sb.Append("  ScannerId: ").Append(ScannerId).Append("\n");
            sb.Append("  SupportSide: ").Append(SupportSide).Append("\n");
            sb.Append("  OffsetX: ").Append(OffsetX).Append("\n");
            sb.Append("  OffsetY: ").Append(OffsetY).Append("\n");
            sb.Append("  MirrorX: ").Append(MirrorX).Append("\n");
            sb.Append("  MirrorY: ").Append(MirrorY).Append("\n");
            sb.Append("  Entities: ").Append(Entities).Append("\n");
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
