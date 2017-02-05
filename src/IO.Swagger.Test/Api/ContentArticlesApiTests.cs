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
    ///  Class for testing ContentArticlesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ContentArticlesApiTests
    {
        private ContentArticlesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ContentArticlesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ContentArticlesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ContentArticlesApi
            //Assert.IsInstanceOfType(typeof(ContentArticlesApi), instance, "instance is a ContentArticlesApi");
        }

        
        /// <summary>
        /// Test CreateArticleTemplateUsingPOST
        /// </summary>
        [Test]
        public void CreateArticleTemplateUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TemplateResource articleTemplateResource = null;
            //var response = instance.CreateArticleTemplateUsingPOST(articleTemplateResource);
            //Assert.IsInstanceOf<TemplateResource> (response, "response is TemplateResource");
        }
        
        /// <summary>
        /// Test CreateArticleUsingPOST
        /// </summary>
        [Test]
        public void CreateArticleUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ArticleResource articleResource = null;
            //var response = instance.CreateArticleUsingPOST(articleResource);
            //Assert.IsInstanceOf<ArticleResource> (response, "response is ArticleResource");
        }
        
        /// <summary>
        /// Test DeleteArticleTemplateUsingDELETE
        /// </summary>
        [Test]
        public void DeleteArticleTemplateUsingDELETETest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string cascade = null;
            //instance.DeleteArticleTemplateUsingDELETE(id, cascade);
            
        }
        
        /// <summary>
        /// Test DeleteArticleUsingDELETE
        /// </summary>
        [Test]
        public void DeleteArticleUsingDELETETest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DeleteArticleUsingDELETE(id);
            
        }
        
        /// <summary>
        /// Test GetArticleTemplateUsingGET
        /// </summary>
        [Test]
        public void GetArticleTemplateUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetArticleTemplateUsingGET(id);
            //Assert.IsInstanceOf<TemplateResource> (response, "response is TemplateResource");
        }
        
        /// <summary>
        /// Test GetArticleTemplatesUsingGET
        /// </summary>
        [Test]
        public void GetArticleTemplatesUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetArticleTemplatesUsingGET(size, page, order);
            //Assert.IsInstanceOf<PageResourceTemplateResource> (response, "response is PageResourceTemplateResource");
        }
        
        /// <summary>
        /// Test GetArticleUsingGET
        /// </summary>
        [Test]
        public void GetArticleUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetArticleUsingGET(id);
            //Assert.IsInstanceOf<ArticleResource> (response, "response is ArticleResource");
        }
        
        /// <summary>
        /// Test GetArticlesUsingGET
        /// </summary>
        [Test]
        public void GetArticlesUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filterCategory = null;
            //string filterTagset = null;
            //string filterTitle = null;
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetArticlesUsingGET(filterCategory, filterTagset, filterTitle, size, page, order);
            //Assert.IsInstanceOf<PageResourceArticleResource> (response, "response is PageResourceArticleResource");
        }
        
        /// <summary>
        /// Test UpdateArticleTemplateUsingPUT
        /// </summary>
        [Test]
        public void UpdateArticleTemplateUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TemplateResource articleTemplateResource = null;
            //instance.UpdateArticleTemplateUsingPUT(id, articleTemplateResource);
            
        }
        
        /// <summary>
        /// Test UpdateArticleUsingPUT
        /// </summary>
        [Test]
        public void UpdateArticleUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ArticleResource articleResource = null;
            //instance.UpdateArticleUsingPUT(id, articleResource);
            
        }
        
    }

}