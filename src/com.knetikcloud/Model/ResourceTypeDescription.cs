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
    /// ResourceTypeDescription
    /// </summary>
    [DataContract]
    public partial class ResourceTypeDescription :  IEquatable<ResourceTypeDescription>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceTypeDescription" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResourceTypeDescription() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceTypeDescription" /> class.
        /// </summary>
        /// <param name="IdField">The field on the resource that the id is in (required).</param>
        /// <param name="Name">The unique name for the resource in swagger. This serves as the unique identifier. Cannot be changed after creation (required).</param>
        /// <param name="ServicePath">The base path of the service (required).</param>
        public ResourceTypeDescription(string IdField = default(string), string Name = default(string), string ServicePath = default(string))
        {
            // to ensure "IdField" is required (not null)
            if (IdField == null)
            {
                throw new InvalidDataException("IdField is a required property for ResourceTypeDescription and cannot be null");
            }
            else
            {
                this.IdField = IdField;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for ResourceTypeDescription and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "ServicePath" is required (not null)
            if (ServicePath == null)
            {
                throw new InvalidDataException("ServicePath is a required property for ResourceTypeDescription and cannot be null");
            }
            else
            {
                this.ServicePath = ServicePath;
            }
        }
        
        /// <summary>
        /// The field on the resource that the id is in
        /// </summary>
        /// <value>The field on the resource that the id is in</value>
        [DataMember(Name="id_field", EmitDefaultValue=false)]
        public string IdField { get; set; }

        /// <summary>
        /// The unique name for the resource in swagger. This serves as the unique identifier. Cannot be changed after creation
        /// </summary>
        /// <value>The unique name for the resource in swagger. This serves as the unique identifier. Cannot be changed after creation</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The base path of the service
        /// </summary>
        /// <value>The base path of the service</value>
        [DataMember(Name="service_path", EmitDefaultValue=false)]
        public string ServicePath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceTypeDescription {\n");
            sb.Append("  IdField: ").Append(IdField).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ServicePath: ").Append(ServicePath).Append("\n");
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
            return this.Equals(input as ResourceTypeDescription);
        }

        /// <summary>
        /// Returns true if ResourceTypeDescription instances are equal
        /// </summary>
        /// <param name="input">Instance of ResourceTypeDescription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourceTypeDescription input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdField == input.IdField ||
                    (this.IdField != null &&
                    this.IdField.Equals(input.IdField))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ServicePath == input.ServicePath ||
                    (this.ServicePath != null &&
                    this.ServicePath.Equals(input.ServicePath))
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
                if (this.IdField != null)
                    hashCode = hashCode * 59 + this.IdField.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ServicePath != null)
                    hashCode = hashCode * 59 + this.ServicePath.GetHashCode();
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
