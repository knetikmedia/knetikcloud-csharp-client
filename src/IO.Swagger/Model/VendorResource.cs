/* 
 * Knetik Platform API Documentation latest 
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://demo.sandbox.knetikcloud.com
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

namespace IO.Swagger.Model
{
    /// <summary>
    /// VendorResource
    /// </summary>
    [DataContract]
    public partial class VendorResource :  IEquatable<VendorResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VendorResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VendorResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VendorResource" /> class.
        /// </summary>
        /// <param name="Active">Whether the vendor is active.  Default &#x3D; true.</param>
        /// <param name="Description">A description of the vendor.</param>
        /// <param name="ImageUrl">The url of an image for the vendor.</param>
        /// <param name="ManualApproval">Whether the vendor needs to manually approve invoices before they are paid.  A separate checkout flow is required in this case.  Default: false.</param>
        /// <param name="Name">The name of the vendor (required).</param>
        /// <param name="PrimaryContactEmail">The primary email address for the vendor.</param>
        /// <param name="PrimaryContactName">The name of the primary contact for the vendor.</param>
        /// <param name="PrimaryContactPhone">The primary phone number for the vendor.</param>
        /// <param name="SalesEmail">The email address for sale inquiries for the vendor.</param>
        /// <param name="SupportEmail">The email address for support inquiries for the vendor.</param>
        /// <param name="Url">The url for the vendor&#39;s site.</param>
        public VendorResource(bool? Active = default(bool?), string Description = default(string), string ImageUrl = default(string), bool? ManualApproval = default(bool?), string Name = default(string), string PrimaryContactEmail = default(string), string PrimaryContactName = default(string), string PrimaryContactPhone = default(string), string SalesEmail = default(string), string SupportEmail = default(string), string Url = default(string))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for VendorResource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.Active = Active;
            this.Description = Description;
            this.ImageUrl = ImageUrl;
            this.ManualApproval = ManualApproval;
            this.PrimaryContactEmail = PrimaryContactEmail;
            this.PrimaryContactName = PrimaryContactName;
            this.PrimaryContactPhone = PrimaryContactPhone;
            this.SalesEmail = SalesEmail;
            this.SupportEmail = SupportEmail;
            this.Url = Url;
        }
        
        /// <summary>
        /// Whether the vendor is active.  Default &#x3D; true
        /// </summary>
        /// <value>Whether the vendor is active.  Default &#x3D; true</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }
        /// <summary>
        /// The date the vendor was added. Unix timestamp in seconds
        /// </summary>
        /// <value>The date the vendor was added. Unix timestamp in seconds</value>
        [DataMember(Name="create_date", EmitDefaultValue=false)]
        public long? CreateDate { get; private set; }
        /// <summary>
        /// A description of the vendor
        /// </summary>
        /// <value>A description of the vendor</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// The id of the vendor
        /// </summary>
        /// <value>The id of the vendor</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
        /// <summary>
        /// The url of an image for the vendor
        /// </summary>
        /// <value>The url of an image for the vendor</value>
        [DataMember(Name="image_url", EmitDefaultValue=false)]
        public string ImageUrl { get; set; }
        /// <summary>
        /// Whether the vendor needs to manually approve invoices before they are paid.  A separate checkout flow is required in this case.  Default: false
        /// </summary>
        /// <value>Whether the vendor needs to manually approve invoices before they are paid.  A separate checkout flow is required in this case.  Default: false</value>
        [DataMember(Name="manual_approval", EmitDefaultValue=false)]
        public bool? ManualApproval { get; set; }
        /// <summary>
        /// The name of the vendor
        /// </summary>
        /// <value>The name of the vendor</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The primary email address for the vendor
        /// </summary>
        /// <value>The primary email address for the vendor</value>
        [DataMember(Name="primary_contact_email", EmitDefaultValue=false)]
        public string PrimaryContactEmail { get; set; }
        /// <summary>
        /// The name of the primary contact for the vendor
        /// </summary>
        /// <value>The name of the primary contact for the vendor</value>
        [DataMember(Name="primary_contact_name", EmitDefaultValue=false)]
        public string PrimaryContactName { get; set; }
        /// <summary>
        /// The primary phone number for the vendor
        /// </summary>
        /// <value>The primary phone number for the vendor</value>
        [DataMember(Name="primary_contact_phone", EmitDefaultValue=false)]
        public string PrimaryContactPhone { get; set; }
        /// <summary>
        /// The email address for sale inquiries for the vendor
        /// </summary>
        /// <value>The email address for sale inquiries for the vendor</value>
        [DataMember(Name="sales_email", EmitDefaultValue=false)]
        public string SalesEmail { get; set; }
        /// <summary>
        /// The email address for support inquiries for the vendor
        /// </summary>
        /// <value>The email address for support inquiries for the vendor</value>
        [DataMember(Name="support_email", EmitDefaultValue=false)]
        public string SupportEmail { get; set; }
        /// <summary>
        /// The date the vendor was last updated. Unix timestamp in seconds
        /// </summary>
        /// <value>The date the vendor was last updated. Unix timestamp in seconds</value>
        [DataMember(Name="update_date", EmitDefaultValue=false)]
        public long? UpdateDate { get; private set; }
        /// <summary>
        /// The url for the vendor&#39;s site
        /// </summary>
        /// <value>The url for the vendor&#39;s site</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VendorResource {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  ManualApproval: ").Append(ManualApproval).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PrimaryContactEmail: ").Append(PrimaryContactEmail).Append("\n");
            sb.Append("  PrimaryContactName: ").Append(PrimaryContactName).Append("\n");
            sb.Append("  PrimaryContactPhone: ").Append(PrimaryContactPhone).Append("\n");
            sb.Append("  SalesEmail: ").Append(SalesEmail).Append("\n");
            sb.Append("  SupportEmail: ").Append(SupportEmail).Append("\n");
            sb.Append("  UpdateDate: ").Append(UpdateDate).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(obj as VendorResource);
        }

        /// <summary>
        /// Returns true if VendorResource instances are equal
        /// </summary>
        /// <param name="other">Instance of VendorResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VendorResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
                ) && 
                (
                    this.CreateDate == other.CreateDate ||
                    this.CreateDate != null &&
                    this.CreateDate.Equals(other.CreateDate)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.ImageUrl == other.ImageUrl ||
                    this.ImageUrl != null &&
                    this.ImageUrl.Equals(other.ImageUrl)
                ) && 
                (
                    this.ManualApproval == other.ManualApproval ||
                    this.ManualApproval != null &&
                    this.ManualApproval.Equals(other.ManualApproval)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.PrimaryContactEmail == other.PrimaryContactEmail ||
                    this.PrimaryContactEmail != null &&
                    this.PrimaryContactEmail.Equals(other.PrimaryContactEmail)
                ) && 
                (
                    this.PrimaryContactName == other.PrimaryContactName ||
                    this.PrimaryContactName != null &&
                    this.PrimaryContactName.Equals(other.PrimaryContactName)
                ) && 
                (
                    this.PrimaryContactPhone == other.PrimaryContactPhone ||
                    this.PrimaryContactPhone != null &&
                    this.PrimaryContactPhone.Equals(other.PrimaryContactPhone)
                ) && 
                (
                    this.SalesEmail == other.SalesEmail ||
                    this.SalesEmail != null &&
                    this.SalesEmail.Equals(other.SalesEmail)
                ) && 
                (
                    this.SupportEmail == other.SupportEmail ||
                    this.SupportEmail != null &&
                    this.SupportEmail.Equals(other.SupportEmail)
                ) && 
                (
                    this.UpdateDate == other.UpdateDate ||
                    this.UpdateDate != null &&
                    this.UpdateDate.Equals(other.UpdateDate)
                ) && 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
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
                if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();
                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.ImageUrl != null)
                    hash = hash * 59 + this.ImageUrl.GetHashCode();
                if (this.ManualApproval != null)
                    hash = hash * 59 + this.ManualApproval.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.PrimaryContactEmail != null)
                    hash = hash * 59 + this.PrimaryContactEmail.GetHashCode();
                if (this.PrimaryContactName != null)
                    hash = hash * 59 + this.PrimaryContactName.GetHashCode();
                if (this.PrimaryContactPhone != null)
                    hash = hash * 59 + this.PrimaryContactPhone.GetHashCode();
                if (this.SalesEmail != null)
                    hash = hash * 59 + this.SalesEmail.GetHashCode();
                if (this.SupportEmail != null)
                    hash = hash * 59 + this.SupportEmail.GetHashCode();
                if (this.UpdateDate != null)
                    hash = hash * 59 + this.UpdateDate.GetHashCode();
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
