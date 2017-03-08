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
    /// LocationLogResource
    /// </summary>
    [DataContract]
    public partial class LocationLogResource :  IEquatable<LocationLogResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationLogResource" /> class.
        /// </summary>
        /// <param name="Country">Country.</param>
        /// <param name="Ip">Ip.</param>
        /// <param name="Time">Time.</param>
        public LocationLogResource(string Country = default(string), string Ip = default(string), long? Time = default(long?))
        {
            this.Country = Country;
            this.Ip = Ip;
            this.Time = Time;
        }
        
        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }
        /// <summary>
        /// Gets or Sets Ip
        /// </summary>
        [DataMember(Name="ip", EmitDefaultValue=false)]
        public string Ip { get; set; }
        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public long? Time { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LocationLogResource {\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
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
            return this.Equals(obj as LocationLogResource);
        }

        /// <summary>
        /// Returns true if LocationLogResource instances are equal
        /// </summary>
        /// <param name="other">Instance of LocationLogResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocationLogResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.Ip == other.Ip ||
                    this.Ip != null &&
                    this.Ip.Equals(other.Ip)
                ) && 
                (
                    this.Time == other.Time ||
                    this.Time != null &&
                    this.Time.Equals(other.Time)
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
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.Ip != null)
                    hash = hash * 59 + this.Ip.GetHashCode();
                if (this.Time != null)
                    hash = hash * 59 + this.Time.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
