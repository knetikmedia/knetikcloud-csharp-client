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
    ///  Class for testing AuthRolesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AuthRolesApiTests
    {
        private AuthRolesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AuthRolesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AuthRolesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AuthRolesApi
            //Assert.IsInstanceOfType(typeof(AuthRolesApi), instance, "instance is a AuthRolesApi");
        }

        
        /// <summary>
        /// Test AssignClientRolesUsingPUT
        /// </summary>
        [Test]
        public void AssignClientRolesUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientKey = null;
            //List<string> rolesList = null;
            //instance.AssignClientRolesUsingPUT(clientKey, rolesList);
            
        }
        
        /// <summary>
        /// Test AssignPermissionsUsingPUT
        /// </summary>
        [Test]
        public void AssignPermissionsUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string role = null;
            //List<string> permissionsList = null;
            //instance.AssignPermissionsUsingPUT(role, permissionsList);
            
        }
        
        /// <summary>
        /// Test AssignUserRolesExternalUsingPUT
        /// </summary>
        [Test]
        public void AssignUserRolesExternalUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //List<string> rolesList = null;
            //instance.AssignUserRolesExternalUsingPUT(userId, rolesList);
            
        }
        
        /// <summary>
        /// Test CreateRoleUsingPOST
        /// </summary>
        [Test]
        public void CreateRoleUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RoleResource roleResource = null;
            //var response = instance.CreateRoleUsingPOST(roleResource);
            //Assert.IsInstanceOf<RoleResource> (response, "response is RoleResource");
        }
        
        /// <summary>
        /// Test DeleteRoleUsingDELETE
        /// </summary>
        [Test]
        public void DeleteRoleUsingDELETETest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string role = null;
            //bool? force = null;
            //instance.DeleteRoleUsingDELETE(role, force);
            
        }
        
        /// <summary>
        /// Test GetClientRolesUsingGET
        /// </summary>
        [Test]
        public void GetClientRolesUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientKey = null;
            //var response = instance.GetClientRolesUsingGET(clientKey);
            //Assert.IsInstanceOf<List<RoleResource>> (response, "response is List<RoleResource>");
        }
        
        /// <summary>
        /// Test GetRoleUsingGET
        /// </summary>
        [Test]
        public void GetRoleUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string role = null;
            //var response = instance.GetRoleUsingGET(role);
            //Assert.IsInstanceOf<RoleResource> (response, "response is RoleResource");
        }
        
        /// <summary>
        /// Test GetRolesUsingGET
        /// </summary>
        [Test]
        public void GetRolesUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetRolesUsingGET(size, page, order);
            //Assert.IsInstanceOf<PageResourceRoleResource> (response, "response is PageResourceRoleResource");
        }
        
        /// <summary>
        /// Test GetUserRolesUsingGET
        /// </summary>
        [Test]
        public void GetUserRolesUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //var response = instance.GetUserRolesUsingGET(userId);
            //Assert.IsInstanceOf<List<RoleResource>> (response, "response is List<RoleResource>");
        }
        
        /// <summary>
        /// Test UpdateRoleUsingPUT
        /// </summary>
        [Test]
        public void UpdateRoleUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string role = null;
            //RoleResource roleResource = null;
            //instance.UpdateRoleUsingPUT(role, roleResource);
            
        }
        
    }

}
