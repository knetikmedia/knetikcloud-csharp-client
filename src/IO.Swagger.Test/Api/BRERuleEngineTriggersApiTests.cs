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

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing BRERuleEngineTriggersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class BRERuleEngineTriggersApiTests
    {
        private BRERuleEngineTriggersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BRERuleEngineTriggersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BRERuleEngineTriggersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BRERuleEngineTriggersApi
            //Assert.IsInstanceOfType(typeof(BRERuleEngineTriggersApi), instance, "instance is a BRERuleEngineTriggersApi");
        }

        
        /// <summary>
        /// Test CreateBRETrigger
        /// </summary>
        [Test]
        public void CreateBRETriggerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BreTriggerResource breTriggerResource = null;
            //var response = instance.CreateBRETrigger(breTriggerResource);
            //Assert.IsInstanceOf<BreTriggerResource> (response, "response is BreTriggerResource");
        }
        
        /// <summary>
        /// Test DeleteBRETrigger
        /// </summary>
        [Test]
        public void DeleteBRETriggerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventName = null;
            //instance.DeleteBRETrigger(eventName);
            
        }
        
        /// <summary>
        /// Test GetBRETrigger
        /// </summary>
        [Test]
        public void GetBRETriggerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventName = null;
            //var response = instance.GetBRETrigger(eventName);
            //Assert.IsInstanceOf<BreTriggerResource> (response, "response is BreTriggerResource");
        }
        
        /// <summary>
        /// Test GetBRETriggers
        /// </summary>
        [Test]
        public void GetBRETriggersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? filterSystem = null;
            //string filterCategory = null;
            //string filterName = null;
            //int? size = null;
            //int? page = null;
            //var response = instance.GetBRETriggers(filterSystem, filterCategory, filterName, size, page);
            //Assert.IsInstanceOf<PageResourceBreTriggerResource> (response, "response is PageResourceBreTriggerResource");
        }
        
        /// <summary>
        /// Test UpdateBRETrigger
        /// </summary>
        [Test]
        public void UpdateBRETriggerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventName = null;
            //BreTriggerResource breTriggerResource = null;
            //instance.UpdateBRETrigger(eventName, breTriggerResource);
            
        }
        
    }

}
