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
    ///  Class for testing DevicesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DevicesApiTests
    {
        private DevicesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DevicesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DevicesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DevicesApi
            //Assert.IsInstanceOfType(typeof(DevicesApi), instance, "instance is a DevicesApi");
        }

        
        /// <summary>
        /// Test CreateDeviceUsingPOST
        /// </summary>
        [Test]
        public void CreateDeviceUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DeviceResource device = null;
            //var response = instance.CreateDeviceUsingPOST(device);
            //Assert.IsInstanceOf<DeviceResource> (response, "response is DeviceResource");
        }
        
        /// <summary>
        /// Test DeleteDeviceUsingDELETE
        /// </summary>
        [Test]
        public void DeleteDeviceUsingDELETETest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //instance.DeleteDeviceUsingDELETE(id);
            
        }
        
        /// <summary>
        /// Test GetDeviceUsingGET
        /// </summary>
        [Test]
        public void GetDeviceUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //var response = instance.GetDeviceUsingGET(id);
            //Assert.IsInstanceOf<DeviceResource> (response, "response is DeviceResource");
        }
        
        /// <summary>
        /// Test GetDevicesUsingGET
        /// </summary>
        [Test]
        public void GetDevicesUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filterMake = null;
            //string filterModel = null;
            //int? size = null;
            //int? page = null;
            //string order = null;
            //var response = instance.GetDevicesUsingGET(filterMake, filterModel, size, page, order);
            //Assert.IsInstanceOf<PageResourceDeviceResource> (response, "response is PageResourceDeviceResource");
        }
        
        /// <summary>
        /// Test UpdateDeviceUsingPUT
        /// </summary>
        [Test]
        public void UpdateDeviceUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DeviceResource device = null;
            //int? id = null;
            //instance.UpdateDeviceUsingPUT(device, id);
            
        }
        
    }

}
