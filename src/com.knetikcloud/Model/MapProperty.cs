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
    /// MapProperty
    /// </summary>
    [DataContract]
    public partial class MapProperty : Property,  IEquatable<MapProperty>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MapProperty" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MapProperty() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MapProperty" /> class.
        /// </summary>
        /// <param name="Type">The type of the property. Used for polymorphic type recognition and thus must match an expected type with additional properties. (required).</param>
        /// <param name="Map">A map/object of string to sub-property (required).</param>
        public MapProperty(string Type = default(string), Dictionary<string, Property> Map = default(Dictionary<string, Property>))
        {
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for MapProperty and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            // to ensure "Map" is required (not null)
            if (Map == null)
            {
                throw new InvalidDataException("Map is a required property for MapProperty and cannot be null");
            }
            else
            {
                this.Map = Map;
            }
        }
        
        /// <summary>
        /// The type of the property. Used for polymorphic type recognition and thus must match an expected type with additional properties.
        /// </summary>
        /// <value>The type of the property. Used for polymorphic type recognition and thus must match an expected type with additional properties.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// A map/object of string to sub-property
        /// </summary>
        /// <value>A map/object of string to sub-property</value>
        [DataMember(Name="map", EmitDefaultValue=false)]
        public Dictionary<string, Property> Map { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MapProperty {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Map: ").Append(Map).Append("\n");
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
            return this.Equals(input as MapProperty);
        }

        /// <summary>
        /// Returns true if MapProperty instances are equal
        /// </summary>
        /// <param name="input">Instance of MapProperty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MapProperty input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Map == input.Map ||
                    (this.Map != null &&
                    this.Map.SequenceEqual(input.Map))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Map != null)
                    hashCode = hashCode * 59 + this.Map.GetHashCode();
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
