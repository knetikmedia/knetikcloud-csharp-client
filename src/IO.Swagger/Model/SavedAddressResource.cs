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
    /// SavedAddressResource
    /// </summary>
    [DataContract]
    public partial class SavedAddressResource :  IEquatable<SavedAddressResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SavedAddressResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SavedAddressResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SavedAddressResource" /> class.
        /// </summary>
        /// <param name="Address1">The first line of the address (required).</param>
        /// <param name="Address2">A second line of the address.</param>
        /// <param name="City">The city (required).</param>
        /// <param name="CountryCode">The iso3 code for the country (required).</param>
        /// <param name="_Default">_Default.</param>
        /// <param name="FirstName">The first name of the user (required).</param>
        /// <param name="LastName">The last name of the user (required).</param>
        /// <param name="Name">The name of the address (required).</param>
        /// <param name="Phone1">The first phone number of the user.</param>
        /// <param name="Phone2">The second phone number of the user.</param>
        /// <param name="PostalCode">The postal code.</param>
        /// <param name="StateCode">The code for the state. Required if the country has states/provinces/equivalent.</param>
        public SavedAddressResource(string Address1 = null, string Address2 = null, string City = null, string CountryCode = null, bool? _Default = null, string FirstName = null, string LastName = null, string Name = null, string Phone1 = null, string Phone2 = null, string PostalCode = null, string StateCode = null)
        {
            // to ensure "Address1" is required (not null)
            if (Address1 == null)
            {
                throw new InvalidDataException("Address1 is a required property for SavedAddressResource and cannot be null");
            }
            else
            {
                this.Address1 = Address1;
            }
            // to ensure "City" is required (not null)
            if (City == null)
            {
                throw new InvalidDataException("City is a required property for SavedAddressResource and cannot be null");
            }
            else
            {
                this.City = City;
            }
            // to ensure "CountryCode" is required (not null)
            if (CountryCode == null)
            {
                throw new InvalidDataException("CountryCode is a required property for SavedAddressResource and cannot be null");
            }
            else
            {
                this.CountryCode = CountryCode;
            }
            // to ensure "FirstName" is required (not null)
            if (FirstName == null)
            {
                throw new InvalidDataException("FirstName is a required property for SavedAddressResource and cannot be null");
            }
            else
            {
                this.FirstName = FirstName;
            }
            // to ensure "LastName" is required (not null)
            if (LastName == null)
            {
                throw new InvalidDataException("LastName is a required property for SavedAddressResource and cannot be null");
            }
            else
            {
                this.LastName = LastName;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for SavedAddressResource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.Address2 = Address2;
            this._Default = _Default;
            this.Phone1 = Phone1;
            this.Phone2 = Phone2;
            this.PostalCode = PostalCode;
            this.StateCode = StateCode;
        }
        
        /// <summary>
        /// The first line of the address
        /// </summary>
        /// <value>The first line of the address</value>
        [DataMember(Name="address1", EmitDefaultValue=false)]
        public string Address1 { get; set; }
        /// <summary>
        /// A second line of the address
        /// </summary>
        /// <value>A second line of the address</value>
        [DataMember(Name="address2", EmitDefaultValue=false)]
        public string Address2 { get; set; }
        /// <summary>
        /// The city
        /// </summary>
        /// <value>The city</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }
        /// <summary>
        /// The iso3 code for the country
        /// </summary>
        /// <value>The iso3 code for the country</value>
        [DataMember(Name="country_code", EmitDefaultValue=false)]
        public string CountryCode { get; set; }
        /// <summary>
        /// Gets or Sets _Default
        /// </summary>
        [DataMember(Name="default", EmitDefaultValue=false)]
        public bool? _Default { get; set; }
        /// <summary>
        /// The first name of the user
        /// </summary>
        /// <value>The first name of the user</value>
        [DataMember(Name="first_name", EmitDefaultValue=false)]
        public string FirstName { get; set; }
        /// <summary>
        /// The id of the address
        /// </summary>
        /// <value>The id of the address</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
        /// <summary>
        /// The last name of the user
        /// </summary>
        /// <value>The last name of the user</value>
        [DataMember(Name="last_name", EmitDefaultValue=false)]
        public string LastName { get; set; }
        /// <summary>
        /// The name of the address
        /// </summary>
        /// <value>The name of the address</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The first phone number of the user
        /// </summary>
        /// <value>The first phone number of the user</value>
        [DataMember(Name="phone1", EmitDefaultValue=false)]
        public string Phone1 { get; set; }
        /// <summary>
        /// The second phone number of the user
        /// </summary>
        /// <value>The second phone number of the user</value>
        [DataMember(Name="phone2", EmitDefaultValue=false)]
        public string Phone2 { get; set; }
        /// <summary>
        /// The postal code
        /// </summary>
        /// <value>The postal code</value>
        [DataMember(Name="postal_code", EmitDefaultValue=false)]
        public string PostalCode { get; set; }
        /// <summary>
        /// The code for the state. Required if the country has states/provinces/equivalent
        /// </summary>
        /// <value>The code for the state. Required if the country has states/provinces/equivalent</value>
        [DataMember(Name="state_code", EmitDefaultValue=false)]
        public string StateCode { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SavedAddressResource {\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  _Default: ").Append(_Default).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Phone1: ").Append(Phone1).Append("\n");
            sb.Append("  Phone2: ").Append(Phone2).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  StateCode: ").Append(StateCode).Append("\n");
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
            return this.Equals(obj as SavedAddressResource);
        }

        /// <summary>
        /// Returns true if SavedAddressResource instances are equal
        /// </summary>
        /// <param name="other">Instance of SavedAddressResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SavedAddressResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Address1 == other.Address1 ||
                    this.Address1 != null &&
                    this.Address1.Equals(other.Address1)
                ) && 
                (
                    this.Address2 == other.Address2 ||
                    this.Address2 != null &&
                    this.Address2.Equals(other.Address2)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.CountryCode == other.CountryCode ||
                    this.CountryCode != null &&
                    this.CountryCode.Equals(other.CountryCode)
                ) && 
                (
                    this._Default == other._Default ||
                    this._Default != null &&
                    this._Default.Equals(other._Default)
                ) && 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Phone1 == other.Phone1 ||
                    this.Phone1 != null &&
                    this.Phone1.Equals(other.Phone1)
                ) && 
                (
                    this.Phone2 == other.Phone2 ||
                    this.Phone2 != null &&
                    this.Phone2.Equals(other.Phone2)
                ) && 
                (
                    this.PostalCode == other.PostalCode ||
                    this.PostalCode != null &&
                    this.PostalCode.Equals(other.PostalCode)
                ) && 
                (
                    this.StateCode == other.StateCode ||
                    this.StateCode != null &&
                    this.StateCode.Equals(other.StateCode)
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
                if (this.Address1 != null)
                    hash = hash * 59 + this.Address1.GetHashCode();
                if (this.Address2 != null)
                    hash = hash * 59 + this.Address2.GetHashCode();
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                if (this.CountryCode != null)
                    hash = hash * 59 + this.CountryCode.GetHashCode();
                if (this._Default != null)
                    hash = hash * 59 + this._Default.GetHashCode();
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Phone1 != null)
                    hash = hash * 59 + this.Phone1.GetHashCode();
                if (this.Phone2 != null)
                    hash = hash * 59 + this.Phone2.GetHashCode();
                if (this.PostalCode != null)
                    hash = hash * 59 + this.PostalCode.GetHashCode();
                if (this.StateCode != null)
                    hash = hash * 59 + this.StateCode.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
