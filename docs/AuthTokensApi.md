# IO.Swagger.Api.AuthTokensApi

All URIs are relative to *https://integration.knetikcloud.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteTokenUsingDELETE**](AuthTokensApi.md#deletetokenusingdelete) | **DELETE** /auth/tokens/{username} | Delete all tokens by username
[**DeleteTokenWithClientIdUsingDELETE**](AuthTokensApi.md#deletetokenwithclientidusingdelete) | **DELETE** /auth/tokens/{username}/{client_id} | Delete a token by username and client id
[**GetTokenByUserUsingGET**](AuthTokensApi.md#gettokenbyuserusingget) | **GET** /auth/tokens/{username}/{client_id} | Get a single token by username and client id
[**GetTokensUsingGET**](AuthTokensApi.md#gettokensusingget) | **GET** /auth/tokens | List usernames and client ids


<a name="deletetokenusingdelete"></a>
# **DeleteTokenUsingDELETE**
> void DeleteTokenUsingDELETE (string username)

Delete all tokens by username

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteTokenUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthTokensApi();
            var username = username_example;  // string | The username of the user

            try
            {
                // Delete all tokens by username
                apiInstance.DeleteTokenUsingDELETE(username);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthTokensApi.DeleteTokenUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The username of the user | 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetokenwithclientidusingdelete"></a>
# **DeleteTokenWithClientIdUsingDELETE**
> void DeleteTokenWithClientIdUsingDELETE (string username, string clientId)

Delete a token by username and client id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteTokenWithClientIdUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthTokensApi();
            var username = username_example;  // string | The username of the user
            var clientId = clientId_example;  // string | The id of the client

            try
            {
                // Delete a token by username and client id
                apiInstance.DeleteTokenWithClientIdUsingDELETE(username, clientId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthTokensApi.DeleteTokenWithClientIdUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The username of the user | 
 **clientId** | **string**| The id of the client | 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettokenbyuserusingget"></a>
# **GetTokenByUserUsingGET**
> OauthAccessTokenResource GetTokenByUserUsingGET (string username, string clientId)

Get a single token by username and client id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTokenByUserUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthTokensApi();
            var username = username_example;  // string | The username of the user
            var clientId = clientId_example;  // string | The id of the client

            try
            {
                // Get a single token by username and client id
                OauthAccessTokenResource result = apiInstance.GetTokenByUserUsingGET(username, clientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthTokensApi.GetTokenByUserUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The username of the user | 
 **clientId** | **string**| The id of the client | 

### Return type

[**OauthAccessTokenResource**](OauthAccessTokenResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettokensusingget"></a>
# **GetTokensUsingGET**
> PageResourceOauthAccessTokenResource GetTokensUsingGET (string filterClientId = null, string filterUsername = null, int? size = null, int? page = null, string order = null)

List usernames and client ids

Token value not shown

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTokensUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthTokensApi();
            var filterClientId = filterClientId_example;  // string | Filters for token whose client id matches provided string (optional) 
            var filterUsername = filterUsername_example;  // string | Filters for token whose username matches provided string (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to username:ASC)

            try
            {
                // List usernames and client ids
                PageResourceOauthAccessTokenResource result = apiInstance.GetTokensUsingGET(filterClientId, filterUsername, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthTokensApi.GetTokensUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterClientId** | **string**| Filters for token whose client id matches provided string | [optional] 
 **filterUsername** | **string**| Filters for token whose username matches provided string | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to username:ASC]

### Return type

[**PageResourceOauthAccessTokenResource**](PageResourceOauthAccessTokenResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

