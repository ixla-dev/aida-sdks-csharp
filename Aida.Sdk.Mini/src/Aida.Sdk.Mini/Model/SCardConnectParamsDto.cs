/*
 * aida-mini
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
using FileParameter = Aida.Sdk.Mini.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Mini.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Mini.Model
{
    /// <summary>
    /// SCardConnectParamsDto
    /// </summary>
    [DataContract(Name = "SCardConnectParamsDto")]
    public partial class SCardConnectParamsDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Share
        /// </summary>
        [DataMember(Name = "share", EmitDefaultValue = false)]
        public SCardShare? Share { get; set; }

        /// <summary>
        /// Gets or Sets PreferredProtocol
        /// </summary>
        [DataMember(Name = "preferredProtocol", EmitDefaultValue = false)]
        public SCardProtocol? PreferredProtocol { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SCardConnectParamsDto" /> class.
        /// </summary>
        /// <param name="share">share.</param>
        /// <param name="preferredProtocol">preferredProtocol.</param>
        public SCardConnectParamsDto(SCardShare? share = default(SCardShare?), SCardProtocol? preferredProtocol = default(SCardProtocol?))
        {
            this.Share = share;
            this.PreferredProtocol = preferredProtocol;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCardConnectParamsDto {\n");
            sb.Append("  Share: ").Append(Share).Append("\n");
            sb.Append("  PreferredProtocol: ").Append(PreferredProtocol).Append("\n");
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
