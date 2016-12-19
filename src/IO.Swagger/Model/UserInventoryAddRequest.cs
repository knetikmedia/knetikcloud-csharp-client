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
    /// UserInventoryAddRequest
    /// </summary>
    [DataContract]
    public partial class UserInventoryAddRequest :  IEquatable<UserInventoryAddRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserInventoryAddRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserInventoryAddRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserInventoryAddRequest" /> class.
        /// </summary>
        /// <param name="Note">A note to be passed to the invoice or transaction (required).</param>
        /// <param name="Overrides">A list of behaviors to ignore explicitely.  Ex: &#39;limited_gettable&#39;.</param>
        /// <param name="SkipInvoice">If set to true will cause the endpoint to skip creation of cart and invoice to track the inventory change (required).</param>
        /// <param name="Sku">The specific SKU of the item to be added to the inventory (required).</param>
        public UserInventoryAddRequest(string Note = null, List<string> Overrides = null, bool? SkipInvoice = null, string Sku = null)
        {
            // to ensure "Note" is required (not null)
            if (Note == null)
            {
                throw new InvalidDataException("Note is a required property for UserInventoryAddRequest and cannot be null");
            }
            else
            {
                this.Note = Note;
            }
            // to ensure "SkipInvoice" is required (not null)
            if (SkipInvoice == null)
            {
                throw new InvalidDataException("SkipInvoice is a required property for UserInventoryAddRequest and cannot be null");
            }
            else
            {
                this.SkipInvoice = SkipInvoice;
            }
            // to ensure "Sku" is required (not null)
            if (Sku == null)
            {
                throw new InvalidDataException("Sku is a required property for UserInventoryAddRequest and cannot be null");
            }
            else
            {
                this.Sku = Sku;
            }
            this.Overrides = Overrides;
        }
        
        /// <summary>
        /// A note to be passed to the invoice or transaction
        /// </summary>
        /// <value>A note to be passed to the invoice or transaction</value>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }
        /// <summary>
        /// A list of behaviors to ignore explicitely.  Ex: &#39;limited_gettable&#39;
        /// </summary>
        /// <value>A list of behaviors to ignore explicitely.  Ex: &#39;limited_gettable&#39;</value>
        [DataMember(Name="overrides", EmitDefaultValue=false)]
        public List<string> Overrides { get; set; }
        /// <summary>
        /// If set to true will cause the endpoint to skip creation of cart and invoice to track the inventory change
        /// </summary>
        /// <value>If set to true will cause the endpoint to skip creation of cart and invoice to track the inventory change</value>
        [DataMember(Name="skip_invoice", EmitDefaultValue=false)]
        public bool? SkipInvoice { get; set; }
        /// <summary>
        /// The specific SKU of the item to be added to the inventory
        /// </summary>
        /// <value>The specific SKU of the item to be added to the inventory</value>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserInventoryAddRequest {\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  Overrides: ").Append(Overrides).Append("\n");
            sb.Append("  SkipInvoice: ").Append(SkipInvoice).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
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
            return this.Equals(obj as UserInventoryAddRequest);
        }

        /// <summary>
        /// Returns true if UserInventoryAddRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UserInventoryAddRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserInventoryAddRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Note == other.Note ||
                    this.Note != null &&
                    this.Note.Equals(other.Note)
                ) && 
                (
                    this.Overrides == other.Overrides ||
                    this.Overrides != null &&
                    this.Overrides.SequenceEqual(other.Overrides)
                ) && 
                (
                    this.SkipInvoice == other.SkipInvoice ||
                    this.SkipInvoice != null &&
                    this.SkipInvoice.Equals(other.SkipInvoice)
                ) && 
                (
                    this.Sku == other.Sku ||
                    this.Sku != null &&
                    this.Sku.Equals(other.Sku)
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
                if (this.Note != null)
                    hash = hash * 59 + this.Note.GetHashCode();
                if (this.Overrides != null)
                    hash = hash * 59 + this.Overrides.GetHashCode();
                if (this.SkipInvoice != null)
                    hash = hash * 59 + this.SkipInvoice.GetHashCode();
                if (this.Sku != null)
                    hash = hash * 59 + this.Sku.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
