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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
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
        /// Test CreateInvoiceUsingPOST
        /// </summary>
        [Test]
        public void CreateInvoiceUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InvoiceCreateRequest req = null;
            //var response = instance.CreateInvoiceUsingPOST(req);
            //Assert.IsInstanceOf<List<InvoiceResource>> (response, "response is List<InvoiceResource>");
        }
        
        /// <summary>
        /// Test GetInvoiceHistoryUsingGET
        /// </summary>
        [Test]
        public void GetInvoiceHistoryUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? filterUser = null;
            //string filterEmail = null;
            //string filterFulfillmentStatus = null;
            //string filterPaymentStatus = null;
            //string filterItemName = null;
            //string filterCreatedDate = null;
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetInvoiceHistoryUsingGET(filterUser, filterEmail, filterFulfillmentStatus, filterPaymentStatus, filterItemName, filterCreatedDate, size, page, order);
            //Assert.IsInstanceOf<PageResourceInvoiceResource> (response, "response is PageResourceInvoiceResource");
        }
        
        /// <summary>
        /// Test GetInvoiceUsingGET
        /// </summary>
        [Test]
        public void GetInvoiceUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //string postalCode = null;
            //var response = instance.GetInvoiceUsingGET(id, postalCode);
            //Assert.IsInstanceOf<InvoiceResource> (response, "response is InvoiceResource");
        }
        
        /// <summary>
        /// Test GetLogsUsingGET
        /// </summary>
        [Test]
        public void GetLogsUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //int? size = null;
            //int? page = null;
            //var response = instance.GetLogsUsingGET(id, size, page);
            //Assert.IsInstanceOf<PageResourceInvoiceLogEntry> (response, "response is PageResourceInvoiceLogEntry");
        }
        
        /// <summary>
        /// Test ListFulFillmentStatusesUsingGET
        /// </summary>
        [Test]
        public void ListFulFillmentStatusesUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListFulFillmentStatusesUsingGET();
            //Assert.IsInstanceOf<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test ListPaymentStatusesUsingGET
        /// </summary>
        [Test]
        public void ListPaymentStatusesUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListPaymentStatusesUsingGET();
            //Assert.IsInstanceOf<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test PayInvoiceUsingPOST
        /// </summary>
        [Test]
        public void PayInvoiceUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //PayBySavedMethodRequest request = null;
            //instance.PayInvoiceUsingPOST(id, request);
            
        }
        
        /// <summary>
        /// Test SetItemFulfillmentStatusUsingPUT
        /// </summary>
        [Test]
        public void SetItemFulfillmentStatusUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //string sku = null;
            //string status = null;
            //instance.SetItemFulfillmentStatusUsingPUT(id, sku, status);
            
        }
        
        /// <summary>
        /// Test SetOrderNotesUsingPUT
        /// </summary>
        [Test]
        public void SetOrderNotesUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //string orderNotes = null;
            //instance.SetOrderNotesUsingPUT(id, orderNotes);
            
        }
        
        /// <summary>
        /// Test SetPaymentStatusUsingPUT
        /// </summary>
        [Test]
        public void SetPaymentStatusUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //InvoicePaymentStatusRequest request = null;
            //instance.SetPaymentStatusUsingPUT(id, request);
            
        }
        
        /// <summary>
        /// Test UpdateBillingInfoUsingPUT
        /// </summary>
        [Test]
        public void UpdateBillingInfoUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //AddressResource billingInfoRequest = null;
            //instance.UpdateBillingInfoUsingPUT(id, billingInfoRequest);
            
        }
        
    }

}
