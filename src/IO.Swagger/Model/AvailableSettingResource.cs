/* 
 * Knetik Platform API Documentation Latest
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://demo.sandbox.knetikcloud.com
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
    /// AvailableSettingResource
    /// </summary>
    [DataContract]
    public partial class AvailableSettingResource :  IEquatable<AvailableSettingResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableSettingResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AvailableSettingResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableSettingResource" /> class.
        /// </summary>
        /// <param name="AdvancedOption">Whether the setting is advanced. Default: false.</param>
        /// <param name="DefaultValue">The value of the default option (must be in options array) (required).</param>
        /// <param name="Description">The description of the setting.</param>
        /// <param name="Key">The unique ID for the setting (required).</param>
        /// <param name="Name">The textual name of the setting (required).</param>
        /// <param name="Options">The set of options available for this setting (required).</param>
        public AvailableSettingResource(bool? AdvancedOption = null, string DefaultValue = null, string Description = null, string Key = null, string Name = null, List<SettingOption> Options = null)
        {
            // to ensure "DefaultValue" is required (not null)
            if (DefaultValue == null)
            {
                throw new InvalidDataException("DefaultValue is a required property for AvailableSettingResource and cannot be null");
            }
            else
            {
                this.DefaultValue = DefaultValue;
            }
            // to ensure "Key" is required (not null)
            if (Key == null)
            {
                throw new InvalidDataException("Key is a required property for AvailableSettingResource and cannot be null");
            }
            else
            {
                this.Key = Key;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for AvailableSettingResource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Options" is required (not null)
            if (Options == null)
            {
                throw new InvalidDataException("Options is a required property for AvailableSettingResource and cannot be null");
            }
            else
            {
                this.Options = Options;
            }
            this.AdvancedOption = AdvancedOption;
            this.Description = Description;
        }
        
        /// <summary>
        /// Whether the setting is advanced. Default: false
        /// </summary>
        /// <value>Whether the setting is advanced. Default: false</value>
        [DataMember(Name="advanced_option", EmitDefaultValue=false)]
        public bool? AdvancedOption { get; set; }
        /// <summary>
        /// The value of the default option (must be in options array)
        /// </summary>
        /// <value>The value of the default option (must be in options array)</value>
        [DataMember(Name="default_value", EmitDefaultValue=false)]
        public string DefaultValue { get; set; }
        /// <summary>
        /// The description of the setting
        /// </summary>
        /// <value>The description of the setting</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
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
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The set of options available for this setting
        /// </summary>
        /// <value>The set of options available for this setting</value>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public List<SettingOption> Options { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvailableSettingResource {\n");
            sb.Append("  AdvancedOption: ").Append(AdvancedOption).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
            return this.Equals(obj as AvailableSettingResource);
        }

        /// <summary>
        /// Returns true if AvailableSettingResource instances are equal
        /// </summary>
        /// <param name="other">Instance of AvailableSettingResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvailableSettingResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AdvancedOption == other.AdvancedOption ||
                    this.AdvancedOption != null &&
                    this.AdvancedOption.Equals(other.AdvancedOption)
                ) && 
                (
                    this.DefaultValue == other.DefaultValue ||
                    this.DefaultValue != null &&
                    this.DefaultValue.Equals(other.DefaultValue)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Key == other.Key ||
                    this.Key != null &&
                    this.Key.Equals(other.Key)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Options == other.Options ||
                    this.Options != null &&
                    this.Options.SequenceEqual(other.Options)
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
                if (this.AdvancedOption != null)
                    hash = hash * 59 + this.AdvancedOption.GetHashCode();
                if (this.DefaultValue != null)
                    hash = hash * 59 + this.DefaultValue.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Key != null)
                    hash = hash * 59 + this.Key.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Options != null)
                    hash = hash * 59 + this.Options.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
