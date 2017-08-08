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
    /// GooglePaymentRequest
    /// </summary>
    [DataContract]
    public partial class GooglePaymentRequest :  IEquatable<GooglePaymentRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooglePaymentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GooglePaymentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GooglePaymentRequest" /> class.
        /// </summary>
        /// <param name="JsonPayload">The json payload exactly as sent from Google (required).</param>
        /// <param name="Signature">The signature from Google to verify the payload (required).</param>
        public GooglePaymentRequest(string JsonPayload = default(string), string Signature = default(string))
        {
            // to ensure "JsonPayload" is required (not null)
            if (JsonPayload == null)
            {
                throw new InvalidDataException("JsonPayload is a required property for GooglePaymentRequest and cannot be null");
            }
            else
            {
                this.JsonPayload = JsonPayload;
            }
            // to ensure "Signature" is required (not null)
            if (Signature == null)
            {
                throw new InvalidDataException("Signature is a required property for GooglePaymentRequest and cannot be null");
            }
            else
            {
                this.Signature = Signature;
            }
        }
        
        /// <summary>
        /// The json payload exactly as sent from Google
        /// </summary>
        /// <value>The json payload exactly as sent from Google</value>
        [DataMember(Name="json_payload", EmitDefaultValue=false)]
        public string JsonPayload { get; set; }

        /// <summary>
        /// The signature from Google to verify the payload
        /// </summary>
        /// <value>The signature from Google to verify the payload</value>
        [DataMember(Name="signature", EmitDefaultValue=false)]
        public string Signature { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GooglePaymentRequest {\n");
            sb.Append("  JsonPayload: ").Append(JsonPayload).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
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
            return this.Equals(input as GooglePaymentRequest);
        }

        /// <summary>
        /// Returns true if GooglePaymentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GooglePaymentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GooglePaymentRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JsonPayload == input.JsonPayload ||
                    (this.JsonPayload != null &&
                    this.JsonPayload.Equals(input.JsonPayload))
                ) && 
                (
                    this.Signature == input.Signature ||
                    (this.Signature != null &&
                    this.Signature.Equals(input.Signature))
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
                if (this.JsonPayload != null)
                    hashCode = hashCode * 59 + this.JsonPayload.GetHashCode();
                if (this.Signature != null)
                    hashCode = hashCode * 59 + this.Signature.GetHashCode();
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
