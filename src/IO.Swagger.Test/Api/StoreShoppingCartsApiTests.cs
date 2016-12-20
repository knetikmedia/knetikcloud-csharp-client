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
    ///  Class for testing StoreShoppingCartsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class StoreShoppingCartsApiTests
    {
        private StoreShoppingCartsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new StoreShoppingCartsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of StoreShoppingCartsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' StoreShoppingCartsApi
            //Assert.IsInstanceOfType(typeof(StoreShoppingCartsApi), instance, "instance is a StoreShoppingCartsApi");
        }

        
        /// <summary>
        /// Test AddDiscountUsingPOST
        /// </summary>
        [Test]
        public void AddDiscountUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //SkuRequest skuRequest = null;
            //instance.AddDiscountUsingPOST(id, skuRequest);
            
        }
        
        /// <summary>
        /// Test AddItemUsingPOST
        /// </summary>
        [Test]
        public void AddItemUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //CartItemRequest cartItemRequest = null;
            //instance.AddItemUsingPOST(id, cartItemRequest);
            
        }
        
        /// <summary>
        /// Test AssignCartUsingPUT
        /// </summary>
        [Test]
        public void AssignCartUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //int? userId = null;
            //instance.AssignCartUsingPUT(id, userId);
            
        }
        
        /// <summary>
        /// Test CheckShippableUsingGET
        /// </summary>
        [Test]
        public void CheckShippableUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.CheckShippableUsingGET(id);
            //Assert.IsInstanceOf<CartShippableResponse> (response, "response is CartShippableResponse");
        }
        
        /// <summary>
        /// Test CreateCartUsingPOST
        /// </summary>
        [Test]
        public void CreateCartUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? owner = null;
            //string currencyCode = null;
            //var response = instance.CreateCartUsingPOST(owner, currencyCode);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test GetCartUsingGET
        /// </summary>
        [Test]
        public void GetCartUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetCartUsingGET(id);
            //Assert.IsInstanceOf<Cart> (response, "response is Cart");
        }
        
        /// <summary>
        /// Test GetCountriesUsingGET
        /// </summary>
        [Test]
        public void GetCountriesUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetCountriesUsingGET(id);
            //Assert.IsInstanceOf<SampleCountriesResponse> (response, "response is SampleCountriesResponse");
        }
        
        /// <summary>
        /// Test ModifyShippingAddressUsingPUT
        /// </summary>
        [Test]
        public void ModifyShippingAddressUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //CartShippingAddressRequest cartShippingAddressRequest = null;
            //instance.ModifyShippingAddressUsingPUT(id, cartShippingAddressRequest);
            
        }
        
        /// <summary>
        /// Test RemoveDiscountUsingDELETE
        /// </summary>
        [Test]
        public void RemoveDiscountUsingDELETETest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string code = null;
            //instance.RemoveDiscountUsingDELETE(id, code);
            
        }
        
        /// <summary>
        /// Test SearchCartsUsingGET
        /// </summary>
        [Test]
        public void SearchCartsUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? filterOwnerId = null;
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.SearchCartsUsingGET(filterOwnerId, size, page, order);
            //Assert.IsInstanceOf<PageResourceCartSummary> (response, "response is PageResourceCartSummary");
        }
        
        /// <summary>
        /// Test SetCartCurrencyUsingPUT
        /// </summary>
        [Test]
        public void SetCartCurrencyUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string currencyCode = null;
            //instance.SetCartCurrencyUsingPUT(id, currencyCode);
            
        }
        
        /// <summary>
        /// Test UpdateItemUsingPUT
        /// </summary>
        [Test]
        public void UpdateItemUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //CartItemRequest cartItemRequest = null;
            //instance.UpdateItemUsingPUT(id, cartItemRequest);
            
        }
        
    }

}
