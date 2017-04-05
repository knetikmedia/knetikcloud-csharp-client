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
    ///  Class for testing StoreSalesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class StoreSalesApiTests
    {
        private StoreSalesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new StoreSalesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of StoreSalesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' StoreSalesApi
            //Assert.IsInstanceOfType(typeof(StoreSalesApi), instance, "instance is a StoreSalesApi");
        }

        
        /// <summary>
        /// Test CreateCatalogSale
        /// </summary>
        [Test]
        public void CreateCatalogSaleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CatalogSale catalogSale = null;
            //var response = instance.CreateCatalogSale(catalogSale);
            //Assert.IsInstanceOf<CatalogSale> (response, "response is CatalogSale");
        }
        
        /// <summary>
        /// Test DeleteCatalogSale
        /// </summary>
        [Test]
        public void DeleteCatalogSaleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //instance.DeleteCatalogSale(id);
            
        }
        
        /// <summary>
        /// Test GetCatalogSale
        /// </summary>
        [Test]
        public void GetCatalogSaleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //var response = instance.GetCatalogSale(id);
            //Assert.IsInstanceOf<CatalogSale> (response, "response is CatalogSale");
        }
        
        /// <summary>
        /// Test GetCatalogSales
        /// </summary>
        [Test]
        public void GetCatalogSalesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetCatalogSales(size, page, order);
            //Assert.IsInstanceOf<PageResourceCatalogSale> (response, "response is PageResourceCatalogSale");
        }
        
        /// <summary>
        /// Test UpdateCatalogSale
        /// </summary>
        [Test]
        public void UpdateCatalogSaleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //CatalogSale catalogSale = null;
            //var response = instance.UpdateCatalogSale(id, catalogSale);
            //Assert.IsInstanceOf<CatalogSale> (response, "response is CatalogSale");
        }
        
    }

}
