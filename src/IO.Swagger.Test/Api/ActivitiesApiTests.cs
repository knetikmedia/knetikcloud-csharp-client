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
    ///  Class for testing ActivitiesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ActivitiesApiTests
    {
        private ActivitiesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ActivitiesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ActivitiesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ActivitiesApi
            //Assert.IsInstanceOfType(typeof(ActivitiesApi), instance, "instance is a ActivitiesApi");
        }

        
        /// <summary>
        /// Test CompleteActivityOccurrenceUsingPUT
        /// </summary>
        [Test]
        public void CompleteActivityOccurrenceUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? activityOccurrenceId = null;
            //string activityCccurrenceStatus = null;
            //instance.CompleteActivityOccurrenceUsingPUT(activityOccurrenceId, activityCccurrenceStatus);
            
        }
        
        /// <summary>
        /// Test CreateActivityOccurrenceUsingPOST
        /// </summary>
        [Test]
        public void CreateActivityOccurrenceUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? test = null;
            //ActivityOccurrenceResource activityOccurrenceResource = null;
            //var response = instance.CreateActivityOccurrenceUsingPOST(test, activityOccurrenceResource);
            //Assert.IsInstanceOf<ActivityOccurrenceResource> (response, "response is ActivityOccurrenceResource");
        }
        
        /// <summary>
        /// Test CreateActivityUsingPOST
        /// </summary>
        [Test]
        public void CreateActivityUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ActivityResource activityResource = null;
            //var response = instance.CreateActivityUsingPOST(activityResource);
            //Assert.IsInstanceOf<ActivityResource> (response, "response is ActivityResource");
        }
        
        /// <summary>
        /// Test DeleteActivityUsingDELETE
        /// </summary>
        [Test]
        public void DeleteActivityUsingDELETETest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.DeleteActivityUsingDELETE(id);
            
        }
        
        /// <summary>
        /// Test GetActivitiesUsingGET
        /// </summary>
        [Test]
        public void GetActivitiesUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? filterTemplate = null;
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetActivitiesUsingGET(filterTemplate, size, page, order);
            //Assert.IsInstanceOf<PageBareActivityResource> (response, "response is PageBareActivityResource");
        }
        
        /// <summary>
        /// Test GetActivityUsingGET
        /// </summary>
        [Test]
        public void GetActivityUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.GetActivityUsingGET(id);
            //Assert.IsInstanceOf<ActivityResource> (response, "response is ActivityResource");
        }
        
        /// <summary>
        /// Test PostResultsUsingPOST
        /// </summary>
        [Test]
        public void PostResultsUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? activityOccurrenceId = null;
            //ActivityOccurrenceResults activityOccurrenceResults = null;
            //var response = instance.PostResultsUsingPOST(activityOccurrenceId, activityOccurrenceResults);
            //Assert.IsInstanceOf<ActivityOccurrenceResults> (response, "response is ActivityOccurrenceResults");
        }
        
        /// <summary>
        /// Test UpdateActivityUsingPUT
        /// </summary>
        [Test]
        public void UpdateActivityUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //ActivityResource activityResource = null;
            //instance.UpdateActivityUsingPUT(id, activityResource);
            
        }
        
    }

}
