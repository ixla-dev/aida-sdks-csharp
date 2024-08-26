/*
 * aida
 *
 * 1.0.703.4
 *
 * The version of the OpenAPI document: 1.0.703.4
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
    /// ScannerEntityDto
    /// </summary>
    [DataContract(Name = "ScannerEntityDto")]
    public partial class ScannerEntityDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public EntityType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScannerEntityDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="penId">penId.</param>
        /// <param name="markLoopCount">markLoopCount.</param>
        /// <param name="markFlags">markFlags.</param>
        /// <param name="name">name.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="prefix">prefix.</param>
        /// <param name="type">type.</param>
        /// <param name="userData">userData.</param>
        /// <param name="layoutId">layoutId.</param>
        /// <param name="layoutName">layoutName.</param>
        /// <param name="rotationAngle">rotationAngle.</param>
        /// <param name="expectedMarkDuration">expectedMarkDuration.</param>
        /// <param name="outline">outline.</param>
        /// <param name="text">text.</param>
        /// <param name="fontName">fontName.</param>
        /// <param name="textSize">textSize.</param>
        /// <param name="textOrientation">textOrientation.</param>
        /// <param name="charSpacing">charSpacing.</param>
        /// <param name="textBaseline">textBaseline.</param>
        /// <param name="textHeightLimit">textHeightLimit.</param>
        /// <param name="textLengthLimit">textLengthLimit.</param>
        /// <param name="textRadius">textRadius.</param>
        /// <param name="textStartAngle">textStartAngle.</param>
        /// <param name="bitmapModeFlags">bitmapModeFlags.</param>
        /// <param name="imageIntensity">imageIntensity.</param>
        /// <param name="imageBrightness">imageBrightness.</param>
        /// <param name="imageDitherStep">imageDitherStep.</param>
        /// <param name="hatchPairs">hatchPairs.</param>
        public ScannerEntityDto(int? id = default(int?), int? penId = default(int?), int? markLoopCount = default(int?), ScannerEntityMarkFlagsDto markFlags = default(ScannerEntityMarkFlagsDto), string name = default(string), string displayName = default(string), string prefix = default(string), EntityType? type = default(EntityType?), int? userData = default(int?), int? layoutId = default(int?), string layoutName = default(string), double? rotationAngle = default(double?), string expectedMarkDuration = default(string), DRectangleDto outline = default(DRectangleDto), string text = default(string), string fontName = default(string), double? textSize = default(double?), double? textOrientation = default(double?), double? charSpacing = default(double?), double? textBaseline = default(double?), double? textHeightLimit = default(double?), double? textLengthLimit = default(double?), double? textRadius = default(double?), double? textStartAngle = default(double?), ScannerEntityBitmapModeFlags bitmapModeFlags = default(ScannerEntityBitmapModeFlags), double? imageIntensity = default(double?), double? imageBrightness = default(double?), double? imageDitherStep = default(double?), List<HatchPairDto> hatchPairs = default(List<HatchPairDto>))
        {
            this.Id = id;
            this.PenId = penId;
            this.MarkLoopCount = markLoopCount;
            this.MarkFlags = markFlags;
            this.Name = name;
            this.DisplayName = displayName;
            this.Prefix = prefix;
            this.Type = type;
            this.UserData = userData;
            this.LayoutId = layoutId;
            this.LayoutName = layoutName;
            this.RotationAngle = rotationAngle;
            this.ExpectedMarkDuration = expectedMarkDuration;
            this.Outline = outline;
            this.Text = text;
            this.FontName = fontName;
            this.TextSize = textSize;
            this.TextOrientation = textOrientation;
            this.CharSpacing = charSpacing;
            this.TextBaseline = textBaseline;
            this.TextHeightLimit = textHeightLimit;
            this.TextLengthLimit = textLengthLimit;
            this.TextRadius = textRadius;
            this.TextStartAngle = textStartAngle;
            this.BitmapModeFlags = bitmapModeFlags;
            this.ImageIntensity = imageIntensity;
            this.ImageBrightness = imageBrightness;
            this.ImageDitherStep = imageDitherStep;
            this.HatchPairs = hatchPairs;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets PenId
        /// </summary>
        [DataMember(Name = "penId", EmitDefaultValue = true)]
        public int? PenId { get; set; }

        /// <summary>
        /// Gets or Sets MarkLoopCount
        /// </summary>
        [DataMember(Name = "markLoopCount", EmitDefaultValue = true)]
        public int? MarkLoopCount { get; set; }

        /// <summary>
        /// Gets or Sets MarkFlags
        /// </summary>
        [DataMember(Name = "markFlags", EmitDefaultValue = false)]
        public ScannerEntityMarkFlagsDto MarkFlags { get; set; }

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
        /// Gets or Sets Prefix
        /// </summary>
        [DataMember(Name = "prefix", EmitDefaultValue = true)]
        public string Prefix { get; set; }

        /// <summary>
        /// Gets or Sets UserData
        /// </summary>
        [DataMember(Name = "userData", EmitDefaultValue = true)]
        public int? UserData { get; set; }

        /// <summary>
        /// Gets or Sets LayoutId
        /// </summary>
        [DataMember(Name = "layoutId", EmitDefaultValue = true)]
        public int? LayoutId { get; set; }

        /// <summary>
        /// Gets or Sets LayoutName
        /// </summary>
        [DataMember(Name = "layoutName", EmitDefaultValue = true)]
        public string LayoutName { get; set; }

        /// <summary>
        /// Gets or Sets RotationAngle
        /// </summary>
        [DataMember(Name = "rotationAngle", EmitDefaultValue = true)]
        public double? RotationAngle { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedMarkDuration
        /// </summary>
        /// <example>25:01:01.001</example>
        [DataMember(Name = "expectedMarkDuration", EmitDefaultValue = false)]
        public string ExpectedMarkDuration { get; set; }

        /// <summary>
        /// Gets or Sets Outline
        /// </summary>
        [DataMember(Name = "outline", EmitDefaultValue = false)]
        public DRectangleDto Outline { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name = "text", EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets FontName
        /// </summary>
        [DataMember(Name = "fontName", EmitDefaultValue = true)]
        public string FontName { get; set; }

        /// <summary>
        /// Gets or Sets TextSize
        /// </summary>
        [DataMember(Name = "textSize", EmitDefaultValue = true)]
        public double? TextSize { get; set; }

        /// <summary>
        /// Gets or Sets TextOrientation
        /// </summary>
        [DataMember(Name = "textOrientation", EmitDefaultValue = true)]
        public double? TextOrientation { get; set; }

        /// <summary>
        /// Gets or Sets CharSpacing
        /// </summary>
        [DataMember(Name = "charSpacing", EmitDefaultValue = true)]
        public double? CharSpacing { get; set; }

        /// <summary>
        /// Gets or Sets TextBaseline
        /// </summary>
        [DataMember(Name = "textBaseline", EmitDefaultValue = true)]
        public double? TextBaseline { get; set; }

        /// <summary>
        /// Gets or Sets TextHeightLimit
        /// </summary>
        [DataMember(Name = "textHeightLimit", EmitDefaultValue = true)]
        public double? TextHeightLimit { get; set; }

        /// <summary>
        /// Gets or Sets TextLengthLimit
        /// </summary>
        [DataMember(Name = "textLengthLimit", EmitDefaultValue = true)]
        public double? TextLengthLimit { get; set; }

        /// <summary>
        /// Gets or Sets TextRadius
        /// </summary>
        [DataMember(Name = "textRadius", EmitDefaultValue = true)]
        public double? TextRadius { get; set; }

        /// <summary>
        /// Gets or Sets TextStartAngle
        /// </summary>
        [DataMember(Name = "textStartAngle", EmitDefaultValue = true)]
        public double? TextStartAngle { get; set; }

        /// <summary>
        /// Gets or Sets BitmapModeFlags
        /// </summary>
        [DataMember(Name = "bitmapModeFlags", EmitDefaultValue = false)]
        public ScannerEntityBitmapModeFlags BitmapModeFlags { get; set; }

        /// <summary>
        /// Gets or Sets ImageIntensity
        /// </summary>
        [DataMember(Name = "imageIntensity", EmitDefaultValue = true)]
        public double? ImageIntensity { get; set; }

        /// <summary>
        /// Gets or Sets ImageBrightness
        /// </summary>
        [DataMember(Name = "imageBrightness", EmitDefaultValue = true)]
        public double? ImageBrightness { get; set; }

        /// <summary>
        /// Gets or Sets ImageDitherStep
        /// </summary>
        [DataMember(Name = "imageDitherStep", EmitDefaultValue = true)]
        public double? ImageDitherStep { get; set; }

        /// <summary>
        /// Gets or Sets HatchPairs
        /// </summary>
        [DataMember(Name = "hatchPairs", EmitDefaultValue = true)]
        public List<HatchPairDto> HatchPairs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScannerEntityDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PenId: ").Append(PenId).Append("\n");
            sb.Append("  MarkLoopCount: ").Append(MarkLoopCount).Append("\n");
            sb.Append("  MarkFlags: ").Append(MarkFlags).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Prefix: ").Append(Prefix).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UserData: ").Append(UserData).Append("\n");
            sb.Append("  LayoutId: ").Append(LayoutId).Append("\n");
            sb.Append("  LayoutName: ").Append(LayoutName).Append("\n");
            sb.Append("  RotationAngle: ").Append(RotationAngle).Append("\n");
            sb.Append("  ExpectedMarkDuration: ").Append(ExpectedMarkDuration).Append("\n");
            sb.Append("  Outline: ").Append(Outline).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  FontName: ").Append(FontName).Append("\n");
            sb.Append("  TextSize: ").Append(TextSize).Append("\n");
            sb.Append("  TextOrientation: ").Append(TextOrientation).Append("\n");
            sb.Append("  CharSpacing: ").Append(CharSpacing).Append("\n");
            sb.Append("  TextBaseline: ").Append(TextBaseline).Append("\n");
            sb.Append("  TextHeightLimit: ").Append(TextHeightLimit).Append("\n");
            sb.Append("  TextLengthLimit: ").Append(TextLengthLimit).Append("\n");
            sb.Append("  TextRadius: ").Append(TextRadius).Append("\n");
            sb.Append("  TextStartAngle: ").Append(TextStartAngle).Append("\n");
            sb.Append("  BitmapModeFlags: ").Append(BitmapModeFlags).Append("\n");
            sb.Append("  ImageIntensity: ").Append(ImageIntensity).Append("\n");
            sb.Append("  ImageBrightness: ").Append(ImageBrightness).Append("\n");
            sb.Append("  ImageDitherStep: ").Append(ImageDitherStep).Append("\n");
            sb.Append("  HatchPairs: ").Append(HatchPairs).Append("\n");
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
