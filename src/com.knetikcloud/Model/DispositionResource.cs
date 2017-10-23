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
    /// DispositionResource
    /// </summary>
    [DataContract]
    public partial class DispositionResource :  IEquatable<DispositionResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DispositionResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DispositionResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DispositionResource" /> class.
        /// </summary>
        /// <param name="Context">The context of that resource. Required when passed to /dispositions rather than context specific endpoint.</param>
        /// <param name="ContextId">The context_id of that resource. Required when passed to /dispositions rather than context specific endpoint.</param>
        /// <param name="Name">The name of the disposition, 1-20 characters. (ex: like/dislike/favorite, etc) (required).</param>
        /// <param name="User">The user.</param>
        public DispositionResource(string Context = default(string), string ContextId = default(string), string Name = default(string), SimpleUserResource User = default(SimpleUserResource))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for DispositionResource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.Context = Context;
            this.ContextId = ContextId;
            this.User = User;
        }
        
        /// <summary>
        /// The context of that resource. Required when passed to /dispositions rather than context specific endpoint
        /// </summary>
        /// <value>The context of that resource. Required when passed to /dispositions rather than context specific endpoint</value>
        [DataMember(Name="context", EmitDefaultValue=false)]
        public string Context { get; set; }

        /// <summary>
        /// The context_id of that resource. Required when passed to /dispositions rather than context specific endpoint
        /// </summary>
        /// <value>The context_id of that resource. Required when passed to /dispositions rather than context specific endpoint</value>
        [DataMember(Name="context_id", EmitDefaultValue=false)]
        public string ContextId { get; set; }

        /// <summary>
        /// The date/time this resource was created in seconds since unix epoch
        /// </summary>
        /// <value>The date/time this resource was created in seconds since unix epoch</value>
        [DataMember(Name="created_date", EmitDefaultValue=false)]
        public long? CreatedDate { get; private set; }

        /// <summary>
        /// The unique ID for that resource
        /// </summary>
        /// <value>The unique ID for that resource</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The name of the disposition, 1-20 characters. (ex: like/dislike/favorite, etc)
        /// </summary>
        /// <value>The name of the disposition, 1-20 characters. (ex: like/dislike/favorite, etc)</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The user
        /// </summary>
        /// <value>The user</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public SimpleUserResource User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DispositionResource {\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  ContextId: ").Append(ContextId).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(input as DispositionResource);
        }

        /// <summary>
        /// Returns true if DispositionResource instances are equal
        /// </summary>
        /// <param name="input">Instance of DispositionResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DispositionResource input)
        {
            if (input == null)
                return false;

            return 
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
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
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
                if (this.Context != null)
                    hashCode = hashCode * 59 + this.Context.GetHashCode();
                if (this.ContextId != null)
                    hashCode = hashCode * 59 + this.ContextId.GetHashCode();
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
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
