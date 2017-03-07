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

namespace IO.Swagger.Model
{
    /// <summary>
    /// CouponDefinition
    /// </summary>
    [DataContract]
    public partial class CouponDefinition :  IEquatable<CouponDefinition>, IValidatableObject
    {
        /// <summary>
        /// The type of discount in terms of how it deducts price.
        /// </summary>
        /// <value>The type of discount in terms of how it deducts price.</value>
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
        /// The type of discount in terms of what it applies to. coupon_cart applies to the cart as a whole, other types apply to specific items based on different criteria.
        /// </summary>
        /// <value>The type of discount in terms of what it applies to. coupon_cart applies to the cart as a whole, other types apply to specific items based on different criteria.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Cart for "coupon_cart"
            /// </summary>
            [EnumMember(Value = "coupon_cart")]
            Cart,
            
            /// <summary>
            /// Enum Singleitem for "coupon_single_item"
            /// </summary>
            [EnumMember(Value = "coupon_single_item")]
            Singleitem,
            
            /// <summary>
            /// Enum Voucher for "coupon_voucher"
            /// </summary>
            [EnumMember(Value = "coupon_voucher")]
            Voucher,
            
            /// <summary>
            /// Enum Vendor for "coupon_vendor"
            /// </summary>
            [EnumMember(Value = "coupon_vendor")]
            Vendor,
            
            /// <summary>
            /// Enum Tag for "coupon_tag"
            /// </summary>
            [EnumMember(Value = "coupon_tag")]
            Tag
        }

        /// <summary>
        /// The type of discount in terms of how it deducts price.
        /// </summary>
        /// <value>The type of discount in terms of how it deducts price.</value>
        [DataMember(Name="discount_type", EmitDefaultValue=false)]
        public DiscountTypeEnum? DiscountType { get; set; }
        /// <summary>
        /// The type of discount in terms of what it applies to. coupon_cart applies to the cart as a whole, other types apply to specific items based on different criteria.
        /// </summary>
        /// <value>The type of discount in terms of what it applies to. coupon_cart applies to the cart as a whole, other types apply to specific items based on different criteria.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CouponDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponDefinition" /> class.
        /// </summary>
        /// <param name="Code">A unique identifier for the discount. Can be used to remove the discount, and uniqueness within the cart will be enforced. (required).</param>
        /// <param name="Description">A description for the discount..</param>
        /// <param name="DiscountType">The type of discount in terms of how it deducts price. (required).</param>
        /// <param name="Exclusive">Whether this discount is exclusive and cannot be used in conjunction with other discounts/coupons. default&#x3D;false.</param>
        /// <param name="MaxDiscount">For coupon_cart, a minimum total price that the cart must meet to be valid..</param>
        /// <param name="MaxQuantity">The maximum number of items to count this discount for (not for cart_coupon)..</param>
        /// <param name="MinCartTotal">For coupon_cart, a minimum total price that the cart must meet to be valid..</param>
        /// <param name="Name">A name for the discount. (required).</param>
        /// <param name="SelfExclusive">Whether this coupon is exclusive to itself or not (true means cannot add two of this same coupon to the same cart).  Default &#x3D; false.</param>
        /// <param name="TargetItemId">The id of the item this discount applies to, which must be present in the cart. Applies if coupon_type_hint is coupon_single_item or coupon_voucher..</param>
        /// <param name="Type">The type of discount in terms of what it applies to. coupon_cart applies to the cart as a whole, other types apply to specific items based on different criteria. (required).</param>
        /// <param name="ValidForTags">Which tags this applies for (item must have at least one of them), if coupon_type is coupon_tag..</param>
        /// <param name="Value">The amount of the discount. If discount_type is value then this is the raw currency amount to remove. If discount_type is percentage then this will be multiplied by the cart total or item price to get the discount amount (0.5 is half price). (required).</param>
        /// <param name="VendorId">Which vendor this applies for, if coupon_type is coupon_vendor..</param>
        public CouponDefinition(string Code = default(string), string Description = default(string), DiscountTypeEnum? DiscountType = default(DiscountTypeEnum?), bool? Exclusive = default(bool?), double? MaxDiscount = default(double?), int? MaxQuantity = default(int?), double? MinCartTotal = default(double?), string Name = default(string), bool? SelfExclusive = default(bool?), int? TargetItemId = default(int?), TypeEnum? Type = default(TypeEnum?), List<string> ValidForTags = default(List<string>), double? Value = default(double?), int? VendorId = default(int?))
        {
            // to ensure "Code" is required (not null)
            if (Code == null)
            {
                throw new InvalidDataException("Code is a required property for CouponDefinition and cannot be null");
            }
            else
            {
                this.Code = Code;
            }
            // to ensure "DiscountType" is required (not null)
            if (DiscountType == null)
            {
                throw new InvalidDataException("DiscountType is a required property for CouponDefinition and cannot be null");
            }
            else
            {
                this.DiscountType = DiscountType;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for CouponDefinition and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for CouponDefinition and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            // to ensure "Value" is required (not null)
            if (Value == null)
            {
                throw new InvalidDataException("Value is a required property for CouponDefinition and cannot be null");
            }
            else
            {
                this.Value = Value;
            }
            this.Description = Description;
            this.Exclusive = Exclusive;
            this.MaxDiscount = MaxDiscount;
            this.MaxQuantity = MaxQuantity;
            this.MinCartTotal = MinCartTotal;
            this.SelfExclusive = SelfExclusive;
            this.TargetItemId = TargetItemId;
            this.ValidForTags = ValidForTags;
            this.VendorId = VendorId;
        }
        
        /// <summary>
        /// A unique identifier for the discount. Can be used to remove the discount, and uniqueness within the cart will be enforced.
        /// </summary>
        /// <value>A unique identifier for the discount. Can be used to remove the discount, and uniqueness within the cart will be enforced.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }
        /// <summary>
        /// A description for the discount.
        /// </summary>
        /// <value>A description for the discount.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Whether this discount is exclusive and cannot be used in conjunction with other discounts/coupons. default&#x3D;false
        /// </summary>
        /// <value>Whether this discount is exclusive and cannot be used in conjunction with other discounts/coupons. default&#x3D;false</value>
        [DataMember(Name="exclusive", EmitDefaultValue=false)]
        public bool? Exclusive { get; set; }
        /// <summary>
        /// For coupon_cart, a minimum total price that the cart must meet to be valid.
        /// </summary>
        /// <value>For coupon_cart, a minimum total price that the cart must meet to be valid.</value>
        [DataMember(Name="max_discount", EmitDefaultValue=false)]
        public double? MaxDiscount { get; set; }
        /// <summary>
        /// The maximum number of items to count this discount for (not for cart_coupon).
        /// </summary>
        /// <value>The maximum number of items to count this discount for (not for cart_coupon).</value>
        [DataMember(Name="max_quantity", EmitDefaultValue=false)]
        public int? MaxQuantity { get; set; }
        /// <summary>
        /// For coupon_cart, a minimum total price that the cart must meet to be valid.
        /// </summary>
        /// <value>For coupon_cart, a minimum total price that the cart must meet to be valid.</value>
        [DataMember(Name="min_cart_total", EmitDefaultValue=false)]
        public double? MinCartTotal { get; set; }
        /// <summary>
        /// A name for the discount.
        /// </summary>
        /// <value>A name for the discount.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Whether this coupon is exclusive to itself or not (true means cannot add two of this same coupon to the same cart).  Default &#x3D; false
        /// </summary>
        /// <value>Whether this coupon is exclusive to itself or not (true means cannot add two of this same coupon to the same cart).  Default &#x3D; false</value>
        [DataMember(Name="self_exclusive", EmitDefaultValue=false)]
        public bool? SelfExclusive { get; set; }
        /// <summary>
        /// The id of the item this discount applies to, which must be present in the cart. Applies if coupon_type_hint is coupon_single_item or coupon_voucher.
        /// </summary>
        /// <value>The id of the item this discount applies to, which must be present in the cart. Applies if coupon_type_hint is coupon_single_item or coupon_voucher.</value>
        [DataMember(Name="target_item_id", EmitDefaultValue=false)]
        public int? TargetItemId { get; set; }
        /// <summary>
        /// Which tags this applies for (item must have at least one of them), if coupon_type is coupon_tag.
        /// </summary>
        /// <value>Which tags this applies for (item must have at least one of them), if coupon_type is coupon_tag.</value>
        [DataMember(Name="valid_for_tags", EmitDefaultValue=false)]
        public List<string> ValidForTags { get; set; }
        /// <summary>
        /// The amount of the discount. If discount_type is value then this is the raw currency amount to remove. If discount_type is percentage then this will be multiplied by the cart total or item price to get the discount amount (0.5 is half price).
        /// </summary>
        /// <value>The amount of the discount. If discount_type is value then this is the raw currency amount to remove. If discount_type is percentage then this will be multiplied by the cart total or item price to get the discount amount (0.5 is half price).</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public double? Value { get; set; }
        /// <summary>
        /// Which vendor this applies for, if coupon_type is coupon_vendor.
        /// </summary>
        /// <value>Which vendor this applies for, if coupon_type is coupon_vendor.</value>
        [DataMember(Name="vendor_id", EmitDefaultValue=false)]
        public int? VendorId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CouponDefinition {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DiscountType: ").Append(DiscountType).Append("\n");
            sb.Append("  Exclusive: ").Append(Exclusive).Append("\n");
            sb.Append("  MaxDiscount: ").Append(MaxDiscount).Append("\n");
            sb.Append("  MaxQuantity: ").Append(MaxQuantity).Append("\n");
            sb.Append("  MinCartTotal: ").Append(MinCartTotal).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SelfExclusive: ").Append(SelfExclusive).Append("\n");
            sb.Append("  TargetItemId: ").Append(TargetItemId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ValidForTags: ").Append(ValidForTags).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  VendorId: ").Append(VendorId).Append("\n");
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
            return this.Equals(obj as CouponDefinition);
        }

        /// <summary>
        /// Returns true if CouponDefinition instances are equal
        /// </summary>
        /// <param name="other">Instance of CouponDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CouponDefinition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.DiscountType == other.DiscountType ||
                    this.DiscountType != null &&
                    this.DiscountType.Equals(other.DiscountType)
                ) && 
                (
                    this.Exclusive == other.Exclusive ||
                    this.Exclusive != null &&
                    this.Exclusive.Equals(other.Exclusive)
                ) && 
                (
                    this.MaxDiscount == other.MaxDiscount ||
                    this.MaxDiscount != null &&
                    this.MaxDiscount.Equals(other.MaxDiscount)
                ) && 
                (
                    this.MaxQuantity == other.MaxQuantity ||
                    this.MaxQuantity != null &&
                    this.MaxQuantity.Equals(other.MaxQuantity)
                ) && 
                (
                    this.MinCartTotal == other.MinCartTotal ||
                    this.MinCartTotal != null &&
                    this.MinCartTotal.Equals(other.MinCartTotal)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.SelfExclusive == other.SelfExclusive ||
                    this.SelfExclusive != null &&
                    this.SelfExclusive.Equals(other.SelfExclusive)
                ) && 
                (
                    this.TargetItemId == other.TargetItemId ||
                    this.TargetItemId != null &&
                    this.TargetItemId.Equals(other.TargetItemId)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.ValidForTags == other.ValidForTags ||
                    this.ValidForTags != null &&
                    this.ValidForTags.SequenceEqual(other.ValidForTags)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) && 
                (
                    this.VendorId == other.VendorId ||
                    this.VendorId != null &&
                    this.VendorId.Equals(other.VendorId)
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
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.DiscountType != null)
                    hash = hash * 59 + this.DiscountType.GetHashCode();
                if (this.Exclusive != null)
                    hash = hash * 59 + this.Exclusive.GetHashCode();
                if (this.MaxDiscount != null)
                    hash = hash * 59 + this.MaxDiscount.GetHashCode();
                if (this.MaxQuantity != null)
                    hash = hash * 59 + this.MaxQuantity.GetHashCode();
                if (this.MinCartTotal != null)
                    hash = hash * 59 + this.MinCartTotal.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.SelfExclusive != null)
                    hash = hash * 59 + this.SelfExclusive.GetHashCode();
                if (this.TargetItemId != null)
                    hash = hash * 59 + this.TargetItemId.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.ValidForTags != null)
                    hash = hash * 59 + this.ValidForTags.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                if (this.VendorId != null)
                    hash = hash * 59 + this.VendorId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
