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
    /// FulfillmentType
    /// </summary>
    [DataContract]
    public partial class FulfillmentType :  IEquatable<FulfillmentType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FulfillmentType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentType" /> class.
        /// </summary>
        /// <param name="Core">Whether the type is core and cannot be altered/deleted, read-only.</param>
        /// <param name="Description">A description of the type.</param>
        /// <param name="Id">The unique id of the type, read-only.</param>
        /// <param name="Name">The name of the type (required).</param>
        public FulfillmentType(bool? Core = null, string Description = null, int? Id = null, string Name = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for FulfillmentType and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.Core = Core;
            this.Description = Description;
            this.Id = Id;
        }
        
        /// <summary>
        /// Whether the type is core and cannot be altered/deleted, read-only
        /// </summary>
        /// <value>Whether the type is core and cannot be altered/deleted, read-only</value>
        [DataMember(Name="core", EmitDefaultValue=false)]
        public bool? Core { get; set; }
        /// <summary>
        /// A description of the type
        /// </summary>
        /// <value>A description of the type</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// The unique id of the type, read-only
        /// </summary>
        /// <value>The unique id of the type, read-only</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// The name of the type
        /// </summary>
        /// <value>The name of the type</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FulfillmentType {\n");
            sb.Append("  Core: ").Append(Core).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(obj as FulfillmentType);
        }

        /// <summary>
        /// Returns true if FulfillmentType instances are equal
        /// </summary>
        /// <param name="other">Instance of FulfillmentType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FulfillmentType other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Core == other.Core ||
                    this.Core != null &&
                    this.Core.Equals(other.Core)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                if (this.Core != null)
                    hash = hash * 59 + this.Core.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
