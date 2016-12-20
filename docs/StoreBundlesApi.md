# IO.Swagger.Api.StoreBundlesApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBundleItemUsingPOST**](StoreBundlesApi.md#createbundleitemusingpost) | **POST** /store/bundles | Create a bundle item
[**CreateBundleTemplateUsingPOST**](StoreBundlesApi.md#createbundletemplateusingpost) | **POST** /store/bundles/templates | Create a bundle template
[**DeleteBundleTemplateUsingDELETE**](StoreBundlesApi.md#deletebundletemplateusingdelete) | **DELETE** /store/bundles/templates/{id} | Delete a bundle template
[**DeleteStoreItemUsingDELETE**](StoreBundlesApi.md#deletestoreitemusingdelete) | **DELETE** /store/bundles/{id} | Delete a bundle item
[**GetBundleTemplateUsingGET**](StoreBundlesApi.md#getbundletemplateusingget) | **GET** /store/bundles/templates/{id} | Get a single bundle template
[**GetBundleTemplatesUsingGET**](StoreBundlesApi.md#getbundletemplatesusingget) | **GET** /store/bundles/templates | List and search bundle templates
[**GetStoreItemUsingGET**](StoreBundlesApi.md#getstoreitemusingget) | **GET** /store/bundles/{id} | Get a single bundle item
[**UpdateBundleItemUsingPUT**](StoreBundlesApi.md#updatebundleitemusingput) | **PUT** /store/bundles/{id} | Update a bundle item
[**UpdateBundleTemplateUsingPUT**](StoreBundlesApi.md#updatebundletemplateusingput) | **PUT** /store/bundles/templates/{id} | Update a bundle template


<a name="createbundleitemusingpost"></a>
# **CreateBundleItemUsingPOST**
> BundleItem CreateBundleItemUsingPOST (BundleItem bundleItem = null)

Create a bundle item

The SKU for the bundle itself must be unique and there can only be one SKU.  Extra notes for price_override:  The price of all the items (multiplied by the quantity) must equal the price of the bundle.  With individual prices set, items will be processed individually and can be refunded as such.  However, if all prices are set to null, the price of the bundle will be used and will be treated as one item.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateBundleItemUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreBundlesApi();
            var bundleItem = new BundleItem(); // BundleItem | The bundle item object (optional) 

            try
            {
                // Create a bundle item
                BundleItem result = apiInstance.CreateBundleItemUsingPOST(bundleItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreBundlesApi.CreateBundleItemUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bundleItem** | [**BundleItem**](BundleItem.md)| The bundle item object | [optional] 

### Return type

[**BundleItem**](BundleItem.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createbundletemplateusingpost"></a>
# **CreateBundleTemplateUsingPOST**
> ItemTemplateResource CreateBundleTemplateUsingPOST (ItemTemplateResource bundleTemplateResource = null)

Create a bundle template

Bundle Templates define a type of bundle and the properties they have.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateBundleTemplateUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreBundlesApi();
            var bundleTemplateResource = new ItemTemplateResource(); // ItemTemplateResource | The new bundle template (optional) 

            try
            {
                // Create a bundle template
                ItemTemplateResource result = apiInstance.CreateBundleTemplateUsingPOST(bundleTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreBundlesApi.CreateBundleTemplateUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bundleTemplateResource** | [**ItemTemplateResource**](ItemTemplateResource.md)| The new bundle template | [optional] 

### Return type

[**ItemTemplateResource**](ItemTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebundletemplateusingdelete"></a>
# **DeleteBundleTemplateUsingDELETE**
> void DeleteBundleTemplateUsingDELETE (string id, string cascade = null)

Delete a bundle template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteBundleTemplateUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreBundlesApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | force deleting the template if it's attached to other objects, cascade = detach (optional) 

            try
            {
                // Delete a bundle template
                apiInstance.DeleteBundleTemplateUsingDELETE(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreBundlesApi.DeleteBundleTemplateUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **cascade** | **string**| force deleting the template if it&#39;s attached to other objects, cascade &#x3D; detach | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletestoreitemusingdelete"></a>
# **DeleteStoreItemUsingDELETE**
> void DeleteStoreItemUsingDELETE (int? id)

Delete a bundle item

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteStoreItemUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreBundlesApi();
            var id = 56;  // int? | The id of the bundle

            try
            {
                // Delete a bundle item
                apiInstance.DeleteStoreItemUsingDELETE(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreBundlesApi.DeleteStoreItemUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the bundle | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbundletemplateusingget"></a>
# **GetBundleTemplateUsingGET**
> ItemTemplateResource GetBundleTemplateUsingGET (string id)

Get a single bundle template

Bundle Templates define a type of bundle and the properties they have.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBundleTemplateUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new StoreBundlesApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single bundle template
                ItemTemplateResource result = apiInstance.GetBundleTemplateUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreBundlesApi.GetBundleTemplateUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 

### Return type

[**ItemTemplateResource**](ItemTemplateResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbundletemplatesusingget"></a>
# **GetBundleTemplatesUsingGET**
> PageResourceItemTemplateResource GetBundleTemplatesUsingGET (int? size = null, int? page = null, string order = null)

List and search bundle templates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBundleTemplatesUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new StoreBundlesApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search bundle templates
                PageResourceItemTemplateResource result = apiInstance.GetBundleTemplatesUsingGET(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreBundlesApi.GetBundleTemplatesUsingGET: " + e.Message );
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

[**PageResourceItemTemplateResource**](PageResourceItemTemplateResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstoreitemusingget"></a>
# **GetStoreItemUsingGET**
> BundleItem GetStoreItemUsingGET (int? id)

Get a single bundle item

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStoreItemUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new StoreBundlesApi();
            var id = 56;  // int? | The id of the bundle

            try
            {
                // Get a single bundle item
                BundleItem result = apiInstance.GetStoreItemUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreBundlesApi.GetStoreItemUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the bundle | 

### Return type

[**BundleItem**](BundleItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebundleitemusingput"></a>
# **UpdateBundleItemUsingPUT**
> void UpdateBundleItemUsingPUT (int? id, BundleItem bundleItem = null)

Update a bundle item

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateBundleItemUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreBundlesApi();
            var id = 56;  // int? | The id of the bundle
            var bundleItem = new BundleItem(); // BundleItem | The bundle item object (optional) 

            try
            {
                // Update a bundle item
                apiInstance.UpdateBundleItemUsingPUT(id, bundleItem);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreBundlesApi.UpdateBundleItemUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the bundle | 
 **bundleItem** | [**BundleItem**](BundleItem.md)| The bundle item object | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebundletemplateusingput"></a>
# **UpdateBundleTemplateUsingPUT**
> void UpdateBundleTemplateUsingPUT (string id, ItemTemplateResource bundleTemplateResource = null)

Update a bundle template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateBundleTemplateUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreBundlesApi();
            var id = id_example;  // string | The id of the template
            var bundleTemplateResource = new ItemTemplateResource(); // ItemTemplateResource | The bundle template resource object (optional) 

            try
            {
                // Update a bundle template
                apiInstance.UpdateBundleTemplateUsingPUT(id, bundleTemplateResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreBundlesApi.UpdateBundleTemplateUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **bundleTemplateResource** | [**ItemTemplateResource**](ItemTemplateResource.md)| The bundle template resource object | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

