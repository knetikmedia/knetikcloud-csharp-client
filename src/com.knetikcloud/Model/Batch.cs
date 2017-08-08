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
    /// Batch
    /// </summary>
    [DataContract]
    public partial class Batch :  IEquatable<Batch>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Batch" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Batch() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Batch" /> class.
        /// </summary>
        /// <param name="_Batch">The list of batch requests (required).</param>
        /// <param name="Timeout">The amount of time before a request token is returned instead of the batch result.  Default is 60.  Range is 0-300 (required).</param>
        public Batch(List<BatchRequest> _Batch = default(List<BatchRequest>), int? Timeout = default(int?))
        {
            // to ensure "_Batch" is required (not null)
            if (_Batch == null)
            {
                throw new InvalidDataException("_Batch is a required property for Batch and cannot be null");
            }
            else
            {
                this._Batch = _Batch;
            }
            // to ensure "Timeout" is required (not null)
            if (Timeout == null)
            {
                throw new InvalidDataException("Timeout is a required property for Batch and cannot be null");
            }
            else
            {
                this.Timeout = Timeout;
            }
        }
        
        /// <summary>
        /// The list of batch requests
        /// </summary>
        /// <value>The list of batch requests</value>
        [DataMember(Name="batch", EmitDefaultValue=false)]
        public List<BatchRequest> _Batch { get; set; }

        /// <summary>
        /// The amount of time before a request token is returned instead of the batch result.  Default is 60.  Range is 0-300
        /// </summary>
        /// <value>The amount of time before a request token is returned instead of the batch result.  Default is 60.  Range is 0-300</value>
        [DataMember(Name="timeout", EmitDefaultValue=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Batch {\n");
            sb.Append("  _Batch: ").Append(_Batch).Append("\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
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
            return this.Equals(input as Batch);
        }

        /// <summary>
        /// Returns true if Batch instances are equal
        /// </summary>
        /// <param name="input">Instance of Batch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Batch input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Batch == input._Batch ||
                    (this._Batch != null &&
                    this._Batch.SequenceEqual(input._Batch))
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
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
                if (this._Batch != null)
                    hashCode = hashCode * 59 + this._Batch.GetHashCode();
                if (this.Timeout != null)
                    hashCode = hashCode * 59 + this.Timeout.GetHashCode();
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