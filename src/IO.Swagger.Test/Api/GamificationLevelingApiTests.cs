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
    ///  Class for testing GamificationLevelingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class GamificationLevelingApiTests
    {
        private GamificationLevelingApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new GamificationLevelingApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GamificationLevelingApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' GamificationLevelingApi
            //Assert.IsInstanceOfType(typeof(GamificationLevelingApi), instance, "instance is a GamificationLevelingApi");
        }

        
        /// <summary>
        /// Test ChangeUserLevelExperienceUsingPUT
        /// </summary>
        [Test]
        public void ChangeUserLevelExperienceUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //string name = null;
            //int? progress = null;
            //instance.ChangeUserLevelExperienceUsingPUT(userId, name, progress);
            
        }
        
        /// <summary>
        /// Test CreateLevelUsingPOST
        /// </summary>
        [Test]
        public void CreateLevelUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //LevelingResource level = null;
            //var response = instance.CreateLevelUsingPOST(level);
            //Assert.IsInstanceOf<LevelingResource> (response, "response is LevelingResource");
        }
        
        /// <summary>
        /// Test DeleteLevelUsingDELETE
        /// </summary>
        [Test]
        public void DeleteLevelUsingDELETETest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //instance.DeleteLevelUsingDELETE(name);
            
        }
        
        /// <summary>
        /// Test GetAvailableTriggersUsingGET1
        /// </summary>
        [Test]
        public void GetAvailableTriggersUsingGET1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAvailableTriggersUsingGET1();
            //Assert.IsInstanceOf<List<BreTriggerResource>> (response, "response is List<BreTriggerResource>");
        }
        
        /// <summary>
        /// Test GetLevelUsingGET
        /// </summary>
        [Test]
        public void GetLevelUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //var response = instance.GetLevelUsingGET(name);
            //Assert.IsInstanceOf<LevelingResource> (response, "response is LevelingResource");
        }
        
        /// <summary>
        /// Test GetLevelsUsingGET
        /// </summary>
        [Test]
        public void GetLevelsUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filterName = null;
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetLevelsUsingGET(filterName, size, page, order);
            //Assert.IsInstanceOf<PageLevelingResource> (response, "response is PageLevelingResource");
        }
        
        /// <summary>
        /// Test GetUserLevelUsingGET
        /// </summary>
        [Test]
        public void GetUserLevelUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //string name = null;
            //var response = instance.GetUserLevelUsingGET(userId, name);
            //Assert.IsInstanceOf<UserLevelingResource> (response, "response is UserLevelingResource");
        }
        
        /// <summary>
        /// Test GetUserLevelsUsingGET
        /// </summary>
        [Test]
        public void GetUserLevelsUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //var response = instance.GetUserLevelsUsingGET(userId);
            //Assert.IsInstanceOf<PageUserLevelingResource> (response, "response is PageUserLevelingResource");
        }
        
        /// <summary>
        /// Test UpdateLevelUsingPUT
        /// </summary>
        [Test]
        public void UpdateLevelUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //LevelingResource newLevel = null;
            //instance.UpdateLevelUsingPUT(name, newLevel);
            
        }
        
    }

}