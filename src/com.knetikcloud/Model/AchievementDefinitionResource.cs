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
    /// AchievementDefinitionResource
    /// </summary>
    [DataContract]
    public partial class AchievementDefinitionResource :  IEquatable<AchievementDefinitionResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AchievementDefinitionResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AchievementDefinitionResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AchievementDefinitionResource" /> class.
        /// </summary>
        /// <param name="AdditionalProperties">A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this resource type.</param>
        /// <param name="Description">The description of the achievement. Must be at least 2 characters in length..</param>
        /// <param name="Hidden">Whether the achievement is hidden from the user (required).</param>
        /// <param name="Name">The name of the achievement. Must be at least 6 characters in length. IMMUTABLE (required).</param>
        /// <param name="RequiredProgress">The required progress for the achievement definition (required).</param>
        /// <param name="Tags">The tags for the achievement definition.</param>
        /// <param name="Template">An achievement template this achievement is validated against (private). May be null and no validation of additional_properties will be done.</param>
        /// <param name="TriggerEventName">The name of the trigger event associated with this achievement.</param>
        public AchievementDefinitionResource(Dictionary<string, Property> AdditionalProperties = default(Dictionary<string, Property>), string Description = default(string), bool? Hidden = default(bool?), string Name = default(string), int? RequiredProgress = default(int?), List<string> Tags = default(List<string>), string Template = default(string), string TriggerEventName = default(string))
        {
            // to ensure "Hidden" is required (not null)
            if (Hidden == null)
            {
                throw new InvalidDataException("Hidden is a required property for AchievementDefinitionResource and cannot be null");
            }
            else
            {
                this.Hidden = Hidden;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for AchievementDefinitionResource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "RequiredProgress" is required (not null)
            if (RequiredProgress == null)
            {
                throw new InvalidDataException("RequiredProgress is a required property for AchievementDefinitionResource and cannot be null");
            }
            else
            {
                this.RequiredProgress = RequiredProgress;
            }
            this.AdditionalProperties = AdditionalProperties;
            this.Description = Description;
            this.Tags = Tags;
            this.Template = Template;
            this.TriggerEventName = TriggerEventName;
        }
        
        /// <summary>
        /// A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this resource type
        /// </summary>
        /// <value>A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this resource type</value>
        [DataMember(Name="additional_properties", EmitDefaultValue=false)]
        public Dictionary<string, Property> AdditionalProperties { get; set; }

        /// <summary>
        /// The date/time this resource was created in seconds since unix epoch
        /// </summary>
        /// <value>The date/time this resource was created in seconds since unix epoch</value>
        [DataMember(Name="created_date", EmitDefaultValue=false)]
        public long? CreatedDate { get; private set; }

        /// <summary>
        /// The description of the achievement. Must be at least 2 characters in length.
        /// </summary>
        /// <value>The description of the achievement. Must be at least 2 characters in length.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Whether the achievement is hidden from the user
        /// </summary>
        /// <value>Whether the achievement is hidden from the user</value>
        [DataMember(Name="hidden", EmitDefaultValue=false)]
        public bool? Hidden { get; set; }

        /// <summary>
        /// The name of the achievement. Must be at least 6 characters in length. IMMUTABLE
        /// </summary>
        /// <value>The name of the achievement. Must be at least 6 characters in length. IMMUTABLE</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The required progress for the achievement definition
        /// </summary>
        /// <value>The required progress for the achievement definition</value>
        [DataMember(Name="required_progress", EmitDefaultValue=false)]
        public int? RequiredProgress { get; set; }

        /// <summary>
        /// The id of the rule generated for this achievement
        /// </summary>
        /// <value>The id of the rule generated for this achievement</value>
        [DataMember(Name="rule_id", EmitDefaultValue=false)]
        public string RuleId { get; private set; }

        /// <summary>
        /// The tags for the achievement definition
        /// </summary>
        /// <value>The tags for the achievement definition</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// An achievement template this achievement is validated against (private). May be null and no validation of additional_properties will be done
        /// </summary>
        /// <value>An achievement template this achievement is validated against (private). May be null and no validation of additional_properties will be done</value>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public string Template { get; set; }

        /// <summary>
        /// The name of the trigger event associated with this achievement
        /// </summary>
        /// <value>The name of the trigger event associated with this achievement</value>
        [DataMember(Name="trigger_event_name", EmitDefaultValue=false)]
        public string TriggerEventName { get; set; }

        /// <summary>
        /// The date/time this resource was last updated in seconds since unix epoch
        /// </summary>
        /// <value>The date/time this resource was last updated in seconds since unix epoch</value>
        [DataMember(Name="updated_date", EmitDefaultValue=false)]
        public long? UpdatedDate { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AchievementDefinitionResource {\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Hidden: ").Append(Hidden).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RequiredProgress: ").Append(RequiredProgress).Append("\n");
            sb.Append("  RuleId: ").Append(RuleId).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
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
            return this.Equals(input as AchievementDefinitionResource);
        }

        /// <summary>
        /// Returns true if AchievementDefinitionResource instances are equal
        /// </summary>
        /// <param name="input">Instance of AchievementDefinitionResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AchievementDefinitionResource input)
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
                    this.Hidden == input.Hidden ||
                    (this.Hidden != null &&
                    this.Hidden.Equals(input.Hidden))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.RequiredProgress == input.RequiredProgress ||
                    (this.RequiredProgress != null &&
                    this.RequiredProgress.Equals(input.RequiredProgress))
                ) && 
                (
                    this.RuleId == input.RuleId ||
                    (this.RuleId != null &&
                    this.RuleId.Equals(input.RuleId))
                ) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags))
                ) && 
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
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
                if (this.Hidden != null)
                    hashCode = hashCode * 59 + this.Hidden.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RequiredProgress != null)
                    hashCode = hashCode * 59 + this.RequiredProgress.GetHashCode();
                if (this.RuleId != null)
                    hashCode = hashCode * 59 + this.RuleId.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Template != null)
                    hashCode = hashCode * 59 + this.Template.GetHashCode();
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