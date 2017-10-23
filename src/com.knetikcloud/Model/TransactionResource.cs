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
    /// TransactionResource
    /// </summary>
    [DataContract]
    public partial class TransactionResource :  IEquatable<TransactionResource>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="TransactionResource" /> class.
        /// </summary>
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
        /// <param name="Value">The amount of the transaction, positive if a gain, negative if an expenditure.</param>
        public TransactionResource(long? CreateDate = default(long?), string CurrencyCode = default(string), string Details = default(string), int? Id = default(int?), int? InvoiceId = default(int?), bool? IsRefunded = default(bool?), string Response = default(string), SourceEnum? Source = default(SourceEnum?), bool? Successful = default(bool?), string TransactionId = default(string), string Type = default(string), string TypeHint = default(string), decimal? Value = default(decimal?))
        {
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
            this.Value = Value;
        }
        
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
        /// The amount of the transaction, positive if a gain, negative if an expenditure
        /// </summary>
        /// <value>The amount of the transaction, positive if a gain, negative if an expenditure</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public decimal? Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionResource {\n");
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
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as TransactionResource);
        }

        /// <summary>
        /// Returns true if TransactionResource instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreateDate == input.CreateDate ||
                    (this.CreateDate != null &&
                    this.CreateDate.Equals(input.CreateDate))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
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
                    this.IsRefunded == input.IsRefunded ||
                    (this.IsRefunded != null &&
                    this.IsRefunded.Equals(input.IsRefunded))
                ) && 
                (
                    this.Response == input.Response ||
                    (this.Response != null &&
                    this.Response.Equals(input.Response))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Successful == input.Successful ||
                    (this.Successful != null &&
                    this.Successful.Equals(input.Successful))
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.TypeHint == input.TypeHint ||
                    (this.TypeHint != null &&
                    this.TypeHint.Equals(input.TypeHint))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.CreateDate != null)
                    hashCode = hashCode * 59 + this.CreateDate.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InvoiceId != null)
                    hashCode = hashCode * 59 + this.InvoiceId.GetHashCode();
                if (this.IsRefunded != null)
                    hashCode = hashCode * 59 + this.IsRefunded.GetHashCode();
                if (this.Response != null)
                    hashCode = hashCode * 59 + this.Response.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Successful != null)
                    hashCode = hashCode * 59 + this.Successful.GetHashCode();
                if (this.TransactionId != null)
                    hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.TypeHint != null)
                    hashCode = hashCode * 59 + this.TypeHint.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
