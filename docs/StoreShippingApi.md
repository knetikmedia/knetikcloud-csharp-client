# IO.Swagger.Api.StoreShippingApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateShippingItemUsingPOST**](StoreShippingApi.md#createshippingitemusingpost) | **POST** /store/shipping | Create a shipping item
[**CreateShippingTemplateUsingPOST**](StoreShippingApi.md#createshippingtemplateusingpost) | **POST** /store/shipping/templates | Create a shipping template
[**DeleteShippingItemUsingDELETE**](StoreShippingApi.md#deleteshippingitemusingdelete) | **DELETE** /store/shipping/{id} | Delete a shipping item
[**DeleteShippingTemplateUsingDELETE**](StoreShippingApi.md#deleteshippingtemplateusingdelete) | **DELETE** /store/shipping/templates/{id} | Delete a shipping template
[**GetShippingItemUsingGET**](StoreShippingApi.md#getshippingitemusingget) | **GET** /store/shipping/{id} | Get a single shipping item
[**GetShippingTemplateUsingGET**](StoreShippingApi.md#getshippingtemplateusingget) | **GET** /store/shipping/templates/{id} | Get a single shipping template
[**GetShippingTemplatesUsingGET**](StoreShippingApi.md#getshippingtemplatesusingget) | **GET** /store/shipping/templates | List and search shipping templates
[**UpdateShippingItemUsingPUT**](StoreShippingApi.md#updateshippingitemusingput) | **PUT** /store/shipping/{id} | Update a shipping item
[**UpdateShippingTemplateUsingPUT**](StoreShippingApi.md#updateshippingtemplateusingput) | **PUT** /store/shipping/templates/{id} | Update a shipping template


<a name="createshippingitemusingpost"></a>
# **CreateShippingItemUsingPOST**
> ShippingItem CreateShippingItemUsingPOST (ShippingItem shippingItem = null)

Create a shipping item

A shipping item represents a shipping option and cost. SKUs have to be unique in the entire store.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateShippingItemUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreShippingApi();
            var shippingItem = new ShippingItem(); // ShippingItem | The shipping item object (optional) 

            try
            {
                // Create a shipping item
                ShippingItem result = apiInstance.CreateShippingItemUsingPOST(shippingItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreShippingApi.CreateShippingItemUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shippingItem** | [**ShippingItem**](ShippingItem.md)| The shipping item object | [optional] 

### Return type

[**ShippingItem**](ShippingItem.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createshippingtemplateusingpost"></a>
# **CreateShippingTemplateUsingPOST**
> ItemTemplateResource CreateShippingTemplateUsingPOST (ItemTemplateResource shippingTemplateResource = null)

Create a shipping template

Shipping Templates define a type of shipping and the properties they have.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateShippingTemplateUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreShippingApi();
            var shippingTemplateResource = new ItemTemplateResource(); // ItemTemplateResource | The new shipping template (optional) 

            try
            {
                // Create a shipping template
                ItemTemplateResource result = apiInstance.CreateShippingTemplateUsingPOST(shippingTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreShippingApi.CreateShippingTemplateUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shippingTemplateResource** | [**ItemTemplateResource**](ItemTemplateResource.md)| The new shipping template | [optional] 

### Return type

[**ItemTemplateResource**](ItemTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteshippingitemusingdelete"></a>
# **DeleteShippingItemUsingDELETE**
> void DeleteShippingItemUsingDELETE (int? id)

Delete a shipping item

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteShippingItemUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreShippingApi();
            var id = 56;  // int? | The id of the shipping item

            try
            {
                // Delete a shipping item
                apiInstance.DeleteShippingItemUsingDELETE(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreShippingApi.DeleteShippingItemUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the shipping item | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteshippingtemplateusingdelete"></a>
# **DeleteShippingTemplateUsingDELETE**
> void DeleteShippingTemplateUsingDELETE (string id, string cascade = null)

Delete a shipping template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteShippingTemplateUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreShippingApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | force deleting the template if it's attached to other objects, cascade = detach (optional) 

            try
            {
                // Delete a shipping template
                apiInstance.DeleteShippingTemplateUsingDELETE(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreShippingApi.DeleteShippingTemplateUsingDELETE: " + e.Message );
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
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshippingitemusingget"></a>
# **GetShippingItemUsingGET**
> ShippingItem GetShippingItemUsingGET (int? id)

Get a single shipping item

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetShippingItemUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new StoreShippingApi();
            var id = 56;  // int? | The id of the shipping item

            try
            {
                // Get a single shipping item
                ShippingItem result = apiInstance.GetShippingItemUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreShippingApi.GetShippingItemUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the shipping item | 

### Return type

[**ShippingItem**](ShippingItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshippingtemplateusingget"></a>
# **GetShippingTemplateUsingGET**
> ItemTemplateResource GetShippingTemplateUsingGET (string id)

Get a single shipping template

Shipping Templates define a type of shipping and the properties they have.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetShippingTemplateUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreShippingApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single shipping template
                ItemTemplateResource result = apiInstance.GetShippingTemplateUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreShippingApi.GetShippingTemplateUsingGET: " + e.Message );
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

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshippingtemplatesusingget"></a>
# **GetShippingTemplatesUsingGET**
> PageItemTemplateResource GetShippingTemplatesUsingGET (int? size = null, int? page = null, string order = null)

List and search shipping templates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetShippingTemplatesUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreShippingApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search shipping templates
                PageItemTemplateResource result = apiInstance.GetShippingTemplatesUsingGET(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreShippingApi.GetShippingTemplatesUsingGET: " + e.Message );
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

[**PageItemTemplateResource**](PageItemTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateshippingitemusingput"></a>
# **UpdateShippingItemUsingPUT**
> void UpdateShippingItemUsingPUT (int? id, ShippingItem shippingItem = null)

Update a shipping item

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateShippingItemUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreShippingApi();
            var id = 56;  // int? | The id of the shipping item
            var shippingItem = new ShippingItem(); // ShippingItem | The shipping item object (optional) 

            try
            {
                // Update a shipping item
                apiInstance.UpdateShippingItemUsingPUT(id, shippingItem);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreShippingApi.UpdateShippingItemUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the shipping item | 
 **shippingItem** | [**ShippingItem**](ShippingItem.md)| The shipping item object | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateshippingtemplateusingput"></a>
# **UpdateShippingTemplateUsingPUT**
> void UpdateShippingTemplateUsingPUT (string id, ItemTemplateResource shippingTemplateResource = null)

Update a shipping template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateShippingTemplateUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreShippingApi();
            var id = id_example;  // string | The id of the template
            var shippingTemplateResource = new ItemTemplateResource(); // ItemTemplateResource | The shipping template resource object (optional) 

            try
            {
                // Update a shipping template
                apiInstance.UpdateShippingTemplateUsingPUT(id, shippingTemplateResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreShippingApi.UpdateShippingTemplateUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **shippingTemplateResource** | [**ItemTemplateResource**](ItemTemplateResource.md)| The shipping template resource object | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

