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
    /// VariableTypeResource
    /// </summary>
    [DataContract]
    public partial class VariableTypeResource :  IEquatable<VariableTypeResource>, IValidatableObject
    {
        /// <summary>
        /// The base class of the type
        /// </summary>
        /// <value>The base class of the type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BaseEnum
        {
            
            /// <summary>
            /// Enum NUMBER for "NUMBER"
            /// </summary>
            [EnumMember(Value = "NUMBER")]
            NUMBER,
            
            /// <summary>
            /// Enum INTEGER for "INTEGER"
            /// </summary>
            [EnumMember(Value = "INTEGER")]
            INTEGER,
            
            /// <summary>
            /// Enum STRING for "STRING"
            /// </summary>
            [EnumMember(Value = "STRING")]
            STRING,
            
            /// <summary>
            /// Enum DATE for "DATE"
            /// </summary>
            [EnumMember(Value = "DATE")]
            DATE,
            
            /// <summary>
            /// Enum BOOLEAN for "BOOLEAN"
            /// </summary>
            [EnumMember(Value = "BOOLEAN")]
            BOOLEAN
        }

        /// <summary>
        /// The base class of the type
        /// </summary>
        /// <value>The base class of the type</value>
        [DataMember(Name="base", EmitDefaultValue=false)]
        public BaseEnum? _Base { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableTypeResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VariableTypeResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableTypeResource" /> class.
        /// </summary>
        /// <param name="_Base">The base class of the type (required).</param>
        /// <param name="Name">The name of the variable type. Used as the unique id (required).</param>
        public VariableTypeResource(BaseEnum? _Base = default(BaseEnum?), string Name = default(string))
        {
            // to ensure "_Base" is required (not null)
            if (_Base == null)
            {
                throw new InvalidDataException("_Base is a required property for VariableTypeResource and cannot be null");
            }
            else
            {
                this._Base = _Base;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for VariableTypeResource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
        }
        

        /// <summary>
        /// Whether the type comes from a set of valid values that the system can provided (such as users)
        /// </summary>
        /// <value>Whether the type comes from a set of valid values that the system can provided (such as users)</value>
        [DataMember(Name="enumerable", EmitDefaultValue=false)]
        public bool? Enumerable { get; private set; }

        /// <summary>
        /// The name of the variable type. Used as the unique id
        /// </summary>
        /// <value>The name of the variable type. Used as the unique id</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VariableTypeResource {\n");
            sb.Append("  _Base: ").Append(_Base).Append("\n");
            sb.Append("  Enumerable: ").Append(Enumerable).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as VariableTypeResource);
        }

        /// <summary>
        /// Returns true if VariableTypeResource instances are equal
        /// </summary>
        /// <param name="input">Instance of VariableTypeResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VariableTypeResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Base == input._Base ||
                    (this._Base != null &&
                    this._Base.Equals(input._Base))
                ) && 
                (
                    this.Enumerable == input.Enumerable ||
                    (this.Enumerable != null &&
                    this.Enumerable.Equals(input.Enumerable))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this._Base != null)
                    hashCode = hashCode * 59 + this._Base.GetHashCode();
                if (this.Enumerable != null)
                    hashCode = hashCode * 59 + this.Enumerable.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
