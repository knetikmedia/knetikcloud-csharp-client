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

using com.knetikcloud.Client;
using com.knetikcloud.Api;
using com.knetikcloud.Model;

namespace com.knetikcloud.Test
{
    /// <summary>
    ///  Class for testing CampaignsChallengesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CampaignsChallengesApiTests
    {
        private CampaignsChallengesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CampaignsChallengesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CampaignsChallengesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CampaignsChallengesApi
            //Assert.IsInstanceOfType(typeof(CampaignsChallengesApi), instance, "instance is a CampaignsChallengesApi");
        }

        
        /// <summary>
        /// Test CreateChallenge
        /// </summary>
        [Test]
        public void CreateChallengeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ChallengeResource challengeResource = null;
            //var response = instance.CreateChallenge(challengeResource);
            //Assert.IsInstanceOf<ChallengeResource> (response, "response is ChallengeResource");
        }
        
        /// <summary>
        /// Test CreateChallengeActivity
        /// </summary>
        [Test]
        public void CreateChallengeActivityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? challengeId = null;
            //ChallengeActivityResource challengeActivityResource = null;
            //bool? validateSettings = null;
            //var response = instance.CreateChallengeActivity(challengeId, challengeActivityResource, validateSettings);
            //Assert.IsInstanceOf<ChallengeActivityResource> (response, "response is ChallengeActivityResource");
        }
        
        /// <summary>
        /// Test CreateChallengeActivityTemplate
        /// </summary>
        [Test]
        public void CreateChallengeActivityTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TemplateResource challengeActivityTemplateResource = null;
            //var response = instance.CreateChallengeActivityTemplate(challengeActivityTemplateResource);
            //Assert.IsInstanceOf<TemplateResource> (response, "response is TemplateResource");
        }
        
        /// <summary>
        /// Test CreateChallengeTemplate
        /// </summary>
        [Test]
        public void CreateChallengeTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TemplateResource challengeTemplateResource = null;
            //var response = instance.CreateChallengeTemplate(challengeTemplateResource);
            //Assert.IsInstanceOf<TemplateResource> (response, "response is TemplateResource");
        }
        
        /// <summary>
        /// Test DeleteChallenge
        /// </summary>
        [Test]
        public void DeleteChallengeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.DeleteChallenge(id);
            
        }
        
        /// <summary>
        /// Test DeleteChallengeActivity
        /// </summary>
        [Test]
        public void DeleteChallengeActivityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? activityId = null;
            //long? challengeId = null;
            //instance.DeleteChallengeActivity(activityId, challengeId);
            
        }
        
        /// <summary>
        /// Test DeleteChallengeActivityTemplate
        /// </summary>
        [Test]
        public void DeleteChallengeActivityTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string cascade = null;
            //instance.DeleteChallengeActivityTemplate(id, cascade);
            
        }
        
        /// <summary>
        /// Test DeleteChallengeEvent
        /// </summary>
        [Test]
        public void DeleteChallengeEventTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.DeleteChallengeEvent(id);
            
        }
        
        /// <summary>
        /// Test DeleteChallengeTemplate
        /// </summary>
        [Test]
        public void DeleteChallengeTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string cascade = null;
            //instance.DeleteChallengeTemplate(id, cascade);
            
        }
        
        /// <summary>
        /// Test GetChallenge
        /// </summary>
        [Test]
        public void GetChallengeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.GetChallenge(id);
            //Assert.IsInstanceOf<ChallengeResource> (response, "response is ChallengeResource");
        }
        
        /// <summary>
        /// Test GetChallengeActivities
        /// </summary>
        [Test]
        public void GetChallengeActivitiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? challengeId = null;
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetChallengeActivities(challengeId, size, page, order);
            //Assert.IsInstanceOf<PageResourceBareChallengeActivityResource> (response, "response is PageResourceBareChallengeActivityResource");
        }
        
        /// <summary>
        /// Test GetChallengeActivity
        /// </summary>
        [Test]
        public void GetChallengeActivityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? activityId = null;
            //var response = instance.GetChallengeActivity(activityId);
            //Assert.IsInstanceOf<ChallengeActivityResource> (response, "response is ChallengeActivityResource");
        }
        
        /// <summary>
        /// Test GetChallengeActivityTemplate
        /// </summary>
        [Test]
        public void GetChallengeActivityTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetChallengeActivityTemplate(id);
            //Assert.IsInstanceOf<TemplateResource> (response, "response is TemplateResource");
        }
        
        /// <summary>
        /// Test GetChallengeActivityTemplates
        /// </summary>
        [Test]
        public void GetChallengeActivityTemplatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetChallengeActivityTemplates(size, page, order);
            //Assert.IsInstanceOf<PageResourceTemplateResource> (response, "response is PageResourceTemplateResource");
        }
        
        /// <summary>
        /// Test GetChallengeEvent
        /// </summary>
        [Test]
        public void GetChallengeEventTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.GetChallengeEvent(id);
            //Assert.IsInstanceOf<ChallengeEventResource> (response, "response is ChallengeEventResource");
        }
        
        /// <summary>
        /// Test GetChallengeEvents
        /// </summary>
        [Test]
        public void GetChallengeEventsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filterStartDate = null;
            //string filterEndDate = null;
            //bool? filterCampaigns = null;
            //long? filterChallenge = null;
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetChallengeEvents(filterStartDate, filterEndDate, filterCampaigns, filterChallenge, size, page, order);
            //Assert.IsInstanceOf<PageResourceChallengeEventResource> (response, "response is PageResourceChallengeEventResource");
        }
        
        /// <summary>
        /// Test GetChallengeTemplate
        /// </summary>
        [Test]
        public void GetChallengeTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetChallengeTemplate(id);
            //Assert.IsInstanceOf<TemplateResource> (response, "response is TemplateResource");
        }
        
        /// <summary>
        /// Test GetChallengeTemplates
        /// </summary>
        [Test]
        public void GetChallengeTemplatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetChallengeTemplates(size, page, order);
            //Assert.IsInstanceOf<PageResourceTemplateResource> (response, "response is PageResourceTemplateResource");
        }
        
        /// <summary>
        /// Test GetChallenges
        /// </summary>
        [Test]
        public void GetChallengesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? filterTemplate = null;
            //bool? filterActiveCampaign = null;
            //var response = instance.GetChallenges(filterTemplate, filterActiveCampaign);
            //Assert.IsInstanceOf<PageResourceChallengeResource> (response, "response is PageResourceChallengeResource");
        }
        
        /// <summary>
        /// Test UpdateChallenge
        /// </summary>
        [Test]
        public void UpdateChallengeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //ChallengeResource challengeResource = null;
            //var response = instance.UpdateChallenge(id, challengeResource);
            //Assert.IsInstanceOf<ChallengeResource> (response, "response is ChallengeResource");
        }
        
        /// <summary>
        /// Test UpdateChallengeActivity
        /// </summary>
        [Test]
        public void UpdateChallengeActivityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? activityId = null;
            //long? challengeId = null;
            //ChallengeActivityResource challengeActivityResource = null;
            //var response = instance.UpdateChallengeActivity(activityId, challengeId, challengeActivityResource);
            //Assert.IsInstanceOf<ChallengeActivityResource> (response, "response is ChallengeActivityResource");
        }
        
        /// <summary>
        /// Test UpdateChallengeActivityTemplate
        /// </summary>
        [Test]
        public void UpdateChallengeActivityTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TemplateResource challengeActivityTemplateResource = null;
            //var response = instance.UpdateChallengeActivityTemplate(id, challengeActivityTemplateResource);
            //Assert.IsInstanceOf<TemplateResource> (response, "response is TemplateResource");
        }
        
        /// <summary>
        /// Test UpdateChallengeTemplate
        /// </summary>
        [Test]
        public void UpdateChallengeTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TemplateResource challengeTemplateResource = null;
            //var response = instance.UpdateChallengeTemplate(id, challengeTemplateResource);
            //Assert.IsInstanceOf<TemplateResource> (response, "response is TemplateResource");
        }
        
    }

}
