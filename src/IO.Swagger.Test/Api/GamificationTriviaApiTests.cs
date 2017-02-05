/* 
 * Knetik Platform API Documentation latest 
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://demo.sandbox.knetikcloud.com
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
    ///  Class for testing GamificationTriviaApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class GamificationTriviaApiTests
    {
        private GamificationTriviaApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new GamificationTriviaApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GamificationTriviaApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' GamificationTriviaApi
            //Assert.IsInstanceOfType(typeof(GamificationTriviaApi), instance, "instance is a GamificationTriviaApi");
        }

        
        /// <summary>
        /// Test AddAnswersUsingPOST
        /// </summary>
        [Test]
        public void AddAnswersUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string questionId = null;
            //AnswerResource answer = null;
            //var response = instance.AddAnswersUsingPOST(questionId, answer);
            //Assert.IsInstanceOf<AnswerResource> (response, "response is AnswerResource");
        }
        
        /// <summary>
        /// Test AddTagUsingPOST
        /// </summary>
        [Test]
        public void AddTagUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string tag = null;
            //instance.AddTagUsingPOST(id, tag);
            
        }
        
        /// <summary>
        /// Test BatchAddTagUsingPOST
        /// </summary>
        [Test]
        public void BatchAddTagUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tag = null;
            //string filterSearch = null;
            //string filterIdset = null;
            //string filterCategory = null;
            //string filterTag = null;
            //string filterTagset = null;
            //string filterType = null;
            //bool? filterPublished = null;
            //long? filterImportId = null;
            //var response = instance.BatchAddTagUsingPOST(tag, filterSearch, filterIdset, filterCategory, filterTag, filterTagset, filterType, filterPublished, filterImportId);
            //Assert.IsInstanceOf<int?> (response, "response is int?");
        }
        
        /// <summary>
        /// Test BatchRemoveTagUsingDELETE
        /// </summary>
        [Test]
        public void BatchRemoveTagUsingDELETETest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tag = null;
            //string filterSearch = null;
            //string filterIdset = null;
            //string filterCategory = null;
            //string filterTag = null;
            //string filterTagset = null;
            //string filterType = null;
            //bool? filterPublished = null;
            //long? filterImportId = null;
            //var response = instance.BatchRemoveTagUsingDELETE(tag, filterSearch, filterIdset, filterCategory, filterTag, filterTagset, filterType, filterPublished, filterImportId);
            //Assert.IsInstanceOf<int?> (response, "response is int?");
        }
        
        /// <summary>
        /// Test BulkUpdateUsingPUT
        /// </summary>
        [Test]
        public void BulkUpdateUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QuestionResource question = null;
            //string filterSearch = null;
            //string filterIdset = null;
            //string filterCategory = null;
            //string filterTagset = null;
            //string filterType = null;
            //bool? filterPublished = null;
            //long? filterImportId = null;
            //var response = instance.BulkUpdateUsingPUT(question, filterSearch, filterIdset, filterCategory, filterTagset, filterType, filterPublished, filterImportId);
            //Assert.IsInstanceOf<int?> (response, "response is int?");
        }
        
        /// <summary>
        /// Test CountQuestionsUsingGET
        /// </summary>
        [Test]
        public void CountQuestionsUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filterSearch = null;
            //string filterIdset = null;
            //string filterCategory = null;
            //string filterTag = null;
            //string filterTagset = null;
            //string filterType = null;
            //bool? filterPublished = null;
            //var response = instance.CountQuestionsUsingGET(filterSearch, filterIdset, filterCategory, filterTag, filterTagset, filterType, filterPublished);
            //Assert.IsInstanceOf<long?> (response, "response is long?");
        }
        
        /// <summary>
        /// Test CreateQuestionTemplateUsingPOST
        /// </summary>
        [Test]
        public void CreateQuestionTemplateUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QuestionTemplateResource questionTemplateResource = null;
            //var response = instance.CreateQuestionTemplateUsingPOST(questionTemplateResource);
            //Assert.IsInstanceOf<QuestionTemplateResource> (response, "response is QuestionTemplateResource");
        }
        
        /// <summary>
        /// Test CreateQuestionUsingPOST
        /// </summary>
        [Test]
        public void CreateQuestionUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QuestionResource question = null;
            //var response = instance.CreateQuestionUsingPOST(question);
            //Assert.IsInstanceOf<QuestionResource> (response, "response is QuestionResource");
        }
        
        /// <summary>
        /// Test CreateUsingPOST
        /// </summary>
        [Test]
        public void CreateUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ImportJobResource request = null;
            //var response = instance.CreateUsingPOST(request);
            //Assert.IsInstanceOf<ImportJobResource> (response, "response is ImportJobResource");
        }
        
        /// <summary>
        /// Test DeleteQuestionTemplateUsingDELETE
        /// </summary>
        [Test]
        public void DeleteQuestionTemplateUsingDELETETest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string cascade = null;
            //instance.DeleteQuestionTemplateUsingDELETE(id, cascade);
            
        }
        
        /// <summary>
        /// Test DeleteQuestionUsingDELETE
        /// </summary>
        [Test]
        public void DeleteQuestionUsingDELETETest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DeleteQuestionUsingDELETE(id);
            
        }
        
        /// <summary>
        /// Test DeleteUsingDELETE
        /// </summary>
        [Test]
        public void DeleteUsingDELETETest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.DeleteUsingDELETE(id);
            
        }
        
        /// <summary>
        /// Test GetAnswerUsingGET
        /// </summary>
        [Test]
        public void GetAnswerUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string questionId = null;
            //string id = null;
            //var response = instance.GetAnswerUsingGET(questionId, id);
            //Assert.IsInstanceOf<AnswerResource> (response, "response is AnswerResource");
        }
        
        /// <summary>
        /// Test GetAnswersUsingGET
        /// </summary>
        [Test]
        public void GetAnswersUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string questionId = null;
            //var response = instance.GetAnswersUsingGET(questionId);
            //Assert.IsInstanceOf<List<AnswerResource>> (response, "response is List<AnswerResource>");
        }
        
        /// <summary>
        /// Test GetListUsingGET1
        /// </summary>
        [Test]
        public void GetListUsingGET1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filterVendor = null;
            //string filterCategory = null;
            //string filterName = null;
            //string filterStatus = null;
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetListUsingGET1(filterVendor, filterCategory, filterName, filterStatus, size, page, order);
            //Assert.IsInstanceOf<PageResourceImportJobResource> (response, "response is PageResourceImportJobResource");
        }
        
        /// <summary>
        /// Test GetQuestionTemplateUsingGET
        /// </summary>
        [Test]
        public void GetQuestionTemplateUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetQuestionTemplateUsingGET(id);
            //Assert.IsInstanceOf<QuestionTemplateResource> (response, "response is QuestionTemplateResource");
        }
        
        /// <summary>
        /// Test GetQuestionTemplatesUsingGET
        /// </summary>
        [Test]
        public void GetQuestionTemplatesUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetQuestionTemplatesUsingGET(size, page, order);
            //Assert.IsInstanceOf<PageResourceQuestionTemplateResource> (response, "response is PageResourceQuestionTemplateResource");
        }
        
        /// <summary>
        /// Test GetQuestionUsingGET
        /// </summary>
        [Test]
        public void GetQuestionUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetQuestionUsingGET(id);
            //Assert.IsInstanceOf<QuestionResource> (response, "response is QuestionResource");
        }
        
        /// <summary>
        /// Test GetQuestionsDeltaUsingGET
        /// </summary>
        [Test]
        public void GetQuestionsDeltaUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? since = null;
            //var response = instance.GetQuestionsDeltaUsingGET(since);
            //Assert.IsInstanceOf<List<DeltaResource>> (response, "response is List<DeltaResource>");
        }
        
        /// <summary>
        /// Test GetQuestionsUsingGET
        /// </summary>
        [Test]
        public void GetQuestionsUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? size = null;
            //int? page = null;
            //string order = null;
            //string filterSearch = null;
            //string filterIdset = null;
            //string filterCategory = null;
            //string filterTagset = null;
            //string filterType = null;
            //bool? filterPublished = null;
            //long? filterImportId = null;
            //var response = instance.GetQuestionsUsingGET(size, page, order, filterSearch, filterIdset, filterCategory, filterTagset, filterType, filterPublished, filterImportId);
            //Assert.IsInstanceOf<PageResourceQuestionResource> (response, "response is PageResourceQuestionResource");
        }
        
        /// <summary>
        /// Test GetTagsUsingGET1
        /// </summary>
        [Test]
        public void GetTagsUsingGET1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetTagsUsingGET1(id);
            //Assert.IsInstanceOf<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test GetTagsUsingGET2
        /// </summary>
        [Test]
        public void GetTagsUsingGET2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filterSearch = null;
            //string filterCategory = null;
            //long? filterImportId = null;
            //var response = instance.GetTagsUsingGET2(filterSearch, filterCategory, filterImportId);
            //Assert.IsInstanceOf<Collectionstring> (response, "response is Collectionstring");
        }
        
        /// <summary>
        /// Test GetUsingGET
        /// </summary>
        [Test]
        public void GetUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.GetUsingGET(id);
            //Assert.IsInstanceOf<ImportJobResource> (response, "response is ImportJobResource");
        }
        
        /// <summary>
        /// Test RemoveAnswersUsingDELETE
        /// </summary>
        [Test]
        public void RemoveAnswersUsingDELETETest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string questionId = null;
            //string id = null;
            //instance.RemoveAnswersUsingDELETE(questionId, id);
            
        }
        
        /// <summary>
        /// Test RemoveTagUsingDELETE
        /// </summary>
        [Test]
        public void RemoveTagUsingDELETETest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string tag = null;
            //instance.RemoveTagUsingDELETE(id, tag);
            
        }
        
        /// <summary>
        /// Test StartProcessUsingPOST
        /// </summary>
        [Test]
        public void StartProcessUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //bool? publishNow = null;
            //var response = instance.StartProcessUsingPOST(id, publishNow);
            //Assert.IsInstanceOf<ImportJobResource> (response, "response is ImportJobResource");
        }
        
        /// <summary>
        /// Test UpdateAnswerUsingPUT
        /// </summary>
        [Test]
        public void UpdateAnswerUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string questionId = null;
            //string id = null;
            //AnswerResource answer = null;
            //instance.UpdateAnswerUsingPUT(questionId, id, answer);
            
        }
        
        /// <summary>
        /// Test UpdateQuestionTemplateUsingPUT
        /// </summary>
        [Test]
        public void UpdateQuestionTemplateUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //QuestionTemplateResource questionTemplateResource = null;
            //instance.UpdateQuestionTemplateUsingPUT(id, questionTemplateResource);
            
        }
        
        /// <summary>
        /// Test UpdateQuestionUsingPUT
        /// </summary>
        [Test]
        public void UpdateQuestionUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //QuestionResource question = null;
            //var response = instance.UpdateQuestionUsingPUT(id, question);
            //Assert.IsInstanceOf<QuestionResource> (response, "response is QuestionResource");
        }
        
        /// <summary>
        /// Test UpdateUsingPUT
        /// </summary>
        [Test]
        public void UpdateUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //ImportJobResource request = null;
            //var response = instance.UpdateUsingPUT(id, request);
            //Assert.IsInstanceOf<ImportJobResource> (response, "response is ImportJobResource");
        }
        
    }

}