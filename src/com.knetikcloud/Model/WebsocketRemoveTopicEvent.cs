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
    /// WebsocketRemoveTopicEvent
    /// </summary>
    [DataContract]
    public partial class WebsocketRemoveTopicEvent : BroadcastableEvent,  IEquatable<WebsocketRemoveTopicEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketRemoveTopicEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebsocketRemoveTopicEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketRemoveTopicEvent" /> class.
        /// </summary>
        /// <param name="_Client">_Client.</param>
        /// <param name="Customer">Customer.</param>
        /// <param name="DoNotBroadcast">DoNotBroadcast.</param>
        /// <param name="Section">Section.</param>
        /// <param name="Source">Source.</param>
        /// <param name="Specifics">Specifics.</param>
        /// <param name="Synchronous">Synchronous.</param>
        /// <param name="Timestamp">Timestamp.</param>
        /// <param name="Type">The type of the event. Used for polymorphic type recognition and thus must match an expected type (required).</param>
        /// <param name="Topic">Topic.</param>
        public WebsocketRemoveTopicEvent(string _Client = default(string), string Customer = default(string), bool? DoNotBroadcast = default(bool?), string Section = default(string), Object Source = default(Object), string Specifics = default(string), bool? Synchronous = default(bool?), long? Timestamp = default(long?), string Type = default(string), Topic Topic = default(Topic))
        {
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for WebsocketRemoveTopicEvent and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this._Client = _Client;
            this.Customer = Customer;
            this.DoNotBroadcast = DoNotBroadcast;
            this.Section = Section;
            this.Source = Source;
            this.Specifics = Specifics;
            this.Synchronous = Synchronous;
            this.Timestamp = Timestamp;
            this.Topic = Topic;
        }
        
        /// <summary>
        /// Gets or Sets _Client
        /// </summary>
        [DataMember(Name="client", EmitDefaultValue=false)]
        public string _Client { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name="customer", EmitDefaultValue=false)]
        public string Customer { get; set; }

        /// <summary>
        /// Gets or Sets DoNotBroadcast
        /// </summary>
        [DataMember(Name="do_not_broadcast", EmitDefaultValue=false)]
        public bool? DoNotBroadcast { get; set; }

        /// <summary>
        /// Gets or Sets Section
        /// </summary>
        [DataMember(Name="section", EmitDefaultValue=false)]
        public string Section { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public Object Source { get; set; }

        /// <summary>
        /// Gets or Sets Specifics
        /// </summary>
        [DataMember(Name="specifics", EmitDefaultValue=false)]
        public string Specifics { get; set; }

        /// <summary>
        /// Gets or Sets Synchronous
        /// </summary>
        [DataMember(Name="synchronous", EmitDefaultValue=false)]
        public bool? Synchronous { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public long? Timestamp { get; set; }

        /// <summary>
        /// The type of the event. Used for polymorphic type recognition and thus must match an expected type
        /// </summary>
        /// <value>The type of the event. Used for polymorphic type recognition and thus must match an expected type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Topic
        /// </summary>
        [DataMember(Name="topic", EmitDefaultValue=false)]
        public Topic Topic { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebsocketRemoveTopicEvent {\n");
            sb.Append("  _Client: ").Append(_Client).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  DoNotBroadcast: ").Append(DoNotBroadcast).Append("\n");
            sb.Append("  Section: ").Append(Section).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Specifics: ").Append(Specifics).Append("\n");
            sb.Append("  Synchronous: ").Append(Synchronous).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Topic: ").Append(Topic).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
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
            return this.Equals(input as WebsocketRemoveTopicEvent);
        }

        /// <summary>
        /// Returns true if WebsocketRemoveTopicEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of WebsocketRemoveTopicEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebsocketRemoveTopicEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Client == input._Client ||
                    (this._Client != null &&
                    this._Client.Equals(input._Client))
                ) && 
                (
                    this.Customer == input.Customer ||
                    (this.Customer != null &&
                    this.Customer.Equals(input.Customer))
                ) && 
                (
                    this.DoNotBroadcast == input.DoNotBroadcast ||
                    (this.DoNotBroadcast != null &&
                    this.DoNotBroadcast.Equals(input.DoNotBroadcast))
                ) && 
                (
                    this.Section == input.Section ||
                    (this.Section != null &&
                    this.Section.Equals(input.Section))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Specifics == input.Specifics ||
                    (this.Specifics != null &&
                    this.Specifics.Equals(input.Specifics))
                ) && 
                (
                    this.Synchronous == input.Synchronous ||
                    (this.Synchronous != null &&
                    this.Synchronous.Equals(input.Synchronous))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Topic == input.Topic ||
                    (this.Topic != null &&
                    this.Topic.Equals(input.Topic))
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
                if (this._Client != null)
                    hashCode = hashCode * 59 + this._Client.GetHashCode();
                if (this.Customer != null)
                    hashCode = hashCode * 59 + this.Customer.GetHashCode();
                if (this.DoNotBroadcast != null)
                    hashCode = hashCode * 59 + this.DoNotBroadcast.GetHashCode();
                if (this.Section != null)
                    hashCode = hashCode * 59 + this.Section.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Specifics != null)
                    hashCode = hashCode * 59 + this.Specifics.GetHashCode();
                if (this.Synchronous != null)
                    hashCode = hashCode * 59 + this.Synchronous.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Topic != null)
                    hashCode = hashCode * 59 + this.Topic.GetHashCode();
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
