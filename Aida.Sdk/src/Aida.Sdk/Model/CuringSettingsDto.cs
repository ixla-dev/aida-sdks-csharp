/*
 * aida
 *
 * 1.0.703.1
 *
 * The version of the OpenAPI document: 1.0.703.1
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
    /// CuringSettingsDto
    /// </summary>
    [DataContract(Name = "CuringSettingsDto")]
    public partial class CuringSettingsDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CuringSettingsDto" /> class.
        /// </summary>
        /// <param name="curingEnabled">curingEnabled.</param>
        /// <param name="dualCuringEnabled">dualCuringEnabled.</param>
        /// <param name="fumeExtractorEnabled">fumeExtractorEnabled.</param>
        /// <param name="level">level.</param>
        /// <param name="speed">speed.</param>
        public CuringSettingsDto(bool curingEnabled = default(bool), bool dualCuringEnabled = default(bool), bool fumeExtractorEnabled = default(bool), int level = default(int), int speed = default(int))
        {
            this.CuringEnabled = curingEnabled;
            this.DualCuringEnabled = dualCuringEnabled;
            this.FumeExtractorEnabled = fumeExtractorEnabled;
            this.Level = level;
            this.Speed = speed;
        }

        /// <summary>
        /// Gets or Sets CuringEnabled
        /// </summary>
        [DataMember(Name = "curingEnabled", EmitDefaultValue = true)]
        public bool CuringEnabled { get; set; }

        /// <summary>
        /// Gets or Sets DualCuringEnabled
        /// </summary>
        [DataMember(Name = "dualCuringEnabled", EmitDefaultValue = true)]
        public bool DualCuringEnabled { get; set; }

        /// <summary>
        /// Gets or Sets FumeExtractorEnabled
        /// </summary>
        [DataMember(Name = "fumeExtractorEnabled", EmitDefaultValue = true)]
        public bool FumeExtractorEnabled { get; set; }

        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name = "level", EmitDefaultValue = false)]
        public int Level { get; set; }

        /// <summary>
        /// Gets or Sets Speed
        /// </summary>
        [DataMember(Name = "speed", EmitDefaultValue = false)]
        public int Speed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CuringSettingsDto {\n");
            sb.Append("  CuringEnabled: ").Append(CuringEnabled).Append("\n");
            sb.Append("  DualCuringEnabled: ").Append(DualCuringEnabled).Append("\n");
            sb.Append("  FumeExtractorEnabled: ").Append(FumeExtractorEnabled).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  Speed: ").Append(Speed).Append("\n");
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
