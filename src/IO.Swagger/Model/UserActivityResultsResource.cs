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
    /// UserActivityResultsResource
    /// </summary>
    [DataContract]
    public partial class UserActivityResultsResource :  IEquatable<UserActivityResultsResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserActivityResultsResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserActivityResultsResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserActivityResultsResource" /> class.
        /// </summary>
        /// <param name="CurrencyRewards">Any currency rewarded to this user.</param>
        /// <param name="ItemRewards">Any items rewarded to this user.</param>
        /// <param name="Rank">The position of the user in the leaderboard. Null means non-compete or disqualification.</param>
        /// <param name="Score">The raw score in this leaderboard. Null means non-compete or disqualification.</param>
        /// <param name="Tags">Any tags for the metric. Each unique tag will translate into a unique leaderboard. Maximum 5 tags and 50 characters each.</param>
        /// <param name="User">The player for this entry (required).</param>
        public UserActivityResultsResource(List<RewardCurrencyResource> CurrencyRewards = null, List<RewardItemResource> ItemRewards = null, long? Rank = null, long? Score = null, List<string> Tags = null, SimpleUserResource User = null)
        {
            // to ensure "User" is required (not null)
            if (User == null)
            {
                throw new InvalidDataException("User is a required property for UserActivityResultsResource and cannot be null");
            }
            else
            {
                this.User = User;
            }
            this.CurrencyRewards = CurrencyRewards;
            this.ItemRewards = ItemRewards;
            this.Rank = Rank;
            this.Score = Score;
            this.Tags = Tags;
        }
        
        /// <summary>
        /// Any currency rewarded to this user
        /// </summary>
        /// <value>Any currency rewarded to this user</value>
        [DataMember(Name="currency_rewards", EmitDefaultValue=false)]
        public List<RewardCurrencyResource> CurrencyRewards { get; set; }
        /// <summary>
        /// Any items rewarded to this user
        /// </summary>
        /// <value>Any items rewarded to this user</value>
        [DataMember(Name="item_rewards", EmitDefaultValue=false)]
        public List<RewardItemResource> ItemRewards { get; set; }
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
        /// Any tags for the metric. Each unique tag will translate into a unique leaderboard. Maximum 5 tags and 50 characters each
        /// </summary>
        /// <value>Any tags for the metric. Each unique tag will translate into a unique leaderboard. Maximum 5 tags and 50 characters each</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }
        /// <summary>
        /// The number of users tied at this rank, including this user. 1 means no tie
        /// </summary>
        /// <value>The number of users tied at this rank, including this user. 1 means no tie</value>
        [DataMember(Name="ties", EmitDefaultValue=false)]
        public int? Ties { get; private set; }
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
            sb.Append("class UserActivityResultsResource {\n");
            sb.Append("  CurrencyRewards: ").Append(CurrencyRewards).Append("\n");
            sb.Append("  ItemRewards: ").Append(ItemRewards).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Ties: ").Append(Ties).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as UserActivityResultsResource);
        }

        /// <summary>
        /// Returns true if UserActivityResultsResource instances are equal
        /// </summary>
        /// <param name="other">Instance of UserActivityResultsResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserActivityResultsResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CurrencyRewards == other.CurrencyRewards ||
                    this.CurrencyRewards != null &&
                    this.CurrencyRewards.SequenceEqual(other.CurrencyRewards)
                ) && 
                (
                    this.ItemRewards == other.ItemRewards ||
                    this.ItemRewards != null &&
                    this.ItemRewards.SequenceEqual(other.ItemRewards)
                ) && 
                (
                    this.Rank == other.Rank ||
                    this.Rank != null &&
                    this.Rank.Equals(other.Rank)
                ) && 
                (
                    this.Score == other.Score ||
                    this.Score != null &&
                    this.Score.Equals(other.Score)
                ) && 
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(other.Tags)
                ) && 
                (
                    this.Ties == other.Ties ||
                    this.Ties != null &&
                    this.Ties.Equals(other.Ties)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
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
                if (this.CurrencyRewards != null)
                    hash = hash * 59 + this.CurrencyRewards.GetHashCode();
                if (this.ItemRewards != null)
                    hash = hash * 59 + this.ItemRewards.GetHashCode();
                if (this.Rank != null)
                    hash = hash * 59 + this.Rank.GetHashCode();
                if (this.Score != null)
                    hash = hash * 59 + this.Score.GetHashCode();
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
                if (this.Ties != null)
                    hash = hash * 59 + this.Ties.GetHashCode();
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}