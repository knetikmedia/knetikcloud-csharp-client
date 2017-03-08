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
    public interface IAmazonWebServicesS3Api : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get a signed S3 URL
        /// </summary>
        /// <remarks>
        /// Requires the file name and file content type (i.e., &#39;video/mpeg&#39;)
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filename">The file name (optional)</param>
        /// <param name="contentType">The content type (optional)</param>
        /// <returns>AmazonS3Activity</returns>
        AmazonS3Activity GetSignedS3URL (string filename = null, string contentType = null);

        /// <summary>
        /// Get a signed S3 URL
        /// </summary>
        /// <remarks>
        /// Requires the file name and file content type (i.e., &#39;video/mpeg&#39;)
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filename">The file name (optional)</param>
        /// <param name="contentType">The content type (optional)</param>
        /// <returns>ApiResponse of AmazonS3Activity</returns>
        ApiResponse<AmazonS3Activity> GetSignedS3URLWithHttpInfo (string filename = null, string contentType = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get a signed S3 URL
        /// </summary>
        /// <remarks>
        /// Requires the file name and file content type (i.e., &#39;video/mpeg&#39;)
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filename">The file name (optional)</param>
        /// <param name="contentType">The content type (optional)</param>
        /// <returns>Task of AmazonS3Activity</returns>
        System.Threading.Tasks.Task<AmazonS3Activity> GetSignedS3URLAsync (string filename = null, string contentType = null);

        /// <summary>
        /// Get a signed S3 URL
        /// </summary>
        /// <remarks>
        /// Requires the file name and file content type (i.e., &#39;video/mpeg&#39;)
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filename">The file name (optional)</param>
        /// <param name="contentType">The content type (optional)</param>
        /// <returns>Task of ApiResponse (AmazonS3Activity)</returns>
        System.Threading.Tasks.Task<ApiResponse<AmazonS3Activity>> GetSignedS3URLAsyncWithHttpInfo (string filename = null, string contentType = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AmazonWebServicesS3Api : IAmazonWebServicesS3Api
    {
        private com.knetikcloud.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AmazonWebServicesS3Api"/> class.
        /// </summary>
        /// <returns></returns>
        public AmazonWebServicesS3Api(String basePath)
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
        /// Initializes a new instance of the <see cref="AmazonWebServicesS3Api"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AmazonWebServicesS3Api(Configuration configuration = null)
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
        /// Get a signed S3 URL Requires the file name and file content type (i.e., &#39;video/mpeg&#39;)
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filename">The file name (optional)</param>
        /// <param name="contentType">The content type (optional)</param>
        /// <returns>AmazonS3Activity</returns>
        public AmazonS3Activity GetSignedS3URL (string filename = null, string contentType = null)
        {
             ApiResponse<AmazonS3Activity> localVarResponse = GetSignedS3URLWithHttpInfo(filename, contentType);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a signed S3 URL Requires the file name and file content type (i.e., &#39;video/mpeg&#39;)
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filename">The file name (optional)</param>
        /// <param name="contentType">The content type (optional)</param>
        /// <returns>ApiResponse of AmazonS3Activity</returns>
        public ApiResponse< AmazonS3Activity > GetSignedS3URLWithHttpInfo (string filename = null, string contentType = null)
        {

            var localVarPath = "/amazon/s3/signedposturl";
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

            if (filename != null) localVarQueryParams.Add("filename", Configuration.ApiClient.ParameterToString(filename)); // query parameter
            if (contentType != null) localVarQueryParams.Add("content_type", Configuration.ApiClient.ParameterToString(contentType)); // query parameter

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
                Exception exception = ExceptionFactory("GetSignedS3URL", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AmazonS3Activity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AmazonS3Activity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AmazonS3Activity)));
            
        }

        /// <summary>
        /// Get a signed S3 URL Requires the file name and file content type (i.e., &#39;video/mpeg&#39;)
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filename">The file name (optional)</param>
        /// <param name="contentType">The content type (optional)</param>
        /// <returns>Task of AmazonS3Activity</returns>
        public async System.Threading.Tasks.Task<AmazonS3Activity> GetSignedS3URLAsync (string filename = null, string contentType = null)
        {
             ApiResponse<AmazonS3Activity> localVarResponse = await GetSignedS3URLAsyncWithHttpInfo(filename, contentType);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a signed S3 URL Requires the file name and file content type (i.e., &#39;video/mpeg&#39;)
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filename">The file name (optional)</param>
        /// <param name="contentType">The content type (optional)</param>
        /// <returns>Task of ApiResponse (AmazonS3Activity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AmazonS3Activity>> GetSignedS3URLAsyncWithHttpInfo (string filename = null, string contentType = null)
        {

            var localVarPath = "/amazon/s3/signedposturl";
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

            if (filename != null) localVarQueryParams.Add("filename", Configuration.ApiClient.ParameterToString(filename)); // query parameter
            if (contentType != null) localVarQueryParams.Add("content_type", Configuration.ApiClient.ParameterToString(contentType)); // query parameter

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
                Exception exception = ExceptionFactory("GetSignedS3URL", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AmazonS3Activity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AmazonS3Activity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AmazonS3Activity)));
            
        }

    }
}
