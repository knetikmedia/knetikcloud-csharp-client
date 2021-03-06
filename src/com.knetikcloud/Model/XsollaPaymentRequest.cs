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
    /// XsollaPaymentRequest
    /// </summary>
    [DataContract]
    public partial class XsollaPaymentRequest :  IEquatable<XsollaPaymentRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XsollaPaymentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected XsollaPaymentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="XsollaPaymentRequest" /> class.
        /// </summary>
        /// <param name="InvoiceId">The id of an invoice to pay (required).</param>
        /// <param name="ReturnUrl">The endpoint URL xsolla should forward the user to after they pay (required).</param>
        public XsollaPaymentRequest(int? InvoiceId = default(int?), string ReturnUrl = default(string))
        {
            // to ensure "InvoiceId" is required (not null)
            if (InvoiceId == null)
            {
                throw new InvalidDataException("InvoiceId is a required property for XsollaPaymentRequest and cannot be null");
            }
            else
            {
                this.InvoiceId = InvoiceId;
            }
            // to ensure "ReturnUrl" is required (not null)
            if (ReturnUrl == null)
            {
                throw new InvalidDataException("ReturnUrl is a required property for XsollaPaymentRequest and cannot be null");
            }
            else
            {
                this.ReturnUrl = ReturnUrl;
            }
        }
        
        /// <summary>
        /// The id of an invoice to pay
        /// </summary>
        /// <value>The id of an invoice to pay</value>
        [DataMember(Name="invoice_id", EmitDefaultValue=false)]
        public int? InvoiceId { get; set; }

        /// <summary>
        /// The endpoint URL xsolla should forward the user to after they pay
        /// </summary>
        /// <value>The endpoint URL xsolla should forward the user to after they pay</value>
        [DataMember(Name="return_url", EmitDefaultValue=false)]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XsollaPaymentRequest {\n");
            sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
            sb.Append("  ReturnUrl: ").Append(ReturnUrl).Append("\n");
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
            return this.Equals(input as XsollaPaymentRequest);
        }

        /// <summary>
        /// Returns true if XsollaPaymentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of XsollaPaymentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XsollaPaymentRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InvoiceId == input.InvoiceId ||
                    (this.InvoiceId != null &&
                    this.InvoiceId.Equals(input.InvoiceId))
                ) && 
                (
                    this.ReturnUrl == input.ReturnUrl ||
                    (this.ReturnUrl != null &&
                    this.ReturnUrl.Equals(input.ReturnUrl))
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
                if (this.InvoiceId != null)
                    hashCode = hashCode * 59 + this.InvoiceId.GetHashCode();
                if (this.ReturnUrl != null)
                    hashCode = hashCode * 59 + this.ReturnUrl.GetHashCode();
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
