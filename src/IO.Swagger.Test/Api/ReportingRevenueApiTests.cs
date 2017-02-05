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
    ///  Class for testing ReportingRevenueApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ReportingRevenueApiTests
    {
        private ReportingRevenueApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ReportingRevenueApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ReportingRevenueApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ReportingRevenueApi
            //Assert.IsInstanceOfType(typeof(ReportingRevenueApi), instance, "instance is a ReportingRevenueApi");
        }

        
        /// <summary>
        /// Test ExecutiveRevenueCountrySalesUsingGET
        /// </summary>
        [Test]
        public void ExecutiveRevenueCountrySalesUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currencyCode = null;
            //long? startDate = null;
            //long? endDate = null;
            //int? size = null;
            //int? page = null;
            //var response = instance.ExecutiveRevenueCountrySalesUsingGET(currencyCode, startDate, endDate, size, page);
            //Assert.IsInstanceOf<PageResourceRevenueCountryReportResource> (response, "response is PageResourceRevenueCountryReportResource");
        }
        
        /// <summary>
        /// Test ExecutiveRevenueItemSalesUsingGET
        /// </summary>
        [Test]
        public void ExecutiveRevenueItemSalesUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currencyCode = null;
            //long? startDate = null;
            //long? endDate = null;
            //var response = instance.ExecutiveRevenueItemSalesUsingGET(currencyCode, startDate, endDate);
            //Assert.IsInstanceOf<RevenueReportResource> (response, "response is RevenueReportResource");
        }
        
        /// <summary>
        /// Test ExecutiveRevenueProductSalesUsingGET
        /// </summary>
        [Test]
        public void ExecutiveRevenueProductSalesUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currencyCode = null;
            //long? startDate = null;
            //long? endDate = null;
            //int? size = null;
            //int? page = null;
            //var response = instance.ExecutiveRevenueProductSalesUsingGET(currencyCode, startDate, endDate, size, page);
            //Assert.IsInstanceOf<PageResourceRevenueProductReportResource> (response, "response is PageResourceRevenueProductReportResource");
        }
        
        /// <summary>
        /// Test ExecutiveRevenueRefundsUsingGET
        /// </summary>
        [Test]
        public void ExecutiveRevenueRefundsUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currencyCode = null;
            //long? startDate = null;
            //long? endDate = null;
            //var response = instance.ExecutiveRevenueRefundsUsingGET(currencyCode, startDate, endDate);
            //Assert.IsInstanceOf<RevenueReportResource> (response, "response is RevenueReportResource");
        }
        
        /// <summary>
        /// Test ExecutiveRevenueSubscriptionSalesUsingGET
        /// </summary>
        [Test]
        public void ExecutiveRevenueSubscriptionSalesUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currencyCode = null;
            //long? startDate = null;
            //long? endDate = null;
            //var response = instance.ExecutiveRevenueSubscriptionSalesUsingGET(currencyCode, startDate, endDate);
            //Assert.IsInstanceOf<RevenueReportResource> (response, "response is RevenueReportResource");
        }
        
    }

}
