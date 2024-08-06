/*
 * aida
 *
 * 1.0.703.1
 *
 * The version of the OpenAPI document: 1.0.703.1
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
    /// Defines TransportStatusFlags
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransportStatusFlags
    {
        /// <summary>
        /// Enum Motor1On for value: Motor1On
        /// </summary>
        [EnumMember(Value = "Motor1On")]
        Motor1On = 1,

        /// <summary>
        /// Enum Motor2On for value: Motor2On
        /// </summary>
        [EnumMember(Value = "Motor2On")]
        Motor2On = 2,

        /// <summary>
        /// Enum Motor3On for value: Motor3On
        /// </summary>
        [EnumMember(Value = "Motor3On")]
        Motor3On = 3,

        /// <summary>
        /// Enum Motor4On for value: Motor4On
        /// </summary>
        [EnumMember(Value = "Motor4On")]
        Motor4On = 4,

        /// <summary>
        /// Enum CardFlipped for value: CardFlipped
        /// </summary>
        [EnumMember(Value = "CardFlipped")]
        CardFlipped = 5,

        /// <summary>
        /// Enum Stacker2Error for value: Stacker2Error
        /// </summary>
        [EnumMember(Value = "Stacker2Error")]
        Stacker2Error = 6,

        /// <summary>
        /// Enum Feeder2Empty for value: Feeder2Empty
        /// </summary>
        [EnumMember(Value = "Feeder2Empty")]
        Feeder2Empty = 7,

        /// <summary>
        /// Enum Feeder2Error for value: Feeder2Error
        /// </summary>
        [EnumMember(Value = "Feeder2Error")]
        Feeder2Error = 8,

        /// <summary>
        /// Enum TransportError for value: TransportError
        /// </summary>
        [EnumMember(Value = "TransportError")]
        TransportError = 9,

        /// <summary>
        /// Enum Feeder1Empty for value: Feeder1Empty
        /// </summary>
        [EnumMember(Value = "Feeder1Empty")]
        Feeder1Empty = 10,

        /// <summary>
        /// Enum Feeder1Error for value: Feeder1Error
        /// </summary>
        [EnumMember(Value = "Feeder1Error")]
        Feeder1Error = 11,

        /// <summary>
        /// Enum CardNotFed for value: CardNotFed
        /// </summary>
        [EnumMember(Value = "CardNotFed")]
        CardNotFed = 12,

        /// <summary>
        /// Enum FlipError for value: FlipError
        /// </summary>
        [EnumMember(Value = "FlipError")]
        FlipError = 13,

        /// <summary>
        /// Enum StackerError for value: StackerError
        /// </summary>
        [EnumMember(Value = "StackerError")]
        StackerError = 14,

        /// <summary>
        /// Enum MotorDc1On for value: MotorDc1On
        /// </summary>
        [EnumMember(Value = "MotorDc1On")]
        MotorDc1On = 15
    }

}
