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
    /// Defines DiagnosticTaskType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DiagnosticTaskType
    {
        /// <summary>
        /// Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 1,

        /// <summary>
        /// Enum Transport for value: Transport
        /// </summary>
        [EnumMember(Value = "Transport")]
        Transport = 2,

        /// <summary>
        /// Enum Autopos for value: Autopos
        /// </summary>
        [EnumMember(Value = "Autopos")]
        Autopos = 3,

        /// <summary>
        /// Enum Ocr for value: Ocr
        /// </summary>
        [EnumMember(Value = "Ocr")]
        Ocr = 4,

        /// <summary>
        /// Enum Laser for value: Laser
        /// </summary>
        [EnumMember(Value = "Laser")]
        Laser = 5,

        /// <summary>
        /// Enum MagStripe for value: MagStripe
        /// </summary>
        [EnumMember(Value = "MagStripe")]
        MagStripe = 6
    }

}
