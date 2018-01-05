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
    /// CurrencyResource
    /// </summary>
    [DataContract]
    public partial class CurrencyResource :  IEquatable<CurrencyResource>, IValidatableObject
    {
        /// <summary>
        /// The type of currency. Default &#39;real&#39;
        /// </summary>
        /// <value>The type of currency. Default &#39;real&#39;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Real for "real"
            /// </summary>
            [EnumMember(Value = "real")]
            Real,
            
            /// <summary>
            /// Enum Virtual for "virtual"
            /// </summary>
            [EnumMember(Value = "virtual")]
            Virtual
        }

        /// <summary>
        /// The type of currency. Default &#39;real&#39;
        /// </summary>
        /// <value>The type of currency. Default &#39;real&#39;</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CurrencyResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyResource" /> class.
        /// </summary>
        /// <param name="Active">Whether the currency is active. Default true.</param>
        /// <param name="Code">The unique id code for the currency. Maximum 5 characters (required).</param>
        /// <param name="DefaultCurrency">Whether this is the default currency. All real money wallets will be in this currency, and the &#39;factor&#39; on each currency is in relation to the default. There must be one default currency and the current will be changed if you set another as the default. Cannot be combined with virtual currency. Take extreme caution when changing.</param>
        /// <param name="Factor">The decimal to multiply the default currency to localize to this one. Should be 1 for the default currency itself. (required).</param>
        /// <param name="Icon">The url for an icon of the currency.</param>
        /// <param name="Name">The name of the currency (required).</param>
        /// <param name="Type">The type of currency. Default &#39;real&#39;.</param>
        public CurrencyResource(bool? Active = default(bool?), string Code = default(string), bool? DefaultCurrency = default(bool?), decimal? Factor = default(decimal?), string Icon = default(string), string Name = default(string), TypeEnum? Type = default(TypeEnum?))
        {
            // to ensure "Code" is required (not null)
            if (Code == null)
            {
                throw new InvalidDataException("Code is a required property for CurrencyResource and cannot be null");
            }
            else
            {
                this.Code = Code;
            }
            // to ensure "Factor" is required (not null)
            if (Factor == null)
            {
                throw new InvalidDataException("Factor is a required property for CurrencyResource and cannot be null");
            }
            else
            {
                this.Factor = Factor;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for CurrencyResource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.Active = Active;
            this.DefaultCurrency = DefaultCurrency;
            this.Icon = Icon;
            this.Type = Type;
        }
        
        /// <summary>
        /// Whether the currency is active. Default true
        /// </summary>
        /// <value>Whether the currency is active. Default true</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// The unique id code for the currency. Maximum 5 characters
        /// </summary>
        /// <value>The unique id code for the currency. Maximum 5 characters</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// The unix timestamp in seconds the currency was added to the system
        /// </summary>
        /// <value>The unix timestamp in seconds the currency was added to the system</value>
        [DataMember(Name="created_date", EmitDefaultValue=false)]
        public long? CreatedDate { get; private set; }

        /// <summary>
        /// Whether this is the default currency. All real money wallets will be in this currency, and the &#39;factor&#39; on each currency is in relation to the default. There must be one default currency and the current will be changed if you set another as the default. Cannot be combined with virtual currency. Take extreme caution when changing
        /// </summary>
        /// <value>Whether this is the default currency. All real money wallets will be in this currency, and the &#39;factor&#39; on each currency is in relation to the default. There must be one default currency and the current will be changed if you set another as the default. Cannot be combined with virtual currency. Take extreme caution when changing</value>
        [DataMember(Name="default_currency", EmitDefaultValue=false)]
        public bool? DefaultCurrency { get; set; }

        /// <summary>
        /// The decimal to multiply the default currency to localize to this one. Should be 1 for the default currency itself.
        /// </summary>
        /// <value>The decimal to multiply the default currency to localize to this one. Should be 1 for the default currency itself.</value>
        [DataMember(Name="factor", EmitDefaultValue=false)]
        public decimal? Factor { get; set; }

        /// <summary>
        /// The url for an icon of the currency
        /// </summary>
        /// <value>The url for an icon of the currency</value>
        [DataMember(Name="icon", EmitDefaultValue=false)]
        public string Icon { get; set; }

        /// <summary>
        /// The name of the currency
        /// </summary>
        /// <value>The name of the currency</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// The unix timestamp in seconds the currency was last updated in the system.
        /// </summary>
        /// <value>The unix timestamp in seconds the currency was last updated in the system.</value>
        [DataMember(Name="updated_date", EmitDefaultValue=false)]
        public long? UpdatedDate { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CurrencyResource {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  DefaultCurrency: ").Append(DefaultCurrency).Append("\n");
            sb.Append("  Factor: ").Append(Factor).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as CurrencyResource);
        }

        /// <summary>
        /// Returns true if CurrencyResource instances are equal
        /// </summary>
        /// <param name="input">Instance of CurrencyResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CurrencyResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.DefaultCurrency == input.DefaultCurrency ||
                    (this.DefaultCurrency != null &&
                    this.DefaultCurrency.Equals(input.DefaultCurrency))
                ) && 
                (
                    this.Factor == input.Factor ||
                    (this.Factor != null &&
                    this.Factor.Equals(input.Factor))
                ) && 
                (
                    this.Icon == input.Icon ||
                    (this.Icon != null &&
                    this.Icon.Equals(input.Icon))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.DefaultCurrency != null)
                    hashCode = hashCode * 59 + this.DefaultCurrency.GetHashCode();
                if (this.Factor != null)
                    hashCode = hashCode * 59 + this.Factor.GetHashCode();
                if (this.Icon != null)
                    hashCode = hashCode * 59 + this.Icon.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
