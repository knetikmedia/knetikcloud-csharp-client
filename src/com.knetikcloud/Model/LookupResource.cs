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
    /// Expressions are instructions for the rule engine to resolve certain values. For example instead of &#x60;user 1&#x60; it&#39;d state &#x60;user provided by the event&#x60;. Full list and definitions available at GET /bre/expressions.
    /// </summary>
    [DataContract]
    public partial class LookupResource :  IEquatable<LookupResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LookupResource" /> class.
        /// </summary>
        /// <param name="Definition">Definition.</param>
        /// <param name="LookupKey">LookupKey.</param>
        /// <param name="RequiredKeyType">RequiredKeyType.</param>
        /// <param name="Type">Type.</param>
        /// <param name="ValueType">ValueType.</param>
        public LookupResource(string Definition = default(string), ExpressionResource LookupKey = default(ExpressionResource), string RequiredKeyType = default(string), string Type = default(string), string ValueType = default(string))
        {
            this.Definition = Definition;
            this.LookupKey = LookupKey;
            this.RequiredKeyType = RequiredKeyType;
            this.Type = Type;
            this.ValueType = ValueType;
        }
        
        /// <summary>
        /// Gets or Sets Definition
        /// </summary>
        [DataMember(Name="definition", EmitDefaultValue=false)]
        public string Definition { get; set; }

        /// <summary>
        /// Gets or Sets LookupKey
        /// </summary>
        [DataMember(Name="lookup_key", EmitDefaultValue=false)]
        public ExpressionResource LookupKey { get; set; }

        /// <summary>
        /// Gets or Sets RequiredKeyType
        /// </summary>
        [DataMember(Name="required_key_type", EmitDefaultValue=false)]
        public string RequiredKeyType { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets ValueType
        /// </summary>
        [DataMember(Name="value_type", EmitDefaultValue=false)]
        public string ValueType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LookupResource {\n");
            sb.Append("  Definition: ").Append(Definition).Append("\n");
            sb.Append("  LookupKey: ").Append(LookupKey).Append("\n");
            sb.Append("  RequiredKeyType: ").Append(RequiredKeyType).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ValueType: ").Append(ValueType).Append("\n");
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
            return this.Equals(input as LookupResource);
        }

        /// <summary>
        /// Returns true if LookupResource instances are equal
        /// </summary>
        /// <param name="input">Instance of LookupResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LookupResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Definition == input.Definition ||
                    (this.Definition != null &&
                    this.Definition.Equals(input.Definition))
                ) && 
                (
                    this.LookupKey == input.LookupKey ||
                    (this.LookupKey != null &&
                    this.LookupKey.Equals(input.LookupKey))
                ) && 
                (
                    this.RequiredKeyType == input.RequiredKeyType ||
                    (this.RequiredKeyType != null &&
                    this.RequiredKeyType.Equals(input.RequiredKeyType))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ValueType == input.ValueType ||
                    (this.ValueType != null &&
                    this.ValueType.Equals(input.ValueType))
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
                if (this.Definition != null)
                    hashCode = hashCode * 59 + this.Definition.GetHashCode();
                if (this.LookupKey != null)
                    hashCode = hashCode * 59 + this.LookupKey.GetHashCode();
                if (this.RequiredKeyType != null)
                    hashCode = hashCode * 59 + this.RequiredKeyType.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ValueType != null)
                    hashCode = hashCode * 59 + this.ValueType.GetHashCode();
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
