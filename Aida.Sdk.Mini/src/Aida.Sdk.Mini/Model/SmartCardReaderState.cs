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
    /// SmartCardReaderState
    /// </summary>
    [DataContract(Name = "SmartCardReaderState")]
    public partial class SmartCardReaderState : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets CurrentState
        /// </summary>
        [DataMember(Name = "currentState", EmitDefaultValue = false)]
        public SCardReaderState? CurrentState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SmartCardReaderState" /> class.
        /// </summary>
        /// <param name="currentState">currentState.</param>
        /// <param name="readerName">readerName.</param>
        /// <param name="updateCount">updateCount.</param>
        public SmartCardReaderState(SCardReaderState? currentState = default(SCardReaderState?), string readerName = default(string), int updateCount = default(int))
        {
            this.CurrentState = currentState;
            this.ReaderName = readerName;
            this.UpdateCount = updateCount;
        }

        /// <summary>
        /// Gets or Sets ReaderName
        /// </summary>
        [DataMember(Name = "readerName", EmitDefaultValue = true)]
        public string ReaderName { get; set; }

        /// <summary>
        /// Gets or Sets UpdateCount
        /// </summary>
        [DataMember(Name = "updateCount", EmitDefaultValue = false)]
        public int UpdateCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SmartCardReaderState {\n");
            sb.Append("  CurrentState: ").Append(CurrentState).Append("\n");
            sb.Append("  ReaderName: ").Append(ReaderName).Append("\n");
            sb.Append("  UpdateCount: ").Append(UpdateCount).Append("\n");
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
