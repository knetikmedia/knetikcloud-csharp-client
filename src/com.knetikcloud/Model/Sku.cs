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
    /// Sku
    /// </summary>
    [DataContract]
    public partial class Sku :  IEquatable<Sku>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Sku" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Sku() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Sku" /> class.
        /// </summary>
        /// <param name="AdditionalProperties">A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type, or be an extra not from the template.</param>
        /// <param name="CurrencyCode">The currency code for the SKU, a three letter string (ISO3) (required).</param>
        /// <param name="Description">The friendly name of the SKU as it will appear on invoices and reports. Typically represents the option name like red, large, etc (required).</param>
        /// <param name="Inventory">The number of SKUs currently in stock.</param>
        /// <param name="MinInventoryThreshold">Alerts vendor when SKU inventory drops below this value.</param>
        /// <param name="OriginalPrice">The base price before any sale (required).</param>
        /// <param name="Published">Whether or not the SKU is currently published.</param>
        /// <param name="_Sku">The stock keeping unit (SKU), a unique identifier for a given product.  Max 40 characters (required).</param>
        /// <param name="StartDate">The date the sku becomes available, unix timestamp in seconds.  If set to null, sku will become available immediately.</param>
        /// <param name="StopDate">The date the sku becomes unavailable, unix timestamp in seconds.  If set to null, sku is always available.</param>
        public Sku(Dictionary<string, Property> AdditionalProperties = default(Dictionary<string, Property>), string CurrencyCode = default(string), string Description = default(string), int? Inventory = default(int?), int? MinInventoryThreshold = default(int?), double? OriginalPrice = default(double?), bool? Published = default(bool?), string _Sku = default(string), long? StartDate = default(long?), long? StopDate = default(long?))
        {
            // to ensure "CurrencyCode" is required (not null)
            if (CurrencyCode == null)
            {
                throw new InvalidDataException("CurrencyCode is a required property for Sku and cannot be null");
            }
            else
            {
                this.CurrencyCode = CurrencyCode;
            }
            // to ensure "Description" is required (not null)
            if (Description == null)
            {
                throw new InvalidDataException("Description is a required property for Sku and cannot be null");
            }
            else
            {
                this.Description = Description;
            }
            // to ensure "OriginalPrice" is required (not null)
            if (OriginalPrice == null)
            {
                throw new InvalidDataException("OriginalPrice is a required property for Sku and cannot be null");
            }
            else
            {
                this.OriginalPrice = OriginalPrice;
            }
            // to ensure "_Sku" is required (not null)
            if (_Sku == null)
            {
                throw new InvalidDataException("_Sku is a required property for Sku and cannot be null");
            }
            else
            {
                this._Sku = _Sku;
            }
            this.AdditionalProperties = AdditionalProperties;
            this.Inventory = Inventory;
            this.MinInventoryThreshold = MinInventoryThreshold;
            this.Published = Published;
            this.StartDate = StartDate;
            this.StopDate = StopDate;
        }
        
        /// <summary>
        /// A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type, or be an extra not from the template
        /// </summary>
        /// <value>A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type, or be an extra not from the template</value>
        [DataMember(Name="additional_properties", EmitDefaultValue=false)]
        public Dictionary<string, Property> AdditionalProperties { get; set; }

        /// <summary>
        /// The currency code for the SKU, a three letter string (ISO3)
        /// </summary>
        /// <value>The currency code for the SKU, a three letter string (ISO3)</value>
        [DataMember(Name="currency_code", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// The friendly name of the SKU as it will appear on invoices and reports. Typically represents the option name like red, large, etc
        /// </summary>
        /// <value>The friendly name of the SKU as it will appear on invoices and reports. Typically represents the option name like red, large, etc</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The number of SKUs currently in stock
        /// </summary>
        /// <value>The number of SKUs currently in stock</value>
        [DataMember(Name="inventory", EmitDefaultValue=false)]
        public int? Inventory { get; set; }

        /// <summary>
        /// Alerts vendor when SKU inventory drops below this value
        /// </summary>
        /// <value>Alerts vendor when SKU inventory drops below this value</value>
        [DataMember(Name="min_inventory_threshold", EmitDefaultValue=false)]
        public int? MinInventoryThreshold { get; set; }

        /// <summary>
        /// The base price before any sale
        /// </summary>
        /// <value>The base price before any sale</value>
        [DataMember(Name="original_price", EmitDefaultValue=false)]
        public double? OriginalPrice { get; set; }

        /// <summary>
        /// The current price of the SKU with sales, if any. Set original_price for the base
        /// </summary>
        /// <value>The current price of the SKU with sales, if any. Set original_price for the base</value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public double? Price { get; private set; }

        /// <summary>
        /// Whether or not the SKU is currently published
        /// </summary>
        /// <value>Whether or not the SKU is currently published</value>
        [DataMember(Name="published", EmitDefaultValue=false)]
        public bool? Published { get; set; }

        /// <summary>
        /// The id of a sale affecting the price, if any
        /// </summary>
        /// <value>The id of a sale affecting the price, if any</value>
        [DataMember(Name="sale_id", EmitDefaultValue=false)]
        public int? SaleId { get; private set; }

        /// <summary>
        /// The name of a sale affecting the price, if any
        /// </summary>
        /// <value>The name of a sale affecting the price, if any</value>
        [DataMember(Name="sale_name", EmitDefaultValue=false)]
        public string SaleName { get; private set; }

        /// <summary>
        /// The stock keeping unit (SKU), a unique identifier for a given product.  Max 40 characters
        /// </summary>
        /// <value>The stock keeping unit (SKU), a unique identifier for a given product.  Max 40 characters</value>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string _Sku { get; set; }

        /// <summary>
        /// The date the sku becomes available, unix timestamp in seconds.  If set to null, sku will become available immediately
        /// </summary>
        /// <value>The date the sku becomes available, unix timestamp in seconds.  If set to null, sku will become available immediately</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public long? StartDate { get; set; }

        /// <summary>
        /// The date the sku becomes unavailable, unix timestamp in seconds.  If set to null, sku is always available
        /// </summary>
        /// <value>The date the sku becomes unavailable, unix timestamp in seconds.  If set to null, sku is always available</value>
        [DataMember(Name="stop_date", EmitDefaultValue=false)]
        public long? StopDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Sku {\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Inventory: ").Append(Inventory).Append("\n");
            sb.Append("  MinInventoryThreshold: ").Append(MinInventoryThreshold).Append("\n");
            sb.Append("  OriginalPrice: ").Append(OriginalPrice).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
            sb.Append("  SaleId: ").Append(SaleId).Append("\n");
            sb.Append("  SaleName: ").Append(SaleName).Append("\n");
            sb.Append("  _Sku: ").Append(_Sku).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  StopDate: ").Append(StopDate).Append("\n");
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
            return this.Equals(input as Sku);
        }

        /// <summary>
        /// Returns true if Sku instances are equal
        /// </summary>
        /// <param name="input">Instance of Sku to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Sku input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdditionalProperties == input.AdditionalProperties ||
                    (this.AdditionalProperties != null &&
                    this.AdditionalProperties.SequenceEqual(input.AdditionalProperties))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Inventory == input.Inventory ||
                    (this.Inventory != null &&
                    this.Inventory.Equals(input.Inventory))
                ) && 
                (
                    this.MinInventoryThreshold == input.MinInventoryThreshold ||
                    (this.MinInventoryThreshold != null &&
                    this.MinInventoryThreshold.Equals(input.MinInventoryThreshold))
                ) && 
                (
                    this.OriginalPrice == input.OriginalPrice ||
                    (this.OriginalPrice != null &&
                    this.OriginalPrice.Equals(input.OriginalPrice))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.Published == input.Published ||
                    (this.Published != null &&
                    this.Published.Equals(input.Published))
                ) && 
                (
                    this.SaleId == input.SaleId ||
                    (this.SaleId != null &&
                    this.SaleId.Equals(input.SaleId))
                ) && 
                (
                    this.SaleName == input.SaleName ||
                    (this.SaleName != null &&
                    this.SaleName.Equals(input.SaleName))
                ) && 
                (
                    this._Sku == input._Sku ||
                    (this._Sku != null &&
                    this._Sku.Equals(input._Sku))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.StopDate == input.StopDate ||
                    (this.StopDate != null &&
                    this.StopDate.Equals(input.StopDate))
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
                if (this.AdditionalProperties != null)
                    hashCode = hashCode * 59 + this.AdditionalProperties.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Inventory != null)
                    hashCode = hashCode * 59 + this.Inventory.GetHashCode();
                if (this.MinInventoryThreshold != null)
                    hashCode = hashCode * 59 + this.MinInventoryThreshold.GetHashCode();
                if (this.OriginalPrice != null)
                    hashCode = hashCode * 59 + this.OriginalPrice.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.Published != null)
                    hashCode = hashCode * 59 + this.Published.GetHashCode();
                if (this.SaleId != null)
                    hashCode = hashCode * 59 + this.SaleId.GetHashCode();
                if (this.SaleName != null)
                    hashCode = hashCode * 59 + this.SaleName.GetHashCode();
                if (this._Sku != null)
                    hashCode = hashCode * 59 + this._Sku.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.StopDate != null)
                    hashCode = hashCode * 59 + this.StopDate.GetHashCode();
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
