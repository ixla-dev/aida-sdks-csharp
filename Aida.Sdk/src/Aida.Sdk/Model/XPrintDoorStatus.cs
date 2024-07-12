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
    /// Defines XPrintDoorStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum XPrintDoorStatus
    {
        /// <summary>
        /// Enum AllClosed for value: AllClosed
        /// </summary>
        [EnumMember(Value = "AllClosed")]
        AllClosed = 1,

        /// <summary>
        /// Enum FrontRight for value: FrontRight
        /// </summary>
        [EnumMember(Value = "FrontRight")]
        FrontRight = 2,

        /// <summary>
        /// Enum FrontLeft for value: FrontLeft
        /// </summary>
        [EnumMember(Value = "FrontLeft")]
        FrontLeft = 3,

        /// <summary>
        /// Enum RearLeft for value: RearLeft
        /// </summary>
        [EnumMember(Value = "RearLeft")]
        RearLeft = 4,

        /// <summary>
        /// Enum InspectionDoor for value: InspectionDoor
        /// </summary>
        [EnumMember(Value = "InspectionDoor")]
        InspectionDoor = 5,

        /// <summary>
        /// Enum AnyInterlock for value: AnyInterlock
        /// </summary>
        [EnumMember(Value = "AnyInterlock")]
        AnyInterlock = 6,

        /// <summary>
        /// Enum ExternalInterlock for value: ExternalInterlock
        /// </summary>
        [EnumMember(Value = "ExternalInterlock")]
        ExternalInterlock = 7
    }

}
