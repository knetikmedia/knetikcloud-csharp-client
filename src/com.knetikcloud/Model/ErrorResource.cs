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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ErrorResource);
        }

        /// <summary>
        /// Returns true if ErrorResource instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
                ) && 
                (
                    this.Field == input.Field ||
                    (this.Field != null &&
                    this.Field.Equals(input.Field))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.Field != null)
                    hashCode = hashCode * 59 + this.Field.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
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
