/* 
 * Knetik Platform API Documentation Latest
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
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
    ///  Class for testing FulfillmentApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class FulfillmentApiTests
    {
        private FulfillmentApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FulfillmentApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FulfillmentApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' FulfillmentApi
            //Assert.IsInstanceOfType(typeof(FulfillmentApi), instance, "instance is a FulfillmentApi");
        }

        
        /// <summary>
        /// Test CreateFulfillmentTypeUsingPOST
        /// </summary>
        [Test]
        public void CreateFulfillmentTypeUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //FulfillmentType type = null;
            //var response = instance.CreateFulfillmentTypeUsingPOST(type);
            //Assert.IsInstanceOf<FulfillmentType> (response, "response is FulfillmentType");
        }
        
        /// <summary>
        /// Test DeleteFulfillmentTypeUsingDELETE
        /// </summary>
        [Test]
        public void DeleteFulfillmentTypeUsingDELETETest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //instance.DeleteFulfillmentTypeUsingDELETE(id);
            
        }
        
        /// <summary>
        /// Test GetFulfillmentTypeUsingGET
        /// </summary>
        [Test]
        public void GetFulfillmentTypeUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //var response = instance.GetFulfillmentTypeUsingGET(id);
            //Assert.IsInstanceOf<FulfillmentType> (response, "response is FulfillmentType");
        }
        
        /// <summary>
        /// Test GetFulfillmentsUsingGET
        /// </summary>
        [Test]
        public void GetFulfillmentsUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetFulfillmentsUsingGET(size, page, order);
            //Assert.IsInstanceOf<PageFulfillmentType> (response, "response is PageFulfillmentType");
        }
        
        /// <summary>
        /// Test UpdateFulfillmentTypeUsingPUT
        /// </summary>
        [Test]
        public void UpdateFulfillmentTypeUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //FulfillmentType fulfillmentType = null;
            //instance.UpdateFulfillmentTypeUsingPUT(id, fulfillmentType);
            
        }
        
    }

}