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
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace com.knetikcloud.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IReportingChallengesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieve a challenge event leaderboard details
        /// </summary>
        /// <remarks>
        /// Lists all leaderboard entries with additional user details
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterEvent">A sepecific challenge event id (optional)</param>
        /// <returns>PageResourceChallengeEventParticipantResource</returns>
        PageResourceChallengeEventParticipantResource GetChallengeEventLeaderboard (long? filterEvent = null);

        /// <summary>
        /// Retrieve a challenge event leaderboard details
        /// </summary>
        /// <remarks>
        /// Lists all leaderboard entries with additional user details
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterEvent">A sepecific challenge event id (optional)</param>
        /// <returns>ApiResponse of PageResourceChallengeEventParticipantResource</returns>
        ApiResponse<PageResourceChallengeEventParticipantResource> GetChallengeEventLeaderboardWithHttpInfo (long? filterEvent = null);
        /// <summary>
        /// Retrieve a challenge event participant details
        /// </summary>
        /// <remarks>
        /// Lists all user submitted scores sorted by value, including those that do not apear in the leaderboard due to value or aggregation
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterEvent">A sepecific challenge event id (optional)</param>
        /// <returns>PageResourceChallengeEventParticipantResource</returns>
        PageResourceChallengeEventParticipantResource GetChallengeEventParticipants (long? filterEvent = null);

        /// <summary>
        /// Retrieve a challenge event participant details
        /// </summary>
        /// <remarks>
        /// Lists all user submitted scores sorted by value, including those that do not apear in the leaderboard due to value or aggregation
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterEvent">A sepecific challenge event id (optional)</param>
        /// <returns>ApiResponse of PageResourceChallengeEventParticipantResource</returns>
        ApiResponse<PageResourceChallengeEventParticipantResource> GetChallengeEventParticipantsWithHttpInfo (long? filterEvent = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Retrieve a challenge event leaderboard details
        /// </summary>
        /// <remarks>
        /// Lists all leaderboard entries with additional user details
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterEvent">A sepecific challenge event id (optional)</param>
        /// <returns>Task of PageResourceChallengeEventParticipantResource</returns>
        System.Threading.Tasks.Task<PageResourceChallengeEventParticipantResource> GetChallengeEventLeaderboardAsync (long? filterEvent = null);

        /// <summary>
        /// Retrieve a challenge event leaderboard details
        /// </summary>
        /// <remarks>
        /// Lists all leaderboard entries with additional user details
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterEvent">A sepecific challenge event id (optional)</param>
        /// <returns>Task of ApiResponse (PageResourceChallengeEventParticipantResource)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageResourceChallengeEventParticipantResource>> GetChallengeEventLeaderboardAsyncWithHttpInfo (long? filterEvent = null);
        /// <summary>
        /// Retrieve a challenge event participant details
        /// </summary>
        /// <remarks>
        /// Lists all user submitted scores sorted by value, including those that do not apear in the leaderboard due to value or aggregation
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterEvent">A sepecific challenge event id (optional)</param>
        /// <returns>Task of PageResourceChallengeEventParticipantResource</returns>
        System.Threading.Tasks.Task<PageResourceChallengeEventParticipantResource> GetChallengeEventParticipantsAsync (long? filterEvent = null);

        /// <summary>
        /// Retrieve a challenge event participant details
        /// </summary>
        /// <remarks>
        /// Lists all user submitted scores sorted by value, including those that do not apear in the leaderboard due to value or aggregation
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterEvent">A sepecific challenge event id (optional)</param>
        /// <returns>Task of ApiResponse (PageResourceChallengeEventParticipantResource)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageResourceChallengeEventParticipantResource>> GetChallengeEventParticipantsAsyncWithHttpInfo (long? filterEvent = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ReportingChallengesApi : IReportingChallengesApi
    {
        private com.knetikcloud.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingChallengesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReportingChallengesApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = com.knetikcloud.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingChallengesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ReportingChallengesApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = com.knetikcloud.Client.Configuration.DefaultExceptionFactory;

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
        /// Retrieve a challenge event leaderboard details Lists all leaderboard entries with additional user details
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterEvent">A sepecific challenge event id (optional)</param>
        /// <returns>PageResourceChallengeEventParticipantResource</returns>
        public PageResourceChallengeEventParticipantResource GetChallengeEventLeaderboard (long? filterEvent = null)
        {
             ApiResponse<PageResourceChallengeEventParticipantResource> localVarResponse = GetChallengeEventLeaderboardWithHttpInfo(filterEvent);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a challenge event leaderboard details Lists all leaderboard entries with additional user details
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterEvent">A sepecific challenge event id (optional)</param>
        /// <returns>ApiResponse of PageResourceChallengeEventParticipantResource</returns>
        public ApiResponse< PageResourceChallengeEventParticipantResource > GetChallengeEventLeaderboardWithHttpInfo (long? filterEvent = null)
        {

            var localVarPath = "/reporting/events/leaderboard";
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

            if (filterEvent != null) localVarQueryParams.Add("filter_event", Configuration.ApiClient.ParameterToString(filterEvent)); // query parameter

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
                Exception exception = ExceptionFactory("GetChallengeEventLeaderboard", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PageResourceChallengeEventParticipantResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageResourceChallengeEventParticipantResource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageResourceChallengeEventParticipantResource)));
            
        }

        /// <summary>
        /// Retrieve a challenge event leaderboard details Lists all leaderboard entries with additional user details
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterEvent">A sepecific challenge event id (optional)</param>
        /// <returns>Task of PageResourceChallengeEventParticipantResource</returns>
        public async System.Threading.Tasks.Task<PageResourceChallengeEventParticipantResource> GetChallengeEventLeaderboardAsync (long? filterEvent = null)
        {
             ApiResponse<PageResourceChallengeEventParticipantResource> localVarResponse = await GetChallengeEventLeaderboardAsyncWithHttpInfo(filterEvent);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve a challenge event leaderboard details Lists all leaderboard entries with additional user details
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterEvent">A sepecific challenge event id (optional)</param>
        /// <returns>Task of ApiResponse (PageResourceChallengeEventParticipantResource)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageResourceChallengeEventParticipantResource>> GetChallengeEventLeaderboardAsyncWithHttpInfo (long? filterEvent = null)
        {

            var localVarPath = "/reporting/events/leaderboard";
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

            if (filterEvent != null) localVarQueryParams.Add("filter_event", Configuration.ApiClient.ParameterToString(filterEvent)); // query parameter

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
                Exception exception = ExceptionFactory("GetChallengeEventLeaderboard", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PageResourceChallengeEventParticipantResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageResourceChallengeEventParticipantResource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageResourceChallengeEventParticipantResource)));
            
        }

        /// <summary>
        /// Retrieve a challenge event participant details Lists all user submitted scores sorted by value, including those that do not apear in the leaderboard due to value or aggregation
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterEvent">A sepecific challenge event id (optional)</param>
        /// <returns>PageResourceChallengeEventParticipantResource</returns>
        public PageResourceChallengeEventParticipantResource GetChallengeEventParticipants (long? filterEvent = null)
        {
             ApiResponse<PageResourceChallengeEventParticipantResource> localVarResponse = GetChallengeEventParticipantsWithHttpInfo(filterEvent);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a challenge event participant details Lists all user submitted scores sorted by value, including those that do not apear in the leaderboard due to value or aggregation
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterEvent">A sepecific challenge event id (optional)</param>
        /// <returns>ApiResponse of PageResourceChallengeEventParticipantResource</returns>
        public ApiResponse< PageResourceChallengeEventParticipantResource > GetChallengeEventParticipantsWithHttpInfo (long? filterEvent = null)
        {

            var localVarPath = "/reporting/events/participants";
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

            if (filterEvent != null) localVarQueryParams.Add("filter_event", Configuration.ApiClient.ParameterToString(filterEvent)); // query parameter

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
                Exception exception = ExceptionFactory("GetChallengeEventParticipants", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PageResourceChallengeEventParticipantResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageResourceChallengeEventParticipantResource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageResourceChallengeEventParticipantResource)));
            
        }

        /// <summary>
        /// Retrieve a challenge event participant details Lists all user submitted scores sorted by value, including those that do not apear in the leaderboard due to value or aggregation
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterEvent">A sepecific challenge event id (optional)</param>
        /// <returns>Task of PageResourceChallengeEventParticipantResource</returns>
        public async System.Threading.Tasks.Task<PageResourceChallengeEventParticipantResource> GetChallengeEventParticipantsAsync (long? filterEvent = null)
        {
             ApiResponse<PageResourceChallengeEventParticipantResource> localVarResponse = await GetChallengeEventParticipantsAsyncWithHttpInfo(filterEvent);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve a challenge event participant details Lists all user submitted scores sorted by value, including those that do not apear in the leaderboard due to value or aggregation
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterEvent">A sepecific challenge event id (optional)</param>
        /// <returns>Task of ApiResponse (PageResourceChallengeEventParticipantResource)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageResourceChallengeEventParticipantResource>> GetChallengeEventParticipantsAsyncWithHttpInfo (long? filterEvent = null)
        {

            var localVarPath = "/reporting/events/participants";
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

            if (filterEvent != null) localVarQueryParams.Add("filter_event", Configuration.ApiClient.ParameterToString(filterEvent)); // query parameter

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
                Exception exception = ExceptionFactory("GetChallengeEventParticipants", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PageResourceChallengeEventParticipantResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageResourceChallengeEventParticipantResource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageResourceChallengeEventParticipantResource)));
            
        }

    }
}
