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
    /// GroupMemberResource
    /// </summary>
    [DataContract]
    public partial class GroupMemberResource :  IEquatable<GroupMemberResource>, IValidatableObject
    {
        /// <summary>
        /// The member&#39;s access level. Default: member
        /// </summary>
        /// <value>The member&#39;s access level. Default: member</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Moderator for "moderator"
            /// </summary>
            [EnumMember(Value = "moderator")]
            Moderator,
            
            /// <summary>
            /// Enum Member for "member"
            /// </summary>
            [EnumMember(Value = "member")]
            Member
        }

        /// <summary>
        /// The member&#39;s access level. Default: member
        /// </summary>
        /// <value>The member&#39;s access level. Default: member</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupMemberResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupMemberResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupMemberResource" /> class.
        /// </summary>
        /// <param name="AdditionalProperties">A map of additional properties, keyed on the property name (private). Must match the names and types defined in the template for this type, or be an extra not from the template.</param>
        /// <param name="Id">The id of the user (required).</param>
        /// <param name="Order">The position of the member in the group if applicable. Read notes for details.</param>
        /// <param name="Status">The member&#39;s access level. Default: member.</param>
        /// <param name="Template">A template this member additional properties are validated against (private). May be null and no validation of properties will be done.</param>
        public GroupMemberResource(Dictionary<string, JObject> AdditionalProperties = default(Dictionary<string, JObject>), int? Id = default(int?), string Order = default(string), StatusEnum? Status = default(StatusEnum?), string Template = default(string))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for GroupMemberResource and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            this.AdditionalProperties = AdditionalProperties;
            this.Order = Order;
            this.Status = Status;
            this.Template = Template;
        }
        
        /// <summary>
        /// A map of additional properties, keyed on the property name (private). Must match the names and types defined in the template for this type, or be an extra not from the template
        /// </summary>
        /// <value>A map of additional properties, keyed on the property name (private). Must match the names and types defined in the template for this type, or be an extra not from the template</value>
        [DataMember(Name="additional_properties", EmitDefaultValue=false)]
        public Dictionary<string, JObject> AdditionalProperties { get; set; }

        /// <summary>
        /// The url of the user&#39;s avatar image
        /// </summary>
        /// <value>The url of the user&#39;s avatar image</value>
        [DataMember(Name="avatar_url", EmitDefaultValue=false)]
        public string AvatarUrl { get; private set; }

        /// <summary>
        /// The public username of the user
        /// </summary>
        /// <value>The public username of the user</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; private set; }

        /// <summary>
        /// The id of the user
        /// </summary>
        /// <value>The id of the user</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The position of the member in the group if applicable. Read notes for details
        /// </summary>
        /// <value>The position of the member in the group if applicable. Read notes for details</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public string Order { get; set; }


        /// <summary>
        /// A template this member additional properties are validated against (private). May be null and no validation of properties will be done
        /// </summary>
        /// <value>A template this member additional properties are validated against (private). May be null and no validation of properties will be done</value>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public string Template { get; set; }

        /// <summary>
        /// The username of the user
        /// </summary>
        /// <value>The username of the user</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupMemberResource {\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("  AvatarUrl: ").Append(AvatarUrl).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
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
            return this.Equals(input as GroupMemberResource);
        }

        /// <summary>
        /// Returns true if GroupMemberResource instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupMemberResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupMemberResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdditionalProperties == input.AdditionalProperties ||
                    (this.AdditionalProperties != null &&
                    this.AdditionalProperties.SequenceEqual(input.AdditionalProperties))
                ) && 
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
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
                if (this.AdditionalProperties != null)
                    hashCode = hashCode * 59 + this.AdditionalProperties.GetHashCode();
                if (this.AvatarUrl != null)
                    hashCode = hashCode * 59 + this.AvatarUrl.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Template != null)
                    hashCode = hashCode * 59 + this.Template.GetHashCode();
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
