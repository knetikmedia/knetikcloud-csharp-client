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
    ///  Class for testing BRERuleEngineRulesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class BRERuleEngineRulesApiTests
    {
        private BRERuleEngineRulesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BRERuleEngineRulesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BRERuleEngineRulesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BRERuleEngineRulesApi
            //Assert.IsInstanceOfType(typeof(BRERuleEngineRulesApi), instance, "instance is a BRERuleEngineRulesApi");
        }

        
        /// <summary>
        /// Test ConvertExpressionToStringUsingPOST
        /// </summary>
        [Test]
        public void ConvertExpressionToStringUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Expressionobject expression = null;
            //var response = instance.ConvertExpressionToStringUsingPOST(expression);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test CreateRuleUsingPOST
        /// </summary>
        [Test]
        public void CreateRuleUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BreRule breRule = null;
            //var response = instance.CreateRuleUsingPOST(breRule);
            //Assert.IsInstanceOf<BreRule> (response, "response is BreRule");
        }
        
        /// <summary>
        /// Test DeleteRuleUsingDELETE
        /// </summary>
        [Test]
        public void DeleteRuleUsingDELETETest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DeleteRuleUsingDELETE(id);
            
        }
        
        /// <summary>
        /// Test EnableRuleUsingPUT
        /// </summary>
        [Test]
        public void EnableRuleUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //BooleanResource enabled = null;
            //instance.EnableRuleUsingPUT(id, enabled);
            
        }
        
        /// <summary>
        /// Test GetRuleUsingGET
        /// </summary>
        [Test]
        public void GetRuleUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetRuleUsingGET(id);
            //Assert.IsInstanceOf<BreRule> (response, "response is BreRule");
        }
        
        /// <summary>
        /// Test GetRulesUsingGET
        /// </summary>
        [Test]
        public void GetRulesUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filterName = null;
            //bool? filterEnabled = null;
            //bool? filterSystem = null;
            //string filterTrigger = null;
            //string filterAction = null;
            //string filterCondition = null;
            //int? size = null;
            //int? page = null;
            //var response = instance.GetRulesUsingGET(filterName, filterEnabled, filterSystem, filterTrigger, filterAction, filterCondition, size, page);
            //Assert.IsInstanceOf<PageBreRule> (response, "response is PageBreRule");
        }
        
        /// <summary>
        /// Test UpdateRuleUsingPUT
        /// </summary>
        [Test]
        public void UpdateRuleUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //BreRule breRule = null;
            //instance.UpdateRuleUsingPUT(id, breRule);
            
        }
        
    }

}
