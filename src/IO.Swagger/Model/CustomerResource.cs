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
    /// CustomerResource
    /// </summary>
    [DataContract]
    public partial class CustomerResource :  IEquatable<CustomerResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerResource" /> class.
        /// </summary>
        /// <param name="Aliases">Aliases.</param>
        /// <param name="Database">Database.</param>
        /// <param name="Name">Name.</param>
        public CustomerResource(string Aliases = null, DatabaseConfig Database = null, string Name = null)
        {
            this.Aliases = Aliases;
            this.Database = Database;
            this.Name = Name;
        }
        
        /// <summary>
        /// Gets or Sets Aliases
        /// </summary>
        [DataMember(Name="aliases", EmitDefaultValue=false)]
        public string Aliases { get; set; }
        /// <summary>
        /// Gets or Sets Database
        /// </summary>
        [DataMember(Name="database", EmitDefaultValue=false)]
        public DatabaseConfig Database { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerResource {\n");
            sb.Append("  Aliases: ").Append(Aliases).Append("\n");
            sb.Append("  Database: ").Append(Database).Append("\n");
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
            return this.Equals(obj as CustomerResource);
        }

        /// <summary>
        /// Returns true if CustomerResource instances are equal
        /// </summary>
        /// <param name="other">Instance of CustomerResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Aliases == other.Aliases ||
                    this.Aliases != null &&
                    this.Aliases.Equals(other.Aliases)
                ) && 
                (
                    this.Database == other.Database ||
                    this.Database != null &&
                    this.Database.Equals(other.Database)
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
                if (this.Aliases != null)
                    hash = hash * 59 + this.Aliases.GetHashCode();
                if (this.Database != null)
                    hash = hash * 59 + this.Database.GetHashCode();
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
