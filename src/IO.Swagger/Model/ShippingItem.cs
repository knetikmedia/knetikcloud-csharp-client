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
    /// ShippingItem
    /// </summary>
    [DataContract]
    public partial class ShippingItem :  IEquatable<ShippingItem>, IValidatableObject
    {
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
        /// Whether to use the geo_country_list as a black list or white list for item geographical availability
        /// </summary>
        /// <value>Whether to use the geo_country_list as a black list or white list for item geographical availability</value>
        [DataMember(Name="geo_policy_type", EmitDefaultValue=false)]
        public GeoPolicyTypeEnum? GeoPolicyType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShippingItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingItem" /> class.
        /// </summary>
        /// <param name="AdditionalProperties">A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type, or be an extra not from the template.</param>
        /// <param name="Behaviors">The behaviors linked to the item, describing various options and interactions. May not be included in item lists.</param>
        /// <param name="Category">A category for filtering items.</param>
        /// <param name="Countries">A unique list of country iso3 codes that allow the shipping option.</param>
        /// <param name="Displayable">Whether or not the item is currently displayable.  Default &#x3D; true.</param>
        /// <param name="GeoCountryList">A list of country ID to include in the blacklist/whitelist geo policy.</param>
        /// <param name="GeoPolicyType">Whether to use the geo_country_list as a black list or white list for item geographical availability.</param>
        /// <param name="LongDescription">A long description of the item.</param>
        /// <param name="MaxTierTotal">An abstract max value that the values of item&#39;s shipping_tier work against to decide whether an order can be fulfilled (required).</param>
        /// <param name="Name">The name of the item (required).</param>
        /// <param name="ShippingTier">Provides the abstract shipping needs if this item is physical and can be shipped.  A value of zero means no shipping needed.  Default &#x3D; 0.</param>
        /// <param name="ShortDescription">A short description of the item, max 255 chars.</param>
        /// <param name="Skus">The skus for the item. Each defines a unique configuration for the item to be purchased (Large-Blue, Small-Green, etc). These are what is ultimately selected in the store and added to the cart (required).</param>
        /// <param name="Sort">A number to use in sorting items.  Default 500.</param>
        /// <param name="StoreEnd">The date the item will leave the store, unix timestamp in seconds.  If set to null, item will never leave the store.</param>
        /// <param name="StoreStart">The date the item will appear in the store, unix timestamp in seconds.  If set to null, item will appear in store immediately.</param>
        /// <param name="Tags">List of tags used for filtering items.</param>
        /// <param name="Taxable">Whether tax should be applied to the shipping price.  Default &#x3D; false.</param>
        /// <param name="Template">An item template this item is validated against.  May be null and no validation of additional_properties will be done.  Default &#x3D; null.</param>
        /// <param name="TypeHint">The type of the item (required).</param>
        /// <param name="UniqueKey">The unique key for the item.</param>
        /// <param name="VendorId">The vendor who provides the item (required).</param>
        public ShippingItem(Dictionary<string, Property> AdditionalProperties = null, List<Behavior> Behaviors = null, string Category = null, List<string> Countries = null, bool? Displayable = null, List<string> GeoCountryList = null, GeoPolicyTypeEnum? GeoPolicyType = null, string LongDescription = null, int? MaxTierTotal = null, string Name = null, int? ShippingTier = null, string ShortDescription = null, List<Sku> Skus = null, int? Sort = null, long? StoreEnd = null, long? StoreStart = null, List<string> Tags = null, bool? Taxable = null, string Template = null, string TypeHint = null, string UniqueKey = null, int? VendorId = null)
        {
            // to ensure "MaxTierTotal" is required (not null)
            if (MaxTierTotal == null)
            {
                throw new InvalidDataException("MaxTierTotal is a required property for ShippingItem and cannot be null");
            }
            else
            {
                this.MaxTierTotal = MaxTierTotal;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for ShippingItem and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Skus" is required (not null)
            if (Skus == null)
            {
                throw new InvalidDataException("Skus is a required property for ShippingItem and cannot be null");
            }
            else
            {
                this.Skus = Skus;
            }
            // to ensure "TypeHint" is required (not null)
            if (TypeHint == null)
            {
                throw new InvalidDataException("TypeHint is a required property for ShippingItem and cannot be null");
            }
            else
            {
                this.TypeHint = TypeHint;
            }
            // to ensure "VendorId" is required (not null)
            if (VendorId == null)
            {
                throw new InvalidDataException("VendorId is a required property for ShippingItem and cannot be null");
            }
            else
            {
                this.VendorId = VendorId;
            }
            this.AdditionalProperties = AdditionalProperties;
            this.Behaviors = Behaviors;
            this.Category = Category;
            this.Countries = Countries;
            this.Displayable = Displayable;
            this.GeoCountryList = GeoCountryList;
            this.GeoPolicyType = GeoPolicyType;
            this.LongDescription = LongDescription;
            this.ShippingTier = ShippingTier;
            this.ShortDescription = ShortDescription;
            this.Sort = Sort;
            this.StoreEnd = StoreEnd;
            this.StoreStart = StoreStart;
            this.Tags = Tags;
            this.Taxable = Taxable;
            this.Template = Template;
            this.UniqueKey = UniqueKey;
        }
        
        /// <summary>
        /// A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type, or be an extra not from the template
        /// </summary>
        /// <value>A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type, or be an extra not from the template</value>
        [DataMember(Name="additional_properties", EmitDefaultValue=false)]
        public Dictionary<string, Property> AdditionalProperties { get; set; }
        /// <summary>
        /// The behaviors linked to the item, describing various options and interactions. May not be included in item lists
        /// </summary>
        /// <value>The behaviors linked to the item, describing various options and interactions. May not be included in item lists</value>
        [DataMember(Name="behaviors", EmitDefaultValue=false)]
        public List<Behavior> Behaviors { get; set; }
        /// <summary>
        /// A category for filtering items
        /// </summary>
        /// <value>A category for filtering items</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }
        /// <summary>
        /// A unique list of country iso3 codes that allow the shipping option
        /// </summary>
        /// <value>A unique list of country iso3 codes that allow the shipping option</value>
        [DataMember(Name="countries", EmitDefaultValue=false)]
        public List<string> Countries { get; set; }
        /// <summary>
        /// The date the item was created, unix timestamp in seconds
        /// </summary>
        /// <value>The date the item was created, unix timestamp in seconds</value>
        [DataMember(Name="created_date", EmitDefaultValue=false)]
        public long? CreatedDate { get; private set; }
        /// <summary>
        /// Whether or not the item is currently displayable.  Default &#x3D; true
        /// </summary>
        /// <value>Whether or not the item is currently displayable.  Default &#x3D; true</value>
        [DataMember(Name="displayable", EmitDefaultValue=false)]
        public bool? Displayable { get; set; }
        /// <summary>
        /// A list of country ID to include in the blacklist/whitelist geo policy
        /// </summary>
        /// <value>A list of country ID to include in the blacklist/whitelist geo policy</value>
        [DataMember(Name="geo_country_list", EmitDefaultValue=false)]
        public List<string> GeoCountryList { get; set; }
        /// <summary>
        /// The id of the item
        /// </summary>
        /// <value>The id of the item</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
        /// <summary>
        /// A long description of the item
        /// </summary>
        /// <value>A long description of the item</value>
        [DataMember(Name="long_description", EmitDefaultValue=false)]
        public string LongDescription { get; set; }
        /// <summary>
        /// An abstract max value that the values of item&#39;s shipping_tier work against to decide whether an order can be fulfilled
        /// </summary>
        /// <value>An abstract max value that the values of item&#39;s shipping_tier work against to decide whether an order can be fulfilled</value>
        [DataMember(Name="max_tier_total", EmitDefaultValue=false)]
        public int? MaxTierTotal { get; set; }
        /// <summary>
        /// The name of the item
        /// </summary>
        /// <value>The name of the item</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Provides the abstract shipping needs if this item is physical and can be shipped.  A value of zero means no shipping needed.  Default &#x3D; 0
        /// </summary>
        /// <value>Provides the abstract shipping needs if this item is physical and can be shipped.  A value of zero means no shipping needed.  Default &#x3D; 0</value>
        [DataMember(Name="shipping_tier", EmitDefaultValue=false)]
        public int? ShippingTier { get; set; }
        /// <summary>
        /// A short description of the item, max 255 chars
        /// </summary>
        /// <value>A short description of the item, max 255 chars</value>
        [DataMember(Name="short_description", EmitDefaultValue=false)]
        public string ShortDescription { get; set; }
        /// <summary>
        /// The skus for the item. Each defines a unique configuration for the item to be purchased (Large-Blue, Small-Green, etc). These are what is ultimately selected in the store and added to the cart
        /// </summary>
        /// <value>The skus for the item. Each defines a unique configuration for the item to be purchased (Large-Blue, Small-Green, etc). These are what is ultimately selected in the store and added to the cart</value>
        [DataMember(Name="skus", EmitDefaultValue=false)]
        public List<Sku> Skus { get; set; }
        /// <summary>
        /// A number to use in sorting items.  Default 500
        /// </summary>
        /// <value>A number to use in sorting items.  Default 500</value>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public int? Sort { get; set; }
        /// <summary>
        /// The date the item will leave the store, unix timestamp in seconds.  If set to null, item will never leave the store
        /// </summary>
        /// <value>The date the item will leave the store, unix timestamp in seconds.  If set to null, item will never leave the store</value>
        [DataMember(Name="store_end", EmitDefaultValue=false)]
        public long? StoreEnd { get; set; }
        /// <summary>
        /// The date the item will appear in the store, unix timestamp in seconds.  If set to null, item will appear in store immediately
        /// </summary>
        /// <value>The date the item will appear in the store, unix timestamp in seconds.  If set to null, item will appear in store immediately</value>
        [DataMember(Name="store_start", EmitDefaultValue=false)]
        public long? StoreStart { get; set; }
        /// <summary>
        /// List of tags used for filtering items
        /// </summary>
        /// <value>List of tags used for filtering items</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }
        /// <summary>
        /// Whether tax should be applied to the shipping price.  Default &#x3D; false
        /// </summary>
        /// <value>Whether tax should be applied to the shipping price.  Default &#x3D; false</value>
        [DataMember(Name="taxable", EmitDefaultValue=false)]
        public bool? Taxable { get; set; }
        /// <summary>
        /// An item template this item is validated against.  May be null and no validation of additional_properties will be done.  Default &#x3D; null
        /// </summary>
        /// <value>An item template this item is validated against.  May be null and no validation of additional_properties will be done.  Default &#x3D; null</value>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public string Template { get; set; }
        /// <summary>
        /// The type of the item
        /// </summary>
        /// <value>The type of the item</value>
        [DataMember(Name="type_hint", EmitDefaultValue=false)]
        public string TypeHint { get; set; }
        /// <summary>
        /// The unique key for the item
        /// </summary>
        /// <value>The unique key for the item</value>
        [DataMember(Name="unique_key", EmitDefaultValue=false)]
        public string UniqueKey { get; set; }
        /// <summary>
        /// The date the item was last updated, unix timestamp in seconds
        /// </summary>
        /// <value>The date the item was last updated, unix timestamp in seconds</value>
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
            sb.Append("class ShippingItem {\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("  Behaviors: ").Append(Behaviors).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Countries: ").Append(Countries).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Displayable: ").Append(Displayable).Append("\n");
            sb.Append("  GeoCountryList: ").Append(GeoCountryList).Append("\n");
            sb.Append("  GeoPolicyType: ").Append(GeoPolicyType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LongDescription: ").Append(LongDescription).Append("\n");
            sb.Append("  MaxTierTotal: ").Append(MaxTierTotal).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ShippingTier: ").Append(ShippingTier).Append("\n");
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
            sb.Append("  Skus: ").Append(Skus).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  StoreEnd: ").Append(StoreEnd).Append("\n");
            sb.Append("  StoreStart: ").Append(StoreStart).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Taxable: ").Append(Taxable).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  TypeHint: ").Append(TypeHint).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ShippingItem);
        }

        /// <summary>
        /// Returns true if ShippingItem instances are equal
        /// </summary>
        /// <param name="other">Instance of ShippingItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShippingItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
                ) && 
                (
                    this.Behaviors == other.Behaviors ||
                    this.Behaviors != null &&
                    this.Behaviors.SequenceEqual(other.Behaviors)
                ) && 
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) && 
                (
                    this.Countries == other.Countries ||
                    this.Countries != null &&
                    this.Countries.SequenceEqual(other.Countries)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.Displayable == other.Displayable ||
                    this.Displayable != null &&
                    this.Displayable.Equals(other.Displayable)
                ) && 
                (
                    this.GeoCountryList == other.GeoCountryList ||
                    this.GeoCountryList != null &&
                    this.GeoCountryList.SequenceEqual(other.GeoCountryList)
                ) && 
                (
                    this.GeoPolicyType == other.GeoPolicyType ||
                    this.GeoPolicyType != null &&
                    this.GeoPolicyType.Equals(other.GeoPolicyType)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.LongDescription == other.LongDescription ||
                    this.LongDescription != null &&
                    this.LongDescription.Equals(other.LongDescription)
                ) && 
                (
                    this.MaxTierTotal == other.MaxTierTotal ||
                    this.MaxTierTotal != null &&
                    this.MaxTierTotal.Equals(other.MaxTierTotal)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.ShippingTier == other.ShippingTier ||
                    this.ShippingTier != null &&
                    this.ShippingTier.Equals(other.ShippingTier)
                ) && 
                (
                    this.ShortDescription == other.ShortDescription ||
                    this.ShortDescription != null &&
                    this.ShortDescription.Equals(other.ShortDescription)
                ) && 
                (
                    this.Skus == other.Skus ||
                    this.Skus != null &&
                    this.Skus.SequenceEqual(other.Skus)
                ) && 
                (
                    this.Sort == other.Sort ||
                    this.Sort != null &&
                    this.Sort.Equals(other.Sort)
                ) && 
                (
                    this.StoreEnd == other.StoreEnd ||
                    this.StoreEnd != null &&
                    this.StoreEnd.Equals(other.StoreEnd)
                ) && 
                (
                    this.StoreStart == other.StoreStart ||
                    this.StoreStart != null &&
                    this.StoreStart.Equals(other.StoreStart)
                ) && 
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(other.Tags)
                ) && 
                (
                    this.Taxable == other.Taxable ||
                    this.Taxable != null &&
                    this.Taxable.Equals(other.Taxable)
                ) && 
                (
                    this.Template == other.Template ||
                    this.Template != null &&
                    this.Template.Equals(other.Template)
                ) && 
                (
                    this.TypeHint == other.TypeHint ||
                    this.TypeHint != null &&
                    this.TypeHint.Equals(other.TypeHint)
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
                ) && 
                (
                    this.VendorId == other.VendorId ||
                    this.VendorId != null &&
                    this.VendorId.Equals(other.VendorId)
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
                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();
                if (this.Behaviors != null)
                    hash = hash * 59 + this.Behaviors.GetHashCode();
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                if (this.Countries != null)
                    hash = hash * 59 + this.Countries.GetHashCode();
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                if (this.Displayable != null)
                    hash = hash * 59 + this.Displayable.GetHashCode();
                if (this.GeoCountryList != null)
                    hash = hash * 59 + this.GeoCountryList.GetHashCode();
                if (this.GeoPolicyType != null)
                    hash = hash * 59 + this.GeoPolicyType.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.LongDescription != null)
                    hash = hash * 59 + this.LongDescription.GetHashCode();
                if (this.MaxTierTotal != null)
                    hash = hash * 59 + this.MaxTierTotal.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.ShippingTier != null)
                    hash = hash * 59 + this.ShippingTier.GetHashCode();
                if (this.ShortDescription != null)
                    hash = hash * 59 + this.ShortDescription.GetHashCode();
                if (this.Skus != null)
                    hash = hash * 59 + this.Skus.GetHashCode();
                if (this.Sort != null)
                    hash = hash * 59 + this.Sort.GetHashCode();
                if (this.StoreEnd != null)
                    hash = hash * 59 + this.StoreEnd.GetHashCode();
                if (this.StoreStart != null)
                    hash = hash * 59 + this.StoreStart.GetHashCode();
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
                if (this.Taxable != null)
                    hash = hash * 59 + this.Taxable.GetHashCode();
                if (this.Template != null)
                    hash = hash * 59 + this.Template.GetHashCode();
                if (this.TypeHint != null)
                    hash = hash * 59 + this.TypeHint.GetHashCode();
                if (this.UniqueKey != null)
                    hash = hash * 59 + this.UniqueKey.GetHashCode();
                if (this.UpdatedDate != null)
                    hash = hash * 59 + this.UpdatedDate.GetHashCode();
                if (this.VendorId != null)
                    hash = hash * 59 + this.VendorId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
