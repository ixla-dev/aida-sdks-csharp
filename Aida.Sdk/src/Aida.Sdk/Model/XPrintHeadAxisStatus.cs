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
    /// Defines XPrintHeadAxisStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum XPrintHeadAxisStatus
    {
        /// <summary>
        /// Enum NoErrors for value: NoErrors
        /// </summary>
        [EnumMember(Value = "NoErrors")]
        NoErrors = 1,

        /// <summary>
        /// Enum HeadAxisStepMotorDriverFault for value: HeadAxisStepMotorDriverFault
        /// </summary>
        [EnumMember(Value = "HeadAxisStepMotorDriverFault")]
        HeadAxisStepMotorDriverFault = 2,

        /// <summary>
        /// Enum HeadAxisMotorOrHomePhotoFault for value: HeadAxisMotorOrHomePhotoFault
        /// </summary>
        [EnumMember(Value = "HeadAxisMotorOrHomePhotoFault")]
        HeadAxisMotorOrHomePhotoFault = 3,

        /// <summary>
        /// Enum HeadAxisPositioningFault for value: HeadAxisPositioningFault
        /// </summary>
        [EnumMember(Value = "HeadAxisPositioningFault")]
        HeadAxisPositioningFault = 4
    }

}
