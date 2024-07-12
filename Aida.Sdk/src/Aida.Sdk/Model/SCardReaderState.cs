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
    /// Defines SCardReaderState
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SCardReaderState
    {
        /// <summary>
        /// Enum Unaware for value: Unaware
        /// </summary>
        [EnumMember(Value = "Unaware")]
        Unaware = 1,

        /// <summary>
        /// Enum Ignore for value: Ignore
        /// </summary>
        [EnumMember(Value = "Ignore")]
        Ignore = 2,

        /// <summary>
        /// Enum Changed for value: Changed
        /// </summary>
        [EnumMember(Value = "Changed")]
        Changed = 3,

        /// <summary>
        /// Enum Unknown for value: Unknown
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown = 4,

        /// <summary>
        /// Enum Unavailable for value: Unavailable
        /// </summary>
        [EnumMember(Value = "Unavailable")]
        Unavailable = 5,

        /// <summary>
        /// Enum Empty for value: Empty
        /// </summary>
        [EnumMember(Value = "Empty")]
        Empty = 6,

        /// <summary>
        /// Enum Present for value: Present
        /// </summary>
        [EnumMember(Value = "Present")]
        Present = 7,

        /// <summary>
        /// Enum AtrMatch for value: AtrMatch
        /// </summary>
        [EnumMember(Value = "AtrMatch")]
        AtrMatch = 8,

        /// <summary>
        /// Enum Exclusive for value: Exclusive
        /// </summary>
        [EnumMember(Value = "Exclusive")]
        Exclusive = 9,

        /// <summary>
        /// Enum InUse for value: InUse
        /// </summary>
        [EnumMember(Value = "InUse")]
        InUse = 10,

        /// <summary>
        /// Enum Mute for value: Mute
        /// </summary>
        [EnumMember(Value = "Mute")]
        Mute = 11,

        /// <summary>
        /// Enum Unpowered for value: Unpowered
        /// </summary>
        [EnumMember(Value = "Unpowered")]
        Unpowered = 12
    }

}
