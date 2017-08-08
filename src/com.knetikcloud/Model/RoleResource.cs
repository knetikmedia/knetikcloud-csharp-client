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
    /// RoleResource
    /// </summary>
    [DataContract]
    public partial class RoleResource :  IEquatable<RoleResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RoleResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleResource" /> class.
        /// </summary>
        /// <param name="Locked">Whether a role is locked from being deleted.</param>
        /// <param name="Name">The name of the role used for display purposes (required).</param>
        /// <param name="Role">The keyword that defines the role (required).</param>
        /// <param name="RolePermission">The list of permissions this role has.</param>
        public RoleResource(bool? Locked = default(bool?), string Name = default(string), string Role = default(string), List<PermissionResource> RolePermission = default(List<PermissionResource>))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for RoleResource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Role" is required (not null)
            if (Role == null)
            {
                throw new InvalidDataException("Role is a required property for RoleResource and cannot be null");
            }
            else
            {
                this.Role = Role;
            }
            this.Locked = Locked;
            this.RolePermission = RolePermission;
        }
        
        /// <summary>
        /// The number of clients this role is assigned to
        /// </summary>
        /// <value>The number of clients this role is assigned to</value>
        [DataMember(Name="client_count", EmitDefaultValue=false)]
        public int? ClientCount { get; private set; }

        /// <summary>
        /// The date the role was added. Unix timestamp in seconds
        /// </summary>
        /// <value>The date the role was added. Unix timestamp in seconds</value>
        [DataMember(Name="created_date", EmitDefaultValue=false)]
        public long? CreatedDate { get; private set; }

        /// <summary>
        /// Whether a role is locked from being deleted
        /// </summary>
        /// <value>Whether a role is locked from being deleted</value>
        [DataMember(Name="locked", EmitDefaultValue=false)]
        public bool? Locked { get; set; }

        /// <summary>
        /// The name of the role used for display purposes
        /// </summary>
        /// <value>The name of the role used for display purposes</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The keyword that defines the role
        /// </summary>
        /// <value>The keyword that defines the role</value>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public string Role { get; set; }

        /// <summary>
        /// The list of permissions this role has
        /// </summary>
        /// <value>The list of permissions this role has</value>
        [DataMember(Name="role_permission", EmitDefaultValue=false)]
        public List<PermissionResource> RolePermission { get; set; }

        /// <summary>
        /// The number of users this role is assigned to
        /// </summary>
        /// <value>The number of users this role is assigned to</value>
        [DataMember(Name="user_count", EmitDefaultValue=false)]
        public int? UserCount { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoleResource {\n");
            sb.Append("  ClientCount: ").Append(ClientCount).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  RolePermission: ").Append(RolePermission).Append("\n");
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
            return this.Equals(input as RoleResource);
        }

        /// <summary>
        /// Returns true if RoleResource instances are equal
        /// </summary>
        /// <param name="input">Instance of RoleResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoleResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientCount == input.ClientCount ||
                    (this.ClientCount != null &&
                    this.ClientCount.Equals(input.ClientCount))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.Locked == input.Locked ||
                    (this.Locked != null &&
                    this.Locked.Equals(input.Locked))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.RolePermission == input.RolePermission ||
                    (this.RolePermission != null &&
                    this.RolePermission.SequenceEqual(input.RolePermission))
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
                if (this.ClientCount != null)
                    hashCode = hashCode * 59 + this.ClientCount.GetHashCode();
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.Locked != null)
                    hashCode = hashCode * 59 + this.Locked.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.RolePermission != null)
                    hashCode = hashCode * 59 + this.RolePermission.GetHashCode();
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
