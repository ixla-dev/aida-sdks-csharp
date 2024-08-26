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
using System.ComponentModel.DataAnnotations;
using FileParameter = Aida.Sdk.Mini.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Mini.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Mini.Model
{
    /// <summary>
    /// Defines PageSegmentationMode
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PageSegmentationMode
    {
        /// <summary>
        /// Enum OsdOnly for value: OsdOnly
        /// </summary>
        [EnumMember(Value = "OsdOnly")]
        OsdOnly = 1,

        /// <summary>
        /// Enum AutoOsd for value: AutoOsd
        /// </summary>
        [EnumMember(Value = "AutoOsd")]
        AutoOsd = 2,

        /// <summary>
        /// Enum AutoOnly for value: AutoOnly
        /// </summary>
        [EnumMember(Value = "AutoOnly")]
        AutoOnly = 3,

        /// <summary>
        /// Enum Auto for value: Auto
        /// </summary>
        [EnumMember(Value = "Auto")]
        Auto = 4,

        /// <summary>
        /// Enum SingleColumn for value: SingleColumn
        /// </summary>
        [EnumMember(Value = "SingleColumn")]
        SingleColumn = 5,

        /// <summary>
        /// Enum SingleBlockVertText for value: SingleBlockVertText
        /// </summary>
        [EnumMember(Value = "SingleBlockVertText")]
        SingleBlockVertText = 6,

        /// <summary>
        /// Enum SingleBlock for value: SingleBlock
        /// </summary>
        [EnumMember(Value = "SingleBlock")]
        SingleBlock = 7,

        /// <summary>
        /// Enum SingleLine for value: SingleLine
        /// </summary>
        [EnumMember(Value = "SingleLine")]
        SingleLine = 8,

        /// <summary>
        /// Enum SingleWord for value: SingleWord
        /// </summary>
        [EnumMember(Value = "SingleWord")]
        SingleWord = 9,

        /// <summary>
        /// Enum CircleWord for value: CircleWord
        /// </summary>
        [EnumMember(Value = "CircleWord")]
        CircleWord = 10,

        /// <summary>
        /// Enum SingleChar for value: SingleChar
        /// </summary>
        [EnumMember(Value = "SingleChar")]
        SingleChar = 11,

        /// <summary>
        /// Enum SparseText for value: SparseText
        /// </summary>
        [EnumMember(Value = "SparseText")]
        SparseText = 12,

        /// <summary>
        /// Enum SparseTextOsd for value: SparseTextOsd
        /// </summary>
        [EnumMember(Value = "SparseTextOsd")]
        SparseTextOsd = 13,

        /// <summary>
        /// Enum RawLine for value: RawLine
        /// </summary>
        [EnumMember(Value = "RawLine")]
        RawLine = 14,

        /// <summary>
        /// Enum Count for value: Count
        /// </summary>
        [EnumMember(Value = "Count")]
        Count = 15
    }

}
