/* 
 * Knetik Platform API Documentation Latest
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://demo.sandbox.knetikcloud.com
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
        public XsollaPaymentRequest(int? InvoiceId = null, string ReturnUrl = null)
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as XsollaPaymentRequest);
        }

        /// <summary>
        /// Returns true if XsollaPaymentRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of XsollaPaymentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XsollaPaymentRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.InvoiceId == other.InvoiceId ||
                    this.InvoiceId != null &&
                    this.InvoiceId.Equals(other.InvoiceId)
                ) && 
                (
                    this.ReturnUrl == other.ReturnUrl ||
                    this.ReturnUrl != null &&
                    this.ReturnUrl.Equals(other.ReturnUrl)
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
                if (this.InvoiceId != null)
                    hash = hash * 59 + this.InvoiceId.GetHashCode();
                if (this.ReturnUrl != null)
                    hash = hash * 59 + this.ReturnUrl.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
