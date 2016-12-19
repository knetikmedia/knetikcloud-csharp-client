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
    /// WalletTransactionResource
    /// </summary>
    [DataContract]
    public partial class WalletTransactionResource :  IEquatable<WalletTransactionResource>, IValidatableObject
    {
        /// <summary>
        /// The root source of the transaction
        /// </summary>
        /// <value>The root source of the transaction</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SourceEnum
        {
            
            /// <summary>
            /// Enum Digital for "digital"
            /// </summary>
            [EnumMember(Value = "digital")]
            Digital,
            
            /// <summary>
            /// Enum Physical for "physical"
            /// </summary>
            [EnumMember(Value = "physical")]
            Physical
        }

        /// <summary>
        /// The root source of the transaction
        /// </summary>
        /// <value>The root source of the transaction</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public SourceEnum? Source { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletTransactionResource" /> class.
        /// </summary>
        /// <param name="Balance">The new balance of the wallet after the transaction.</param>
        /// <param name="CreateDate">The unix timestamp in seconds of the transaction.</param>
        /// <param name="CurrencyCode">The code of the currency for the transaction.</param>
        /// <param name="Details">The specific details of the transaction, such as a message from the admin that created it.</param>
        /// <param name="Id">The id of the transaction.</param>
        /// <param name="InvoiceId">The id of the invoice that spawned the transaction, if any.</param>
        /// <param name="IsRefunded">Whether the transaction has been refunded.</param>
        /// <param name="Response">The response.</param>
        /// <param name="Source">The root source of the transaction.</param>
        /// <param name="Successful">If the transaction was successful.</param>
        /// <param name="TransactionId">The payment gateway (external) transaction ID.</param>
        /// <param name="Type">The general type of the transaction.</param>
        /// <param name="TypeHint">The table name of the subclass.</param>
        /// <param name="User">The owner of the wallet.</param>
        /// <param name="Value">The amount of the transaction, positive if a gain, negative if an expenditure.</param>
        /// <param name="WalletId">The id of the wallet this transaction affected.</param>
        public WalletTransactionResource(double? Balance = null, long? CreateDate = null, string CurrencyCode = null, string Details = null, int? Id = null, int? InvoiceId = null, bool? IsRefunded = null, string Response = null, SourceEnum? Source = null, bool? Successful = null, string TransactionId = null, string Type = null, string TypeHint = null, SimpleUserResource User = null, double? Value = null, int? WalletId = null)
        {
            this.Balance = Balance;
            this.CreateDate = CreateDate;
            this.CurrencyCode = CurrencyCode;
            this.Details = Details;
            this.Id = Id;
            this.InvoiceId = InvoiceId;
            this.IsRefunded = IsRefunded;
            this.Response = Response;
            this.Source = Source;
            this.Successful = Successful;
            this.TransactionId = TransactionId;
            this.Type = Type;
            this.TypeHint = TypeHint;
            this.User = User;
            this.Value = Value;
            this.WalletId = WalletId;
        }
        
        /// <summary>
        /// The new balance of the wallet after the transaction
        /// </summary>
        /// <value>The new balance of the wallet after the transaction</value>
        [DataMember(Name="balance", EmitDefaultValue=false)]
        public double? Balance { get; set; }
        /// <summary>
        /// The unix timestamp in seconds of the transaction
        /// </summary>
        /// <value>The unix timestamp in seconds of the transaction</value>
        [DataMember(Name="create_date", EmitDefaultValue=false)]
        public long? CreateDate { get; set; }
        /// <summary>
        /// The code of the currency for the transaction
        /// </summary>
        /// <value>The code of the currency for the transaction</value>
        [DataMember(Name="currency_code", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }
        /// <summary>
        /// The specific details of the transaction, such as a message from the admin that created it
        /// </summary>
        /// <value>The specific details of the transaction, such as a message from the admin that created it</value>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public string Details { get; set; }
        /// <summary>
        /// The id of the transaction
        /// </summary>
        /// <value>The id of the transaction</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// The id of the invoice that spawned the transaction, if any
        /// </summary>
        /// <value>The id of the invoice that spawned the transaction, if any</value>
        [DataMember(Name="invoice_id", EmitDefaultValue=false)]
        public int? InvoiceId { get; set; }
        /// <summary>
        /// Whether the transaction has been refunded
        /// </summary>
        /// <value>Whether the transaction has been refunded</value>
        [DataMember(Name="is_refunded", EmitDefaultValue=false)]
        public bool? IsRefunded { get; set; }
        /// <summary>
        /// The response
        /// </summary>
        /// <value>The response</value>
        [DataMember(Name="response", EmitDefaultValue=false)]
        public string Response { get; set; }
        /// <summary>
        /// If the transaction was successful
        /// </summary>
        /// <value>If the transaction was successful</value>
        [DataMember(Name="successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }
        /// <summary>
        /// The payment gateway (external) transaction ID
        /// </summary>
        /// <value>The payment gateway (external) transaction ID</value>
        [DataMember(Name="transaction_id", EmitDefaultValue=false)]
        public string TransactionId { get; set; }
        /// <summary>
        /// The general type of the transaction
        /// </summary>
        /// <value>The general type of the transaction</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// The table name of the subclass
        /// </summary>
        /// <value>The table name of the subclass</value>
        [DataMember(Name="type_hint", EmitDefaultValue=false)]
        public string TypeHint { get; set; }
        /// <summary>
        /// The owner of the wallet
        /// </summary>
        /// <value>The owner of the wallet</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public SimpleUserResource User { get; set; }
        /// <summary>
        /// The amount of the transaction, positive if a gain, negative if an expenditure
        /// </summary>
        /// <value>The amount of the transaction, positive if a gain, negative if an expenditure</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public double? Value { get; set; }
        /// <summary>
        /// The id of the wallet this transaction affected
        /// </summary>
        /// <value>The id of the wallet this transaction affected</value>
        [DataMember(Name="wallet_id", EmitDefaultValue=false)]
        public int? WalletId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WalletTransactionResource {\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
            sb.Append("  IsRefunded: ").Append(IsRefunded).Append("\n");
            sb.Append("  Response: ").Append(Response).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TypeHint: ").Append(TypeHint).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  WalletId: ").Append(WalletId).Append("\n");
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
            return this.Equals(obj as WalletTransactionResource);
        }

        /// <summary>
        /// Returns true if WalletTransactionResource instances are equal
        /// </summary>
        /// <param name="other">Instance of WalletTransactionResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WalletTransactionResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Balance == other.Balance ||
                    this.Balance != null &&
                    this.Balance.Equals(other.Balance)
                ) && 
                (
                    this.CreateDate == other.CreateDate ||
                    this.CreateDate != null &&
                    this.CreateDate.Equals(other.CreateDate)
                ) && 
                (
                    this.CurrencyCode == other.CurrencyCode ||
                    this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(other.CurrencyCode)
                ) && 
                (
                    this.Details == other.Details ||
                    this.Details != null &&
                    this.Details.Equals(other.Details)
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
                    this.IsRefunded == other.IsRefunded ||
                    this.IsRefunded != null &&
                    this.IsRefunded.Equals(other.IsRefunded)
                ) && 
                (
                    this.Response == other.Response ||
                    this.Response != null &&
                    this.Response.Equals(other.Response)
                ) && 
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
                ) && 
                (
                    this.Successful == other.Successful ||
                    this.Successful != null &&
                    this.Successful.Equals(other.Successful)
                ) && 
                (
                    this.TransactionId == other.TransactionId ||
                    this.TransactionId != null &&
                    this.TransactionId.Equals(other.TransactionId)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.TypeHint == other.TypeHint ||
                    this.TypeHint != null &&
                    this.TypeHint.Equals(other.TypeHint)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) && 
                (
                    this.WalletId == other.WalletId ||
                    this.WalletId != null &&
                    this.WalletId.Equals(other.WalletId)
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
                if (this.Balance != null)
                    hash = hash * 59 + this.Balance.GetHashCode();
                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();
                if (this.CurrencyCode != null)
                    hash = hash * 59 + this.CurrencyCode.GetHashCode();
                if (this.Details != null)
                    hash = hash * 59 + this.Details.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.InvoiceId != null)
                    hash = hash * 59 + this.InvoiceId.GetHashCode();
                if (this.IsRefunded != null)
                    hash = hash * 59 + this.IsRefunded.GetHashCode();
                if (this.Response != null)
                    hash = hash * 59 + this.Response.GetHashCode();
                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();
                if (this.Successful != null)
                    hash = hash * 59 + this.Successful.GetHashCode();
                if (this.TransactionId != null)
                    hash = hash * 59 + this.TransactionId.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.TypeHint != null)
                    hash = hash * 59 + this.TypeHint.GetHashCode();
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                if (this.WalletId != null)
                    hash = hash * 59 + this.WalletId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
