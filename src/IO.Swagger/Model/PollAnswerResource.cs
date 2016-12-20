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
        public PollAnswerResource(string Key = null, string Text = null)
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
        /// The number of uesrs that selected this answer
        /// </summary>
        /// <value>The number of uesrs that selected this answer</value>
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as PollAnswerResource);
        }

        /// <summary>
        /// Returns true if PollAnswerResource instances are equal
        /// </summary>
        /// <param name="other">Instance of PollAnswerResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PollAnswerResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
                ) && 
                (
                    this.Key == other.Key ||
                    this.Key != null &&
                    this.Key.Equals(other.Key)
                ) && 
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
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
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                if (this.Key != null)
                    hash = hash * 59 + this.Key.GetHashCode();
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
