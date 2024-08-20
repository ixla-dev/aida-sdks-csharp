/*
 * aida
 *
 * 1.0.703.2
 *
 * The version of the OpenAPI document: 1.0.703.2
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
    /// Defines BinningMode
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BinningMode
    {
        /// <summary>
        /// Enum Off for value: Off
        /// </summary>
        [EnumMember(Value = "Off")]
        Off = 1,

        /// <summary>
        /// Enum BinningH for value: BinningH
        /// </summary>
        [EnumMember(Value = "BinningH")]
        BinningH = 2,

        /// <summary>
        /// Enum BinningV for value: BinningV
        /// </summary>
        [EnumMember(Value = "BinningV")]
        BinningV = 3,

        /// <summary>
        /// Enum BinningHV for value: BinningHV
        /// </summary>
        [EnumMember(Value = "BinningHV")]
        BinningHV = 4,

        /// <summary>
        /// Enum Binning3H for value: Binning3H
        /// </summary>
        [EnumMember(Value = "Binning3H")]
        Binning3H = 5,

        /// <summary>
        /// Enum Binning3V for value: Binning3V
        /// </summary>
        [EnumMember(Value = "Binning3V")]
        Binning3V = 6,

        /// <summary>
        /// Enum Binning3H3V for value: Binning3H3V
        /// </summary>
        [EnumMember(Value = "Binning3H3V")]
        Binning3H3V = 7,

        /// <summary>
        /// Enum BinningHAvg for value: BinningHAvg
        /// </summary>
        [EnumMember(Value = "BinningHAvg")]
        BinningHAvg = 8,

        /// <summary>
        /// Enum BinningVAvg for value: BinningVAvg
        /// </summary>
        [EnumMember(Value = "BinningVAvg")]
        BinningVAvg = 9,

        /// <summary>
        /// Enum BinningHVAvg for value: BinningHVAvg
        /// </summary>
        [EnumMember(Value = "BinningHVAvg")]
        BinningHVAvg = 10,

        /// <summary>
        /// Enum Binning3HAvg for value: Binning3HAvg
        /// </summary>
        [EnumMember(Value = "Binning3HAvg")]
        Binning3HAvg = 11,

        /// <summary>
        /// Enum Binning3VAvg for value: Binning3VAvg
        /// </summary>
        [EnumMember(Value = "Binning3VAvg")]
        Binning3VAvg = 12,

        /// <summary>
        /// Enum Binning3H3VAvg for value: Binning3H3VAvg
        /// </summary>
        [EnumMember(Value = "Binning3H3VAvg")]
        Binning3H3VAvg = 13,

        /// <summary>
        /// Enum DroppingH for value: DroppingH
        /// </summary>
        [EnumMember(Value = "DroppingH")]
        DroppingH = 14,

        /// <summary>
        /// Enum DroppingV for value: DroppingV
        /// </summary>
        [EnumMember(Value = "DroppingV")]
        DroppingV = 15,

        /// <summary>
        /// Enum DroppingHV for value: DroppingHV
        /// </summary>
        [EnumMember(Value = "DroppingHV")]
        DroppingHV = 16,

        /// <summary>
        /// Enum Dropping3H for value: Dropping3H
        /// </summary>
        [EnumMember(Value = "Dropping3H")]
        Dropping3H = 17,

        /// <summary>
        /// Enum Dropping3V for value: Dropping3V
        /// </summary>
        [EnumMember(Value = "Dropping3V")]
        Dropping3V = 18,

        /// <summary>
        /// Enum Dropping3H3V for value: Dropping3H3V
        /// </summary>
        [EnumMember(Value = "Dropping3H3V")]
        Dropping3H3V = 19
    }

}
