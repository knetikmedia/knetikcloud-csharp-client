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
    /// InvoiceCreateRequest
    /// </summary>
    [DataContract]
    public partial class InvoiceCreateRequest :  IEquatable<InvoiceCreateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceCreateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InvoiceCreateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceCreateRequest" /> class.
        /// </summary>
        /// <param name="CartGuid">The guid of a cart to create a new invoice for (required).</param>
        public InvoiceCreateRequest(string CartGuid = default(string))
        {
            // to ensure "CartGuid" is required (not null)
            if (CartGuid == null)
            {
                throw new InvalidDataException("CartGuid is a required property for InvoiceCreateRequest and cannot be null");
            }
            else
            {
                this.CartGuid = CartGuid;
            }
        }
        
        /// <summary>
        /// The guid of a cart to create a new invoice for
        /// </summary>
        /// <value>The guid of a cart to create a new invoice for</value>
        [DataMember(Name="cart_guid", EmitDefaultValue=false)]
        public string CartGuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvoiceCreateRequest {\n");
            sb.Append("  CartGuid: ").Append(CartGuid).Append("\n");
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
            return this.Equals(input as InvoiceCreateRequest);
        }

        /// <summary>
        /// Returns true if InvoiceCreateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceCreateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceCreateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CartGuid == input.CartGuid ||
                    (this.CartGuid != null &&
                    this.CartGuid.Equals(input.CartGuid))
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
                if (this.CartGuid != null)
                    hashCode = hashCode * 59 + this.CartGuid.GetHashCode();
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
