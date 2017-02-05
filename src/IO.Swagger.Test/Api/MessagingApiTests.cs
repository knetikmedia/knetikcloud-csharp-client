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
    ///  Class for testing MessagingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class MessagingApiTests
    {
        private MessagingApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MessagingApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MessagingApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' MessagingApi
            //Assert.IsInstanceOfType(typeof(MessagingApi), instance, "instance is a MessagingApi");
        }

        
        /// <summary>
        /// Test SendRawEmailUsingPOST
        /// </summary>
        [Test]
        public void SendRawEmailUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RawEmailResource rawEmailResource = null;
            //instance.SendRawEmailUsingPOST(rawEmailResource);
            
        }
        
        /// <summary>
        /// Test SendRawSMSUsingPOST
        /// </summary>
        [Test]
        public void SendRawSMSUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RawSMSResource rawSMSResource = null;
            //instance.SendRawSMSUsingPOST(rawSMSResource);
            
        }
        
        /// <summary>
        /// Test SendRawSMSUsingPOST1
        /// </summary>
        [Test]
        public void SendRawSMSUsingPOST1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TemplateSMSResource templateSMSResource = null;
            //instance.SendRawSMSUsingPOST1(templateSMSResource);
            
        }
        
        /// <summary>
        /// Test SendTemplateEmailUsingPOST
        /// </summary>
        [Test]
        public void SendTemplateEmailUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TemplateEmailResource messageResource = null;
            //instance.SendTemplateEmailUsingPOST(messageResource);
            
        }
        
    }

}
