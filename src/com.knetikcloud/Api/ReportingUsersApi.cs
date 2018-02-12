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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace com.knetikcloud.Api
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
        /// Get user registration counts grouped by time range. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; REPORTING_USER_ADMIN
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="granularity">The time duration to aggregate by (optional, default to day)</param>
        /// <param name="startDate">The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time (optional)</param>
        /// <param name="endDate">The end of the time range to aggregate, unix timestamp in seconds. Default is end of time (optional)</param>
        /// <param name="size">The number of objects returned per page (optional, default to 25)</param>
        /// <param name="page">The number of the page returned, starting with 1 (optional, default to 1)</param>
        /// <returns>PageResourceAggregateCountResource</returns>
        PageResourceAggregateCountResource GetUserRegistrations (string granularity = null, long? startDate = null, long? endDate = null, int? size = null, int? page = null);

        /// <summary>
        /// Get user registration info
        /// </summary>
        /// <remarks>
        /// Get user registration counts grouped by time range. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; REPORTING_USER_ADMIN
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="granularity">The time duration to aggregate by (optional, default to day)</param>
        /// <param name="startDate">The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time (optional)</param>
        /// <param name="endDate">The end of the time range to aggregate, unix timestamp in seconds. Default is end of time (optional)</param>
        /// <param name="size">The number of objects returned per page (optional, default to 25)</param>
        /// <param name="page">The number of the page returned, starting with 1 (optional, default to 1)</param>
        /// <returns>ApiResponse of PageResourceAggregateCountResource</returns>
        ApiResponse<PageResourceAggregateCountResource> GetUserRegistrationsWithHttpInfo (string granularity = null, long? startDate = null, long? endDate = null, int? size = null, int? page = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get user registration info
        /// </summary>
        /// <remarks>
        /// Get user registration counts grouped by time range. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; REPORTING_USER_ADMIN
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="granularity">The time duration to aggregate by (optional, default to day)</param>
        /// <param name="startDate">The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time (optional)</param>
        /// <param name="endDate">The end of the time range to aggregate, unix timestamp in seconds. Default is end of time (optional)</param>
        /// <param name="size">The number of objects returned per page (optional, default to 25)</param>
        /// <param name="page">The number of the page returned, starting with 1 (optional, default to 1)</param>
        /// <returns>Task of PageResourceAggregateCountResource</returns>
        System.Threading.Tasks.Task<PageResourceAggregateCountResource> GetUserRegistrationsAsync (string granularity = null, long? startDate = null, long? endDate = null, int? size = null, int? page = null);

        /// <summary>
        /// Get user registration info
        /// </summary>
        /// <remarks>
        /// Get user registration counts grouped by time range. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; REPORTING_USER_ADMIN
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="granularity">The time duration to aggregate by (optional, default to day)</param>
        /// <param name="startDate">The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time (optional)</param>
        /// <param name="endDate">The end of the time range to aggregate, unix timestamp in seconds. Default is end of time (optional)</param>
        /// <param name="size">The number of objects returned per page (optional, default to 25)</param>
        /// <param name="page">The number of the page returned, starting with 1 (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (PageResourceAggregateCountResource)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageResourceAggregateCountResource>> GetUserRegistrationsAsyncWithHttpInfo (string granularity = null, long? startDate = null, long? endDate = null, int? size = null, int? page = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ReportingUsersApi : IReportingUsersApi
    {
        private com.knetikcloud.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingUsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReportingUsersApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = com.knetikcloud.Client.Configuration.DefaultExceptionFactory;
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

            ExceptionFactory = com.knetikcloud.Client.Configuration.DefaultExceptionFactory;
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
        public com.knetikcloud.Client.ExceptionFactory ExceptionFactory
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
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
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
        /// Get user registration info Get user registration counts grouped by time range. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; REPORTING_USER_ADMIN
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="granularity">The time duration to aggregate by (optional, default to day)</param>
        /// <param name="startDate">The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time (optional)</param>
        /// <param name="endDate">The end of the time range to aggregate, unix timestamp in seconds. Default is end of time (optional)</param>
        /// <param name="size">The number of objects returned per page (optional, default to 25)</param>
        /// <param name="page">The number of the page returned, starting with 1 (optional, default to 1)</param>
        /// <returns>PageResourceAggregateCountResource</returns>
        public PageResourceAggregateCountResource GetUserRegistrations (string granularity = null, long? startDate = null, long? endDate = null, int? size = null, int? page = null)
        {
             ApiResponse<PageResourceAggregateCountResource> localVarResponse = GetUserRegistrationsWithHttpInfo(granularity, startDate, endDate, size, page);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get user registration info Get user registration counts grouped by time range. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; REPORTING_USER_ADMIN
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="granularity">The time duration to aggregate by (optional, default to day)</param>
        /// <param name="startDate">The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time (optional)</param>
        /// <param name="endDate">The end of the time range to aggregate, unix timestamp in seconds. Default is end of time (optional)</param>
        /// <param name="size">The number of objects returned per page (optional, default to 25)</param>
        /// <param name="page">The number of the page returned, starting with 1 (optional, default to 1)</param>
        /// <returns>ApiResponse of PageResourceAggregateCountResource</returns>
        public ApiResponse< PageResourceAggregateCountResource > GetUserRegistrationsWithHttpInfo (string granularity = null, long? startDate = null, long? endDate = null, int? size = null, int? page = null)
        {

            var localVarPath = "/reporting/users/registrations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (granularity != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "granularity", granularity)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (size != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "size", size)); // query parameter
            if (page != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter

            // authentication (oauth2_client_credentials_grant) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (oauth2_password_grant) required
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
                Exception exception = ExceptionFactory("GetUserRegistrations", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PageResourceAggregateCountResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageResourceAggregateCountResource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageResourceAggregateCountResource)));
        }

        /// <summary>
        /// Get user registration info Get user registration counts grouped by time range. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; REPORTING_USER_ADMIN
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="granularity">The time duration to aggregate by (optional, default to day)</param>
        /// <param name="startDate">The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time (optional)</param>
        /// <param name="endDate">The end of the time range to aggregate, unix timestamp in seconds. Default is end of time (optional)</param>
        /// <param name="size">The number of objects returned per page (optional, default to 25)</param>
        /// <param name="page">The number of the page returned, starting with 1 (optional, default to 1)</param>
        /// <returns>Task of PageResourceAggregateCountResource</returns>
        public async System.Threading.Tasks.Task<PageResourceAggregateCountResource> GetUserRegistrationsAsync (string granularity = null, long? startDate = null, long? endDate = null, int? size = null, int? page = null)
        {
             ApiResponse<PageResourceAggregateCountResource> localVarResponse = await GetUserRegistrationsAsyncWithHttpInfo(granularity, startDate, endDate, size, page);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get user registration info Get user registration counts grouped by time range. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; REPORTING_USER_ADMIN
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="granularity">The time duration to aggregate by (optional, default to day)</param>
        /// <param name="startDate">The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time (optional)</param>
        /// <param name="endDate">The end of the time range to aggregate, unix timestamp in seconds. Default is end of time (optional)</param>
        /// <param name="size">The number of objects returned per page (optional, default to 25)</param>
        /// <param name="page">The number of the page returned, starting with 1 (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (PageResourceAggregateCountResource)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageResourceAggregateCountResource>> GetUserRegistrationsAsyncWithHttpInfo (string granularity = null, long? startDate = null, long? endDate = null, int? size = null, int? page = null)
        {

            var localVarPath = "/reporting/users/registrations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (granularity != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "granularity", granularity)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (size != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "size", size)); // query parameter
            if (page != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter

            // authentication (oauth2_client_credentials_grant) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (oauth2_password_grant) required
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
                Exception exception = ExceptionFactory("GetUserRegistrations", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PageResourceAggregateCountResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageResourceAggregateCountResource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageResourceAggregateCountResource)));
        }

    }
}
