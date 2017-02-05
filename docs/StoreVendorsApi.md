# IO.Swagger.Api.StoreVendorsApi

All URIs are relative to *https://integration.knetikcloud.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateVendorUsingPOST**](StoreVendorsApi.md#createvendorusingpost) | **POST** /vendors | Create a vendor
[**DeleteVendorUsingDELETE**](StoreVendorsApi.md#deletevendorusingdelete) | **DELETE** /vendors/{id} | Delete a vendor
[**GetVendorUsingGET**](StoreVendorsApi.md#getvendorusingget) | **GET** /vendors/{id} | Get a single vendor
[**GetVendorsUsingGET**](StoreVendorsApi.md#getvendorsusingget) | **GET** /vendors | List and search vendors
[**UpdateVendorUsingPUT**](StoreVendorsApi.md#updatevendorusingput) | **PUT** /vendors/{id} | Update a vendor


<a name="createvendorusingpost"></a>
# **CreateVendorUsingPOST**
> VendorResource CreateVendorUsingPOST (VendorResource vendor = null)

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
    public class CreateVendorUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreVendorsApi();
            var vendor = new VendorResource(); // VendorResource | The vendor (optional) 

            try
            {
                // Create a vendor
                VendorResource result = apiInstance.CreateVendorUsingPOST(vendor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreVendorsApi.CreateVendorUsingPOST: " + e.Message );
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

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevendorusingdelete"></a>
# **DeleteVendorUsingDELETE**
> void DeleteVendorUsingDELETE (int? id)

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
    public class DeleteVendorUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreVendorsApi();
            var id = 56;  // int? | The id of the vendor

            try
            {
                // Delete a vendor
                apiInstance.DeleteVendorUsingDELETE(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreVendorsApi.DeleteVendorUsingDELETE: " + e.Message );
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

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvendorusingget"></a>
# **GetVendorUsingGET**
> VendorResource GetVendorUsingGET (int? id)

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
    public class GetVendorUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new StoreVendorsApi();
            var id = 56;  // int? | The id of the vendor

            try
            {
                // Get a single vendor
                VendorResource result = apiInstance.GetVendorUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreVendorsApi.GetVendorUsingGET: " + e.Message );
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

<a name="getvendorsusingget"></a>
# **GetVendorsUsingGET**
> PageResourceVendorResource GetVendorsUsingGET (string filterName = null, int? size = null, int? page = null, string order = null)

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
    public class GetVendorsUsingGETExample
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
                PageResourceVendorResource result = apiInstance.GetVendorsUsingGET(filterName, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreVendorsApi.GetVendorsUsingGET: " + e.Message );
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

<a name="updatevendorusingput"></a>
# **UpdateVendorUsingPUT**
> void UpdateVendorUsingPUT (int? id, VendorResource vendor = null)

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
    public class UpdateVendorUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreVendorsApi();
            var id = 56;  // int? | The id of the vendor
            var vendor = new VendorResource(); // VendorResource | The vendor (optional) 

            try
            {
                // Update a vendor
                apiInstance.UpdateVendorUsingPUT(id, vendor);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreVendorsApi.UpdateVendorUsingPUT: " + e.Message );
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

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

