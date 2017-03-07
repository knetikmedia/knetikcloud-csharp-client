/* 
 * Knetik Platform API Documentation latest 
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://knetikcloud.com
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

namespace com.knetikcloud.Model
{
    /// <summary>
    /// GroupMember
    /// </summary>
    [DataContract]
    public partial class GroupMember :  IEquatable<GroupMember>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
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
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupMember" /> class.
        /// </summary>
        /// <param name="Group">Group.</param>
        /// <param name="Secondary">Secondary.</param>
        /// <param name="Status">Status.</param>
        /// <param name="User">User.</param>
        public GroupMember(Group Group = default(Group), bool? Secondary = default(bool?), StatusEnum? Status = default(StatusEnum?), User User = default(User))
        {
            this.Group = Group;
            this.Secondary = Secondary;
            this.Status = Status;
            this.User = User;
        }
        
        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public Group Group { get; set; }
        /// <summary>
        /// Gets or Sets Secondary
        /// </summary>
        [DataMember(Name="secondary", EmitDefaultValue=false)]
        public bool? Secondary { get; set; }
        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupMember {\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Secondary: ").Append(Secondary).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as GroupMember);
        }

        /// <summary>
        /// Returns true if GroupMember instances are equal
        /// </summary>
        /// <param name="other">Instance of GroupMember to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupMember other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Group == other.Group ||
                    this.Group != null &&
                    this.Group.Equals(other.Group)
                ) && 
                (
                    this.Secondary == other.Secondary ||
                    this.Secondary != null &&
                    this.Secondary.Equals(other.Secondary)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
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
                if (this.Group != null)
                    hash = hash * 59 + this.Group.GetHashCode();
                if (this.Secondary != null)
                    hash = hash * 59 + this.Secondary.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
