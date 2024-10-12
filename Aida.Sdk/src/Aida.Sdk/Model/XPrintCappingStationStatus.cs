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
    /// Defines XPrintCappingStationStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum XPrintCappingStationStatus
    {
        /// <summary>
        /// Enum NoErrors for value: NoErrors
        /// </summary>
        [EnumMember(Value = "NoErrors")]
        NoErrors = 1,

        /// <summary>
        /// Enum CappingDcOrWiperStepMotorDriverFault for value: CappingDcOrWiperStepMotorDriverFault
        /// </summary>
        [EnumMember(Value = "CappingDcOrWiperStepMotorDriverFault")]
        CappingDcOrWiperStepMotorDriverFault = 2,

        /// <summary>
        /// Enum CappingMotorOrHomePhotoFault for value: CappingMotorOrHomePhotoFault
        /// </summary>
        [EnumMember(Value = "CappingMotorOrHomePhotoFault")]
        CappingMotorOrHomePhotoFault = 3,

        /// <summary>
        /// Enum WiperMotorOrHomePhotoFault for value: WiperMotorOrHomePhotoFault
        /// </summary>
        [EnumMember(Value = "WiperMotorOrHomePhotoFault")]
        WiperMotorOrHomePhotoFault = 4,

        /// <summary>
        /// Enum CappingVacuumTooLowFault for value: CappingVacuumTooLowFault
        /// </summary>
        [EnumMember(Value = "CappingVacuumTooLowFault")]
        CappingVacuumTooLowFault = 5,

        /// <summary>
        /// Enum CappingVacuumTooHighFault for value: CappingVacuumTooHighFault
        /// </summary>
        [EnumMember(Value = "CappingVacuumTooHighFault")]
        CappingVacuumTooHighFault = 6,

        /// <summary>
        /// Enum CappingVacuumSensorFault for value: CappingVacuumSensorFault
        /// </summary>
        [EnumMember(Value = "CappingVacuumSensorFault")]
        CappingVacuumSensorFault = 7
    }

}