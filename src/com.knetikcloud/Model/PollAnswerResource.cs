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
    /// PollAnswerResource
    /// </summary>
    [DataContract]
    public partial class PollAnswerResource :  IEquatable<PollAnswerResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PollAnswerResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PollAnswerResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PollAnswerResource" /> class.
        /// </summary>
        /// <param name="Key">The key to the answer (for code reference) (required).</param>
        /// <param name="Text">The text of the answer (for user display) (required).</param>
        public PollAnswerResource(string Key = default(string), string Text = default(string))
        {
            // to ensure "Key" is required (not null)
            if (Key == null)
            {
                throw new InvalidDataException("Key is a required property for PollAnswerResource and cannot be null");
            }
            else
            {
                this.Key = Key;
            }
            // to ensure "Text" is required (not null)
            if (Text == null)
            {
                throw new InvalidDataException("Text is a required property for PollAnswerResource and cannot be null");
            }
            else
            {
                this.Text = Text;
            }
        }
        
        /// <summary>
        /// The number of users that selected this answer
        /// </summary>
        /// <value>The number of users that selected this answer</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; private set; }

        /// <summary>
        /// The key to the answer (for code reference)
        /// </summary>
        /// <value>The key to the answer (for code reference)</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// The text of the answer (for user display)
        /// </summary>
        /// <value>The text of the answer (for user display)</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PollAnswerResource {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return this.Equals(input as PollAnswerResource);
        }

        /// <summary>
        /// Returns true if PollAnswerResource instances are equal
        /// </summary>
        /// <param name="input">Instance of PollAnswerResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PollAnswerResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
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
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
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