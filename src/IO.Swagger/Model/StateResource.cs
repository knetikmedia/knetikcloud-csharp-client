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
    /// StateResource
    /// </summary>
    [DataContract]
    public partial class StateResource :  IEquatable<StateResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StateResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public StateResource()
        {
        }
        
        /// <summary>
        /// The code of the state
        /// </summary>
        /// <value>The code of the state</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; private set; }
        /// <summary>
        /// The iso3 of the country this state is in
        /// </summary>
        /// <value>The iso3 of the country this state is in</value>
        [DataMember(Name="country_code_iso3", EmitDefaultValue=false)]
        public string CountryCodeIso3 { get; private set; }
        /// <summary>
        /// The unique ID for the state
        /// </summary>
        /// <value>The unique ID for the state</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
        /// <summary>
        /// The name of the state
        /// </summary>
        /// <value>The name of the state</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StateResource {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  CountryCodeIso3: ").Append(CountryCodeIso3).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(obj as StateResource);
        }

        /// <summary>
        /// Returns true if StateResource instances are equal
        /// </summary>
        /// <param name="other">Instance of StateResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StateResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.CountryCodeIso3 == other.CountryCodeIso3 ||
                    this.CountryCodeIso3 != null &&
                    this.CountryCodeIso3.Equals(other.CountryCodeIso3)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                if (this.CountryCodeIso3 != null)
                    hash = hash * 59 + this.CountryCodeIso3.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
