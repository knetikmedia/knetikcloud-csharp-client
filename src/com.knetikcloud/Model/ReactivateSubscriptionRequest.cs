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
    /// ReactivateSubscriptionRequest
    /// </summary>
    [DataContract]
    public partial class ReactivateSubscriptionRequest :  IEquatable<ReactivateSubscriptionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReactivateSubscriptionRequest" /> class.
        /// </summary>
        /// <param name="InventoryId">The inventory to reactivate. Only required if using the deprecated subscriptions service.</param>
        /// <param name="ReactivationFee">Whether to add the additional reactivation fee in addition to the recurring fee.</param>
        public ReactivateSubscriptionRequest(int? InventoryId = default(int?), bool? ReactivationFee = default(bool?))
        {
            this.InventoryId = InventoryId;
            this.ReactivationFee = ReactivationFee;
        }
        
        /// <summary>
        /// The inventory to reactivate. Only required if using the deprecated subscriptions service
        /// </summary>
        /// <value>The inventory to reactivate. Only required if using the deprecated subscriptions service</value>
        [DataMember(Name="inventory_id", EmitDefaultValue=false)]
        public int? InventoryId { get; set; }

        /// <summary>
        /// Whether to add the additional reactivation fee in addition to the recurring fee
        /// </summary>
        /// <value>Whether to add the additional reactivation fee in addition to the recurring fee</value>
        [DataMember(Name="reactivation_fee", EmitDefaultValue=false)]
        public bool? ReactivationFee { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReactivateSubscriptionRequest {\n");
            sb.Append("  InventoryId: ").Append(InventoryId).Append("\n");
            sb.Append("  ReactivationFee: ").Append(ReactivationFee).Append("\n");
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
            return this.Equals(input as ReactivateSubscriptionRequest);
        }

        /// <summary>
        /// Returns true if ReactivateSubscriptionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ReactivateSubscriptionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReactivateSubscriptionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InventoryId == input.InventoryId ||
                    (this.InventoryId != null &&
                    this.InventoryId.Equals(input.InventoryId))
                ) && 
                (
                    this.ReactivationFee == input.ReactivationFee ||
                    (this.ReactivationFee != null &&
                    this.ReactivationFee.Equals(input.ReactivationFee))
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
                if (this.InventoryId != null)
                    hashCode = hashCode * 59 + this.InventoryId.GetHashCode();
                if (this.ReactivationFee != null)
                    hashCode = hashCode * 59 + this.ReactivationFee.GetHashCode();
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
