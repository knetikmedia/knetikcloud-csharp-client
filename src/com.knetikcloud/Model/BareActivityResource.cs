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
    /// BareActivityResource
    /// </summary>
    [DataContract]
    public partial class BareActivityResource :  IEquatable<BareActivityResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BareActivityResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BareActivityResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BareActivityResource" /> class.
        /// </summary>
        /// <param name="Launch">Details about how to launch the activity.</param>
        /// <param name="LongDescription">The user friendly name of that resource. Defaults to blank string.</param>
        /// <param name="Name">The user friendly name of that resource (required).</param>
        /// <param name="ShortDescription">The user friendly name of that resource. Defaults to blank string.</param>
        /// <param name="Template">Whether this activity is a template for other activities. Default: false.</param>
        /// <param name="Type">The type of the activity.</param>
        /// <param name="UniqueKey">The unique key (for static reference in code) of the activity.</param>
        public BareActivityResource(string Launch = default(string), string LongDescription = default(string), string Name = default(string), string ShortDescription = default(string), bool? Template = default(bool?), string Type = default(string), string UniqueKey = default(string))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for BareActivityResource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.Launch = Launch;
            this.LongDescription = LongDescription;
            this.ShortDescription = ShortDescription;
            this.Template = Template;
            this.Type = Type;
            this.UniqueKey = UniqueKey;
        }
        
        /// <summary>
        /// The date/time this resource was created in seconds since unix epoch
        /// </summary>
        /// <value>The date/time this resource was created in seconds since unix epoch</value>
        [DataMember(Name="created_date", EmitDefaultValue=false)]
        public long? CreatedDate { get; private set; }

        /// <summary>
        /// The unique ID for that resource
        /// </summary>
        /// <value>The unique ID for that resource</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// Details about how to launch the activity
        /// </summary>
        /// <value>Details about how to launch the activity</value>
        [DataMember(Name="launch", EmitDefaultValue=false)]
        public string Launch { get; set; }

        /// <summary>
        /// The user friendly name of that resource. Defaults to blank string
        /// </summary>
        /// <value>The user friendly name of that resource. Defaults to blank string</value>
        [DataMember(Name="long_description", EmitDefaultValue=false)]
        public string LongDescription { get; set; }

        /// <summary>
        /// The user friendly name of that resource
        /// </summary>
        /// <value>The user friendly name of that resource</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The user friendly name of that resource. Defaults to blank string
        /// </summary>
        /// <value>The user friendly name of that resource. Defaults to blank string</value>
        [DataMember(Name="short_description", EmitDefaultValue=false)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Whether this activity is a template for other activities. Default: false
        /// </summary>
        /// <value>Whether this activity is a template for other activities. Default: false</value>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public bool? Template { get; set; }

        /// <summary>
        /// The type of the activity
        /// </summary>
        /// <value>The type of the activity</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// The unique key (for static reference in code) of the activity
        /// </summary>
        /// <value>The unique key (for static reference in code) of the activity</value>
        [DataMember(Name="unique_key", EmitDefaultValue=false)]
        public string UniqueKey { get; set; }

        /// <summary>
        /// The date/time this resource was last updated in seconds since unix epoch
        /// </summary>
        /// <value>The date/time this resource was last updated in seconds since unix epoch</value>
        [DataMember(Name="updated_date", EmitDefaultValue=false)]
        public long? UpdatedDate { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BareActivityResource {\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Launch: ").Append(Launch).Append("\n");
            sb.Append("  LongDescription: ").Append(LongDescription).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UniqueKey: ").Append(UniqueKey).Append("\n");
            sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
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
            return this.Equals(input as BareActivityResource);
        }

        /// <summary>
        /// Returns true if BareActivityResource instances are equal
        /// </summary>
        /// <param name="input">Instance of BareActivityResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BareActivityResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Launch == input.Launch ||
                    (this.Launch != null &&
                    this.Launch.Equals(input.Launch))
                ) && 
                (
                    this.LongDescription == input.LongDescription ||
                    (this.LongDescription != null &&
                    this.LongDescription.Equals(input.LongDescription))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ShortDescription == input.ShortDescription ||
                    (this.ShortDescription != null &&
                    this.ShortDescription.Equals(input.ShortDescription))
                ) && 
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.UniqueKey == input.UniqueKey ||
                    (this.UniqueKey != null &&
                    this.UniqueKey.Equals(input.UniqueKey))
                ) && 
                (
                    this.UpdatedDate == input.UpdatedDate ||
                    (this.UpdatedDate != null &&
                    this.UpdatedDate.Equals(input.UpdatedDate))
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
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Launch != null)
                    hashCode = hashCode * 59 + this.Launch.GetHashCode();
                if (this.LongDescription != null)
                    hashCode = hashCode * 59 + this.LongDescription.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ShortDescription != null)
                    hashCode = hashCode * 59 + this.ShortDescription.GetHashCode();
                if (this.Template != null)
                    hashCode = hashCode * 59 + this.Template.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.UniqueKey != null)
                    hashCode = hashCode * 59 + this.UniqueKey.GetHashCode();
                if (this.UpdatedDate != null)
                    hashCode = hashCode * 59 + this.UpdatedDate.GetHashCode();
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
