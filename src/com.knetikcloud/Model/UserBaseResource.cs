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
        public UserBaseResource(string AvatarUrl = default(string), string DisplayName = default(string), string Email = default(string), string Fullname = default(string), string Username = default(string))
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
        /// The date the user last interacted with the API (private)
        /// </summary>
        /// <value>The date the user last interacted with the API (private)</value>
        [DataMember(Name="last_activity", EmitDefaultValue=false)]
        public long? LastActivity { get; private set; }

        /// <summary>
        /// The date the user&#39;s info was last updated as a unix timestamp
        /// </summary>
        /// <value>The date the user&#39;s info was last updated as a unix timestamp</value>
        [DataMember(Name="last_updated", EmitDefaultValue=false)]
        public long? LastUpdated { get; private set; }

        /// <summary>
        /// The user&#39;s date of registration as a unix timestamp
        /// </summary>
        /// <value>The user&#39;s date of registration as a unix timestamp</value>
        [DataMember(Name="member_since", EmitDefaultValue=false)]
        public long? MemberSince { get; private set; }

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
            sb.Append("  LastActivity: ").Append(LastActivity).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("  MemberSince: ").Append(MemberSince).Append("\n");
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
            return this.Equals(input as UserBaseResource);
        }

        /// <summary>
        /// Returns true if UserBaseResource instances are equal
        /// </summary>
        /// <param name="input">Instance of UserBaseResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserBaseResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AvatarUrl == input.AvatarUrl ||
                    (this.AvatarUrl != null &&
                    this.AvatarUrl.Equals(input.AvatarUrl))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Fullname == input.Fullname ||
                    (this.Fullname != null &&
                    this.Fullname.Equals(input.Fullname))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LastActivity == input.LastActivity ||
                    (this.LastActivity != null &&
                    this.LastActivity.Equals(input.LastActivity))
                ) && 
                (
                    this.LastUpdated == input.LastUpdated ||
                    (this.LastUpdated != null &&
                    this.LastUpdated.Equals(input.LastUpdated))
                ) && 
                (
                    this.MemberSince == input.MemberSince ||
                    (this.MemberSince != null &&
                    this.MemberSince.Equals(input.MemberSince))
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
                if (this.AvatarUrl != null)
                    hashCode = hashCode * 59 + this.AvatarUrl.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Fullname != null)
                    hashCode = hashCode * 59 + this.Fullname.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LastActivity != null)
                    hashCode = hashCode * 59 + this.LastActivity.GetHashCode();
                if (this.LastUpdated != null)
                    hashCode = hashCode * 59 + this.LastUpdated.GetHashCode();
                if (this.MemberSince != null)
                    hashCode = hashCode * 59 + this.MemberSince.GetHashCode();
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