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
    ///  Class for testing LogsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class LogsApiTests
    {
        private LogsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LogsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LogsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' LogsApi
            //Assert.IsInstanceOfType(typeof(LogsApi), instance, "instance is a LogsApi");
        }

        
        /// <summary>
        /// Test AddUserLogUsingPOST
        /// </summary>
        [Test]
        public void AddUserLogUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserActionLog logEntry = null;
            //instance.AddUserLogUsingPOST(logEntry);
            
        }
        
        /// <summary>
        /// Test GetEventLogUsingGET
        /// </summary>
        [Test]
        public void GetEventLogUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetEventLogUsingGET(id);
            //Assert.IsInstanceOf<BreEventLog> (response, "response is BreEventLog");
        }
        
        /// <summary>
        /// Test GetEventsLogsUsingGET
        /// </summary>
        [Test]
        public void GetEventsLogsUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filterStartDate = null;
            //string filterEventName = null;
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetEventsLogsUsingGET(filterStartDate, filterEventName, size, page, order);
            //Assert.IsInstanceOf<PageBreEventLog> (response, "response is PageBreEventLog");
        }
        
        /// <summary>
        /// Test GetForwardLogUsingGET
        /// </summary>
        [Test]
        public void GetForwardLogUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetForwardLogUsingGET(id);
            //Assert.IsInstanceOf<ForwardLog> (response, "response is ForwardLog");
        }
        
        /// <summary>
        /// Test GetForwardLogsUsingGET
        /// </summary>
        [Test]
        public void GetForwardLogsUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filterStartDate = null;
            //string filterEndDate = null;
            //int? filterStatusCode = null;
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetForwardLogsUsingGET(filterStartDate, filterEndDate, filterStatusCode, size, page, order);
            //Assert.IsInstanceOf<PageForwardLog> (response, "response is PageForwardLog");
        }
        
        /// <summary>
        /// Test GetUserLogsUsingGET
        /// </summary>
        [Test]
        public void GetUserLogsUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetUserLogsUsingGET(id);
            //Assert.IsInstanceOf<UserActionLog> (response, "response is UserActionLog");
        }
        
        /// <summary>
        /// Test GetUserLogsUsingGET1
        /// </summary>
        [Test]
        public void GetUserLogsUsingGET1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? filterUser = null;
            //string filterActionName = null;
            //int? size = null;
            //int? page = null;
            //var response = instance.GetUserLogsUsingGET1(filterUser, filterActionName, size, page);
            //Assert.IsInstanceOf<PageUserActionLog> (response, "response is PageUserActionLog");
        }
        
    }

}