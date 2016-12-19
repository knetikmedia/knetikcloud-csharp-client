# IO.Swagger.Api.UsersAddressesApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAddressUsingPOST**](UsersAddressesApi.md#createaddressusingpost) | **POST** /users/{user_id}/addresses | Save a new address
[**DeleteAddressUsingDELETE**](UsersAddressesApi.md#deleteaddressusingdelete) | **DELETE** /users/{user_id}/addresses/{id} | Delete an address
[**GetAddressUsingGET**](UsersAddressesApi.md#getaddressusingget) | **GET** /users/{user_id}/addresses/{id} | Get a single address
[**GetAddressesUsingGET**](UsersAddressesApi.md#getaddressesusingget) | **GET** /users/{user_id}/addresses | List and search addresses
[**UpdateAddressUsingPUT**](UsersAddressesApi.md#updateaddressusingput) | **PUT** /users/{user_id}/addresses/{id} | Update an address


<a name="createaddressusingpost"></a>
# **CreateAddressUsingPOST**
> SavedAddressResource CreateAddressUsingPOST (string userId, SavedAddressResource savedAddressResource = null)

Save a new address

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateAddressUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersAddressesApi();
            var userId = userId_example;  // string | The id of the user
            var savedAddressResource = new SavedAddressResource(); // SavedAddressResource | The new address (optional) 

            try
            {
                // Save a new address
                SavedAddressResource result = apiInstance.CreateAddressUsingPOST(userId, savedAddressResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersAddressesApi.CreateAddressUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the user | 
 **savedAddressResource** | [**SavedAddressResource**](SavedAddressResource.md)| The new address | [optional] 

### Return type

[**SavedAddressResource**](SavedAddressResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteaddressusingdelete"></a>
# **DeleteAddressUsingDELETE**
> void DeleteAddressUsingDELETE (string userId, int? id)

Delete an address

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAddressUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersAddressesApi();
            var userId = userId_example;  // string | The id of the user
            var id = 56;  // int? | The id of the address

            try
            {
                // Delete an address
                apiInstance.DeleteAddressUsingDELETE(userId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersAddressesApi.DeleteAddressUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the user | 
 **id** | **int?**| The id of the address | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaddressusingget"></a>
# **GetAddressUsingGET**
> SavedAddressResource GetAddressUsingGET (string userId, int? id)

Get a single address

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAddressUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersAddressesApi();
            var userId = userId_example;  // string | The id of the user
            var id = 56;  // int? | The id of the address

            try
            {
                // Get a single address
                SavedAddressResource result = apiInstance.GetAddressUsingGET(userId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersAddressesApi.GetAddressUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the user | 
 **id** | **int?**| The id of the address | 

### Return type

[**SavedAddressResource**](SavedAddressResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaddressesusingget"></a>
# **GetAddressesUsingGET**
> PageSavedAddressResource GetAddressesUsingGET (string userId, int? size = null, int? page = null, string order = null)

List and search addresses

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAddressesUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersAddressesApi();
            var userId = userId_example;  // string | The id of the user
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | a comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to 1)

            try
            {
                // List and search addresses
                PageSavedAddressResource result = apiInstance.GetAddressesUsingGET(userId, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersAddressesApi.GetAddressesUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the user | 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| a comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to 1]

### Return type

[**PageSavedAddressResource**](PageSavedAddressResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateaddressusingput"></a>
# **UpdateAddressUsingPUT**
> void UpdateAddressUsingPUT (string userId, int? id, SavedAddressResource savedAddressResource = null)

Update an address

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateAddressUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersAddressesApi();
            var userId = userId_example;  // string | The id of the user
            var id = 56;  // int? | The id of the address
            var savedAddressResource = new SavedAddressResource(); // SavedAddressResource | The saved address resource object (optional) 

            try
            {
                // Update an address
                apiInstance.UpdateAddressUsingPUT(userId, id, savedAddressResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersAddressesApi.UpdateAddressUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the user | 
 **id** | **int?**| The id of the address | 
 **savedAddressResource** | [**SavedAddressResource**](SavedAddressResource.md)| The saved address resource object | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

