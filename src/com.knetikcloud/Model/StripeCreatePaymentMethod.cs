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
    /// StripeCreatePaymentMethod
    /// </summary>
    [DataContract]
    public partial class StripeCreatePaymentMethod :  IEquatable<StripeCreatePaymentMethod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StripeCreatePaymentMethod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StripeCreatePaymentMethod() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StripeCreatePaymentMethod" /> class.
        /// </summary>
        /// <param name="Details">Additional optional details to store on the payment method. If included, all fields in the details will override any defaults.</param>
        /// <param name="Token">A token from Stripe to identify payment info to be tied to the customer (required).</param>
        /// <param name="UserId">The id of the user, if null the logged in user is used. Admin privilege need to specify other users.</param>
        public StripeCreatePaymentMethod(PaymentMethodDetails Details = default(PaymentMethodDetails), string Token = default(string), int? UserId = default(int?))
        {
            // to ensure "Token" is required (not null)
            if (Token == null)
            {
                throw new InvalidDataException("Token is a required property for StripeCreatePaymentMethod and cannot be null");
            }
            else
            {
                this.Token = Token;
            }
            this.Details = Details;
            this.UserId = UserId;
        }
        
        /// <summary>
        /// Additional optional details to store on the payment method. If included, all fields in the details will override any defaults
        /// </summary>
        /// <value>Additional optional details to store on the payment method. If included, all fields in the details will override any defaults</value>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public PaymentMethodDetails Details { get; set; }

        /// <summary>
        /// A token from Stripe to identify payment info to be tied to the customer
        /// </summary>
        /// <value>A token from Stripe to identify payment info to be tied to the customer</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }

        /// <summary>
        /// The id of the user, if null the logged in user is used. Admin privilege need to specify other users
        /// </summary>
        /// <value>The id of the user, if null the logged in user is used. Admin privilege need to specify other users</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StripeCreatePaymentMethod {\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as StripeCreatePaymentMethod);
        }

        /// <summary>
        /// Returns true if StripeCreatePaymentMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of StripeCreatePaymentMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StripeCreatePaymentMethod input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
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