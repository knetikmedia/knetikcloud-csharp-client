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

namespace IO.Swagger.Model
{
    /// <summary>
    /// AggregateInvoiceReportResource
    /// </summary>
    [DataContract]
    public partial class AggregateInvoiceReportResource :  IEquatable<AggregateInvoiceReportResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateInvoiceReportResource" /> class.
        /// </summary>
        /// <param name="Count">Count.</param>
        /// <param name="Date">Date.</param>
        /// <param name="Revenue">Revenue.</param>
        /// <param name="UserCount">UserCount.</param>
        public AggregateInvoiceReportResource(long? Count = default(long?), string Date = default(string), double? Revenue = default(double?), long? UserCount = default(long?))
        {
            this.Count = Count;
            this.Date = Date;
            this.Revenue = Revenue;
            this.UserCount = UserCount;
        }
        
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public long? Count { get; set; }
        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public string Date { get; set; }
        /// <summary>
        /// Gets or Sets Revenue
        /// </summary>
        [DataMember(Name="revenue", EmitDefaultValue=false)]
        public double? Revenue { get; set; }
        /// <summary>
        /// Gets or Sets UserCount
        /// </summary>
        [DataMember(Name="user_count", EmitDefaultValue=false)]
        public long? UserCount { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AggregateInvoiceReportResource {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Revenue: ").Append(Revenue).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as AggregateInvoiceReportResource);
        }

        /// <summary>
        /// Returns true if AggregateInvoiceReportResource instances are equal
        /// </summary>
        /// <param name="other">Instance of AggregateInvoiceReportResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AggregateInvoiceReportResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
                ) && 
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
                ) && 
                (
                    this.Revenue == other.Revenue ||
                    this.Revenue != null &&
                    this.Revenue.Equals(other.Revenue)
                ) && 
                (
                    this.UserCount == other.UserCount ||
                    this.UserCount != null &&
                    this.UserCount.Equals(other.UserCount)
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
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();
                if (this.Revenue != null)
                    hash = hash * 59 + this.Revenue.GetHashCode();
                if (this.UserCount != null)
                    hash = hash * 59 + this.UserCount.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
