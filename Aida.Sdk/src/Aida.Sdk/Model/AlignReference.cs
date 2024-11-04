/*
 * aida
 *
 * 1.0.721-rc.9+f020d61fcb6ef6ebe31e8b3974d429a24c2e10d0
 *
 * The version of the OpenAPI document: 1.0.721-rc.9+f020d61fcb6ef6ebe31e8b3974d429a24c2e10d0
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
    /// Defines AlignReference
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AlignReference
    {
        /// <summary>
        /// Enum Top for value: Top
        /// </summary>
        [EnumMember(Value = "Top")]
        Top = 1,

        /// <summary>
        /// Enum Right for value: Right
        /// </summary>
        [EnumMember(Value = "Right")]
        Right = 2,

        /// <summary>
        /// Enum Bottom for value: Bottom
        /// </summary>
        [EnumMember(Value = "Bottom")]
        Bottom = 3,

        /// <summary>
        /// Enum Left for value: Left
        /// </summary>
        [EnumMember(Value = "Left")]
        Left = 4,

        /// <summary>
        /// Enum Middle for value: Middle
        /// </summary>
        [EnumMember(Value = "Middle")]
        Middle = 5,

        /// <summary>
        /// Enum Center for value: Center
        /// </summary>
        [EnumMember(Value = "Center")]
        Center = 6
    }

}
