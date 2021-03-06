# com.knetikcloud.Api.Auth_ClientsApi

All URIs are relative to *https://jsapi-integration.us-east-1.elasticbeanstalk.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateClient**](Auth_ClientsApi.md#createclient) | **POST** /auth/clients | Create a new client
[**DeleteClient**](Auth_ClientsApi.md#deleteclient) | **DELETE** /auth/clients/{client_key} | Delete a client
[**GetClient**](Auth_ClientsApi.md#getclient) | **GET** /auth/clients/{client_key} | Get a single client
[**GetClientGrantTypes**](Auth_ClientsApi.md#getclientgranttypes) | **GET** /auth/clients/grant-types | List available client grant types
[**GetClients**](Auth_ClientsApi.md#getclients) | **GET** /auth/clients | List and search clients
[**SetClientGrantTypes**](Auth_ClientsApi.md#setclientgranttypes) | **PUT** /auth/clients/{client_key}/grant-types | Set grant types for a client
[**SetClientRedirectUris**](Auth_ClientsApi.md#setclientredirecturis) | **PUT** /auth/clients/{client_key}/redirect-uris | Set redirect uris for a client
[**UpdateClient**](Auth_ClientsApi.md#updateclient) | **PUT** /auth/clients/{client_key} | Update a client


<a name="createclient"></a>
# **CreateClient**
> ClientResource CreateClient (ClientResource clientResource = null)

Create a new client

<b>Permissions Needed:</b> CLIENTS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateClientExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Auth_ClientsApi();
            var clientResource = new ClientResource(); // ClientResource | The client resource object (optional) 

            try
            {
                // Create a new client
                ClientResource result = apiInstance.CreateClient(clientResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Auth_ClientsApi.CreateClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientResource** | [**ClientResource**](ClientResource.md)| The client resource object | [optional] 

### Return type

[**ClientResource**](ClientResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteclient"></a>
# **DeleteClient**
> void DeleteClient (string clientKey)

Delete a client

<b>Permissions Needed:</b> CLIENTS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteClientExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Auth_ClientsApi();
            var clientKey = clientKey_example;  // string | The key of the client

            try
            {
                // Delete a client
                apiInstance.DeleteClient(clientKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Auth_ClientsApi.DeleteClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientKey** | **string**| The key of the client | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclient"></a>
# **GetClient**
> ClientResource GetClient (string clientKey)

Get a single client

<b>Permissions Needed:</b> CLIENTS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetClientExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Auth_ClientsApi();
            var clientKey = clientKey_example;  // string | The key of the client

            try
            {
                // Get a single client
                ClientResource result = apiInstance.GetClient(clientKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Auth_ClientsApi.GetClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientKey** | **string**| The key of the client | 

### Return type

[**ClientResource**](ClientResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclientgranttypes"></a>
# **GetClientGrantTypes**
> List<GrantTypeResource> GetClientGrantTypes ()

List available client grant types

<b>Permissions Needed:</b> CLIENTS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetClientGrantTypesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Auth_ClientsApi();

            try
            {
                // List available client grant types
                List&lt;GrantTypeResource&gt; result = apiInstance.GetClientGrantTypes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Auth_ClientsApi.GetClientGrantTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<GrantTypeResource>**](GrantTypeResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclients"></a>
# **GetClients**
> PageResourceClientResource GetClients (int? size = null, int? page = null, string order = null)

List and search clients

<b>Permissions Needed:</b> CLIENTS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetClientsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Auth_ClientsApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search clients
                PageResourceClientResource result = apiInstance.GetClients(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Auth_ClientsApi.GetClients: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourceClientResource**](PageResourceClientResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setclientgranttypes"></a>
# **SetClientGrantTypes**
> void SetClientGrantTypes (string clientKey, List<string> grantList = null)

Set grant types for a client

<b>Permissions Needed:</b> CLIENTS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SetClientGrantTypesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Auth_ClientsApi();
            var clientKey = clientKey_example;  // string | The key of the client
            var grantList = ;  // List<string> | A list of unique grant types (optional) 

            try
            {
                // Set grant types for a client
                apiInstance.SetClientGrantTypes(clientKey, grantList);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Auth_ClientsApi.SetClientGrantTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientKey** | **string**| The key of the client | 
 **grantList** | **List&lt;string&gt;**| A list of unique grant types | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setclientredirecturis"></a>
# **SetClientRedirectUris**
> void SetClientRedirectUris (string clientKey, List<string> redirectList = null)

Set redirect uris for a client

<b>Permissions Needed:</b> CLIENTS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SetClientRedirectUrisExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Auth_ClientsApi();
            var clientKey = clientKey_example;  // string | The key of the client
            var redirectList = ;  // List<string> | A list of unique redirect uris (optional) 

            try
            {
                // Set redirect uris for a client
                apiInstance.SetClientRedirectUris(clientKey, redirectList);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Auth_ClientsApi.SetClientRedirectUris: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientKey** | **string**| The key of the client | 
 **redirectList** | **List&lt;string&gt;**| A list of unique redirect uris | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateclient"></a>
# **UpdateClient**
> ClientResource UpdateClient (string clientKey, ClientResource clientResource = null)

Update a client

<b>Permissions Needed:</b> CLIENTS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateClientExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Auth_ClientsApi();
            var clientKey = clientKey_example;  // string | The key of the client
            var clientResource = new ClientResource(); // ClientResource | The client resource object (optional) 

            try
            {
                // Update a client
                ClientResource result = apiInstance.UpdateClient(clientKey, clientResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Auth_ClientsApi.UpdateClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientKey** | **string**| The key of the client | 
 **clientResource** | [**ClientResource**](ClientResource.md)| The client resource object | [optional] 

### Return type

[**ClientResource**](ClientResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

