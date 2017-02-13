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
    /// ChallengeResource
    /// </summary>
    [DataContract]
    public partial class ChallengeResource :  IEquatable<ChallengeResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChallengeResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChallengeResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChallengeResource" /> class.
        /// </summary>
        /// <param name="AdditionalProperties">A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type.</param>
        /// <param name="CampaignId">The id of the campaign this challenge is a part of. The challenge must be tied to an active campaign before it will spawn events.</param>
        /// <param name="CopyOf">The ID of the original challenge it was copied from.</param>
        /// <param name="EndDate">The end date of this challenge in seconds since epoch. required if part of a campaign.</param>
        /// <param name="LeaderboardStrategy">The strategy for calculating the leaderboard. Defaults to highest score. Value MUST come from the list of available strategies from the Leaderboard Service..</param>
        /// <param name="LongDescription">The user friendly name of that resource. Defaults to blank string.</param>
        /// <param name="Name">The user friendly name of that resource (required).</param>
        /// <param name="RewardLagMinutes">The number of minutes minimum to wait at the end of this challenge before running rewards, to allow activities to complete.</param>
        /// <param name="RewardSet">The rewards to give at the end of the challenge. When creating/updating only id is used. Reward set must be pre-existing.</param>
        /// <param name="Schedule">The repeat schedule for the challenge.</param>
        /// <param name="ShortDescription">The user friendly name of that resource. Defaults to blank string.</param>
        /// <param name="StartDate">The start date of this challenge in seconds since epoch. required if part of a campaign.</param>
        /// <param name="Template">A challenge template this challenge is validated against (private). May be null and no validation of additional_properties will be done.</param>
        public ChallengeResource(Dictionary<string, Property> AdditionalProperties = default(Dictionary<string, Property>), long? CampaignId = default(long?), long? CopyOf = default(long?), long? EndDate = default(long?), string LeaderboardStrategy = default(string), string LongDescription = default(string), string Name = default(string), int? RewardLagMinutes = default(int?), RewardSetResource RewardSet = default(RewardSetResource), Schedule Schedule = default(Schedule), string ShortDescription = default(string), long? StartDate = default(long?), string Template = default(string))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for ChallengeResource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.AdditionalProperties = AdditionalProperties;
            this.CampaignId = CampaignId;
            this.CopyOf = CopyOf;
            this.EndDate = EndDate;
            this.LeaderboardStrategy = LeaderboardStrategy;
            this.LongDescription = LongDescription;
            this.RewardLagMinutes = RewardLagMinutes;
            this.RewardSet = RewardSet;
            this.Schedule = Schedule;
            this.ShortDescription = ShortDescription;
            this.StartDate = StartDate;
            this.Template = Template;
        }
        
        /// <summary>
        /// The number of activities allowed to this challenge
        /// </summary>
        /// <value>The number of activities allowed to this challenge</value>
        [DataMember(Name="activities", EmitDefaultValue=false)]
        public int? Activities { get; private set; }
        /// <summary>
        /// A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type
        /// </summary>
        /// <value>A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type</value>
        [DataMember(Name="additional_properties", EmitDefaultValue=false)]
        public Dictionary<string, Property> AdditionalProperties { get; set; }
        /// <summary>
        /// The id of the campaign this challenge is a part of. The challenge must be tied to an active campaign before it will spawn events
        /// </summary>
        /// <value>The id of the campaign this challenge is a part of. The challenge must be tied to an active campaign before it will spawn events</value>
        [DataMember(Name="campaign_id", EmitDefaultValue=false)]
        public long? CampaignId { get; set; }
        /// <summary>
        /// The ID of the original challenge it was copied from
        /// </summary>
        /// <value>The ID of the original challenge it was copied from</value>
        [DataMember(Name="copy_of", EmitDefaultValue=false)]
        public long? CopyOf { get; set; }
        /// <summary>
        /// The date/time this resource was created in seconds since unix epoch
        /// </summary>
        /// <value>The date/time this resource was created in seconds since unix epoch</value>
        [DataMember(Name="created_date", EmitDefaultValue=false)]
        public long? CreatedDate { get; private set; }
        /// <summary>
        /// The end date of this challenge in seconds since epoch. required if part of a campaign
        /// </summary>
        /// <value>The end date of this challenge in seconds since epoch. required if part of a campaign</value>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        public long? EndDate { get; set; }
        /// <summary>
        /// The unique ID for that resource
        /// </summary>
        /// <value>The unique ID for that resource</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }
        /// <summary>
        /// The strategy for calculating the leaderboard. Defaults to highest score. Value MUST come from the list of available strategies from the Leaderboard Service.
        /// </summary>
        /// <value>The strategy for calculating the leaderboard. Defaults to highest score. Value MUST come from the list of available strategies from the Leaderboard Service.</value>
        [DataMember(Name="leaderboard_strategy", EmitDefaultValue=false)]
        public string LeaderboardStrategy { get; set; }
        /// <summary>
        /// The user friendly name of that resource. Defaults to blank string
        /// </summary>
        /// <value>The user friendly name of that resource. Defaults to blank string</value>
        [DataMember(Name="long_description", EmitDefaultValue=false)]
        public string LongDescription { get; set; }
        /// <summary>
        /// The user friendly name of that resource
        /// </summary>
        /// <value>The user friendly name of that resource</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The next date this challenge will be occur in seconds since epoch
        /// </summary>
        /// <value>The next date this challenge will be occur in seconds since epoch</value>
        [DataMember(Name="next_event_date", EmitDefaultValue=false)]
        public long? NextEventDate { get; private set; }
        /// <summary>
        /// The number of minutes minimum to wait at the end of this challenge before running rewards, to allow activities to complete
        /// </summary>
        /// <value>The number of minutes minimum to wait at the end of this challenge before running rewards, to allow activities to complete</value>
        [DataMember(Name="reward_lag_minutes", EmitDefaultValue=false)]
        public int? RewardLagMinutes { get; set; }
        /// <summary>
        /// The rewards to give at the end of the challenge. When creating/updating only id is used. Reward set must be pre-existing
        /// </summary>
        /// <value>The rewards to give at the end of the challenge. When creating/updating only id is used. Reward set must be pre-existing</value>
        [DataMember(Name="reward_set", EmitDefaultValue=false)]
        public RewardSetResource RewardSet { get; set; }
        /// <summary>
        /// The repeat schedule for the challenge
        /// </summary>
        /// <value>The repeat schedule for the challenge</value>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public Schedule Schedule { get; set; }
        /// <summary>
        /// The user friendly name of that resource. Defaults to blank string
        /// </summary>
        /// <value>The user friendly name of that resource. Defaults to blank string</value>
        [DataMember(Name="short_description", EmitDefaultValue=false)]
        public string ShortDescription { get; set; }
        /// <summary>
        /// The start date of this challenge in seconds since epoch. required if part of a campaign
        /// </summary>
        /// <value>The start date of this challenge in seconds since epoch. required if part of a campaign</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public long? StartDate { get; set; }
        /// <summary>
        /// A challenge template this challenge is validated against (private). May be null and no validation of additional_properties will be done
        /// </summary>
        /// <value>A challenge template this challenge is validated against (private). May be null and no validation of additional_properties will be done</value>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public string Template { get; set; }
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
            sb.Append("class ChallengeResource {\n");
            sb.Append("  Activities: ").Append(Activities).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  CopyOf: ").Append(CopyOf).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LeaderboardStrategy: ").Append(LeaderboardStrategy).Append("\n");
            sb.Append("  LongDescription: ").Append(LongDescription).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NextEventDate: ").Append(NextEventDate).Append("\n");
            sb.Append("  RewardLagMinutes: ").Append(RewardLagMinutes).Append("\n");
            sb.Append("  RewardSet: ").Append(RewardSet).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
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
            return this.Equals(obj as ChallengeResource);
        }

        /// <summary>
        /// Returns true if ChallengeResource instances are equal
        /// </summary>
        /// <param name="other">Instance of ChallengeResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChallengeResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Activities == other.Activities ||
                    this.Activities != null &&
                    this.Activities.Equals(other.Activities)
                ) && 
                (
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
                ) && 
                (
                    this.CampaignId == other.CampaignId ||
                    this.CampaignId != null &&
                    this.CampaignId.Equals(other.CampaignId)
                ) && 
                (
                    this.CopyOf == other.CopyOf ||
                    this.CopyOf != null &&
                    this.CopyOf.Equals(other.CopyOf)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.LeaderboardStrategy == other.LeaderboardStrategy ||
                    this.LeaderboardStrategy != null &&
                    this.LeaderboardStrategy.Equals(other.LeaderboardStrategy)
                ) && 
                (
                    this.LongDescription == other.LongDescription ||
                    this.LongDescription != null &&
                    this.LongDescription.Equals(other.LongDescription)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.NextEventDate == other.NextEventDate ||
                    this.NextEventDate != null &&
                    this.NextEventDate.Equals(other.NextEventDate)
                ) && 
                (
                    this.RewardLagMinutes == other.RewardLagMinutes ||
                    this.RewardLagMinutes != null &&
                    this.RewardLagMinutes.Equals(other.RewardLagMinutes)
                ) && 
                (
                    this.RewardSet == other.RewardSet ||
                    this.RewardSet != null &&
                    this.RewardSet.Equals(other.RewardSet)
                ) && 
                (
                    this.Schedule == other.Schedule ||
                    this.Schedule != null &&
                    this.Schedule.Equals(other.Schedule)
                ) && 
                (
                    this.ShortDescription == other.ShortDescription ||
                    this.ShortDescription != null &&
                    this.ShortDescription.Equals(other.ShortDescription)
                ) && 
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
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
                if (this.Activities != null)
                    hash = hash * 59 + this.Activities.GetHashCode();
                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();
                if (this.CampaignId != null)
                    hash = hash * 59 + this.CampaignId.GetHashCode();
                if (this.CopyOf != null)
                    hash = hash * 59 + this.CopyOf.GetHashCode();
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.LeaderboardStrategy != null)
                    hash = hash * 59 + this.LeaderboardStrategy.GetHashCode();
                if (this.LongDescription != null)
                    hash = hash * 59 + this.LongDescription.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.NextEventDate != null)
                    hash = hash * 59 + this.NextEventDate.GetHashCode();
                if (this.RewardLagMinutes != null)
                    hash = hash * 59 + this.RewardLagMinutes.GetHashCode();
                if (this.RewardSet != null)
                    hash = hash * 59 + this.RewardSet.GetHashCode();
                if (this.Schedule != null)
                    hash = hash * 59 + this.Schedule.GetHashCode();
                if (this.ShortDescription != null)
                    hash = hash * 59 + this.ShortDescription.GetHashCode();
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                if (this.Template != null)
                    hash = hash * 59 + this.Template.GetHashCode();
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
