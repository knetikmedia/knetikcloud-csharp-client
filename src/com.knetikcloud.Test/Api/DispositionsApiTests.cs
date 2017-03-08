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
    ///  Class for testing DispositionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DispositionsApiTests
    {
        private DispositionsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DispositionsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DispositionsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DispositionsApi
            //Assert.IsInstanceOfType(typeof(DispositionsApi), instance, "instance is a DispositionsApi");
        }

        
        /// <summary>
        /// Test AddDisposition
        /// </summary>
        [Test]
        public void AddDispositionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DispositionResource disposition = null;
            //var response = instance.AddDisposition(disposition);
            //Assert.IsInstanceOf<DispositionResource> (response, "response is DispositionResource");
        }
        
        /// <summary>
        /// Test DeleteDisposition
        /// </summary>
        [Test]
        public void DeleteDispositionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.DeleteDisposition(id);
            
        }
        
        /// <summary>
        /// Test GetDisposition
        /// </summary>
        [Test]
        public void GetDispositionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.GetDisposition(id);
            //Assert.IsInstanceOf<DispositionResource> (response, "response is DispositionResource");
        }
        
        /// <summary>
        /// Test GetDispositionCounts
        /// </summary>
        [Test]
        public void GetDispositionCountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filterContext = null;
            //string filterOwner = null;
            //var response = instance.GetDispositionCounts(filterContext, filterOwner);
            //Assert.IsInstanceOf<List<DispositionCount>> (response, "response is List<DispositionCount>");
        }
        
        /// <summary>
        /// Test GetDispositions
        /// </summary>
        [Test]
        public void GetDispositionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filterContext = null;
            //string filterOwner = null;
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetDispositions(filterContext, filterOwner, size, page, order);
            //Assert.IsInstanceOf<PageResourceDispositionResource> (response, "response is PageResourceDispositionResource");
        }
        
    }

}