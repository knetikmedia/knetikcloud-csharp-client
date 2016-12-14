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
        /// <param name="Type">The type of the activity (required).</param>
        /// <param name="UniqueKey">The unique key (for static reference in code) of the activity.</param>
        public BareActivityResource(string Launch = null, string LongDescription = null, string Name = null, string ShortDescription = null, bool? Template = null, string Type = null, string UniqueKey = null)
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
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for BareActivityResource and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.Launch = Launch;
            this.LongDescription = LongDescription;
            this.ShortDescription = ShortDescription;
            this.Template = Template;
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as BareActivityResource);
        }

        /// <summary>
        /// Returns true if BareActivityResource instances are equal
        /// </summary>
        /// <param name="other">Instance of BareActivityResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BareActivityResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Launch == other.Launch ||
                    this.Launch != null &&
                    this.Launch.Equals(other.Launch)
                ) && 
                (
                    this.LongDescription == other.LongDescription ||
                    this.LongDescription != null &&
                    this.LongDescription.Equals(other.LongDescription)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.ShortDescription == other.ShortDescription ||
                    this.ShortDescription != null &&
                    this.ShortDescription.Equals(other.ShortDescription)
                ) && 
                (
                    this.Template == other.Template ||
                    this.Template != null &&
                    this.Template.Equals(other.Template)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.UniqueKey == other.UniqueKey ||
                    this.UniqueKey != null &&
                    this.UniqueKey.Equals(other.UniqueKey)
                ) && 
                (
                    this.UpdatedDate == other.UpdatedDate ||
                    this.UpdatedDate != null &&
                    this.UpdatedDate.Equals(other.UpdatedDate)
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
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Launch != null)
                    hash = hash * 59 + this.Launch.GetHashCode();
                if (this.LongDescription != null)
                    hash = hash * 59 + this.LongDescription.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.ShortDescription != null)
                    hash = hash * 59 + this.ShortDescription.GetHashCode();
                if (this.Template != null)
                    hash = hash * 59 + this.Template.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.UniqueKey != null)
                    hash = hash * 59 + this.UniqueKey.GetHashCode();
                if (this.UpdatedDate != null)
                    hash = hash * 59 + this.UpdatedDate.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
