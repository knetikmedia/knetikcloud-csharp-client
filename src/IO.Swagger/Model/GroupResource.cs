/* 
 * Knetik Platform API Documentation Latest
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
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
    /// GroupResource
    /// </summary>
    [DataContract]
    public partial class GroupResource :  IEquatable<GroupResource>, IValidatableObject
    {
        /// <summary>
        /// The status which describes whether other users can freely join the group or not
        /// </summary>
        /// <value>The status which describes whether other users can freely join the group or not</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Open for "open"
            /// </summary>
            [EnumMember(Value = "open")]
            Open,
            
            /// <summary>
            /// Enum Closed for "closed"
            /// </summary>
            [EnumMember(Value = "closed")]
            Closed
        }

        /// <summary>
        /// The status which describes whether other users can freely join the group or not
        /// </summary>
        /// <value>The status which describes whether other users can freely join the group or not</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupResource" /> class.
        /// </summary>
        /// <param name="AdditionalProperties">A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type.</param>
        /// <param name="Description">A description of the group. Max 250 characters.</param>
        /// <param name="MessageOfTheDay">A message of the day for members of the group.</param>
        /// <param name="Name">The name of the group. Max 50 characters (required).</param>
        /// <param name="Parent">The unique name of another group that this group is a subset of.</param>
        /// <param name="Status">The status which describes whether other users can freely join the group or not (required).</param>
        /// <param name="Template">A group template this group is validated against. May be null and no validation of additional_properties will be done.</param>
        /// <param name="UniqueName">Unique name used in url and references. Uppercase, lowercase, numbers and hyphens only. Max 50 characters. Cannot be altered once created (required).</param>
        public GroupResource(Dictionary<string, Property> AdditionalProperties = null, string Description = null, string MessageOfTheDay = null, string Name = null, string Parent = null, StatusEnum? Status = null, string Template = null, string UniqueName = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for GroupResource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for GroupResource and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            // to ensure "UniqueName" is required (not null)
            if (UniqueName == null)
            {
                throw new InvalidDataException("UniqueName is a required property for GroupResource and cannot be null");
            }
            else
            {
                this.UniqueName = UniqueName;
            }
            this.AdditionalProperties = AdditionalProperties;
            this.Description = Description;
            this.MessageOfTheDay = MessageOfTheDay;
            this.Parent = Parent;
            this.Template = Template;
        }
        
        /// <summary>
        /// A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type
        /// </summary>
        /// <value>A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type</value>
        [DataMember(Name="additional_properties", EmitDefaultValue=false)]
        public Dictionary<string, Property> AdditionalProperties { get; set; }
        /// <summary>
        /// A description of the group. Max 250 characters
        /// </summary>
        /// <value>A description of the group. Max 250 characters</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// The number of users in the group
        /// </summary>
        /// <value>The number of users in the group</value>
        [DataMember(Name="member_count", EmitDefaultValue=false)]
        public int? MemberCount { get; private set; }
        /// <summary>
        /// A message of the day for members of the group
        /// </summary>
        /// <value>A message of the day for members of the group</value>
        [DataMember(Name="message_of_the_day", EmitDefaultValue=false)]
        public string MessageOfTheDay { get; set; }
        /// <summary>
        /// The name of the group. Max 50 characters
        /// </summary>
        /// <value>The name of the group. Max 50 characters</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The unique name of another group that this group is a subset of
        /// </summary>
        /// <value>The unique name of another group that this group is a subset of</value>
        [DataMember(Name="parent", EmitDefaultValue=false)]
        public string Parent { get; set; }
        /// <summary>
        /// The number of users in child groups
        /// </summary>
        /// <value>The number of users in child groups</value>
        [DataMember(Name="sub_member_count", EmitDefaultValue=false)]
        public int? SubMemberCount { get; private set; }
        /// <summary>
        /// A group template this group is validated against. May be null and no validation of additional_properties will be done
        /// </summary>
        /// <value>A group template this group is validated against. May be null and no validation of additional_properties will be done</value>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public string Template { get; set; }
        /// <summary>
        /// Unique name used in url and references. Uppercase, lowercase, numbers and hyphens only. Max 50 characters. Cannot be altered once created
        /// </summary>
        /// <value>Unique name used in url and references. Uppercase, lowercase, numbers and hyphens only. Max 50 characters. Cannot be altered once created</value>
        [DataMember(Name="unique_name", EmitDefaultValue=false)]
        public string UniqueName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupResource {\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  MemberCount: ").Append(MemberCount).Append("\n");
            sb.Append("  MessageOfTheDay: ").Append(MessageOfTheDay).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SubMemberCount: ").Append(SubMemberCount).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  UniqueName: ").Append(UniqueName).Append("\n");
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
            return this.Equals(obj as GroupResource);
        }

        /// <summary>
        /// Returns true if GroupResource instances are equal
        /// </summary>
        /// <param name="other">Instance of GroupResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.MemberCount == other.MemberCount ||
                    this.MemberCount != null &&
                    this.MemberCount.Equals(other.MemberCount)
                ) && 
                (
                    this.MessageOfTheDay == other.MessageOfTheDay ||
                    this.MessageOfTheDay != null &&
                    this.MessageOfTheDay.Equals(other.MessageOfTheDay)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Parent == other.Parent ||
                    this.Parent != null &&
                    this.Parent.Equals(other.Parent)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.SubMemberCount == other.SubMemberCount ||
                    this.SubMemberCount != null &&
                    this.SubMemberCount.Equals(other.SubMemberCount)
                ) && 
                (
                    this.Template == other.Template ||
                    this.Template != null &&
                    this.Template.Equals(other.Template)
                ) && 
                (
                    this.UniqueName == other.UniqueName ||
                    this.UniqueName != null &&
                    this.UniqueName.Equals(other.UniqueName)
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
                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.MemberCount != null)
                    hash = hash * 59 + this.MemberCount.GetHashCode();
                if (this.MessageOfTheDay != null)
                    hash = hash * 59 + this.MessageOfTheDay.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Parent != null)
                    hash = hash * 59 + this.Parent.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.SubMemberCount != null)
                    hash = hash * 59 + this.SubMemberCount.GetHashCode();
                if (this.Template != null)
                    hash = hash * 59 + this.Template.GetHashCode();
                if (this.UniqueName != null)
                    hash = hash * 59 + this.UniqueName.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}