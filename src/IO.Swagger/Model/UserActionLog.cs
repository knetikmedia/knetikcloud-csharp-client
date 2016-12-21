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
    /// UserActionLog
    /// </summary>
    [DataContract]
    public partial class UserActionLog :  IEquatable<UserActionLog>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserActionLog" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserActionLog() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserActionLog" /> class.
        /// </summary>
        /// <param name="ActionDescription">A description of the action taken (required).</param>
        /// <param name="ActionName">The name of the action taken (required).</param>
        /// <param name="Details">A map of additional details such as the target of the action.</param>
        /// <param name="UserId">The id of the user that took the action, if any. Read-only if not posting with LOGS_ADMIN.</param>
        public UserActionLog(string ActionDescription = null, string ActionName = null, Dictionary<string, string> Details = null, int? UserId = null)
        {
            // to ensure "ActionDescription" is required (not null)
            if (ActionDescription == null)
            {
                throw new InvalidDataException("ActionDescription is a required property for UserActionLog and cannot be null");
            }
            else
            {
                this.ActionDescription = ActionDescription;
            }
            // to ensure "ActionName" is required (not null)
            if (ActionName == null)
            {
                throw new InvalidDataException("ActionName is a required property for UserActionLog and cannot be null");
            }
            else
            {
                this.ActionName = ActionName;
            }
            this.Details = Details;
            this.UserId = UserId;
        }
        
        /// <summary>
        /// A description of the action taken
        /// </summary>
        /// <value>A description of the action taken</value>
        [DataMember(Name="action_description", EmitDefaultValue=false)]
        public string ActionDescription { get; set; }
        /// <summary>
        /// The name of the action taken
        /// </summary>
        /// <value>The name of the action taken</value>
        [DataMember(Name="action_name", EmitDefaultValue=false)]
        public string ActionName { get; set; }
        /// <summary>
        /// The date of the action, unix timestamp in seconds
        /// </summary>
        /// <value>The date of the action, unix timestamp in seconds</value>
        [DataMember(Name="created_date", EmitDefaultValue=false)]
        public long? CreatedDate { get; private set; }
        /// <summary>
        /// A map of additional details such as the target of the action
        /// </summary>
        /// <value>A map of additional details such as the target of the action</value>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public Dictionary<string, string> Details { get; set; }
        /// <summary>
        /// The id of the log entry
        /// </summary>
        /// <value>The id of the log entry</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        /// <summary>
        /// The id of the api request that spawned the action, if generated internally
        /// </summary>
        /// <value>The id of the api request that spawned the action, if generated internally</value>
        [DataMember(Name="request_id", EmitDefaultValue=false)]
        public string RequestId { get; private set; }
        /// <summary>
        /// The id of the user that took the action, if any. Read-only if not posting with LOGS_ADMIN
        /// </summary>
        /// <value>The id of the user that took the action, if any. Read-only if not posting with LOGS_ADMIN</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public int? UserId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserActionLog {\n");
            sb.Append("  ActionDescription: ").Append(ActionDescription).Append("\n");
            sb.Append("  ActionName: ").Append(ActionName).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(obj as UserActionLog);
        }

        /// <summary>
        /// Returns true if UserActionLog instances are equal
        /// </summary>
        /// <param name="other">Instance of UserActionLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserActionLog other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ActionDescription == other.ActionDescription ||
                    this.ActionDescription != null &&
                    this.ActionDescription.Equals(other.ActionDescription)
                ) && 
                (
                    this.ActionName == other.ActionName ||
                    this.ActionName != null &&
                    this.ActionName.Equals(other.ActionName)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.Details == other.Details ||
                    this.Details != null &&
                    this.Details.SequenceEqual(other.Details)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.RequestId == other.RequestId ||
                    this.RequestId != null &&
                    this.RequestId.Equals(other.RequestId)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
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
                if (this.ActionDescription != null)
                    hash = hash * 59 + this.ActionDescription.GetHashCode();
                if (this.ActionName != null)
                    hash = hash * 59 + this.ActionName.GetHashCode();
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                if (this.Details != null)
                    hash = hash * 59 + this.Details.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.RequestId != null)
                    hash = hash * 59 + this.RequestId.GetHashCode();
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
