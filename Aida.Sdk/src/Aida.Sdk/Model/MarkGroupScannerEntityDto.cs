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
    /// MarkGroupScannerEntityDto
    /// </summary>
    [DataContract(Name = "MarkGroupScannerEntityDto")]
    public partial class MarkGroupScannerEntityDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkGroupScannerEntityDto" /> class.
        /// </summary>
        /// <param name="index">index.</param>
        /// <param name="entityId">entityId.</param>
        /// <param name="markGroupId">markGroupId.</param>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="positionId">positionId.</param>
        /// <param name="supportSide">supportSide.</param>
        /// <param name="entity">entity.</param>
        public MarkGroupScannerEntityDto(int index = default(int), int entityId = default(int), int markGroupId = default(int), string deviceId = default(string), string positionId = default(string), string supportSide = default(string), ScannerEntityDto entity = default(ScannerEntityDto))
        {
            this.Index = index;
            this.EntityId = entityId;
            this.MarkGroupId = markGroupId;
            this.DeviceId = deviceId;
            this.PositionId = positionId;
            this.SupportSide = supportSide;
            this.Entity = entity;
        }

        /// <summary>
        /// Gets or Sets Index
        /// </summary>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public int Index { get; set; }

        /// <summary>
        /// Gets or Sets EntityId
        /// </summary>
        [DataMember(Name = "entityId", EmitDefaultValue = false)]
        public int EntityId { get; set; }

        /// <summary>
        /// Gets or Sets MarkGroupId
        /// </summary>
        [DataMember(Name = "markGroupId", EmitDefaultValue = false)]
        public int MarkGroupId { get; set; }

        /// <summary>
        /// Gets or Sets DeviceId
        /// </summary>
        [DataMember(Name = "deviceId", EmitDefaultValue = true)]
        public string DeviceId { get; set; }

        /// <summary>
        /// Gets or Sets PositionId
        /// </summary>
        [DataMember(Name = "positionId", EmitDefaultValue = true)]
        public string PositionId { get; set; }

        /// <summary>
        /// Gets or Sets SupportSide
        /// </summary>
        [DataMember(Name = "supportSide", EmitDefaultValue = true)]
        public string SupportSide { get; set; }

        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name = "entity", EmitDefaultValue = false)]
        public ScannerEntityDto Entity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MarkGroupScannerEntityDto {\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  MarkGroupId: ").Append(MarkGroupId).Append("\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  PositionId: ").Append(PositionId).Append("\n");
            sb.Append("  SupportSide: ").Append(SupportSide).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
