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
    /// SubscriptionPriceOverrideRequest
    /// </summary>
    [DataContract]
    public partial class SubscriptionPriceOverrideRequest :  IEquatable<SubscriptionPriceOverrideRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPriceOverrideRequest" /> class.
        /// </summary>
        /// <param name="NewPrice">The recurring price that has been set to override the base price. Null if not overriding.</param>
        /// <param name="Reason">An explanation for the reason the price is being overridden.</param>
        public SubscriptionPriceOverrideRequest(decimal? NewPrice = default(decimal?), string Reason = default(string))
        {
            this.NewPrice = NewPrice;
            this.Reason = Reason;
        }
        
        /// <summary>
        /// The recurring price that has been set to override the base price. Null if not overriding
        /// </summary>
        /// <value>The recurring price that has been set to override the base price. Null if not overriding</value>
        [DataMember(Name="new_price", EmitDefaultValue=false)]
        public decimal? NewPrice { get; set; }

        /// <summary>
        /// An explanation for the reason the price is being overridden
        /// </summary>
        /// <value>An explanation for the reason the price is being overridden</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionPriceOverrideRequest {\n");
            sb.Append("  NewPrice: ").Append(NewPrice).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
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
            return this.Equals(input as SubscriptionPriceOverrideRequest);
        }

        /// <summary>
        /// Returns true if SubscriptionPriceOverrideRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionPriceOverrideRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionPriceOverrideRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NewPrice == input.NewPrice ||
                    (this.NewPrice != null &&
                    this.NewPrice.Equals(input.NewPrice))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
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
                if (this.NewPrice != null)
                    hashCode = hashCode * 59 + this.NewPrice.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
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
