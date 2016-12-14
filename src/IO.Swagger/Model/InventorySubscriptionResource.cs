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
    /// InventorySubscriptionResource
    /// </summary>
    [DataContract]
    public partial class InventorySubscriptionResource :  IEquatable<InventorySubscriptionResource>, IValidatableObject
    {
        /// <summary>
        /// The inventory status object
        /// </summary>
        /// <value>The inventory status object</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InventoryStatusEnum
        {
            
            /// <summary>
            /// Enum Pending for "pending"
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending,
            
            /// <summary>
            /// Enum Active for "active"
            /// </summary>
            [EnumMember(Value = "active")]
            Active,
            
            /// <summary>
            /// Enum Inactive for "inactive"
            /// </summary>
            [EnumMember(Value = "inactive")]
            Inactive
        }

        /// <summary>
        /// The inventory status object
        /// </summary>
        /// <value>The inventory status object</value>
        [DataMember(Name="inventory_status", EmitDefaultValue=false)]
        public InventoryStatusEnum? InventoryStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InventorySubscriptionResource" /> class.
        /// </summary>
        /// <param name="BillDate">The date the subscription will be billed.</param>
        /// <param name="CreditLog">A record of past and present credit/debt changes.</param>
        /// <param name="GraceEnd">The date the grace period ends.</param>
        /// <param name="InventoryId">The id of the inventory.</param>
        /// <param name="InventoryStatus">The inventory status object.</param>
        /// <param name="ItemId">The id of the item.</param>
        /// <param name="PaymentMethod">The payment method object.</param>
        /// <param name="RecurringPrice">The recurring price.</param>
        /// <param name="Sku">The sku of the subscription.</param>
        /// <param name="StartDate">The date the subscription will start.</param>
        /// <param name="SubscriptionStatus">The status of the subscription.</param>
        /// <param name="User">The user.</param>
        public InventorySubscriptionResource(long? BillDate = null, List<SubscriptionCreditResource> CreditLog = null, long? GraceEnd = null, int? InventoryId = null, InventoryStatusEnum? InventoryStatus = null, int? ItemId = null, PaymentMethodResource PaymentMethod = null, double? RecurringPrice = null, string Sku = null, long? StartDate = null, int? SubscriptionStatus = null, SimpleUserResource User = null)
        {
            this.BillDate = BillDate;
            this.CreditLog = CreditLog;
            this.GraceEnd = GraceEnd;
            this.InventoryId = InventoryId;
            this.InventoryStatus = InventoryStatus;
            this.ItemId = ItemId;
            this.PaymentMethod = PaymentMethod;
            this.RecurringPrice = RecurringPrice;
            this.Sku = Sku;
            this.StartDate = StartDate;
            this.SubscriptionStatus = SubscriptionStatus;
            this.User = User;
        }
        
        /// <summary>
        /// The date the subscription will be billed
        /// </summary>
        /// <value>The date the subscription will be billed</value>
        [DataMember(Name="bill_date", EmitDefaultValue=false)]
        public long? BillDate { get; set; }
        /// <summary>
        /// A credit of money already applied to a subscription for the next bill, or a debt if negative
        /// </summary>
        /// <value>A credit of money already applied to a subscription for the next bill, or a debt if negative</value>
        [DataMember(Name="credit", EmitDefaultValue=false)]
        public double? Credit { get; private set; }
        /// <summary>
        /// A record of past and present credit/debt changes
        /// </summary>
        /// <value>A record of past and present credit/debt changes</value>
        [DataMember(Name="credit_log", EmitDefaultValue=false)]
        public List<SubscriptionCreditResource> CreditLog { get; set; }
        /// <summary>
        /// The date the grace period ends
        /// </summary>
        /// <value>The date the grace period ends</value>
        [DataMember(Name="grace_end", EmitDefaultValue=false)]
        public long? GraceEnd { get; set; }
        /// <summary>
        /// The id of the inventory
        /// </summary>
        /// <value>The id of the inventory</value>
        [DataMember(Name="inventory_id", EmitDefaultValue=false)]
        public int? InventoryId { get; set; }
        /// <summary>
        /// The id of the item
        /// </summary>
        /// <value>The id of the item</value>
        [DataMember(Name="item_id", EmitDefaultValue=false)]
        public int? ItemId { get; set; }
        /// <summary>
        /// The payment method object
        /// </summary>
        /// <value>The payment method object</value>
        [DataMember(Name="payment_method", EmitDefaultValue=false)]
        public PaymentMethodResource PaymentMethod { get; set; }
        /// <summary>
        /// The recurring price
        /// </summary>
        /// <value>The recurring price</value>
        [DataMember(Name="recurring_price", EmitDefaultValue=false)]
        public double? RecurringPrice { get; set; }
        /// <summary>
        /// The sku of the subscription
        /// </summary>
        /// <value>The sku of the subscription</value>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }
        /// <summary>
        /// The date the subscription will start
        /// </summary>
        /// <value>The date the subscription will start</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public long? StartDate { get; set; }
        /// <summary>
        /// The status of the subscription
        /// </summary>
        /// <value>The status of the subscription</value>
        [DataMember(Name="subscription_status", EmitDefaultValue=false)]
        public int? SubscriptionStatus { get; set; }
        /// <summary>
        /// The user
        /// </summary>
        /// <value>The user</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public SimpleUserResource User { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InventorySubscriptionResource {\n");
            sb.Append("  BillDate: ").Append(BillDate).Append("\n");
            sb.Append("  Credit: ").Append(Credit).Append("\n");
            sb.Append("  CreditLog: ").Append(CreditLog).Append("\n");
            sb.Append("  GraceEnd: ").Append(GraceEnd).Append("\n");
            sb.Append("  InventoryId: ").Append(InventoryId).Append("\n");
            sb.Append("  InventoryStatus: ").Append(InventoryStatus).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  RecurringPrice: ").Append(RecurringPrice).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  SubscriptionStatus: ").Append(SubscriptionStatus).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(obj as InventorySubscriptionResource);
        }

        /// <summary>
        /// Returns true if InventorySubscriptionResource instances are equal
        /// </summary>
        /// <param name="other">Instance of InventorySubscriptionResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InventorySubscriptionResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BillDate == other.BillDate ||
                    this.BillDate != null &&
                    this.BillDate.Equals(other.BillDate)
                ) && 
                (
                    this.Credit == other.Credit ||
                    this.Credit != null &&
                    this.Credit.Equals(other.Credit)
                ) && 
                (
                    this.CreditLog == other.CreditLog ||
                    this.CreditLog != null &&
                    this.CreditLog.SequenceEqual(other.CreditLog)
                ) && 
                (
                    this.GraceEnd == other.GraceEnd ||
                    this.GraceEnd != null &&
                    this.GraceEnd.Equals(other.GraceEnd)
                ) && 
                (
                    this.InventoryId == other.InventoryId ||
                    this.InventoryId != null &&
                    this.InventoryId.Equals(other.InventoryId)
                ) && 
                (
                    this.InventoryStatus == other.InventoryStatus ||
                    this.InventoryStatus != null &&
                    this.InventoryStatus.Equals(other.InventoryStatus)
                ) && 
                (
                    this.ItemId == other.ItemId ||
                    this.ItemId != null &&
                    this.ItemId.Equals(other.ItemId)
                ) && 
                (
                    this.PaymentMethod == other.PaymentMethod ||
                    this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(other.PaymentMethod)
                ) && 
                (
                    this.RecurringPrice == other.RecurringPrice ||
                    this.RecurringPrice != null &&
                    this.RecurringPrice.Equals(other.RecurringPrice)
                ) && 
                (
                    this.Sku == other.Sku ||
                    this.Sku != null &&
                    this.Sku.Equals(other.Sku)
                ) && 
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) && 
                (
                    this.SubscriptionStatus == other.SubscriptionStatus ||
                    this.SubscriptionStatus != null &&
                    this.SubscriptionStatus.Equals(other.SubscriptionStatus)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
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
                if (this.BillDate != null)
                    hash = hash * 59 + this.BillDate.GetHashCode();
                if (this.Credit != null)
                    hash = hash * 59 + this.Credit.GetHashCode();
                if (this.CreditLog != null)
                    hash = hash * 59 + this.CreditLog.GetHashCode();
                if (this.GraceEnd != null)
                    hash = hash * 59 + this.GraceEnd.GetHashCode();
                if (this.InventoryId != null)
                    hash = hash * 59 + this.InventoryId.GetHashCode();
                if (this.InventoryStatus != null)
                    hash = hash * 59 + this.InventoryStatus.GetHashCode();
                if (this.ItemId != null)
                    hash = hash * 59 + this.ItemId.GetHashCode();
                if (this.PaymentMethod != null)
                    hash = hash * 59 + this.PaymentMethod.GetHashCode();
                if (this.RecurringPrice != null)
                    hash = hash * 59 + this.RecurringPrice.GetHashCode();
                if (this.Sku != null)
                    hash = hash * 59 + this.Sku.GetHashCode();
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                if (this.SubscriptionStatus != null)
                    hash = hash * 59 + this.SubscriptionStatus.GetHashCode();
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
