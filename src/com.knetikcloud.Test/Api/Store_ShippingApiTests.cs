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
    ///  Class for testing Store_ShippingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class Store_ShippingApiTests
    {
        private Store_ShippingApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Store_ShippingApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Store_ShippingApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' Store_ShippingApi
            //Assert.IsInstanceOfType(typeof(Store_ShippingApi), instance, "instance is a Store_ShippingApi");
        }

        
        /// <summary>
        /// Test CreateShippingItem
        /// </summary>
        [Test]
        public void CreateShippingItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? cascade = null;
            //ShippingItem shippingItem = null;
            //var response = instance.CreateShippingItem(cascade, shippingItem);
            //Assert.IsInstanceOf<ShippingItem> (response, "response is ShippingItem");
        }
        
        /// <summary>
        /// Test CreateShippingTemplate
        /// </summary>
        [Test]
        public void CreateShippingTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ItemTemplateResource shippingTemplateResource = null;
            //var response = instance.CreateShippingTemplate(shippingTemplateResource);
            //Assert.IsInstanceOf<ItemTemplateResource> (response, "response is ItemTemplateResource");
        }
        
        /// <summary>
        /// Test DeleteShippingItem
        /// </summary>
        [Test]
        public void DeleteShippingItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //instance.DeleteShippingItem(id);
            
        }
        
        /// <summary>
        /// Test DeleteShippingTemplate
        /// </summary>
        [Test]
        public void DeleteShippingTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string cascade = null;
            //instance.DeleteShippingTemplate(id, cascade);
            
        }
        
        /// <summary>
        /// Test GetShippingItem
        /// </summary>
        [Test]
        public void GetShippingItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //var response = instance.GetShippingItem(id);
            //Assert.IsInstanceOf<ShippingItem> (response, "response is ShippingItem");
        }
        
        /// <summary>
        /// Test GetShippingTemplate
        /// </summary>
        [Test]
        public void GetShippingTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetShippingTemplate(id);
            //Assert.IsInstanceOf<ItemTemplateResource> (response, "response is ItemTemplateResource");
        }
        
        /// <summary>
        /// Test GetShippingTemplates
        /// </summary>
        [Test]
        public void GetShippingTemplatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetShippingTemplates(size, page, order);
            //Assert.IsInstanceOf<PageResourceItemTemplateResource> (response, "response is PageResourceItemTemplateResource");
        }
        
        /// <summary>
        /// Test UpdateShippingItem
        /// </summary>
        [Test]
        public void UpdateShippingItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //bool? cascade = null;
            //ShippingItem shippingItem = null;
            //var response = instance.UpdateShippingItem(id, cascade, shippingItem);
            //Assert.IsInstanceOf<ShippingItem> (response, "response is ShippingItem");
        }
        
        /// <summary>
        /// Test UpdateShippingTemplate
        /// </summary>
        [Test]
        public void UpdateShippingTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ItemTemplateResource shippingTemplateResource = null;
            //var response = instance.UpdateShippingTemplate(id, shippingTemplateResource);
            //Assert.IsInstanceOf<ItemTemplateResource> (response, "response is ItemTemplateResource");
        }
        
    }

}
