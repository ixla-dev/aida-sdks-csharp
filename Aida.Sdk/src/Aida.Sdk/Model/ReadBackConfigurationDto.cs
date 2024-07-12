/*
 * aida
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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using FileParameter = Aida.Sdk.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Model
{
    /// <summary>
    /// ReadBackConfigurationDto
    /// </summary>
    [DataContract(Name = "ReadBackConfigurationDto")]
    [JsonConverter(typeof(JsonSubtypes), "Discriminator")]
    [JsonSubtypes.KnownSubType(typeof(ChipReadBackConfigurationDto), "IXLA.Box.Automapper.ChipReadBackConfigurationDto")]
    [JsonSubtypes.KnownSubType(typeof(MagneticReadBackConfigurationDto), "IXLA.Box.Automapper.MagneticReadBackConfigurationDto")]
    [JsonSubtypes.KnownSubType(typeof(OcrReadBackConfigurationDto), "IXLA.Box.Automapper.OcrReadBackConfigurationDto")]
    public partial class ReadBackConfigurationDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ReadBackType
        /// </summary>
        [DataMember(Name = "readBackType", EmitDefaultValue = false)]
        public ReadBackType? ReadBackType { get; set; }

        /// <summary>
        /// Gets or Sets RequiredSide
        /// </summary>
        [DataMember(Name = "requiredSide", EmitDefaultValue = false)]
        public SupportSide? RequiredSide { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadBackConfigurationDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReadBackConfigurationDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadBackConfigurationDto" /> class.
        /// </summary>
        /// <param name="discriminator">discriminator (required).</param>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="readBackType">readBackType.</param>
        /// <param name="requiredSide">requiredSide.</param>
        /// <param name="jobTemplateId">jobTemplateId.</param>
        public ReadBackConfigurationDto(string discriminator = default(string), int id = default(int), string name = default(string), ReadBackType? readBackType = default(ReadBackType?), SupportSide? requiredSide = default(SupportSide?), int jobTemplateId = default(int))
        {
            // to ensure "discriminator" is required (not null)
            if (discriminator == null)
            {
                throw new ArgumentNullException("discriminator is a required property for ReadBackConfigurationDto and cannot be null");
            }
            this.Discriminator = discriminator;
            this.Id = id;
            this.Name = name;
            this.ReadBackType = readBackType;
            this.RequiredSide = requiredSide;
            this.JobTemplateId = jobTemplateId;
        }

        /// <summary>
        /// Gets or Sets Discriminator
        /// </summary>
        [DataMember(Name = "discriminator", IsRequired = true, EmitDefaultValue = true)]
        public string Discriminator { get; set; }

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
        /// Gets or Sets JobTemplateId
        /// </summary>
        [DataMember(Name = "jobTemplateId", EmitDefaultValue = false)]
        public int JobTemplateId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReadBackConfigurationDto {\n");
            sb.Append("  Discriminator: ").Append(Discriminator).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ReadBackType: ").Append(ReadBackType).Append("\n");
            sb.Append("  RequiredSide: ").Append(RequiredSide).Append("\n");
            sb.Append("  JobTemplateId: ").Append(JobTemplateId).Append("\n");
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
