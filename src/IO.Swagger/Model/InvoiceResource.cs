/* 
 * Knetik Platform API Documentation latest 
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://knetikcloud.com
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
    /// InvoiceResource
    /// </summary>
    [DataContract]
    public partial class InvoiceResource :  IEquatable<InvoiceResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceResource" /> class.
        /// </summary>
        /// <param name="BillingAddress1">Line one of the customer&#39;s billing address.</param>
        /// <param name="BillingAddress2">Line two of the customer&#39;s billing address.</param>
        /// <param name="BillingCityName">The city for the customer&#39;s billing address.</param>
        /// <param name="BillingCountryName">The country for the customer&#39;s billing address.</param>
        /// <param name="BillingFullName">The customer&#39;s name for the billing address.</param>
        /// <param name="BillingPostalCode">The postal code for the customer&#39;s billing address.</param>
        /// <param name="BillingStateName">The state for the customer&#39;s billing address.</param>
        /// <param name="CartId">The guid of the cart this invoice came from.</param>
        /// <param name="Currency">The code for the currency invoice prices are in.</param>
        /// <param name="CurrentFulfillmentStatus">The fulfillment status of the invoice.</param>
        /// <param name="CurrentPaymentStatus">The payment status of the invoice.</param>
        /// <param name="Discount">The amount of money saved through coupons.</param>
        /// <param name="Email">The customer&#39;s email address.</param>
        /// <param name="ExternalRef">An external reference to filter on.</param>
        /// <param name="FedTax">The amount of federal tax added.</param>
        /// <param name="GrandTotal">The final price of the invoice.</param>
        /// <param name="InvoiceNumber">A reference number for the invoice.</param>
        /// <param name="Items">A list of items within the invoice.</param>
        /// <param name="NamePrefix">The customer&#39;s name prefix.</param>
        /// <param name="OrderNotes">Notes about the order.</param>
        /// <param name="ParentInvoiceId">The id of an invoice this is a child of.</param>
        /// <param name="PaymentMethodId">The id of a saved payment method used to pay for the invoice.</param>
        /// <param name="Phone">The customer&#39;s phone number.</param>
        /// <param name="PhoneNumber">The customer&#39;s phone number.</param>
        /// <param name="Shipping">The shipping cost.</param>
        /// <param name="ShippingAddress1">Line one of the customer&#39;s shipping address.</param>
        /// <param name="ShippingAddress2">Line two of the customer&#39;s shipping address.</param>
        /// <param name="ShippingCityName">The city for the customer&#39;s shipping address.</param>
        /// <param name="ShippingCountryName">The country for the customer&#39;s shipping address.</param>
        /// <param name="ShippingFullName">The customer&#39;s name for the shipping address.</param>
        /// <param name="ShippingPostalCode">The postal code for the customer&#39;s shipping address.</param>
        /// <param name="ShippingStateName">The state for the customer&#39;s shipping address.</param>
        /// <param name="Sort">A number to use in sorting items. default 500..</param>
        /// <param name="StateTax">The amount of state tax added.</param>
        /// <param name="Subtotal">The sum price of all items before shipping, coupons and tax.</param>
        /// <param name="User">The owner of the invoice.</param>
        /// <param name="VendorId">The id of the vendor.</param>
        /// <param name="VendorName">The name of the invoice.</param>
        public InvoiceResource(string BillingAddress1 = default(string), string BillingAddress2 = default(string), string BillingCityName = default(string), string BillingCountryName = default(string), string BillingFullName = default(string), string BillingPostalCode = default(string), string BillingStateName = default(string), string CartId = default(string), string Currency = default(string), string CurrentFulfillmentStatus = default(string), string CurrentPaymentStatus = default(string), double? Discount = default(double?), string Email = default(string), string ExternalRef = default(string), double? FedTax = default(double?), double? GrandTotal = default(double?), string InvoiceNumber = default(string), List<InvoiceItemResource> Items = default(List<InvoiceItemResource>), string NamePrefix = default(string), string OrderNotes = default(string), int? ParentInvoiceId = default(int?), int? PaymentMethodId = default(int?), string Phone = default(string), string PhoneNumber = default(string), double? Shipping = default(double?), string ShippingAddress1 = default(string), string ShippingAddress2 = default(string), string ShippingCityName = default(string), string ShippingCountryName = default(string), string ShippingFullName = default(string), string ShippingPostalCode = default(string), string ShippingStateName = default(string), int? Sort = default(int?), double? StateTax = default(double?), double? Subtotal = default(double?), SimpleUserResource User = default(SimpleUserResource), int? VendorId = default(int?), string VendorName = default(string))
        {
            this.BillingAddress1 = BillingAddress1;
            this.BillingAddress2 = BillingAddress2;
            this.BillingCityName = BillingCityName;
            this.BillingCountryName = BillingCountryName;
            this.BillingFullName = BillingFullName;
            this.BillingPostalCode = BillingPostalCode;
            this.BillingStateName = BillingStateName;
            this.CartId = CartId;
            this.Currency = Currency;
            this.CurrentFulfillmentStatus = CurrentFulfillmentStatus;
            this.CurrentPaymentStatus = CurrentPaymentStatus;
            this.Discount = Discount;
            this.Email = Email;
            this.ExternalRef = ExternalRef;
            this.FedTax = FedTax;
            this.GrandTotal = GrandTotal;
            this.InvoiceNumber = InvoiceNumber;
            this.Items = Items;
            this.NamePrefix = NamePrefix;
            this.OrderNotes = OrderNotes;
            this.ParentInvoiceId = ParentInvoiceId;
            this.PaymentMethodId = PaymentMethodId;
            this.Phone = Phone;
            this.PhoneNumber = PhoneNumber;
            this.Shipping = Shipping;
            this.ShippingAddress1 = ShippingAddress1;
            this.ShippingAddress2 = ShippingAddress2;
            this.ShippingCityName = ShippingCityName;
            this.ShippingCountryName = ShippingCountryName;
            this.ShippingFullName = ShippingFullName;
            this.ShippingPostalCode = ShippingPostalCode;
            this.ShippingStateName = ShippingStateName;
            this.Sort = Sort;
            this.StateTax = StateTax;
            this.Subtotal = Subtotal;
            this.User = User;
            this.VendorId = VendorId;
            this.VendorName = VendorName;
        }
        
        /// <summary>
        /// Line one of the customer&#39;s billing address
        /// </summary>
        /// <value>Line one of the customer&#39;s billing address</value>
        [DataMember(Name="billing_address1", EmitDefaultValue=false)]
        public string BillingAddress1 { get; set; }
        /// <summary>
        /// Line two of the customer&#39;s billing address
        /// </summary>
        /// <value>Line two of the customer&#39;s billing address</value>
        [DataMember(Name="billing_address2", EmitDefaultValue=false)]
        public string BillingAddress2 { get; set; }
        /// <summary>
        /// The city for the customer&#39;s billing address
        /// </summary>
        /// <value>The city for the customer&#39;s billing address</value>
        [DataMember(Name="billing_city_name", EmitDefaultValue=false)]
        public string BillingCityName { get; set; }
        /// <summary>
        /// The country for the customer&#39;s billing address
        /// </summary>
        /// <value>The country for the customer&#39;s billing address</value>
        [DataMember(Name="billing_country_name", EmitDefaultValue=false)]
        public string BillingCountryName { get; set; }
        /// <summary>
        /// The customer&#39;s name for the billing address
        /// </summary>
        /// <value>The customer&#39;s name for the billing address</value>
        [DataMember(Name="billing_full_name", EmitDefaultValue=false)]
        public string BillingFullName { get; set; }
        /// <summary>
        /// The postal code for the customer&#39;s billing address
        /// </summary>
        /// <value>The postal code for the customer&#39;s billing address</value>
        [DataMember(Name="billing_postal_code", EmitDefaultValue=false)]
        public string BillingPostalCode { get; set; }
        /// <summary>
        /// The state for the customer&#39;s billing address
        /// </summary>
        /// <value>The state for the customer&#39;s billing address</value>
        [DataMember(Name="billing_state_name", EmitDefaultValue=false)]
        public string BillingStateName { get; set; }
        /// <summary>
        /// The guid of the cart this invoice came from
        /// </summary>
        /// <value>The guid of the cart this invoice came from</value>
        [DataMember(Name="cart_id", EmitDefaultValue=false)]
        public string CartId { get; set; }
        /// <summary>
        /// The date the invoice was created, unix timestamp in seconds
        /// </summary>
        /// <value>The date the invoice was created, unix timestamp in seconds</value>
        [DataMember(Name="created_date", EmitDefaultValue=false)]
        public long? CreatedDate { get; private set; }
        /// <summary>
        /// The code for the currency invoice prices are in
        /// </summary>
        /// <value>The code for the currency invoice prices are in</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }
        /// <summary>
        /// The fulfillment status of the invoice
        /// </summary>
        /// <value>The fulfillment status of the invoice</value>
        [DataMember(Name="current_fulfillment_status", EmitDefaultValue=false)]
        public string CurrentFulfillmentStatus { get; set; }
        /// <summary>
        /// The payment status of the invoice
        /// </summary>
        /// <value>The payment status of the invoice</value>
        [DataMember(Name="current_payment_status", EmitDefaultValue=false)]
        public string CurrentPaymentStatus { get; set; }
        /// <summary>
        /// The amount of money saved through coupons
        /// </summary>
        /// <value>The amount of money saved through coupons</value>
        [DataMember(Name="discount", EmitDefaultValue=false)]
        public double? Discount { get; set; }
        /// <summary>
        /// The customer&#39;s email address
        /// </summary>
        /// <value>The customer&#39;s email address</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// An external reference to filter on
        /// </summary>
        /// <value>An external reference to filter on</value>
        [DataMember(Name="external_ref", EmitDefaultValue=false)]
        public string ExternalRef { get; set; }
        /// <summary>
        /// The amount of federal tax added
        /// </summary>
        /// <value>The amount of federal tax added</value>
        [DataMember(Name="fed_tax", EmitDefaultValue=false)]
        public double? FedTax { get; set; }
        /// <summary>
        /// The final price of the invoice
        /// </summary>
        /// <value>The final price of the invoice</value>
        [DataMember(Name="grand_total", EmitDefaultValue=false)]
        public double? GrandTotal { get; set; }
        /// <summary>
        /// The id of the invoice
        /// </summary>
        /// <value>The id of the invoice</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
        /// <summary>
        /// A reference number for the invoice
        /// </summary>
        /// <value>A reference number for the invoice</value>
        [DataMember(Name="invoice_number", EmitDefaultValue=false)]
        public string InvoiceNumber { get; set; }
        /// <summary>
        /// A list of items within the invoice
        /// </summary>
        /// <value>A list of items within the invoice</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<InvoiceItemResource> Items { get; set; }
        /// <summary>
        /// The customer&#39;s name prefix
        /// </summary>
        /// <value>The customer&#39;s name prefix</value>
        [DataMember(Name="name_prefix", EmitDefaultValue=false)]
        public string NamePrefix { get; set; }
        /// <summary>
        /// Notes about the order
        /// </summary>
        /// <value>Notes about the order</value>
        [DataMember(Name="order_notes", EmitDefaultValue=false)]
        public string OrderNotes { get; set; }
        /// <summary>
        /// The id of an invoice this is a child of
        /// </summary>
        /// <value>The id of an invoice this is a child of</value>
        [DataMember(Name="parent_invoice_id", EmitDefaultValue=false)]
        public int? ParentInvoiceId { get; set; }
        /// <summary>
        /// The id of a saved payment method used to pay for the invoice
        /// </summary>
        /// <value>The id of a saved payment method used to pay for the invoice</value>
        [DataMember(Name="payment_method_id", EmitDefaultValue=false)]
        public int? PaymentMethodId { get; set; }
        /// <summary>
        /// The customer&#39;s phone number
        /// </summary>
        /// <value>The customer&#39;s phone number</value>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }
        /// <summary>
        /// The customer&#39;s phone number
        /// </summary>
        /// <value>The customer&#39;s phone number</value>
        [DataMember(Name="phone_number", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
        /// <summary>
        /// The shipping cost
        /// </summary>
        /// <value>The shipping cost</value>
        [DataMember(Name="shipping", EmitDefaultValue=false)]
        public double? Shipping { get; set; }
        /// <summary>
        /// Line one of the customer&#39;s shipping address
        /// </summary>
        /// <value>Line one of the customer&#39;s shipping address</value>
        [DataMember(Name="shipping_address1", EmitDefaultValue=false)]
        public string ShippingAddress1 { get; set; }
        /// <summary>
        /// Line two of the customer&#39;s shipping address
        /// </summary>
        /// <value>Line two of the customer&#39;s shipping address</value>
        [DataMember(Name="shipping_address2", EmitDefaultValue=false)]
        public string ShippingAddress2 { get; set; }
        /// <summary>
        /// The city for the customer&#39;s shipping address
        /// </summary>
        /// <value>The city for the customer&#39;s shipping address</value>
        [DataMember(Name="shipping_city_name", EmitDefaultValue=false)]
        public string ShippingCityName { get; set; }
        /// <summary>
        /// The country for the customer&#39;s shipping address
        /// </summary>
        /// <value>The country for the customer&#39;s shipping address</value>
        [DataMember(Name="shipping_country_name", EmitDefaultValue=false)]
        public string ShippingCountryName { get; set; }
        /// <summary>
        /// The customer&#39;s name for the shipping address
        /// </summary>
        /// <value>The customer&#39;s name for the shipping address</value>
        [DataMember(Name="shipping_full_name", EmitDefaultValue=false)]
        public string ShippingFullName { get; set; }
        /// <summary>
        /// The postal code for the customer&#39;s shipping address
        /// </summary>
        /// <value>The postal code for the customer&#39;s shipping address</value>
        [DataMember(Name="shipping_postal_code", EmitDefaultValue=false)]
        public string ShippingPostalCode { get; set; }
        /// <summary>
        /// The state for the customer&#39;s shipping address
        /// </summary>
        /// <value>The state for the customer&#39;s shipping address</value>
        [DataMember(Name="shipping_state_name", EmitDefaultValue=false)]
        public string ShippingStateName { get; set; }
        /// <summary>
        /// A number to use in sorting items. default 500.
        /// </summary>
        /// <value>A number to use in sorting items. default 500.</value>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public int? Sort { get; set; }
        /// <summary>
        /// The amount of state tax added
        /// </summary>
        /// <value>The amount of state tax added</value>
        [DataMember(Name="state_tax", EmitDefaultValue=false)]
        public double? StateTax { get; set; }
        /// <summary>
        /// The sum price of all items before shipping, coupons and tax
        /// </summary>
        /// <value>The sum price of all items before shipping, coupons and tax</value>
        [DataMember(Name="subtotal", EmitDefaultValue=false)]
        public double? Subtotal { get; set; }
        /// <summary>
        /// The date the invoice was last updated, unix timestamp in seconds
        /// </summary>
        /// <value>The date the invoice was last updated, unix timestamp in seconds</value>
        [DataMember(Name="updated_date", EmitDefaultValue=false)]
        public long? UpdatedDate { get; private set; }
        /// <summary>
        /// The owner of the invoice
        /// </summary>
        /// <value>The owner of the invoice</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public SimpleUserResource User { get; set; }
        /// <summary>
        /// The id of the vendor
        /// </summary>
        /// <value>The id of the vendor</value>
        [DataMember(Name="vendor_id", EmitDefaultValue=false)]
        public int? VendorId { get; set; }
        /// <summary>
        /// The name of the invoice
        /// </summary>
        /// <value>The name of the invoice</value>
        [DataMember(Name="vendor_name", EmitDefaultValue=false)]
        public string VendorName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvoiceResource {\n");
            sb.Append("  BillingAddress1: ").Append(BillingAddress1).Append("\n");
            sb.Append("  BillingAddress2: ").Append(BillingAddress2).Append("\n");
            sb.Append("  BillingCityName: ").Append(BillingCityName).Append("\n");
            sb.Append("  BillingCountryName: ").Append(BillingCountryName).Append("\n");
            sb.Append("  BillingFullName: ").Append(BillingFullName).Append("\n");
            sb.Append("  BillingPostalCode: ").Append(BillingPostalCode).Append("\n");
            sb.Append("  BillingStateName: ").Append(BillingStateName).Append("\n");
            sb.Append("  CartId: ").Append(CartId).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  CurrentFulfillmentStatus: ").Append(CurrentFulfillmentStatus).Append("\n");
            sb.Append("  CurrentPaymentStatus: ").Append(CurrentPaymentStatus).Append("\n");
            sb.Append("  Discount: ").Append(Discount).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  ExternalRef: ").Append(ExternalRef).Append("\n");
            sb.Append("  FedTax: ").Append(FedTax).Append("\n");
            sb.Append("  GrandTotal: ").Append(GrandTotal).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  NamePrefix: ").Append(NamePrefix).Append("\n");
            sb.Append("  OrderNotes: ").Append(OrderNotes).Append("\n");
            sb.Append("  ParentInvoiceId: ").Append(ParentInvoiceId).Append("\n");
            sb.Append("  PaymentMethodId: ").Append(PaymentMethodId).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Shipping: ").Append(Shipping).Append("\n");
            sb.Append("  ShippingAddress1: ").Append(ShippingAddress1).Append("\n");
            sb.Append("  ShippingAddress2: ").Append(ShippingAddress2).Append("\n");
            sb.Append("  ShippingCityName: ").Append(ShippingCityName).Append("\n");
            sb.Append("  ShippingCountryName: ").Append(ShippingCountryName).Append("\n");
            sb.Append("  ShippingFullName: ").Append(ShippingFullName).Append("\n");
            sb.Append("  ShippingPostalCode: ").Append(ShippingPostalCode).Append("\n");
            sb.Append("  ShippingStateName: ").Append(ShippingStateName).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  StateTax: ").Append(StateTax).Append("\n");
            sb.Append("  Subtotal: ").Append(Subtotal).Append("\n");
            sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  VendorId: ").Append(VendorId).Append("\n");
            sb.Append("  VendorName: ").Append(VendorName).Append("\n");
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
            return this.Equals(obj as InvoiceResource);
        }

        /// <summary>
        /// Returns true if InvoiceResource instances are equal
        /// </summary>
        /// <param name="other">Instance of InvoiceResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BillingAddress1 == other.BillingAddress1 ||
                    this.BillingAddress1 != null &&
                    this.BillingAddress1.Equals(other.BillingAddress1)
                ) && 
                (
                    this.BillingAddress2 == other.BillingAddress2 ||
                    this.BillingAddress2 != null &&
                    this.BillingAddress2.Equals(other.BillingAddress2)
                ) && 
                (
                    this.BillingCityName == other.BillingCityName ||
                    this.BillingCityName != null &&
                    this.BillingCityName.Equals(other.BillingCityName)
                ) && 
                (
                    this.BillingCountryName == other.BillingCountryName ||
                    this.BillingCountryName != null &&
                    this.BillingCountryName.Equals(other.BillingCountryName)
                ) && 
                (
                    this.BillingFullName == other.BillingFullName ||
                    this.BillingFullName != null &&
                    this.BillingFullName.Equals(other.BillingFullName)
                ) && 
                (
                    this.BillingPostalCode == other.BillingPostalCode ||
                    this.BillingPostalCode != null &&
                    this.BillingPostalCode.Equals(other.BillingPostalCode)
                ) && 
                (
                    this.BillingStateName == other.BillingStateName ||
                    this.BillingStateName != null &&
                    this.BillingStateName.Equals(other.BillingStateName)
                ) && 
                (
                    this.CartId == other.CartId ||
                    this.CartId != null &&
                    this.CartId.Equals(other.CartId)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
                (
                    this.CurrentFulfillmentStatus == other.CurrentFulfillmentStatus ||
                    this.CurrentFulfillmentStatus != null &&
                    this.CurrentFulfillmentStatus.Equals(other.CurrentFulfillmentStatus)
                ) && 
                (
                    this.CurrentPaymentStatus == other.CurrentPaymentStatus ||
                    this.CurrentPaymentStatus != null &&
                    this.CurrentPaymentStatus.Equals(other.CurrentPaymentStatus)
                ) && 
                (
                    this.Discount == other.Discount ||
                    this.Discount != null &&
                    this.Discount.Equals(other.Discount)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.ExternalRef == other.ExternalRef ||
                    this.ExternalRef != null &&
                    this.ExternalRef.Equals(other.ExternalRef)
                ) && 
                (
                    this.FedTax == other.FedTax ||
                    this.FedTax != null &&
                    this.FedTax.Equals(other.FedTax)
                ) && 
                (
                    this.GrandTotal == other.GrandTotal ||
                    this.GrandTotal != null &&
                    this.GrandTotal.Equals(other.GrandTotal)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.InvoiceNumber == other.InvoiceNumber ||
                    this.InvoiceNumber != null &&
                    this.InvoiceNumber.Equals(other.InvoiceNumber)
                ) && 
                (
                    this.Items == other.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(other.Items)
                ) && 
                (
                    this.NamePrefix == other.NamePrefix ||
                    this.NamePrefix != null &&
                    this.NamePrefix.Equals(other.NamePrefix)
                ) && 
                (
                    this.OrderNotes == other.OrderNotes ||
                    this.OrderNotes != null &&
                    this.OrderNotes.Equals(other.OrderNotes)
                ) && 
                (
                    this.ParentInvoiceId == other.ParentInvoiceId ||
                    this.ParentInvoiceId != null &&
                    this.ParentInvoiceId.Equals(other.ParentInvoiceId)
                ) && 
                (
                    this.PaymentMethodId == other.PaymentMethodId ||
                    this.PaymentMethodId != null &&
                    this.PaymentMethodId.Equals(other.PaymentMethodId)
                ) && 
                (
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    this.Shipping == other.Shipping ||
                    this.Shipping != null &&
                    this.Shipping.Equals(other.Shipping)
                ) && 
                (
                    this.ShippingAddress1 == other.ShippingAddress1 ||
                    this.ShippingAddress1 != null &&
                    this.ShippingAddress1.Equals(other.ShippingAddress1)
                ) && 
                (
                    this.ShippingAddress2 == other.ShippingAddress2 ||
                    this.ShippingAddress2 != null &&
                    this.ShippingAddress2.Equals(other.ShippingAddress2)
                ) && 
                (
                    this.ShippingCityName == other.ShippingCityName ||
                    this.ShippingCityName != null &&
                    this.ShippingCityName.Equals(other.ShippingCityName)
                ) && 
                (
                    this.ShippingCountryName == other.ShippingCountryName ||
                    this.ShippingCountryName != null &&
                    this.ShippingCountryName.Equals(other.ShippingCountryName)
                ) && 
                (
                    this.ShippingFullName == other.ShippingFullName ||
                    this.ShippingFullName != null &&
                    this.ShippingFullName.Equals(other.ShippingFullName)
                ) && 
                (
                    this.ShippingPostalCode == other.ShippingPostalCode ||
                    this.ShippingPostalCode != null &&
                    this.ShippingPostalCode.Equals(other.ShippingPostalCode)
                ) && 
                (
                    this.ShippingStateName == other.ShippingStateName ||
                    this.ShippingStateName != null &&
                    this.ShippingStateName.Equals(other.ShippingStateName)
                ) && 
                (
                    this.Sort == other.Sort ||
                    this.Sort != null &&
                    this.Sort.Equals(other.Sort)
                ) && 
                (
                    this.StateTax == other.StateTax ||
                    this.StateTax != null &&
                    this.StateTax.Equals(other.StateTax)
                ) && 
                (
                    this.Subtotal == other.Subtotal ||
                    this.Subtotal != null &&
                    this.Subtotal.Equals(other.Subtotal)
                ) && 
                (
                    this.UpdatedDate == other.UpdatedDate ||
                    this.UpdatedDate != null &&
                    this.UpdatedDate.Equals(other.UpdatedDate)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) && 
                (
                    this.VendorId == other.VendorId ||
                    this.VendorId != null &&
                    this.VendorId.Equals(other.VendorId)
                ) && 
                (
                    this.VendorName == other.VendorName ||
                    this.VendorName != null &&
                    this.VendorName.Equals(other.VendorName)
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
                if (this.BillingAddress1 != null)
                    hash = hash * 59 + this.BillingAddress1.GetHashCode();
                if (this.BillingAddress2 != null)
                    hash = hash * 59 + this.BillingAddress2.GetHashCode();
                if (this.BillingCityName != null)
                    hash = hash * 59 + this.BillingCityName.GetHashCode();
                if (this.BillingCountryName != null)
                    hash = hash * 59 + this.BillingCountryName.GetHashCode();
                if (this.BillingFullName != null)
                    hash = hash * 59 + this.BillingFullName.GetHashCode();
                if (this.BillingPostalCode != null)
                    hash = hash * 59 + this.BillingPostalCode.GetHashCode();
                if (this.BillingStateName != null)
                    hash = hash * 59 + this.BillingStateName.GetHashCode();
                if (this.CartId != null)
                    hash = hash * 59 + this.CartId.GetHashCode();
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                if (this.CurrentFulfillmentStatus != null)
                    hash = hash * 59 + this.CurrentFulfillmentStatus.GetHashCode();
                if (this.CurrentPaymentStatus != null)
                    hash = hash * 59 + this.CurrentPaymentStatus.GetHashCode();
                if (this.Discount != null)
                    hash = hash * 59 + this.Discount.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.ExternalRef != null)
                    hash = hash * 59 + this.ExternalRef.GetHashCode();
                if (this.FedTax != null)
                    hash = hash * 59 + this.FedTax.GetHashCode();
                if (this.GrandTotal != null)
                    hash = hash * 59 + this.GrandTotal.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.InvoiceNumber != null)
                    hash = hash * 59 + this.InvoiceNumber.GetHashCode();
                if (this.Items != null)
                    hash = hash * 59 + this.Items.GetHashCode();
                if (this.NamePrefix != null)
                    hash = hash * 59 + this.NamePrefix.GetHashCode();
                if (this.OrderNotes != null)
                    hash = hash * 59 + this.OrderNotes.GetHashCode();
                if (this.ParentInvoiceId != null)
                    hash = hash * 59 + this.ParentInvoiceId.GetHashCode();
                if (this.PaymentMethodId != null)
                    hash = hash * 59 + this.PaymentMethodId.GetHashCode();
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                if (this.Shipping != null)
                    hash = hash * 59 + this.Shipping.GetHashCode();
                if (this.ShippingAddress1 != null)
                    hash = hash * 59 + this.ShippingAddress1.GetHashCode();
                if (this.ShippingAddress2 != null)
                    hash = hash * 59 + this.ShippingAddress2.GetHashCode();
                if (this.ShippingCityName != null)
                    hash = hash * 59 + this.ShippingCityName.GetHashCode();
                if (this.ShippingCountryName != null)
                    hash = hash * 59 + this.ShippingCountryName.GetHashCode();
                if (this.ShippingFullName != null)
                    hash = hash * 59 + this.ShippingFullName.GetHashCode();
                if (this.ShippingPostalCode != null)
                    hash = hash * 59 + this.ShippingPostalCode.GetHashCode();
                if (this.ShippingStateName != null)
                    hash = hash * 59 + this.ShippingStateName.GetHashCode();
                if (this.Sort != null)
                    hash = hash * 59 + this.Sort.GetHashCode();
                if (this.StateTax != null)
                    hash = hash * 59 + this.StateTax.GetHashCode();
                if (this.Subtotal != null)
                    hash = hash * 59 + this.Subtotal.GetHashCode();
                if (this.UpdatedDate != null)
                    hash = hash * 59 + this.UpdatedDate.GetHashCode();
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                if (this.VendorId != null)
                    hash = hash * 59 + this.VendorId.GetHashCode();
                if (this.VendorName != null)
                    hash = hash * 59 + this.VendorName.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
