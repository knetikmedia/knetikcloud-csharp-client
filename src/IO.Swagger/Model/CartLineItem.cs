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
    /// CartLineItem
    /// </summary>
    [DataContract]
    public partial class CartLineItem :  IEquatable<CartLineItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartLineItem" /> class.
        /// </summary>
        /// <param name="CurrencyCode">CurrencyCode.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Discount">Discount.</param>
        /// <param name="LineTotal">LineTotal.</param>
        /// <param name="Name">Name.</param>
        /// <param name="OriginalLineTotal">OriginalLineTotal.</param>
        /// <param name="OriginalUnitPrice">OriginalUnitPrice.</param>
        /// <param name="Qty">Qty.</param>
        /// <param name="SaleName">SaleName.</param>
        /// <param name="Sku">Sku.</param>
        /// <param name="SkuDescription">SkuDescription.</param>
        /// <param name="StoreItemId">StoreItemId.</param>
        /// <param name="Tags">Tags.</param>
        /// <param name="ThumbUrl">ThumbUrl.</param>
        /// <param name="UnitPrice">UnitPrice.</param>
        /// <param name="VendorId">VendorId.</param>
        /// <param name="VendorName">VendorName.</param>
        public CartLineItem(string CurrencyCode = null, string Description = null, Discount Discount = null, double? LineTotal = null, string Name = null, double? OriginalLineTotal = null, double? OriginalUnitPrice = null, int? Qty = null, string SaleName = null, string Sku = null, string SkuDescription = null, int? StoreItemId = null, List<string> Tags = null, string ThumbUrl = null, double? UnitPrice = null, int? VendorId = null, string VendorName = null)
        {
            this.CurrencyCode = CurrencyCode;
            this.Description = Description;
            this.Discount = Discount;
            this.LineTotal = LineTotal;
            this.Name = Name;
            this.OriginalLineTotal = OriginalLineTotal;
            this.OriginalUnitPrice = OriginalUnitPrice;
            this.Qty = Qty;
            this.SaleName = SaleName;
            this.Sku = Sku;
            this.SkuDescription = SkuDescription;
            this.StoreItemId = StoreItemId;
            this.Tags = Tags;
            this.ThumbUrl = ThumbUrl;
            this.UnitPrice = UnitPrice;
            this.VendorId = VendorId;
            this.VendorName = VendorName;
        }
        
        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name="currency_code", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets Discount
        /// </summary>
        [DataMember(Name="discount", EmitDefaultValue=false)]
        public Discount Discount { get; set; }
        /// <summary>
        /// Gets or Sets LineTotal
        /// </summary>
        [DataMember(Name="line_total", EmitDefaultValue=false)]
        public double? LineTotal { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets OriginalLineTotal
        /// </summary>
        [DataMember(Name="original_line_total", EmitDefaultValue=false)]
        public double? OriginalLineTotal { get; set; }
        /// <summary>
        /// Gets or Sets OriginalUnitPrice
        /// </summary>
        [DataMember(Name="original_unit_price", EmitDefaultValue=false)]
        public double? OriginalUnitPrice { get; set; }
        /// <summary>
        /// Gets or Sets Qty
        /// </summary>
        [DataMember(Name="qty", EmitDefaultValue=false)]
        public int? Qty { get; set; }
        /// <summary>
        /// Gets or Sets SaleName
        /// </summary>
        [DataMember(Name="sale_name", EmitDefaultValue=false)]
        public string SaleName { get; set; }
        /// <summary>
        /// Gets or Sets Sku
        /// </summary>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }
        /// <summary>
        /// Gets or Sets SkuDescription
        /// </summary>
        [DataMember(Name="sku_description", EmitDefaultValue=false)]
        public string SkuDescription { get; set; }
        /// <summary>
        /// Gets or Sets StoreItemId
        /// </summary>
        [DataMember(Name="store_item_id", EmitDefaultValue=false)]
        public int? StoreItemId { get; set; }
        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }
        /// <summary>
        /// Gets or Sets ThumbUrl
        /// </summary>
        [DataMember(Name="thumb_url", EmitDefaultValue=false)]
        public string ThumbUrl { get; set; }
        /// <summary>
        /// Gets or Sets UnitPrice
        /// </summary>
        [DataMember(Name="unit_price", EmitDefaultValue=false)]
        public double? UnitPrice { get; set; }
        /// <summary>
        /// Gets or Sets VendorId
        /// </summary>
        [DataMember(Name="vendor_id", EmitDefaultValue=false)]
        public int? VendorId { get; set; }
        /// <summary>
        /// Gets or Sets VendorName
        /// </summary>
        [DataMember(Name="vendor_name", EmitDefaultValue=false)]
        public string VendorName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartLineItem {\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Discount: ").Append(Discount).Append("\n");
            sb.Append("  LineTotal: ").Append(LineTotal).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OriginalLineTotal: ").Append(OriginalLineTotal).Append("\n");
            sb.Append("  OriginalUnitPrice: ").Append(OriginalUnitPrice).Append("\n");
            sb.Append("  Qty: ").Append(Qty).Append("\n");
            sb.Append("  SaleName: ").Append(SaleName).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  SkuDescription: ").Append(SkuDescription).Append("\n");
            sb.Append("  StoreItemId: ").Append(StoreItemId).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  ThumbUrl: ").Append(ThumbUrl).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  VendorId: ").Append(VendorId).Append("\n");
            sb.Append("  VendorName: ").Append(VendorName).Append("\n");
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
            return this.Equals(obj as CartLineItem);
        }

        /// <summary>
        /// Returns true if CartLineItem instances are equal
        /// </summary>
        /// <param name="other">Instance of CartLineItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartLineItem other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Discount == other.Discount ||
                    this.Discount != null &&
                    this.Discount.Equals(other.Discount)
                ) && 
                (
                    this.LineTotal == other.LineTotal ||
                    this.LineTotal != null &&
                    this.LineTotal.Equals(other.LineTotal)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.OriginalLineTotal == other.OriginalLineTotal ||
                    this.OriginalLineTotal != null &&
                    this.OriginalLineTotal.Equals(other.OriginalLineTotal)
                ) && 
                (
                    this.OriginalUnitPrice == other.OriginalUnitPrice ||
                    this.OriginalUnitPrice != null &&
                    this.OriginalUnitPrice.Equals(other.OriginalUnitPrice)
                ) && 
                (
                    this.Qty == other.Qty ||
                    this.Qty != null &&
                    this.Qty.Equals(other.Qty)
                ) && 
                (
                    this.SaleName == other.SaleName ||
                    this.SaleName != null &&
                    this.SaleName.Equals(other.SaleName)
                ) && 
                (
                    this.Sku == other.Sku ||
                    this.Sku != null &&
                    this.Sku.Equals(other.Sku)
                ) && 
                (
                    this.SkuDescription == other.SkuDescription ||
                    this.SkuDescription != null &&
                    this.SkuDescription.Equals(other.SkuDescription)
                ) && 
                (
                    this.StoreItemId == other.StoreItemId ||
                    this.StoreItemId != null &&
                    this.StoreItemId.Equals(other.StoreItemId)
                ) && 
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(other.Tags)
                ) && 
                (
                    this.ThumbUrl == other.ThumbUrl ||
                    this.ThumbUrl != null &&
                    this.ThumbUrl.Equals(other.ThumbUrl)
                ) && 
                (
                    this.UnitPrice == other.UnitPrice ||
                    this.UnitPrice != null &&
                    this.UnitPrice.Equals(other.UnitPrice)
                ) && 
                (
                    this.VendorId == other.VendorId ||
                    this.VendorId != null &&
                    this.VendorId.Equals(other.VendorId)
                ) && 
                (
                    this.VendorName == other.VendorName ||
                    this.VendorName != null &&
                    this.VendorName.Equals(other.VendorName)
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
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Discount != null)
                    hash = hash * 59 + this.Discount.GetHashCode();
                if (this.LineTotal != null)
                    hash = hash * 59 + this.LineTotal.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.OriginalLineTotal != null)
                    hash = hash * 59 + this.OriginalLineTotal.GetHashCode();
                if (this.OriginalUnitPrice != null)
                    hash = hash * 59 + this.OriginalUnitPrice.GetHashCode();
                if (this.Qty != null)
                    hash = hash * 59 + this.Qty.GetHashCode();
                if (this.SaleName != null)
                    hash = hash * 59 + this.SaleName.GetHashCode();
                if (this.Sku != null)
                    hash = hash * 59 + this.Sku.GetHashCode();
                if (this.SkuDescription != null)
                    hash = hash * 59 + this.SkuDescription.GetHashCode();
                if (this.StoreItemId != null)
                    hash = hash * 59 + this.StoreItemId.GetHashCode();
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
                if (this.ThumbUrl != null)
                    hash = hash * 59 + this.ThumbUrl.GetHashCode();
                if (this.UnitPrice != null)
                    hash = hash * 59 + this.UnitPrice.GetHashCode();
                if (this.VendorId != null)
                    hash = hash * 59 + this.VendorId.GetHashCode();
                if (this.VendorName != null)
                    hash = hash * 59 + this.VendorName.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
