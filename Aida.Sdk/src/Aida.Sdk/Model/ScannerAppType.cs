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
    /// Defines ScannerAppType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ScannerAppType
    {
        /// <summary>
        /// Enum ScapsSamLight for value: ScapsSamLight
        /// </summary>
        [EnumMember(Value = "ScapsSamLight")]
        ScapsSamLight = 1,

        /// <summary>
        /// Enum VirtualScannerApp for value: VirtualScannerApp
        /// </summary>
        [EnumMember(Value = "VirtualScannerApp")]
        VirtualScannerApp = 2
    }

}
