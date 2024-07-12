/*
 * aida-mini
 *
 * 1.0.700.1
 *
 * The version of the OpenAPI document: 1.0.700.1
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
    /// DataExchangeTableDefinition
    /// </summary>
    [DataContract(Name = "DataExchangeTableDefinition")]
    public partial class DataExchangeTableDefinition : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataExchangeTableDefinition" /> class.
        /// </summary>
        /// <param name="sql">sql.</param>
        /// <param name="tableName">tableName.</param>
        public DataExchangeTableDefinition(string sql = default(string), string tableName = default(string))
        {
            this.Sql = sql;
            this.TableName = tableName;
        }

        /// <summary>
        /// Gets or Sets Sql
        /// </summary>
        [DataMember(Name = "sql", EmitDefaultValue = true)]
        public string Sql { get; set; }

        /// <summary>
        /// Gets or Sets TableName
        /// </summary>
        [DataMember(Name = "tableName", EmitDefaultValue = true)]
        public string TableName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DataExchangeTableDefinition {\n");
            sb.Append("  Sql: ").Append(Sql).Append("\n");
            sb.Append("  TableName: ").Append(TableName).Append("\n");
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