# IO.Swagger.Api.AuthClientsApi

All URIs are relative to *https://integration.knetikcloud.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssignClientGrantTypesUsingPUT**](AuthClientsApi.md#assignclientgranttypesusingput) | **PUT** /auth/clients/{client_key}/grant-types | Set grant types for a client
[**AssignClientRedirectUrisUsingPUT**](AuthClientsApi.md#assignclientredirecturisusingput) | **PUT** /auth/clients/{client_key}/redirect-uris | Set redirect uris for a client
[**CreateClientUsingPOST**](AuthClientsApi.md#createclientusingpost) | **POST** /auth/clients | Create a new client
[**DeleteClientUsingDELETE**](AuthClientsApi.md#deleteclientusingdelete) | **DELETE** /auth/clients/{client_key} | Delete a client
[**GetClientUsingGET**](AuthClientsApi.md#getclientusingget) | **GET** /auth/clients/{client_key} | Get a single client
[**GetClientsUsingGET**](AuthClientsApi.md#getclientsusingget) | **GET** /auth/clients | List and search clients
[**ListAvailableGrantTypesUsingGET**](AuthClientsApi.md#listavailablegranttypesusingget) | **GET** /auth/clients/grant-types | List available client grant types
[**UpdateClientUsingPUT**](AuthClientsApi.md#updateclientusingput) | **PUT** /auth/clients/{client_key} | Update a client


<a name="assignclientgranttypesusingput"></a>
# **AssignClientGrantTypesUsingPUT**
> void AssignClientGrantTypesUsingPUT (string clientKey, List<string> grantList = null)

Set grant types for a client

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AssignClientGrantTypesUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthClientsApi();
            var clientKey = clientKey_example;  // string | The key of the client
            var grantList = ;  // List<string> | A list of unique grant types (optional) 

            try
            {
                // Set grant types for a client
                apiInstance.AssignClientGrantTypesUsingPUT(clientKey, grantList);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthClientsApi.AssignClientGrantTypesUsingPUT: " + e.Message );
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

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assignclientredirecturisusingput"></a>
# **AssignClientRedirectUrisUsingPUT**
> void AssignClientRedirectUrisUsingPUT (string clientKey, List<string> redirectList = null)

Set redirect uris for a client

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AssignClientRedirectUrisUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthClientsApi();
            var clientKey = clientKey_example;  // string | The key of the client
            var redirectList = ;  // List<string> | A list of unique redirect uris (optional) 

            try
            {
                // Set redirect uris for a client
                apiInstance.AssignClientRedirectUrisUsingPUT(clientKey, redirectList);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthClientsApi.AssignClientRedirectUrisUsingPUT: " + e.Message );
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

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createclientusingpost"></a>
# **CreateClientUsingPOST**
> ClientResource CreateClientUsingPOST (ClientResource clientResource = null)

Create a new client

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateClientUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthClientsApi();
            var clientResource = new ClientResource(); // ClientResource | The client resource object (optional) 

            try
            {
                // Create a new client
                ClientResource result = apiInstance.CreateClientUsingPOST(clientResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthClientsApi.CreateClientUsingPOST: " + e.Message );
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

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteclientusingdelete"></a>
# **DeleteClientUsingDELETE**
> void DeleteClientUsingDELETE (string clientKey)

Delete a client

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteClientUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthClientsApi();
            var clientKey = clientKey_example;  // string | The key of the client

            try
            {
                // Delete a client
                apiInstance.DeleteClientUsingDELETE(clientKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthClientsApi.DeleteClientUsingDELETE: " + e.Message );
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

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclientusingget"></a>
# **GetClientUsingGET**
> ClientResource GetClientUsingGET (string clientKey)

Get a single client

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthClientsApi();
            var clientKey = clientKey_example;  // string | The key of the client

            try
            {
                // Get a single client
                ClientResource result = apiInstance.GetClientUsingGET(clientKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthClientsApi.GetClientUsingGET: " + e.Message );
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

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclientsusingget"></a>
# **GetClientsUsingGET**
> PageResourceClientResource GetClientsUsingGET (int? size = null, int? page = null, string order = null)

List and search clients

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientsUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthClientsApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search clients
                PageResourceClientResource result = apiInstance.GetClientsUsingGET(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthClientsApi.GetClientsUsingGET: " + e.Message );
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

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listavailablegranttypesusingget"></a>
# **ListAvailableGrantTypesUsingGET**
> List<GrantTypeResource> ListAvailableGrantTypesUsingGET ()

List available client grant types

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListAvailableGrantTypesUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthClientsApi();

            try
            {
                // List available client grant types
                List&lt;GrantTypeResource&gt; result = apiInstance.ListAvailableGrantTypesUsingGET();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthClientsApi.ListAvailableGrantTypesUsingGET: " + e.Message );
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

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateclientusingput"></a>
# **UpdateClientUsingPUT**
> void UpdateClientUsingPUT (string clientKey, ClientResource clientResource = null)

Update a client

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateClientUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthClientsApi();
            var clientKey = clientKey_example;  // string | The key of the client
            var clientResource = new ClientResource(); // ClientResource | The client resource object (optional) 

            try
            {
                // Update a client
                apiInstance.UpdateClientUsingPUT(clientKey, clientResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthClientsApi.UpdateClientUsingPUT: " + e.Message );
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

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

