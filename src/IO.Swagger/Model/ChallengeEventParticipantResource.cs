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
    /// ChallengeEventParticipantResource
    /// </summary>
    [DataContract]
    public partial class ChallengeEventParticipantResource :  IEquatable<ChallengeEventParticipantResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChallengeEventParticipantResource" /> class.
        /// </summary>
        /// <param name="Email">Email.</param>
        /// <param name="Fullname">Fullname.</param>
        /// <param name="Score">Score.</param>
        /// <param name="UserId">UserId.</param>
        /// <param name="Username">Username.</param>
        public ChallengeEventParticipantResource(string Email = default(string), string Fullname = default(string), long? Score = default(long?), int? UserId = default(int?), string Username = default(string))
        {
            this.Email = Email;
            this.Fullname = Fullname;
            this.Score = Score;
            this.UserId = UserId;
            this.Username = Username;
        }
        
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Gets or Sets Fullname
        /// </summary>
        [DataMember(Name="fullname", EmitDefaultValue=false)]
        public string Fullname { get; set; }
        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name="score", EmitDefaultValue=false)]
        public long? Score { get; set; }
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
            sb.Append("class ChallengeEventParticipantResource {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Fullname: ").Append(Fullname).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ChallengeEventParticipantResource);
        }

        /// <summary>
        /// Returns true if ChallengeEventParticipantResource instances are equal
        /// </summary>
        /// <param name="other">Instance of ChallengeEventParticipantResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChallengeEventParticipantResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Fullname == other.Fullname ||
                    this.Fullname != null &&
                    this.Fullname.Equals(other.Fullname)
                ) && 
                (
                    this.Score == other.Score ||
                    this.Score != null &&
                    this.Score.Equals(other.Score)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.Username == other.Username ||
                    this.Username != null &&
                    this.Username.Equals(other.Username)
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
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Fullname != null)
                    hash = hash * 59 + this.Fullname.GetHashCode();
                if (this.Score != null)
                    hash = hash * 59 + this.Score.GetHashCode();
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.Username != null)
                    hash = hash * 59 + this.Username.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
