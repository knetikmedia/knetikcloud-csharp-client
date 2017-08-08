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
    /// ActivityOccurrenceResultsResource
    /// </summary>
    [DataContract]
    public partial class ActivityOccurrenceResultsResource :  IEquatable<ActivityOccurrenceResultsResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityOccurrenceResultsResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActivityOccurrenceResultsResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityOccurrenceResultsResource" /> class.
        /// </summary>
        /// <param name="Users">The game results for each user. Include all users that played (paid to get in) even if they were eliminated without a result. A null metric is allowed (required).</param>
        public ActivityOccurrenceResultsResource(List<UserActivityResultsResource> Users = default(List<UserActivityResultsResource>))
        {
            // to ensure "Users" is required (not null)
            if (Users == null)
            {
                throw new InvalidDataException("Users is a required property for ActivityOccurrenceResultsResource and cannot be null");
            }
            else
            {
                this.Users = Users;
            }
        }
        
        /// <summary>
        /// The game results for each user. Include all users that played (paid to get in) even if they were eliminated without a result. A null metric is allowed
        /// </summary>
        /// <value>The game results for each user. Include all users that played (paid to get in) even if they were eliminated without a result. A null metric is allowed</value>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<UserActivityResultsResource> Users { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActivityOccurrenceResultsResource {\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
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
            return this.Equals(input as ActivityOccurrenceResultsResource);
        }

        /// <summary>
        /// Returns true if ActivityOccurrenceResultsResource instances are equal
        /// </summary>
        /// <param name="input">Instance of ActivityOccurrenceResultsResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivityOccurrenceResultsResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Users == input.Users ||
                    (this.Users != null &&
                    this.Users.SequenceEqual(input.Users))
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
                if (this.Users != null)
                    hashCode = hashCode * 59 + this.Users.GetHashCode();
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
