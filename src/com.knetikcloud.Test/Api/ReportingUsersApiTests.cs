/* 
 * Knetik Platform API Documentation latest 
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://knetikcloud.com.
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

using com.knetikcloud.Client;
using com.knetikcloud.Api;
using com.knetikcloud.Model;

namespace com.knetikcloud.Test
{
    /// <summary>
    ///  Class for testing ReportingUsersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ReportingUsersApiTests
    {
        private ReportingUsersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ReportingUsersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ReportingUsersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ReportingUsersApi
            //Assert.IsInstanceOfType(typeof(ReportingUsersApi), instance, "instance is a ReportingUsersApi");
        }

        
        /// <summary>
        /// Test GetUserRegistrations
        /// </summary>
        [Test]
        public void GetUserRegistrationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string granularity = null;
            //long? startDate = null;
            //long? endDate = null;
            //int? size = null;
            //int? page = null;
            //var response = instance.GetUserRegistrations(granularity, startDate, endDate, size, page);
            //Assert.IsInstanceOf<PageResourceAggregateCountResource> (response, "response is PageResourceAggregateCountResource");
        }
        
    }

}
