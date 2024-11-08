/*
 * aida-mini
 *
 * 1.0.713
 *
 * The version of the OpenAPI document: 1.0.713
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
    /// Defines ReaderAccessType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReaderAccessType
    {
        /// <summary>
        /// Enum PcScGateway for value: PcScGateway
        /// </summary>
        [EnumMember(Value = "PcScGateway")]
        PcScGateway = 1,

        /// <summary>
        /// Enum Ethernet for value: Ethernet
        /// </summary>
        [EnumMember(Value = "Ethernet")]
        Ethernet = 2,

        /// <summary>
        /// Enum ExternalUsb for value: ExternalUsb
        /// </summary>
        [EnumMember(Value = "ExternalUsb")]
        ExternalUsb = 3
    }

}
