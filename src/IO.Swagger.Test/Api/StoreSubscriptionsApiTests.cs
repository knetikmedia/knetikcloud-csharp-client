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
    ///  Class for testing StoreSubscriptionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class StoreSubscriptionsApiTests
    {
        private StoreSubscriptionsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new StoreSubscriptionsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of StoreSubscriptionsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' StoreSubscriptionsApi
            //Assert.IsInstanceOfType(typeof(StoreSubscriptionsApi), instance, "instance is a StoreSubscriptionsApi");
        }

        
        /// <summary>
        /// Test CreateSubscriptionTemplateUsingPOST
        /// </summary>
        [Test]
        public void CreateSubscriptionTemplateUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SubscriptionTemplateResource subscriptionTemplateResource = null;
            //var response = instance.CreateSubscriptionTemplateUsingPOST(subscriptionTemplateResource);
            //Assert.IsInstanceOf<SubscriptionTemplateResource> (response, "response is SubscriptionTemplateResource");
        }
        
        /// <summary>
        /// Test CreateSubscriptionUsingPOST
        /// </summary>
        [Test]
        public void CreateSubscriptionUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SubscriptionResource subscriptionResource = null;
            //var response = instance.CreateSubscriptionUsingPOST(subscriptionResource);
            //Assert.IsInstanceOf<SubscriptionResource> (response, "response is SubscriptionResource");
        }
        
        /// <summary>
        /// Test DeletePlanUsingDELETE
        /// </summary>
        [Test]
        public void DeletePlanUsingDELETETest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //string planId = null;
            //instance.DeletePlanUsingDELETE(id, planId);
            
        }
        
        /// <summary>
        /// Test DeleteSubscriptionTemplateUsingDELETE
        /// </summary>
        [Test]
        public void DeleteSubscriptionTemplateUsingDELETETest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string cascade = null;
            //instance.DeleteSubscriptionTemplateUsingDELETE(id, cascade);
            
        }
        
        /// <summary>
        /// Test GetSubscriptionTemplateUsingGET
        /// </summary>
        [Test]
        public void GetSubscriptionTemplateUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetSubscriptionTemplateUsingGET(id);
            //Assert.IsInstanceOf<SubscriptionTemplateResource> (response, "response is SubscriptionTemplateResource");
        }
        
        /// <summary>
        /// Test GetSubscriptionTemplatesUsingGET
        /// </summary>
        [Test]
        public void GetSubscriptionTemplatesUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetSubscriptionTemplatesUsingGET(size, page, order);
            //Assert.IsInstanceOf<PageSubscriptionTemplateResource> (response, "response is PageSubscriptionTemplateResource");
        }
        
        /// <summary>
        /// Test GetSubscriptionUsingGET
        /// </summary>
        [Test]
        public void GetSubscriptionUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //var response = instance.GetSubscriptionUsingGET(id);
            //Assert.IsInstanceOf<SubscriptionResource> (response, "response is SubscriptionResource");
        }
        
        /// <summary>
        /// Test ListSubscriptionsUsingGET
        /// </summary>
        [Test]
        public void ListSubscriptionsUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.ListSubscriptionsUsingGET(size, page, order);
            //Assert.IsInstanceOf<PageSubscriptionResource> (response, "response is PageSubscriptionResource");
        }
        
        /// <summary>
        /// Test ProcessUsingPOST
        /// </summary>
        [Test]
        public void ProcessUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.ProcessUsingPOST();
            
        }
        
        /// <summary>
        /// Test UpdateSubscriptionTemplateUsingPUT
        /// </summary>
        [Test]
        public void UpdateSubscriptionTemplateUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //SubscriptionTemplateResource subscriptionTemplateResource = null;
            //instance.UpdateSubscriptionTemplateUsingPUT(id, subscriptionTemplateResource);
            
        }
        
        /// <summary>
        /// Test UpdateSubscriptionUsingPUT
        /// </summary>
        [Test]
        public void UpdateSubscriptionUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //SubscriptionResource subscriptionResource = null;
            //instance.UpdateSubscriptionUsingPUT(id, subscriptionResource);
            
        }
        
    }

}
