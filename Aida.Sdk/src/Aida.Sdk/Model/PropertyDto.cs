/*
 * aida
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
using FileParameter = Aida.Sdk.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Model
{
    /// <summary>
    /// PropertyDto
    /// </summary>
    [DataContract(Name = "PropertyDto")]
    public partial class PropertyDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets DevicePropertyType
        /// </summary>
        [DataMember(Name = "devicePropertyType", EmitDefaultValue = false)]
        public DevicePropertyType? DevicePropertyType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyDto" /> class.
        /// </summary>
        /// <param name="group">group.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="value">value.</param>
        /// <param name="readOnly">readOnly.</param>
        /// <param name="devicePropertyType">devicePropertyType.</param>
        public PropertyDto(string group = default(string), string name = default(string), string description = default(string), string value = default(string), bool readOnly = default(bool), DevicePropertyType? devicePropertyType = default(DevicePropertyType?))
        {
            this.Group = group;
            this.Name = name;
            this.Description = description;
            this.Value = value;
            this.ReadOnly = readOnly;
            this.DevicePropertyType = devicePropertyType;
        }

        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name = "group", EmitDefaultValue = true)]
        public string Group { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Gets or Sets ReadOnly
        /// </summary>
        [DataMember(Name = "readOnly", EmitDefaultValue = true)]
        public bool ReadOnly { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PropertyDto {\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  ReadOnly: ").Append(ReadOnly).Append("\n");
            sb.Append("  DevicePropertyType: ").Append(DevicePropertyType).Append("\n");
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
