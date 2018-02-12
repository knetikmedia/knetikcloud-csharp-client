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
    /// TopicSubscriber
    /// </summary>
    [DataContract]
    public partial class TopicSubscriber :  IEquatable<TopicSubscriber>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TopicSubscriber" /> class.
        /// </summary>
        /// <param name="Disabled">Disabled.</param>
        /// <param name="Email">Email.</param>
        /// <param name="JoinDate">JoinDate.</param>
        /// <param name="MobileNumber">MobileNumber.</param>
        /// <param name="TopicId">TopicId.</param>
        /// <param name="TopicSubscriberMap">TopicSubscriberMap.</param>
        /// <param name="UserId">UserId.</param>
        /// <param name="Username">Username.</param>
        public TopicSubscriber(bool? Disabled = default(bool?), string Email = default(string), long? JoinDate = default(long?), string MobileNumber = default(string), string TopicId = default(string), Object TopicSubscriberMap = default(Object), int? UserId = default(int?), string Username = default(string))
        {
            this.Disabled = Disabled;
            this.Email = Email;
            this.JoinDate = JoinDate;
            this.MobileNumber = MobileNumber;
            this.TopicId = TopicId;
            this.TopicSubscriberMap = TopicSubscriberMap;
            this.UserId = UserId;
            this.Username = Username;
        }
        
        /// <summary>
        /// Gets or Sets Disabled
        /// </summary>
        [DataMember(Name="disabled", EmitDefaultValue=false)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets JoinDate
        /// </summary>
        [DataMember(Name="join_date", EmitDefaultValue=false)]
        public long? JoinDate { get; set; }

        /// <summary>
        /// Gets or Sets MobileNumber
        /// </summary>
        [DataMember(Name="mobile_number", EmitDefaultValue=false)]
        public string MobileNumber { get; set; }

        /// <summary>
        /// Gets or Sets TopicId
        /// </summary>
        [DataMember(Name="topic_id", EmitDefaultValue=false)]
        public string TopicId { get; set; }

        /// <summary>
        /// Gets or Sets TopicSubscriberMap
        /// </summary>
        [DataMember(Name="topic_subscriber_map", EmitDefaultValue=false)]
        public Object TopicSubscriberMap { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TopicSubscriber {\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  JoinDate: ").Append(JoinDate).Append("\n");
            sb.Append("  MobileNumber: ").Append(MobileNumber).Append("\n");
            sb.Append("  TopicId: ").Append(TopicId).Append("\n");
            sb.Append("  TopicSubscriberMap: ").Append(TopicSubscriberMap).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
            return this.Equals(input as TopicSubscriber);
        }

        /// <summary>
        /// Returns true if TopicSubscriber instances are equal
        /// </summary>
        /// <param name="input">Instance of TopicSubscriber to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TopicSubscriber input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Disabled == input.Disabled ||
                    (this.Disabled != null &&
                    this.Disabled.Equals(input.Disabled))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.JoinDate == input.JoinDate ||
                    (this.JoinDate != null &&
                    this.JoinDate.Equals(input.JoinDate))
                ) && 
                (
                    this.MobileNumber == input.MobileNumber ||
                    (this.MobileNumber != null &&
                    this.MobileNumber.Equals(input.MobileNumber))
                ) && 
                (
                    this.TopicId == input.TopicId ||
                    (this.TopicId != null &&
                    this.TopicId.Equals(input.TopicId))
                ) && 
                (
                    this.TopicSubscriberMap == input.TopicSubscriberMap ||
                    (this.TopicSubscriberMap != null &&
                    this.TopicSubscriberMap.Equals(input.TopicSubscriberMap))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                if (this.Disabled != null)
                    hashCode = hashCode * 59 + this.Disabled.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.JoinDate != null)
                    hashCode = hashCode * 59 + this.JoinDate.GetHashCode();
                if (this.MobileNumber != null)
                    hashCode = hashCode * 59 + this.MobileNumber.GetHashCode();
                if (this.TopicId != null)
                    hashCode = hashCode * 59 + this.TopicId.GetHashCode();
                if (this.TopicSubscriberMap != null)
                    hashCode = hashCode * 59 + this.TopicSubscriberMap.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
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
