# IO.Swagger.Api.BRERuleEngineGlobalsApi

All URIs are relative to *https://devsandbox.knetikcloud.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateGlobalUsingPOST**](BRERuleEngineGlobalsApi.md#createglobalusingpost) | **POST** /bre/globals/definitions | Create a global definition
[**DeleteGlobalUsingDELETE**](BRERuleEngineGlobalsApi.md#deleteglobalusingdelete) | **DELETE** /bre/globals/definitions/{id} | Delete a global
[**GetGlobalUsingGET**](BRERuleEngineGlobalsApi.md#getglobalusingget) | **GET** /bre/globals/definitions/{id} | Get a single global definition
[**GetGlobalsUsingGET**](BRERuleEngineGlobalsApi.md#getglobalsusingget) | **GET** /bre/globals/definitions | List global definitions
[**UpdateGlobalUsingPUT**](BRERuleEngineGlobalsApi.md#updateglobalusingput) | **PUT** /bre/globals/definitions/{id} | Update a global definition


<a name="createglobalusingpost"></a>
# **CreateGlobalUsingPOST**
> BreGlobalResource CreateGlobalUsingPOST (BreGlobalResource breGlobalResource = null)

Create a global definition

Once created you can then use in a custom rule. Note that global definitions cannot be modified or deleted if in use.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateGlobalUsingPOSTExample
    {
        public void main()
        {
            
            var apiInstance = new BRERuleEngineGlobalsApi();
            var breGlobalResource = new BreGlobalResource(); // BreGlobalResource | The BRE global resource object (optional) 

            try
            {
                // Create a global definition
                BreGlobalResource result = apiInstance.CreateGlobalUsingPOST(breGlobalResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineGlobalsApi.CreateGlobalUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **breGlobalResource** | [**BreGlobalResource**](BreGlobalResource.md)| The BRE global resource object | [optional] 

### Return type

[**BreGlobalResource**](BreGlobalResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteglobalusingdelete"></a>
# **DeleteGlobalUsingDELETE**
> void DeleteGlobalUsingDELETE (string id)

Delete a global

May fail if there are existing rules against it. Cannot delete core globals

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteGlobalUsingDELETEExample
    {
        public void main()
        {
            
            var apiInstance = new BRERuleEngineGlobalsApi();
            var id = id_example;  // string | The id of the global definition

            try
            {
                // Delete a global
                apiInstance.DeleteGlobalUsingDELETE(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineGlobalsApi.DeleteGlobalUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the global definition | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getglobalusingget"></a>
# **GetGlobalUsingGET**
> BreGlobalResource GetGlobalUsingGET (string id)

Get a single global definition

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetGlobalUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new BRERuleEngineGlobalsApi();
            var id = id_example;  // string | The id of the global definition

            try
            {
                // Get a single global definition
                BreGlobalResource result = apiInstance.GetGlobalUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineGlobalsApi.GetGlobalUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the global definition | 

### Return type

[**BreGlobalResource**](BreGlobalResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getglobalsusingget"></a>
# **GetGlobalsUsingGET**
> PageBreGlobalResource GetGlobalsUsingGET (bool? filterSystem = null, int? size = null, int? page = null)

List global definitions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetGlobalsUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new BRERuleEngineGlobalsApi();
            var filterSystem = true;  // bool? | Filter for globals that are system globals when true, or not when false. Leave off for both mixed (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // List global definitions
                PageBreGlobalResource result = apiInstance.GetGlobalsUsingGET(filterSystem, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineGlobalsApi.GetGlobalsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterSystem** | **bool?**| Filter for globals that are system globals when true, or not when false. Leave off for both mixed | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageBreGlobalResource**](PageBreGlobalResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateglobalusingput"></a>
# **UpdateGlobalUsingPUT**
> void UpdateGlobalUsingPUT (string id, BreGlobalResource breGlobalResource = null)

Update a global definition

May fail if new parameters mismatch requirements of existing rules. Cannot update core globals

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateGlobalUsingPUTExample
    {
        public void main()
        {
            
            var apiInstance = new BRERuleEngineGlobalsApi();
            var id = id_example;  // string | The id of the global definition
            var breGlobalResource = new BreGlobalResource(); // BreGlobalResource | The BRE global resource object (optional) 

            try
            {
                // Update a global definition
                apiInstance.UpdateGlobalUsingPUT(id, breGlobalResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineGlobalsApi.UpdateGlobalUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the global definition | 
 **breGlobalResource** | [**BreGlobalResource**](BreGlobalResource.md)| The BRE global resource object | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

