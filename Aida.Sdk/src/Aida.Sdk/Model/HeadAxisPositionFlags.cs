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
using System.ComponentModel.DataAnnotations;
using FileParameter = Aida.Sdk.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Model
{
    /// <summary>
    /// Defines HeadAxisPositionFlags
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum HeadAxisPositionFlags
    {
        /// <summary>
        /// Enum Capping for value: Capping
        /// </summary>
        [EnumMember(Value = "Capping")]
        Capping = 1,

        /// <summary>
        /// Enum Print for value: Print
        /// </summary>
        [EnumMember(Value = "Print")]
        Print = 2,

        /// <summary>
        /// Enum Wiper for value: Wiper
        /// </summary>
        [EnumMember(Value = "Wiper")]
        Wiper = 3,

        /// <summary>
        /// Enum Calib for value: Calib
        /// </summary>
        [EnumMember(Value = "Calib")]
        Calib = 4
    }

}
