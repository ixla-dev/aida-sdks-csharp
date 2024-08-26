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
    /// LaserBoardStateChangedEventArgs
    /// </summary>
    [DataContract(Name = "LaserBoardStateChangedEventArgs")]
    public partial class LaserBoardStateChangedEventArgs : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LaserBoardStateChangedEventArgs" /> class.
        /// </summary>
        /// <param name="currentState">currentState.</param>
        /// <param name="previousState">previousState.</param>
        public LaserBoardStateChangedEventArgs(LaserBoardState currentState = default(LaserBoardState), LaserBoardState previousState = default(LaserBoardState))
        {
            this.CurrentState = currentState;
            this.PreviousState = previousState;
        }

        /// <summary>
        /// Gets or Sets CurrentState
        /// </summary>
        [DataMember(Name = "currentState", EmitDefaultValue = false)]
        public LaserBoardState CurrentState { get; set; }

        /// <summary>
        /// Gets or Sets PreviousState
        /// </summary>
        [DataMember(Name = "previousState", EmitDefaultValue = false)]
        public LaserBoardState PreviousState { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LaserBoardStateChangedEventArgs {\n");
            sb.Append("  CurrentState: ").Append(CurrentState).Append("\n");
            sb.Append("  PreviousState: ").Append(PreviousState).Append("\n");
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
