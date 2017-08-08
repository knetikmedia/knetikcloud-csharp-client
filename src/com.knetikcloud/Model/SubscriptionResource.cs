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
    /// SubscriptionResource
    /// </summary>
    [DataContract]
    public partial class SubscriptionResource :  IEquatable<SubscriptionResource>, IValidatableObject
    {
        /// <summary>
        /// Who can purchase this subscription
        /// </summary>
        /// <value>Who can purchase this subscription</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AvailabilityEnum
        {
            
            /// <summary>
            /// Enum All for "all"
            /// </summary>
            [EnumMember(Value = "all")]
            All,
            
            /// <summary>
            /// Enum Newsubscribers for "new_subscribers"
            /// </summary>
            [EnumMember(Value = "new_subscribers")]
            Newsubscribers
        }

        /// <summary>
        /// Whether to use the geo_country_list as a black list or white list for item geographical availability
        /// </summary>
        /// <value>Whether to use the geo_country_list as a black list or white list for item geographical availability</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GeoPolicyTypeEnum
        {
            
            /// <summary>
            /// Enum Whitelist for "whitelist"
            /// </summary>
            [EnumMember(Value = "whitelist")]
            Whitelist,
            
            /// <summary>
            /// Enum Blacklist for "blacklist"
            /// </summary>
            [EnumMember(Value = "blacklist")]
            Blacklist
        }

        /// <summary>
        /// Who can purchase this subscription
        /// </summary>
        /// <value>Who can purchase this subscription</value>
        [DataMember(Name="availability", EmitDefaultValue=false)]
        public AvailabilityEnum? Availability { get; set; }
        /// <summary>
        /// Whether to use the geo_country_list as a black list or white list for item geographical availability
        /// </summary>
        /// <value>Whether to use the geo_country_list as a black list or white list for item geographical availability</value>
        [DataMember(Name="geo_policy_type", EmitDefaultValue=false)]
        public GeoPolicyTypeEnum? GeoPolicyType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionResource" /> class.
        /// </summary>
        /// <param name="AdditionalProperties">A map of item additional properties, keyed on the property name. Must match the names and types defined in the template for this item type..</param>
        /// <param name="Availability">Who can purchase this subscription.</param>
        /// <param name="Category">A category for filtering items.</param>
        /// <param name="ConsolidationDayOfMonth">The day of the month 1..31 this subscription will renew.</param>
        /// <param name="GeoCountryList">A list of country iso3 codes to include in the blacklist/whitelist geo policy.</param>
        /// <param name="GeoPolicyType">Whether to use the geo_country_list as a black list or white list for item geographical availability.</param>
        /// <param name="LongDescription">A long description of the subscription.</param>
        /// <param name="Name">The name of the item (required).</param>
        /// <param name="Plans">The billing options for this subscription.</param>
        /// <param name="ShortDescription">A short description of the subscription.  Max 255 characters.</param>
        /// <param name="Sort">A number to use in sorting items.  Default 500.</param>
        /// <param name="StoreEnd">Used to schedule removal from store.  Null means the subscription will never be removed.</param>
        /// <param name="StoreStart">Used to schedule appearance in store.  Null means the subscription will appear now.</param>
        /// <param name="Tags">List of tags used for filtering items.</param>
        /// <param name="Template">An item template this item is validated against. May be null and no validation of additional properties will be done..</param>
        /// <param name="UniqueKey">The unique key for the item.</param>
        /// <param name="VendorId">The vendor who provides the item (required).</param>
        public SubscriptionResource(Dictionary<string, Property> AdditionalProperties = default(Dictionary<string, Property>), AvailabilityEnum? Availability = default(AvailabilityEnum?), string Category = default(string), int? ConsolidationDayOfMonth = default(int?), List<string> GeoCountryList = default(List<string>), GeoPolicyTypeEnum? GeoPolicyType = default(GeoPolicyTypeEnum?), string LongDescription = default(string), string Name = default(string), List<SubscriptionPlanResource> Plans = default(List<SubscriptionPlanResource>), string ShortDescription = default(string), int? Sort = default(int?), long? StoreEnd = default(long?), long? StoreStart = default(long?), List<string> Tags = default(List<string>), string Template = default(string), string UniqueKey = default(string), int? VendorId = default(int?))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for SubscriptionResource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "VendorId" is required (not null)
            if (VendorId == null)
            {
                throw new InvalidDataException("VendorId is a required property for SubscriptionResource and cannot be null");
            }
            else
            {
                this.VendorId = VendorId;
            }
            this.AdditionalProperties = AdditionalProperties;
            this.Availability = Availability;
            this.Category = Category;
            this.ConsolidationDayOfMonth = ConsolidationDayOfMonth;
            this.GeoCountryList = GeoCountryList;
            this.GeoPolicyType = GeoPolicyType;
            this.LongDescription = LongDescription;
            this.Plans = Plans;
            this.ShortDescription = ShortDescription;
            this.Sort = Sort;
            this.StoreEnd = StoreEnd;
            this.StoreStart = StoreStart;
            this.Tags = Tags;
            this.Template = Template;
            this.UniqueKey = UniqueKey;
        }
        
        /// <summary>
        /// A map of item additional properties, keyed on the property name. Must match the names and types defined in the template for this item type.
        /// </summary>
        /// <value>A map of item additional properties, keyed on the property name. Must match the names and types defined in the template for this item type.</value>
        [DataMember(Name="additional_properties", EmitDefaultValue=false)]
        public Dictionary<string, Property> AdditionalProperties { get; set; }


        /// <summary>
        /// A category for filtering items
        /// </summary>
        /// <value>A category for filtering items</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }

        /// <summary>
        /// The day of the month 1..31 this subscription will renew
        /// </summary>
        /// <value>The day of the month 1..31 this subscription will renew</value>
        [DataMember(Name="consolidation_day_of_month", EmitDefaultValue=false)]
        public int? ConsolidationDayOfMonth { get; set; }

        /// <summary>
        /// The date the item was created, unix timestamp in seconds
        /// </summary>
        /// <value>The date the item was created, unix timestamp in seconds</value>
        [DataMember(Name="created_date", EmitDefaultValue=false)]
        public long? CreatedDate { get; private set; }

        /// <summary>
        /// A list of country iso3 codes to include in the blacklist/whitelist geo policy
        /// </summary>
        /// <value>A list of country iso3 codes to include in the blacklist/whitelist geo policy</value>
        [DataMember(Name="geo_country_list", EmitDefaultValue=false)]
        public List<string> GeoCountryList { get; set; }


        /// <summary>
        /// The id of the item
        /// </summary>
        /// <value>The id of the item</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }

        /// <summary>
        /// A long description of the subscription
        /// </summary>
        /// <value>A long description of the subscription</value>
        [DataMember(Name="long_description", EmitDefaultValue=false)]
        public string LongDescription { get; set; }

        /// <summary>
        /// The name of the item
        /// </summary>
        /// <value>The name of the item</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The billing options for this subscription
        /// </summary>
        /// <value>The billing options for this subscription</value>
        [DataMember(Name="plans", EmitDefaultValue=false)]
        public List<SubscriptionPlanResource> Plans { get; set; }

        /// <summary>
        /// A short description of the subscription.  Max 255 characters
        /// </summary>
        /// <value>A short description of the subscription.  Max 255 characters</value>
        [DataMember(Name="short_description", EmitDefaultValue=false)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// A number to use in sorting items.  Default 500
        /// </summary>
        /// <value>A number to use in sorting items.  Default 500</value>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public int? Sort { get; set; }

        /// <summary>
        /// Used to schedule removal from store.  Null means the subscription will never be removed
        /// </summary>
        /// <value>Used to schedule removal from store.  Null means the subscription will never be removed</value>
        [DataMember(Name="store_end", EmitDefaultValue=false)]
        public long? StoreEnd { get; set; }

        /// <summary>
        /// Used to schedule appearance in store.  Null means the subscription will appear now
        /// </summary>
        /// <value>Used to schedule appearance in store.  Null means the subscription will appear now</value>
        [DataMember(Name="store_start", EmitDefaultValue=false)]
        public long? StoreStart { get; set; }

        /// <summary>
        /// List of tags used for filtering items
        /// </summary>
        /// <value>List of tags used for filtering items</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// An item template this item is validated against. May be null and no validation of additional properties will be done.
        /// </summary>
        /// <value>An item template this item is validated against. May be null and no validation of additional properties will be done.</value>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public string Template { get; set; }

        /// <summary>
        /// The unique key for the item
        /// </summary>
        /// <value>The unique key for the item</value>
        [DataMember(Name="unique_key", EmitDefaultValue=false)]
        public string UniqueKey { get; set; }

        /// <summary>
        /// The date the item was last updated
        /// </summary>
        /// <value>The date the item was last updated</value>
        [DataMember(Name="updated_date", EmitDefaultValue=false)]
        public long? UpdatedDate { get; private set; }

        /// <summary>
        /// The vendor who provides the item
        /// </summary>
        /// <value>The vendor who provides the item</value>
        [DataMember(Name="vendor_id", EmitDefaultValue=false)]
        public int? VendorId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionResource {\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("  Availability: ").Append(Availability).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  ConsolidationDayOfMonth: ").Append(ConsolidationDayOfMonth).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  GeoCountryList: ").Append(GeoCountryList).Append("\n");
            sb.Append("  GeoPolicyType: ").Append(GeoPolicyType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LongDescription: ").Append(LongDescription).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Plans: ").Append(Plans).Append("\n");
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  StoreEnd: ").Append(StoreEnd).Append("\n");
            sb.Append("  StoreStart: ").Append(StoreStart).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  UniqueKey: ").Append(UniqueKey).Append("\n");
            sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
            sb.Append("  VendorId: ").Append(VendorId).Append("\n");
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
            return this.Equals(input as SubscriptionResource);
        }

        /// <summary>
        /// Returns true if SubscriptionResource instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdditionalProperties == input.AdditionalProperties ||
                    (this.AdditionalProperties != null &&
                    this.AdditionalProperties.SequenceEqual(input.AdditionalProperties))
                ) && 
                (
                    this.Availability == input.Availability ||
                    (this.Availability != null &&
                    this.Availability.Equals(input.Availability))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.ConsolidationDayOfMonth == input.ConsolidationDayOfMonth ||
                    (this.ConsolidationDayOfMonth != null &&
                    this.ConsolidationDayOfMonth.Equals(input.ConsolidationDayOfMonth))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.GeoCountryList == input.GeoCountryList ||
                    (this.GeoCountryList != null &&
                    this.GeoCountryList.SequenceEqual(input.GeoCountryList))
                ) && 
                (
                    this.GeoPolicyType == input.GeoPolicyType ||
                    (this.GeoPolicyType != null &&
                    this.GeoPolicyType.Equals(input.GeoPolicyType))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                    this.Plans == input.Plans ||
                    (this.Plans != null &&
                    this.Plans.SequenceEqual(input.Plans))
                ) && 
                (
                    this.ShortDescription == input.ShortDescription ||
                    (this.ShortDescription != null &&
                    this.ShortDescription.Equals(input.ShortDescription))
                ) && 
                (
                    this.Sort == input.Sort ||
                    (this.Sort != null &&
                    this.Sort.Equals(input.Sort))
                ) && 
                (
                    this.StoreEnd == input.StoreEnd ||
                    (this.StoreEnd != null &&
                    this.StoreEnd.Equals(input.StoreEnd))
                ) && 
                (
                    this.StoreStart == input.StoreStart ||
                    (this.StoreStart != null &&
                    this.StoreStart.Equals(input.StoreStart))
                ) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags))
                ) && 
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
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
                ) && 
                (
                    this.VendorId == input.VendorId ||
                    (this.VendorId != null &&
                    this.VendorId.Equals(input.VendorId))
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
                if (this.AdditionalProperties != null)
                    hashCode = hashCode * 59 + this.AdditionalProperties.GetHashCode();
                if (this.Availability != null)
                    hashCode = hashCode * 59 + this.Availability.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.ConsolidationDayOfMonth != null)
                    hashCode = hashCode * 59 + this.ConsolidationDayOfMonth.GetHashCode();
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.GeoCountryList != null)
                    hashCode = hashCode * 59 + this.GeoCountryList.GetHashCode();
                if (this.GeoPolicyType != null)
                    hashCode = hashCode * 59 + this.GeoPolicyType.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LongDescription != null)
                    hashCode = hashCode * 59 + this.LongDescription.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Plans != null)
                    hashCode = hashCode * 59 + this.Plans.GetHashCode();
                if (this.ShortDescription != null)
                    hashCode = hashCode * 59 + this.ShortDescription.GetHashCode();
                if (this.Sort != null)
                    hashCode = hashCode * 59 + this.Sort.GetHashCode();
                if (this.StoreEnd != null)
                    hashCode = hashCode * 59 + this.StoreEnd.GetHashCode();
                if (this.StoreStart != null)
                    hashCode = hashCode * 59 + this.StoreStart.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Template != null)
                    hashCode = hashCode * 59 + this.Template.GetHashCode();
                if (this.UniqueKey != null)
                    hashCode = hashCode * 59 + this.UniqueKey.GetHashCode();
                if (this.UpdatedDate != null)
                    hashCode = hashCode * 59 + this.UpdatedDate.GetHashCode();
                if (this.VendorId != null)
                    hashCode = hashCode * 59 + this.VendorId.GetHashCode();
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
