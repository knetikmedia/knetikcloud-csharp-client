# IO.Swagger.Api.StoreApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateItemTemplateUsingPOST**](StoreApi.md#createitemtemplateusingpost) | **POST** /store/items/templates | Create an item template
[**CreateStoreItemExternalUsingPOST**](StoreApi.md#createstoreitemexternalusingpost) | **POST** /store/items | Create a store item
[**DeleteItemTemplateUsingDELETE**](StoreApi.md#deleteitemtemplateusingdelete) | **DELETE** /store/items/templates/{id} | Delete an item template
[**DeleteStoreItemUsingDELETE1**](StoreApi.md#deletestoreitemusingdelete1) | **DELETE** /store/items/{id} | Delete a store item
[**GetItemTemplateUsingGET**](StoreApi.md#getitemtemplateusingget) | **GET** /store/items/templates/{id} | Get a single item template
[**GetItemTemplatesUsingGET**](StoreApi.md#getitemtemplatesusingget) | **GET** /store/items/templates | List and search item templates
[**GetStoreItemUsingGET1**](StoreApi.md#getstoreitemusingget1) | **GET** /store/items/{id} | Get a single store item
[**GetStoreItemsUsingGET**](StoreApi.md#getstoreitemsusingget) | **GET** /store/items | List and search store items
[**GetUsingGET2**](StoreApi.md#getusingget2) | **GET** /store | Get a listing of store items
[**UpdateItemTemplateUsingPUT**](StoreApi.md#updateitemtemplateusingput) | **PUT** /store/items/templates/{id} | Update an item template
[**UpdateStoreItemExternalUsingPUT**](StoreApi.md#updatestoreitemexternalusingput) | **PUT** /store/items/{id} | Update a store item


<a name="createitemtemplateusingpost"></a>
# **CreateItemTemplateUsingPOST**
> StoreItemTemplateResource CreateItemTemplateUsingPOST (StoreItemTemplateResource itemTemplateResource = null)

Create an item template

Item Templates define a type of item and the properties they have.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateItemTemplateUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreApi();
            var itemTemplateResource = new StoreItemTemplateResource(); // StoreItemTemplateResource | The new item template (optional) 

            try
            {
                // Create an item template
                StoreItemTemplateResource result = apiInstance.CreateItemTemplateUsingPOST(itemTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreApi.CreateItemTemplateUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemTemplateResource** | [**StoreItemTemplateResource**](StoreItemTemplateResource.md)| The new item template | [optional] 

### Return type

[**StoreItemTemplateResource**](StoreItemTemplateResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createstoreitemexternalusingpost"></a>
# **CreateStoreItemExternalUsingPOST**
> StoreItem CreateStoreItemExternalUsingPOST (StoreItem storeItem = null)

Create a store item

SKUs have to be unique in the entire store. If a duplicate SKU is found, a 400 error is generated and the response will have a \"parameters\" field that is a list of duplicates. A duplicate is an object like {item_id, offending_sku_list}. Ex:<br /> {..., parameters: [[{item: 1, skus: [\"SKU-1\"]}]]}<br /> If an item is brand new and has duplicate SKUs within itself, the item ID will be 0.  Item subclasses are not allowed here, you will have to use their respective endpoints.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateStoreItemExternalUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreApi();
            var storeItem = new StoreItem(); // StoreItem | The store item object (optional) 

            try
            {
                // Create a store item
                StoreItem result = apiInstance.CreateStoreItemExternalUsingPOST(storeItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreApi.CreateStoreItemExternalUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeItem** | [**StoreItem**](StoreItem.md)| The store item object | [optional] 

### Return type

[**StoreItem**](StoreItem.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitemtemplateusingdelete"></a>
# **DeleteItemTemplateUsingDELETE**
> void DeleteItemTemplateUsingDELETE (string id, string cascade = null)

Delete an item template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteItemTemplateUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | force deleting the template if it's attached to other objects, cascade = detach (optional) 

            try
            {
                // Delete an item template
                apiInstance.DeleteItemTemplateUsingDELETE(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreApi.DeleteItemTemplateUsingDELETE: " + e.Message );
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

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletestoreitemusingdelete1"></a>
# **DeleteStoreItemUsingDELETE1**
> void DeleteStoreItemUsingDELETE1 (int? id)

Delete a store item

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteStoreItemUsingDELETE1Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreApi();
            var id = 56;  // int? | The id of the item

            try
            {
                // Delete a store item
                apiInstance.DeleteStoreItemUsingDELETE1(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreApi.DeleteStoreItemUsingDELETE1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the item | 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemtemplateusingget"></a>
# **GetItemTemplateUsingGET**
> StoreItemTemplateResource GetItemTemplateUsingGET (string id)

Get a single item template

Item Templates define a type of item and the properties they have.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetItemTemplateUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single item template
                StoreItemTemplateResource result = apiInstance.GetItemTemplateUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreApi.GetItemTemplateUsingGET: " + e.Message );
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

[**StoreItemTemplateResource**](StoreItemTemplateResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemtemplatesusingget"></a>
# **GetItemTemplatesUsingGET**
> PageResourceStoreItemTemplateResource GetItemTemplatesUsingGET (int? size = null, int? page = null, string order = null)

List and search item templates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetItemTemplatesUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search item templates
                PageResourceStoreItemTemplateResource result = apiInstance.GetItemTemplatesUsingGET(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreApi.GetItemTemplatesUsingGET: " + e.Message );
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

[**PageResourceStoreItemTemplateResource**](PageResourceStoreItemTemplateResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstoreitemusingget1"></a>
# **GetStoreItemUsingGET1**
> StoreItem GetStoreItemUsingGET1 (int? id)

Get a single store item

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStoreItemUsingGET1Example
    {
        public void main()
        {
            
            var apiInstance = new StoreApi();
            var id = 56;  // int? | The id of the item

            try
            {
                // Get a single store item
                StoreItem result = apiInstance.GetStoreItemUsingGET1(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreApi.GetStoreItemUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the item | 

### Return type

[**StoreItem**](StoreItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstoreitemsusingget"></a>
# **GetStoreItemsUsingGET**
> PageResourceStoreItem GetStoreItemsUsingGET (string filterNameSearch = null, string filterUniqueKey = null, bool? filterPublished = null, bool? filterDisplayable = null, string filterStart = null, string filterEnd = null, string filterStartDate = null, string filterStopDate = null, string filterSku = null, string filterPrice = null, string filterTag = null, string filterItemsByType = null, string filterBundledSkus = null, int? size = null, int? page = null, string order = null)

List and search store items

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStoreItemsUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new StoreApi();
            var filterNameSearch = filterNameSearch_example;  // string | Filter for items whose name starts with a given string. (optional) 
            var filterUniqueKey = filterUniqueKey_example;  // string | Filter for items whose unique_key is a given string. (optional) 
            var filterPublished = true;  // bool? | Filter for skus that have been published. (optional) 
            var filterDisplayable = true;  // bool? | Filter for items that are displayable. (optional) 
            var filterStart = filterStart_example;  // string | A comma separated string without spaces.  First value is the operator to search on, second value is the store start date, a unix timestamp in seconds.  Allowed operators: (LT, GT, LTE, GTE, EQ). (optional) 
            var filterEnd = filterEnd_example;  // string | A comma separated string without spaces.  First value is the operator to search on, second value is the store end date, a unix timestamp in seconds.  Allowed operators: (LT, GT, LTE, GTE, EQ). (optional) 
            var filterStartDate = filterStartDate_example;  // string | A comma separated string without spaces.  First value is the operator to search on, second value is the sku start date, a unix timestamp in seconds.  Allowed operators: (LT, GT, LTE, GTE, EQ). (optional) 
            var filterStopDate = filterStopDate_example;  // string | A comma separated string without spaces.  First value is the operator to search on, second value is the sku end date, a unix timestamp in seconds.  Allowed operators: (LT, GT, LTE, GTE, EQ). (optional) 
            var filterSku = filterSku_example;  // string | Filter for skus whose name starts with a given string. (optional) 
            var filterPrice = filterPrice_example;  // string | A colon separated string without spaces.  First value is the operator to search on, second value is the price of a sku.  Allowed operators: (LT, GT, LTE, GTE, EQ). (optional) 
            var filterTag = filterTag_example;  // string | A comma separated list without spaces of the names of tags. Will only return items with at least one of the tags. (optional) 
            var filterItemsByType = filterItemsByType_example;  // string | Filter for item type based on its type hint. (optional) 
            var filterBundledSkus = filterBundledSkus_example;  // string | Filter for skus inside bundles whose name starts with a given string.  Used only when type hint is 'bundle_item' (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search store items
                PageResourceStoreItem result = apiInstance.GetStoreItemsUsingGET(filterNameSearch, filterUniqueKey, filterPublished, filterDisplayable, filterStart, filterEnd, filterStartDate, filterStopDate, filterSku, filterPrice, filterTag, filterItemsByType, filterBundledSkus, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreApi.GetStoreItemsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterNameSearch** | **string**| Filter for items whose name starts with a given string. | [optional] 
 **filterUniqueKey** | **string**| Filter for items whose unique_key is a given string. | [optional] 
 **filterPublished** | **bool?**| Filter for skus that have been published. | [optional] 
 **filterDisplayable** | **bool?**| Filter for items that are displayable. | [optional] 
 **filterStart** | **string**| A comma separated string without spaces.  First value is the operator to search on, second value is the store start date, a unix timestamp in seconds.  Allowed operators: (LT, GT, LTE, GTE, EQ). | [optional] 
 **filterEnd** | **string**| A comma separated string without spaces.  First value is the operator to search on, second value is the store end date, a unix timestamp in seconds.  Allowed operators: (LT, GT, LTE, GTE, EQ). | [optional] 
 **filterStartDate** | **string**| A comma separated string without spaces.  First value is the operator to search on, second value is the sku start date, a unix timestamp in seconds.  Allowed operators: (LT, GT, LTE, GTE, EQ). | [optional] 
 **filterStopDate** | **string**| A comma separated string without spaces.  First value is the operator to search on, second value is the sku end date, a unix timestamp in seconds.  Allowed operators: (LT, GT, LTE, GTE, EQ). | [optional] 
 **filterSku** | **string**| Filter for skus whose name starts with a given string. | [optional] 
 **filterPrice** | **string**| A colon separated string without spaces.  First value is the operator to search on, second value is the price of a sku.  Allowed operators: (LT, GT, LTE, GTE, EQ). | [optional] 
 **filterTag** | **string**| A comma separated list without spaces of the names of tags. Will only return items with at least one of the tags. | [optional] 
 **filterItemsByType** | **string**| Filter for item type based on its type hint. | [optional] 
 **filterBundledSkus** | **string**| Filter for skus inside bundles whose name starts with a given string.  Used only when type hint is &#39;bundle_item&#39; | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourceStoreItem**](PageResourceStoreItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusingget2"></a>
# **GetUsingGET2**
> PageResourceStoreItem GetUsingGET2 (StoreListRequest storeListRequest = null)

Get a listing of store items

The exact structure of each items may differ to include fields specific to the type. The same is true for behaviors.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUsingGET2Example
    {
        public void main()
        {
            
            var apiInstance = new StoreApi();
            var storeListRequest = new StoreListRequest(); // StoreListRequest | The store list request object (optional) 

            try
            {
                // Get a listing of store items
                PageResourceStoreItem result = apiInstance.GetUsingGET2(storeListRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreApi.GetUsingGET2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeListRequest** | [**StoreListRequest**](StoreListRequest.md)| The store list request object | [optional] 

### Return type

[**PageResourceStoreItem**](PageResourceStoreItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateitemtemplateusingput"></a>
# **UpdateItemTemplateUsingPUT**
> void UpdateItemTemplateUsingPUT (string id, StoreItemTemplateResource itemTemplateResource = null)

Update an item template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateItemTemplateUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreApi();
            var id = id_example;  // string | The id of the template
            var itemTemplateResource = new StoreItemTemplateResource(); // StoreItemTemplateResource | The item template resource object (optional) 

            try
            {
                // Update an item template
                apiInstance.UpdateItemTemplateUsingPUT(id, itemTemplateResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreApi.UpdateItemTemplateUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **itemTemplateResource** | [**StoreItemTemplateResource**](StoreItemTemplateResource.md)| The item template resource object | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatestoreitemexternalusingput"></a>
# **UpdateStoreItemExternalUsingPUT**
> void UpdateStoreItemExternalUsingPUT (int? id, StoreItem storeItem = null)

Update a store item

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateStoreItemExternalUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreApi();
            var id = 56;  // int? | The id of the item
            var storeItem = new StoreItem(); // StoreItem | The store item object (optional) 

            try
            {
                // Update a store item
                apiInstance.UpdateStoreItemExternalUsingPUT(id, storeItem);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreApi.UpdateStoreItemExternalUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the item | 
 **storeItem** | [**StoreItem**](StoreItem.md)| The store item object | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

