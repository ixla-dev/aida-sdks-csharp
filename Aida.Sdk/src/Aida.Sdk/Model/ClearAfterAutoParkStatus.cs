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
    /// Defines ClearAfterAutoParkStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ClearAfterAutoParkStatus
    {
        /// <summary>
        /// Enum Disabled for value: Disabled
        /// </summary>
        [EnumMember(Value = "Disabled")]
        Disabled = 1,

        /// <summary>
        /// Enum Idle for value: Idle
        /// </summary>
        [EnumMember(Value = "Idle")]
        Idle = 2,

        /// <summary>
        /// Enum WaitingForTemperature for value: WaitingForTemperature
        /// </summary>
        [EnumMember(Value = "WaitingForTemperature")]
        WaitingForTemperature = 3,

        /// <summary>
        /// Enum PerformingCleaning for value: PerformingCleaning
        /// </summary>
        [EnumMember(Value = "PerformingCleaning")]
        PerformingCleaning = 4,

        /// <summary>
        /// Enum Done for value: Done
        /// </summary>
        [EnumMember(Value = "Done")]
        Done = 5,

        /// <summary>
        /// Enum Failed for value: Failed
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed = 6
    }

}
