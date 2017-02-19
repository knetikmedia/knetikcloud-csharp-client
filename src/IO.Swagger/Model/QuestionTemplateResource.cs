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

namespace IO.Swagger.Model
{
    /// <summary>
    /// QuestionTemplateResource
    /// </summary>
    [DataContract]
    public partial class QuestionTemplateResource :  IEquatable<QuestionTemplateResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionTemplateResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QuestionTemplateResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionTemplateResource" /> class.
        /// </summary>
        /// <param name="AnswerProperty">A property definition for all answers. If included each answer must match this definition&#39;s type and be valid.</param>
        /// <param name="Name">The name of the template (required).</param>
        /// <param name="Properties">The customized properties that are present.</param>
        /// <param name="QuestionProperty">A property definition for the question itself. If included the answer must match this definition&#39;s type and be valid.</param>
        public QuestionTemplateResource(PropertyDefinitionResource AnswerProperty = default(PropertyDefinitionResource), string Name = default(string), List<PropertyDefinitionResource> Properties = default(List<PropertyDefinitionResource>), PropertyDefinitionResource QuestionProperty = default(PropertyDefinitionResource))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for QuestionTemplateResource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.AnswerProperty = AnswerProperty;
            this.Properties = Properties;
            this.QuestionProperty = QuestionProperty;
        }
        
        /// <summary>
        /// A property definition for all answers. If included each answer must match this definition&#39;s type and be valid
        /// </summary>
        /// <value>A property definition for all answers. If included each answer must match this definition&#39;s type and be valid</value>
        [DataMember(Name="answer_property", EmitDefaultValue=false)]
        public PropertyDefinitionResource AnswerProperty { get; set; }
        /// <summary>
        /// The date/time this resource was created in seconds since unix epoch
        /// </summary>
        /// <value>The date/time this resource was created in seconds since unix epoch</value>
        [DataMember(Name="created_date", EmitDefaultValue=false)]
        public long? CreatedDate { get; private set; }
        /// <summary>
        /// The id of the template
        /// </summary>
        /// <value>The id of the template</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        /// <summary>
        /// The name of the template
        /// </summary>
        /// <value>The name of the template</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The customized properties that are present
        /// </summary>
        /// <value>The customized properties that are present</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public List<PropertyDefinitionResource> Properties { get; set; }
        /// <summary>
        /// A property definition for the question itself. If included the answer must match this definition&#39;s type and be valid
        /// </summary>
        /// <value>A property definition for the question itself. If included the answer must match this definition&#39;s type and be valid</value>
        [DataMember(Name="question_property", EmitDefaultValue=false)]
        public PropertyDefinitionResource QuestionProperty { get; set; }
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
            sb.Append("class QuestionTemplateResource {\n");
            sb.Append("  AnswerProperty: ").Append(AnswerProperty).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  QuestionProperty: ").Append(QuestionProperty).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as QuestionTemplateResource);
        }

        /// <summary>
        /// Returns true if QuestionTemplateResource instances are equal
        /// </summary>
        /// <param name="other">Instance of QuestionTemplateResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuestionTemplateResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AnswerProperty == other.AnswerProperty ||
                    this.AnswerProperty != null &&
                    this.AnswerProperty.Equals(other.AnswerProperty)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.SequenceEqual(other.Properties)
                ) && 
                (
                    this.QuestionProperty == other.QuestionProperty ||
                    this.QuestionProperty != null &&
                    this.QuestionProperty.Equals(other.QuestionProperty)
                ) && 
                (
                    this.UpdatedDate == other.UpdatedDate ||
                    this.UpdatedDate != null &&
                    this.UpdatedDate.Equals(other.UpdatedDate)
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
                if (this.AnswerProperty != null)
                    hash = hash * 59 + this.AnswerProperty.GetHashCode();
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();
                if (this.QuestionProperty != null)
                    hash = hash * 59 + this.QuestionProperty.GetHashCode();
                if (this.UpdatedDate != null)
                    hash = hash * 59 + this.UpdatedDate.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
