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
    /// CatalogSale
    /// </summary>
    [DataContract]
    public partial class CatalogSale :  IEquatable<CatalogSale>, IValidatableObject
    {
        /// <summary>
        /// The way in which the price is reduced. 'value' means subtracting directly, 'percentage' means subtracting by the price times the discountValue (1.0 == 100%)
        /// </summary>
        /// <value>The way in which the price is reduced. 'value' means subtracting directly, 'percentage' means subtracting by the price times the discountValue (1.0 == 100%)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DiscountTypeEnum
        {
            
            /// <summary>
            /// Enum Value for "value"
            /// </summary>
            [EnumMember(Value = "value")]
            Value,
            
            /// <summary>
            /// Enum Percentage for "percentage"
            /// </summary>
            [EnumMember(Value = "percentage")]
            Percentage
        }

        /// <summary>
        /// The way in which the price is reduced. 'value' means subtracting directly, 'percentage' means subtracting by the price times the discountValue (1.0 == 100%)
        /// </summary>
        /// <value>The way in which the price is reduced. 'value' means subtracting directly, 'percentage' means subtracting by the price times the discountValue (1.0 == 100%)</value>
        [DataMember(Name="discount_type", EmitDefaultValue=false)]
        public DiscountTypeEnum? DiscountType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogSale" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CatalogSale() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogSale" /> class.
        /// </summary>
        /// <param name="CurrencyCode">The iso3 code for the currency for this discountValue.  The sku purchased will have to match for it this sale to apply (required).</param>
        /// <param name="DiscountType">The way in which the price is reduced. &#39;value&#39; means subtracting directly, &#39;percentage&#39; means subtracting by the price times the discountValue (1.0 &#x3D;&#x3D; 100%) (required).</param>
        /// <param name="DiscountValue">The amount deducted from the price, in the same currencyCode as the item.</param>
        /// <param name="Item">The id of the item this sale applies to.  Leave null to use other filters.</param>
        /// <param name="LongDescription">The long description of the sale.</param>
        /// <param name="Name">The name of the sale.  Max 40 characters (required).</param>
        /// <param name="SaleEndDate">The date the sale ends, null for never.  Unix timestamp in seconds.</param>
        /// <param name="SaleStartDate">The date the sale begins.  Unix timestamp in seconds (required).</param>
        /// <param name="ShortDescription">The short description of the sale.  Max 140 characters.</param>
        /// <param name="Tag">The tag this sale applies to.  Leave null to skip this filter (applies to all tags).</param>
        /// <param name="Vendor">The id of the vendor this sale applies to.  Leave null to skip this filter (applies to all vendors).</param>
        public CatalogSale(string CurrencyCode = default(string), DiscountTypeEnum? DiscountType = default(DiscountTypeEnum?), double? DiscountValue = default(double?), int? Item = default(int?), string LongDescription = default(string), string Name = default(string), long? SaleEndDate = default(long?), long? SaleStartDate = default(long?), string ShortDescription = default(string), string Tag = default(string), int? Vendor = default(int?))
        {
            // to ensure "CurrencyCode" is required (not null)
            if (CurrencyCode == null)
            {
                throw new InvalidDataException("CurrencyCode is a required property for CatalogSale and cannot be null");
            }
            else
            {
                this.CurrencyCode = CurrencyCode;
            }
            // to ensure "DiscountType" is required (not null)
            if (DiscountType == null)
            {
                throw new InvalidDataException("DiscountType is a required property for CatalogSale and cannot be null");
            }
            else
            {
                this.DiscountType = DiscountType;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for CatalogSale and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "SaleStartDate" is required (not null)
            if (SaleStartDate == null)
            {
                throw new InvalidDataException("SaleStartDate is a required property for CatalogSale and cannot be null");
            }
            else
            {
                this.SaleStartDate = SaleStartDate;
            }
            this.DiscountValue = DiscountValue;
            this.Item = Item;
            this.LongDescription = LongDescription;
            this.SaleEndDate = SaleEndDate;
            this.ShortDescription = ShortDescription;
            this.Tag = Tag;
            this.Vendor = Vendor;
        }
        
        /// <summary>
        /// The iso3 code for the currency for this discountValue.  The sku purchased will have to match for it this sale to apply
        /// </summary>
        /// <value>The iso3 code for the currency for this discountValue.  The sku purchased will have to match for it this sale to apply</value>
        [DataMember(Name="currency_code", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }
        /// <summary>
        /// The amount deducted from the price, in the same currencyCode as the item
        /// </summary>
        /// <value>The amount deducted from the price, in the same currencyCode as the item</value>
        [DataMember(Name="discount_value", EmitDefaultValue=false)]
        public double? DiscountValue { get; set; }
        /// <summary>
        /// The id of the sale
        /// </summary>
        /// <value>The id of the sale</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
        /// <summary>
        /// The id of the item this sale applies to.  Leave null to use other filters
        /// </summary>
        /// <value>The id of the item this sale applies to.  Leave null to use other filters</value>
        [DataMember(Name="item", EmitDefaultValue=false)]
        public int? Item { get; set; }
        /// <summary>
        /// The long description of the sale
        /// </summary>
        /// <value>The long description of the sale</value>
        [DataMember(Name="long_description", EmitDefaultValue=false)]
        public string LongDescription { get; set; }
        /// <summary>
        /// The name of the sale.  Max 40 characters
        /// </summary>
        /// <value>The name of the sale.  Max 40 characters</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The date the sale ends, null for never.  Unix timestamp in seconds
        /// </summary>
        /// <value>The date the sale ends, null for never.  Unix timestamp in seconds</value>
        [DataMember(Name="sale_end_date", EmitDefaultValue=false)]
        public long? SaleEndDate { get; set; }
        /// <summary>
        /// The date the sale begins.  Unix timestamp in seconds
        /// </summary>
        /// <value>The date the sale begins.  Unix timestamp in seconds</value>
        [DataMember(Name="sale_start_date", EmitDefaultValue=false)]
        public long? SaleStartDate { get; set; }
        /// <summary>
        /// The short description of the sale.  Max 140 characters
        /// </summary>
        /// <value>The short description of the sale.  Max 140 characters</value>
        [DataMember(Name="short_description", EmitDefaultValue=false)]
        public string ShortDescription { get; set; }
        /// <summary>
        /// The tag this sale applies to.  Leave null to skip this filter (applies to all tags)
        /// </summary>
        /// <value>The tag this sale applies to.  Leave null to skip this filter (applies to all tags)</value>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        public string Tag { get; set; }
        /// <summary>
        /// The id of the vendor this sale applies to.  Leave null to skip this filter (applies to all vendors)
        /// </summary>
        /// <value>The id of the vendor this sale applies to.  Leave null to skip this filter (applies to all vendors)</value>
        [DataMember(Name="vendor", EmitDefaultValue=false)]
        public int? Vendor { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CatalogSale {\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  DiscountType: ").Append(DiscountType).Append("\n");
            sb.Append("  DiscountValue: ").Append(DiscountValue).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Item: ").Append(Item).Append("\n");
            sb.Append("  LongDescription: ").Append(LongDescription).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SaleEndDate: ").Append(SaleEndDate).Append("\n");
            sb.Append("  SaleStartDate: ").Append(SaleStartDate).Append("\n");
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Vendor: ").Append(Vendor).Append("\n");
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
            return this.Equals(obj as CatalogSale);
        }

        /// <summary>
        /// Returns true if CatalogSale instances are equal
        /// </summary>
        /// <param name="other">Instance of CatalogSale to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CatalogSale other)
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
                    this.DiscountType == other.DiscountType ||
                    this.DiscountType != null &&
                    this.DiscountType.Equals(other.DiscountType)
                ) && 
                (
                    this.DiscountValue == other.DiscountValue ||
                    this.DiscountValue != null &&
                    this.DiscountValue.Equals(other.DiscountValue)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Item == other.Item ||
                    this.Item != null &&
                    this.Item.Equals(other.Item)
                ) && 
                (
                    this.LongDescription == other.LongDescription ||
                    this.LongDescription != null &&
                    this.LongDescription.Equals(other.LongDescription)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.SaleEndDate == other.SaleEndDate ||
                    this.SaleEndDate != null &&
                    this.SaleEndDate.Equals(other.SaleEndDate)
                ) && 
                (
                    this.SaleStartDate == other.SaleStartDate ||
                    this.SaleStartDate != null &&
                    this.SaleStartDate.Equals(other.SaleStartDate)
                ) && 
                (
                    this.ShortDescription == other.ShortDescription ||
                    this.ShortDescription != null &&
                    this.ShortDescription.Equals(other.ShortDescription)
                ) && 
                (
                    this.Tag == other.Tag ||
                    this.Tag != null &&
                    this.Tag.Equals(other.Tag)
                ) && 
                (
                    this.Vendor == other.Vendor ||
                    this.Vendor != null &&
                    this.Vendor.Equals(other.Vendor)
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
                if (this.DiscountType != null)
                    hash = hash * 59 + this.DiscountType.GetHashCode();
                if (this.DiscountValue != null)
                    hash = hash * 59 + this.DiscountValue.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Item != null)
                    hash = hash * 59 + this.Item.GetHashCode();
                if (this.LongDescription != null)
                    hash = hash * 59 + this.LongDescription.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.SaleEndDate != null)
                    hash = hash * 59 + this.SaleEndDate.GetHashCode();
                if (this.SaleStartDate != null)
                    hash = hash * 59 + this.SaleStartDate.GetHashCode();
                if (this.ShortDescription != null)
                    hash = hash * 59 + this.ShortDescription.GetHashCode();
                if (this.Tag != null)
                    hash = hash * 59 + this.Tag.GetHashCode();
                if (this.Vendor != null)
                    hash = hash * 59 + this.Vendor.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
