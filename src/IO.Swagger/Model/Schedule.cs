/* 
 * Knetik Platform API Documentation latest 
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://demo.sandbox.knetikcloud.com
 *
 * OpenAPI spec version: latest 
 * Contact: support@knetik.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Schedule
    /// </summary>
    [DataContract]
    public partial class Schedule :  IEquatable<Schedule>, IValidatableObject
    {
        /// <summary>
        /// The unit of time for the duration field
        /// </summary>
        /// <value>The unit of time for the duration field</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DurationUnitEnum
        {
            
            /// <summary>
            /// Enum Millisecond for "millisecond"
            /// </summary>
            [EnumMember(Value = "millisecond")]
            Millisecond,
            
            /// <summary>
            /// Enum Second for "second"
            /// </summary>
            [EnumMember(Value = "second")]
            Second,
            
            /// <summary>
            /// Enum Minute for "minute"
            /// </summary>
            [EnumMember(Value = "minute")]
            Minute,
            
            /// <summary>
            /// Enum Hour for "hour"
            /// </summary>
            [EnumMember(Value = "hour")]
            Hour,
            
            /// <summary>
            /// Enum Day for "day"
            /// </summary>
            [EnumMember(Value = "day")]
            Day,
            
            /// <summary>
            /// Enum Week for "week"
            /// </summary>
            [EnumMember(Value = "week")]
            Week,
            
            /// <summary>
            /// Enum Month for "month"
            /// </summary>
            [EnumMember(Value = "month")]
            Month,
            
            /// <summary>
            /// Enum Year for "year"
            /// </summary>
            [EnumMember(Value = "year")]
            Year
        }

        /// <summary>
        /// How often the event is scheduled
        /// </summary>
        /// <value>How often the event is scheduled</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RepeatEnum
        {
            
            /// <summary>
            /// Enum DAILY for "DAILY"
            /// </summary>
            [EnumMember(Value = "DAILY")]
            DAILY,
            
            /// <summary>
            /// Enum WEEKLY for "WEEKLY"
            /// </summary>
            [EnumMember(Value = "WEEKLY")]
            WEEKLY
        }

        /// <summary>
        /// The unit of time for the duration field
        /// </summary>
        /// <value>The unit of time for the duration field</value>
        [DataMember(Name="duration_unit", EmitDefaultValue=false)]
        public DurationUnitEnum? DurationUnit { get; set; }
        /// <summary>
        /// How often the event is scheduled
        /// </summary>
        /// <value>How often the event is scheduled</value>
        [DataMember(Name="repeat", EmitDefaultValue=false)]
        public RepeatEnum? Repeat { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Schedule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Schedule() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Schedule" /> class.
        /// </summary>
        /// <param name="Duration">The duration of the repeatable events (required).</param>
        /// <param name="DurationUnit">The unit of time for the duration field (required).</param>
        /// <param name="Repeat">How often the event is scheduled (required).</param>
        public Schedule(int? Duration = default(int?), DurationUnitEnum? DurationUnit = default(DurationUnitEnum?), RepeatEnum? Repeat = default(RepeatEnum?))
        {
            // to ensure "Duration" is required (not null)
            if (Duration == null)
            {
                throw new InvalidDataException("Duration is a required property for Schedule and cannot be null");
            }
            else
            {
                this.Duration = Duration;
            }
            // to ensure "DurationUnit" is required (not null)
            if (DurationUnit == null)
            {
                throw new InvalidDataException("DurationUnit is a required property for Schedule and cannot be null");
            }
            else
            {
                this.DurationUnit = DurationUnit;
            }
            // to ensure "Repeat" is required (not null)
            if (Repeat == null)
            {
                throw new InvalidDataException("Repeat is a required property for Schedule and cannot be null");
            }
            else
            {
                this.Repeat = Repeat;
            }
        }
        
        /// <summary>
        /// The duration of the repeatable events
        /// </summary>
        /// <value>The duration of the repeatable events</value>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public int? Duration { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Schedule {\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  DurationUnit: ").Append(DurationUnit).Append("\n");
            sb.Append("  Repeat: ").Append(Repeat).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Schedule);
        }

        /// <summary>
        /// Returns true if Schedule instances are equal
        /// </summary>
        /// <param name="other">Instance of Schedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Schedule other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Duration == other.Duration ||
                    this.Duration != null &&
                    this.Duration.Equals(other.Duration)
                ) && 
                (
                    this.DurationUnit == other.DurationUnit ||
                    this.DurationUnit != null &&
                    this.DurationUnit.Equals(other.DurationUnit)
                ) && 
                (
                    this.Repeat == other.Repeat ||
                    this.Repeat != null &&
                    this.Repeat.Equals(other.Repeat)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Duration != null)
                    hash = hash * 59 + this.Duration.GetHashCode();
                if (this.DurationUnit != null)
                    hash = hash * 59 + this.DurationUnit.GetHashCode();
                if (this.Repeat != null)
                    hash = hash * 59 + this.Repeat.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}