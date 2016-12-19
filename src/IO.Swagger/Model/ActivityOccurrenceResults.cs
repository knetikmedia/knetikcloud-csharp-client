/* 
 * Knetik Platform API Documentation Latest
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
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
    /// ActivityOccurrenceResults
    /// </summary>
    [DataContract]
    public partial class ActivityOccurrenceResults :  IEquatable<ActivityOccurrenceResults>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityOccurrenceResults" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActivityOccurrenceResults() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityOccurrenceResults" /> class.
        /// </summary>
        /// <param name="Users">The game results for each user. Include all users that played (paid to get in) even if they were eliminated without a result. A null metric is allowed (required).</param>
        public ActivityOccurrenceResults(List<UserActivityResultsResource> Users = null)
        {
            // to ensure "Users" is required (not null)
            if (Users == null)
            {
                throw new InvalidDataException("Users is a required property for ActivityOccurrenceResults and cannot be null");
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
            sb.Append("class ActivityOccurrenceResults {\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ActivityOccurrenceResults);
        }

        /// <summary>
        /// Returns true if ActivityOccurrenceResults instances are equal
        /// </summary>
        /// <param name="other">Instance of ActivityOccurrenceResults to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivityOccurrenceResults other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Users == other.Users ||
                    this.Users != null &&
                    this.Users.SequenceEqual(other.Users)
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
                if (this.Users != null)
                    hash = hash * 59 + this.Users.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
