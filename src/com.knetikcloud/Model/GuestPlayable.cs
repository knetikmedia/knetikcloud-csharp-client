/* 
 * Knetik Platform API Documentation latest 
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://knetikcloud.com.
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
using SwaggerDateConverter = com.knetikcloud.Client.SwaggerDateConverter;

namespace com.knetikcloud.Model
{
    /// <summary>
    /// GuestPlayable
    /// </summary>
    [DataContract]
    public partial class GuestPlayable : Behavior,  IEquatable<GuestPlayable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GuestPlayable" /> class.
        /// </summary>
        /// <param name="Description">Description.</param>
        /// <param name="TypeHint">Used for polymorphic type recognition and thus must match an expected type with additional properties.</param>
        /// <param name="Allowed">Whether guests are allowed to use items.</param>
        /// <param name="Leaderboard">Whether guests are allowed on the leaderboard.</param>
        public GuestPlayable(string Description = default(string), string TypeHint = default(string), bool? Allowed = default(bool?), bool? Leaderboard = default(bool?))
        {
            this.Description = Description;
            this.TypeHint = TypeHint;
            this.Allowed = Allowed;
            this.Leaderboard = Leaderboard;
        }
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Used for polymorphic type recognition and thus must match an expected type with additional properties
        /// </summary>
        /// <value>Used for polymorphic type recognition and thus must match an expected type with additional properties</value>
        [DataMember(Name="type_hint", EmitDefaultValue=false)]
        public string TypeHint { get; set; }

        /// <summary>
        /// Whether guests are allowed to use items
        /// </summary>
        /// <value>Whether guests are allowed to use items</value>
        [DataMember(Name="allowed", EmitDefaultValue=false)]
        public bool? Allowed { get; set; }

        /// <summary>
        /// Whether guests are allowed on the leaderboard
        /// </summary>
        /// <value>Whether guests are allowed on the leaderboard</value>
        [DataMember(Name="leaderboard", EmitDefaultValue=false)]
        public bool? Leaderboard { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GuestPlayable {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  TypeHint: ").Append(TypeHint).Append("\n");
            sb.Append("  Allowed: ").Append(Allowed).Append("\n");
            sb.Append("  Leaderboard: ").Append(Leaderboard).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GuestPlayable);
        }

        /// <summary>
        /// Returns true if GuestPlayable instances are equal
        /// </summary>
        /// <param name="input">Instance of GuestPlayable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GuestPlayable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.TypeHint == input.TypeHint ||
                    (this.TypeHint != null &&
                    this.TypeHint.Equals(input.TypeHint))
                ) && 
                (
                    this.Allowed == input.Allowed ||
                    (this.Allowed != null &&
                    this.Allowed.Equals(input.Allowed))
                ) && 
                (
                    this.Leaderboard == input.Leaderboard ||
                    (this.Leaderboard != null &&
                    this.Leaderboard.Equals(input.Leaderboard))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.TypeHint != null)
                    hashCode = hashCode * 59 + this.TypeHint.GetHashCode();
                if (this.Allowed != null)
                    hashCode = hashCode * 59 + this.Allowed.GetHashCode();
                if (this.Leaderboard != null)
                    hashCode = hashCode * 59 + this.Leaderboard.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}