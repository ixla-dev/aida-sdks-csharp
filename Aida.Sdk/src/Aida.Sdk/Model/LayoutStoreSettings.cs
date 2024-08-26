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
    /// LayoutStoreSettings
    /// </summary>
    [DataContract(Name = "LayoutStoreSettings")]
    public partial class LayoutStoreSettings : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutStoreSettings" /> class.
        /// </summary>
        /// <param name="imagesBucketName">imagesBucketName.</param>
        /// <param name="uploadBucketName">uploadBucketName.</param>
        /// <param name="layoutsBucketName">layoutsBucketName.</param>
        /// <param name="jobTemplatesBucketName">jobTemplatesBucketName.</param>
        public LayoutStoreSettings(string imagesBucketName = default(string), string uploadBucketName = default(string), string layoutsBucketName = default(string), string jobTemplatesBucketName = default(string))
        {
            this.ImagesBucketName = imagesBucketName;
            this.UploadBucketName = uploadBucketName;
            this.LayoutsBucketName = layoutsBucketName;
            this.JobTemplatesBucketName = jobTemplatesBucketName;
        }

        /// <summary>
        /// Gets or Sets ImagesBucketName
        /// </summary>
        [DataMember(Name = "imagesBucketName", EmitDefaultValue = true)]
        public string ImagesBucketName { get; set; }

        /// <summary>
        /// Gets or Sets UploadBucketName
        /// </summary>
        [DataMember(Name = "uploadBucketName", EmitDefaultValue = true)]
        public string UploadBucketName { get; set; }

        /// <summary>
        /// Gets or Sets LayoutsBucketName
        /// </summary>
        [DataMember(Name = "layoutsBucketName", EmitDefaultValue = true)]
        public string LayoutsBucketName { get; set; }

        /// <summary>
        /// Gets or Sets JobTemplatesBucketName
        /// </summary>
        [DataMember(Name = "jobTemplatesBucketName", EmitDefaultValue = true)]
        public string JobTemplatesBucketName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LayoutStoreSettings {\n");
            sb.Append("  ImagesBucketName: ").Append(ImagesBucketName).Append("\n");
            sb.Append("  UploadBucketName: ").Append(UploadBucketName).Append("\n");
            sb.Append("  LayoutsBucketName: ").Append(LayoutsBucketName).Append("\n");
            sb.Append("  JobTemplatesBucketName: ").Append(JobTemplatesBucketName).Append("\n");
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
