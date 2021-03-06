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
    ///  Class for testing Users_AddressesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class Users_AddressesApiTests
    {
        private Users_AddressesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Users_AddressesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Users_AddressesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' Users_AddressesApi
            //Assert.IsInstanceOfType(typeof(Users_AddressesApi), instance, "instance is a Users_AddressesApi");
        }

        
        /// <summary>
        /// Test CreateAddress
        /// </summary>
        [Test]
        public void CreateAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //SavedAddressResource savedAddressResource = null;
            //var response = instance.CreateAddress(userId, savedAddressResource);
            //Assert.IsInstanceOf<SavedAddressResource> (response, "response is SavedAddressResource");
        }
        
        /// <summary>
        /// Test DeleteAddress
        /// </summary>
        [Test]
        public void DeleteAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //int? id = null;
            //instance.DeleteAddress(userId, id);
            
        }
        
        /// <summary>
        /// Test GetAddress
        /// </summary>
        [Test]
        public void GetAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //int? id = null;
            //var response = instance.GetAddress(userId, id);
            //Assert.IsInstanceOf<SavedAddressResource> (response, "response is SavedAddressResource");
        }
        
        /// <summary>
        /// Test GetAddresses
        /// </summary>
        [Test]
        public void GetAddressesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetAddresses(userId, size, page, order);
            //Assert.IsInstanceOf<PageResourceSavedAddressResource> (response, "response is PageResourceSavedAddressResource");
        }
        
        /// <summary>
        /// Test UpdateAddress
        /// </summary>
        [Test]
        public void UpdateAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //int? id = null;
            //SavedAddressResource savedAddressResource = null;
            //var response = instance.UpdateAddress(userId, id, savedAddressResource);
            //Assert.IsInstanceOf<SavedAddressResource> (response, "response is SavedAddressResource");
        }
        
    }

}
