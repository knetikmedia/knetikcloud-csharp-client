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
    ///  Class for testing StoreBundlesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class StoreBundlesApiTests
    {
        private StoreBundlesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new StoreBundlesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of StoreBundlesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' StoreBundlesApi
            //Assert.IsInstanceOfType(typeof(StoreBundlesApi), instance, "instance is a StoreBundlesApi");
        }

        
        /// <summary>
        /// Test CreateBundleItemUsingPOST
        /// </summary>
        [Test]
        public void CreateBundleItemUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BundleItem bundleItem = null;
            //var response = instance.CreateBundleItemUsingPOST(bundleItem);
            //Assert.IsInstanceOf<BundleItem> (response, "response is BundleItem");
        }
        
        /// <summary>
        /// Test CreateBundleTemplateUsingPOST
        /// </summary>
        [Test]
        public void CreateBundleTemplateUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ItemTemplateResource bundleTemplateResource = null;
            //var response = instance.CreateBundleTemplateUsingPOST(bundleTemplateResource);
            //Assert.IsInstanceOf<ItemTemplateResource> (response, "response is ItemTemplateResource");
        }
        
        /// <summary>
        /// Test DeleteBundleTemplateUsingDELETE
        /// </summary>
        [Test]
        public void DeleteBundleTemplateUsingDELETETest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string cascade = null;
            //instance.DeleteBundleTemplateUsingDELETE(id, cascade);
            
        }
        
        /// <summary>
        /// Test DeleteStoreItemUsingDELETE
        /// </summary>
        [Test]
        public void DeleteStoreItemUsingDELETETest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //instance.DeleteStoreItemUsingDELETE(id);
            
        }
        
        /// <summary>
        /// Test GetBundleTemplateUsingGET
        /// </summary>
        [Test]
        public void GetBundleTemplateUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetBundleTemplateUsingGET(id);
            //Assert.IsInstanceOf<ItemTemplateResource> (response, "response is ItemTemplateResource");
        }
        
        /// <summary>
        /// Test GetBundleTemplatesUsingGET
        /// </summary>
        [Test]
        public void GetBundleTemplatesUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetBundleTemplatesUsingGET(size, page, order);
            //Assert.IsInstanceOf<PageItemTemplateResource> (response, "response is PageItemTemplateResource");
        }
        
        /// <summary>
        /// Test GetStoreItemUsingGET
        /// </summary>
        [Test]
        public void GetStoreItemUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //var response = instance.GetStoreItemUsingGET(id);
            //Assert.IsInstanceOf<BundleItem> (response, "response is BundleItem");
        }
        
        /// <summary>
        /// Test UpdateBundleItemUsingPUT
        /// </summary>
        [Test]
        public void UpdateBundleItemUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //BundleItem bundleItem = null;
            //instance.UpdateBundleItemUsingPUT(id, bundleItem);
            
        }
        
        /// <summary>
        /// Test UpdateBundleTemplateUsingPUT
        /// </summary>
        [Test]
        public void UpdateBundleTemplateUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ItemTemplateResource bundleTemplateResource = null;
            //instance.UpdateBundleTemplateUsingPUT(id, bundleTemplateResource);
            
        }
        
    }

}
