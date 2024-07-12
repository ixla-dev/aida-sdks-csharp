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
using System.ComponentModel.DataAnnotations;
using FileParameter = Aida.Sdk.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Model
{
    /// <summary>
    /// SupportDto
    /// </summary>
    [DataContract(Name = "SupportDto")]
    public partial class SupportDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Side
        /// </summary>
        [DataMember(Name = "side", EmitDefaultValue = false)]
        public SupportSide? Side { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="side">side.</param>
        /// <param name="entranceTime">entranceTime.</param>
        public SupportDto(string id = default(string), SupportSide? side = default(SupportSide?), DateTime? entranceTime = default(DateTime?))
        {
            this.Id = id;
            this.Side = side;
            this.EntranceTime = entranceTime;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets EntranceTime
        /// </summary>
        /// <example>2019-12-10T10:06:50.466318Z</example>
        [DataMember(Name = "entranceTime", EmitDefaultValue = true)]
        public DateTime? EntranceTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SupportDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Side: ").Append(Side).Append("\n");
            sb.Append("  EntranceTime: ").Append(EntranceTime).Append("\n");
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