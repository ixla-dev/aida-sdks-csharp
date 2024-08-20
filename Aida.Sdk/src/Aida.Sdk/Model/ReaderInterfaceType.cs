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
    /// Defines ReaderInterfaceType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReaderInterfaceType
    {
        /// <summary>
        /// Enum Contact for value: Contact
        /// </summary>
        [EnumMember(Value = "Contact")]
        Contact = 1,

        /// <summary>
        /// Enum Contactless for value: Contactless
        /// </summary>
        [EnumMember(Value = "Contactless")]
        Contactless = 2
    }

}
