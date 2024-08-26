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
    /// BarcodeParamsDto
    /// </summary>
    [DataContract(Name = "BarcodeParamsDto")]
    public partial class BarcodeParamsDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BarcodeParamsDto" /> class.
        /// </summary>
        /// <param name="rotation">rotation.</param>
        /// <param name="roi">roi.</param>
        public BarcodeParamsDto(double? rotation = default(double?), RectangleDto roi = default(RectangleDto))
        {
            this.Rotation = rotation;
            this.Roi = roi;
        }

        /// <summary>
        /// Gets or Sets Rotation
        /// </summary>
        [DataMember(Name = "rotation", EmitDefaultValue = true)]
        public double? Rotation { get; set; }

        /// <summary>
        /// Gets or Sets Roi
        /// </summary>
        [DataMember(Name = "roi", EmitDefaultValue = false)]
        public RectangleDto Roi { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BarcodeParamsDto {\n");
            sb.Append("  Rotation: ").Append(Rotation).Append("\n");
            sb.Append("  Roi: ").Append(Roi).Append("\n");
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
