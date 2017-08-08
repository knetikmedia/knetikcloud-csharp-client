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
    /// PredicateResource
    /// </summary>
    [DataContract]
    public partial class PredicateResource :  IEquatable<PredicateResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PredicateResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PredicateResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PredicateResource" /> class.
        /// </summary>
        /// <param name="Args">The arguments the operator apply to. See notes for details. (required).</param>
        /// <param name="Op">The operator to be used in this predicate. See notes for details. (required).</param>
        /// <param name="Type">Type.</param>
        public PredicateResource(List<ExpressionResource> Args = default(List<ExpressionResource>), string Op = default(string), string Type = default(string))
        {
            // to ensure "Args" is required (not null)
            if (Args == null)
            {
                throw new InvalidDataException("Args is a required property for PredicateResource and cannot be null");
            }
            else
            {
                this.Args = Args;
            }
            // to ensure "Op" is required (not null)
            if (Op == null)
            {
                throw new InvalidDataException("Op is a required property for PredicateResource and cannot be null");
            }
            else
            {
                this.Op = Op;
            }
            this.Type = Type;
        }
        
        /// <summary>
        /// The arguments the operator apply to. See notes for details.
        /// </summary>
        /// <value>The arguments the operator apply to. See notes for details.</value>
        [DataMember(Name="args", EmitDefaultValue=false)]
        public List<ExpressionResource> Args { get; set; }

        /// <summary>
        /// The operator to be used in this predicate. See notes for details.
        /// </summary>
        /// <value>The operator to be used in this predicate. See notes for details.</value>
        [DataMember(Name="op", EmitDefaultValue=false)]
        public string Op { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PredicateResource {\n");
            sb.Append("  Args: ").Append(Args).Append("\n");
            sb.Append("  Op: ").Append(Op).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PredicateResource);
        }

        /// <summary>
        /// Returns true if PredicateResource instances are equal
        /// </summary>
        /// <param name="input">Instance of PredicateResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PredicateResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Args == input.Args ||
                    (this.Args != null &&
                    this.Args.SequenceEqual(input.Args))
                ) && 
                (
                    this.Op == input.Op ||
                    (this.Op != null &&
                    this.Op.Equals(input.Op))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Args != null)
                    hashCode = hashCode * 59 + this.Args.GetHashCode();
                if (this.Op != null)
                    hashCode = hashCode * 59 + this.Op.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
