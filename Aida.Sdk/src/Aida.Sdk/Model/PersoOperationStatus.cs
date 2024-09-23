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
    /// Defines PersoOperationStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PersoOperationStatus
    {
        /// <summary>
        /// Enum Idle for value: Idle
        /// </summary>
        [EnumMember(Value = "Idle")]
        Idle = 1,

        /// <summary>
        /// Enum Scheduled for value: Scheduled
        /// </summary>
        [EnumMember(Value = "Scheduled")]
        Scheduled = 2,

        /// <summary>
        /// Enum Executing for value: Executing
        /// </summary>
        [EnumMember(Value = "Executing")]
        Executing = 3,

        /// <summary>
        /// Enum Suspended for value: Suspended
        /// </summary>
        [EnumMember(Value = "Suspended")]
        Suspended = 4,

        /// <summary>
        /// Enum Cancelled for value: Cancelled
        /// </summary>
        [EnumMember(Value = "Cancelled")]
        Cancelled = 5,

        /// <summary>
        /// Enum Finished for value: Finished
        /// </summary>
        [EnumMember(Value = "Finished")]
        Finished = 6
    }

}
