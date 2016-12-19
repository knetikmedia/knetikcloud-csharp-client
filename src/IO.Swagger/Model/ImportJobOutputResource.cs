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
    /// ImportJobOutputResource
    /// </summary>
    [DataContract]
    public partial class ImportJobOutputResource :  IEquatable<ImportJobOutputResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportJobOutputResource" /> class.
        /// </summary>
        /// <param name="Description">The description of the import job.</param>
        /// <param name="LineNumber">The line number of the import job.</param>
        public ImportJobOutputResource(string Description = null, long? LineNumber = null)
        {
            this.Description = Description;
            this.LineNumber = LineNumber;
        }
        
        /// <summary>
        /// The description of the import job
        /// </summary>
        /// <value>The description of the import job</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// The line number of the import job
        /// </summary>
        /// <value>The line number of the import job</value>
        [DataMember(Name="line_number", EmitDefaultValue=false)]
        public long? LineNumber { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportJobOutputResource {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  LineNumber: ").Append(LineNumber).Append("\n");
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
            return this.Equals(obj as ImportJobOutputResource);
        }

        /// <summary>
        /// Returns true if ImportJobOutputResource instances are equal
        /// </summary>
        /// <param name="other">Instance of ImportJobOutputResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportJobOutputResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.LineNumber == other.LineNumber ||
                    this.LineNumber != null &&
                    this.LineNumber.Equals(other.LineNumber)
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
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.LineNumber != null)
                    hash = hash * 59 + this.LineNumber.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}