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
    /// The definition of an activity parameters: ex: difficulty level
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
        /// <param name="DefaultValue">The default value of the setting (must be in options array). Ex: easy.</param>
        /// <param name="Description">The description of the setting: Ex: Choose the difficulty level to show more or less complicated questions (for a trivia activity).</param>
        /// <param name="Key">The unique ID for the setting: Ex: difficulty (required).</param>
        /// <param name="Name">The textual name of the setting: Ex: Difficulty Level (required).</param>
        /// <param name="Options">The set of options available for this setting, Ex: easy, medium, hard.</param>
        /// <param name="Type">The type of the setting value: Ex: TEXT (required).</param>
        public AvailableSettingResource(bool? AdvancedOption = default(bool?), string DefaultValue = default(string), string Description = default(string), string Key = default(string), string Name = default(string), List<SettingOption> Options = default(List<SettingOption>), string Type = default(string))
        {
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
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for AvailableSettingResource and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.AdvancedOption = AdvancedOption;
            this.DefaultValue = DefaultValue;
            this.Description = Description;
            this.Options = Options;
        }
        
        /// <summary>
        /// Whether the setting is advanced. Default: false
        /// </summary>
        /// <value>Whether the setting is advanced. Default: false</value>
        [DataMember(Name="advanced_option", EmitDefaultValue=false)]
        public bool? AdvancedOption { get; set; }

        /// <summary>
        /// The default value of the setting (must be in options array). Ex: easy
        /// </summary>
        /// <value>The default value of the setting (must be in options array). Ex: easy</value>
        [DataMember(Name="default_value", EmitDefaultValue=false)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// The description of the setting: Ex: Choose the difficulty level to show more or less complicated questions (for a trivia activity)
        /// </summary>
        /// <value>The description of the setting: Ex: Choose the difficulty level to show more or less complicated questions (for a trivia activity)</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The unique ID for the setting: Ex: difficulty
        /// </summary>
        /// <value>The unique ID for the setting: Ex: difficulty</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// The textual name of the setting: Ex: Difficulty Level
        /// </summary>
        /// <value>The textual name of the setting: Ex: Difficulty Level</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The set of options available for this setting, Ex: easy, medium, hard
        /// </summary>
        /// <value>The set of options available for this setting, Ex: easy, medium, hard</value>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public List<SettingOption> Options { get; set; }

        /// <summary>
        /// The type of the setting value: Ex: TEXT
        /// </summary>
        /// <value>The type of the setting value: Ex: TEXT</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

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
            return this.Equals(input as AvailableSettingResource);
        }

        /// <summary>
        /// Returns true if AvailableSettingResource instances are equal
        /// </summary>
        /// <param name="input">Instance of AvailableSettingResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvailableSettingResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdvancedOption == input.AdvancedOption ||
                    (this.AdvancedOption != null &&
                    this.AdvancedOption.Equals(input.AdvancedOption))
                ) && 
                (
                    this.DefaultValue == input.DefaultValue ||
                    (this.DefaultValue != null &&
                    this.DefaultValue.Equals(input.DefaultValue))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Options == input.Options ||
                    (this.Options != null &&
                    this.Options.SequenceEqual(input.Options))
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
                if (this.AdvancedOption != null)
                    hashCode = hashCode * 59 + this.AdvancedOption.GetHashCode();
                if (this.DefaultValue != null)
                    hashCode = hashCode * 59 + this.DefaultValue.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
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
