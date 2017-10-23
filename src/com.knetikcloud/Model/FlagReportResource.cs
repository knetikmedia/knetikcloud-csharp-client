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
    /// FlagReportResource
    /// </summary>
    [DataContract]
    public partial class FlagReportResource :  IEquatable<FlagReportResource>, IValidatableObject
    {
        /// <summary>
        /// The resolution of that resource
        /// </summary>
        /// <value>The resolution of that resource</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResolutionEnum
        {
            
            /// <summary>
            /// Enum Banned for "banned"
            /// </summary>
            [EnumMember(Value = "banned")]
            Banned,
            
            /// <summary>
            /// Enum Ignored for "ignored"
            /// </summary>
            [EnumMember(Value = "ignored")]
            Ignored
        }

        /// <summary>
        /// The resolution of that resource
        /// </summary>
        /// <value>The resolution of that resource</value>
        [DataMember(Name="resolution", EmitDefaultValue=false)]
        public ResolutionEnum? Resolution { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlagReportResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FlagReportResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlagReportResource" /> class.
        /// </summary>
        /// <param name="Reason">The reason of that resource required only in case of active resolution.</param>
        /// <param name="Resolution">The resolution of that resource (required).</param>
        public FlagReportResource(string Reason = default(string), ResolutionEnum? Resolution = default(ResolutionEnum?))
        {
            // to ensure "Resolution" is required (not null)
            if (Resolution == null)
            {
                throw new InvalidDataException("Resolution is a required property for FlagReportResource and cannot be null");
            }
            else
            {
                this.Resolution = Resolution;
            }
            this.Reason = Reason;
        }
        
        /// <summary>
        /// The context of that resource 
        /// </summary>
        /// <value>The context of that resource </value>
        [DataMember(Name="context", EmitDefaultValue=false)]
        public string Context { get; private set; }

        /// <summary>
        /// The context ID of that resource
        /// </summary>
        /// <value>The context ID of that resource</value>
        [DataMember(Name="context_id", EmitDefaultValue=false)]
        public string ContextId { get; private set; }

        /// <summary>
        /// The date/time this resource was created in seconds since epoch
        /// </summary>
        /// <value>The date/time this resource was created in seconds since epoch</value>
        [DataMember(Name="created_date", EmitDefaultValue=false)]
        public long? CreatedDate { get; private set; }

        /// <summary>
        /// The unique ID for that resource
        /// </summary>
        /// <value>The unique ID for that resource</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The reason of that resource required only in case of active resolution
        /// </summary>
        /// <value>The reason of that resource required only in case of active resolution</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }


        /// <summary>
        /// The date/time this report was resolved in seconds since epoch. Null if not resolved yet
        /// </summary>
        /// <value>The date/time this report was resolved in seconds since epoch. Null if not resolved yet</value>
        [DataMember(Name="resolved", EmitDefaultValue=false)]
        public long? Resolved { get; private set; }

        /// <summary>
        /// The date/time this resource was last updated in seconds since epoch
        /// </summary>
        /// <value>The date/time this resource was last updated in seconds since epoch</value>
        [DataMember(Name="updated_date", EmitDefaultValue=false)]
        public long? UpdatedDate { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlagReportResource {\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  ContextId: ").Append(ContextId).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Resolution: ").Append(Resolution).Append("\n");
            sb.Append("  Resolved: ").Append(Resolved).Append("\n");
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
            return this.Equals(input as FlagReportResource);
        }

        /// <summary>
        /// Returns true if FlagReportResource instances are equal
        /// </summary>
        /// <param name="input">Instance of FlagReportResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlagReportResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Context == input.Context ||
                    (this.Context != null &&
                    this.Context.Equals(input.Context))
                ) && 
                (
                    this.ContextId == input.ContextId ||
                    (this.ContextId != null &&
                    this.ContextId.Equals(input.ContextId))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.Resolution == input.Resolution ||
                    (this.Resolution != null &&
                    this.Resolution.Equals(input.Resolution))
                ) && 
                (
                    this.Resolved == input.Resolved ||
                    (this.Resolved != null &&
                    this.Resolved.Equals(input.Resolved))
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
                if (this.Context != null)
                    hashCode = hashCode * 59 + this.Context.GetHashCode();
                if (this.ContextId != null)
                    hashCode = hashCode * 59 + this.ContextId.GetHashCode();
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Resolution != null)
                    hashCode = hashCode * 59 + this.Resolution.GetHashCode();
                if (this.Resolved != null)
                    hashCode = hashCode * 59 + this.Resolved.GetHashCode();
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
