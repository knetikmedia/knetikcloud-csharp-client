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
    /// TopicResource
    /// </summary>
    [DataContract]
    public partial class TopicResource :  IEquatable<TopicResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TopicResource" /> class.
        /// </summary>
        /// <param name="CreatedDate">The created date of the topic.</param>
        /// <param name="DisplayName">The display name of the topic.</param>
        /// <param name="Id">The unique ID for this topic.</param>
        /// <param name="Locked">Whether this topic is locked or not..</param>
        /// <param name="Tags">Random tags to facilitate search.</param>
        /// <param name="UpdatedDate">The last time the topic was updated.</param>
        /// <param name="UserCount">The subscribed user count of the topic.</param>
        public TopicResource(long? CreatedDate = default(long?), string DisplayName = default(string), string Id = default(string), bool? Locked = default(bool?), List<string> Tags = default(List<string>), long? UpdatedDate = default(long?), int? UserCount = default(int?))
        {
            this.CreatedDate = CreatedDate;
            this.DisplayName = DisplayName;
            this.Id = Id;
            this.Locked = Locked;
            this.Tags = Tags;
            this.UpdatedDate = UpdatedDate;
            this.UserCount = UserCount;
        }
        
        /// <summary>
        /// The created date of the topic
        /// </summary>
        /// <value>The created date of the topic</value>
        [DataMember(Name="created_date", EmitDefaultValue=false)]
        public long? CreatedDate { get; set; }

        /// <summary>
        /// The display name of the topic
        /// </summary>
        /// <value>The display name of the topic</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The unique ID for this topic
        /// </summary>
        /// <value>The unique ID for this topic</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Whether this topic is locked or not.
        /// </summary>
        /// <value>Whether this topic is locked or not.</value>
        [DataMember(Name="locked", EmitDefaultValue=false)]
        public bool? Locked { get; set; }

        /// <summary>
        /// Random tags to facilitate search
        /// </summary>
        /// <value>Random tags to facilitate search</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// The last time the topic was updated
        /// </summary>
        /// <value>The last time the topic was updated</value>
        [DataMember(Name="updated_date", EmitDefaultValue=false)]
        public long? UpdatedDate { get; set; }

        /// <summary>
        /// The subscribed user count of the topic
        /// </summary>
        /// <value>The subscribed user count of the topic</value>
        [DataMember(Name="user_count", EmitDefaultValue=false)]
        public int? UserCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TopicResource {\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
            sb.Append("  UserCount: ").Append(UserCount).Append("\n");
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
            return this.Equals(input as TopicResource);
        }

        /// <summary>
        /// Returns true if TopicResource instances are equal
        /// </summary>
        /// <param name="input">Instance of TopicResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TopicResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Locked == input.Locked ||
                    (this.Locked != null &&
                    this.Locked.Equals(input.Locked))
                ) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags))
                ) && 
                (
                    this.UpdatedDate == input.UpdatedDate ||
                    (this.UpdatedDate != null &&
                    this.UpdatedDate.Equals(input.UpdatedDate))
                ) && 
                (
                    this.UserCount == input.UserCount ||
                    (this.UserCount != null &&
                    this.UserCount.Equals(input.UserCount))
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
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Locked != null)
                    hashCode = hashCode * 59 + this.Locked.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.UpdatedDate != null)
                    hashCode = hashCode * 59 + this.UpdatedDate.GetHashCode();
                if (this.UserCount != null)
                    hashCode = hashCode * 59 + this.UserCount.GetHashCode();
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
