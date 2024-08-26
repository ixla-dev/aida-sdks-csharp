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
    /// Defines BoxModuleConfiguration
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BoxModuleConfiguration
    {
        /// <summary>
        /// Enum Basic for value: Basic
        /// </summary>
        [EnumMember(Value = "Basic")]
        Basic = 1,

        /// <summary>
        /// Enum SingleFeederOnBoard for value: SingleFeederOnBoard
        /// </summary>
        [EnumMember(Value = "SingleFeederOnBoard")]
        SingleFeederOnBoard = 2,

        /// <summary>
        /// Enum SingleFeeder for value: SingleFeeder
        /// </summary>
        [EnumMember(Value = "SingleFeeder")]
        SingleFeeder = 3,

        /// <summary>
        /// Enum DoubleFeeder for value: DoubleFeeder
        /// </summary>
        [EnumMember(Value = "DoubleFeeder")]
        DoubleFeeder = 4,

        /// <summary>
        /// Enum SingleChipReader for value: SingleChipReader
        /// </summary>
        [EnumMember(Value = "SingleChipReader")]
        SingleChipReader = 5,

        /// <summary>
        /// Enum SingleRfIdReader for value: SingleRfIdReader
        /// </summary>
        [EnumMember(Value = "SingleRfIdReader")]
        SingleRfIdReader = 6,

        /// <summary>
        /// Enum SingleChipAndRfIdReader for value: SingleChipAndRfIdReader
        /// </summary>
        [EnumMember(Value = "SingleChipAndRfIdReader")]
        SingleChipAndRfIdReader = 7,

        /// <summary>
        /// Enum MultiChipLowerBoard for value: MultiChipLowerBoard
        /// </summary>
        [EnumMember(Value = "MultiChipLowerBoard")]
        MultiChipLowerBoard = 8,

        /// <summary>
        /// Enum MultiChipHigherBoard for value: MultiChipHigherBoard
        /// </summary>
        [EnumMember(Value = "MultiChipHigherBoard")]
        MultiChipHigherBoard = 9,

        /// <summary>
        /// Enum QualityControl for value: QualityControl
        /// </summary>
        [EnumMember(Value = "QualityControl")]
        QualityControl = 10,

        /// <summary>
        /// Enum MagStripeReader for value: MagStripeReader
        /// </summary>
        [EnumMember(Value = "MagStripeReader")]
        MagStripeReader = 11,

        /// <summary>
        /// Enum InkJetPrinter for value: InkJetPrinter
        /// </summary>
        [EnumMember(Value = "InkJetPrinter")]
        InkJetPrinter = 12,

        /// <summary>
        /// Enum SingleStackerOnBoard for value: SingleStackerOnBoard
        /// </summary>
        [EnumMember(Value = "SingleStackerOnBoard")]
        SingleStackerOnBoard = 13,

        /// <summary>
        /// Enum SingleStacker for value: SingleStacker
        /// </summary>
        [EnumMember(Value = "SingleStacker")]
        SingleStacker = 14,

        /// <summary>
        /// Enum DoubleStacker for value: DoubleStacker
        /// </summary>
        [EnumMember(Value = "DoubleStacker")]
        DoubleStacker = 15
    }

}
