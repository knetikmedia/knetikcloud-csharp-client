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

namespace com.knetikcloud.Model
{
    /// <summary>
    /// BreRuleLog
    /// </summary>
    [DataContract]
    public partial class BreRuleLog :  IEquatable<BreRuleLog>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BreRuleLog" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public BreRuleLog()
        {
        }
        
        /// <summary>
        /// Whether the rule ran
        /// </summary>
        /// <value>Whether the rule ran</value>
        [DataMember(Name="ran", EmitDefaultValue=false)]
        public bool? Ran { get; private set; }
        /// <summary>
        /// The reason for the rule
        /// </summary>
        /// <value>The reason for the rule</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; private set; }
        /// <summary>
        /// The end date of the rule in seconds
        /// </summary>
        /// <value>The end date of the rule in seconds</value>
        [DataMember(Name="rule_end_date", EmitDefaultValue=false)]
        public long? RuleEndDate { get; private set; }
        /// <summary>
        /// The id of the rule
        /// </summary>
        /// <value>The id of the rule</value>
        [DataMember(Name="rule_id", EmitDefaultValue=false)]
        public string RuleId { get; private set; }
        /// <summary>
        /// The name of the rule
        /// </summary>
        /// <value>The name of the rule</value>
        [DataMember(Name="rule_name", EmitDefaultValue=false)]
        public string RuleName { get; private set; }
        /// <summary>
        /// The start date of the rule in seconds
        /// </summary>
        /// <value>The start date of the rule in seconds</value>
        [DataMember(Name="rule_start_date", EmitDefaultValue=false)]
        public long? RuleStartDate { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BreRuleLog {\n");
            sb.Append("  Ran: ").Append(Ran).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  RuleEndDate: ").Append(RuleEndDate).Append("\n");
            sb.Append("  RuleId: ").Append(RuleId).Append("\n");
            sb.Append("  RuleName: ").Append(RuleName).Append("\n");
            sb.Append("  RuleStartDate: ").Append(RuleStartDate).Append("\n");
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
            return this.Equals(obj as BreRuleLog);
        }

        /// <summary>
        /// Returns true if BreRuleLog instances are equal
        /// </summary>
        /// <param name="other">Instance of BreRuleLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BreRuleLog other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Ran == other.Ran ||
                    this.Ran != null &&
                    this.Ran.Equals(other.Ran)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) && 
                (
                    this.RuleEndDate == other.RuleEndDate ||
                    this.RuleEndDate != null &&
                    this.RuleEndDate.Equals(other.RuleEndDate)
                ) && 
                (
                    this.RuleId == other.RuleId ||
                    this.RuleId != null &&
                    this.RuleId.Equals(other.RuleId)
                ) && 
                (
                    this.RuleName == other.RuleName ||
                    this.RuleName != null &&
                    this.RuleName.Equals(other.RuleName)
                ) && 
                (
                    this.RuleStartDate == other.RuleStartDate ||
                    this.RuleStartDate != null &&
                    this.RuleStartDate.Equals(other.RuleStartDate)
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
                if (this.Ran != null)
                    hash = hash * 59 + this.Ran.GetHashCode();
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                if (this.RuleEndDate != null)
                    hash = hash * 59 + this.RuleEndDate.GetHashCode();
                if (this.RuleId != null)
                    hash = hash * 59 + this.RuleId.GetHashCode();
                if (this.RuleName != null)
                    hash = hash * 59 + this.RuleName.GetHashCode();
                if (this.RuleStartDate != null)
                    hash = hash * 59 + this.RuleStartDate.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
