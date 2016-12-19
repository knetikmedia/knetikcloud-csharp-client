/* 
 * Knetik Platform API Documentation Latest
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
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
    public interface IUtilSecurityApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Returns the authentication log for a user
        /// </summary>
        /// <remarks>
        /// A log entry is recorded everytime a user requests a new token. Standard pagination available
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The user id (optional)</param>
        /// <returns>PageLocationLogResource</returns>
        PageLocationLogResource GetUserLocationLogUsingGET (int? userId = null);

        /// <summary>
        /// Returns the authentication log for a user
        /// </summary>
        /// <remarks>
        /// A log entry is recorded everytime a user requests a new token. Standard pagination available
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The user id (optional)</param>
        /// <returns>ApiResponse of PageLocationLogResource</returns>
        ApiResponse<PageLocationLogResource> GetUserLocationLogUsingGETWithHttpInfo (int? userId = null);
        /// <summary>
        /// Returns the authentication token details. Use /users endpoint for detailed user&#39;s info
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>TokenDetailsResource</returns>
        TokenDetailsResource UserUsingGET ();

        /// <summary>
        /// Returns the authentication token details. Use /users endpoint for detailed user&#39;s info
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of TokenDetailsResource</returns>
        ApiResponse<TokenDetailsResource> UserUsingGETWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Returns the authentication log for a user
        /// </summary>
        /// <remarks>
        /// A log entry is recorded everytime a user requests a new token. Standard pagination available
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The user id (optional)</param>
        /// <returns>Task of PageLocationLogResource</returns>
        System.Threading.Tasks.Task<PageLocationLogResource> GetUserLocationLogUsingGETAsync (int? userId = null);

        /// <summary>
        /// Returns the authentication log for a user
        /// </summary>
        /// <remarks>
        /// A log entry is recorded everytime a user requests a new token. Standard pagination available
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The user id (optional)</param>
        /// <returns>Task of ApiResponse (PageLocationLogResource)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageLocationLogResource>> GetUserLocationLogUsingGETAsyncWithHttpInfo (int? userId = null);
        /// <summary>
        /// Returns the authentication token details. Use /users endpoint for detailed user&#39;s info
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of TokenDetailsResource</returns>
        System.Threading.Tasks.Task<TokenDetailsResource> UserUsingGETAsync ();

        /// <summary>
        /// Returns the authentication token details. Use /users endpoint for detailed user&#39;s info
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (TokenDetailsResource)</returns>
        System.Threading.Tasks.Task<ApiResponse<TokenDetailsResource>> UserUsingGETAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UtilSecurityApi : IUtilSecurityApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UtilSecurityApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UtilSecurityApi(String basePath)
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
        /// Initializes a new instance of the <see cref="UtilSecurityApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UtilSecurityApi(Configuration configuration = null)
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
        /// Returns the authentication log for a user A log entry is recorded everytime a user requests a new token. Standard pagination available
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The user id (optional)</param>
        /// <returns>PageLocationLogResource</returns>
        public PageLocationLogResource GetUserLocationLogUsingGET (int? userId = null)
        {
             ApiResponse<PageLocationLogResource> localVarResponse = GetUserLocationLogUsingGETWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the authentication log for a user A log entry is recorded everytime a user requests a new token. Standard pagination available
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The user id (optional)</param>
        /// <returns>ApiResponse of PageLocationLogResource</returns>
        public ApiResponse< PageLocationLogResource > GetUserLocationLogUsingGETWithHttpInfo (int? userId = null)
        {

            var localVarPath = "/security/country-log";
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
            if (userId != null) localVarQueryParams.Add("user_id", Configuration.ApiClient.ParameterToString(userId)); // query parameter

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
                Exception exception = ExceptionFactory("GetUserLocationLogUsingGET", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PageLocationLogResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageLocationLogResource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageLocationLogResource)));
            
        }

        /// <summary>
        /// Returns the authentication log for a user A log entry is recorded everytime a user requests a new token. Standard pagination available
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The user id (optional)</param>
        /// <returns>Task of PageLocationLogResource</returns>
        public async System.Threading.Tasks.Task<PageLocationLogResource> GetUserLocationLogUsingGETAsync (int? userId = null)
        {
             ApiResponse<PageLocationLogResource> localVarResponse = await GetUserLocationLogUsingGETAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns the authentication log for a user A log entry is recorded everytime a user requests a new token. Standard pagination available
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The user id (optional)</param>
        /// <returns>Task of ApiResponse (PageLocationLogResource)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageLocationLogResource>> GetUserLocationLogUsingGETAsyncWithHttpInfo (int? userId = null)
        {

            var localVarPath = "/security/country-log";
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
            if (userId != null) localVarQueryParams.Add("user_id", Configuration.ApiClient.ParameterToString(userId)); // query parameter

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
                Exception exception = ExceptionFactory("GetUserLocationLogUsingGET", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PageLocationLogResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageLocationLogResource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageLocationLogResource)));
            
        }

        /// <summary>
        /// Returns the authentication token details. Use /users endpoint for detailed user&#39;s info 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>TokenDetailsResource</returns>
        public TokenDetailsResource UserUsingGET ()
        {
             ApiResponse<TokenDetailsResource> localVarResponse = UserUsingGETWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the authentication token details. Use /users endpoint for detailed user&#39;s info 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of TokenDetailsResource</returns>
        public ApiResponse< TokenDetailsResource > UserUsingGETWithHttpInfo ()
        {

            var localVarPath = "/me";
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
                Exception exception = ExceptionFactory("UserUsingGET", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TokenDetailsResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TokenDetailsResource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TokenDetailsResource)));
            
        }

        /// <summary>
        /// Returns the authentication token details. Use /users endpoint for detailed user&#39;s info 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of TokenDetailsResource</returns>
        public async System.Threading.Tasks.Task<TokenDetailsResource> UserUsingGETAsync ()
        {
             ApiResponse<TokenDetailsResource> localVarResponse = await UserUsingGETAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns the authentication token details. Use /users endpoint for detailed user&#39;s info 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (TokenDetailsResource)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TokenDetailsResource>> UserUsingGETAsyncWithHttpInfo ()
        {

            var localVarPath = "/me";
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
                Exception exception = ExceptionFactory("UserUsingGET", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TokenDetailsResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TokenDetailsResource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TokenDetailsResource)));
            
        }

    }
}
