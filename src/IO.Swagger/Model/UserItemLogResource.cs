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
    /// UserItemLogResource
    /// </summary>
    [DataContract]
    public partial class UserItemLogResource :  IEquatable<UserItemLogResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserItemLogResource" /> class.
        /// </summary>
        /// <param name="Info">Additional information defined by the type.</param>
        /// <param name="Item">The item interacted with.</param>
        /// <param name="Type">The type of event.</param>
        /// <param name="User">The user making the interaction.</param>
        /// <param name="UserInventory">The id of the inventory entry this event is related to, if any.</param>
        public UserItemLogResource(string Info = null, SimpleReferenceResourceint Item = null, string Type = null, SimpleUserResource User = null, int? UserInventory = null)
        {
            this.Info = Info;
            this.Item = Item;
            this.Type = Type;
            this.User = User;
            this.UserInventory = UserInventory;
        }
        
        /// <summary>
        /// The log entry id
        /// </summary>
        /// <value>The log entry id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
        /// <summary>
        /// Additional information defined by the type
        /// </summary>
        /// <value>Additional information defined by the type</value>
        [DataMember(Name="info", EmitDefaultValue=false)]
        public string Info { get; set; }
        /// <summary>
        /// The item interacted with
        /// </summary>
        /// <value>The item interacted with</value>
        [DataMember(Name="item", EmitDefaultValue=false)]
        public SimpleReferenceResourceint Item { get; set; }
        /// <summary>
        /// The date/time this event occurred in seconds since epoch
        /// </summary>
        /// <value>The date/time this event occurred in seconds since epoch</value>
        [DataMember(Name="log_date", EmitDefaultValue=false)]
        public long? LogDate { get; private set; }
        /// <summary>
        /// The type of event
        /// </summary>
        /// <value>The type of event</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// The user making the interaction
        /// </summary>
        /// <value>The user making the interaction</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public SimpleUserResource User { get; set; }
        /// <summary>
        /// The id of the inventory entry this event is related to, if any
        /// </summary>
        /// <value>The id of the inventory entry this event is related to, if any</value>
        [DataMember(Name="user_inventory", EmitDefaultValue=false)]
        public int? UserInventory { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserItemLogResource {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
            sb.Append("  Item: ").Append(Item).Append("\n");
            sb.Append("  LogDate: ").Append(LogDate).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  UserInventory: ").Append(UserInventory).Append("\n");
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
            return this.Equals(obj as UserItemLogResource);
        }

        /// <summary>
        /// Returns true if UserItemLogResource instances are equal
        /// </summary>
        /// <param name="other">Instance of UserItemLogResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserItemLogResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Info == other.Info ||
                    this.Info != null &&
                    this.Info.Equals(other.Info)
                ) && 
                (
                    this.Item == other.Item ||
                    this.Item != null &&
                    this.Item.Equals(other.Item)
                ) && 
                (
                    this.LogDate == other.LogDate ||
                    this.LogDate != null &&
                    this.LogDate.Equals(other.LogDate)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) && 
                (
                    this.UserInventory == other.UserInventory ||
                    this.UserInventory != null &&
                    this.UserInventory.Equals(other.UserInventory)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Info != null)
                    hash = hash * 59 + this.Info.GetHashCode();
                if (this.Item != null)
                    hash = hash * 59 + this.Item.GetHashCode();
                if (this.LogDate != null)
                    hash = hash * 59 + this.LogDate.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                if (this.UserInventory != null)
                    hash = hash * 59 + this.UserInventory.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}