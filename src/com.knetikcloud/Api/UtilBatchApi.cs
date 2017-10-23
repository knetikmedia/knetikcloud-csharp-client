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
    public interface IUtilBatchApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get batch result with token
        /// </summary>
        /// <remarks>
        /// Tokens expire in 24 hours
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">token</param>
        /// <returns>List&lt;BatchReturn&gt;</returns>
        List<BatchReturn> GetBatch (string token);

        /// <summary>
        /// Get batch result with token
        /// </summary>
        /// <remarks>
        /// Tokens expire in 24 hours
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">token</param>
        /// <returns>ApiResponse of List&lt;BatchReturn&gt;</returns>
        ApiResponse<List<BatchReturn>> GetBatchWithHttpInfo (string token);
        /// <summary>
        /// Request to run API call given the method, content type, path url, and body of request
        /// </summary>
        /// <remarks>
        /// Should the request take longer than one of the alloted timeout parameters, a token will be returned instead, which can be used on the token endpoint in this service
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batch">The batch object (optional)</param>
        /// <returns>List&lt;BatchReturn&gt;</returns>
        List<BatchReturn> SendBatch (Batch batch = null);

        /// <summary>
        /// Request to run API call given the method, content type, path url, and body of request
        /// </summary>
        /// <remarks>
        /// Should the request take longer than one of the alloted timeout parameters, a token will be returned instead, which can be used on the token endpoint in this service
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batch">The batch object (optional)</param>
        /// <returns>ApiResponse of List&lt;BatchReturn&gt;</returns>
        ApiResponse<List<BatchReturn>> SendBatchWithHttpInfo (Batch batch = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get batch result with token
        /// </summary>
        /// <remarks>
        /// Tokens expire in 24 hours
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">token</param>
        /// <returns>Task of List&lt;BatchReturn&gt;</returns>
        System.Threading.Tasks.Task<List<BatchReturn>> GetBatchAsync (string token);

        /// <summary>
        /// Get batch result with token
        /// </summary>
        /// <remarks>
        /// Tokens expire in 24 hours
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">token</param>
        /// <returns>Task of ApiResponse (List&lt;BatchReturn&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<BatchReturn>>> GetBatchAsyncWithHttpInfo (string token);
        /// <summary>
        /// Request to run API call given the method, content type, path url, and body of request
        /// </summary>
        /// <remarks>
        /// Should the request take longer than one of the alloted timeout parameters, a token will be returned instead, which can be used on the token endpoint in this service
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batch">The batch object (optional)</param>
        /// <returns>Task of List&lt;BatchReturn&gt;</returns>
        System.Threading.Tasks.Task<List<BatchReturn>> SendBatchAsync (Batch batch = null);

        /// <summary>
        /// Request to run API call given the method, content type, path url, and body of request
        /// </summary>
        /// <remarks>
        /// Should the request take longer than one of the alloted timeout parameters, a token will be returned instead, which can be used on the token endpoint in this service
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batch">The batch object (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;BatchReturn&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<BatchReturn>>> SendBatchAsyncWithHttpInfo (Batch batch = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UtilBatchApi : IUtilBatchApi
    {
        private com.knetikcloud.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UtilBatchApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UtilBatchApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = com.knetikcloud.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UtilBatchApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UtilBatchApi(Configuration configuration = null)
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
        /// Get batch result with token Tokens expire in 24 hours
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">token</param>
        /// <returns>List&lt;BatchReturn&gt;</returns>
        public List<BatchReturn> GetBatch (string token)
        {
             ApiResponse<List<BatchReturn>> localVarResponse = GetBatchWithHttpInfo(token);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get batch result with token Tokens expire in 24 hours
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">token</param>
        /// <returns>ApiResponse of List&lt;BatchReturn&gt;</returns>
        public ApiResponse< List<BatchReturn> > GetBatchWithHttpInfo (string token)
        {
            // verify the required parameter 'token' is set
            if (token == null)
                throw new ApiException(400, "Missing required parameter 'token' when calling UtilBatchApi->GetBatch");

            var localVarPath = "/batch/{token}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
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

            if (token != null) localVarPathParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetBatch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<BatchReturn>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<BatchReturn>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<BatchReturn>)));
        }

        /// <summary>
        /// Get batch result with token Tokens expire in 24 hours
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">token</param>
        /// <returns>Task of List&lt;BatchReturn&gt;</returns>
        public async System.Threading.Tasks.Task<List<BatchReturn>> GetBatchAsync (string token)
        {
             ApiResponse<List<BatchReturn>> localVarResponse = await GetBatchAsyncWithHttpInfo(token);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get batch result with token Tokens expire in 24 hours
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">token</param>
        /// <returns>Task of ApiResponse (List&lt;BatchReturn&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<BatchReturn>>> GetBatchAsyncWithHttpInfo (string token)
        {
            // verify the required parameter 'token' is set
            if (token == null)
                throw new ApiException(400, "Missing required parameter 'token' when calling UtilBatchApi->GetBatch");

            var localVarPath = "/batch/{token}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
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

            if (token != null) localVarPathParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetBatch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<BatchReturn>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<BatchReturn>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<BatchReturn>)));
        }

        /// <summary>
        /// Request to run API call given the method, content type, path url, and body of request Should the request take longer than one of the alloted timeout parameters, a token will be returned instead, which can be used on the token endpoint in this service
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batch">The batch object (optional)</param>
        /// <returns>List&lt;BatchReturn&gt;</returns>
        public List<BatchReturn> SendBatch (Batch batch = null)
        {
             ApiResponse<List<BatchReturn>> localVarResponse = SendBatchWithHttpInfo(batch);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Request to run API call given the method, content type, path url, and body of request Should the request take longer than one of the alloted timeout parameters, a token will be returned instead, which can be used on the token endpoint in this service
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batch">The batch object (optional)</param>
        /// <returns>ApiResponse of List&lt;BatchReturn&gt;</returns>
        public ApiResponse< List<BatchReturn> > SendBatchWithHttpInfo (Batch batch = null)
        {

            var localVarPath = "/batch";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
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

            if (batch != null && batch.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(batch); // http body (model) parameter
            }
            else
            {
                localVarPostBody = batch; // byte array
            }

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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SendBatch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<BatchReturn>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<BatchReturn>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<BatchReturn>)));
        }

        /// <summary>
        /// Request to run API call given the method, content type, path url, and body of request Should the request take longer than one of the alloted timeout parameters, a token will be returned instead, which can be used on the token endpoint in this service
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batch">The batch object (optional)</param>
        /// <returns>Task of List&lt;BatchReturn&gt;</returns>
        public async System.Threading.Tasks.Task<List<BatchReturn>> SendBatchAsync (Batch batch = null)
        {
             ApiResponse<List<BatchReturn>> localVarResponse = await SendBatchAsyncWithHttpInfo(batch);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Request to run API call given the method, content type, path url, and body of request Should the request take longer than one of the alloted timeout parameters, a token will be returned instead, which can be used on the token endpoint in this service
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batch">The batch object (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;BatchReturn&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<BatchReturn>>> SendBatchAsyncWithHttpInfo (Batch batch = null)
        {

            var localVarPath = "/batch";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
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

            if (batch != null && batch.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(batch); // http body (model) parameter
            }
            else
            {
                localVarPostBody = batch; // byte array
            }

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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SendBatch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<BatchReturn>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<BatchReturn>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<BatchReturn>)));
        }

    }
}
