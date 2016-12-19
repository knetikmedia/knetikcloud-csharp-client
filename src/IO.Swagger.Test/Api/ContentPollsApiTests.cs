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
    ///  Class for testing ContentPollsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ContentPollsApiTests
    {
        private ContentPollsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ContentPollsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ContentPollsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ContentPollsApi
            //Assert.IsInstanceOfType(typeof(ContentPollsApi), instance, "instance is a ContentPollsApi");
        }

        
        /// <summary>
        /// Test AnswerPollUsingPOST
        /// </summary>
        [Test]
        public void AnswerPollUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string answerKey = null;
            //var response = instance.AnswerPollUsingPOST(id, answerKey);
            //Assert.IsInstanceOf<PollResponseResource> (response, "response is PollResponseResource");
        }
        
        /// <summary>
        /// Test CreatePollTemplateUsingPOST
        /// </summary>
        [Test]
        public void CreatePollTemplateUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TemplateResource pollTemplateResource = null;
            //var response = instance.CreatePollTemplateUsingPOST(pollTemplateResource);
            //Assert.IsInstanceOf<TemplateResource> (response, "response is TemplateResource");
        }
        
        /// <summary>
        /// Test CreatePollUsingPOST
        /// </summary>
        [Test]
        public void CreatePollUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PollResource pollResource = null;
            //var response = instance.CreatePollUsingPOST(pollResource);
            //Assert.IsInstanceOf<PollResource> (response, "response is PollResource");
        }
        
        /// <summary>
        /// Test DeletePollTemplateUsingDELETE
        /// </summary>
        [Test]
        public void DeletePollTemplateUsingDELETETest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string cascade = null;
            //instance.DeletePollTemplateUsingDELETE(id, cascade);
            
        }
        
        /// <summary>
        /// Test DeletePollUsingDELETE
        /// </summary>
        [Test]
        public void DeletePollUsingDELETETest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DeletePollUsingDELETE(id);
            
        }
        
        /// <summary>
        /// Test GetPollAnswerUsingGET
        /// </summary>
        [Test]
        public void GetPollAnswerUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetPollAnswerUsingGET(id);
            //Assert.IsInstanceOf<PollResponseResource> (response, "response is PollResponseResource");
        }
        
        /// <summary>
        /// Test GetPollTemplateUsingGET
        /// </summary>
        [Test]
        public void GetPollTemplateUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetPollTemplateUsingGET(id);
            //Assert.IsInstanceOf<TemplateResource> (response, "response is TemplateResource");
        }
        
        /// <summary>
        /// Test GetPollTemplatesUsingGET
        /// </summary>
        [Test]
        public void GetPollTemplatesUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetPollTemplatesUsingGET(size, page, order);
            //Assert.IsInstanceOf<PageTemplateResource> (response, "response is PageTemplateResource");
        }
        
        /// <summary>
        /// Test GetPollUsingGET
        /// </summary>
        [Test]
        public void GetPollUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetPollUsingGET(id);
            //Assert.IsInstanceOf<PollResource> (response, "response is PollResource");
        }
        
        /// <summary>
        /// Test GetPollsUsingGET
        /// </summary>
        [Test]
        public void GetPollsUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filterCategory = null;
            //string filterTagset = null;
            //string filterText = null;
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetPollsUsingGET(filterCategory, filterTagset, filterText, size, page, order);
            //Assert.IsInstanceOf<PagePollResource> (response, "response is PagePollResource");
        }
        
        /// <summary>
        /// Test UpdatePollTemplateUsingPUT
        /// </summary>
        [Test]
        public void UpdatePollTemplateUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TemplateResource pollTemplateResource = null;
            //instance.UpdatePollTemplateUsingPUT(id, pollTemplateResource);
            
        }
        
        /// <summary>
        /// Test UpdatePollUsingPUT
        /// </summary>
        [Test]
        public void UpdatePollUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //PollResource pollResource = null;
            //instance.UpdatePollUsingPUT(id, pollResource);
            
        }
        
    }

}
