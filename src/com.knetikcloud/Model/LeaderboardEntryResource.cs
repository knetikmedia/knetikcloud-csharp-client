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
    /// LeaderboardEntryResource
    /// </summary>
    [DataContract]
    public partial class LeaderboardEntryResource :  IEquatable<LeaderboardEntryResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LeaderboardEntryResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LeaderboardEntryResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LeaderboardEntryResource" /> class.
        /// </summary>
        /// <param name="Rank">The position of the user in the leaderboard. Null means non-compete or disqualification.</param>
        /// <param name="Score">The raw score in this leaderboard. Null means non-compete or disqualification.</param>
        /// <param name="UpdatedDate">The date this score was recorded or updated. Unix timestamp in seconds.</param>
        /// <param name="User">The player for this entry (required).</param>
        public LeaderboardEntryResource(long? Rank = default(long?), long? Score = default(long?), long? UpdatedDate = default(long?), SimpleUserResource User = default(SimpleUserResource))
        {
            // to ensure "User" is required (not null)
            if (User == null)
            {
                throw new InvalidDataException("User is a required property for LeaderboardEntryResource and cannot be null");
            }
            else
            {
                this.User = User;
            }
            this.Rank = Rank;
            this.Score = Score;
            this.UpdatedDate = UpdatedDate;
        }
        
        /// <summary>
        /// The position of the user in the leaderboard. Null means non-compete or disqualification
        /// </summary>
        /// <value>The position of the user in the leaderboard. Null means non-compete or disqualification</value>
        [DataMember(Name="rank", EmitDefaultValue=false)]
        public long? Rank { get; set; }

        /// <summary>
        /// The raw score in this leaderboard. Null means non-compete or disqualification
        /// </summary>
        /// <value>The raw score in this leaderboard. Null means non-compete or disqualification</value>
        [DataMember(Name="score", EmitDefaultValue=false)]
        public long? Score { get; set; }

        /// <summary>
        /// The date this score was recorded or updated. Unix timestamp in seconds
        /// </summary>
        /// <value>The date this score was recorded or updated. Unix timestamp in seconds</value>
        [DataMember(Name="updated_date", EmitDefaultValue=false)]
        public long? UpdatedDate { get; set; }

        /// <summary>
        /// The player for this entry
        /// </summary>
        /// <value>The player for this entry</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public SimpleUserResource User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LeaderboardEntryResource {\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(input as LeaderboardEntryResource);
        }

        /// <summary>
        /// Returns true if LeaderboardEntryResource instances are equal
        /// </summary>
        /// <param name="input">Instance of LeaderboardEntryResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LeaderboardEntryResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Rank == input.Rank ||
                    (this.Rank != null &&
                    this.Rank.Equals(input.Rank))
                ) && 
                (
                    this.Score == input.Score ||
                    (this.Score != null &&
                    this.Score.Equals(input.Score))
                ) && 
                (
                    this.UpdatedDate == input.UpdatedDate ||
                    (this.UpdatedDate != null &&
                    this.UpdatedDate.Equals(input.UpdatedDate))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
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
                if (this.Rank != null)
                    hashCode = hashCode * 59 + this.Rank.GetHashCode();
                if (this.Score != null)
                    hashCode = hashCode * 59 + this.Score.GetHashCode();
                if (this.UpdatedDate != null)
                    hashCode = hashCode * 59 + this.UpdatedDate.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
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
