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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using FileParameter = Aida.Sdk.Mini.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Mini.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Mini.Model
{
    /// <summary>
    /// MySqlDataSourceConfigurationDto
    /// </summary>
    [DataContract(Name = "MySqlDataSourceConfigurationDto")]
    [JsonConverter(typeof(JsonSubtypes), "Discriminator")]
    public partial class MySqlDataSourceConfigurationDto : DataSourceConfigurationDto, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MySqlDataSourceConfigurationDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MySqlDataSourceConfigurationDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MySqlDataSourceConfigurationDto" /> class.
        /// </summary>
        /// <param name="tableName">tableName.</param>
        /// <param name="queryTemplate">queryTemplate.</param>
        /// <param name="connectionString">connectionString.</param>
        /// <param name="provider">provider.</param>
        /// <param name="discriminator">discriminator (required) (default to &quot;MySqlDataSourceConfigurationDto&quot;).</param>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="dataSourceType">dataSourceType.</param>
        /// <param name="canBeDeleted">canBeDeleted.</param>
        public MySqlDataSourceConfigurationDto(string tableName = default(string), string queryTemplate = default(string), string connectionString = default(string), string provider = default(string), string discriminator = @"MySqlDataSourceConfigurationDto", int? id = default(int?), string name = default(string), DataSourceType? dataSourceType = default(DataSourceType?), bool canBeDeleted = default(bool)) : base(discriminator, id, name, dataSourceType, canBeDeleted)
        {
            this.TableName = tableName;
            this.QueryTemplate = queryTemplate;
            this.ConnectionString = connectionString;
            this.Provider = provider;
        }

        /// <summary>
        /// Gets or Sets TableName
        /// </summary>
        [DataMember(Name = "tableName", EmitDefaultValue = true)]
        public string TableName { get; set; }

        /// <summary>
        /// Gets or Sets QueryTemplate
        /// </summary>
        [DataMember(Name = "queryTemplate", EmitDefaultValue = true)]
        public string QueryTemplate { get; set; }

        /// <summary>
        /// Gets or Sets ConnectionString
        /// </summary>
        [DataMember(Name = "connectionString", EmitDefaultValue = true)]
        public string ConnectionString { get; set; }

        /// <summary>
        /// Gets or Sets Provider
        /// </summary>
        [DataMember(Name = "provider", EmitDefaultValue = true)]
        public string Provider { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MySqlDataSourceConfigurationDto {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  TableName: ").Append(TableName).Append("\n");
            sb.Append("  QueryTemplate: ").Append(QueryTemplate).Append("\n");
            sb.Append("  ConnectionString: ").Append(ConnectionString).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach (var x in base.BaseValidate(validationContext))
            {
                yield return x;
            }
            yield break;
        }
    }

}
