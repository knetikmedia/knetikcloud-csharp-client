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
    ///  Class for testing CategoriesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CategoriesApiTests
    {
        private CategoriesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CategoriesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CategoriesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CategoriesApi
            //Assert.IsInstanceOfType(typeof(CategoriesApi), instance, "instance is a CategoriesApi");
        }

        
        /// <summary>
        /// Test CreateCategoryUsingPOST
        /// </summary>
        [Test]
        public void CreateCategoryUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CategoryResource category = null;
            //var response = instance.CreateCategoryUsingPOST(category);
            //Assert.IsInstanceOf<CategoryResource> (response, "response is CategoryResource");
        }
        
        /// <summary>
        /// Test CreateTemplateUsingPOST2
        /// </summary>
        [Test]
        public void CreateTemplateUsingPOST2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TemplateResource template = null;
            //var response = instance.CreateTemplateUsingPOST2(template);
            //Assert.IsInstanceOf<TemplateResource> (response, "response is TemplateResource");
        }
        
        /// <summary>
        /// Test DeleteCategoryUsingDELETE
        /// </summary>
        [Test]
        public void DeleteCategoryUsingDELETETest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DeleteCategoryUsingDELETE(id);
            
        }
        
        /// <summary>
        /// Test DeleteTemplateUsingDELETE1
        /// </summary>
        [Test]
        public void DeleteTemplateUsingDELETE1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string cascade = null;
            //instance.DeleteTemplateUsingDELETE1(id, cascade);
            
        }
        
        /// <summary>
        /// Test GetArticleTemplatesUsingGET1
        /// </summary>
        [Test]
        public void GetArticleTemplatesUsingGET1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetArticleTemplatesUsingGET1(size, page, order);
            //Assert.IsInstanceOf<PageTemplateResource> (response, "response is PageTemplateResource");
        }
        
        /// <summary>
        /// Test GetCategoriesUsingGET1
        /// </summary>
        [Test]
        public void GetCategoriesUsingGET1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filterSearch = null;
            //bool? filterActive = null;
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetCategoriesUsingGET1(filterSearch, filterActive, size, page, order);
            //Assert.IsInstanceOf<PageCategoryResource> (response, "response is PageCategoryResource");
        }
        
        /// <summary>
        /// Test GetCategoryUsingGET1
        /// </summary>
        [Test]
        public void GetCategoryUsingGET1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetCategoryUsingGET1(id);
            //Assert.IsInstanceOf<CategoryResource> (response, "response is CategoryResource");
        }
        
        /// <summary>
        /// Test GetTagsUsingGET
        /// </summary>
        [Test]
        public void GetTagsUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? size = null;
            //int? page = null;
            //var response = instance.GetTagsUsingGET(size, page);
            //Assert.IsInstanceOf<Pagestring> (response, "response is Pagestring");
        }
        
        /// <summary>
        /// Test GetTemplateUsingGET1
        /// </summary>
        [Test]
        public void GetTemplateUsingGET1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetTemplateUsingGET1(id);
            //Assert.IsInstanceOf<TemplateResource> (response, "response is TemplateResource");
        }
        
        /// <summary>
        /// Test UpdateCategoryUsingPUT1
        /// </summary>
        [Test]
        public void UpdateCategoryUsingPUT1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //CategoryResource category = null;
            //instance.UpdateCategoryUsingPUT1(id, category);
            
        }
        
        /// <summary>
        /// Test UpdateTemplateUsingPUT2
        /// </summary>
        [Test]
        public void UpdateTemplateUsingPUT2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TemplateResource template = null;
            //instance.UpdateTemplateUsingPUT2(id, template);
            
        }
        
    }

}
