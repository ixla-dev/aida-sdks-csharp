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
    /// TestAutoposStartParams
    /// </summary>
    [DataContract(Name = "TestAutoposStartParams")]
    public partial class TestAutoposStartParams : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestAutoposStartParams" /> class.
        /// </summary>
        /// <param name="feeder">feeder.</param>
        /// <param name="repetitions">repetitions.</param>
        /// <param name="autoposId">autoposId.</param>
        /// <param name="moveBackPosition">moveBackPosition.</param>
        public TestAutoposStartParams(string feeder = default(string), int repetitions = default(int), int autoposId = default(int), string moveBackPosition = default(string))
        {
            this.Feeder = feeder;
            this.Repetitions = repetitions;
            this.AutoposId = autoposId;
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
        /// Gets or Sets AutoposId
        /// </summary>
        [DataMember(Name = "autoposId", EmitDefaultValue = false)]
        public int AutoposId { get; set; }

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
            sb.Append("class TestAutoposStartParams {\n");
            sb.Append("  Feeder: ").Append(Feeder).Append("\n");
            sb.Append("  Repetitions: ").Append(Repetitions).Append("\n");
            sb.Append("  AutoposId: ").Append(AutoposId).Append("\n");
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
