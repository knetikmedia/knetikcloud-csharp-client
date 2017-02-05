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
    /// PaymentMethodResource
    /// </summary>
    [DataContract]
    public partial class PaymentMethodResource :  IEquatable<PaymentMethodResource>, IValidatableObject
    {
        /// <summary>
        /// The generic payment type. Default is card
        /// </summary>
        /// <value>The generic payment type. Default is card</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaymentTypeEnum
        {
            
            /// <summary>
            /// Enum Card for "card"
            /// </summary>
            [EnumMember(Value = "card")]
            Card,
            
            /// <summary>
            /// Enum Bankaccount for "bank_account"
            /// </summary>
            [EnumMember(Value = "bank_account")]
            Bankaccount
        }

        /// <summary>
        /// The generic payment type. Default is card
        /// </summary>
        /// <value>The generic payment type. Default is card</value>
        [DataMember(Name="payment_type", EmitDefaultValue=false)]
        public PaymentTypeEnum? PaymentType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentMethodResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodResource" /> class.
        /// </summary>
        /// <param name="_Default">_Default.</param>
        /// <param name="Disabled">Whether this payment method is disabled or not.</param>
        /// <param name="ExpirationDate">The expiration date for the payment method, expressed as seconds since epoch. Typically used for credit card payment methods.</param>
        /// <param name="ExpirationMonth">The expiration month (1 - 12) for the payment method. Typically used for credit card payment methods.</param>
        /// <param name="ExpirationYear">The expiration year for the payment method. Typically used for credit card payment methods.</param>
        /// <param name="Last4">The last 4 digits of the account number for the payment method. Typically used for credit card payment methods.</param>
        /// <param name="LongDescription">The user friendly name of that resource. Defaults to blank string.</param>
        /// <param name="Name">The user friendly name of that resource (required).</param>
        /// <param name="PaymentMethodType">The type of payment method. Must be a pre-existing value (required).</param>
        /// <param name="PaymentType">The generic payment type. Default is card.</param>
        /// <param name="ShortDescription">The user friendly name of that resource. Defaults to blank string.</param>
        /// <param name="Sort">The sort value for the payment method.</param>
        /// <param name="Token">The unique token for the payment method.</param>
        /// <param name="UniqueKey">An optional unique identifier.</param>
        /// <param name="UserId">The user&#39;s id. If null, indicates a shared payment method that any user can use (i.e., &#39;wallet&#39;).</param>
        /// <param name="Verified">Verified.</param>
        public PaymentMethodResource(bool? _Default = default(bool?), bool? Disabled = default(bool?), long? ExpirationDate = default(long?), int? ExpirationMonth = default(int?), int? ExpirationYear = default(int?), string Last4 = default(string), string LongDescription = default(string), string Name = default(string), PaymentMethodTypeResource PaymentMethodType = default(PaymentMethodTypeResource), PaymentTypeEnum? PaymentType = default(PaymentTypeEnum?), string ShortDescription = default(string), int? Sort = default(int?), string Token = default(string), string UniqueKey = default(string), int? UserId = default(int?), bool? Verified = default(bool?))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for PaymentMethodResource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "PaymentMethodType" is required (not null)
            if (PaymentMethodType == null)
            {
                throw new InvalidDataException("PaymentMethodType is a required property for PaymentMethodResource and cannot be null");
            }
            else
            {
                this.PaymentMethodType = PaymentMethodType;
            }
            this._Default = _Default;
            this.Disabled = Disabled;
            this.ExpirationDate = ExpirationDate;
            this.ExpirationMonth = ExpirationMonth;
            this.ExpirationYear = ExpirationYear;
            this.Last4 = Last4;
            this.LongDescription = LongDescription;
            this.PaymentType = PaymentType;
            this.ShortDescription = ShortDescription;
            this.Sort = Sort;
            this.Token = Token;
            this.UniqueKey = UniqueKey;
            this.UserId = UserId;
            this.Verified = Verified;
        }
        
        /// <summary>
        /// The date/time this resource was created in seconds since unix epoch
        /// </summary>
        /// <value>The date/time this resource was created in seconds since unix epoch</value>
        [DataMember(Name="created_date", EmitDefaultValue=false)]
        public long? CreatedDate { get; private set; }
        /// <summary>
        /// Gets or Sets _Default
        /// </summary>
        [DataMember(Name="default", EmitDefaultValue=false)]
        public bool? _Default { get; set; }
        /// <summary>
        /// Whether this payment method is disabled or not
        /// </summary>
        /// <value>Whether this payment method is disabled or not</value>
        [DataMember(Name="disabled", EmitDefaultValue=false)]
        public bool? Disabled { get; set; }
        /// <summary>
        /// The expiration date for the payment method, expressed as seconds since epoch. Typically used for credit card payment methods
        /// </summary>
        /// <value>The expiration date for the payment method, expressed as seconds since epoch. Typically used for credit card payment methods</value>
        [DataMember(Name="expiration_date", EmitDefaultValue=false)]
        public long? ExpirationDate { get; set; }
        /// <summary>
        /// The expiration month (1 - 12) for the payment method. Typically used for credit card payment methods
        /// </summary>
        /// <value>The expiration month (1 - 12) for the payment method. Typically used for credit card payment methods</value>
        [DataMember(Name="expiration_month", EmitDefaultValue=false)]
        public int? ExpirationMonth { get; set; }
        /// <summary>
        /// The expiration year for the payment method. Typically used for credit card payment methods
        /// </summary>
        /// <value>The expiration year for the payment method. Typically used for credit card payment methods</value>
        [DataMember(Name="expiration_year", EmitDefaultValue=false)]
        public int? ExpirationYear { get; set; }
        /// <summary>
        /// The unique ID for that resource
        /// </summary>
        /// <value>The unique ID for that resource</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }
        /// <summary>
        /// The last 4 digits of the account number for the payment method. Typically used for credit card payment methods
        /// </summary>
        /// <value>The last 4 digits of the account number for the payment method. Typically used for credit card payment methods</value>
        [DataMember(Name="last4", EmitDefaultValue=false)]
        public string Last4 { get; set; }
        /// <summary>
        /// The user friendly name of that resource. Defaults to blank string
        /// </summary>
        /// <value>The user friendly name of that resource. Defaults to blank string</value>
        [DataMember(Name="long_description", EmitDefaultValue=false)]
        public string LongDescription { get; set; }
        /// <summary>
        /// The user friendly name of that resource
        /// </summary>
        /// <value>The user friendly name of that resource</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The type of payment method. Must be a pre-existing value
        /// </summary>
        /// <value>The type of payment method. Must be a pre-existing value</value>
        [DataMember(Name="payment_method_type", EmitDefaultValue=false)]
        public PaymentMethodTypeResource PaymentMethodType { get; set; }
        /// <summary>
        /// The user friendly name of that resource. Defaults to blank string
        /// </summary>
        /// <value>The user friendly name of that resource. Defaults to blank string</value>
        [DataMember(Name="short_description", EmitDefaultValue=false)]
        public string ShortDescription { get; set; }
        /// <summary>
        /// The sort value for the payment method
        /// </summary>
        /// <value>The sort value for the payment method</value>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public int? Sort { get; set; }
        /// <summary>
        /// The unique token for the payment method
        /// </summary>
        /// <value>The unique token for the payment method</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }
        /// <summary>
        /// An optional unique identifier
        /// </summary>
        /// <value>An optional unique identifier</value>
        [DataMember(Name="unique_key", EmitDefaultValue=false)]
        public string UniqueKey { get; set; }
        /// <summary>
        /// The date/time this resource was last updated in seconds since unix epoch
        /// </summary>
        /// <value>The date/time this resource was last updated in seconds since unix epoch</value>
        [DataMember(Name="updated_date", EmitDefaultValue=false)]
        public long? UpdatedDate { get; private set; }
        /// <summary>
        /// The user&#39;s id. If null, indicates a shared payment method that any user can use (i.e., &#39;wallet&#39;)
        /// </summary>
        /// <value>The user&#39;s id. If null, indicates a shared payment method that any user can use (i.e., &#39;wallet&#39;)</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public int? UserId { get; set; }
        /// <summary>
        /// Gets or Sets Verified
        /// </summary>
        [DataMember(Name="verified", EmitDefaultValue=false)]
        public bool? Verified { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentMethodResource {\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  _Default: ").Append(_Default).Append("\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  ExpirationMonth: ").Append(ExpirationMonth).Append("\n");
            sb.Append("  ExpirationYear: ").Append(ExpirationYear).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Last4: ").Append(Last4).Append("\n");
            sb.Append("  LongDescription: ").Append(LongDescription).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PaymentMethodType: ").Append(PaymentMethodType).Append("\n");
            sb.Append("  PaymentType: ").Append(PaymentType).Append("\n");
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  UniqueKey: ").Append(UniqueKey).Append("\n");
            sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Verified: ").Append(Verified).Append("\n");
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
            return this.Equals(obj as PaymentMethodResource);
        }

        /// <summary>
        /// Returns true if PaymentMethodResource instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentMethodResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethodResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this._Default == other._Default ||
                    this._Default != null &&
                    this._Default.Equals(other._Default)
                ) && 
                (
                    this.Disabled == other.Disabled ||
                    this.Disabled != null &&
                    this.Disabled.Equals(other.Disabled)
                ) && 
                (
                    this.ExpirationDate == other.ExpirationDate ||
                    this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(other.ExpirationDate)
                ) && 
                (
                    this.ExpirationMonth == other.ExpirationMonth ||
                    this.ExpirationMonth != null &&
                    this.ExpirationMonth.Equals(other.ExpirationMonth)
                ) && 
                (
                    this.ExpirationYear == other.ExpirationYear ||
                    this.ExpirationYear != null &&
                    this.ExpirationYear.Equals(other.ExpirationYear)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Last4 == other.Last4 ||
                    this.Last4 != null &&
                    this.Last4.Equals(other.Last4)
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
                    this.PaymentMethodType == other.PaymentMethodType ||
                    this.PaymentMethodType != null &&
                    this.PaymentMethodType.Equals(other.PaymentMethodType)
                ) && 
                (
                    this.PaymentType == other.PaymentType ||
                    this.PaymentType != null &&
                    this.PaymentType.Equals(other.PaymentType)
                ) && 
                (
                    this.ShortDescription == other.ShortDescription ||
                    this.ShortDescription != null &&
                    this.ShortDescription.Equals(other.ShortDescription)
                ) && 
                (
                    this.Sort == other.Sort ||
                    this.Sort != null &&
                    this.Sort.Equals(other.Sort)
                ) && 
                (
                    this.Token == other.Token ||
                    this.Token != null &&
                    this.Token.Equals(other.Token)
                ) && 
                (
                    this.UniqueKey == other.UniqueKey ||
                    this.UniqueKey != null &&
                    this.UniqueKey.Equals(other.UniqueKey)
                ) && 
                (
                    this.UpdatedDate == other.UpdatedDate ||
                    this.UpdatedDate != null &&
                    this.UpdatedDate.Equals(other.UpdatedDate)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.Verified == other.Verified ||
                    this.Verified != null &&
                    this.Verified.Equals(other.Verified)
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
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                if (this._Default != null)
                    hash = hash * 59 + this._Default.GetHashCode();
                if (this.Disabled != null)
                    hash = hash * 59 + this.Disabled.GetHashCode();
                if (this.ExpirationDate != null)
                    hash = hash * 59 + this.ExpirationDate.GetHashCode();
                if (this.ExpirationMonth != null)
                    hash = hash * 59 + this.ExpirationMonth.GetHashCode();
                if (this.ExpirationYear != null)
                    hash = hash * 59 + this.ExpirationYear.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Last4 != null)
                    hash = hash * 59 + this.Last4.GetHashCode();
                if (this.LongDescription != null)
                    hash = hash * 59 + this.LongDescription.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.PaymentMethodType != null)
                    hash = hash * 59 + this.PaymentMethodType.GetHashCode();
                if (this.PaymentType != null)
                    hash = hash * 59 + this.PaymentType.GetHashCode();
                if (this.ShortDescription != null)
                    hash = hash * 59 + this.ShortDescription.GetHashCode();
                if (this.Sort != null)
                    hash = hash * 59 + this.Sort.GetHashCode();
                if (this.Token != null)
                    hash = hash * 59 + this.Token.GetHashCode();
                if (this.UniqueKey != null)
                    hash = hash * 59 + this.UniqueKey.GetHashCode();
                if (this.UpdatedDate != null)
                    hash = hash * 59 + this.UpdatedDate.GetHashCode();
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.Verified != null)
                    hash = hash * 59 + this.Verified.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
