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
    /// Defines BoxModuleTransportStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BoxModuleTransportStatus
    {
        /// <summary>
        /// Enum Uninitialized for value: Uninitialized
        /// </summary>
        [EnumMember(Value = "Uninitialized")]
        Uninitialized = 1,

        /// <summary>
        /// Enum Ready for value: Ready
        /// </summary>
        [EnumMember(Value = "Ready")]
        Ready = 2,

        /// <summary>
        /// Enum AnotherCmdExError for value: AnotherCmdExError
        /// </summary>
        [EnumMember(Value = "AnotherCmdExError")]
        AnotherCmdExError = 3,

        /// <summary>
        /// Enum Feeder1Empty for value: Feeder1Empty
        /// </summary>
        [EnumMember(Value = "Feeder1Empty")]
        Feeder1Empty = 4,

        /// <summary>
        /// Enum MagFeederOut for value: MagFeederOut
        /// </summary>
        [EnumMember(Value = "MagFeederOut")]
        MagFeederOut = 5,

        /// <summary>
        /// Enum MagStackerOut for value: MagStackerOut
        /// </summary>
        [EnumMember(Value = "MagStackerOut")]
        MagStackerOut = 6,

        /// <summary>
        /// Enum CardJam for value: CardJam
        /// </summary>
        [EnumMember(Value = "CardJam")]
        CardJam = 7,

        /// <summary>
        /// Enum FlipError for value: FlipError
        /// </summary>
        [EnumMember(Value = "FlipError")]
        FlipError = 8,

        /// <summary>
        /// Enum Feeder1Error for value: Feeder1Error
        /// </summary>
        [EnumMember(Value = "Feeder1Error")]
        Feeder1Error = 9,

        /// <summary>
        /// Enum Feeder2Empty for value: Feeder2Empty
        /// </summary>
        [EnumMember(Value = "Feeder2Empty")]
        Feeder2Empty = 10,

        /// <summary>
        /// Enum MagStacker2Out for value: MagStacker2Out
        /// </summary>
        [EnumMember(Value = "MagStacker2Out")]
        MagStacker2Out = 11,

        /// <summary>
        /// Enum SpindleError for value: SpindleError
        /// </summary>
        [EnumMember(Value = "SpindleError")]
        SpindleError = 12,

        /// <summary>
        /// Enum NoCardFed for value: NoCardFed
        /// </summary>
        [EnumMember(Value = "NoCardFed")]
        NoCardFed = 13,

        /// <summary>
        /// Enum Feeder2Error for value: Feeder2Error
        /// </summary>
        [EnumMember(Value = "Feeder2Error")]
        Feeder2Error = 14,

        /// <summary>
        /// Enum CardSourceEmpty for value: CardSourceEmpty
        /// </summary>
        [EnumMember(Value = "CardSourceEmpty")]
        CardSourceEmpty = 15,

        /// <summary>
        /// Enum CardDestFull for value: CardDestFull
        /// </summary>
        [EnumMember(Value = "CardDestFull")]
        CardDestFull = 16,

        /// <summary>
        /// Enum Stacker2Error for value: Stacker2Error
        /// </summary>
        [EnumMember(Value = "Stacker2Error")]
        Stacker2Error = 17,

        /// <summary>
        /// Enum TrayRejectFull for value: TrayRejectFull
        /// </summary>
        [EnumMember(Value = "TrayRejectFull")]
        TrayRejectFull = 18,

        /// <summary>
        /// Enum MagBothStackerOut for value: MagBothStackerOut
        /// </summary>
        [EnumMember(Value = "MagBothStackerOut")]
        MagBothStackerOut = 19,

        /// <summary>
        /// Enum ChipReaderError for value: ChipReaderError
        /// </summary>
        [EnumMember(Value = "ChipReaderError")]
        ChipReaderError = 20,

        /// <summary>
        /// Enum TrayEjectOpen for value: TrayEjectOpen
        /// </summary>
        [EnumMember(Value = "TrayEjectOpen")]
        TrayEjectOpen = 21,

        /// <summary>
        /// Enum StackerError for value: StackerError
        /// </summary>
        [EnumMember(Value = "StackerError")]
        StackerError = 22,

        /// <summary>
        /// Enum TransportInputTimeout for value: TransportInputTimeout
        /// </summary>
        [EnumMember(Value = "TransportInputTimeout")]
        TransportInputTimeout = 23,

        /// <summary>
        /// Enum Unknown for value: Unknown
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown = 24,

        /// <summary>
        /// Enum TransportWaitingCard for value: TransportWaitingCard
        /// </summary>
        [EnumMember(Value = "TransportWaitingCard")]
        TransportWaitingCard = 25,

        /// <summary>
        /// Enum Busy for value: Busy
        /// </summary>
        [EnumMember(Value = "Busy")]
        Busy = 26
    }

}
