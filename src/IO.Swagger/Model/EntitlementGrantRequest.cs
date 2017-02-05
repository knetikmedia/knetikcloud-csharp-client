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
    /// EntitlementGrantRequest
    /// </summary>
    [DataContract]
    public partial class EntitlementGrantRequest :  IEquatable<EntitlementGrantRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntitlementGrantRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EntitlementGrantRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EntitlementGrantRequest" /> class.
        /// </summary>
        /// <param name="EntitlementId">The ID of the entitlement item to grant (required).</param>
        public EntitlementGrantRequest(int? EntitlementId = default(int?))
        {
            // to ensure "EntitlementId" is required (not null)
            if (EntitlementId == null)
            {
                throw new InvalidDataException("EntitlementId is a required property for EntitlementGrantRequest and cannot be null");
            }
            else
            {
                this.EntitlementId = EntitlementId;
            }
        }
        
        /// <summary>
        /// The ID of the entitlement item to grant
        /// </summary>
        /// <value>The ID of the entitlement item to grant</value>
        [DataMember(Name="entitlement_id", EmitDefaultValue=false)]
        public int? EntitlementId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EntitlementGrantRequest {\n");
            sb.Append("  EntitlementId: ").Append(EntitlementId).Append("\n");
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
            return this.Equals(obj as EntitlementGrantRequest);
        }

        /// <summary>
        /// Returns true if EntitlementGrantRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of EntitlementGrantRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntitlementGrantRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EntitlementId == other.EntitlementId ||
                    this.EntitlementId != null &&
                    this.EntitlementId.Equals(other.EntitlementId)
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
                if (this.EntitlementId != null)
                    hash = hash * 59 + this.EntitlementId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
