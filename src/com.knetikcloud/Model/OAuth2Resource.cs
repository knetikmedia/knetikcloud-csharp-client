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
    /// OAuth2Resource
    /// </summary>
    [DataContract]
    public partial class OAuth2Resource :  IEquatable<OAuth2Resource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth2Resource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public OAuth2Resource()
        {
        }
        
        /// <summary>
        /// The access token issued by the authorization server
        /// </summary>
        /// <value>The access token issued by the authorization server</value>
        [DataMember(Name="access_token", EmitDefaultValue=false)]
        public string AccessToken { get; private set; }

        /// <summary>
        /// The lifetime in seconds of the access token
        /// </summary>
        /// <value>The lifetime in seconds of the access token</value>
        [DataMember(Name="expires_in", EmitDefaultValue=false)]
        public string ExpiresIn { get; private set; }

        /// <summary>
        /// The refresh token issued by the authorization server
        /// </summary>
        /// <value>The refresh token issued by the authorization server</value>
        [DataMember(Name="refresh_token", EmitDefaultValue=false)]
        public string RefreshToken { get; private set; }

        /// <summary>
        /// The scope of the access token. Currently these values can be ignored, as security defaults to roles and permissions
        /// </summary>
        /// <value>The scope of the access token. Currently these values can be ignored, as security defaults to roles and permissions</value>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public string Scope { get; private set; }

        /// <summary>
        /// The type of the token issued
        /// </summary>
        /// <value>The type of the token issued</value>
        [DataMember(Name="token_type", EmitDefaultValue=false)]
        public string TokenType { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OAuth2Resource {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
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
            return this.Equals(input as OAuth2Resource);
        }

        /// <summary>
        /// Returns true if OAuth2Resource instances are equal
        /// </summary>
        /// <param name="input">Instance of OAuth2Resource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OAuth2Resource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessToken == input.AccessToken ||
                    (this.AccessToken != null &&
                    this.AccessToken.Equals(input.AccessToken))
                ) && 
                (
                    this.ExpiresIn == input.ExpiresIn ||
                    (this.ExpiresIn != null &&
                    this.ExpiresIn.Equals(input.ExpiresIn))
                ) && 
                (
                    this.RefreshToken == input.RefreshToken ||
                    (this.RefreshToken != null &&
                    this.RefreshToken.Equals(input.RefreshToken))
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.TokenType == input.TokenType ||
                    (this.TokenType != null &&
                    this.TokenType.Equals(input.TokenType))
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
                if (this.AccessToken != null)
                    hashCode = hashCode * 59 + this.AccessToken.GetHashCode();
                if (this.ExpiresIn != null)
                    hashCode = hashCode * 59 + this.ExpiresIn.GetHashCode();
                if (this.RefreshToken != null)
                    hashCode = hashCode * 59 + this.RefreshToken.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.TokenType != null)
                    hashCode = hashCode * 59 + this.TokenType.GetHashCode();
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
