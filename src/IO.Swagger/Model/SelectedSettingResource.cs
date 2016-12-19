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
    /// SelectedSettingResource
    /// </summary>
    [DataContract]
    public partial class SelectedSettingResource :  IEquatable<SelectedSettingResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectedSettingResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SelectedSettingResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectedSettingResource" /> class.
        /// </summary>
        /// <param name="Key">The unique ID for the setting (required).</param>
        /// <param name="KeyName">The textual name of the setting (required).</param>
        /// <param name="Value">The unique ID for the option (required).</param>
        /// <param name="ValueName">The textual name of the option (required).</param>
        public SelectedSettingResource(string Key = null, string KeyName = null, string Value = null, string ValueName = null)
        {
            // to ensure "Key" is required (not null)
            if (Key == null)
            {
                throw new InvalidDataException("Key is a required property for SelectedSettingResource and cannot be null");
            }
            else
            {
                this.Key = Key;
            }
            // to ensure "KeyName" is required (not null)
            if (KeyName == null)
            {
                throw new InvalidDataException("KeyName is a required property for SelectedSettingResource and cannot be null");
            }
            else
            {
                this.KeyName = KeyName;
            }
            // to ensure "Value" is required (not null)
            if (Value == null)
            {
                throw new InvalidDataException("Value is a required property for SelectedSettingResource and cannot be null");
            }
            else
            {
                this.Value = Value;
            }
            // to ensure "ValueName" is required (not null)
            if (ValueName == null)
            {
                throw new InvalidDataException("ValueName is a required property for SelectedSettingResource and cannot be null");
            }
            else
            {
                this.ValueName = ValueName;
            }
        }
        
        /// <summary>
        /// The unique ID for the setting
        /// </summary>
        /// <value>The unique ID for the setting</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }
        /// <summary>
        /// The textual name of the setting
        /// </summary>
        /// <value>The textual name of the setting</value>
        [DataMember(Name="key_name", EmitDefaultValue=false)]
        public string KeyName { get; set; }
        /// <summary>
        /// The unique ID for the option
        /// </summary>
        /// <value>The unique ID for the option</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        /// <summary>
        /// The textual name of the option
        /// </summary>
        /// <value>The textual name of the option</value>
        [DataMember(Name="value_name", EmitDefaultValue=false)]
        public string ValueName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SelectedSettingResource {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  KeyName: ").Append(KeyName).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  ValueName: ").Append(ValueName).Append("\n");
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
            return this.Equals(obj as SelectedSettingResource);
        }

        /// <summary>
        /// Returns true if SelectedSettingResource instances are equal
        /// </summary>
        /// <param name="other">Instance of SelectedSettingResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SelectedSettingResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Key == other.Key ||
                    this.Key != null &&
                    this.Key.Equals(other.Key)
                ) && 
                (
                    this.KeyName == other.KeyName ||
                    this.KeyName != null &&
                    this.KeyName.Equals(other.KeyName)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) && 
                (
                    this.ValueName == other.ValueName ||
                    this.ValueName != null &&
                    this.ValueName.Equals(other.ValueName)
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
                if (this.Key != null)
                    hash = hash * 59 + this.Key.GetHashCode();
                if (this.KeyName != null)
                    hash = hash * 59 + this.KeyName.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                if (this.ValueName != null)
                    hash = hash * 59 + this.ValueName.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
