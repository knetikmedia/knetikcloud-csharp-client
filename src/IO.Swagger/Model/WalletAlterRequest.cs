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
    /// WalletAlterRequest
    /// </summary>
    [DataContract]
    public partial class WalletAlterRequest :  IEquatable<WalletAlterRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletAlterRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WalletAlterRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletAlterRequest" /> class.
        /// </summary>
        /// <param name="Delta">The amount of currency to add/remove. positive to add, negative to remove (required).</param>
        /// <param name="InvoiceId">The id of an invoice to attribute the transaction to.</param>
        /// <param name="Reason">The admin entered or system generated reason (required).</param>
        /// <param name="Type">The transaction type to allow for search/etc.</param>
        public WalletAlterRequest(double? Delta = null, int? InvoiceId = null, string Reason = null, string Type = null)
        {
            // to ensure "Delta" is required (not null)
            if (Delta == null)
            {
                throw new InvalidDataException("Delta is a required property for WalletAlterRequest and cannot be null");
            }
            else
            {
                this.Delta = Delta;
            }
            // to ensure "Reason" is required (not null)
            if (Reason == null)
            {
                throw new InvalidDataException("Reason is a required property for WalletAlterRequest and cannot be null");
            }
            else
            {
                this.Reason = Reason;
            }
            this.InvoiceId = InvoiceId;
            this.Type = Type;
        }
        
        /// <summary>
        /// The amount of currency to add/remove. positive to add, negative to remove
        /// </summary>
        /// <value>The amount of currency to add/remove. positive to add, negative to remove</value>
        [DataMember(Name="delta", EmitDefaultValue=false)]
        public double? Delta { get; set; }
        /// <summary>
        /// The id of an invoice to attribute the transaction to
        /// </summary>
        /// <value>The id of an invoice to attribute the transaction to</value>
        [DataMember(Name="invoice_id", EmitDefaultValue=false)]
        public int? InvoiceId { get; set; }
        /// <summary>
        /// The admin entered or system generated reason
        /// </summary>
        /// <value>The admin entered or system generated reason</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }
        /// <summary>
        /// The transaction type to allow for search/etc
        /// </summary>
        /// <value>The transaction type to allow for search/etc</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WalletAlterRequest {\n");
            sb.Append("  Delta: ").Append(Delta).Append("\n");
            sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as WalletAlterRequest);
        }

        /// <summary>
        /// Returns true if WalletAlterRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of WalletAlterRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WalletAlterRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Delta == other.Delta ||
                    this.Delta != null &&
                    this.Delta.Equals(other.Delta)
                ) && 
                (
                    this.InvoiceId == other.InvoiceId ||
                    this.InvoiceId != null &&
                    this.InvoiceId.Equals(other.InvoiceId)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.Delta != null)
                    hash = hash * 59 + this.Delta.GetHashCode();
                if (this.InvoiceId != null)
                    hash = hash * 59 + this.InvoiceId.GetHashCode();
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
