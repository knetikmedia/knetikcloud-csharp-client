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
    /// MapPropertyDefinitionResource
    /// </summary>
    [DataContract]
    public partial class MapPropertyDefinitionResource : PropertyDefinitionResource,  IEquatable<MapPropertyDefinitionResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MapPropertyDefinitionResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MapPropertyDefinitionResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MapPropertyDefinitionResource" /> class.
        /// </summary>
        /// <param name="Description">The description of the property.</param>
        /// <param name="FieldList">A list of the fields on both the property definition and property of this type.</param>
        /// <param name="FriendlyName">The friendly front-facing name of the property.</param>
        /// <param name="Name">The name of the property (required).</param>
        /// <param name="OptionLabelPath">The JSON path to the option label.</param>
        /// <param name="OptionValuePath">The JSON path to the option value.</param>
        /// <param name="OptionsUrl">URL of service containing the property options (assumed JSON array).</param>
        /// <param name="Required">Whether the property is required (required).</param>
        /// <param name="Type">The type of the property. Used for polymorphic type recognition and thus must match an expected type with additional properties. (required).</param>
        /// <param name="AllowAdditional">Whether to allow additional properties beyond those specified or not.</param>
        /// <param name="Properties">If provided, a list of property definitions for each map entry.</param>
        public MapPropertyDefinitionResource(string Description = default(string), PropertyFieldListResource FieldList = default(PropertyFieldListResource), string FriendlyName = default(string), string Name = default(string), string OptionLabelPath = default(string), string OptionValuePath = default(string), string OptionsUrl = default(string), bool? Required = default(bool?), string Type = default(string), bool? AllowAdditional = default(bool?), List<PropertyDefinitionResource> Properties = default(List<PropertyDefinitionResource>))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for MapPropertyDefinitionResource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Required" is required (not null)
            if (Required == null)
            {
                throw new InvalidDataException("Required is a required property for MapPropertyDefinitionResource and cannot be null");
            }
            else
            {
                this.Required = Required;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for MapPropertyDefinitionResource and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.Description = Description;
            this.FieldList = FieldList;
            this.FriendlyName = FriendlyName;
            this.OptionLabelPath = OptionLabelPath;
            this.OptionValuePath = OptionValuePath;
            this.OptionsUrl = OptionsUrl;
            this.AllowAdditional = AllowAdditional;
            this.Properties = Properties;
        }
        
        /// <summary>
        /// The description of the property
        /// </summary>
        /// <value>The description of the property</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// A list of the fields on both the property definition and property of this type
        /// </summary>
        /// <value>A list of the fields on both the property definition and property of this type</value>
        [DataMember(Name="field_list", EmitDefaultValue=false)]
        public PropertyFieldListResource FieldList { get; set; }

        /// <summary>
        /// The friendly front-facing name of the property
        /// </summary>
        /// <value>The friendly front-facing name of the property</value>
        [DataMember(Name="friendly_name", EmitDefaultValue=false)]
        public string FriendlyName { get; set; }

        /// <summary>
        /// The name of the property
        /// </summary>
        /// <value>The name of the property</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The JSON path to the option label
        /// </summary>
        /// <value>The JSON path to the option label</value>
        [DataMember(Name="option_label_path", EmitDefaultValue=false)]
        public string OptionLabelPath { get; set; }

        /// <summary>
        /// The JSON path to the option value
        /// </summary>
        /// <value>The JSON path to the option value</value>
        [DataMember(Name="option_value_path", EmitDefaultValue=false)]
        public string OptionValuePath { get; set; }

        /// <summary>
        /// URL of service containing the property options (assumed JSON array)
        /// </summary>
        /// <value>URL of service containing the property options (assumed JSON array)</value>
        [DataMember(Name="options_url", EmitDefaultValue=false)]
        public string OptionsUrl { get; set; }

        /// <summary>
        /// Whether the property is required
        /// </summary>
        /// <value>Whether the property is required</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool? Required { get; set; }

        /// <summary>
        /// The type of the property. Used for polymorphic type recognition and thus must match an expected type with additional properties.
        /// </summary>
        /// <value>The type of the property. Used for polymorphic type recognition and thus must match an expected type with additional properties.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Whether to allow additional properties beyond those specified or not
        /// </summary>
        /// <value>Whether to allow additional properties beyond those specified or not</value>
        [DataMember(Name="allow_additional", EmitDefaultValue=false)]
        public bool? AllowAdditional { get; set; }

        /// <summary>
        /// If provided, a list of property definitions for each map entry
        /// </summary>
        /// <value>If provided, a list of property definitions for each map entry</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public List<PropertyDefinitionResource> Properties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MapPropertyDefinitionResource {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FieldList: ").Append(FieldList).Append("\n");
            sb.Append("  FriendlyName: ").Append(FriendlyName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OptionLabelPath: ").Append(OptionLabelPath).Append("\n");
            sb.Append("  OptionValuePath: ").Append(OptionValuePath).Append("\n");
            sb.Append("  OptionsUrl: ").Append(OptionsUrl).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AllowAdditional: ").Append(AllowAdditional).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
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
            return this.Equals(input as MapPropertyDefinitionResource);
        }

        /// <summary>
        /// Returns true if MapPropertyDefinitionResource instances are equal
        /// </summary>
        /// <param name="input">Instance of MapPropertyDefinitionResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MapPropertyDefinitionResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.FieldList == input.FieldList ||
                    (this.FieldList != null &&
                    this.FieldList.Equals(input.FieldList))
                ) && 
                (
                    this.FriendlyName == input.FriendlyName ||
                    (this.FriendlyName != null &&
                    this.FriendlyName.Equals(input.FriendlyName))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OptionLabelPath == input.OptionLabelPath ||
                    (this.OptionLabelPath != null &&
                    this.OptionLabelPath.Equals(input.OptionLabelPath))
                ) && 
                (
                    this.OptionValuePath == input.OptionValuePath ||
                    (this.OptionValuePath != null &&
                    this.OptionValuePath.Equals(input.OptionValuePath))
                ) && 
                (
                    this.OptionsUrl == input.OptionsUrl ||
                    (this.OptionsUrl != null &&
                    this.OptionsUrl.Equals(input.OptionsUrl))
                ) && 
                (
                    this.Required == input.Required ||
                    (this.Required != null &&
                    this.Required.Equals(input.Required))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.AllowAdditional == input.AllowAdditional ||
                    (this.AllowAdditional != null &&
                    this.AllowAdditional.Equals(input.AllowAdditional))
                ) && 
                (
                    this.Properties == input.Properties ||
                    (this.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.FieldList != null)
                    hashCode = hashCode * 59 + this.FieldList.GetHashCode();
                if (this.FriendlyName != null)
                    hashCode = hashCode * 59 + this.FriendlyName.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OptionLabelPath != null)
                    hashCode = hashCode * 59 + this.OptionLabelPath.GetHashCode();
                if (this.OptionValuePath != null)
                    hashCode = hashCode * 59 + this.OptionValuePath.GetHashCode();
                if (this.OptionsUrl != null)
                    hashCode = hashCode * 59 + this.OptionsUrl.GetHashCode();
                if (this.Required != null)
                    hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.AllowAdditional != null)
                    hashCode = hashCode * 59 + this.AllowAdditional.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
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
