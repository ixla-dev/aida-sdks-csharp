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
    /// PenDto
    /// </summary>
    [DataContract(Name = "PenDto")]
    public partial class PenDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PenDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="laserPower">laserPower.</param>
        /// <param name="markSpeed">markSpeed.</param>
        /// <param name="frequency">frequency.</param>
        /// <param name="pulseLength">pulseLength.</param>
        /// <param name="firstPulseLength">firstPulseLength.</param>
        /// <param name="halfPeriod">halfPeriod.</param>
        /// <param name="longDelay">longDelay.</param>
        /// <param name="jumpDelay">jumpDelay.</param>
        /// <param name="markDelay">markDelay.</param>
        /// <param name="polyDelay">polyDelay.</param>
        /// <param name="laserOnDelay">laserOnDelay.</param>
        /// <param name="laserOffDelay">laserOffDelay.</param>
        /// <param name="jumpSpeed">jumpSpeed.</param>
        /// <param name="pixelMap">pixelMap.</param>
        /// <param name="flags">flags.</param>
        public PenDto(int id = default(int), string name = default(string), double? laserPower = default(double?), double? markSpeed = default(double?), double? frequency = default(double?), double? pulseLength = default(double?), double? firstPulseLength = default(double?), double? halfPeriod = default(double?), double? longDelay = default(double?), double? jumpDelay = default(double?), double? markDelay = default(double?), double? polyDelay = default(double?), double? laserOnDelay = default(double?), double? laserOffDelay = default(double?), double? jumpSpeed = default(double?), PixelMapDto pixelMap = default(PixelMapDto), PenFlagsDto flags = default(PenFlagsDto))
        {
            this.Id = id;
            this.Name = name;
            this.LaserPower = laserPower;
            this.MarkSpeed = markSpeed;
            this.Frequency = frequency;
            this.PulseLength = pulseLength;
            this.FirstPulseLength = firstPulseLength;
            this.HalfPeriod = halfPeriod;
            this.LongDelay = longDelay;
            this.JumpDelay = jumpDelay;
            this.MarkDelay = markDelay;
            this.PolyDelay = polyDelay;
            this.LaserOnDelay = laserOnDelay;
            this.LaserOffDelay = laserOffDelay;
            this.JumpSpeed = jumpSpeed;
            this.PixelMap = pixelMap;
            this.Flags = flags;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets LaserPower
        /// </summary>
        [DataMember(Name = "laserPower", EmitDefaultValue = true)]
        public double? LaserPower { get; set; }

        /// <summary>
        /// Gets or Sets MarkSpeed
        /// </summary>
        [DataMember(Name = "markSpeed", EmitDefaultValue = true)]
        public double? MarkSpeed { get; set; }

        /// <summary>
        /// Gets or Sets Frequency
        /// </summary>
        [DataMember(Name = "frequency", EmitDefaultValue = true)]
        public double? Frequency { get; set; }

        /// <summary>
        /// Gets or Sets PulseLength
        /// </summary>
        [DataMember(Name = "pulseLength", EmitDefaultValue = true)]
        public double? PulseLength { get; set; }

        /// <summary>
        /// Gets or Sets FirstPulseLength
        /// </summary>
        [DataMember(Name = "firstPulseLength", EmitDefaultValue = true)]
        public double? FirstPulseLength { get; set; }

        /// <summary>
        /// Gets or Sets HalfPeriod
        /// </summary>
        [DataMember(Name = "halfPeriod", EmitDefaultValue = true)]
        public double? HalfPeriod { get; set; }

        /// <summary>
        /// Gets or Sets LongDelay
        /// </summary>
        [DataMember(Name = "longDelay", EmitDefaultValue = true)]
        public double? LongDelay { get; set; }

        /// <summary>
        /// Gets or Sets JumpDelay
        /// </summary>
        [DataMember(Name = "jumpDelay", EmitDefaultValue = true)]
        public double? JumpDelay { get; set; }

        /// <summary>
        /// Gets or Sets MarkDelay
        /// </summary>
        [DataMember(Name = "markDelay", EmitDefaultValue = true)]
        public double? MarkDelay { get; set; }

        /// <summary>
        /// Gets or Sets PolyDelay
        /// </summary>
        [DataMember(Name = "polyDelay", EmitDefaultValue = true)]
        public double? PolyDelay { get; set; }

        /// <summary>
        /// Gets or Sets LaserOnDelay
        /// </summary>
        [DataMember(Name = "laserOnDelay", EmitDefaultValue = true)]
        public double? LaserOnDelay { get; set; }

        /// <summary>
        /// Gets or Sets LaserOffDelay
        /// </summary>
        [DataMember(Name = "laserOffDelay", EmitDefaultValue = true)]
        public double? LaserOffDelay { get; set; }

        /// <summary>
        /// Gets or Sets JumpSpeed
        /// </summary>
        [DataMember(Name = "jumpSpeed", EmitDefaultValue = true)]
        public double? JumpSpeed { get; set; }

        /// <summary>
        /// Gets or Sets PixelMap
        /// </summary>
        [DataMember(Name = "pixelMap", EmitDefaultValue = false)]
        public PixelMapDto PixelMap { get; set; }

        /// <summary>
        /// Gets or Sets Flags
        /// </summary>
        [DataMember(Name = "flags", EmitDefaultValue = false)]
        public PenFlagsDto Flags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PenDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LaserPower: ").Append(LaserPower).Append("\n");
            sb.Append("  MarkSpeed: ").Append(MarkSpeed).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  PulseLength: ").Append(PulseLength).Append("\n");
            sb.Append("  FirstPulseLength: ").Append(FirstPulseLength).Append("\n");
            sb.Append("  HalfPeriod: ").Append(HalfPeriod).Append("\n");
            sb.Append("  LongDelay: ").Append(LongDelay).Append("\n");
            sb.Append("  JumpDelay: ").Append(JumpDelay).Append("\n");
            sb.Append("  MarkDelay: ").Append(MarkDelay).Append("\n");
            sb.Append("  PolyDelay: ").Append(PolyDelay).Append("\n");
            sb.Append("  LaserOnDelay: ").Append(LaserOnDelay).Append("\n");
            sb.Append("  LaserOffDelay: ").Append(LaserOffDelay).Append("\n");
            sb.Append("  JumpSpeed: ").Append(JumpSpeed).Append("\n");
            sb.Append("  PixelMap: ").Append(PixelMap).Append("\n");
            sb.Append("  Flags: ").Append(Flags).Append("\n");
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
