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
    ///  Class for testing UsersRelationshipsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UsersRelationshipsApiTests
    {
        private UsersRelationshipsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UsersRelationshipsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UsersRelationshipsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UsersRelationshipsApi
            //Assert.IsInstanceOfType(typeof(UsersRelationshipsApi), instance, "instance is a UsersRelationshipsApi");
        }

        
        /// <summary>
        /// Test AddRelationshipUsingPOST
        /// </summary>
        [Test]
        public void AddRelationshipUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserRelationshipResource relationship = null;
            //var response = instance.AddRelationshipUsingPOST(relationship);
            //Assert.IsInstanceOf<UserRelationshipResource> (response, "response is UserRelationshipResource");
        }
        
        /// <summary>
        /// Test DeleteRelationshipUsingDELETE
        /// </summary>
        [Test]
        public void DeleteRelationshipUsingDELETETest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.DeleteRelationshipUsingDELETE(id);
            
        }
        
        /// <summary>
        /// Test GetRelationshipUsingGET
        /// </summary>
        [Test]
        public void GetRelationshipUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.GetRelationshipUsingGET(id);
            //Assert.IsInstanceOf<UserRelationshipResource> (response, "response is UserRelationshipResource");
        }
        
        /// <summary>
        /// Test GetRelationshipsUsingGET
        /// </summary>
        [Test]
        public void GetRelationshipsUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetRelationshipsUsingGET();
            //Assert.IsInstanceOf<PageResourceUserRelationshipResource> (response, "response is PageResourceUserRelationshipResource");
        }
        
        /// <summary>
        /// Test UpdateRelationshipUsingPUT
        /// </summary>
        [Test]
        public void UpdateRelationshipUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //UserRelationshipResource relationship = null;
            //var response = instance.UpdateRelationshipUsingPUT(id, relationship);
            //Assert.IsInstanceOf<UserRelationshipResource> (response, "response is UserRelationshipResource");
        }
        
    }

}
