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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILocationsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get a list of countries
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;CountryResource&gt;</returns>
        List<CountryResource> GetCountries ();

        /// <summary>
        /// Get a list of countries
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;CountryResource&gt;</returns>
        ApiResponse<List<CountryResource>> GetCountriesWithHttpInfo ();
        /// <summary>
        /// Get the iso3 code of your country
        /// </summary>
        /// <remarks>
        /// Determined by geo ip location
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>string</returns>
        string GetCountryByGeoLocation ();

        /// <summary>
        /// Get the iso3 code of your country
        /// </summary>
        /// <remarks>
        /// Determined by geo ip location
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> GetCountryByGeoLocationWithHttpInfo ();
        /// <summary>
        /// Get a list of a country&#39;s states
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryCodeIso3">The iso3 code of the country</param>
        /// <returns>List&lt;StateResource&gt;</returns>
        List<StateResource> GetCountryStates (string countryCodeIso3);

        /// <summary>
        /// Get a list of a country&#39;s states
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryCodeIso3">The iso3 code of the country</param>
        /// <returns>ApiResponse of List&lt;StateResource&gt;</returns>
        ApiResponse<List<StateResource>> GetCountryStatesWithHttpInfo (string countryCodeIso3);
        /// <summary>
        /// Get the currency information of your country
        /// </summary>
        /// <remarks>
        /// Determined by geo ip location, currency to country mapping and a fallback setting
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CurrencyResource</returns>
        CurrencyResource GetCurrencyByGeoLocation ();

        /// <summary>
        /// Get the currency information of your country
        /// </summary>
        /// <remarks>
        /// Determined by geo ip location, currency to country mapping and a fallback setting
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CurrencyResource</returns>
        ApiResponse<CurrencyResource> GetCurrencyByGeoLocationWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get a list of countries
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;CountryResource&gt;</returns>
        System.Threading.Tasks.Task<List<CountryResource>> GetCountriesAsync ();

        /// <summary>
        /// Get a list of countries
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;CountryResource&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<CountryResource>>> GetCountriesAsyncWithHttpInfo ();
        /// <summary>
        /// Get the iso3 code of your country
        /// </summary>
        /// <remarks>
        /// Determined by geo ip location
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> GetCountryByGeoLocationAsync ();

        /// <summary>
        /// Get the iso3 code of your country
        /// </summary>
        /// <remarks>
        /// Determined by geo ip location
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> GetCountryByGeoLocationAsyncWithHttpInfo ();
        /// <summary>
        /// Get a list of a country&#39;s states
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryCodeIso3">The iso3 code of the country</param>
        /// <returns>Task of List&lt;StateResource&gt;</returns>
        System.Threading.Tasks.Task<List<StateResource>> GetCountryStatesAsync (string countryCodeIso3);

        /// <summary>
        /// Get a list of a country&#39;s states
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryCodeIso3">The iso3 code of the country</param>
        /// <returns>Task of ApiResponse (List&lt;StateResource&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<StateResource>>> GetCountryStatesAsyncWithHttpInfo (string countryCodeIso3);
        /// <summary>
        /// Get the currency information of your country
        /// </summary>
        /// <remarks>
        /// Determined by geo ip location, currency to country mapping and a fallback setting
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of CurrencyResource</returns>
        System.Threading.Tasks.Task<CurrencyResource> GetCurrencyByGeoLocationAsync ();

        /// <summary>
        /// Get the currency information of your country
        /// </summary>
        /// <remarks>
        /// Determined by geo ip location, currency to country mapping and a fallback setting
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (CurrencyResource)</returns>
        System.Threading.Tasks.Task<ApiResponse<CurrencyResource>> GetCurrencyByGeoLocationAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LocationsApi : ILocationsApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LocationsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LocationsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get a list of countries 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;CountryResource&gt;</returns>
        public List<CountryResource> GetCountries ()
        {
             ApiResponse<List<CountryResource>> localVarResponse = GetCountriesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of countries 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;CountryResource&gt;</returns>
        public ApiResponse< List<CountryResource> > GetCountriesWithHttpInfo ()
        {

            var localVarPath = "/location/countries";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCountries", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<CountryResource>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CountryResource>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CountryResource>)));
            
        }

        /// <summary>
        /// Get a list of countries 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;CountryResource&gt;</returns>
        public async System.Threading.Tasks.Task<List<CountryResource>> GetCountriesAsync ()
        {
             ApiResponse<List<CountryResource>> localVarResponse = await GetCountriesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of countries 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;CountryResource&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<CountryResource>>> GetCountriesAsyncWithHttpInfo ()
        {

            var localVarPath = "/location/countries";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCountries", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<CountryResource>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CountryResource>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CountryResource>)));
            
        }

        /// <summary>
        /// Get the iso3 code of your country Determined by geo ip location
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>string</returns>
        public string GetCountryByGeoLocation ()
        {
             ApiResponse<string> localVarResponse = GetCountryByGeoLocationWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the iso3 code of your country Determined by geo ip location
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > GetCountryByGeoLocationWithHttpInfo ()
        {

            var localVarPath = "/location/geolocation/country";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCountryByGeoLocation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get the iso3 code of your country Determined by geo ip location
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> GetCountryByGeoLocationAsync ()
        {
             ApiResponse<string> localVarResponse = await GetCountryByGeoLocationAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the iso3 code of your country Determined by geo ip location
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> GetCountryByGeoLocationAsyncWithHttpInfo ()
        {

            var localVarPath = "/location/geolocation/country";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCountryByGeoLocation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get a list of a country&#39;s states 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryCodeIso3">The iso3 code of the country</param>
        /// <returns>List&lt;StateResource&gt;</returns>
        public List<StateResource> GetCountryStates (string countryCodeIso3)
        {
             ApiResponse<List<StateResource>> localVarResponse = GetCountryStatesWithHttpInfo(countryCodeIso3);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of a country&#39;s states 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryCodeIso3">The iso3 code of the country</param>
        /// <returns>ApiResponse of List&lt;StateResource&gt;</returns>
        public ApiResponse< List<StateResource> > GetCountryStatesWithHttpInfo (string countryCodeIso3)
        {
            // verify the required parameter 'countryCodeIso3' is set
            if (countryCodeIso3 == null)
                throw new ApiException(400, "Missing required parameter 'countryCodeIso3' when calling LocationsApi->GetCountryStates");

            var localVarPath = "/location/countries/{country_code_iso3}/states";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (countryCodeIso3 != null) localVarPathParams.Add("country_code_iso3", Configuration.ApiClient.ParameterToString(countryCodeIso3)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCountryStates", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<StateResource>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<StateResource>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<StateResource>)));
            
        }

        /// <summary>
        /// Get a list of a country&#39;s states 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryCodeIso3">The iso3 code of the country</param>
        /// <returns>Task of List&lt;StateResource&gt;</returns>
        public async System.Threading.Tasks.Task<List<StateResource>> GetCountryStatesAsync (string countryCodeIso3)
        {
             ApiResponse<List<StateResource>> localVarResponse = await GetCountryStatesAsyncWithHttpInfo(countryCodeIso3);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of a country&#39;s states 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryCodeIso3">The iso3 code of the country</param>
        /// <returns>Task of ApiResponse (List&lt;StateResource&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<StateResource>>> GetCountryStatesAsyncWithHttpInfo (string countryCodeIso3)
        {
            // verify the required parameter 'countryCodeIso3' is set
            if (countryCodeIso3 == null)
                throw new ApiException(400, "Missing required parameter 'countryCodeIso3' when calling LocationsApi->GetCountryStates");

            var localVarPath = "/location/countries/{country_code_iso3}/states";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (countryCodeIso3 != null) localVarPathParams.Add("country_code_iso3", Configuration.ApiClient.ParameterToString(countryCodeIso3)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCountryStates", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<StateResource>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<StateResource>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<StateResource>)));
            
        }

        /// <summary>
        /// Get the currency information of your country Determined by geo ip location, currency to country mapping and a fallback setting
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CurrencyResource</returns>
        public CurrencyResource GetCurrencyByGeoLocation ()
        {
             ApiResponse<CurrencyResource> localVarResponse = GetCurrencyByGeoLocationWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the currency information of your country Determined by geo ip location, currency to country mapping and a fallback setting
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CurrencyResource</returns>
        public ApiResponse< CurrencyResource > GetCurrencyByGeoLocationWithHttpInfo ()
        {

            var localVarPath = "/location/geolocation/currency";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCurrencyByGeoLocation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CurrencyResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CurrencyResource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CurrencyResource)));
            
        }

        /// <summary>
        /// Get the currency information of your country Determined by geo ip location, currency to country mapping and a fallback setting
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of CurrencyResource</returns>
        public async System.Threading.Tasks.Task<CurrencyResource> GetCurrencyByGeoLocationAsync ()
        {
             ApiResponse<CurrencyResource> localVarResponse = await GetCurrencyByGeoLocationAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the currency information of your country Determined by geo ip location, currency to country mapping and a fallback setting
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (CurrencyResource)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CurrencyResource>> GetCurrencyByGeoLocationAsyncWithHttpInfo ()
        {

            var localVarPath = "/location/geolocation/currency";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCurrencyByGeoLocation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CurrencyResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CurrencyResource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CurrencyResource)));
            
        }

    }
}
