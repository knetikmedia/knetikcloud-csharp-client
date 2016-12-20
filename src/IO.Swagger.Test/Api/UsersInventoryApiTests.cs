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
    ///  Class for testing UsersInventoryApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UsersInventoryApiTests
    {
        private UsersInventoryApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UsersInventoryApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UsersInventoryApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UsersInventoryApi
            //Assert.IsInstanceOfType(typeof(UsersInventoryApi), instance, "instance is a UsersInventoryApi");
        }

        
        /// <summary>
        /// Test AddItemUsingPOST1
        /// </summary>
        [Test]
        public void AddItemUsingPOST1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //UserInventoryAddRequest userInventoryAddRequest = null;
            //var response = instance.AddItemUsingPOST1(id, userInventoryAddRequest);
            //Assert.IsInstanceOf<InvoiceResource> (response, "response is InvoiceResource");
        }
        
        /// <summary>
        /// Test CreateItemUsingPOST
        /// </summary>
        [Test]
        public void CreateItemUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EntitlementItem entitlementItem = null;
            //var response = instance.CreateItemUsingPOST(entitlementItem);
            //Assert.IsInstanceOf<EntitlementItem> (response, "response is EntitlementItem");
        }
        
        /// <summary>
        /// Test CreateTemplateUsingPOST3
        /// </summary>
        [Test]
        public void CreateTemplateUsingPOST3Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ItemTemplateResource template = null;
            //var response = instance.CreateTemplateUsingPOST3(template);
            //Assert.IsInstanceOf<ItemTemplateResource> (response, "response is ItemTemplateResource");
        }
        
        /// <summary>
        /// Test DeleteEntitlementTemplateUsingDELETE
        /// </summary>
        [Test]
        public void DeleteEntitlementTemplateUsingDELETETest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string cascade = null;
            //instance.DeleteEntitlementTemplateUsingDELETE(id, cascade);
            
        }
        
        /// <summary>
        /// Test DeleteItemUsingDELETE
        /// </summary>
        [Test]
        public void DeleteItemUsingDELETETest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? entitlementId = null;
            //instance.DeleteItemUsingDELETE(entitlementId);
            
        }
        
        /// <summary>
        /// Test EntitlementCheckUsingGET
        /// </summary>
        [Test]
        public void EntitlementCheckUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //int? itemId = null;
            //string sku = null;
            //instance.EntitlementCheckUsingGET(userId, itemId, sku);
            
        }
        
        /// <summary>
        /// Test EntitlementUseUsingPOST
        /// </summary>
        [Test]
        public void EntitlementUseUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //int? itemId = null;
            //string sku = null;
            //string info = null;
            //instance.EntitlementUseUsingPOST(userId, itemId, sku, info);
            
        }
        
        /// <summary>
        /// Test GetCurrenciesUsingGET1
        /// </summary>
        [Test]
        public void GetCurrenciesUsingGET1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetCurrenciesUsingGET1(size, page, order);
            //Assert.IsInstanceOf<PageEntitlementItem> (response, "response is PageEntitlementItem");
        }
        
        /// <summary>
        /// Test GetEntitlementTemplateUsingGET
        /// </summary>
        [Test]
        public void GetEntitlementTemplateUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetEntitlementTemplateUsingGET(id);
            //Assert.IsInstanceOf<ItemTemplateResource> (response, "response is ItemTemplateResource");
        }
        
        /// <summary>
        /// Test GetEntitlementTemplatesUsingGET
        /// </summary>
        [Test]
        public void GetEntitlementTemplatesUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetEntitlementTemplatesUsingGET(size, page, order);
            //Assert.IsInstanceOf<PageItemTemplateResource> (response, "response is PageItemTemplateResource");
        }
        
        /// <summary>
        /// Test GetInventoryListUsingGET
        /// </summary>
        [Test]
        public void GetInventoryListUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? inactive = null;
            //int? size = null;
            //int? page = null;
            //string filterItemName = null;
            //string filterUsername = null;
            //string filterGroup = null;
            //string filterDate = null;
            //var response = instance.GetInventoryListUsingGET(inactive, size, page, filterItemName, filterUsername, filterGroup, filterDate);
            //Assert.IsInstanceOf<PageUserInventoryResource> (response, "response is PageUserInventoryResource");
        }
        
        /// <summary>
        /// Test GetInventoryUsingGET
        /// </summary>
        [Test]
        public void GetInventoryUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //int? id = null;
            //var response = instance.GetInventoryUsingGET(userId, id);
            //Assert.IsInstanceOf<UserInventoryResource> (response, "response is UserInventoryResource");
        }
        
        /// <summary>
        /// Test GetItemUsingGET
        /// </summary>
        [Test]
        public void GetItemUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? entitlementId = null;
            //var response = instance.GetItemUsingGET(entitlementId);
            //Assert.IsInstanceOf<EntitlementItem> (response, "response is EntitlementItem");
        }
        
        /// <summary>
        /// Test GetUserInventoryListUsingGET
        /// </summary>
        [Test]
        public void GetUserInventoryListUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //bool? inactive = null;
            //int? size = null;
            //int? page = null;
            //string filterItemName = null;
            //long? filterMinDate = null;
            //long? filterMaxDate = null;
            //var response = instance.GetUserInventoryListUsingGET(id, inactive, size, page, filterItemName, filterMinDate, filterMaxDate);
            //Assert.IsInstanceOf<PageUserInventoryResource> (response, "response is PageUserInventoryResource");
        }
        
        /// <summary>
        /// Test GetUserInventoryLogUsingGET
        /// </summary>
        [Test]
        public void GetUserInventoryLogUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //int? id = null;
            //int? size = null;
            //int? page = null;
            //var response = instance.GetUserInventoryLogUsingGET(userId, id, size, page);
            //Assert.IsInstanceOf<PageUserItemLogResource> (response, "response is PageUserItemLogResource");
        }
        
        /// <summary>
        /// Test UpdateItemUsingPUT1
        /// </summary>
        [Test]
        public void UpdateItemUsingPUT1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? entitlementId = null;
            //EntitlementItem entitlementItem = null;
            //instance.UpdateItemUsingPUT1(entitlementId, entitlementItem);
            
        }
        
        /// <summary>
        /// Test UpdateTemplateUsingPUT3
        /// </summary>
        [Test]
        public void UpdateTemplateUsingPUT3Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ItemTemplateResource template = null;
            //instance.UpdateTemplateUsingPUT3(id, template);
            
        }
        
        /// <summary>
        /// Test UpdateUserInventoryBehaviorDataUsingPUT
        /// </summary>
        [Test]
        public void UpdateUserInventoryBehaviorDataUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //int? id = null;
            //Object data = null;
            //instance.UpdateUserInventoryBehaviorDataUsingPUT(userId, id, data);
            
        }
        
        /// <summary>
        /// Test UpdateUserInventoryExpiresUsingPUT
        /// </summary>
        [Test]
        public void UpdateUserInventoryExpiresUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //int? id = null;
            //long? timestamp = null;
            //instance.UpdateUserInventoryExpiresUsingPUT(userId, id, timestamp);
            
        }
        
        /// <summary>
        /// Test UpdateUserInventoryStatusUsingPUT
        /// </summary>
        [Test]
        public void UpdateUserInventoryStatusUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //int? id = null;
            //string inventoryStatus = null;
            //instance.UpdateUserInventoryStatusUsingPUT(userId, id, inventoryStatus);
            
        }
        
    }

}
