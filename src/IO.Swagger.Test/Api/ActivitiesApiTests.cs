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
        /// Test CreateActivity
        /// </summary>
        [Test]
        public void CreateActivityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ActivityResource activityResource = null;
            //var response = instance.CreateActivity(activityResource);
            //Assert.IsInstanceOf<ActivityResource> (response, "response is ActivityResource");
        }
        
        /// <summary>
        /// Test CreateActivityOccurrence
        /// </summary>
        [Test]
        public void CreateActivityOccurrenceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? test = null;
            //ActivityOccurrenceResource activityOccurrenceResource = null;
            //var response = instance.CreateActivityOccurrence(test, activityOccurrenceResource);
            //Assert.IsInstanceOf<ActivityOccurrenceResource> (response, "response is ActivityOccurrenceResource");
        }
        
        /// <summary>
        /// Test DeleteActivity
        /// </summary>
        [Test]
        public void DeleteActivityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.DeleteActivity(id);
            
        }
        
        /// <summary>
        /// Test GetActivities
        /// </summary>
        [Test]
        public void GetActivitiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? filterTemplate = null;
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetActivities(filterTemplate, size, page, order);
            //Assert.IsInstanceOf<PageResourceBareActivityResource> (response, "response is PageResourceBareActivityResource");
        }
        
        /// <summary>
        /// Test GetActivity
        /// </summary>
        [Test]
        public void GetActivityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.GetActivity(id);
            //Assert.IsInstanceOf<ActivityResource> (response, "response is ActivityResource");
        }
        
        /// <summary>
        /// Test SetActivityOccurrenceResults
        /// </summary>
        [Test]
        public void SetActivityOccurrenceResultsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? activityOccurrenceId = null;
            //ActivityOccurrenceResults activityOccurrenceResults = null;
            //var response = instance.SetActivityOccurrenceResults(activityOccurrenceId, activityOccurrenceResults);
            //Assert.IsInstanceOf<ActivityOccurrenceResults> (response, "response is ActivityOccurrenceResults");
        }
        
        /// <summary>
        /// Test UpdateActivity
        /// </summary>
        [Test]
        public void UpdateActivityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //ActivityResource activityResource = null;
            //instance.UpdateActivity(id, activityResource);
            
        }
        
        /// <summary>
        /// Test UpdateActivityOccurrence
        /// </summary>
        [Test]
        public void UpdateActivityOccurrenceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? activityOccurrenceId = null;
            //string activityCccurrenceStatus = null;
            //instance.UpdateActivityOccurrence(activityOccurrenceId, activityCccurrenceStatus);
            
        }
        
    }

}
