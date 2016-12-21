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
    /// UserRelationshipReferenceResource
    /// </summary>
    [DataContract]
    public partial class UserRelationshipReferenceResource :  IEquatable<UserRelationshipReferenceResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRelationshipReferenceResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserRelationshipReferenceResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRelationshipReferenceResource" /> class.
        /// </summary>
        /// <param name="AvatarUrl">The url of the user&#39;s avatar image.</param>
        /// <param name="Context">The context of the relationship.</param>
        /// <param name="DisplayName">The public username of the user.</param>
        /// <param name="Id">The id of the user (required).</param>
        /// <param name="RelationshipId">The id of the relationship.</param>
        /// <param name="Username">The username of the user.</param>
        public UserRelationshipReferenceResource(string AvatarUrl = null, string Context = null, string DisplayName = null, int? Id = null, long? RelationshipId = null, string Username = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for UserRelationshipReferenceResource and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            this.AvatarUrl = AvatarUrl;
            this.Context = Context;
            this.DisplayName = DisplayName;
            this.RelationshipId = RelationshipId;
            this.Username = Username;
        }
        
        /// <summary>
        /// The url of the user&#39;s avatar image
        /// </summary>
        /// <value>The url of the user&#39;s avatar image</value>
        [DataMember(Name="avatar_url", EmitDefaultValue=false)]
        public string AvatarUrl { get; set; }
        /// <summary>
        /// The context of the relationship
        /// </summary>
        /// <value>The context of the relationship</value>
        [DataMember(Name="context", EmitDefaultValue=false)]
        public string Context { get; set; }
        /// <summary>
        /// The public username of the user
        /// </summary>
        /// <value>The public username of the user</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }
        /// <summary>
        /// The id of the user
        /// </summary>
        /// <value>The id of the user</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// The id of the relationship
        /// </summary>
        /// <value>The id of the relationship</value>
        [DataMember(Name="relationship_id", EmitDefaultValue=false)]
        public long? RelationshipId { get; set; }
        /// <summary>
        /// The username of the user
        /// </summary>
        /// <value>The username of the user</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserRelationshipReferenceResource {\n");
            sb.Append("  AvatarUrl: ").Append(AvatarUrl).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RelationshipId: ").Append(RelationshipId).Append("\n");
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
            return this.Equals(obj as UserRelationshipReferenceResource);
        }

        /// <summary>
        /// Returns true if UserRelationshipReferenceResource instances are equal
        /// </summary>
        /// <param name="other">Instance of UserRelationshipReferenceResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserRelationshipReferenceResource other)
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
                    this.Context == other.Context ||
                    this.Context != null &&
                    this.Context.Equals(other.Context)
                ) && 
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.RelationshipId == other.RelationshipId ||
                    this.RelationshipId != null &&
                    this.RelationshipId.Equals(other.RelationshipId)
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
                if (this.Context != null)
                    hash = hash * 59 + this.Context.GetHashCode();
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.RelationshipId != null)
                    hash = hash * 59 + this.RelationshipId.GetHashCode();
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