/*
 * aida-mini
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
using FileParameter = Aida.Sdk.Mini.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Mini.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Mini.Model
{
    /// <summary>
    /// SCardReconnectParamsDto
    /// </summary>
    [DataContract(Name = "SCardReconnectParamsDto")]
    public partial class SCardReconnectParamsDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Initialization
        /// </summary>
        [DataMember(Name = "initialization", EmitDefaultValue = false)]
        public SCardInitialization? Initialization { get; set; }

        /// <summary>
        /// Gets or Sets Share
        /// </summary>
        [DataMember(Name = "share", EmitDefaultValue = false)]
        public SCardShare? Share { get; set; }

        /// <summary>
        /// Gets or Sets PreferredProtocols
        /// </summary>
        [DataMember(Name = "preferredProtocols", EmitDefaultValue = false)]
        public SCardProtocol? PreferredProtocols { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SCardReconnectParamsDto" /> class.
        /// </summary>
        /// <param name="initialization">initialization.</param>
        /// <param name="share">share.</param>
        /// <param name="preferredProtocols">preferredProtocols.</param>
        public SCardReconnectParamsDto(SCardInitialization? initialization = default(SCardInitialization?), SCardShare? share = default(SCardShare?), SCardProtocol? preferredProtocols = default(SCardProtocol?))
        {
            this.Initialization = initialization;
            this.Share = share;
            this.PreferredProtocols = preferredProtocols;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCardReconnectParamsDto {\n");
            sb.Append("  Initialization: ").Append(Initialization).Append("\n");
            sb.Append("  Share: ").Append(Share).Append("\n");
            sb.Append("  PreferredProtocols: ").Append(PreferredProtocols).Append("\n");
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
