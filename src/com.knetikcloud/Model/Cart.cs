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

namespace com.knetikcloud.Model
{
    /// <summary>
    /// Cart
    /// </summary>
    [DataContract]
    public partial class Cart :  IEquatable<Cart>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Active for "active"
            /// </summary>
            [EnumMember(Value = "active")]
            Active,
            
            /// <summary>
            /// Enum Processing for "processing"
            /// </summary>
            [EnumMember(Value = "processing")]
            Processing,
            
            /// <summary>
            /// Enum Closed for "closed"
            /// </summary>
            [EnumMember(Value = "closed")]
            Closed,
            
            /// <summary>
            /// Enum Onhold for "onhold"
            /// </summary>
            [EnumMember(Value = "onhold")]
            Onhold
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Cart" /> class.
        /// </summary>
        /// <param name="CountryTax">CountryTax.</param>
        /// <param name="Coupons">Coupons.</param>
        /// <param name="Created">Created.</param>
        /// <param name="CurrencyCode">CurrencyCode.</param>
        /// <param name="DiscountTotal">DiscountTotal.</param>
        /// <param name="ErrorCode">ErrorCode.</param>
        /// <param name="ErrorMessage">ErrorMessage.</param>
        /// <param name="GrandTotal">GrandTotal.</param>
        /// <param name="Id">Id.</param>
        /// <param name="InvoiceId">InvoiceId.</param>
        /// <param name="Items">Items.</param>
        /// <param name="Owner">Owner.</param>
        /// <param name="SelectedShippingOptions">SelectedShippingOptions.</param>
        /// <param name="Shippable">Shippable.</param>
        /// <param name="ShippingAddress">ShippingAddress.</param>
        /// <param name="ShippingCost">ShippingCost.</param>
        /// <param name="ShippingOptions">ShippingOptions.</param>
        /// <param name="StateTax">StateTax.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Subtotal">Subtotal.</param>
        /// <param name="Updated">Updated.</param>
        public Cart(double? CountryTax = default(double?), List<CouponDefinition> Coupons = default(List<CouponDefinition>), long? Created = default(long?), string CurrencyCode = default(string), double? DiscountTotal = default(double?), int? ErrorCode = default(int?), string ErrorMessage = default(string), double? GrandTotal = default(double?), string Id = default(string), double? InvoiceId = default(double?), List<CartLineItem> Items = default(List<CartLineItem>), int? Owner = default(int?), List<CartShippingOption> SelectedShippingOptions = default(List<CartShippingOption>), bool? Shippable = default(bool?), CartShippingAddressRequest ShippingAddress = default(CartShippingAddressRequest), double? ShippingCost = default(double?), Dictionary<string, Set> ShippingOptions = default(Dictionary<string, Set>), double? StateTax = default(double?), StatusEnum? Status = default(StatusEnum?), double? Subtotal = default(double?), long? Updated = default(long?))
        {
            this.CountryTax = CountryTax;
            this.Coupons = Coupons;
            this.Created = Created;
            this.CurrencyCode = CurrencyCode;
            this.DiscountTotal = DiscountTotal;
            this.ErrorCode = ErrorCode;
            this.ErrorMessage = ErrorMessage;
            this.GrandTotal = GrandTotal;
            this.Id = Id;
            this.InvoiceId = InvoiceId;
            this.Items = Items;
            this.Owner = Owner;
            this.SelectedShippingOptions = SelectedShippingOptions;
            this.Shippable = Shippable;
            this.ShippingAddress = ShippingAddress;
            this.ShippingCost = ShippingCost;
            this.ShippingOptions = ShippingOptions;
            this.StateTax = StateTax;
            this.Status = Status;
            this.Subtotal = Subtotal;
            this.Updated = Updated;
        }
        
        /// <summary>
        /// Gets or Sets CountryTax
        /// </summary>
        [DataMember(Name="country_tax", EmitDefaultValue=false)]
        public double? CountryTax { get; set; }
        /// <summary>
        /// Gets or Sets Coupons
        /// </summary>
        [DataMember(Name="coupons", EmitDefaultValue=false)]
        public List<CouponDefinition> Coupons { get; set; }
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public long? Created { get; set; }
        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name="currency_code", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }
        /// <summary>
        /// Gets or Sets DiscountTotal
        /// </summary>
        [DataMember(Name="discount_total", EmitDefaultValue=false)]
        public double? DiscountTotal { get; set; }
        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name="error_code", EmitDefaultValue=false)]
        public int? ErrorCode { get; set; }
        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name="error_message", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }
        /// <summary>
        /// Gets or Sets GrandTotal
        /// </summary>
        [DataMember(Name="grand_total", EmitDefaultValue=false)]
        public double? GrandTotal { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets InvoiceId
        /// </summary>
        [DataMember(Name="invoice_id", EmitDefaultValue=false)]
        public double? InvoiceId { get; set; }
        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<CartLineItem> Items { get; set; }
        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public int? Owner { get; set; }
        /// <summary>
        /// Gets or Sets SelectedShippingOptions
        /// </summary>
        [DataMember(Name="selected_shipping_options", EmitDefaultValue=false)]
        public List<CartShippingOption> SelectedShippingOptions { get; set; }
        /// <summary>
        /// Gets or Sets Shippable
        /// </summary>
        [DataMember(Name="shippable", EmitDefaultValue=false)]
        public bool? Shippable { get; set; }
        /// <summary>
        /// Gets or Sets ShippingAddress
        /// </summary>
        [DataMember(Name="shipping_address", EmitDefaultValue=false)]
        public CartShippingAddressRequest ShippingAddress { get; set; }
        /// <summary>
        /// Gets or Sets ShippingCost
        /// </summary>
        [DataMember(Name="shipping_cost", EmitDefaultValue=false)]
        public double? ShippingCost { get; set; }
        /// <summary>
        /// Gets or Sets ShippingOptions
        /// </summary>
        [DataMember(Name="shipping_options", EmitDefaultValue=false)]
        public Dictionary<string, Set> ShippingOptions { get; set; }
        /// <summary>
        /// Gets or Sets StateTax
        /// </summary>
        [DataMember(Name="state_tax", EmitDefaultValue=false)]
        public double? StateTax { get; set; }
        /// <summary>
        /// Gets or Sets Subtotal
        /// </summary>
        [DataMember(Name="subtotal", EmitDefaultValue=false)]
        public double? Subtotal { get; set; }
        /// <summary>
        /// Gets or Sets Updated
        /// </summary>
        [DataMember(Name="updated", EmitDefaultValue=false)]
        public long? Updated { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Cart {\n");
            sb.Append("  CountryTax: ").Append(CountryTax).Append("\n");
            sb.Append("  Coupons: ").Append(Coupons).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  DiscountTotal: ").Append(DiscountTotal).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  GrandTotal: ").Append(GrandTotal).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  SelectedShippingOptions: ").Append(SelectedShippingOptions).Append("\n");
            sb.Append("  Shippable: ").Append(Shippable).Append("\n");
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
            sb.Append("  ShippingCost: ").Append(ShippingCost).Append("\n");
            sb.Append("  ShippingOptions: ").Append(ShippingOptions).Append("\n");
            sb.Append("  StateTax: ").Append(StateTax).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Subtotal: ").Append(Subtotal).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
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
            return this.Equals(obj as Cart);
        }

        /// <summary>
        /// Returns true if Cart instances are equal
        /// </summary>
        /// <param name="other">Instance of Cart to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Cart other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CountryTax == other.CountryTax ||
                    this.CountryTax != null &&
                    this.CountryTax.Equals(other.CountryTax)
                ) && 
                (
                    this.Coupons == other.Coupons ||
                    this.Coupons != null &&
                    this.Coupons.SequenceEqual(other.Coupons)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.CurrencyCode == other.CurrencyCode ||
                    this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(other.CurrencyCode)
                ) && 
                (
                    this.DiscountTotal == other.DiscountTotal ||
                    this.DiscountTotal != null &&
                    this.DiscountTotal.Equals(other.DiscountTotal)
                ) && 
                (
                    this.ErrorCode == other.ErrorCode ||
                    this.ErrorCode != null &&
                    this.ErrorCode.Equals(other.ErrorCode)
                ) && 
                (
                    this.ErrorMessage == other.ErrorMessage ||
                    this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(other.ErrorMessage)
                ) && 
                (
                    this.GrandTotal == other.GrandTotal ||
                    this.GrandTotal != null &&
                    this.GrandTotal.Equals(other.GrandTotal)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.InvoiceId == other.InvoiceId ||
                    this.InvoiceId != null &&
                    this.InvoiceId.Equals(other.InvoiceId)
                ) && 
                (
                    this.Items == other.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(other.Items)
                ) && 
                (
                    this.Owner == other.Owner ||
                    this.Owner != null &&
                    this.Owner.Equals(other.Owner)
                ) && 
                (
                    this.SelectedShippingOptions == other.SelectedShippingOptions ||
                    this.SelectedShippingOptions != null &&
                    this.SelectedShippingOptions.SequenceEqual(other.SelectedShippingOptions)
                ) && 
                (
                    this.Shippable == other.Shippable ||
                    this.Shippable != null &&
                    this.Shippable.Equals(other.Shippable)
                ) && 
                (
                    this.ShippingAddress == other.ShippingAddress ||
                    this.ShippingAddress != null &&
                    this.ShippingAddress.Equals(other.ShippingAddress)
                ) && 
                (
                    this.ShippingCost == other.ShippingCost ||
                    this.ShippingCost != null &&
                    this.ShippingCost.Equals(other.ShippingCost)
                ) && 
                (
                    this.ShippingOptions == other.ShippingOptions ||
                    this.ShippingOptions != null &&
                    this.ShippingOptions.SequenceEqual(other.ShippingOptions)
                ) && 
                (
                    this.StateTax == other.StateTax ||
                    this.StateTax != null &&
                    this.StateTax.Equals(other.StateTax)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Subtotal == other.Subtotal ||
                    this.Subtotal != null &&
                    this.Subtotal.Equals(other.Subtotal)
                ) && 
                (
                    this.Updated == other.Updated ||
                    this.Updated != null &&
                    this.Updated.Equals(other.Updated)
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
                if (this.CountryTax != null)
                    hash = hash * 59 + this.CountryTax.GetHashCode();
                if (this.Coupons != null)
                    hash = hash * 59 + this.Coupons.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.CurrencyCode != null)
                    hash = hash * 59 + this.CurrencyCode.GetHashCode();
                if (this.DiscountTotal != null)
                    hash = hash * 59 + this.DiscountTotal.GetHashCode();
                if (this.ErrorCode != null)
                    hash = hash * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMessage != null)
                    hash = hash * 59 + this.ErrorMessage.GetHashCode();
                if (this.GrandTotal != null)
                    hash = hash * 59 + this.GrandTotal.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.InvoiceId != null)
                    hash = hash * 59 + this.InvoiceId.GetHashCode();
                if (this.Items != null)
                    hash = hash * 59 + this.Items.GetHashCode();
                if (this.Owner != null)
                    hash = hash * 59 + this.Owner.GetHashCode();
                if (this.SelectedShippingOptions != null)
                    hash = hash * 59 + this.SelectedShippingOptions.GetHashCode();
                if (this.Shippable != null)
                    hash = hash * 59 + this.Shippable.GetHashCode();
                if (this.ShippingAddress != null)
                    hash = hash * 59 + this.ShippingAddress.GetHashCode();
                if (this.ShippingCost != null)
                    hash = hash * 59 + this.ShippingCost.GetHashCode();
                if (this.ShippingOptions != null)
                    hash = hash * 59 + this.ShippingOptions.GetHashCode();
                if (this.StateTax != null)
                    hash = hash * 59 + this.StateTax.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Subtotal != null)
                    hash = hash * 59 + this.Subtotal.GetHashCode();
                if (this.Updated != null)
                    hash = hash * 59 + this.Updated.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
