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
    /// A request to reset a user&#39;s password by using a known user property
    /// </summary>
    [DataContract]
    public partial class PasswordResetRequest :  IEquatable<PasswordResetRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordResetRequest" /> class.
        /// </summary>
        /// <param name="Email">The user&#39;s email address.</param>
        /// <param name="MobileNumber">The user&#39;s mobile phone number.</param>
        /// <param name="Username">The user&#39;s username.</param>
        public PasswordResetRequest(string Email = default(string), string MobileNumber = default(string), string Username = default(string))
        {
            this.Email = Email;
            this.MobileNumber = MobileNumber;
            this.Username = Username;
        }
        
        /// <summary>
        /// The user&#39;s email address
        /// </summary>
        /// <value>The user&#39;s email address</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// The user&#39;s mobile phone number
        /// </summary>
        /// <value>The user&#39;s mobile phone number</value>
        [DataMember(Name="mobile_number", EmitDefaultValue=false)]
        public string MobileNumber { get; set; }

        /// <summary>
        /// The user&#39;s username
        /// </summary>
        /// <value>The user&#39;s username</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PasswordResetRequest {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  MobileNumber: ").Append(MobileNumber).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
            return this.Equals(input as PasswordResetRequest);
        }

        /// <summary>
        /// Returns true if PasswordResetRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PasswordResetRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PasswordResetRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.MobileNumber == input.MobileNumber ||
                    (this.MobileNumber != null &&
                    this.MobileNumber.Equals(input.MobileNumber))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.MobileNumber != null)
                    hashCode = hashCode * 59 + this.MobileNumber.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
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
