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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using com.knetikcloud.Client;
using com.knetikcloud.Api;
using com.knetikcloud.Model;

namespace com.knetikcloud.Test
{
    /// <summary>
    ///  Class for testing InvoicesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class InvoicesApiTests
    {
        private InvoicesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new InvoicesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InvoicesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' InvoicesApi
            //Assert.IsInstanceOfType(typeof(InvoicesApi), instance, "instance is a InvoicesApi");
        }

        
        /// <summary>
        /// Test CreateInvoice
        /// </summary>
        [Test]
        public void CreateInvoiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InvoiceCreateRequest req = null;
            //var response = instance.CreateInvoice(req);
            //Assert.IsInstanceOf<List<InvoiceResource>> (response, "response is List<InvoiceResource>");
        }
        
        /// <summary>
        /// Test GetFulFillmentStatuses
        /// </summary>
        [Test]
        public void GetFulFillmentStatusesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetFulFillmentStatuses();
            //Assert.IsInstanceOf<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test GetInvoice
        /// </summary>
        [Test]
        public void GetInvoiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //var response = instance.GetInvoice(id);
            //Assert.IsInstanceOf<InvoiceResource> (response, "response is InvoiceResource");
        }
        
        /// <summary>
        /// Test GetInvoiceLogs
        /// </summary>
        [Test]
        public void GetInvoiceLogsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //int? size = null;
            //int? page = null;
            //var response = instance.GetInvoiceLogs(id, size, page);
            //Assert.IsInstanceOf<PageResourceInvoiceLogEntry> (response, "response is PageResourceInvoiceLogEntry");
        }
        
        /// <summary>
        /// Test GetInvoices
        /// </summary>
        [Test]
        public void GetInvoicesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? filterUser = null;
            //string filterEmail = null;
            //string filterFulfillmentStatus = null;
            //string filterPaymentStatus = null;
            //string filterItemName = null;
            //string filterExternalRef = null;
            //string filterCreatedDate = null;
            //string filterVendorIds = null;
            //string filterCurrency = null;
            //string filterShippingStateName = null;
            //string filterShippingCountryName = null;
            //float? filterShipping = null;
            //string filterVendorName = null;
            //string filterSku = null;
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetInvoices(filterUser, filterEmail, filterFulfillmentStatus, filterPaymentStatus, filterItemName, filterExternalRef, filterCreatedDate, filterVendorIds, filterCurrency, filterShippingStateName, filterShippingCountryName, filterShipping, filterVendorName, filterSku, size, page, order);
            //Assert.IsInstanceOf<PageResourceInvoiceResource> (response, "response is PageResourceInvoiceResource");
        }
        
        /// <summary>
        /// Test GetPaymentStatuses
        /// </summary>
        [Test]
        public void GetPaymentStatusesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetPaymentStatuses();
            //Assert.IsInstanceOf<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test PayInvoice
        /// </summary>
        [Test]
        public void PayInvoiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //PayBySavedMethodRequest request = null;
            //instance.PayInvoice(id, request);
            
        }
        
        /// <summary>
        /// Test SetExternalRef
        /// </summary>
        [Test]
        public void SetExternalRefTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //string externalRef = null;
            //instance.SetExternalRef(id, externalRef);
            
        }
        
        /// <summary>
        /// Test SetInvoiceItemFulfillmentStatus
        /// </summary>
        [Test]
        public void SetInvoiceItemFulfillmentStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //string sku = null;
            //string status = null;
            //instance.SetInvoiceItemFulfillmentStatus(id, sku, status);
            
        }
        
        /// <summary>
        /// Test SetOrderNotes
        /// </summary>
        [Test]
        public void SetOrderNotesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //string orderNotes = null;
            //instance.SetOrderNotes(id, orderNotes);
            
        }
        
        /// <summary>
        /// Test SetPaymentStatus
        /// </summary>
        [Test]
        public void SetPaymentStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //InvoicePaymentStatusRequest request = null;
            //instance.SetPaymentStatus(id, request);
            
        }
        
        /// <summary>
        /// Test UpdateBillingInfo
        /// </summary>
        [Test]
        public void UpdateBillingInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //AddressResource billingInfoRequest = null;
            //instance.UpdateBillingInfo(id, billingInfoRequest);
            
        }
        
    }

}
