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
    public interface IPaymentsGoogleApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Mark an invoice paid with Google
        /// </summary>
        /// <remarks>
        /// Mark an invoice paid with Google. Verifies signature from Google and treats the developerPayload field inside the json payload as the id of the invoice to pay. Returns the transaction ID if successful.
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request for paying an invoice through a Google in-app payment (optional)</param>
        /// <returns>int?</returns>
        int? HandleGooglePayment (GooglePaymentRequest request = null);

        /// <summary>
        /// Mark an invoice paid with Google
        /// </summary>
        /// <remarks>
        /// Mark an invoice paid with Google. Verifies signature from Google and treats the developerPayload field inside the json payload as the id of the invoice to pay. Returns the transaction ID if successful.
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request for paying an invoice through a Google in-app payment (optional)</param>
        /// <returns>ApiResponse of int?</returns>
        ApiResponse<int?> HandleGooglePaymentWithHttpInfo (GooglePaymentRequest request = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Mark an invoice paid with Google
        /// </summary>
        /// <remarks>
        /// Mark an invoice paid with Google. Verifies signature from Google and treats the developerPayload field inside the json payload as the id of the invoice to pay. Returns the transaction ID if successful.
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request for paying an invoice through a Google in-app payment (optional)</param>
        /// <returns>Task of int?</returns>
        System.Threading.Tasks.Task<int?> HandleGooglePaymentAsync (GooglePaymentRequest request = null);

        /// <summary>
        /// Mark an invoice paid with Google
        /// </summary>
        /// <remarks>
        /// Mark an invoice paid with Google. Verifies signature from Google and treats the developerPayload field inside the json payload as the id of the invoice to pay. Returns the transaction ID if successful.
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request for paying an invoice through a Google in-app payment (optional)</param>
        /// <returns>Task of ApiResponse (int?)</returns>
        System.Threading.Tasks.Task<ApiResponse<int?>> HandleGooglePaymentAsyncWithHttpInfo (GooglePaymentRequest request = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PaymentsGoogleApi : IPaymentsGoogleApi
    {
        private com.knetikcloud.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsGoogleApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PaymentsGoogleApi(String basePath)
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
        /// Initializes a new instance of the <see cref="PaymentsGoogleApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PaymentsGoogleApi(Configuration configuration = null)
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
        /// Mark an invoice paid with Google Mark an invoice paid with Google. Verifies signature from Google and treats the developerPayload field inside the json payload as the id of the invoice to pay. Returns the transaction ID if successful.
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request for paying an invoice through a Google in-app payment (optional)</param>
        /// <returns>int?</returns>
        public int? HandleGooglePayment (GooglePaymentRequest request = null)
        {
             ApiResponse<int?> localVarResponse = HandleGooglePaymentWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Mark an invoice paid with Google Mark an invoice paid with Google. Verifies signature from Google and treats the developerPayload field inside the json payload as the id of the invoice to pay. Returns the transaction ID if successful.
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request for paying an invoice through a Google in-app payment (optional)</param>
        /// <returns>ApiResponse of int?</returns>
        public ApiResponse< int? > HandleGooglePaymentWithHttpInfo (GooglePaymentRequest request = null)
        {

            var localVarPath = "/payment/provider/google/payments";
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
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("HandleGooglePayment", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<int?>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(localVarResponse, typeof(int?)));
            
        }

        /// <summary>
        /// Mark an invoice paid with Google Mark an invoice paid with Google. Verifies signature from Google and treats the developerPayload field inside the json payload as the id of the invoice to pay. Returns the transaction ID if successful.
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request for paying an invoice through a Google in-app payment (optional)</param>
        /// <returns>Task of int?</returns>
        public async System.Threading.Tasks.Task<int?> HandleGooglePaymentAsync (GooglePaymentRequest request = null)
        {
             ApiResponse<int?> localVarResponse = await HandleGooglePaymentAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Mark an invoice paid with Google Mark an invoice paid with Google. Verifies signature from Google and treats the developerPayload field inside the json payload as the id of the invoice to pay. Returns the transaction ID if successful.
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request for paying an invoice through a Google in-app payment (optional)</param>
        /// <returns>Task of ApiResponse (int?)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<int?>> HandleGooglePaymentAsyncWithHttpInfo (GooglePaymentRequest request = null)
        {

            var localVarPath = "/payment/provider/google/payments";
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
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("HandleGooglePayment", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<int?>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(localVarResponse, typeof(int?)));
            
        }

    }
}
