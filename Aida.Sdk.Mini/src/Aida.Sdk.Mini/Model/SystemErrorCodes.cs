/*
 * aida-mini
 *
 * 1.0.713
 *
 * The version of the OpenAPI document: 1.0.713
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
    /// Defines SystemErrorCodes
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SystemErrorCodes
    {
        /// <summary>
        /// Enum CardJam for value: CardJam
        /// </summary>
        [EnumMember(Value = "CardJam")]
        CardJam = 1,

        /// <summary>
        /// Enum FeederEmpty for value: FeederEmpty
        /// </summary>
        [EnumMember(Value = "FeederEmpty")]
        FeederEmpty = 2,

        /// <summary>
        /// Enum OpenInterlock for value: OpenInterlock
        /// </summary>
        [EnumMember(Value = "OpenInterlock")]
        OpenInterlock = 3,

        /// <summary>
        /// Enum PrintHeadWarming for value: PrintHeadWarming
        /// </summary>
        [EnumMember(Value = "PrintHeadWarming")]
        PrintHeadWarming = 4,

        /// <summary>
        /// Enum PrintHeadOverTemperature for value: PrintHeadOverTemperature
        /// </summary>
        [EnumMember(Value = "PrintHeadOverTemperature")]
        PrintHeadOverTemperature = 5,

        /// <summary>
        /// Enum LaserInterfaceError for value: LaserInterfaceError
        /// </summary>
        [EnumMember(Value = "LaserInterfaceError")]
        LaserInterfaceError = 6
    }

}
