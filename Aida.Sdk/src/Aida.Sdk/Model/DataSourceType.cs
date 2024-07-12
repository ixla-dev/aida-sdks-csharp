/*
 * aida
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
using FileParameter = Aida.Sdk.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Model
{
    /// <summary>
    /// Defines DataSourceType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DataSourceType
    {
        /// <summary>
        /// Enum RelationalDatabaseMySql for value: RelationalDatabaseMySql
        /// </summary>
        [EnumMember(Value = "RelationalDatabaseMySql")]
        RelationalDatabaseMySql = 1,

        /// <summary>
        /// Enum RelationalDatabasePostgres for value: RelationalDatabasePostgres
        /// </summary>
        [EnumMember(Value = "RelationalDatabasePostgres")]
        RelationalDatabasePostgres = 2
    }

}