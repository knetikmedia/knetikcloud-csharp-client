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
    ///  Class for testing AuthTokensApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AuthTokensApiTests
    {
        private AuthTokensApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AuthTokensApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AuthTokensApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AuthTokensApi
            //Assert.IsInstanceOfType(typeof(AuthTokensApi), instance, "instance is a AuthTokensApi");
        }

        
        /// <summary>
        /// Test DeleteTokens
        /// </summary>
        [Test]
        public void DeleteTokensTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //string clientId = null;
            //instance.DeleteTokens(username, clientId);
            
        }
        
        /// <summary>
        /// Test GetToken
        /// </summary>
        [Test]
        public void GetTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //string clientId = null;
            //var response = instance.GetToken(username, clientId);
            //Assert.IsInstanceOf<OauthAccessTokenResource> (response, "response is OauthAccessTokenResource");
        }
        
        /// <summary>
        /// Test GetTokens
        /// </summary>
        [Test]
        public void GetTokensTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filterClientId = null;
            //string filterUsername = null;
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetTokens(filterClientId, filterUsername, size, page, order);
            //Assert.IsInstanceOf<PageResourceOauthAccessTokenResource> (response, "response is PageResourceOauthAccessTokenResource");
        }
        
    }

}
