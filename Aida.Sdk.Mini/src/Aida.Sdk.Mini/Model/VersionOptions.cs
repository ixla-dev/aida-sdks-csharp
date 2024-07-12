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
    /// VersionOptions
    /// </summary>
    [DataContract(Name = "VersionOptions")]
    public partial class VersionOptions : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VersionOptions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public VersionOptions()
        {
        }

        /// <summary>
        /// Gets or Sets IsLatest
        /// </summary>
        [DataMember(Name = "isLatest", EmitDefaultValue = true)]
        public bool IsLatest { get; private set; }

        /// <summary>
        /// Returns false as IsLatest should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsLatest()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets IsLatestOrPublished
        /// </summary>
        [DataMember(Name = "isLatestOrPublished", EmitDefaultValue = true)]
        public bool IsLatestOrPublished { get; private set; }

        /// <summary>
        /// Returns false as IsLatestOrPublished should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsLatestOrPublished()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets IsPublished
        /// </summary>
        [DataMember(Name = "isPublished", EmitDefaultValue = true)]
        public bool IsPublished { get; private set; }

        /// <summary>
        /// Returns false as IsPublished should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsPublished()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets IsDraft
        /// </summary>
        [DataMember(Name = "isDraft", EmitDefaultValue = true)]
        public bool IsDraft { get; private set; }

        /// <summary>
        /// Returns false as IsDraft should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsDraft()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets AllVersions
        /// </summary>
        [DataMember(Name = "allVersions", EmitDefaultValue = true)]
        public bool AllVersions { get; private set; }

        /// <summary>
        /// Returns false as AllVersions should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAllVersions()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets VarVersion
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int VarVersion { get; private set; }

        /// <summary>
        /// Returns false as VarVersion should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVarVersion()
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
            sb.Append("class VersionOptions {\n");
            sb.Append("  IsLatest: ").Append(IsLatest).Append("\n");
            sb.Append("  IsLatestOrPublished: ").Append(IsLatestOrPublished).Append("\n");
            sb.Append("  IsPublished: ").Append(IsPublished).Append("\n");
            sb.Append("  IsDraft: ").Append(IsDraft).Append("\n");
            sb.Append("  AllVersions: ").Append(AllVersions).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
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
