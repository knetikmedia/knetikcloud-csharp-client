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
    /// RevenueProductReportResource
    /// </summary>
    [DataContract]
    public partial class RevenueProductReportResource :  IEquatable<RevenueProductReportResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RevenueProductReportResource" /> class.
        /// </summary>
        /// <param name="ItemId">ItemId.</param>
        /// <param name="ItemName">ItemName.</param>
        /// <param name="Revenue">Revenue.</param>
        /// <param name="Volume">Volume.</param>
        public RevenueProductReportResource(int? ItemId = null, string ItemName = null, double? Revenue = null, long? Volume = null)
        {
            this.ItemId = ItemId;
            this.ItemName = ItemName;
            this.Revenue = Revenue;
            this.Volume = Volume;
        }
        
        /// <summary>
        /// Gets or Sets ItemId
        /// </summary>
        [DataMember(Name="item_id", EmitDefaultValue=false)]
        public int? ItemId { get; set; }
        /// <summary>
        /// Gets or Sets ItemName
        /// </summary>
        [DataMember(Name="item_name", EmitDefaultValue=false)]
        public string ItemName { get; set; }
        /// <summary>
        /// Gets or Sets Revenue
        /// </summary>
        [DataMember(Name="revenue", EmitDefaultValue=false)]
        public double? Revenue { get; set; }
        /// <summary>
        /// Gets or Sets Volume
        /// </summary>
        [DataMember(Name="volume", EmitDefaultValue=false)]
        public long? Volume { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RevenueProductReportResource {\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  ItemName: ").Append(ItemName).Append("\n");
            sb.Append("  Revenue: ").Append(Revenue).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
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
            return this.Equals(obj as RevenueProductReportResource);
        }

        /// <summary>
        /// Returns true if RevenueProductReportResource instances are equal
        /// </summary>
        /// <param name="other">Instance of RevenueProductReportResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RevenueProductReportResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ItemId == other.ItemId ||
                    this.ItemId != null &&
                    this.ItemId.Equals(other.ItemId)
                ) && 
                (
                    this.ItemName == other.ItemName ||
                    this.ItemName != null &&
                    this.ItemName.Equals(other.ItemName)
                ) && 
                (
                    this.Revenue == other.Revenue ||
                    this.Revenue != null &&
                    this.Revenue.Equals(other.Revenue)
                ) && 
                (
                    this.Volume == other.Volume ||
                    this.Volume != null &&
                    this.Volume.Equals(other.Volume)
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
                if (this.ItemId != null)
                    hash = hash * 59 + this.ItemId.GetHashCode();
                if (this.ItemName != null)
                    hash = hash * 59 + this.ItemName.GetHashCode();
                if (this.Revenue != null)
                    hash = hash * 59 + this.Revenue.GetHashCode();
                if (this.Volume != null)
                    hash = hash * 59 + this.Volume.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
