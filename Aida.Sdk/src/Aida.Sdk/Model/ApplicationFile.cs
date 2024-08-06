/*
 * aida
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
using FileParameter = Aida.Sdk.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Model
{
    /// <summary>
    /// ApplicationFile
    /// </summary>
    [DataContract(Name = "ApplicationFile")]
    public partial class ApplicationFile : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationFile" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="filename">filename.</param>
        /// <param name="originalFilename">originalFilename.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="size">size.</param>
        /// <param name="location">location.</param>
        /// <param name="checksum">checksum.</param>
        /// <param name="extension">extension.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="fileBucketId">fileBucketId.</param>
        public ApplicationFile(int id = default(int), string filename = default(string), string originalFilename = default(string), string displayName = default(string), long size = default(long), string location = default(string), string checksum = default(string), string extension = default(string), DateTime? createdAt = default(DateTime?), DateTime? updatedAt = default(DateTime?), int fileBucketId = default(int))
        {
            this.Id = id;
            this.Filename = filename;
            this.OriginalFilename = originalFilename;
            this.DisplayName = displayName;
            this.Size = size;
            this.Location = location;
            this.Checksum = checksum;
            this.Extension = extension;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.FileBucketId = fileBucketId;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Filename
        /// </summary>
        [DataMember(Name = "filename", EmitDefaultValue = true)]
        public string Filename { get; set; }

        /// <summary>
        /// Gets or Sets OriginalFilename
        /// </summary>
        [DataMember(Name = "originalFilename", EmitDefaultValue = true)]
        public string OriginalFilename { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public long Size { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name = "location", EmitDefaultValue = true)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets Checksum
        /// </summary>
        [DataMember(Name = "checksum", EmitDefaultValue = true)]
        public string Checksum { get; set; }

        /// <summary>
        /// Gets or Sets Extension
        /// </summary>
        [DataMember(Name = "extension", EmitDefaultValue = true)]
        public string Extension { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", EmitDefaultValue = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets FileBucketId
        /// </summary>
        [DataMember(Name = "fileBucketId", EmitDefaultValue = false)]
        public int FileBucketId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApplicationFile {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Filename: ").Append(Filename).Append("\n");
            sb.Append("  OriginalFilename: ").Append(OriginalFilename).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Checksum: ").Append(Checksum).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  FileBucketId: ").Append(FileBucketId).Append("\n");
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
            // Filename (string) maxLength
            if (this.Filename != null && this.Filename.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Filename, length must be less than 255.", new [] { "Filename" });
            }

            // OriginalFilename (string) maxLength
            if (this.OriginalFilename != null && this.OriginalFilename.Length > 255)
            {
                yield return new ValidationResult("Invalid value for OriginalFilename, length must be less than 255.", new [] { "OriginalFilename" });
            }

            // DisplayName (string) maxLength
            if (this.DisplayName != null && this.DisplayName.Length > 255)
            {
                yield return new ValidationResult("Invalid value for DisplayName, length must be less than 255.", new [] { "DisplayName" });
            }

            // Location (string) maxLength
            if (this.Location != null && this.Location.Length > 500)
            {
                yield return new ValidationResult("Invalid value for Location, length must be less than 500.", new [] { "Location" });
            }

            // Checksum (string) maxLength
            if (this.Checksum != null && this.Checksum.Length > 32)
            {
                yield return new ValidationResult("Invalid value for Checksum, length must be less than 32.", new [] { "Checksum" });
            }

            // Extension (string) maxLength
            if (this.Extension != null && this.Extension.Length > 10)
            {
                yield return new ValidationResult("Invalid value for Extension, length must be less than 10.", new [] { "Extension" });
            }

            yield break;
        }
    }

}
