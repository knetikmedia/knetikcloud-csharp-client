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
    /// PermissionResource
    /// </summary>
    [DataContract]
    public partial class PermissionResource :  IEquatable<PermissionResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PermissionResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionResource" /> class.
        /// </summary>
        /// <param name="Description">The description of the permission.</param>
        /// <param name="Locked">Whether a permission is locked from being deleted.</param>
        /// <param name="Name">The name of the permission used for display purposes (required).</param>
        /// <param name="Parent">The name of the parent of the permission.</param>
        /// <param name="Permission">The keyword that defines the permission (required).</param>
        public PermissionResource(string Description = null, bool? Locked = null, string Name = null, string Parent = null, string Permission = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for PermissionResource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Permission" is required (not null)
            if (Permission == null)
            {
                throw new InvalidDataException("Permission is a required property for PermissionResource and cannot be null");
            }
            else
            {
                this.Permission = Permission;
            }
            this.Description = Description;
            this.Locked = Locked;
            this.Parent = Parent;
        }
        
        /// <summary>
        /// The date the permission was added. Unix timestamp in seconds
        /// </summary>
        /// <value>The date the permission was added. Unix timestamp in seconds</value>
        [DataMember(Name="created_date", EmitDefaultValue=false)]
        public long? CreatedDate { get; private set; }
        /// <summary>
        /// The description of the permission
        /// </summary>
        /// <value>The description of the permission</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Whether a permission is locked from being deleted
        /// </summary>
        /// <value>Whether a permission is locked from being deleted</value>
        [DataMember(Name="locked", EmitDefaultValue=false)]
        public bool? Locked { get; set; }
        /// <summary>
        /// The name of the permission used for display purposes
        /// </summary>
        /// <value>The name of the permission used for display purposes</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The name of the parent of the permission
        /// </summary>
        /// <value>The name of the parent of the permission</value>
        [DataMember(Name="parent", EmitDefaultValue=false)]
        public string Parent { get; set; }
        /// <summary>
        /// The keyword that defines the permission
        /// </summary>
        /// <value>The keyword that defines the permission</value>
        [DataMember(Name="permission", EmitDefaultValue=false)]
        public string Permission { get; set; }
        /// <summary>
        /// The date the permission was updated. Unix timestamp in seconds
        /// </summary>
        /// <value>The date the permission was updated. Unix timestamp in seconds</value>
        [DataMember(Name="updated_date", EmitDefaultValue=false)]
        public long? UpdatedDate { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PermissionResource {\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  Permission: ").Append(Permission).Append("\n");
            sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
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
            return this.Equals(obj as PermissionResource);
        }

        /// <summary>
        /// Returns true if PermissionResource instances are equal
        /// </summary>
        /// <param name="other">Instance of PermissionResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PermissionResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Locked == other.Locked ||
                    this.Locked != null &&
                    this.Locked.Equals(other.Locked)
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
                    this.Permission == other.Permission ||
                    this.Permission != null &&
                    this.Permission.Equals(other.Permission)
                ) && 
                (
                    this.UpdatedDate == other.UpdatedDate ||
                    this.UpdatedDate != null &&
                    this.UpdatedDate.Equals(other.UpdatedDate)
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
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Locked != null)
                    hash = hash * 59 + this.Locked.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Parent != null)
                    hash = hash * 59 + this.Parent.GetHashCode();
                if (this.Permission != null)
                    hash = hash * 59 + this.Permission.GetHashCode();
                if (this.UpdatedDate != null)
                    hash = hash * 59 + this.UpdatedDate.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}