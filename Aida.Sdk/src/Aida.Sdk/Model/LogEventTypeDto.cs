/*
 * aida
 *
 * 1.0.703.2
 *
 * The version of the OpenAPI document: 1.0.703.2
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
    /// LogEventTypeDto
    /// </summary>
    [DataContract(Name = "LogEventTypeDto")]
    public partial class LogEventTypeDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogEventTypeDto" /> class.
        /// </summary>
        /// <param name="eventType">eventType.</param>
        /// <param name="messageTemplate">messageTemplate.</param>
        public LogEventTypeDto(string eventType = default(string), string messageTemplate = default(string))
        {
            this.EventType = eventType;
            this.MessageTemplate = messageTemplate;
        }

        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name = "eventType", EmitDefaultValue = true)]
        public string EventType { get; set; }

        /// <summary>
        /// Gets or Sets MessageTemplate
        /// </summary>
        [DataMember(Name = "messageTemplate", EmitDefaultValue = true)]
        public string MessageTemplate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LogEventTypeDto {\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  MessageTemplate: ").Append(MessageTemplate).Append("\n");
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
