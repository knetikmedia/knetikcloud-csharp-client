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
    /// AnswerResource
    /// </summary>
    [DataContract]
    public partial class AnswerResource :  IEquatable<AnswerResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AnswerResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerResource" /> class.
        /// </summary>
        /// <param name="Answer">The answer to the question. Different &#39;type&#39; values indicate different structures as the answer may be test, image, etc. See information on additional properties for the list and their structures (required).</param>
        /// <param name="Correct">Whether the answer is correct or not (required).</param>
        public AnswerResource(Property Answer = null, bool? Correct = null)
        {
            // to ensure "Answer" is required (not null)
            if (Answer == null)
            {
                throw new InvalidDataException("Answer is a required property for AnswerResource and cannot be null");
            }
            else
            {
                this.Answer = Answer;
            }
            // to ensure "Correct" is required (not null)
            if (Correct == null)
            {
                throw new InvalidDataException("Correct is a required property for AnswerResource and cannot be null");
            }
            else
            {
                this.Correct = Correct;
            }
        }
        
        /// <summary>
        /// The answer to the question. Different &#39;type&#39; values indicate different structures as the answer may be test, image, etc. See information on additional properties for the list and their structures
        /// </summary>
        /// <value>The answer to the question. Different &#39;type&#39; values indicate different structures as the answer may be test, image, etc. See information on additional properties for the list and their structures</value>
        [DataMember(Name="answer", EmitDefaultValue=false)]
        public Property Answer { get; set; }
        /// <summary>
        /// Whether the answer is correct or not
        /// </summary>
        /// <value>Whether the answer is correct or not</value>
        [DataMember(Name="correct", EmitDefaultValue=false)]
        public bool? Correct { get; set; }
        /// <summary>
        /// The unique ID for that resource
        /// </summary>
        /// <value>The unique ID for that resource</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnswerResource {\n");
            sb.Append("  Answer: ").Append(Answer).Append("\n");
            sb.Append("  Correct: ").Append(Correct).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(obj as AnswerResource);
        }

        /// <summary>
        /// Returns true if AnswerResource instances are equal
        /// </summary>
        /// <param name="other">Instance of AnswerResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnswerResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Answer == other.Answer ||
                    this.Answer != null &&
                    this.Answer.Equals(other.Answer)
                ) && 
                (
                    this.Correct == other.Correct ||
                    this.Correct != null &&
                    this.Correct.Equals(other.Correct)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                if (this.Answer != null)
                    hash = hash * 59 + this.Answer.GetHashCode();
                if (this.Correct != null)
                    hash = hash * 59 + this.Correct.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}