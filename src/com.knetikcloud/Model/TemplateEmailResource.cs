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
    /// TemplateEmailResource
    /// </summary>
    [DataContract]
    public partial class TemplateEmailResource :  IEquatable<TemplateEmailResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateEmailResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TemplateEmailResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateEmailResource" /> class.
        /// </summary>
        /// <param name="From">Address to attribute the outgoing message to. Optional if the config email.out_address is set..</param>
        /// <param name="Recipients">A list of user ids to send the message to. (required).</param>
        /// <param name="Subject">The subject for email.</param>
        /// <param name="TemplateKey">The key for the template (required).</param>
        /// <param name="TemplateVars">A list of variables to fill in the template.</param>
        public TemplateEmailResource(string From = default(string), List<int?> Recipients = default(List<int?>), string Subject = default(string), string TemplateKey = default(string), List<KeyValuePairstringstring> TemplateVars = default(List<KeyValuePairstringstring>))
        {
            // to ensure "Recipients" is required (not null)
            if (Recipients == null)
            {
                throw new InvalidDataException("Recipients is a required property for TemplateEmailResource and cannot be null");
            }
            else
            {
                this.Recipients = Recipients;
            }
            // to ensure "TemplateKey" is required (not null)
            if (TemplateKey == null)
            {
                throw new InvalidDataException("TemplateKey is a required property for TemplateEmailResource and cannot be null");
            }
            else
            {
                this.TemplateKey = TemplateKey;
            }
            this.From = From;
            this.Subject = Subject;
            this.TemplateVars = TemplateVars;
        }
        
        /// <summary>
        /// Address to attribute the outgoing message to. Optional if the config email.out_address is set.
        /// </summary>
        /// <value>Address to attribute the outgoing message to. Optional if the config email.out_address is set.</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public string From { get; set; }

        /// <summary>
        /// A list of user ids to send the message to.
        /// </summary>
        /// <value>A list of user ids to send the message to.</value>
        [DataMember(Name="recipients", EmitDefaultValue=false)]
        public List<int?> Recipients { get; set; }

        /// <summary>
        /// The subject for email
        /// </summary>
        /// <value>The subject for email</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// The key for the template
        /// </summary>
        /// <value>The key for the template</value>
        [DataMember(Name="template_key", EmitDefaultValue=false)]
        public string TemplateKey { get; set; }

        /// <summary>
        /// A list of variables to fill in the template
        /// </summary>
        /// <value>A list of variables to fill in the template</value>
        [DataMember(Name="template_vars", EmitDefaultValue=false)]
        public List<KeyValuePairstringstring> TemplateVars { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateEmailResource {\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  TemplateKey: ").Append(TemplateKey).Append("\n");
            sb.Append("  TemplateVars: ").Append(TemplateVars).Append("\n");
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
            return this.Equals(input as TemplateEmailResource);
        }

        /// <summary>
        /// Returns true if TemplateEmailResource instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateEmailResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateEmailResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.Recipients == input.Recipients ||
                    (this.Recipients != null &&
                    this.Recipients.SequenceEqual(input.Recipients))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.TemplateKey == input.TemplateKey ||
                    (this.TemplateKey != null &&
                    this.TemplateKey.Equals(input.TemplateKey))
                ) && 
                (
                    this.TemplateVars == input.TemplateVars ||
                    (this.TemplateVars != null &&
                    this.TemplateVars.SequenceEqual(input.TemplateVars))
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
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.Recipients != null)
                    hashCode = hashCode * 59 + this.Recipients.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.TemplateKey != null)
                    hashCode = hashCode * 59 + this.TemplateKey.GetHashCode();
                if (this.TemplateVars != null)
                    hashCode = hashCode * 59 + this.TemplateVars.GetHashCode();
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
