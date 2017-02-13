# IO.Swagger.Api.StoreVendorsApi

All URIs are relative to *https://integration.knetikcloud.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateVendor**](StoreVendorsApi.md#createvendor) | **POST** /vendors | Create a vendor
[**DeleteVendor**](StoreVendorsApi.md#deletevendor) | **DELETE** /vendors/{id} | Delete a vendor
[**GetVendor**](StoreVendorsApi.md#getvendor) | **GET** /vendors/{id} | Get a single vendor
[**GetVendors**](StoreVendorsApi.md#getvendors) | **GET** /vendors | List and search vendors
[**UpdateVendor**](StoreVendorsApi.md#updatevendor) | **PUT** /vendors/{id} | Update a vendor


<a name="createvendor"></a>
# **CreateVendor**
> VendorResource CreateVendor (VendorResource vendor = null)

Create a vendor

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateVendorExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreVendorsApi();
            var vendor = new VendorResource(); // VendorResource | The vendor (optional) 

            try
            {
                // Create a vendor
                VendorResource result = apiInstance.CreateVendor(vendor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreVendorsApi.CreateVendor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vendor** | [**VendorResource**](VendorResource.md)| The vendor | [optional] 

### Return type

[**VendorResource**](VendorResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevendor"></a>
# **DeleteVendor**
> void DeleteVendor (int? id)

Delete a vendor

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteVendorExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreVendorsApi();
            var id = 56;  // int? | The id of the vendor

            try
            {
                // Delete a vendor
                apiInstance.DeleteVendor(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreVendorsApi.DeleteVendor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the vendor | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvendor"></a>
# **GetVendor**
> VendorResource GetVendor (int? id)

Get a single vendor

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetVendorExample
    {
        public void main()
        {
            
            var apiInstance = new StoreVendorsApi();
            var id = 56;  // int? | The id of the vendor

            try
            {
                // Get a single vendor
                VendorResource result = apiInstance.GetVendor(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreVendorsApi.GetVendor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the vendor | 

### Return type

[**VendorResource**](VendorResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvendors"></a>
# **GetVendors**
> PageResourceVendorResource GetVendors (string filterName = null, int? size = null, int? page = null, string order = null)

List and search vendors

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetVendorsExample
    {
        public void main()
        {
            
            var apiInstance = new StoreVendorsApi();
            var filterName = filterName_example;  // string | Filters vendors by name starting with the text provided in the filter (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search vendors
                PageResourceVendorResource result = apiInstance.GetVendors(filterName, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreVendorsApi.GetVendors: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterName** | **string**| Filters vendors by name starting with the text provided in the filter | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourceVendorResource**](PageResourceVendorResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatevendor"></a>
# **UpdateVendor**
> void UpdateVendor (int? id, VendorResource vendor = null)

Update a vendor

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateVendorExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreVendorsApi();
            var id = 56;  // int? | The id of the vendor
            var vendor = new VendorResource(); // VendorResource | The vendor (optional) 

            try
            {
                // Update a vendor
                apiInstance.UpdateVendor(id, vendor);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreVendorsApi.UpdateVendor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the vendor | 
 **vendor** | [**VendorResource**](VendorResource.md)| The vendor | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

