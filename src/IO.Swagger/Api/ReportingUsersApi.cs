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
    public interface IReportingUsersApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get user registration info
        /// </summary>
        /// <remarks>
        /// Get user registration counts grouped by time range
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="granularity">The time duration to aggregate by (optional, default to day)</param>
        /// <param name="startDate">The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time (optional)</param>
        /// <param name="endDate">The end of the time range to aggregate, unix timestamp in seconds. Default is end of time (optional)</param>
        /// <returns>PageAggregateCountResource</returns>
        PageAggregateCountResource ExecutiveRevenueItemSalesUsingGET1 (string granularity = null, long? startDate = null, long? endDate = null);

        /// <summary>
        /// Get user registration info
        /// </summary>
        /// <remarks>
        /// Get user registration counts grouped by time range
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="granularity">The time duration to aggregate by (optional, default to day)</param>
        /// <param name="startDate">The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time (optional)</param>
        /// <param name="endDate">The end of the time range to aggregate, unix timestamp in seconds. Default is end of time (optional)</param>
        /// <returns>ApiResponse of PageAggregateCountResource</returns>
        ApiResponse<PageAggregateCountResource> ExecutiveRevenueItemSalesUsingGET1WithHttpInfo (string granularity = null, long? startDate = null, long? endDate = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get user registration info
        /// </summary>
        /// <remarks>
        /// Get user registration counts grouped by time range
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="granularity">The time duration to aggregate by (optional, default to day)</param>
        /// <param name="startDate">The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time (optional)</param>
        /// <param name="endDate">The end of the time range to aggregate, unix timestamp in seconds. Default is end of time (optional)</param>
        /// <returns>Task of PageAggregateCountResource</returns>
        System.Threading.Tasks.Task<PageAggregateCountResource> ExecutiveRevenueItemSalesUsingGET1Async (string granularity = null, long? startDate = null, long? endDate = null);

        /// <summary>
        /// Get user registration info
        /// </summary>
        /// <remarks>
        /// Get user registration counts grouped by time range
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="granularity">The time duration to aggregate by (optional, default to day)</param>
        /// <param name="startDate">The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time (optional)</param>
        /// <param name="endDate">The end of the time range to aggregate, unix timestamp in seconds. Default is end of time (optional)</param>
        /// <returns>Task of ApiResponse (PageAggregateCountResource)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageAggregateCountResource>> ExecutiveRevenueItemSalesUsingGET1AsyncWithHttpInfo (string granularity = null, long? startDate = null, long? endDate = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ReportingUsersApi : IReportingUsersApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingUsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReportingUsersApi(String basePath)
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
        /// Initializes a new instance of the <see cref="ReportingUsersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ReportingUsersApi(Configuration configuration = null)
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
        /// Get user registration info Get user registration counts grouped by time range
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="granularity">The time duration to aggregate by (optional, default to day)</param>
        /// <param name="startDate">The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time (optional)</param>
        /// <param name="endDate">The end of the time range to aggregate, unix timestamp in seconds. Default is end of time (optional)</param>
        /// <returns>PageAggregateCountResource</returns>
        public PageAggregateCountResource ExecutiveRevenueItemSalesUsingGET1 (string granularity = null, long? startDate = null, long? endDate = null)
        {
             ApiResponse<PageAggregateCountResource> localVarResponse = ExecutiveRevenueItemSalesUsingGET1WithHttpInfo(granularity, startDate, endDate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get user registration info Get user registration counts grouped by time range
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="granularity">The time duration to aggregate by (optional, default to day)</param>
        /// <param name="startDate">The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time (optional)</param>
        /// <param name="endDate">The end of the time range to aggregate, unix timestamp in seconds. Default is end of time (optional)</param>
        /// <returns>ApiResponse of PageAggregateCountResource</returns>
        public ApiResponse< PageAggregateCountResource > ExecutiveRevenueItemSalesUsingGET1WithHttpInfo (string granularity = null, long? startDate = null, long? endDate = null)
        {

            var localVarPath = "/reporting/users/registrations";
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
                "*/*"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (granularity != null) localVarQueryParams.Add("granularity", Configuration.ApiClient.ParameterToString(granularity)); // query parameter
            if (startDate != null) localVarQueryParams.Add("start_date", Configuration.ApiClient.ParameterToString(startDate)); // query parameter
            if (endDate != null) localVarQueryParams.Add("end_date", Configuration.ApiClient.ParameterToString(endDate)); // query parameter

            // authentication (OAuth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ExecutiveRevenueItemSalesUsingGET1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PageAggregateCountResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAggregateCountResource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAggregateCountResource)));
            
        }

        /// <summary>
        /// Get user registration info Get user registration counts grouped by time range
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="granularity">The time duration to aggregate by (optional, default to day)</param>
        /// <param name="startDate">The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time (optional)</param>
        /// <param name="endDate">The end of the time range to aggregate, unix timestamp in seconds. Default is end of time (optional)</param>
        /// <returns>Task of PageAggregateCountResource</returns>
        public async System.Threading.Tasks.Task<PageAggregateCountResource> ExecutiveRevenueItemSalesUsingGET1Async (string granularity = null, long? startDate = null, long? endDate = null)
        {
             ApiResponse<PageAggregateCountResource> localVarResponse = await ExecutiveRevenueItemSalesUsingGET1AsyncWithHttpInfo(granularity, startDate, endDate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get user registration info Get user registration counts grouped by time range
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="granularity">The time duration to aggregate by (optional, default to day)</param>
        /// <param name="startDate">The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time (optional)</param>
        /// <param name="endDate">The end of the time range to aggregate, unix timestamp in seconds. Default is end of time (optional)</param>
        /// <returns>Task of ApiResponse (PageAggregateCountResource)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageAggregateCountResource>> ExecutiveRevenueItemSalesUsingGET1AsyncWithHttpInfo (string granularity = null, long? startDate = null, long? endDate = null)
        {

            var localVarPath = "/reporting/users/registrations";
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
                "*/*"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (granularity != null) localVarQueryParams.Add("granularity", Configuration.ApiClient.ParameterToString(granularity)); // query parameter
            if (startDate != null) localVarQueryParams.Add("start_date", Configuration.ApiClient.ParameterToString(startDate)); // query parameter
            if (endDate != null) localVarQueryParams.Add("end_date", Configuration.ApiClient.ParameterToString(endDate)); // query parameter

            // authentication (OAuth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ExecutiveRevenueItemSalesUsingGET1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PageAggregateCountResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAggregateCountResource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAggregateCountResource)));
            
        }

    }
}
