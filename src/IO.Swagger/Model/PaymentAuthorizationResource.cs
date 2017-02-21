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
    /// PaymentAuthorizationResource
    /// </summary>
    [DataContract]
    public partial class PaymentAuthorizationResource :  IEquatable<PaymentAuthorizationResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentAuthorizationResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentAuthorizationResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentAuthorizationResource" /> class.
        /// </summary>
        /// <param name="Details">The details for this authorization. Format dependent on payment provider.</param>
        /// <param name="Invoice">The invoice this authorization is intended to pay.</param>
        /// <param name="PaymentType">The payment type (which provider) this payment is through (required).</param>
        public PaymentAuthorizationResource(Object Details = default(Object), int? Invoice = default(int?), SimpleReferenceResourceint PaymentType = default(SimpleReferenceResourceint))
        {
            // to ensure "PaymentType" is required (not null)
            if (PaymentType == null)
            {
                throw new InvalidDataException("PaymentType is a required property for PaymentAuthorizationResource and cannot be null");
            }
            else
            {
                this.PaymentType = PaymentType;
            }
            this.Details = Details;
            this.Invoice = Invoice;
        }
        
        /// <summary>
        /// Whether this authorization has been captured
        /// </summary>
        /// <value>Whether this authorization has been captured</value>
        [DataMember(Name="captured", EmitDefaultValue=false)]
        public bool? Captured { get; private set; }
        /// <summary>
        /// The date this authorization was received, unix timestamp in seconds
        /// </summary>
        /// <value>The date this authorization was received, unix timestamp in seconds</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public long? Created { get; private set; }
        /// <summary>
        /// The details for this authorization. Format dependent on payment provider
        /// </summary>
        /// <value>The details for this authorization. Format dependent on payment provider</value>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public Object Details { get; set; }
        /// <summary>
        /// The id of the authorization
        /// </summary>
        /// <value>The id of the authorization</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
        /// <summary>
        /// The invoice this authorization is intended to pay
        /// </summary>
        /// <value>The invoice this authorization is intended to pay</value>
        [DataMember(Name="invoice", EmitDefaultValue=false)]
        public int? Invoice { get; set; }
        /// <summary>
        /// The payment type (which provider) this payment is through
        /// </summary>
        /// <value>The payment type (which provider) this payment is through</value>
        [DataMember(Name="payment_type", EmitDefaultValue=false)]
        public SimpleReferenceResourceint PaymentType { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentAuthorizationResource {\n");
            sb.Append("  Captured: ").Append(Captured).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Invoice: ").Append(Invoice).Append("\n");
            sb.Append("  PaymentType: ").Append(PaymentType).Append("\n");
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
            return this.Equals(obj as PaymentAuthorizationResource);
        }

        /// <summary>
        /// Returns true if PaymentAuthorizationResource instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentAuthorizationResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentAuthorizationResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Captured == other.Captured ||
                    this.Captured != null &&
                    this.Captured.Equals(other.Captured)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
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
                    this.Invoice == other.Invoice ||
                    this.Invoice != null &&
                    this.Invoice.Equals(other.Invoice)
                ) && 
                (
                    this.PaymentType == other.PaymentType ||
                    this.PaymentType != null &&
                    this.PaymentType.Equals(other.PaymentType)
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
                if (this.Captured != null)
                    hash = hash * 59 + this.Captured.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Details != null)
                    hash = hash * 59 + this.Details.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Invoice != null)
                    hash = hash * 59 + this.Invoice.GetHashCode();
                if (this.PaymentType != null)
                    hash = hash * 59 + this.PaymentType.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
