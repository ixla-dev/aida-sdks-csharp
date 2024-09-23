/*
 * aida
 *
 * 1.0.704.0
 *
 * The version of the OpenAPI document: 1.0.704.0
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
using FileParameter = Aida.Sdk.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Client.OpenAPIDateConverter;
using System.Reflection;

namespace Aida.Sdk.Model
{
    /// <summary>
    /// AddDataSourceConfiguration200Response
    /// </summary>
    [JsonConverter(typeof(AddDataSourceConfiguration200ResponseJsonConverter))]
    [DataContract(Name = "AddDataSourceConfiguration_200_response")]
    public partial class AddDataSourceConfiguration200Response : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddDataSourceConfiguration200Response" /> class
        /// with the <see cref="MySqlDataSourceConfigurationDto" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of MySqlDataSourceConfigurationDto.</param>
        public AddDataSourceConfiguration200Response(MySqlDataSourceConfigurationDto actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddDataSourceConfiguration200Response" /> class
        /// with the <see cref="NpgSqlDataSourceConfigurationDto" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NpgSqlDataSourceConfigurationDto.</param>
        public AddDataSourceConfiguration200Response(NpgSqlDataSourceConfigurationDto actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(MySqlDataSourceConfigurationDto) || value is MySqlDataSourceConfigurationDto)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(NpgSqlDataSourceConfigurationDto) || value is NpgSqlDataSourceConfigurationDto)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: MySqlDataSourceConfigurationDto, NpgSqlDataSourceConfigurationDto");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `MySqlDataSourceConfigurationDto`. If the actual instance is not `MySqlDataSourceConfigurationDto`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of MySqlDataSourceConfigurationDto</returns>
        public MySqlDataSourceConfigurationDto GetMySqlDataSourceConfigurationDto()
        {
            return (MySqlDataSourceConfigurationDto)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `NpgSqlDataSourceConfigurationDto`. If the actual instance is not `NpgSqlDataSourceConfigurationDto`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of NpgSqlDataSourceConfigurationDto</returns>
        public NpgSqlDataSourceConfigurationDto GetNpgSqlDataSourceConfigurationDto()
        {
            return (NpgSqlDataSourceConfigurationDto)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddDataSourceConfiguration200Response {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, AddDataSourceConfiguration200Response.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of AddDataSourceConfiguration200Response
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of AddDataSourceConfiguration200Response</returns>
        public static AddDataSourceConfiguration200Response FromJson(string jsonString)
        {
            AddDataSourceConfiguration200Response newAddDataSourceConfiguration200Response = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newAddDataSourceConfiguration200Response;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(MySqlDataSourceConfigurationDto).GetProperty("AdditionalProperties") == null)
                {
                    newAddDataSourceConfiguration200Response = new AddDataSourceConfiguration200Response(JsonConvert.DeserializeObject<MySqlDataSourceConfigurationDto>(jsonString, AddDataSourceConfiguration200Response.SerializerSettings));
                }
                else
                {
                    newAddDataSourceConfiguration200Response = new AddDataSourceConfiguration200Response(JsonConvert.DeserializeObject<MySqlDataSourceConfigurationDto>(jsonString, AddDataSourceConfiguration200Response.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("MySqlDataSourceConfigurationDto");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into MySqlDataSourceConfigurationDto: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NpgSqlDataSourceConfigurationDto).GetProperty("AdditionalProperties") == null)
                {
                    newAddDataSourceConfiguration200Response = new AddDataSourceConfiguration200Response(JsonConvert.DeserializeObject<NpgSqlDataSourceConfigurationDto>(jsonString, AddDataSourceConfiguration200Response.SerializerSettings));
                }
                else
                {
                    newAddDataSourceConfiguration200Response = new AddDataSourceConfiguration200Response(JsonConvert.DeserializeObject<NpgSqlDataSourceConfigurationDto>(jsonString, AddDataSourceConfiguration200Response.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("NpgSqlDataSourceConfigurationDto");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NpgSqlDataSourceConfigurationDto: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + String.Join(",", matchedTypes));
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newAddDataSourceConfiguration200Response;
        }


        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// Custom JSON converter for AddDataSourceConfiguration200Response
    /// </summary>
    public class AddDataSourceConfiguration200ResponseJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(AddDataSourceConfiguration200Response).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch(reader.TokenType) 
            {
                case JsonToken.StartObject:
                    return AddDataSourceConfiguration200Response.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return AddDataSourceConfiguration200Response.FromJson(JArray.Load(reader).ToString(Formatting.None));
                default:
                    return null;
            }
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
