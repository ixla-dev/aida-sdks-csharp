/*
 * aida-mini
 *
 * 1.0.700.1
 *
 * The version of the OpenAPI document: 1.0.700.1
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
    /// Defines MessageType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MessageType
    {
        /// <summary>
        /// Enum Unknown for value: Unknown
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum EncoderLoaded for value: EncoderLoaded
        /// </summary>
        [EnumMember(Value = "EncoderLoaded")]
        EncoderLoaded,

        /// <summary>
        /// Enum OcrExecuted for value: OcrExecuted
        /// </summary>
        [EnumMember(Value = "OcrExecuted")]
        OcrExecuted,

        /// <summary>
        /// Enum WorkflowStarted for value: WorkflowStarted
        /// </summary>
        [EnumMember(Value = "WorkflowStarted")]
        WorkflowStarted,

        /// <summary>
        /// Enum WorkflowCompleted for value: WorkflowCompleted
        /// </summary>
        [EnumMember(Value = "WorkflowCompleted")]
        WorkflowCompleted,

        /// <summary>
        /// Enum WorkflowFaulted for value: WorkflowFaulted
        /// </summary>
        [EnumMember(Value = "WorkflowFaulted")]
        WorkflowFaulted,

        /// <summary>
        /// Enum WorkflowCancelled for value: WorkflowCancelled
        /// </summary>
        [EnumMember(Value = "WorkflowCancelled")]
        WorkflowCancelled,

        /// <summary>
        /// Enum FeederEmpty for value: FeederEmpty
        /// </summary>
        [EnumMember(Value = "FeederEmpty")]
        FeederEmpty,

        /// <summary>
        /// Enum WorkflowSchedulerStarted for value: WorkflowSchedulerStarted
        /// </summary>
        [EnumMember(Value = "WorkflowSchedulerStarted")]
        WorkflowSchedulerStarted,

        /// <summary>
        /// Enum WorkflowSchedulerStopped for value: WorkflowSchedulerStopped
        /// </summary>
        [EnumMember(Value = "WorkflowSchedulerStopped")]
        WorkflowSchedulerStopped,

        /// <summary>
        /// Enum WorkflowSchedulerSuspended for value: WorkflowSchedulerSuspended
        /// </summary>
        [EnumMember(Value = "WorkflowSchedulerSuspended")]
        WorkflowSchedulerSuspended,

        /// <summary>
        /// Enum HealthCheck for value: HealthCheck
        /// </summary>
        [EnumMember(Value = "HealthCheck")]
        HealthCheck,

        /// <summary>
        /// Enum MagneticStripeReadBack for value: MagneticStripeReadBack
        /// </summary>
        [EnumMember(Value = "MagneticStripeReadBack")]
        MagneticStripeReadBack,

        /// <summary>
        /// Enum OcrReadBack for value: OcrReadBack
        /// </summary>
        [EnumMember(Value = "OcrReadBack")]
        OcrReadBack,

        /// <summary>
        /// Enum ChipReadBack for value: ChipReadBack
        /// </summary>
        [EnumMember(Value = "ChipReadBack")]
        ChipReadBack,

        /// <summary>
        /// Enum BarcodeReadBack for value: BarcodeReadBack
        /// </summary>
        [EnumMember(Value = "BarcodeReadBack")]
        BarcodeReadBack
    }

}
