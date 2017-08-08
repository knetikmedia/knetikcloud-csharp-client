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
    /// InvoiceItemResource
    /// </summary>
    [DataContract]
    public partial class InvoiceItemResource :  IEquatable<InvoiceItemResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceItemResource" /> class.
        /// </summary>
        /// <param name="BundleSku">BundleSku.</param>
        /// <param name="CurrentFulfillmentStatus">CurrentFulfillmentStatus.</param>
        /// <param name="Id">Id.</param>
        /// <param name="InvoiceId">InvoiceId.</param>
        /// <param name="ItemId">ItemId.</param>
        /// <param name="ItemName">ItemName.</param>
        /// <param name="OriginalTotalPrice">OriginalTotalPrice.</param>
        /// <param name="OriginalUnitPrice">OriginalUnitPrice.</param>
        /// <param name="Qty">Qty.</param>
        /// <param name="SaleName">SaleName.</param>
        /// <param name="Sku">Sku.</param>
        /// <param name="SkuDescription">SkuDescription.</param>
        /// <param name="SystemPrice">SystemPrice.</param>
        /// <param name="TotalPrice">TotalPrice.</param>
        /// <param name="TypeHint">TypeHint.</param>
        /// <param name="UnitPrice">UnitPrice.</param>
        public InvoiceItemResource(string BundleSku = default(string), string CurrentFulfillmentStatus = default(string), int? Id = default(int?), int? InvoiceId = default(int?), int? ItemId = default(int?), string ItemName = default(string), double? OriginalTotalPrice = default(double?), double? OriginalUnitPrice = default(double?), int? Qty = default(int?), string SaleName = default(string), string Sku = default(string), string SkuDescription = default(string), double? SystemPrice = default(double?), double? TotalPrice = default(double?), string TypeHint = default(string), double? UnitPrice = default(double?))
        {
            this.BundleSku = BundleSku;
            this.CurrentFulfillmentStatus = CurrentFulfillmentStatus;
            this.Id = Id;
            this.InvoiceId = InvoiceId;
            this.ItemId = ItemId;
            this.ItemName = ItemName;
            this.OriginalTotalPrice = OriginalTotalPrice;
            this.OriginalUnitPrice = OriginalUnitPrice;
            this.Qty = Qty;
            this.SaleName = SaleName;
            this.Sku = Sku;
            this.SkuDescription = SkuDescription;
            this.SystemPrice = SystemPrice;
            this.TotalPrice = TotalPrice;
            this.TypeHint = TypeHint;
            this.UnitPrice = UnitPrice;
        }
        
        /// <summary>
        /// Gets or Sets BundleSku
        /// </summary>
        [DataMember(Name="bundle_sku", EmitDefaultValue=false)]
        public string BundleSku { get; set; }

        /// <summary>
        /// Gets or Sets CurrentFulfillmentStatus
        /// </summary>
        [DataMember(Name="current_fulfillment_status", EmitDefaultValue=false)]
        public string CurrentFulfillmentStatus { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceId
        /// </summary>
        [DataMember(Name="invoice_id", EmitDefaultValue=false)]
        public int? InvoiceId { get; set; }

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
        /// Gets or Sets OriginalTotalPrice
        /// </summary>
        [DataMember(Name="original_total_price", EmitDefaultValue=false)]
        public double? OriginalTotalPrice { get; set; }

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
        /// Gets or Sets SystemPrice
        /// </summary>
        [DataMember(Name="system_price", EmitDefaultValue=false)]
        public double? SystemPrice { get; set; }

        /// <summary>
        /// Gets or Sets TotalPrice
        /// </summary>
        [DataMember(Name="total_price", EmitDefaultValue=false)]
        public double? TotalPrice { get; set; }

        /// <summary>
        /// Gets or Sets TypeHint
        /// </summary>
        [DataMember(Name="type_hint", EmitDefaultValue=false)]
        public string TypeHint { get; set; }

        /// <summary>
        /// Gets or Sets UnitPrice
        /// </summary>
        [DataMember(Name="unit_price", EmitDefaultValue=false)]
        public double? UnitPrice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvoiceItemResource {\n");
            sb.Append("  BundleSku: ").Append(BundleSku).Append("\n");
            sb.Append("  CurrentFulfillmentStatus: ").Append(CurrentFulfillmentStatus).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  ItemName: ").Append(ItemName).Append("\n");
            sb.Append("  OriginalTotalPrice: ").Append(OriginalTotalPrice).Append("\n");
            sb.Append("  OriginalUnitPrice: ").Append(OriginalUnitPrice).Append("\n");
            sb.Append("  Qty: ").Append(Qty).Append("\n");
            sb.Append("  SaleName: ").Append(SaleName).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  SkuDescription: ").Append(SkuDescription).Append("\n");
            sb.Append("  SystemPrice: ").Append(SystemPrice).Append("\n");
            sb.Append("  TotalPrice: ").Append(TotalPrice).Append("\n");
            sb.Append("  TypeHint: ").Append(TypeHint).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
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
            return this.Equals(input as InvoiceItemResource);
        }

        /// <summary>
        /// Returns true if InvoiceItemResource instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceItemResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceItemResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BundleSku == input.BundleSku ||
                    (this.BundleSku != null &&
                    this.BundleSku.Equals(input.BundleSku))
                ) && 
                (
                    this.CurrentFulfillmentStatus == input.CurrentFulfillmentStatus ||
                    (this.CurrentFulfillmentStatus != null &&
                    this.CurrentFulfillmentStatus.Equals(input.CurrentFulfillmentStatus))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.InvoiceId == input.InvoiceId ||
                    (this.InvoiceId != null &&
                    this.InvoiceId.Equals(input.InvoiceId))
                ) && 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
                ) && 
                (
                    this.ItemName == input.ItemName ||
                    (this.ItemName != null &&
                    this.ItemName.Equals(input.ItemName))
                ) && 
                (
                    this.OriginalTotalPrice == input.OriginalTotalPrice ||
                    (this.OriginalTotalPrice != null &&
                    this.OriginalTotalPrice.Equals(input.OriginalTotalPrice))
                ) && 
                (
                    this.OriginalUnitPrice == input.OriginalUnitPrice ||
                    (this.OriginalUnitPrice != null &&
                    this.OriginalUnitPrice.Equals(input.OriginalUnitPrice))
                ) && 
                (
                    this.Qty == input.Qty ||
                    (this.Qty != null &&
                    this.Qty.Equals(input.Qty))
                ) && 
                (
                    this.SaleName == input.SaleName ||
                    (this.SaleName != null &&
                    this.SaleName.Equals(input.SaleName))
                ) && 
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
                ) && 
                (
                    this.SkuDescription == input.SkuDescription ||
                    (this.SkuDescription != null &&
                    this.SkuDescription.Equals(input.SkuDescription))
                ) && 
                (
                    this.SystemPrice == input.SystemPrice ||
                    (this.SystemPrice != null &&
                    this.SystemPrice.Equals(input.SystemPrice))
                ) && 
                (
                    this.TotalPrice == input.TotalPrice ||
                    (this.TotalPrice != null &&
                    this.TotalPrice.Equals(input.TotalPrice))
                ) && 
                (
                    this.TypeHint == input.TypeHint ||
                    (this.TypeHint != null &&
                    this.TypeHint.Equals(input.TypeHint))
                ) && 
                (
                    this.UnitPrice == input.UnitPrice ||
                    (this.UnitPrice != null &&
                    this.UnitPrice.Equals(input.UnitPrice))
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
                if (this.BundleSku != null)
                    hashCode = hashCode * 59 + this.BundleSku.GetHashCode();
                if (this.CurrentFulfillmentStatus != null)
                    hashCode = hashCode * 59 + this.CurrentFulfillmentStatus.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InvoiceId != null)
                    hashCode = hashCode * 59 + this.InvoiceId.GetHashCode();
                if (this.ItemId != null)
                    hashCode = hashCode * 59 + this.ItemId.GetHashCode();
                if (this.ItemName != null)
                    hashCode = hashCode * 59 + this.ItemName.GetHashCode();
                if (this.OriginalTotalPrice != null)
                    hashCode = hashCode * 59 + this.OriginalTotalPrice.GetHashCode();
                if (this.OriginalUnitPrice != null)
                    hashCode = hashCode * 59 + this.OriginalUnitPrice.GetHashCode();
                if (this.Qty != null)
                    hashCode = hashCode * 59 + this.Qty.GetHashCode();
                if (this.SaleName != null)
                    hashCode = hashCode * 59 + this.SaleName.GetHashCode();
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                if (this.SkuDescription != null)
                    hashCode = hashCode * 59 + this.SkuDescription.GetHashCode();
                if (this.SystemPrice != null)
                    hashCode = hashCode * 59 + this.SystemPrice.GetHashCode();
                if (this.TotalPrice != null)
                    hashCode = hashCode * 59 + this.TotalPrice.GetHashCode();
                if (this.TypeHint != null)
                    hashCode = hashCode * 59 + this.TypeHint.GetHashCode();
                if (this.UnitPrice != null)
                    hashCode = hashCode * 59 + this.UnitPrice.GetHashCode();
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
