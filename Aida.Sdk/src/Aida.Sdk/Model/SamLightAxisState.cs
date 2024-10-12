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
    /// SamLightAxisState
    /// </summary>
    [DataContract(Name = "SamLightAxisState")]
    public partial class SamLightAxisState : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SamLightAxisState" /> class.
        /// </summary>
        /// <param name="xInverted">xInverted.</param>
        /// <param name="yInverted">yInverted.</param>
        /// <param name="zInverted">zInverted.</param>
        /// <param name="xyFlipped">xyFlipped.</param>
        public SamLightAxisState(bool xInverted = default(bool), bool yInverted = default(bool), bool zInverted = default(bool), bool xyFlipped = default(bool))
        {
            this.XInverted = xInverted;
            this.YInverted = yInverted;
            this.ZInverted = zInverted;
            this.XyFlipped = xyFlipped;
        }

        /// <summary>
        /// Gets or Sets XInverted
        /// </summary>
        [DataMember(Name = "xInverted", EmitDefaultValue = true)]
        public bool XInverted { get; set; }

        /// <summary>
        /// Gets or Sets YInverted
        /// </summary>
        [DataMember(Name = "yInverted", EmitDefaultValue = true)]
        public bool YInverted { get; set; }

        /// <summary>
        /// Gets or Sets ZInverted
        /// </summary>
        [DataMember(Name = "zInverted", EmitDefaultValue = true)]
        public bool ZInverted { get; set; }

        /// <summary>
        /// Gets or Sets XyFlipped
        /// </summary>
        [DataMember(Name = "xyFlipped", EmitDefaultValue = true)]
        public bool XyFlipped { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SamLightAxisState {\n");
            sb.Append("  XInverted: ").Append(XInverted).Append("\n");
            sb.Append("  YInverted: ").Append(YInverted).Append("\n");
            sb.Append("  ZInverted: ").Append(ZInverted).Append("\n");
            sb.Append("  XyFlipped: ").Append(XyFlipped).Append("\n");
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
