/*
 * aida
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
using FileParameter = Aida.Sdk.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Model
{
    /// <summary>
    /// Defines WorkflowSchedulerErrorCodes
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WorkflowSchedulerErrorCodes
    {
        /// <summary>
        /// Enum JobTemplateDoesNotExists for value: JobTemplateDoesNotExists
        /// </summary>
        [EnumMember(Value = "JobTemplateDoesNotExists")]
        JobTemplateDoesNotExists = 1,

        /// <summary>
        /// Enum InvalidDataSourceConfiguration for value: InvalidDataSourceConfiguration
        /// </summary>
        [EnumMember(Value = "InvalidDataSourceConfiguration")]
        InvalidDataSourceConfiguration = 2,

        /// <summary>
        /// Enum WebhooksServerUnreachable for value: WebhooksServerUnreachable
        /// </summary>
        [EnumMember(Value = "WebhooksServerUnreachable")]
        WebhooksServerUnreachable = 3,

        /// <summary>
        /// Enum TransportResetFailed for value: TransportResetFailed
        /// </summary>
        [EnumMember(Value = "TransportResetFailed")]
        TransportResetFailed = 4,

        /// <summary>
        /// Enum FeederEmpty for value: FeederEmpty
        /// </summary>
        [EnumMember(Value = "FeederEmpty")]
        FeederEmpty = 5,

        /// <summary>
        /// Enum InvalidWorkflowTypeName for value: InvalidWorkflowTypeName
        /// </summary>
        [EnumMember(Value = "InvalidWorkflowTypeName")]
        InvalidWorkflowTypeName = 6
    }

}