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
    /// ActivityOccurrenceResource
    /// </summary>
    [DataContract]
    public partial class ActivityOccurrenceResource :  IEquatable<ActivityOccurrenceResource>, IValidatableObject
    {
        /// <summary>
        /// Indicate if the rewards have been given out already
        /// </summary>
        /// <value>Indicate if the rewards have been given out already</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RewardStatusEnum
        {
            
            /// <summary>
            /// Enum Pending for "pending"
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending,
            
            /// <summary>
            /// Enum Failed for "failed"
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed,
            
            /// <summary>
            /// Enum Complete for "complete"
            /// </summary>
            [EnumMember(Value = "complete")]
            Complete,
            
            /// <summary>
            /// Enum Partial for "partial"
            /// </summary>
            [EnumMember(Value = "partial")]
            Partial
        }

        /// <summary>
        /// The current status of the occurrence (default: OPEN)
        /// </summary>
        /// <value>The current status of the occurrence (default: OPEN)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum SETUP for "SETUP"
            /// </summary>
            [EnumMember(Value = "SETUP")]
            SETUP,
            
            /// <summary>
            /// Enum OPEN for "OPEN"
            /// </summary>
            [EnumMember(Value = "OPEN")]
            OPEN,
            
            /// <summary>
            /// Enum PLAYING for "PLAYING"
            /// </summary>
            [EnumMember(Value = "PLAYING")]
            PLAYING,
            
            /// <summary>
            /// Enum FINISHED for "FINISHED"
            /// </summary>
            [EnumMember(Value = "FINISHED")]
            FINISHED,
            
            /// <summary>
            /// Enum ABANDONED for "ABANDONED"
            /// </summary>
            [EnumMember(Value = "ABANDONED")]
            ABANDONED
        }

        /// <summary>
        /// Indicate if the rewards have been given out already
        /// </summary>
        /// <value>Indicate if the rewards have been given out already</value>
        [DataMember(Name="reward_status", EmitDefaultValue=false)]
        public RewardStatusEnum? RewardStatus { get; set; }
        /// <summary>
        /// The current status of the occurrence (default: OPEN)
        /// </summary>
        /// <value>The current status of the occurrence (default: OPEN)</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityOccurrenceResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActivityOccurrenceResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityOccurrenceResource" /> class.
        /// </summary>
        /// <param name="ActivityId">The id of the activity (required).</param>
        /// <param name="ChallengeActivityId">The id of the challenge activity (as part of the event, required if eventId set).</param>
        /// <param name="Entitlement">The entitlement item required to enter the occurrence. Required if not part of an event. Must come from the set of entitlement items listed in the activity.</param>
        /// <param name="EventId">The id of the event.</param>
        /// <param name="Settings">The list of settings and their options available for this activity. Should be null on create if and only if part of an event.</param>
        /// <param name="Simulated">Whether this occurrence will be played as a simulation..</param>
        /// <param name="Status">The current status of the occurrence (default: OPEN).</param>
        /// <param name="Users">The list of users playing in this occurrence. Can only be set directly with ACTIVITIES_ADMIN permission.</param>
        public ActivityOccurrenceResource(long? ActivityId = null, long? ChallengeActivityId = null, ActivityEntitlementResource Entitlement = null, long? EventId = null, List<SelectedSettingResource> Settings = null, bool? Simulated = null, StatusEnum? Status = null, List<ActivityUserResource> Users = null)
        {
            // to ensure "ActivityId" is required (not null)
            if (ActivityId == null)
            {
                throw new InvalidDataException("ActivityId is a required property for ActivityOccurrenceResource and cannot be null");
            }
            else
            {
                this.ActivityId = ActivityId;
            }
            this.ChallengeActivityId = ChallengeActivityId;
            this.Entitlement = Entitlement;
            this.EventId = EventId;
            this.Settings = Settings;
            this.Simulated = Simulated;
            this.Status = Status;
            this.Users = Users;
        }
        
        /// <summary>
        /// The id of the activity
        /// </summary>
        /// <value>The id of the activity</value>
        [DataMember(Name="activity_id", EmitDefaultValue=false)]
        public long? ActivityId { get; set; }
        /// <summary>
        /// The id of the challenge activity (as part of the event, required if eventId set)
        /// </summary>
        /// <value>The id of the challenge activity (as part of the event, required if eventId set)</value>
        [DataMember(Name="challenge_activity_id", EmitDefaultValue=false)]
        public long? ChallengeActivityId { get; set; }
        /// <summary>
        /// The date this occurrence was created, unix timestamp in seconds
        /// </summary>
        /// <value>The date this occurrence was created, unix timestamp in seconds</value>
        [DataMember(Name="created_date", EmitDefaultValue=false)]
        public long? CreatedDate { get; private set; }
        /// <summary>
        /// The entitlement item required to enter the occurrence. Required if not part of an event. Must come from the set of entitlement items listed in the activity
        /// </summary>
        /// <value>The entitlement item required to enter the occurrence. Required if not part of an event. Must come from the set of entitlement items listed in the activity</value>
        [DataMember(Name="entitlement", EmitDefaultValue=false)]
        public ActivityEntitlementResource Entitlement { get; set; }
        /// <summary>
        /// The id of the event
        /// </summary>
        /// <value>The id of the event</value>
        [DataMember(Name="event_id", EmitDefaultValue=false)]
        public long? EventId { get; set; }
        /// <summary>
        /// The id of the activity occurrence
        /// </summary>
        /// <value>The id of the activity occurrence</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }
        /// <summary>
        /// The list of settings and their options available for this activity. Should be null on create if and only if part of an event
        /// </summary>
        /// <value>The list of settings and their options available for this activity. Should be null on create if and only if part of an event</value>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public List<SelectedSettingResource> Settings { get; set; }
        /// <summary>
        /// Whether this occurrence will be played as a simulation.
        /// </summary>
        /// <value>Whether this occurrence will be played as a simulation.</value>
        [DataMember(Name="simulated", EmitDefaultValue=false)]
        public bool? Simulated { get; set; }
        /// <summary>
        /// The date this occurrence was started, unix timestamp in seconds. null if not yet started
        /// </summary>
        /// <value>The date this occurrence was started, unix timestamp in seconds. null if not yet started</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public long? StartDate { get; private set; }
        /// <summary>
        /// The date this occurrence was last updated, unix timestamp in seconds
        /// </summary>
        /// <value>The date this occurrence was last updated, unix timestamp in seconds</value>
        [DataMember(Name="updated_date", EmitDefaultValue=false)]
        public long? UpdatedDate { get; private set; }
        /// <summary>
        /// The list of users playing in this occurrence. Can only be set directly with ACTIVITIES_ADMIN permission
        /// </summary>
        /// <value>The list of users playing in this occurrence. Can only be set directly with ACTIVITIES_ADMIN permission</value>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<ActivityUserResource> Users { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActivityOccurrenceResource {\n");
            sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
            sb.Append("  ChallengeActivityId: ").Append(ChallengeActivityId).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Entitlement: ").Append(Entitlement).Append("\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RewardStatus: ").Append(RewardStatus).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  Simulated: ").Append(Simulated).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
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
            return this.Equals(obj as ActivityOccurrenceResource);
        }

        /// <summary>
        /// Returns true if ActivityOccurrenceResource instances are equal
        /// </summary>
        /// <param name="other">Instance of ActivityOccurrenceResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivityOccurrenceResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ActivityId == other.ActivityId ||
                    this.ActivityId != null &&
                    this.ActivityId.Equals(other.ActivityId)
                ) && 
                (
                    this.ChallengeActivityId == other.ChallengeActivityId ||
                    this.ChallengeActivityId != null &&
                    this.ChallengeActivityId.Equals(other.ChallengeActivityId)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.Entitlement == other.Entitlement ||
                    this.Entitlement != null &&
                    this.Entitlement.Equals(other.Entitlement)
                ) && 
                (
                    this.EventId == other.EventId ||
                    this.EventId != null &&
                    this.EventId.Equals(other.EventId)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.RewardStatus == other.RewardStatus ||
                    this.RewardStatus != null &&
                    this.RewardStatus.Equals(other.RewardStatus)
                ) && 
                (
                    this.Settings == other.Settings ||
                    this.Settings != null &&
                    this.Settings.SequenceEqual(other.Settings)
                ) && 
                (
                    this.Simulated == other.Simulated ||
                    this.Simulated != null &&
                    this.Simulated.Equals(other.Simulated)
                ) && 
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
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
                if (this.ActivityId != null)
                    hash = hash * 59 + this.ActivityId.GetHashCode();
                if (this.ChallengeActivityId != null)
                    hash = hash * 59 + this.ChallengeActivityId.GetHashCode();
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                if (this.Entitlement != null)
                    hash = hash * 59 + this.Entitlement.GetHashCode();
                if (this.EventId != null)
                    hash = hash * 59 + this.EventId.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.RewardStatus != null)
                    hash = hash * 59 + this.RewardStatus.GetHashCode();
                if (this.Settings != null)
                    hash = hash * 59 + this.Settings.GetHashCode();
                if (this.Simulated != null)
                    hash = hash * 59 + this.Simulated.GetHashCode();
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.UpdatedDate != null)
                    hash = hash * 59 + this.UpdatedDate.GetHashCode();
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
