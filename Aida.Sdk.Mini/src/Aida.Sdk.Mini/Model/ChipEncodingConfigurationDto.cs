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
    /// ChipEncodingConfigurationDto
    /// </summary>
    [DataContract(Name = "ChipEncodingConfigurationDto")]
    public partial class ChipEncodingConfigurationDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ReaderAccessType
        /// </summary>
        [DataMember(Name = "readerAccessType", EmitDefaultValue = false)]
        public ReaderAccessType? ReaderAccessType { get; set; }

        /// <summary>
        /// Gets or Sets ReaderInterfaceType
        /// </summary>
        [DataMember(Name = "readerInterfaceType", EmitDefaultValue = false)]
        public ReaderInterfaceType? ReaderInterfaceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChipEncodingConfigurationDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="readerAccessType">readerAccessType.</param>
        /// <param name="readerInterfaceType">readerInterfaceType.</param>
        public ChipEncodingConfigurationDto(int? id = default(int?), ReaderAccessType? readerAccessType = default(ReaderAccessType?), ReaderInterfaceType? readerInterfaceType = default(ReaderInterfaceType?))
        {
            this.Id = id;
            this.ReaderAccessType = readerAccessType;
            this.ReaderInterfaceType = readerInterfaceType;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public int? Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChipEncodingConfigurationDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ReaderAccessType: ").Append(ReaderAccessType).Append("\n");
            sb.Append("  ReaderInterfaceType: ").Append(ReaderInterfaceType).Append("\n");
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
