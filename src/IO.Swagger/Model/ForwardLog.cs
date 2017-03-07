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
    /// ForwardLog
    /// </summary>
    [DataContract]
    public partial class ForwardLog :  IEquatable<ForwardLog>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForwardLog" /> class.
        /// </summary>
        /// <param name="ErrorMsg">ErrorMsg.</param>
        /// <param name="Payload">The payload of the forward log entry.</param>
        public ForwardLog(string ErrorMsg = default(string), Object Payload = default(Object))
        {
            this.ErrorMsg = ErrorMsg;
            this.Payload = Payload;
        }
        
        /// <summary>
        /// The end date of the forward log entry
        /// </summary>
        /// <value>The end date of the forward log entry</value>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        public long? EndDate { get; private set; }
        /// <summary>
        /// Gets or Sets ErrorMsg
        /// </summary>
        [DataMember(Name="error_msg", EmitDefaultValue=false)]
        public string ErrorMsg { get; set; }
        /// <summary>
        /// The http status code the forward log entry
        /// </summary>
        /// <value>The http status code the forward log entry</value>
        [DataMember(Name="http_status_code", EmitDefaultValue=false)]
        public int? HttpStatusCode { get; private set; }
        /// <summary>
        /// The id of the forward log entry
        /// </summary>
        /// <value>The id of the forward log entry</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        /// <summary>
        /// The payload of the forward log entry
        /// </summary>
        /// <value>The payload of the forward log entry</value>
        [DataMember(Name="payload", EmitDefaultValue=false)]
        public Object Payload { get; set; }
        /// <summary>
        /// The response string of the forward log entry
        /// </summary>
        /// <value>The response string of the forward log entry</value>
        [DataMember(Name="response", EmitDefaultValue=false)]
        public string Response { get; private set; }
        /// <summary>
        /// The retry count of the forward log entry
        /// </summary>
        /// <value>The retry count of the forward log entry</value>
        [DataMember(Name="retry_count", EmitDefaultValue=false)]
        public int? RetryCount { get; private set; }
        /// <summary>
        /// The start date of the forward log entry
        /// </summary>
        /// <value>The start date of the forward log entry</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public long? StartDate { get; private set; }
        /// <summary>
        /// The endpoint url of the forward log entry
        /// </summary>
        /// <value>The endpoint url of the forward log entry</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForwardLog {\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  ErrorMsg: ").Append(ErrorMsg).Append("\n");
            sb.Append("  HttpStatusCode: ").Append(HttpStatusCode).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  Response: ").Append(Response).Append("\n");
            sb.Append("  RetryCount: ").Append(RetryCount).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(obj as ForwardLog);
        }

        /// <summary>
        /// Returns true if ForwardLog instances are equal
        /// </summary>
        /// <param name="other">Instance of ForwardLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForwardLog other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) && 
                (
                    this.ErrorMsg == other.ErrorMsg ||
                    this.ErrorMsg != null &&
                    this.ErrorMsg.Equals(other.ErrorMsg)
                ) && 
                (
                    this.HttpStatusCode == other.HttpStatusCode ||
                    this.HttpStatusCode != null &&
                    this.HttpStatusCode.Equals(other.HttpStatusCode)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Payload == other.Payload ||
                    this.Payload != null &&
                    this.Payload.Equals(other.Payload)
                ) && 
                (
                    this.Response == other.Response ||
                    this.Response != null &&
                    this.Response.Equals(other.Response)
                ) && 
                (
                    this.RetryCount == other.RetryCount ||
                    this.RetryCount != null &&
                    this.RetryCount.Equals(other.RetryCount)
                ) && 
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) && 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
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
                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();
                if (this.ErrorMsg != null)
                    hash = hash * 59 + this.ErrorMsg.GetHashCode();
                if (this.HttpStatusCode != null)
                    hash = hash * 59 + this.HttpStatusCode.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Payload != null)
                    hash = hash * 59 + this.Payload.GetHashCode();
                if (this.Response != null)
                    hash = hash * 59 + this.Response.GetHashCode();
                if (this.RetryCount != null)
                    hash = hash * 59 + this.RetryCount.GetHashCode();
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
