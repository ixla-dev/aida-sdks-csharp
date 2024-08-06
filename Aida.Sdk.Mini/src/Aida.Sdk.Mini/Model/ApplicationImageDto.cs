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
    /// ApplicationImageDto
    /// </summary>
    [DataContract(Name = "ApplicationImageDto")]
    public partial class ApplicationImageDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationImageDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="file">file.</param>
        /// <param name="fileId">fileId.</param>
        /// <param name="height">height.</param>
        /// <param name="width">width.</param>
        /// <param name="horizontalResolution">horizontalResolution.</param>
        /// <param name="verticalResolution">verticalResolution.</param>
        /// <param name="imageFormat">imageFormat.</param>
        public ApplicationImageDto(int id = default(int), FileDto file = default(FileDto), int fileId = default(int), int height = default(int), int width = default(int), float horizontalResolution = default(float), float verticalResolution = default(float), string imageFormat = default(string))
        {
            this.Id = id;
            this.File = file;
            this.FileId = fileId;
            this.Height = height;
            this.Width = width;
            this.HorizontalResolution = horizontalResolution;
            this.VerticalResolution = verticalResolution;
            this.ImageFormat = imageFormat;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets File
        /// </summary>
        [DataMember(Name = "file", EmitDefaultValue = false)]
        public FileDto File { get; set; }

        /// <summary>
        /// Gets or Sets FileId
        /// </summary>
        [DataMember(Name = "fileId", EmitDefaultValue = false)]
        public int FileId { get; set; }

        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name = "height", EmitDefaultValue = false)]
        public int Height { get; set; }

        /// <summary>
        /// Gets or Sets Width
        /// </summary>
        [DataMember(Name = "width", EmitDefaultValue = false)]
        public int Width { get; set; }

        /// <summary>
        /// Gets or Sets HorizontalResolution
        /// </summary>
        [DataMember(Name = "horizontalResolution", EmitDefaultValue = false)]
        public float HorizontalResolution { get; set; }

        /// <summary>
        /// Gets or Sets VerticalResolution
        /// </summary>
        [DataMember(Name = "verticalResolution", EmitDefaultValue = false)]
        public float VerticalResolution { get; set; }

        /// <summary>
        /// Gets or Sets ImageFormat
        /// </summary>
        [DataMember(Name = "imageFormat", EmitDefaultValue = true)]
        public string ImageFormat { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; private set; }

        /// <summary>
        /// Returns false as Url should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUrl()
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
            sb.Append("class ApplicationImageDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  HorizontalResolution: ").Append(HorizontalResolution).Append("\n");
            sb.Append("  VerticalResolution: ").Append(VerticalResolution).Append("\n");
            sb.Append("  ImageFormat: ").Append(ImageFormat).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
