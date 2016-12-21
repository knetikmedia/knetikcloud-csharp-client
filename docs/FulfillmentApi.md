# IO.Swagger.Api.FulfillmentApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateFulfillmentTypeUsingPOST**](FulfillmentApi.md#createfulfillmenttypeusingpost) | **POST** /store/fulfillment/types | Create a fulfillment type
[**DeleteFulfillmentTypeUsingDELETE**](FulfillmentApi.md#deletefulfillmenttypeusingdelete) | **DELETE** /store/fulfillment/types/{id} | Delete a fulfillment type
[**GetFulfillmentTypeUsingGET**](FulfillmentApi.md#getfulfillmenttypeusingget) | **GET** /store/fulfillment/types/{id} | Get a single fulfillment type
[**GetFulfillmentsUsingGET**](FulfillmentApi.md#getfulfillmentsusingget) | **GET** /store/fulfillment/types | List and search fulfillment types
[**UpdateFulfillmentTypeUsingPUT**](FulfillmentApi.md#updatefulfillmenttypeusingput) | **PUT** /store/fulfillment/types/{id} | Update a fulfillment type


<a name="createfulfillmenttypeusingpost"></a>
# **CreateFulfillmentTypeUsingPOST**
> FulfillmentType CreateFulfillmentTypeUsingPOST (FulfillmentType type = null)

Create a fulfillment type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateFulfillmentTypeUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FulfillmentApi();
            var type = new FulfillmentType(); // FulfillmentType | The fulfillment type (optional) 

            try
            {
                // Create a fulfillment type
                FulfillmentType result = apiInstance.CreateFulfillmentTypeUsingPOST(type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentApi.CreateFulfillmentTypeUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | [**FulfillmentType**](FulfillmentType.md)| The fulfillment type | [optional] 

### Return type

[**FulfillmentType**](FulfillmentType.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefulfillmenttypeusingdelete"></a>
# **DeleteFulfillmentTypeUsingDELETE**
> void DeleteFulfillmentTypeUsingDELETE (int? id)

Delete a fulfillment type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteFulfillmentTypeUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FulfillmentApi();
            var id = 56;  // int? | The id

            try
            {
                // Delete a fulfillment type
                apiInstance.DeleteFulfillmentTypeUsingDELETE(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentApi.DeleteFulfillmentTypeUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id | 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmenttypeusingget"></a>
# **GetFulfillmentTypeUsingGET**
> FulfillmentType GetFulfillmentTypeUsingGET (int? id)

Get a single fulfillment type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFulfillmentTypeUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new FulfillmentApi();
            var id = 56;  // int? | The id

            try
            {
                // Get a single fulfillment type
                FulfillmentType result = apiInstance.GetFulfillmentTypeUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentApi.GetFulfillmentTypeUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id | 

### Return type

[**FulfillmentType**](FulfillmentType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentsusingget"></a>
# **GetFulfillmentsUsingGET**
> PageResourceFulfillmentType GetFulfillmentsUsingGET (int? size = null, int? page = null, string order = null)

List and search fulfillment types

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFulfillmentsUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new FulfillmentApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search fulfillment types
                PageResourceFulfillmentType result = apiInstance.GetFulfillmentsUsingGET(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentApi.GetFulfillmentsUsingGET: " + e.Message );
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

[**PageResourceFulfillmentType**](PageResourceFulfillmentType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatefulfillmenttypeusingput"></a>
# **UpdateFulfillmentTypeUsingPUT**
> void UpdateFulfillmentTypeUsingPUT (int? id, FulfillmentType fulfillmentType = null)

Update a fulfillment type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateFulfillmentTypeUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FulfillmentApi();
            var id = 56;  // int? | The id
            var fulfillmentType = new FulfillmentType(); // FulfillmentType | The fulfillment type (optional) 

            try
            {
                // Update a fulfillment type
                apiInstance.UpdateFulfillmentTypeUsingPUT(id, fulfillmentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentApi.UpdateFulfillmentTypeUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id | 
 **fulfillmentType** | [**FulfillmentType**](FulfillmentType.md)| The fulfillment type | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

