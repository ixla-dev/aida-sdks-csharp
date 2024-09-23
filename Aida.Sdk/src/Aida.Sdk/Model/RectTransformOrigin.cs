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
    /// Defines RectTransformOrigin
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RectTransformOrigin
    {
        /// <summary>
        /// Enum TopLeft for value: TopLeft
        /// </summary>
        [EnumMember(Value = "TopLeft")]
        TopLeft = 1,

        /// <summary>
        /// Enum TopRight for value: TopRight
        /// </summary>
        [EnumMember(Value = "TopRight")]
        TopRight = 2,

        /// <summary>
        /// Enum BottomLeft for value: BottomLeft
        /// </summary>
        [EnumMember(Value = "BottomLeft")]
        BottomLeft = 3,

        /// <summary>
        /// Enum BottomRight for value: BottomRight
        /// </summary>
        [EnumMember(Value = "BottomRight")]
        BottomRight = 4,

        /// <summary>
        /// Enum Center for value: Center
        /// </summary>
        [EnumMember(Value = "Center")]
        Center = 5
    }

}
