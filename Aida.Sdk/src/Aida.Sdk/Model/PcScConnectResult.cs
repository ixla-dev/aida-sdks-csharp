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
    /// PcScConnectResult
    /// </summary>
    [DataContract(Name = "PcScConnectResult")]
    public partial class PcScConnectResult : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name = "errorCode", EmitDefaultValue = false)]
        public PcScErrorCode? ErrorCode { get; set; }

        /// <summary>
        /// Gets or Sets ActiveSCardProtocol
        /// </summary>
        [DataMember(Name = "activeSCardProtocol", EmitDefaultValue = false)]
        public SCardProtocol? ActiveSCardProtocol { get; set; }

        /// <summary>
        /// Gets or Sets Share
        /// </summary>
        [DataMember(Name = "share", EmitDefaultValue = false)]
        public SCardShare? Share { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PcScConnectResult" /> class.
        /// </summary>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="success">success.</param>
        /// <param name="readerName">readerName.</param>
        /// <param name="activeSCardProtocol">activeSCardProtocol.</param>
        /// <param name="share">share.</param>
        public PcScConnectResult(PcScErrorCode? errorCode = default(PcScErrorCode?), bool success = default(bool), string readerName = default(string), SCardProtocol? activeSCardProtocol = default(SCardProtocol?), SCardShare? share = default(SCardShare?))
        {
            this.ErrorCode = errorCode;
            this.Success = success;
            this.ReaderName = readerName;
            this.ActiveSCardProtocol = activeSCardProtocol;
            this.Share = share;
        }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name = "success", EmitDefaultValue = true)]
        public bool Success { get; set; }

        /// <summary>
        /// Gets or Sets ReaderName
        /// </summary>
        [DataMember(Name = "readerName", EmitDefaultValue = true)]
        public string ReaderName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PcScConnectResult {\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  ReaderName: ").Append(ReaderName).Append("\n");
            sb.Append("  ActiveSCardProtocol: ").Append(ActiveSCardProtocol).Append("\n");
            sb.Append("  Share: ").Append(Share).Append("\n");
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
