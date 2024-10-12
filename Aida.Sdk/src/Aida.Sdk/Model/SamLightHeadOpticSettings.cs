/*
 * aida
 *
 * 1.0.713
 *
 * The version of the OpenAPI document: 1.0.713
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
    /// SamLightHeadOpticSettings
    /// </summary>
    [DataContract(Name = "SamLightHeadOpticSettings")]
    public partial class SamLightHeadOpticSettings : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SamLightHeadOpticSettings" /> class.
        /// </summary>
        /// <param name="gain">gain.</param>
        /// <param name="offset">offset.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="rotation">rotation.</param>
        /// <param name="correctionFilePath">correctionFilePath.</param>
        /// <param name="axisState">axisState.</param>
        public SamLightHeadOpticSettings(Vector2d gain = default(Vector2d), Vector2d offset = default(Vector2d), bool enabled = default(bool), double rotation = default(double), string correctionFilePath = default(string), SamLightAxisState axisState = default(SamLightAxisState))
        {
            this.Gain = gain;
            this.Offset = offset;
            this.Enabled = enabled;
            this.Rotation = rotation;
            this.CorrectionFilePath = correctionFilePath;
            this.AxisState = axisState;
        }

        /// <summary>
        /// Gets or Sets Gain
        /// </summary>
        [DataMember(Name = "gain", EmitDefaultValue = false)]
        public Vector2d Gain { get; set; }

        /// <summary>
        /// Gets or Sets Offset
        /// </summary>
        [DataMember(Name = "offset", EmitDefaultValue = false)]
        public Vector2d Offset { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets Rotation
        /// </summary>
        [DataMember(Name = "rotation", EmitDefaultValue = false)]
        public double Rotation { get; set; }

        /// <summary>
        /// Gets or Sets CorrectionFilePath
        /// </summary>
        [DataMember(Name = "correctionFilePath", EmitDefaultValue = true)]
        public string CorrectionFilePath { get; set; }

        /// <summary>
        /// Gets or Sets AxisState
        /// </summary>
        [DataMember(Name = "axisState", EmitDefaultValue = false)]
        public SamLightAxisState AxisState { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SamLightHeadOpticSettings {\n");
            sb.Append("  Gain: ").Append(Gain).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Rotation: ").Append(Rotation).Append("\n");
            sb.Append("  CorrectionFilePath: ").Append(CorrectionFilePath).Append("\n");
            sb.Append("  AxisState: ").Append(AxisState).Append("\n");
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
