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
    /// CommentSearch
    /// </summary>
    [DataContract]
    public partial class CommentSearch :  IEquatable<CommentSearch>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommentSearch" /> class.
        /// </summary>
        /// <param name="Content">Content.</param>
        /// <param name="Context">Context.</param>
        /// <param name="ContextId">ContextId.</param>
        /// <param name="Id">Id.</param>
        /// <param name="OwnerId">OwnerId.</param>
        /// <param name="OwnerUsername">OwnerUsername.</param>
        public CommentSearch(string Content = default(string), string Context = default(string), int? ContextId = default(int?), long? Id = default(long?), int? OwnerId = default(int?), string OwnerUsername = default(string))
        {
            this.Content = Content;
            this.Context = Context;
            this.ContextId = ContextId;
            this.Id = Id;
            this.OwnerId = OwnerId;
            this.OwnerUsername = OwnerUsername;
        }
        
        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }

        /// <summary>
        /// Gets or Sets Context
        /// </summary>
        [DataMember(Name="context", EmitDefaultValue=false)]
        public string Context { get; set; }

        /// <summary>
        /// Gets or Sets ContextId
        /// </summary>
        [DataMember(Name="context_id", EmitDefaultValue=false)]
        public int? ContextId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets OwnerId
        /// </summary>
        [DataMember(Name="owner_id", EmitDefaultValue=false)]
        public int? OwnerId { get; set; }

        /// <summary>
        /// Gets or Sets OwnerUsername
        /// </summary>
        [DataMember(Name="owner_username", EmitDefaultValue=false)]
        public string OwnerUsername { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommentSearch {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  ContextId: ").Append(ContextId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  OwnerUsername: ").Append(OwnerUsername).Append("\n");
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
            return this.Equals(input as CommentSearch);
        }

        /// <summary>
        /// Returns true if CommentSearch instances are equal
        /// </summary>
        /// <param name="input">Instance of CommentSearch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommentSearch input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.Context == input.Context ||
                    (this.Context != null &&
                    this.Context.Equals(input.Context))
                ) && 
                (
                    this.ContextId == input.ContextId ||
                    (this.ContextId != null &&
                    this.ContextId.Equals(input.ContextId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.OwnerUsername == input.OwnerUsername ||
                    (this.OwnerUsername != null &&
                    this.OwnerUsername.Equals(input.OwnerUsername))
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
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Context != null)
                    hashCode = hashCode * 59 + this.Context.GetHashCode();
                if (this.ContextId != null)
                    hashCode = hashCode * 59 + this.ContextId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.OwnerId != null)
                    hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
                if (this.OwnerUsername != null)
                    hashCode = hashCode * 59 + this.OwnerUsername.GetHashCode();
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