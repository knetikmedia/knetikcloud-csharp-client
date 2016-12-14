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
    /// Affiliate
    /// </summary>
    [DataContract]
    public partial class Affiliate :  IEquatable<Affiliate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Affiliate" /> class.
        /// </summary>
        /// <param name="AffiliateKey">AffiliateKey.</param>
        /// <param name="Id">Id.</param>
        public Affiliate(string AffiliateKey = null, int? Id = null)
        {
            this.AffiliateKey = AffiliateKey;
            this.Id = Id;
        }
        
        /// <summary>
        /// Gets or Sets AffiliateKey
        /// </summary>
        [DataMember(Name="affiliate_key", EmitDefaultValue=false)]
        public string AffiliateKey { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Affiliate {\n");
            sb.Append("  AffiliateKey: ").Append(AffiliateKey).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(obj as Affiliate);
        }

        /// <summary>
        /// Returns true if Affiliate instances are equal
        /// </summary>
        /// <param name="other">Instance of Affiliate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Affiliate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AffiliateKey == other.AffiliateKey ||
                    this.AffiliateKey != null &&
                    this.AffiliateKey.Equals(other.AffiliateKey)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                if (this.AffiliateKey != null)
                    hash = hash * 59 + this.AffiliateKey.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
