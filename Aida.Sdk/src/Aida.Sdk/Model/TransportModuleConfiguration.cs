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
    /// TransportModuleConfiguration
    /// </summary>
    [DataContract(Name = "TransportModuleConfiguration")]
    public partial class TransportModuleConfiguration : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransportModuleConfiguration" /> class.
        /// </summary>
        /// <param name="moduleId">moduleId.</param>
        /// <param name="features">features.</param>
        public TransportModuleConfiguration(int moduleId = default(int), List<TransportFeature> features = default(List<TransportFeature>))
        {
            this.ModuleId = moduleId;
            this.Features = features;
        }

        /// <summary>
        /// Gets or Sets ModuleId
        /// </summary>
        [DataMember(Name = "moduleId", EmitDefaultValue = false)]
        public int ModuleId { get; set; }

        /// <summary>
        /// Gets or Sets Features
        /// </summary>
        [DataMember(Name = "features", EmitDefaultValue = true)]
        public List<TransportFeature> Features { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransportModuleConfiguration {\n");
            sb.Append("  ModuleId: ").Append(ModuleId).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
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
