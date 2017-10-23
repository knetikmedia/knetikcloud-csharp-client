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
    public partial class DefaultOperationResource :  IEquatable<DefaultOperationResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultOperationResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DefaultOperationResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultOperationResource" /> class.
        /// </summary>
        /// <param name="Args">The arguments the operator apply to. See notes for details. (required).</param>
        /// <param name="Definition">Definition.</param>
        /// <param name="Op">The operator to be used in this predicate. See notes for details. (required).</param>
        /// <param name="ReturnType">ReturnType.</param>
        /// <param name="SupportedOperators">The operators supported by this expression.</param>
        /// <param name="Type">Type.</param>
        public DefaultOperationResource(List<ExpressionResource> Args = default(List<ExpressionResource>), string Definition = default(string), string Op = default(string), string ReturnType = default(string), List<OperationDefinitionResource> SupportedOperators = default(List<OperationDefinitionResource>), string Type = default(string))
        {
            // to ensure "Args" is required (not null)
            if (Args == null)
            {
                throw new InvalidDataException("Args is a required property for DefaultOperationResource and cannot be null");
            }
            else
            {
                this.Args = Args;
            }
            // to ensure "Op" is required (not null)
            if (Op == null)
            {
                throw new InvalidDataException("Op is a required property for DefaultOperationResource and cannot be null");
            }
            else
            {
                this.Op = Op;
            }
            this.Definition = Definition;
            this.ReturnType = ReturnType;
            this.SupportedOperators = SupportedOperators;
            this.Type = Type;
        }
        
        /// <summary>
        /// The arguments the operator apply to. See notes for details.
        /// </summary>
        /// <value>The arguments the operator apply to. See notes for details.</value>
        [DataMember(Name="args", EmitDefaultValue=false)]
        public List<ExpressionResource> Args { get; set; }

        /// <summary>
        /// Gets or Sets Definition
        /// </summary>
        [DataMember(Name="definition", EmitDefaultValue=false)]
        public string Definition { get; set; }

        /// <summary>
        /// The operator to be used in this predicate. See notes for details.
        /// </summary>
        /// <value>The operator to be used in this predicate. See notes for details.</value>
        [DataMember(Name="op", EmitDefaultValue=false)]
        public string Op { get; set; }

        /// <summary>
        /// Gets or Sets ReturnType
        /// </summary>
        [DataMember(Name="return_type", EmitDefaultValue=false)]
        public string ReturnType { get; set; }

        /// <summary>
        /// The operators supported by this expression
        /// </summary>
        /// <value>The operators supported by this expression</value>
        [DataMember(Name="supported_operators", EmitDefaultValue=false)]
        public List<OperationDefinitionResource> SupportedOperators { get; set; }

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
            sb.Append("class DefaultOperationResource {\n");
            sb.Append("  Args: ").Append(Args).Append("\n");
            sb.Append("  Definition: ").Append(Definition).Append("\n");
            sb.Append("  Op: ").Append(Op).Append("\n");
            sb.Append("  ReturnType: ").Append(ReturnType).Append("\n");
            sb.Append("  SupportedOperators: ").Append(SupportedOperators).Append("\n");
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
            return this.Equals(input as DefaultOperationResource);
        }

        /// <summary>
        /// Returns true if DefaultOperationResource instances are equal
        /// </summary>
        /// <param name="input">Instance of DefaultOperationResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DefaultOperationResource input)
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
                    this.Definition == input.Definition ||
                    (this.Definition != null &&
                    this.Definition.Equals(input.Definition))
                ) && 
                (
                    this.Op == input.Op ||
                    (this.Op != null &&
                    this.Op.Equals(input.Op))
                ) && 
                (
                    this.ReturnType == input.ReturnType ||
                    (this.ReturnType != null &&
                    this.ReturnType.Equals(input.ReturnType))
                ) && 
                (
                    this.SupportedOperators == input.SupportedOperators ||
                    (this.SupportedOperators != null &&
                    this.SupportedOperators.SequenceEqual(input.SupportedOperators))
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
                if (this.Definition != null)
                    hashCode = hashCode * 59 + this.Definition.GetHashCode();
                if (this.Op != null)
                    hashCode = hashCode * 59 + this.Op.GetHashCode();
                if (this.ReturnType != null)
                    hashCode = hashCode * 59 + this.ReturnType.GetHashCode();
                if (this.SupportedOperators != null)
                    hashCode = hashCode * 59 + this.SupportedOperators.GetHashCode();
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
