/*
 * aida-mini
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
using System.ComponentModel.DataAnnotations;
using FileParameter = Aida.Sdk.Mini.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Mini.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Mini.Model
{
    /// <summary>
    /// Defines SystemStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SystemStatus
    {
        /// <summary>
        /// Enum Booting for value: Booting
        /// </summary>
        [EnumMember(Value = "Booting")]
        Booting = 1,

        /// <summary>
        /// Enum Ready for value: Ready
        /// </summary>
        [EnumMember(Value = "Ready")]
        Ready = 2,

        /// <summary>
        /// Enum Busy for value: Busy
        /// </summary>
        [EnumMember(Value = "Busy")]
        Busy = 3,

        /// <summary>
        /// Enum Error for value: Error
        /// </summary>
        [EnumMember(Value = "Error")]
        Error = 4
    }

}
