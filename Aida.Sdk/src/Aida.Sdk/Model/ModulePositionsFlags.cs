/*
 * aida
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
using FileParameter = Aida.Sdk.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Model
{
    /// <summary>
    /// Defines ModulePositionsFlags
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ModulePositionsFlags
    {
        /// <summary>
        /// Enum NoCard for value: NoCard
        /// </summary>
        [EnumMember(Value = "NoCard")]
        NoCard = 1,

        /// <summary>
        /// Enum Flipover for value: Flipover
        /// </summary>
        [EnumMember(Value = "Flipover")]
        Flipover = 2,

        /// <summary>
        /// Enum Laser for value: Laser
        /// </summary>
        [EnumMember(Value = "Laser")]
        Laser = 3,

        /// <summary>
        /// Enum InkJet for value: InkJet
        /// </summary>
        [EnumMember(Value = "InkJet")]
        InkJet = 4,

        /// <summary>
        /// Enum PinchRoller1 for value: PinchRoller1
        /// </summary>
        [EnumMember(Value = "PinchRoller1")]
        PinchRoller1 = 5,

        /// <summary>
        /// Enum PinchRoller2 for value: PinchRoller2
        /// </summary>
        [EnumMember(Value = "PinchRoller2")]
        PinchRoller2 = 6,

        /// <summary>
        /// Enum FlipoverFlipped for value: FlipoverFlipped
        /// </summary>
        [EnumMember(Value = "FlipoverFlipped")]
        FlipoverFlipped = 7,

        /// <summary>
        /// Enum StackerNotPresent for value: StackerNotPresent
        /// </summary>
        [EnumMember(Value = "StackerNotPresent")]
        StackerNotPresent = 8,

        /// <summary>
        /// Enum NoCardInFeeder1 for value: NoCardInFeeder1
        /// </summary>
        [EnumMember(Value = "NoCardInFeeder1")]
        NoCardInFeeder1 = 9,

        /// <summary>
        /// Enum NoCardInFeeder2 for value: NoCardInFeeder2
        /// </summary>
        [EnumMember(Value = "NoCardInFeeder2")]
        NoCardInFeeder2 = 10
    }

}
