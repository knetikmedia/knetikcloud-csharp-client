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
    /// ActivityEntitlementResource
    /// </summary>
    [DataContract]
    public partial class ActivityEntitlementResource :  IEquatable<ActivityEntitlementResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityEntitlementResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActivityEntitlementResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityEntitlementResource" /> class.
        /// </summary>
        /// <param name="ItemId">The id of the entitlement item (required).</param>
        public ActivityEntitlementResource(int? ItemId = null)
        {
            // to ensure "ItemId" is required (not null)
            if (ItemId == null)
            {
                throw new InvalidDataException("ItemId is a required property for ActivityEntitlementResource and cannot be null");
            }
            else
            {
                this.ItemId = ItemId;
            }
        }
        
        /// <summary>
        /// The ISO3 currency code the price is in, if available
        /// </summary>
        /// <value>The ISO3 currency code the price is in, if available</value>
        [DataMember(Name="currency_code", EmitDefaultValue=false)]
        public string CurrencyCode { get; private set; }
        /// <summary>
        /// The id of the entitlement item
        /// </summary>
        /// <value>The id of the entitlement item</value>
        [DataMember(Name="item_id", EmitDefaultValue=false)]
        public int? ItemId { get; set; }
        /// <summary>
        /// The name of the entitlement item
        /// </summary>
        /// <value>The name of the entitlement item</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }
        /// <summary>
        /// The price of the sku, if available
        /// </summary>
        /// <value>The price of the sku, if available</value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public double? Price { get; private set; }
        /// <summary>
        /// The sku id, if available. If multiple are available, then first one is returned
        /// </summary>
        /// <value>The sku id, if available. If multiple are available, then first one is returned</value>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActivityEntitlementResource {\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
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
            return this.Equals(obj as ActivityEntitlementResource);
        }

        /// <summary>
        /// Returns true if ActivityEntitlementResource instances are equal
        /// </summary>
        /// <param name="other">Instance of ActivityEntitlementResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivityEntitlementResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CurrencyCode == other.CurrencyCode ||
                    this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(other.CurrencyCode)
                ) && 
                (
                    this.ItemId == other.ItemId ||
                    this.ItemId != null &&
                    this.ItemId.Equals(other.ItemId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Price == other.Price ||
                    this.Price != null &&
                    this.Price.Equals(other.Price)
                ) && 
                (
                    this.Sku == other.Sku ||
                    this.Sku != null &&
                    this.Sku.Equals(other.Sku)
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
                if (this.CurrencyCode != null)
                    hash = hash * 59 + this.CurrencyCode.GetHashCode();
                if (this.ItemId != null)
                    hash = hash * 59 + this.ItemId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Price != null)
                    hash = hash * 59 + this.Price.GetHashCode();
                if (this.Sku != null)
                    hash = hash * 59 + this.Sku.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
