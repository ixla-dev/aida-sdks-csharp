/*
 * aida
 *
 * 1.0.721-rc.9+f020d61fcb6ef6ebe31e8b3974d429a24c2e10d0
 *
 * The version of the OpenAPI document: 1.0.721-rc.9+f020d61fcb6ef6ebe31e8b3974d429a24c2e10d0
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
    /// DiagnosticActivity
    /// </summary>
    [DataContract(Name = "DiagnosticActivity")]
    public partial class DiagnosticActivity : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public DiagnosticActivityState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticActivity" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="repetition">repetition.</param>
        /// <param name="description">description.</param>
        /// <param name="errorReason">errorReason.</param>
        /// <param name="result">result.</param>
        /// <param name="state">state.</param>
        public DiagnosticActivity(int id = default(int), int repetition = default(int), string description = default(string), string errorReason = default(string), string result = default(string), DiagnosticActivityState? state = default(DiagnosticActivityState?))
        {
            this.Id = id;
            this.Repetition = repetition;
            this.Description = description;
            this.ErrorReason = errorReason;
            this.Result = result;
            this.State = state;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Repetition
        /// </summary>
        [DataMember(Name = "repetition", EmitDefaultValue = false)]
        public int Repetition { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets ErrorReason
        /// </summary>
        [DataMember(Name = "errorReason", EmitDefaultValue = true)]
        public string ErrorReason { get; set; }

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name = "result", EmitDefaultValue = true)]
        public string Result { get; set; }

        /// <summary>
        /// Gets or Sets ElapsedMilliseconds
        /// </summary>
        [DataMember(Name = "elapsedMilliseconds", EmitDefaultValue = false)]
        public long ElapsedMilliseconds { get; private set; }

        /// <summary>
        /// Returns false as ElapsedMilliseconds should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeElapsedMilliseconds()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DiagnosticActivity {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Repetition: ").Append(Repetition).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ErrorReason: ").Append(ErrorReason).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ElapsedMilliseconds: ").Append(ElapsedMilliseconds).Append("\n");
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
