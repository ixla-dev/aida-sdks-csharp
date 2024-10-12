/*
 * aida
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
using FileParameter = Aida.Sdk.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Model
{
    /// <summary>
    /// Defines AutoPosResultStatusCode
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AutoPosResultStatusCode
    {
        /// <summary>
        /// Enum NOERROR for value: E_NO_ERROR
        /// </summary>
        [EnumMember(Value = "E_NO_ERROR")]
        NOERROR = 1,

        /// <summary>
        /// Enum MISSINGTEMPLATECONFIGURATION for value: E_MISSING_TEMPLATE_CONFIGURATION
        /// </summary>
        [EnumMember(Value = "E_MISSING_TEMPLATE_CONFIGURATION")]
        MISSINGTEMPLATECONFIGURATION = 2,

        /// <summary>
        /// Enum MISSINGSEARCHAREACONFIGURATION for value: E_MISSING_SEARCH_AREA_CONFIGURATION
        /// </summary>
        [EnumMember(Value = "E_MISSING_SEARCH_AREA_CONFIGURATION")]
        MISSINGSEARCHAREACONFIGURATION = 3,

        /// <summary>
        /// Enum NOMATCH for value: E_NO_MATCH
        /// </summary>
        [EnumMember(Value = "E_NO_MATCH")]
        NOMATCH = 4,

        /// <summary>
        /// Enum CAMERAIMAGEACQUISITIONERROR for value: E_CAMERA_IMAGE_ACQUISITION_ERROR
        /// </summary>
        [EnumMember(Value = "E_CAMERA_IMAGE_ACQUISITION_ERROR")]
        CAMERAIMAGEACQUISITIONERROR = 5,

        /// <summary>
        /// Enum INVALIDCAMERAID for value: E_INVALID_CAMERA_ID
        /// </summary>
        [EnumMember(Value = "E_INVALID_CAMERA_ID")]
        INVALIDCAMERAID = 6,

        /// <summary>
        /// Enum INVALIDCAMERACONFIG for value: E_INVALID_CAMERA_CONFIG
        /// </summary>
        [EnumMember(Value = "E_INVALID_CAMERA_CONFIG")]
        INVALIDCAMERACONFIG = 7,

        /// <summary>
        /// Enum AUTOPOSCONFIGNOTFOUND for value: E_AUTO_POS_CONFIG_NOT_FOUND
        /// </summary>
        [EnumMember(Value = "E_AUTO_POS_CONFIG_NOT_FOUND")]
        AUTOPOSCONFIGNOTFOUND = 8
    }

}
