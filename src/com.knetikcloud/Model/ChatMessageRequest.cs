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
    /// ChatMessageRequest
    /// </summary>
    [DataContract]
    public partial class ChatMessageRequest :  IEquatable<ChatMessageRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChatMessageRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageRequest" /> class.
        /// </summary>
        /// <param name="Content">The content of the message (required).</param>
        /// <param name="MessageType">The type of the message set by the client (required).</param>
        public ChatMessageRequest(Object Content = default(Object), string MessageType = default(string))
        {
            // to ensure "Content" is required (not null)
            if (Content == null)
            {
                throw new InvalidDataException("Content is a required property for ChatMessageRequest and cannot be null");
            }
            else
            {
                this.Content = Content;
            }
            // to ensure "MessageType" is required (not null)
            if (MessageType == null)
            {
                throw new InvalidDataException("MessageType is a required property for ChatMessageRequest and cannot be null");
            }
            else
            {
                this.MessageType = MessageType;
            }
        }
        
        /// <summary>
        /// The content of the message
        /// </summary>
        /// <value>The content of the message</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public Object Content { get; set; }

        /// <summary>
        /// The type of the message set by the client
        /// </summary>
        /// <value>The type of the message set by the client</value>
        [DataMember(Name="message_type", EmitDefaultValue=false)]
        public string MessageType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChatMessageRequest {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
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
            return this.Equals(input as ChatMessageRequest);
        }

        /// <summary>
        /// Returns true if ChatMessageRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ChatMessageRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChatMessageRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.MessageType == input.MessageType ||
                    (this.MessageType != null &&
                    this.MessageType.Equals(input.MessageType))
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
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.MessageType != null)
                    hashCode = hashCode * 59 + this.MessageType.GetHashCode();
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
