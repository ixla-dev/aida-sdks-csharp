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
    /// PcScManagerConfiguration
    /// </summary>
    [DataContract(Name = "PcScManagerConfiguration")]
    public partial class PcScManagerConfiguration : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets DefaultScope
        /// </summary>
        [DataMember(Name = "defaultScope", EmitDefaultValue = false)]
        public SCardScope? DefaultScope { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PcScManagerConfiguration" /> class.
        /// </summary>
        /// <param name="defaultScope">defaultScope.</param>
        /// <param name="tracePcScCalls">tracePcScCalls.</param>
        /// <param name="logSensitiveData">logSensitiveData.</param>
        public PcScManagerConfiguration(SCardScope? defaultScope = default(SCardScope?), bool tracePcScCalls = default(bool), bool logSensitiveData = default(bool))
        {
            this.DefaultScope = defaultScope;
            this.TracePcScCalls = tracePcScCalls;
            this.LogSensitiveData = logSensitiveData;
        }

        /// <summary>
        /// Gets or Sets TracePcScCalls
        /// </summary>
        [DataMember(Name = "tracePcScCalls", EmitDefaultValue = true)]
        public bool TracePcScCalls { get; set; }

        /// <summary>
        /// Gets or Sets LogSensitiveData
        /// </summary>
        [DataMember(Name = "logSensitiveData", EmitDefaultValue = true)]
        public bool LogSensitiveData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PcScManagerConfiguration {\n");
            sb.Append("  DefaultScope: ").Append(DefaultScope).Append("\n");
            sb.Append("  TracePcScCalls: ").Append(TracePcScCalls).Append("\n");
            sb.Append("  LogSensitiveData: ").Append(LogSensitiveData).Append("\n");
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
