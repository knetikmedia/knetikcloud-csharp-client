# IO.Swagger.Api.DevicesApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateDeviceUsingPOST**](DevicesApi.md#createdeviceusingpost) | **POST** /devices | Create a device
[**DeleteDeviceUsingDELETE**](DevicesApi.md#deletedeviceusingdelete) | **DELETE** /devices/{id} | Delete a device
[**GetDeviceUsingGET**](DevicesApi.md#getdeviceusingget) | **GET** /devices/{id} | Get a single device
[**GetDevicesUsingGET**](DevicesApi.md#getdevicesusingget) | **GET** /devices | List and search devices
[**UpdateDeviceUsingPUT**](DevicesApi.md#updatedeviceusingput) | **PUT** /devices/{id} | Update a device


<a name="createdeviceusingpost"></a>
# **CreateDeviceUsingPOST**
> DeviceResource CreateDeviceUsingPOST (DeviceResource device)

Create a device

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateDeviceUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesApi();
            var device = new DeviceResource(); // DeviceResource | device

            try
            {
                // Create a device
                DeviceResource result = apiInstance.CreateDeviceUsingPOST(device);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesApi.CreateDeviceUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **device** | [**DeviceResource**](DeviceResource.md)| device | 

### Return type

[**DeviceResource**](DeviceResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedeviceusingdelete"></a>
# **DeleteDeviceUsingDELETE**
> void DeleteDeviceUsingDELETE (int? id)

Delete a device

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteDeviceUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesApi();
            var id = 56;  // int? | id

            try
            {
                // Delete a device
                apiInstance.DeleteDeviceUsingDELETE(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesApi.DeleteDeviceUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id | 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdeviceusingget"></a>
# **GetDeviceUsingGET**
> DeviceResource GetDeviceUsingGET (int? id)

Get a single device

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDeviceUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesApi();
            var id = 56;  // int? | id

            try
            {
                // Get a single device
                DeviceResource result = apiInstance.GetDeviceUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesApi.GetDeviceUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id | 

### Return type

[**DeviceResource**](DeviceResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdevicesusingget"></a>
# **GetDevicesUsingGET**
> PageResourceDeviceResource GetDevicesUsingGET (string filterMake = null, string filterModel = null, int? size = null, int? page = null, string order = null)

List and search devices

Get a list of devices with optional filtering

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDevicesUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesApi();
            var filterMake = filterMake_example;  // string | Filter for devices with specified make (optional) 
            var filterModel = filterModel_example;  // string | Filter for devices with specified model (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search devices
                PageResourceDeviceResource result = apiInstance.GetDevicesUsingGET(filterMake, filterModel, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesApi.GetDevicesUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterMake** | **string**| Filter for devices with specified make | [optional] 
 **filterModel** | **string**| Filter for devices with specified model | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourceDeviceResource**](PageResourceDeviceResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedeviceusingput"></a>
# **UpdateDeviceUsingPUT**
> void UpdateDeviceUsingPUT (DeviceResource device, int? id)

Update a device

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateDeviceUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesApi();
            var device = new DeviceResource(); // DeviceResource | device
            var id = 56;  // int? | id

            try
            {
                // Update a device
                apiInstance.UpdateDeviceUsingPUT(device, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesApi.UpdateDeviceUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **device** | [**DeviceResource**](DeviceResource.md)| device | 
 **id** | **int?**| id | 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

