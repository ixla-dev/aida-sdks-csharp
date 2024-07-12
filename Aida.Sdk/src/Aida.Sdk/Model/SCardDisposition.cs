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
    /// Defines SCardDisposition
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SCardDisposition
    {
        /// <summary>
        /// Enum LeaveCard for value: LeaveCard
        /// </summary>
        [EnumMember(Value = "LeaveCard")]
        LeaveCard = 1,

        /// <summary>
        /// Enum ResetCard for value: ResetCard
        /// </summary>
        [EnumMember(Value = "ResetCard")]
        ResetCard = 2,

        /// <summary>
        /// Enum UnpowerCard for value: UnpowerCard
        /// </summary>
        [EnumMember(Value = "UnpowerCard")]
        UnpowerCard = 3,

        /// <summary>
        /// Enum EjectCard for value: EjectCard
        /// </summary>
        [EnumMember(Value = "EjectCard")]
        EjectCard = 4
    }

}
