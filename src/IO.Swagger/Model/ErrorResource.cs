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

namespace IO.Swagger.Model
{
    /// <summary>
    /// ErrorResource
    /// </summary>
    [DataContract]
    public partial class ErrorResource :  IEquatable<ErrorResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResource" /> class.
        /// </summary>
        /// <param name="Details">Extra details about the error, if needed.</param>
        /// <param name="Field">The JSON key the message pertains to.</param>
        public ErrorResource(Object Details = default(Object), Object Field = default(Object))
        {
            this.Details = Details;
            this.Field = Field;
        }
        
        /// <summary>
        /// Extra details about the error, if needed
        /// </summary>
        /// <value>Extra details about the error, if needed</value>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public Object Details { get; set; }
        /// <summary>
        /// The JSON key the message pertains to
        /// </summary>
        /// <value>The JSON key the message pertains to</value>
        [DataMember(Name="field", EmitDefaultValue=false)]
        public Object Field { get; set; }
        /// <summary>
        /// The message explaining the error
        /// </summary>
        /// <value>The message explaining the error</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorResource {\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(obj as ErrorResource);
        }

        /// <summary>
        /// Returns true if ErrorResource instances are equal
        /// </summary>
        /// <param name="other">Instance of ErrorResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Details == other.Details ||
                    this.Details != null &&
                    this.Details.Equals(other.Details)
                ) && 
                (
                    this.Field == other.Field ||
                    this.Field != null &&
                    this.Field.Equals(other.Field)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
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
                if (this.Details != null)
                    hash = hash * 59 + this.Details.GetHashCode();
                if (this.Field != null)
                    hash = hash * 59 + this.Field.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
