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
    /// Defines DevicePropertyType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DevicePropertyType
    {
        /// <summary>
        /// Enum Integer for value: Integer
        /// </summary>
        [EnumMember(Value = "Integer")]
        Integer = 1,

        /// <summary>
        /// Enum Float for value: Float
        /// </summary>
        [EnumMember(Value = "Float")]
        Float = 2,

        /// <summary>
        /// Enum String for value: String
        /// </summary>
        [EnumMember(Value = "String")]
        String = 3,

        /// <summary>
        /// Enum Boolean for value: Boolean
        /// </summary>
        [EnumMember(Value = "Boolean")]
        Boolean = 4
    }

}