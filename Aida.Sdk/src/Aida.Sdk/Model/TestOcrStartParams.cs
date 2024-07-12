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
    /// TestOcrStartParams
    /// </summary>
    [DataContract(Name = "TestOcrStartParams")]
    public partial class TestOcrStartParams : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestOcrStartParams" /> class.
        /// </summary>
        /// <param name="feeder">feeder.</param>
        /// <param name="repetitions">repetitions.</param>
        /// <param name="ocrId">ocrId.</param>
        /// <param name="moveBackPosition">moveBackPosition.</param>
        public TestOcrStartParams(string feeder = default(string), int repetitions = default(int), int ocrId = default(int), string moveBackPosition = default(string))
        {
            this.Feeder = feeder;
            this.Repetitions = repetitions;
            this.OcrId = ocrId;
            this.MoveBackPosition = moveBackPosition;
        }

        /// <summary>
        /// Gets or Sets Feeder
        /// </summary>
        [DataMember(Name = "feeder", EmitDefaultValue = true)]
        public string Feeder { get; set; }

        /// <summary>
        /// Gets or Sets Repetitions
        /// </summary>
        [DataMember(Name = "repetitions", EmitDefaultValue = false)]
        public int Repetitions { get; set; }

        /// <summary>
        /// Gets or Sets OcrId
        /// </summary>
        [DataMember(Name = "ocrId", EmitDefaultValue = false)]
        public int OcrId { get; set; }

        /// <summary>
        /// Gets or Sets MoveBackPosition
        /// </summary>
        [DataMember(Name = "moveBackPosition", EmitDefaultValue = true)]
        public string MoveBackPosition { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestOcrStartParams {\n");
            sb.Append("  Feeder: ").Append(Feeder).Append("\n");
            sb.Append("  Repetitions: ").Append(Repetitions).Append("\n");
            sb.Append("  OcrId: ").Append(OcrId).Append("\n");
            sb.Append("  MoveBackPosition: ").Append(MoveBackPosition).Append("\n");
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