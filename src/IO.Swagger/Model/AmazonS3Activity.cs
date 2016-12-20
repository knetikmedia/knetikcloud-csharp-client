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
    /// AmazonS3Activity
    /// </summary>
    [DataContract]
    public partial class AmazonS3Activity :  IEquatable<AmazonS3Activity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AmazonS3Activity" /> class.
        /// </summary>
        /// <param name="Action">S3 action (i.e., &#39;PUT&#39;) associated with the activity.</param>
        /// <param name="CreatedDate">Date the resource was created in S3.</param>
        /// <param name="Filename">Name of the file being processed as a resource in S3.</param>
        /// <param name="ObjectKey">S3 object key for the resource.</param>
        /// <param name="Url">URL for accessing the S3 resource.</param>
        /// <param name="UserId">The id of the user that created this S3 activity.</param>
        public AmazonS3Activity(string Action = null, long? CreatedDate = null, string Filename = null, string ObjectKey = null, string Url = null, int? UserId = null)
        {
            this.Action = Action;
            this.CreatedDate = CreatedDate;
            this.Filename = Filename;
            this.ObjectKey = ObjectKey;
            this.Url = Url;
            this.UserId = UserId;
        }
        
        /// <summary>
        /// S3 action (i.e., &#39;PUT&#39;) associated with the activity
        /// </summary>
        /// <value>S3 action (i.e., &#39;PUT&#39;) associated with the activity</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }
        /// <summary>
        /// Date the resource was created in S3
        /// </summary>
        /// <value>Date the resource was created in S3</value>
        [DataMember(Name="created_date", EmitDefaultValue=false)]
        public long? CreatedDate { get; set; }
        /// <summary>
        /// Name of the file being processed as a resource in S3
        /// </summary>
        /// <value>Name of the file being processed as a resource in S3</value>
        [DataMember(Name="filename", EmitDefaultValue=false)]
        public string Filename { get; set; }
        /// <summary>
        /// Unique id of the S3 activity
        /// </summary>
        /// <value>Unique id of the S3 activity</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }
        /// <summary>
        /// S3 object key for the resource
        /// </summary>
        /// <value>S3 object key for the resource</value>
        [DataMember(Name="object_key", EmitDefaultValue=false)]
        public string ObjectKey { get; set; }
        /// <summary>
        /// URL for accessing the S3 resource
        /// </summary>
        /// <value>URL for accessing the S3 resource</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }
        /// <summary>
        /// The id of the user that created this S3 activity
        /// </summary>
        /// <value>The id of the user that created this S3 activity</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public int? UserId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AmazonS3Activity {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Filename: ").Append(Filename).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ObjectKey: ").Append(ObjectKey).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(obj as AmazonS3Activity);
        }

        /// <summary>
        /// Returns true if AmazonS3Activity instances are equal
        /// </summary>
        /// <param name="other">Instance of AmazonS3Activity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AmazonS3Activity other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.Filename == other.Filename ||
                    this.Filename != null &&
                    this.Filename.Equals(other.Filename)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.ObjectKey == other.ObjectKey ||
                    this.ObjectKey != null &&
                    this.ObjectKey.Equals(other.ObjectKey)
                ) && 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
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
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                if (this.Filename != null)
                    hash = hash * 59 + this.Filename.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.ObjectKey != null)
                    hash = hash * 59 + this.ObjectKey.GetHashCode();
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
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
