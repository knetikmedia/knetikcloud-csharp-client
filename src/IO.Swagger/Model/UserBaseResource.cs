/* 
 * Knetik Platform API Documentation Latest
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://demo.sandbox.knetikcloud.com
 *
 * OpenAPI spec version: Latest
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
    /// UserBaseResource
    /// </summary>
    [DataContract]
    public partial class UserBaseResource :  IEquatable<UserBaseResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserBaseResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserBaseResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserBaseResource" /> class.
        /// </summary>
        /// <param name="AvatarUrl">The url of the user&#39;s avatar image.</param>
        /// <param name="DisplayName">The chosen display name of the user, defaults to username if not present.</param>
        /// <param name="Email">The user&#39;s email address (private). May be required and/or unique depending on system configuration (both on by default). Must match standard email requirements if provided (RFC 2822) (required).</param>
        /// <param name="Fullname">The user&#39;s full name (private).</param>
        /// <param name="Username">The login username for the user (private). May be set to match email if system does not require usernames separately. (required).</param>
        public UserBaseResource(string AvatarUrl = null, string DisplayName = null, string Email = null, string Fullname = null, string Username = null)
        {
            // to ensure "Email" is required (not null)
            if (Email == null)
            {
                throw new InvalidDataException("Email is a required property for UserBaseResource and cannot be null");
            }
            else
            {
                this.Email = Email;
            }
            // to ensure "Username" is required (not null)
            if (Username == null)
            {
                throw new InvalidDataException("Username is a required property for UserBaseResource and cannot be null");
            }
            else
            {
                this.Username = Username;
            }
            this.AvatarUrl = AvatarUrl;
            this.DisplayName = DisplayName;
            this.Fullname = Fullname;
        }
        
        /// <summary>
        /// The url of the user&#39;s avatar image
        /// </summary>
        /// <value>The url of the user&#39;s avatar image</value>
        [DataMember(Name="avatar_url", EmitDefaultValue=false)]
        public string AvatarUrl { get; set; }
        /// <summary>
        /// The chosen display name of the user, defaults to username if not present
        /// </summary>
        /// <value>The chosen display name of the user, defaults to username if not present</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }
        /// <summary>
        /// The user&#39;s email address (private). May be required and/or unique depending on system configuration (both on by default). Must match standard email requirements if provided (RFC 2822)
        /// </summary>
        /// <value>The user&#39;s email address (private). May be required and/or unique depending on system configuration (both on by default). Must match standard email requirements if provided (RFC 2822)</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// The user&#39;s full name (private)
        /// </summary>
        /// <value>The user&#39;s full name (private)</value>
        [DataMember(Name="fullname", EmitDefaultValue=false)]
        public string Fullname { get; set; }
        /// <summary>
        /// The id of the user
        /// </summary>
        /// <value>The id of the user</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
        /// <summary>
        /// The login username for the user (private). May be set to match email if system does not require usernames separately.
        /// </summary>
        /// <value>The login username for the user (private). May be set to match email if system does not require usernames separately.</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserBaseResource {\n");
            sb.Append("  AvatarUrl: ").Append(AvatarUrl).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Fullname: ").Append(Fullname).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(obj as UserBaseResource);
        }

        /// <summary>
        /// Returns true if UserBaseResource instances are equal
        /// </summary>
        /// <param name="other">Instance of UserBaseResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserBaseResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AvatarUrl == other.AvatarUrl ||
                    this.AvatarUrl != null &&
                    this.AvatarUrl.Equals(other.AvatarUrl)
                ) && 
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Fullname == other.Fullname ||
                    this.Fullname != null &&
                    this.Fullname.Equals(other.Fullname)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                if (this.AvatarUrl != null)
                    hash = hash * 59 + this.AvatarUrl.GetHashCode();
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Fullname != null)
                    hash = hash * 59 + this.Fullname.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
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