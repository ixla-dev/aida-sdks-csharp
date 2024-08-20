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
    /// ScannerAppStateDto
    /// </summary>
    [DataContract(Name = "ScannerAppStateDto")]
    public partial class ScannerAppStateDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScannerAppStateDto" /> class.
        /// </summary>
        /// <param name="entityCount">entityCount.</param>
        /// <param name="isMarking">isMarking.</param>
        /// <param name="isConnected">isConnected.</param>
        /// <param name="penSet">penSet.</param>
        /// <param name="currentJob">currentJob.</param>
        public ScannerAppStateDto(int entityCount = default(int), bool isMarking = default(bool), bool isConnected = default(bool), List<PenDto> penSet = default(List<PenDto>), JobTemplateDto currentJob = default(JobTemplateDto))
        {
            this.EntityCount = entityCount;
            this.IsMarking = isMarking;
            this.IsConnected = isConnected;
            this.PenSet = penSet;
            this.CurrentJob = currentJob;
        }

        /// <summary>
        /// Gets or Sets EntityCount
        /// </summary>
        [DataMember(Name = "entityCount", EmitDefaultValue = false)]
        public int EntityCount { get; set; }

        /// <summary>
        /// Gets or Sets IsMarking
        /// </summary>
        [DataMember(Name = "isMarking", EmitDefaultValue = true)]
        public bool IsMarking { get; set; }

        /// <summary>
        /// Gets or Sets IsConnected
        /// </summary>
        [DataMember(Name = "isConnected", EmitDefaultValue = true)]
        public bool IsConnected { get; set; }

        /// <summary>
        /// Gets or Sets PenSet
        /// </summary>
        [DataMember(Name = "penSet", EmitDefaultValue = true)]
        public List<PenDto> PenSet { get; set; }

        /// <summary>
        /// Gets or Sets CurrentJob
        /// </summary>
        [DataMember(Name = "currentJob", EmitDefaultValue = false)]
        public JobTemplateDto CurrentJob { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScannerAppStateDto {\n");
            sb.Append("  EntityCount: ").Append(EntityCount).Append("\n");
            sb.Append("  IsMarking: ").Append(IsMarking).Append("\n");
            sb.Append("  IsConnected: ").Append(IsConnected).Append("\n");
            sb.Append("  PenSet: ").Append(PenSet).Append("\n");
            sb.Append("  CurrentJob: ").Append(CurrentJob).Append("\n");
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
