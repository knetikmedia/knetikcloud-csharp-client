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
    /// LevelingResource
    /// </summary>
    [DataContract]
    public partial class LevelingResource :  IEquatable<LevelingResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LevelingResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LevelingResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LevelingResource" /> class.
        /// </summary>
        /// <param name="AdditionalProperties">A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type.</param>
        /// <param name="Description">The description of the leveling schema.</param>
        /// <param name="Name">The name of the leveling schema.  IMMUTABLE (required).</param>
        /// <param name="Tiers">A set of tiers that contain experience boundaries.</param>
        /// <param name="TriggerEventName">The name of an event that will add one progress to this level when fired.</param>
        public LevelingResource(Dictionary<string, Property> AdditionalProperties = default(Dictionary<string, Property>), string Description = default(string), string Name = default(string), List<TierResource> Tiers = default(List<TierResource>), string TriggerEventName = default(string))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for LevelingResource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.AdditionalProperties = AdditionalProperties;
            this.Description = Description;
            this.Tiers = Tiers;
            this.TriggerEventName = TriggerEventName;
        }
        
        /// <summary>
        /// A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type
        /// </summary>
        /// <value>A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type</value>
        [DataMember(Name="additional_properties", EmitDefaultValue=false)]
        public Dictionary<string, Property> AdditionalProperties { get; set; }

        /// <summary>
        /// The date the leveling schema was created
        /// </summary>
        /// <value>The date the leveling schema was created</value>
        [DataMember(Name="created_date", EmitDefaultValue=false)]
        public long? CreatedDate { get; private set; }

        /// <summary>
        /// The description of the leveling schema
        /// </summary>
        /// <value>The description of the leveling schema</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the leveling schema.  IMMUTABLE
        /// </summary>
        /// <value>The name of the leveling schema.  IMMUTABLE</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// A set of tiers that contain experience boundaries
        /// </summary>
        /// <value>A set of tiers that contain experience boundaries</value>
        [DataMember(Name="tiers", EmitDefaultValue=false)]
        public List<TierResource> Tiers { get; set; }

        /// <summary>
        /// The name of an event that will add one progress to this level when fired
        /// </summary>
        /// <value>The name of an event that will add one progress to this level when fired</value>
        [DataMember(Name="trigger_event_name", EmitDefaultValue=false)]
        public string TriggerEventName { get; set; }

        /// <summary>
        /// The date the leveling schema was updated
        /// </summary>
        /// <value>The date the leveling schema was updated</value>
        [DataMember(Name="updated_date", EmitDefaultValue=false)]
        public long? UpdatedDate { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LevelingResource {\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Tiers: ").Append(Tiers).Append("\n");
            sb.Append("  TriggerEventName: ").Append(TriggerEventName).Append("\n");
            sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
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
            return this.Equals(input as LevelingResource);
        }

        /// <summary>
        /// Returns true if LevelingResource instances are equal
        /// </summary>
        /// <param name="input">Instance of LevelingResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LevelingResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdditionalProperties == input.AdditionalProperties ||
                    (this.AdditionalProperties != null &&
                    this.AdditionalProperties.SequenceEqual(input.AdditionalProperties))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Tiers == input.Tiers ||
                    (this.Tiers != null &&
                    this.Tiers.SequenceEqual(input.Tiers))
                ) && 
                (
                    this.TriggerEventName == input.TriggerEventName ||
                    (this.TriggerEventName != null &&
                    this.TriggerEventName.Equals(input.TriggerEventName))
                ) && 
                (
                    this.UpdatedDate == input.UpdatedDate ||
                    (this.UpdatedDate != null &&
                    this.UpdatedDate.Equals(input.UpdatedDate))
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
                if (this.AdditionalProperties != null)
                    hashCode = hashCode * 59 + this.AdditionalProperties.GetHashCode();
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Tiers != null)
                    hashCode = hashCode * 59 + this.Tiers.GetHashCode();
                if (this.TriggerEventName != null)
                    hashCode = hashCode * 59 + this.TriggerEventName.GetHashCode();
                if (this.UpdatedDate != null)
                    hashCode = hashCode * 59 + this.UpdatedDate.GetHashCode();
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
