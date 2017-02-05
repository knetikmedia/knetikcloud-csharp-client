/* 
 * Knetik Platform API Documentation latest 
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://demo.sandbox.knetikcloud.com
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

namespace IO.Swagger.Model
{
    /// <summary>
    /// BillingReport
    /// </summary>
    [DataContract]
    public partial class BillingReport :  IEquatable<BillingReport>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingReport" /> class.
        /// </summary>
        /// <param name="Created">Created.</param>
        /// <param name="Id">Id.</param>
        /// <param name="LastKnownFailures">LastKnownFailures.</param>
        /// <param name="Statistics">Statistics.</param>
        public BillingReport(long? Created = default(long?), string Id = default(string), List<string> LastKnownFailures = default(List<string>), Dictionary<string, int?> Statistics = default(Dictionary<string, int?>))
        {
            this.Created = Created;
            this.Id = Id;
            this.LastKnownFailures = LastKnownFailures;
            this.Statistics = Statistics;
        }
        
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public long? Created { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets LastKnownFailures
        /// </summary>
        [DataMember(Name="last_known_failures", EmitDefaultValue=false)]
        public List<string> LastKnownFailures { get; set; }
        /// <summary>
        /// Gets or Sets Statistics
        /// </summary>
        [DataMember(Name="statistics", EmitDefaultValue=false)]
        public Dictionary<string, int?> Statistics { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingReport {\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastKnownFailures: ").Append(LastKnownFailures).Append("\n");
            sb.Append("  Statistics: ").Append(Statistics).Append("\n");
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
            return this.Equals(obj as BillingReport);
        }

        /// <summary>
        /// Returns true if BillingReport instances are equal
        /// </summary>
        /// <param name="other">Instance of BillingReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingReport other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.LastKnownFailures == other.LastKnownFailures ||
                    this.LastKnownFailures != null &&
                    this.LastKnownFailures.SequenceEqual(other.LastKnownFailures)
                ) && 
                (
                    this.Statistics == other.Statistics ||
                    this.Statistics != null &&
                    this.Statistics.SequenceEqual(other.Statistics)
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
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.LastKnownFailures != null)
                    hash = hash * 59 + this.LastKnownFailures.GetHashCode();
                if (this.Statistics != null)
                    hash = hash * 59 + this.Statistics.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}