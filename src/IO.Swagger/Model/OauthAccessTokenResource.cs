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
    /// OauthAccessTokenResource
    /// </summary>
    [DataContract]
    public partial class OauthAccessTokenResource :  IEquatable<OauthAccessTokenResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OauthAccessTokenResource" /> class.
        /// </summary>
        /// <param name="ClientId">The key of the client assosciated with the token.</param>
        /// <param name="Token">The token.  Not shown in list view.</param>
        /// <param name="Username">The username of the user associated with the token.</param>
        public OauthAccessTokenResource(string ClientId = default(string), string Token = default(string), string Username = default(string))
        {
            this.ClientId = ClientId;
            this.Token = Token;
            this.Username = Username;
        }
        
        /// <summary>
        /// The key of the client assosciated with the token
        /// </summary>
        /// <value>The key of the client assosciated with the token</value>
        [DataMember(Name="client_id", EmitDefaultValue=false)]
        public string ClientId { get; set; }
        /// <summary>
        /// The token.  Not shown in list view
        /// </summary>
        /// <value>The token.  Not shown in list view</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }
        /// <summary>
        /// The username of the user associated with the token
        /// </summary>
        /// <value>The username of the user associated with the token</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OauthAccessTokenResource {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as OauthAccessTokenResource);
        }

        /// <summary>
        /// Returns true if OauthAccessTokenResource instances are equal
        /// </summary>
        /// <param name="other">Instance of OauthAccessTokenResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OauthAccessTokenResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ClientId == other.ClientId ||
                    this.ClientId != null &&
                    this.ClientId.Equals(other.ClientId)
                ) && 
                (
                    this.Token == other.Token ||
                    this.Token != null &&
                    this.Token.Equals(other.Token)
                ) && 
                (
                    this.Username == other.Username ||
                    this.Username != null &&
                    this.Username.Equals(other.Username)
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
                if (this.ClientId != null)
                    hash = hash * 59 + this.ClientId.GetHashCode();
                if (this.Token != null)
                    hash = hash * 59 + this.Token.GetHashCode();
                if (this.Username != null)
                    hash = hash * 59 + this.Username.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
