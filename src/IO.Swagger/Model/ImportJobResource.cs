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
    /// ImportJobResource
    /// </summary>
    [DataContract]
    public partial class ImportJobResource :  IEquatable<ImportJobResource>, IValidatableObject
    {
        /// <summary>
        /// The status of the job
        /// </summary>
        /// <value>The status of the job</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum PENDINGVALIDATION for "PENDING_VALIDATION"
            /// </summary>
            [EnumMember(Value = "PENDING_VALIDATION")]
            PENDINGVALIDATION,
            
            /// <summary>
            /// Enum VALIDATING for "VALIDATING"
            /// </summary>
            [EnumMember(Value = "VALIDATING")]
            VALIDATING,
            
            /// <summary>
            /// Enum VALID for "VALID"
            /// </summary>
            [EnumMember(Value = "VALID")]
            VALID,
            
            /// <summary>
            /// Enum INVALID for "INVALID"
            /// </summary>
            [EnumMember(Value = "INVALID")]
            INVALID,
            
            /// <summary>
            /// Enum PENDINGPROCESS for "PENDING_PROCESS"
            /// </summary>
            [EnumMember(Value = "PENDING_PROCESS")]
            PENDINGPROCESS,
            
            /// <summary>
            /// Enum PROCESSING for "PROCESSING"
            /// </summary>
            [EnumMember(Value = "PROCESSING")]
            PROCESSING,
            
            /// <summary>
            /// Enum PROCESSED for "PROCESSED"
            /// </summary>
            [EnumMember(Value = "PROCESSED")]
            PROCESSED,
            
            /// <summary>
            /// Enum FAILED for "FAILED"
            /// </summary>
            [EnumMember(Value = "FAILED")]
            FAILED
        }

        /// <summary>
        /// The status of the job
        /// </summary>
        /// <value>The status of the job</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportJobResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImportJobResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportJobResource" /> class.
        /// </summary>
        /// <param name="CategoryId">The id of the category to assign all questions in the import to (required).</param>
        /// <param name="Name">A name for this import for later reference (required).</param>
        /// <param name="Output">Error information from validation.</param>
        /// <param name="Status">The status of the job.</param>
        /// <param name="Url">The url of a CSV file to pull trivia questions from. Cannot be changed after initial POST (required).</param>
        /// <param name="Vendor">The vendor who supplied this set of questions (required).</param>
        public ImportJobResource(string CategoryId = null, string Name = null, List<ImportJobOutputResource> Output = null, StatusEnum? Status = null, string Url = null, string Vendor = null)
        {
            // to ensure "CategoryId" is required (not null)
            if (CategoryId == null)
            {
                throw new InvalidDataException("CategoryId is a required property for ImportJobResource and cannot be null");
            }
            else
            {
                this.CategoryId = CategoryId;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for ImportJobResource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Url" is required (not null)
            if (Url == null)
            {
                throw new InvalidDataException("Url is a required property for ImportJobResource and cannot be null");
            }
            else
            {
                this.Url = Url;
            }
            // to ensure "Vendor" is required (not null)
            if (Vendor == null)
            {
                throw new InvalidDataException("Vendor is a required property for ImportJobResource and cannot be null");
            }
            else
            {
                this.Vendor = Vendor;
            }
            this.Output = Output;
            this.Status = Status;
        }
        
        /// <summary>
        /// The id of the category to assign all questions in the import to
        /// </summary>
        /// <value>The id of the category to assign all questions in the import to</value>
        [DataMember(Name="category_id", EmitDefaultValue=false)]
        public string CategoryId { get; set; }
        /// <summary>
        /// The date the job was created in seconds since unix epoc
        /// </summary>
        /// <value>The date the job was created in seconds since unix epoc</value>
        [DataMember(Name="created_date", EmitDefaultValue=false)]
        public long? CreatedDate { get; private set; }
        /// <summary>
        /// The id of the job
        /// </summary>
        /// <value>The id of the job</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }
        /// <summary>
        /// A name for this import for later reference
        /// </summary>
        /// <value>A name for this import for later reference</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Error information from validation
        /// </summary>
        /// <value>Error information from validation</value>
        [DataMember(Name="output", EmitDefaultValue=false)]
        public List<ImportJobOutputResource> Output { get; set; }
        /// <summary>
        /// The number of questions form the CSV file. Filled in after validation
        /// </summary>
        /// <value>The number of questions form the CSV file. Filled in after validation</value>
        [DataMember(Name="record_count", EmitDefaultValue=false)]
        public long? RecordCount { get; private set; }
        /// <summary>
        /// The date the job was last updated in seconds since unix epoc
        /// </summary>
        /// <value>The date the job was last updated in seconds since unix epoc</value>
        [DataMember(Name="updated_date", EmitDefaultValue=false)]
        public long? UpdatedDate { get; private set; }
        /// <summary>
        /// The url of a CSV file to pull trivia questions from. Cannot be changed after initial POST
        /// </summary>
        /// <value>The url of a CSV file to pull trivia questions from. Cannot be changed after initial POST</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }
        /// <summary>
        /// The vendor who supplied this set of questions
        /// </summary>
        /// <value>The vendor who supplied this set of questions</value>
        [DataMember(Name="vendor", EmitDefaultValue=false)]
        public string Vendor { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportJobResource {\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Output: ").Append(Output).Append("\n");
            sb.Append("  RecordCount: ").Append(RecordCount).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(obj as ImportJobResource);
        }

        /// <summary>
        /// Returns true if ImportJobResource instances are equal
        /// </summary>
        /// <param name="other">Instance of ImportJobResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportJobResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CategoryId == other.CategoryId ||
                    this.CategoryId != null &&
                    this.CategoryId.Equals(other.CategoryId)
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
                    this.Output == other.Output ||
                    this.Output != null &&
                    this.Output.SequenceEqual(other.Output)
                ) && 
                (
                    this.RecordCount == other.RecordCount ||
                    this.RecordCount != null &&
                    this.RecordCount.Equals(other.RecordCount)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.UpdatedDate == other.UpdatedDate ||
                    this.UpdatedDate != null &&
                    this.UpdatedDate.Equals(other.UpdatedDate)
                ) && 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
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
                if (this.CategoryId != null)
                    hash = hash * 59 + this.CategoryId.GetHashCode();
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Output != null)
                    hash = hash * 59 + this.Output.GetHashCode();
                if (this.RecordCount != null)
                    hash = hash * 59 + this.RecordCount.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.UpdatedDate != null)
                    hash = hash * 59 + this.UpdatedDate.GetHashCode();
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
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
