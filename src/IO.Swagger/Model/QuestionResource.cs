/* 
 * Knetik Platform API Documentation latest 
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://demo.sandbox.knetikcloud.com
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
    /// QuestionResource
    /// </summary>
    [DataContract]
    public partial class QuestionResource :  IEquatable<QuestionResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QuestionResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionResource" /> class.
        /// </summary>
        /// <param name="AdditionalProperties">A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type.</param>
        /// <param name="Answers">The list of available answers.</param>
        /// <param name="Category">The category for the question (required).</param>
        /// <param name="Difficulty">The difficulty of the question (required).</param>
        /// <param name="ImportId">The id of the import job that created the question, or null if not from an import.</param>
        /// <param name="PublishedDate">When the question becomes available, null for never, in seconds since epoch.</param>
        /// <param name="Question">The question. Different &#39;type&#39; values indicate different structures as the question may be test, image, etc. See information on additional properties for the list and their structures (required).</param>
        /// <param name="Source1">The first source of the question.</param>
        /// <param name="Source2">The second source of the question.</param>
        /// <param name="Tags">The list of tags.</param>
        /// <param name="Template">A question template this question is validated against (private). May be null and no validation of additional_properties will be done.</param>
        /// <param name="Vendor">The supplier of the question.</param>
        public QuestionResource(Dictionary<string, Property> AdditionalProperties = default(Dictionary<string, Property>), List<AnswerResource> Answers = default(List<AnswerResource>), NestedCategory Category = default(NestedCategory), int? Difficulty = default(int?), long? ImportId = default(long?), long? PublishedDate = default(long?), Property Question = default(Property), string Source1 = default(string), string Source2 = default(string), List<string> Tags = default(List<string>), string Template = default(string), string Vendor = default(string))
        {
            // to ensure "Category" is required (not null)
            if (Category == null)
            {
                throw new InvalidDataException("Category is a required property for QuestionResource and cannot be null");
            }
            else
            {
                this.Category = Category;
            }
            // to ensure "Difficulty" is required (not null)
            if (Difficulty == null)
            {
                throw new InvalidDataException("Difficulty is a required property for QuestionResource and cannot be null");
            }
            else
            {
                this.Difficulty = Difficulty;
            }
            // to ensure "Question" is required (not null)
            if (Question == null)
            {
                throw new InvalidDataException("Question is a required property for QuestionResource and cannot be null");
            }
            else
            {
                this.Question = Question;
            }
            this.AdditionalProperties = AdditionalProperties;
            this.Answers = Answers;
            this.ImportId = ImportId;
            this.PublishedDate = PublishedDate;
            this.Source1 = Source1;
            this.Source2 = Source2;
            this.Tags = Tags;
            this.Template = Template;
            this.Vendor = Vendor;
        }
        
        /// <summary>
        /// A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type
        /// </summary>
        /// <value>A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type</value>
        [DataMember(Name="additional_properties", EmitDefaultValue=false)]
        public Dictionary<string, Property> AdditionalProperties { get; set; }
        /// <summary>
        /// The list of available answers
        /// </summary>
        /// <value>The list of available answers</value>
        [DataMember(Name="answers", EmitDefaultValue=false)]
        public List<AnswerResource> Answers { get; set; }
        /// <summary>
        /// The category for the question
        /// </summary>
        /// <value>The category for the question</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public NestedCategory Category { get; set; }
        /// <summary>
        /// The date/time this resource was created in seconds since unix epoch
        /// </summary>
        /// <value>The date/time this resource was created in seconds since unix epoch</value>
        [DataMember(Name="created_date", EmitDefaultValue=false)]
        public long? CreatedDate { get; private set; }
        /// <summary>
        /// The difficulty of the question
        /// </summary>
        /// <value>The difficulty of the question</value>
        [DataMember(Name="difficulty", EmitDefaultValue=false)]
        public int? Difficulty { get; set; }
        /// <summary>
        /// The unique ID for that resource
        /// </summary>
        /// <value>The unique ID for that resource</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        /// <summary>
        /// The id of the import job that created the question, or null if not from an import
        /// </summary>
        /// <value>The id of the import job that created the question, or null if not from an import</value>
        [DataMember(Name="import_id", EmitDefaultValue=false)]
        public long? ImportId { get; set; }
        /// <summary>
        /// When the question becomes available, null for never, in seconds since epoch
        /// </summary>
        /// <value>When the question becomes available, null for never, in seconds since epoch</value>
        [DataMember(Name="published_date", EmitDefaultValue=false)]
        public long? PublishedDate { get; set; }
        /// <summary>
        /// The question. Different &#39;type&#39; values indicate different structures as the question may be test, image, etc. See information on additional properties for the list and their structures
        /// </summary>
        /// <value>The question. Different &#39;type&#39; values indicate different structures as the question may be test, image, etc. See information on additional properties for the list and their structures</value>
        [DataMember(Name="question", EmitDefaultValue=false)]
        public Property Question { get; set; }
        /// <summary>
        /// The first source of the question
        /// </summary>
        /// <value>The first source of the question</value>
        [DataMember(Name="source1", EmitDefaultValue=false)]
        public string Source1 { get; set; }
        /// <summary>
        /// The second source of the question
        /// </summary>
        /// <value>The second source of the question</value>
        [DataMember(Name="source2", EmitDefaultValue=false)]
        public string Source2 { get; set; }
        /// <summary>
        /// The list of tags
        /// </summary>
        /// <value>The list of tags</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }
        /// <summary>
        /// A question template this question is validated against (private). May be null and no validation of additional_properties will be done
        /// </summary>
        /// <value>A question template this question is validated against (private). May be null and no validation of additional_properties will be done</value>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public string Template { get; set; }
        /// <summary>
        /// The date/time this resource was last updated in seconds since unix epoch
        /// </summary>
        /// <value>The date/time this resource was last updated in seconds since unix epoch</value>
        [DataMember(Name="updated_date", EmitDefaultValue=false)]
        public long? UpdatedDate { get; private set; }
        /// <summary>
        /// The supplier of the question
        /// </summary>
        /// <value>The supplier of the question</value>
        [DataMember(Name="vendor", EmitDefaultValue=false)]
        public string Vendor { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuestionResource {\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("  Answers: ").Append(Answers).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Difficulty: ").Append(Difficulty).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ImportId: ").Append(ImportId).Append("\n");
            sb.Append("  PublishedDate: ").Append(PublishedDate).Append("\n");
            sb.Append("  Question: ").Append(Question).Append("\n");
            sb.Append("  Source1: ").Append(Source1).Append("\n");
            sb.Append("  Source2: ").Append(Source2).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
            sb.Append("  Vendor: ").Append(Vendor).Append("\n");
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
            return this.Equals(obj as QuestionResource);
        }

        /// <summary>
        /// Returns true if QuestionResource instances are equal
        /// </summary>
        /// <param name="other">Instance of QuestionResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuestionResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
                ) && 
                (
                    this.Answers == other.Answers ||
                    this.Answers != null &&
                    this.Answers.SequenceEqual(other.Answers)
                ) && 
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.Difficulty == other.Difficulty ||
                    this.Difficulty != null &&
                    this.Difficulty.Equals(other.Difficulty)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.ImportId == other.ImportId ||
                    this.ImportId != null &&
                    this.ImportId.Equals(other.ImportId)
                ) && 
                (
                    this.PublishedDate == other.PublishedDate ||
                    this.PublishedDate != null &&
                    this.PublishedDate.Equals(other.PublishedDate)
                ) && 
                (
                    this.Question == other.Question ||
                    this.Question != null &&
                    this.Question.Equals(other.Question)
                ) && 
                (
                    this.Source1 == other.Source1 ||
                    this.Source1 != null &&
                    this.Source1.Equals(other.Source1)
                ) && 
                (
                    this.Source2 == other.Source2 ||
                    this.Source2 != null &&
                    this.Source2.Equals(other.Source2)
                ) && 
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(other.Tags)
                ) && 
                (
                    this.Template == other.Template ||
                    this.Template != null &&
                    this.Template.Equals(other.Template)
                ) && 
                (
                    this.UpdatedDate == other.UpdatedDate ||
                    this.UpdatedDate != null &&
                    this.UpdatedDate.Equals(other.UpdatedDate)
                ) && 
                (
                    this.Vendor == other.Vendor ||
                    this.Vendor != null &&
                    this.Vendor.Equals(other.Vendor)
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
                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();
                if (this.Answers != null)
                    hash = hash * 59 + this.Answers.GetHashCode();
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                if (this.Difficulty != null)
                    hash = hash * 59 + this.Difficulty.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.ImportId != null)
                    hash = hash * 59 + this.ImportId.GetHashCode();
                if (this.PublishedDate != null)
                    hash = hash * 59 + this.PublishedDate.GetHashCode();
                if (this.Question != null)
                    hash = hash * 59 + this.Question.GetHashCode();
                if (this.Source1 != null)
                    hash = hash * 59 + this.Source1.GetHashCode();
                if (this.Source2 != null)
                    hash = hash * 59 + this.Source2.GetHashCode();
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
                if (this.Template != null)
                    hash = hash * 59 + this.Template.GetHashCode();
                if (this.UpdatedDate != null)
                    hash = hash * 59 + this.UpdatedDate.GetHashCode();
                if (this.Vendor != null)
                    hash = hash * 59 + this.Vendor.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}