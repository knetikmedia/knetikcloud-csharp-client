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
    /// SimpleWallet
    /// </summary>
    [DataContract]
    public partial class SimpleWallet :  IEquatable<SimpleWallet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleWallet" /> class.
        /// </summary>
        /// <param name="Balance">The current balance of the wallet.</param>
        /// <param name="Code">The ISO currency code for the wallet.</param>
        /// <param name="CurrencyName">The name of the currency stored in the wallet.</param>
        /// <param name="Id">The unique ID of the wallet.</param>
        /// <param name="UserId">The ID of the user to whom the wallet belongs.</param>
        public SimpleWallet(decimal? Balance = default(decimal?), string Code = default(string), string CurrencyName = default(string), int? Id = default(int?), int? UserId = default(int?))
        {
            this.Balance = Balance;
            this.Code = Code;
            this.CurrencyName = CurrencyName;
            this.Id = Id;
            this.UserId = UserId;
        }
        
        /// <summary>
        /// The current balance of the wallet
        /// </summary>
        /// <value>The current balance of the wallet</value>
        [DataMember(Name="balance", EmitDefaultValue=false)]
        public decimal? Balance { get; set; }

        /// <summary>
        /// The ISO currency code for the wallet
        /// </summary>
        /// <value>The ISO currency code for the wallet</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// The name of the currency stored in the wallet
        /// </summary>
        /// <value>The name of the currency stored in the wallet</value>
        [DataMember(Name="currency_name", EmitDefaultValue=false)]
        public string CurrencyName { get; set; }

        /// <summary>
        /// The unique ID of the wallet
        /// </summary>
        /// <value>The unique ID of the wallet</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The ID of the user to whom the wallet belongs
        /// </summary>
        /// <value>The ID of the user to whom the wallet belongs</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SimpleWallet {\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  CurrencyName: ").Append(CurrencyName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as SimpleWallet);
        }

        /// <summary>
        /// Returns true if SimpleWallet instances are equal
        /// </summary>
        /// <param name="input">Instance of SimpleWallet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimpleWallet input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.CurrencyName == input.CurrencyName ||
                    (this.CurrencyName != null &&
                    this.CurrencyName.Equals(input.CurrencyName))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.CurrencyName != null)
                    hashCode = hashCode * 59 + this.CurrencyName.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
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
