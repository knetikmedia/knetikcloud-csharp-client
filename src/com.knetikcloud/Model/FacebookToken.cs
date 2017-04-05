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
    /// FacebookToken
    /// </summary>
    [DataContract]
    public partial class FacebookToken :  IEquatable<FacebookToken>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FacebookToken" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FacebookToken() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FacebookToken" /> class.
        /// </summary>
        /// <param name="AccessToken">A valid access token from facebook. See facebook documention for how to obtain one. (required).</param>
        public FacebookToken(string AccessToken = default(string))
        {
            // to ensure "AccessToken" is required (not null)
            if (AccessToken == null)
            {
                throw new InvalidDataException("AccessToken is a required property for FacebookToken and cannot be null");
            }
            else
            {
                this.AccessToken = AccessToken;
            }
        }
        
        /// <summary>
        /// A valid access token from facebook. See facebook documention for how to obtain one.
        /// </summary>
        /// <value>A valid access token from facebook. See facebook documention for how to obtain one.</value>
        [DataMember(Name="access_token", EmitDefaultValue=false)]
        public string AccessToken { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FacebookToken {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
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
            return this.Equals(obj as FacebookToken);
        }

        /// <summary>
        /// Returns true if FacebookToken instances are equal
        /// </summary>
        /// <param name="other">Instance of FacebookToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FacebookToken other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccessToken == other.AccessToken ||
                    this.AccessToken != null &&
                    this.AccessToken.Equals(other.AccessToken)
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
                if (this.AccessToken != null)
                    hash = hash * 59 + this.AccessToken.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
