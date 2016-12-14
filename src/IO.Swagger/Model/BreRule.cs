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
    /// BreRule
    /// </summary>
    [DataContract]
    public partial class BreRule :  IEquatable<BreRule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BreRule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BreRule() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BreRule" /> class.
        /// </summary>
        /// <param name="Actions">A list of actions to execute, and the mapping for their parameters, when the rule runs. Minimum 1 (required).</param>
        /// <param name="Condition">A condition expression that must be met in a given event for the rule to run. Empty to always run.</param>
        /// <param name="Description">The human readable description of the rule.</param>
        /// <param name="Enabled">Whether the rule is enabled to run (in conjunction with dates). Default true.</param>
        /// <param name="EndDate">The date the rule ceases to take effect, or null if never. Unix timestamp in seconds.</param>
        /// <param name="EventName">The event name of the trigger this rule runs for. Affects which parameters are available (required).</param>
        /// <param name="Id">The id of the rule for later references. If left null a random guid will be generated. Must be unique. Cannot be changed.</param>
        /// <param name="Name">The human readable name of the rule (required).</param>
        /// <param name="Sort">Used to sort rules to control the order they run in. Larger numbered sort values run first.  Default 500.</param>
        /// <param name="StartDate">The date the rule begins to take effect, or null if always. Unix timestamp in seconds.</param>
        public BreRule(ActionResource Actions = null, PredicateOperation Condition = null, string Description = null, bool? Enabled = null, long? EndDate = null, string EventName = null, string Id = null, string Name = null, int? Sort = null, long? StartDate = null)
        {
            // to ensure "Actions" is required (not null)
            if (Actions == null)
            {
                throw new InvalidDataException("Actions is a required property for BreRule and cannot be null");
            }
            else
            {
                this.Actions = Actions;
            }
            // to ensure "EventName" is required (not null)
            if (EventName == null)
            {
                throw new InvalidDataException("EventName is a required property for BreRule and cannot be null");
            }
            else
            {
                this.EventName = EventName;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for BreRule and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.Condition = Condition;
            this.Description = Description;
            this.Enabled = Enabled;
            this.EndDate = EndDate;
            this.Id = Id;
            this.Sort = Sort;
            this.StartDate = StartDate;
        }
        
        /// <summary>
        /// A list of actions to execute, and the mapping for their parameters, when the rule runs. Minimum 1
        /// </summary>
        /// <value>A list of actions to execute, and the mapping for their parameters, when the rule runs. Minimum 1</value>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public ActionResource Actions { get; set; }
        /// <summary>
        /// A condition expression that must be met in a given event for the rule to run. Empty to always run
        /// </summary>
        /// <value>A condition expression that must be met in a given event for the rule to run. Empty to always run</value>
        [DataMember(Name="condition", EmitDefaultValue=false)]
        public PredicateOperation Condition { get; set; }
        /// <summary>
        /// The condition as a readable string. Filled in by the system from the condition
        /// </summary>
        /// <value>The condition as a readable string. Filled in by the system from the condition</value>
        [DataMember(Name="condition_text", EmitDefaultValue=false)]
        public string ConditionText { get; private set; }
        /// <summary>
        /// The human readable description of the rule
        /// </summary>
        /// <value>The human readable description of the rule</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Whether the rule is enabled to run (in conjunction with dates). Default true
        /// </summary>
        /// <value>Whether the rule is enabled to run (in conjunction with dates). Default true</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
        /// <summary>
        /// The date the rule ceases to take effect, or null if never. Unix timestamp in seconds
        /// </summary>
        /// <value>The date the rule ceases to take effect, or null if never. Unix timestamp in seconds</value>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        public long? EndDate { get; set; }
        /// <summary>
        /// The event name of the trigger this rule runs for. Affects which parameters are available
        /// </summary>
        /// <value>The event name of the trigger this rule runs for. Affects which parameters are available</value>
        [DataMember(Name="event_name", EmitDefaultValue=false)]
        public string EventName { get; set; }
        /// <summary>
        /// The id of the rule for later references. If left null a random guid will be generated. Must be unique. Cannot be changed
        /// </summary>
        /// <value>The id of the rule for later references. If left null a random guid will be generated. Must be unique. Cannot be changed</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// The human readable name of the rule
        /// </summary>
        /// <value>The human readable name of the rule</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Used to sort rules to control the order they run in. Larger numbered sort values run first.  Default 500
        /// </summary>
        /// <value>Used to sort rules to control the order they run in. Larger numbered sort values run first.  Default 500</value>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public int? Sort { get; set; }
        /// <summary>
        /// The date the rule begins to take effect, or null if always. Unix timestamp in seconds
        /// </summary>
        /// <value>The date the rule begins to take effect, or null if always. Unix timestamp in seconds</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public long? StartDate { get; set; }
        /// <summary>
        /// Whether the rule is a default part of the system. System rules cannot be edited or deleted, but may be disabled
        /// </summary>
        /// <value>Whether the rule is a default part of the system. System rules cannot be edited or deleted, but may be disabled</value>
        [DataMember(Name="system_rule", EmitDefaultValue=false)]
        public bool? SystemRule { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BreRule {\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  Condition: ").Append(Condition).Append("\n");
            sb.Append("  ConditionText: ").Append(ConditionText).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  SystemRule: ").Append(SystemRule).Append("\n");
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
            return this.Equals(obj as BreRule);
        }

        /// <summary>
        /// Returns true if BreRule instances are equal
        /// </summary>
        /// <param name="other">Instance of BreRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BreRule other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Actions == other.Actions ||
                    this.Actions != null &&
                    this.Actions.Equals(other.Actions)
                ) && 
                (
                    this.Condition == other.Condition ||
                    this.Condition != null &&
                    this.Condition.Equals(other.Condition)
                ) && 
                (
                    this.ConditionText == other.ConditionText ||
                    this.ConditionText != null &&
                    this.ConditionText.Equals(other.ConditionText)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) && 
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) && 
                (
                    this.EventName == other.EventName ||
                    this.EventName != null &&
                    this.EventName.Equals(other.EventName)
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
                    this.Sort == other.Sort ||
                    this.Sort != null &&
                    this.Sort.Equals(other.Sort)
                ) && 
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) && 
                (
                    this.SystemRule == other.SystemRule ||
                    this.SystemRule != null &&
                    this.SystemRule.Equals(other.SystemRule)
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
                if (this.Actions != null)
                    hash = hash * 59 + this.Actions.GetHashCode();
                if (this.Condition != null)
                    hash = hash * 59 + this.Condition.GetHashCode();
                if (this.ConditionText != null)
                    hash = hash * 59 + this.ConditionText.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();
                if (this.EventName != null)
                    hash = hash * 59 + this.EventName.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Sort != null)
                    hash = hash * 59 + this.Sort.GetHashCode();
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                if (this.SystemRule != null)
                    hash = hash * 59 + this.SystemRule.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
