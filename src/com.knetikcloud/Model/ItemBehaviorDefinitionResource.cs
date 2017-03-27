/* 
 * Knetik Platform API Documentation latest 
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://knetikcloud.com
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

namespace com.knetikcloud.Model
{
    /// <summary>
    /// ItemBehaviorDefinitionResource
    /// </summary>
    [DataContract]
    public partial class ItemBehaviorDefinitionResource :  IEquatable<ItemBehaviorDefinitionResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemBehaviorDefinitionResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ItemBehaviorDefinitionResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemBehaviorDefinitionResource" /> class.
        /// </summary>
        /// <param name="Behavior">The default version of the behavior (required).</param>
        /// <param name="Modifiable">Whether the behavior&#39;s values can be modified (required).</param>
        /// <param name="Required">Whether the behavior can be removed (required).</param>
        public ItemBehaviorDefinitionResource(Behavior Behavior = default(Behavior), bool? Modifiable = default(bool?), bool? Required = default(bool?))
        {
            // to ensure "Behavior" is required (not null)
            if (Behavior == null)
            {
                throw new InvalidDataException("Behavior is a required property for ItemBehaviorDefinitionResource and cannot be null");
            }
            else
            {
                this.Behavior = Behavior;
            }
            // to ensure "Modifiable" is required (not null)
            if (Modifiable == null)
            {
                throw new InvalidDataException("Modifiable is a required property for ItemBehaviorDefinitionResource and cannot be null");
            }
            else
            {
                this.Modifiable = Modifiable;
            }
            // to ensure "Required" is required (not null)
            if (Required == null)
            {
                throw new InvalidDataException("Required is a required property for ItemBehaviorDefinitionResource and cannot be null");
            }
            else
            {
                this.Required = Required;
            }
        }
        
        /// <summary>
        /// The default version of the behavior
        /// </summary>
        /// <value>The default version of the behavior</value>
        [DataMember(Name="behavior", EmitDefaultValue=false)]
        public Behavior Behavior { get; set; }
        /// <summary>
        /// Whether the behavior&#39;s values can be modified
        /// </summary>
        /// <value>Whether the behavior&#39;s values can be modified</value>
        [DataMember(Name="modifiable", EmitDefaultValue=false)]
        public bool? Modifiable { get; set; }
        /// <summary>
        /// Whether the behavior can be removed
        /// </summary>
        /// <value>Whether the behavior can be removed</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool? Required { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemBehaviorDefinitionResource {\n");
            sb.Append("  Behavior: ").Append(Behavior).Append("\n");
            sb.Append("  Modifiable: ").Append(Modifiable).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
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
            return this.Equals(obj as ItemBehaviorDefinitionResource);
        }

        /// <summary>
        /// Returns true if ItemBehaviorDefinitionResource instances are equal
        /// </summary>
        /// <param name="other">Instance of ItemBehaviorDefinitionResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemBehaviorDefinitionResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Behavior == other.Behavior ||
                    this.Behavior != null &&
                    this.Behavior.Equals(other.Behavior)
                ) && 
                (
                    this.Modifiable == other.Modifiable ||
                    this.Modifiable != null &&
                    this.Modifiable.Equals(other.Modifiable)
                ) && 
                (
                    this.Required == other.Required ||
                    this.Required != null &&
                    this.Required.Equals(other.Required)
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
                if (this.Behavior != null)
                    hash = hash * 59 + this.Behavior.GetHashCode();
                if (this.Modifiable != null)
                    hash = hash * 59 + this.Modifiable.GetHashCode();
                if (this.Required != null)
                    hash = hash * 59 + this.Required.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
