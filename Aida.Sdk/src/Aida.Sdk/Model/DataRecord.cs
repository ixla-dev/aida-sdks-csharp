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
    /// DataRecord
    /// </summary>
    [DataContract(Name = "DataRecord")]
    public partial class DataRecord : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataRecord" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="fields">fields.</param>
        public DataRecord(int id = default(int), List<DataRecordField> fields = default(List<DataRecordField>))
        {
            this.Id = id;
            this.Fields = fields;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name = "fields", EmitDefaultValue = true)]
        public List<DataRecordField> Fields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DataRecord {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
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
