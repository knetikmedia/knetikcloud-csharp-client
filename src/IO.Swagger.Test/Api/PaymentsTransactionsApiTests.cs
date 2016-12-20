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
    ///  Class for testing PaymentsTransactionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PaymentsTransactionsApiTests
    {
        private PaymentsTransactionsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PaymentsTransactionsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PaymentsTransactionsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PaymentsTransactionsApi
            //Assert.IsInstanceOfType(typeof(PaymentsTransactionsApi), instance, "instance is a PaymentsTransactionsApi");
        }

        
        /// <summary>
        /// Test GetTransactionUsingGET
        /// </summary>
        [Test]
        public void GetTransactionUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //var response = instance.GetTransactionUsingGET(id);
            //Assert.IsInstanceOf<TransactionResource> (response, "response is TransactionResource");
        }
        
        /// <summary>
        /// Test GetTransactionsUsingGET
        /// </summary>
        [Test]
        public void GetTransactionsUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? filterInvoice = null;
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetTransactionsUsingGET(filterInvoice, size, page, order);
            //Assert.IsInstanceOf<PageTransactionResource> (response, "response is PageTransactionResource");
        }
        
        /// <summary>
        /// Test RefundTransactionUsingPOST
        /// </summary>
        [Test]
        public void RefundTransactionUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //RefundRequest request = null;
            //var response = instance.RefundTransactionUsingPOST(id, request);
            //Assert.IsInstanceOf<RefundResource> (response, "response is RefundResource");
        }
        
    }

}
