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
    /// Defines SystemStatusFlags
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SystemStatusFlags
    {
        /// <summary>
        /// Enum NoError for value: NoError
        /// </summary>
        [EnumMember(Value = "NoError")]
        NoError = 1,

        /// <summary>
        /// Enum TransportAxisError for value: TransportAxisError
        /// </summary>
        [EnumMember(Value = "TransportAxisError")]
        TransportAxisError = 2,

        /// <summary>
        /// Enum HeadAxisError for value: HeadAxisError
        /// </summary>
        [EnumMember(Value = "HeadAxisError")]
        HeadAxisError = 3,

        /// <summary>
        /// Enum CappingError for value: CappingError
        /// </summary>
        [EnumMember(Value = "CappingError")]
        CappingError = 4,

        /// <summary>
        /// Enum UVLampError for value: UVLampError
        /// </summary>
        [EnumMember(Value = "UVLampError")]
        UVLampError = 5,

        /// <summary>
        /// Enum FumeExtractorError for value: FumeExtractorError
        /// </summary>
        [EnumMember(Value = "FumeExtractorError")]
        FumeExtractorError = 6,

        /// <summary>
        /// Enum HeaterError for value: HeaterError
        /// </summary>
        [EnumMember(Value = "HeaterError")]
        HeaterError = 7,

        /// <summary>
        /// Enum UnknownStatus for value: UnknownStatus
        /// </summary>
        [EnumMember(Value = "UnknownStatus")]
        UnknownStatus = 8
    }

}
