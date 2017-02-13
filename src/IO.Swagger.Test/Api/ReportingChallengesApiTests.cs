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
    ///  Class for testing ReportingChallengesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ReportingChallengesApiTests
    {
        private ReportingChallengesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ReportingChallengesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ReportingChallengesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ReportingChallengesApi
            //Assert.IsInstanceOfType(typeof(ReportingChallengesApi), instance, "instance is a ReportingChallengesApi");
        }

        
        /// <summary>
        /// Test GetChallengeEventLeaderboard
        /// </summary>
        [Test]
        public void GetChallengeEventLeaderboardTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? filterEvent = null;
            //var response = instance.GetChallengeEventLeaderboard(filterEvent);
            //Assert.IsInstanceOf<PageResourceChallengeEventParticipantResource> (response, "response is PageResourceChallengeEventParticipantResource");
        }
        
        /// <summary>
        /// Test GetChallengeEventParticipants
        /// </summary>
        [Test]
        public void GetChallengeEventParticipantsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? filterEvent = null;
            //var response = instance.GetChallengeEventParticipants(filterEvent);
            //Assert.IsInstanceOf<PageResourceChallengeEventParticipantResource> (response, "response is PageResourceChallengeEventParticipantResource");
        }
        
    }

}
