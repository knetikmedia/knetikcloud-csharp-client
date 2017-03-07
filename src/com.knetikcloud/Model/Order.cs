/* 
 * Knetik Platform API Documentation latest 
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://knetikcloud.com
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

namespace com.knetikcloud.Model
{
    /// <summary>
    /// Order
    /// </summary>
    [DataContract]
    public partial class Order :  IEquatable<Order>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DirectionEnum
        {
            
            /// <summary>
            /// Enum ASC for "ASC"
            /// </summary>
            [EnumMember(Value = "ASC")]
            ASC,
            
            /// <summary>
            /// Enum DESC for "DESC"
            /// </summary>
            [EnumMember(Value = "DESC")]
            DESC
        }

        /// <summary>
        /// Gets or Sets NullHandling
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NullHandlingEnum
        {
            
            /// <summary>
            /// Enum NATIVE for "NATIVE"
            /// </summary>
            [EnumMember(Value = "NATIVE")]
            NATIVE,
            
            /// <summary>
            /// Enum NULLSFIRST for "NULLS_FIRST"
            /// </summary>
            [EnumMember(Value = "NULLS_FIRST")]
            NULLSFIRST,
            
            /// <summary>
            /// Enum NULLSLAST for "NULLS_LAST"
            /// </summary>
            [EnumMember(Value = "NULLS_LAST")]
            NULLSLAST
        }

        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public DirectionEnum? Direction { get; set; }
        /// <summary>
        /// Gets or Sets NullHandling
        /// </summary>
        [DataMember(Name="null_handling", EmitDefaultValue=false)]
        public NullHandlingEnum? NullHandling { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Order" /> class.
        /// </summary>
        /// <param name="Ascending">Ascending.</param>
        /// <param name="Direction">Direction.</param>
        /// <param name="IgnoreCase">IgnoreCase.</param>
        /// <param name="NullHandling">NullHandling.</param>
        /// <param name="Property">Property.</param>
        public Order(bool? Ascending = default(bool?), DirectionEnum? Direction = default(DirectionEnum?), bool? IgnoreCase = default(bool?), NullHandlingEnum? NullHandling = default(NullHandlingEnum?), string Property = default(string))
        {
            this.Ascending = Ascending;
            this.Direction = Direction;
            this.IgnoreCase = IgnoreCase;
            this.NullHandling = NullHandling;
            this.Property = Property;
        }
        
        /// <summary>
        /// Gets or Sets Ascending
        /// </summary>
        [DataMember(Name="ascending", EmitDefaultValue=false)]
        public bool? Ascending { get; set; }
        /// <summary>
        /// Gets or Sets IgnoreCase
        /// </summary>
        [DataMember(Name="ignore_case", EmitDefaultValue=false)]
        public bool? IgnoreCase { get; set; }
        /// <summary>
        /// Gets or Sets Property
        /// </summary>
        [DataMember(Name="property", EmitDefaultValue=false)]
        public string Property { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Order {\n");
            sb.Append("  Ascending: ").Append(Ascending).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  IgnoreCase: ").Append(IgnoreCase).Append("\n");
            sb.Append("  NullHandling: ").Append(NullHandling).Append("\n");
            sb.Append("  Property: ").Append(Property).Append("\n");
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
            return this.Equals(obj as Order);
        }

        /// <summary>
        /// Returns true if Order instances are equal
        /// </summary>
        /// <param name="other">Instance of Order to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Order other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Ascending == other.Ascending ||
                    this.Ascending != null &&
                    this.Ascending.Equals(other.Ascending)
                ) && 
                (
                    this.Direction == other.Direction ||
                    this.Direction != null &&
                    this.Direction.Equals(other.Direction)
                ) && 
                (
                    this.IgnoreCase == other.IgnoreCase ||
                    this.IgnoreCase != null &&
                    this.IgnoreCase.Equals(other.IgnoreCase)
                ) && 
                (
                    this.NullHandling == other.NullHandling ||
                    this.NullHandling != null &&
                    this.NullHandling.Equals(other.NullHandling)
                ) && 
                (
                    this.Property == other.Property ||
                    this.Property != null &&
                    this.Property.Equals(other.Property)
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
                if (this.Ascending != null)
                    hash = hash * 59 + this.Ascending.GetHashCode();
                if (this.Direction != null)
                    hash = hash * 59 + this.Direction.GetHashCode();
                if (this.IgnoreCase != null)
                    hash = hash * 59 + this.IgnoreCase.GetHashCode();
                if (this.NullHandling != null)
                    hash = hash * 59 + this.NullHandling.GetHashCode();
                if (this.Property != null)
                    hash = hash * 59 + this.Property.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
