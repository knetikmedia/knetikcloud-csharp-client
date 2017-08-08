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
    ///  Class for testing LocationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class LocationsApiTests
    {
        private LocationsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LocationsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LocationsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' LocationsApi
            //Assert.IsInstanceOfType(typeof(LocationsApi), instance, "instance is a LocationsApi");
        }

        
        /// <summary>
        /// Test GetCountries
        /// </summary>
        [Test]
        public void GetCountriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetCountries();
            //Assert.IsInstanceOf<List<CountryResource>> (response, "response is List<CountryResource>");
        }
        
        /// <summary>
        /// Test GetCountryByGeoLocation
        /// </summary>
        [Test]
        public void GetCountryByGeoLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetCountryByGeoLocation();
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test GetCountryStates
        /// </summary>
        [Test]
        public void GetCountryStatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string countryCodeIso3 = null;
            //var response = instance.GetCountryStates(countryCodeIso3);
            //Assert.IsInstanceOf<List<StateResource>> (response, "response is List<StateResource>");
        }
        
        /// <summary>
        /// Test GetCurrencyByGeoLocation
        /// </summary>
        [Test]
        public void GetCurrencyByGeoLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetCurrencyByGeoLocation();
            //Assert.IsInstanceOf<CurrencyResource> (response, "response is CurrencyResource");
        }
        
    }

}