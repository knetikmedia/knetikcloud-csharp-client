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
    /// FileProperty
    /// </summary>
    [DataContract]
    public partial class FileProperty : Property,  IEquatable<FileProperty>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileProperty" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FileProperty() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileProperty" /> class.
        /// </summary>
        /// <param name="Type">The type of the property. Used for polymorphic type recognition and thus must match an expected type with additional properties. (required).</param>
        /// <param name="Crc">A crc value for file integrity verification.</param>
        /// <param name="Description">A description of the file.</param>
        /// <param name="FileType">The type of file such as txt, mp3, mov or csv.</param>
        /// <param name="Url">The url of the file.</param>
        public FileProperty(string Type = default(string), string Crc = default(string), string Description = default(string), string FileType = default(string), string Url = default(string))
        {
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for FileProperty and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.Crc = Crc;
            this.Description = Description;
            this.FileType = FileType;
            this.Url = Url;
        }
        
        /// <summary>
        /// The type of the property. Used for polymorphic type recognition and thus must match an expected type with additional properties.
        /// </summary>
        /// <value>The type of the property. Used for polymorphic type recognition and thus must match an expected type with additional properties.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// A crc value for file integrity verification
        /// </summary>
        /// <value>A crc value for file integrity verification</value>
        [DataMember(Name="crc", EmitDefaultValue=false)]
        public string Crc { get; set; }

        /// <summary>
        /// A description of the file
        /// </summary>
        /// <value>A description of the file</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The type of file such as txt, mp3, mov or csv
        /// </summary>
        /// <value>The type of file such as txt, mp3, mov or csv</value>
        [DataMember(Name="file_type", EmitDefaultValue=false)]
        public string FileType { get; set; }

        /// <summary>
        /// The url of the file
        /// </summary>
        /// <value>The url of the file</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileProperty {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Crc: ").Append(Crc).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FileType: ").Append(FileType).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as FileProperty);
        }

        /// <summary>
        /// Returns true if FileProperty instances are equal
        /// </summary>
        /// <param name="input">Instance of FileProperty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileProperty input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Crc == input.Crc ||
                    (this.Crc != null &&
                    this.Crc.Equals(input.Crc))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.FileType == input.FileType ||
                    (this.FileType != null &&
                    this.FileType.Equals(input.FileType))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Crc != null)
                    hashCode = hashCode * 59 + this.Crc.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.FileType != null)
                    hashCode = hashCode * 59 + this.FileType.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
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
