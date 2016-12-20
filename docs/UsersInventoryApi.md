# IO.Swagger.Api.UsersInventoryApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddItemUsingPOST1**](UsersInventoryApi.md#additemusingpost1) | **POST** /users/{id}/inventory | Adds an item to the user inventory
[**CreateItemUsingPOST**](UsersInventoryApi.md#createitemusingpost) | **POST** /entitlements | Create an entitlement item
[**CreateTemplateUsingPOST3**](UsersInventoryApi.md#createtemplateusingpost3) | **POST** /entitlements/templates | Create an entitlement template
[**DeleteEntitlementTemplateUsingDELETE**](UsersInventoryApi.md#deleteentitlementtemplateusingdelete) | **DELETE** /entitlements/templates/{id} | Delete an entitlement template
[**DeleteItemUsingDELETE**](UsersInventoryApi.md#deleteitemusingdelete) | **DELETE** /entitlements/{entitlement_id} | Delete an entitlement item
[**EntitlementCheckUsingGET**](UsersInventoryApi.md#entitlementcheckusingget) | **GET** /users/{user_id}/entitlements/{item_id}/check | Check for access to an item without consuming
[**EntitlementUseUsingPOST**](UsersInventoryApi.md#entitlementuseusingpost) | **POST** /users/{user_id}/entitlements/{item_id}/use | Use an item
[**GetCurrenciesUsingGET1**](UsersInventoryApi.md#getcurrenciesusingget1) | **GET** /entitlements | List and search entitlement items
[**GetEntitlementTemplateUsingGET**](UsersInventoryApi.md#getentitlementtemplateusingget) | **GET** /entitlements/templates/{id} | Get a single entitlement template
[**GetEntitlementTemplatesUsingGET**](UsersInventoryApi.md#getentitlementtemplatesusingget) | **GET** /entitlements/templates | List and search entitlement templates
[**GetInventoryListUsingGET**](UsersInventoryApi.md#getinventorylistusingget) | **GET** /inventories | List the user inventory entries for all users
[**GetInventoryUsingGET**](UsersInventoryApi.md#getinventoryusingget) | **GET** /users/{user_id}/inventory/{id} | Get an inventory entry
[**GetItemUsingGET**](UsersInventoryApi.md#getitemusingget) | **GET** /entitlements/{entitlement_id} | Get a single entitlement item
[**GetUserInventoryListUsingGET**](UsersInventoryApi.md#getuserinventorylistusingget) | **GET** /users/{id}/inventory | List the user inventory entries for a given user
[**GetUserInventoryLogUsingGET**](UsersInventoryApi.md#getuserinventorylogusingget) | **GET** /users/{user_id}/inventory/{id}/log | List the log entries for this inventory entry.
[**UpdateItemUsingPUT1**](UsersInventoryApi.md#updateitemusingput1) | **PUT** /entitlements/{entitlement_id} | Update an entitlement item
[**UpdateTemplateUsingPUT3**](UsersInventoryApi.md#updatetemplateusingput3) | **PUT** /entitlements/templates/{id} | Update an entitlement template
[**UpdateUserInventoryBehaviorDataUsingPUT**](UsersInventoryApi.md#updateuserinventorybehaviordatausingput) | **PUT** /users/{user_id}/inventory/{id}/behavior-data | Set the behavior data for an inventory entry
[**UpdateUserInventoryExpiresUsingPUT**](UsersInventoryApi.md#updateuserinventoryexpiresusingput) | **PUT** /users/{user_id}/inventory/{id}/expires | Set the expiration date
[**UpdateUserInventoryStatusUsingPUT**](UsersInventoryApi.md#updateuserinventorystatususingput) | **PUT** /users/{user_id}/inventory/{id}/status | Set the status for an inventory entry


<a name="additemusingpost1"></a>
# **AddItemUsingPOST1**
> InvoiceResource AddItemUsingPOST1 (int? id, UserInventoryAddRequest userInventoryAddRequest = null)

Adds an item to the user inventory

The inventory is fulfilled asynchronously UNLESS the invoice is explicitely skipped. Depending on the use case, it might require the client to verify that the entitlement was added after the fact or configure a BRE rule to get a notification in real time

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddItemUsingPOST1Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersInventoryApi();
            var id = 56;  // int? | The id of the user
            var userInventoryAddRequest = new UserInventoryAddRequest(); // UserInventoryAddRequest | The user inventory add request object (optional) 

            try
            {
                // Adds an item to the user inventory
                InvoiceResource result = apiInstance.AddItemUsingPOST1(id, userInventoryAddRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.AddItemUsingPOST1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the user | 
 **userInventoryAddRequest** | [**UserInventoryAddRequest**](UserInventoryAddRequest.md)| The user inventory add request object | [optional] 

### Return type

[**InvoiceResource**](InvoiceResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createitemusingpost"></a>
# **CreateItemUsingPOST**
> EntitlementItem CreateItemUsingPOST (EntitlementItem entitlementItem = null)

Create an entitlement item

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateItemUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersInventoryApi();
            var entitlementItem = new EntitlementItem(); // EntitlementItem | The entitlement item object (optional) 

            try
            {
                // Create an entitlement item
                EntitlementItem result = apiInstance.CreateItemUsingPOST(entitlementItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.CreateItemUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entitlementItem** | [**EntitlementItem**](EntitlementItem.md)| The entitlement item object | [optional] 

### Return type

[**EntitlementItem**](EntitlementItem.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtemplateusingpost3"></a>
# **CreateTemplateUsingPOST3**
> ItemTemplateResource CreateTemplateUsingPOST3 (ItemTemplateResource template = null)

Create an entitlement template

Entitlement templates define a type of entitlement and the properties they have

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateTemplateUsingPOST3Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersInventoryApi();
            var template = new ItemTemplateResource(); // ItemTemplateResource | The entitlement template to be created (optional) 

            try
            {
                // Create an entitlement template
                ItemTemplateResource result = apiInstance.CreateTemplateUsingPOST3(template);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.CreateTemplateUsingPOST3: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **template** | [**ItemTemplateResource**](ItemTemplateResource.md)| The entitlement template to be created | [optional] 

### Return type

[**ItemTemplateResource**](ItemTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteentitlementtemplateusingdelete"></a>
# **DeleteEntitlementTemplateUsingDELETE**
> void DeleteEntitlementTemplateUsingDELETE (string id, string cascade = null)

Delete an entitlement template

If cascade = 'detach', it will force delete the template even if it's attached to other objects

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteEntitlementTemplateUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersInventoryApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | The value needed to delete used templates (optional) 

            try
            {
                // Delete an entitlement template
                apiInstance.DeleteEntitlementTemplateUsingDELETE(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.DeleteEntitlementTemplateUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **cascade** | **string**| The value needed to delete used templates | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitemusingdelete"></a>
# **DeleteItemUsingDELETE**
> void DeleteItemUsingDELETE (int? entitlementId)

Delete an entitlement item

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteItemUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersInventoryApi();
            var entitlementId = 56;  // int? | The id of the entitlement

            try
            {
                // Delete an entitlement item
                apiInstance.DeleteItemUsingDELETE(entitlementId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.DeleteItemUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entitlementId** | **int?**| The id of the entitlement | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="entitlementcheckusingget"></a>
# **EntitlementCheckUsingGET**
> void EntitlementCheckUsingGET (string userId, int? itemId, string sku = null)

Check for access to an item without consuming

Useful for pre-check and accounts for all various buisness rules

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EntitlementCheckUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersInventoryApi();
            var userId = userId_example;  // string | The id of the user to check for or 'me' for logged in user
            var itemId = 56;  // int? | The id of the item
            var sku = sku_example;  // string | The specific sku of an entitlement list addition to check entitlement for. This is of very limited and specific use and should generally be left out (optional) 

            try
            {
                // Check for access to an item without consuming
                apiInstance.EntitlementCheckUsingGET(userId, itemId, sku);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.EntitlementCheckUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the user to check for or &#39;me&#39; for logged in user | 
 **itemId** | **int?**| The id of the item | 
 **sku** | **string**| The specific sku of an entitlement list addition to check entitlement for. This is of very limited and specific use and should generally be left out | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="entitlementuseusingpost"></a>
# **EntitlementUseUsingPOST**
> void EntitlementUseUsingPOST (string userId, int? itemId, string sku = null, string info = null)

Use an item

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EntitlementUseUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersInventoryApi();
            var userId = userId_example;  // string | The id of the user to check for or 'me' for logged in user
            var itemId = 56;  // int? | The id of the item
            var sku = sku_example;  // string | The specific sku of an entitlement_list addition to check entitlement for. This is of very limited and specific use and should generally be left out (optional) 
            var info = info_example;  // string | Any additional info to add to the log about this use (optional) 

            try
            {
                // Use an item
                apiInstance.EntitlementUseUsingPOST(userId, itemId, sku, info);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.EntitlementUseUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the user to check for or &#39;me&#39; for logged in user | 
 **itemId** | **int?**| The id of the item | 
 **sku** | **string**| The specific sku of an entitlement_list addition to check entitlement for. This is of very limited and specific use and should generally be left out | [optional] 
 **info** | **string**| Any additional info to add to the log about this use | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcurrenciesusingget1"></a>
# **GetCurrenciesUsingGET1**
> PageEntitlementItem GetCurrenciesUsingGET1 (int? size = null, int? page = null, string order = null)

List and search entitlement items

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCurrenciesUsingGET1Example
    {
        public void main()
        {
            
            var apiInstance = new UsersInventoryApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search entitlement items
                PageEntitlementItem result = apiInstance.GetCurrenciesUsingGET1(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.GetCurrenciesUsingGET1: " + e.Message );
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

[**PageEntitlementItem**](PageEntitlementItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getentitlementtemplateusingget"></a>
# **GetEntitlementTemplateUsingGET**
> ItemTemplateResource GetEntitlementTemplateUsingGET (string id)

Get a single entitlement template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEntitlementTemplateUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersInventoryApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single entitlement template
                ItemTemplateResource result = apiInstance.GetEntitlementTemplateUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.GetEntitlementTemplateUsingGET: " + e.Message );
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

<a name="getentitlementtemplatesusingget"></a>
# **GetEntitlementTemplatesUsingGET**
> PageItemTemplateResource GetEntitlementTemplatesUsingGET (int? size = null, int? page = null, string order = null)

List and search entitlement templates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEntitlementTemplatesUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersInventoryApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search entitlement templates
                PageItemTemplateResource result = apiInstance.GetEntitlementTemplatesUsingGET(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.GetEntitlementTemplatesUsingGET: " + e.Message );
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

<a name="getinventorylistusingget"></a>
# **GetInventoryListUsingGET**
> PageUserInventoryResource GetInventoryListUsingGET (bool? inactive = null, int? size = null, int? page = null, string filterItemName = null, string filterUsername = null, string filterGroup = null, string filterDate = null)

List the user inventory entries for all users

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetInventoryListUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersInventoryApi();
            var inactive = true;  // bool? | If true, accepts inactive user inventories (optional)  (default to false)
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var filterItemName = filterItemName_example;  // string | Filter by items whose name starts with a string (optional) 
            var filterUsername = filterUsername_example;  // string | Filter by entries owned by the user with the specified username (optional) 
            var filterGroup = filterGroup_example;  // string | Filter by entries owned by the users in a given group, by unique name (optional) 
            var filterDate = filterDate_example;  // string | A comma separated string without spaces.  First value is the operator to search on, second value is the log start date, a unix timestamp in seconds. Can be repeated for a range, eg: GT,123,LT,456  Allowed operators: (GT, LT, EQ, GOE, LOE). (optional) 

            try
            {
                // List the user inventory entries for all users
                PageUserInventoryResource result = apiInstance.GetInventoryListUsingGET(inactive, size, page, filterItemName, filterUsername, filterGroup, filterDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.GetInventoryListUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inactive** | **bool?**| If true, accepts inactive user inventories | [optional] [default to false]
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **filterItemName** | **string**| Filter by items whose name starts with a string | [optional] 
 **filterUsername** | **string**| Filter by entries owned by the user with the specified username | [optional] 
 **filterGroup** | **string**| Filter by entries owned by the users in a given group, by unique name | [optional] 
 **filterDate** | **string**| A comma separated string without spaces.  First value is the operator to search on, second value is the log start date, a unix timestamp in seconds. Can be repeated for a range, eg: GT,123,LT,456  Allowed operators: (GT, LT, EQ, GOE, LOE). | [optional] 

### Return type

[**PageUserInventoryResource**](PageUserInventoryResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinventoryusingget"></a>
# **GetInventoryUsingGET**
> UserInventoryResource GetInventoryUsingGET (int? userId, int? id)

Get an inventory entry

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetInventoryUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersInventoryApi();
            var userId = 56;  // int? | The id of the inventory owner or 'me' for the logged in user
            var id = 56;  // int? | The id of the user inventory

            try
            {
                // Get an inventory entry
                UserInventoryResource result = apiInstance.GetInventoryUsingGET(userId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.GetInventoryUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The id of the inventory owner or &#39;me&#39; for the logged in user | 
 **id** | **int?**| The id of the user inventory | 

### Return type

[**UserInventoryResource**](UserInventoryResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemusingget"></a>
# **GetItemUsingGET**
> EntitlementItem GetItemUsingGET (int? entitlementId)

Get a single entitlement item

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetItemUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new UsersInventoryApi();
            var entitlementId = 56;  // int? | The id of the entitlement

            try
            {
                // Get a single entitlement item
                EntitlementItem result = apiInstance.GetItemUsingGET(entitlementId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.GetItemUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entitlementId** | **int?**| The id of the entitlement | 

### Return type

[**EntitlementItem**](EntitlementItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserinventorylistusingget"></a>
# **GetUserInventoryListUsingGET**
> PageUserInventoryResource GetUserInventoryListUsingGET (int? id, bool? inactive = null, int? size = null, int? page = null, string filterItemName = null, long? filterMinDate = null, long? filterMaxDate = null)

List the user inventory entries for a given user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserInventoryListUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersInventoryApi();
            var id = 56;  // int? | The id of the user
            var inactive = true;  // bool? | If true, accepts inactive user inventories (optional)  (default to false)
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var filterItemName = filterItemName_example;  // string | Filter by items whose name starts with a string (optional) 
            var filterMinDate = 789;  // long? | Filter for inventory added after the specified date, unix timestamp in seconds (optional) 
            var filterMaxDate = 789;  // long? | Filter for inventory added before the specified date, unix timestamp in seconds (optional) 

            try
            {
                // List the user inventory entries for a given user
                PageUserInventoryResource result = apiInstance.GetUserInventoryListUsingGET(id, inactive, size, page, filterItemName, filterMinDate, filterMaxDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.GetUserInventoryListUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the user | 
 **inactive** | **bool?**| If true, accepts inactive user inventories | [optional] [default to false]
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **filterItemName** | **string**| Filter by items whose name starts with a string | [optional] 
 **filterMinDate** | **long?**| Filter for inventory added after the specified date, unix timestamp in seconds | [optional] 
 **filterMaxDate** | **long?**| Filter for inventory added before the specified date, unix timestamp in seconds | [optional] 

### Return type

[**PageUserInventoryResource**](PageUserInventoryResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserinventorylogusingget"></a>
# **GetUserInventoryLogUsingGET**
> PageUserItemLogResource GetUserInventoryLogUsingGET (string userId, int? id, int? size = null, int? page = null)

List the log entries for this inventory entry.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserInventoryLogUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersInventoryApi();
            var userId = userId_example;  // string | The id of the inventory owner or 'me' for the logged in user
            var id = 56;  // int? | The id of the user inventory
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // List the log entries for this inventory entry.
                PageUserItemLogResource result = apiInstance.GetUserInventoryLogUsingGET(userId, id, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.GetUserInventoryLogUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the inventory owner or &#39;me&#39; for the logged in user | 
 **id** | **int?**| The id of the user inventory | 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageUserItemLogResource**](PageUserItemLogResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateitemusingput1"></a>
# **UpdateItemUsingPUT1**
> void UpdateItemUsingPUT1 (int? entitlementId, EntitlementItem entitlementItem = null)

Update an entitlement item

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateItemUsingPUT1Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersInventoryApi();
            var entitlementId = 56;  // int? | The id of the entitlement
            var entitlementItem = new EntitlementItem(); // EntitlementItem | The entitlement item object (optional) 

            try
            {
                // Update an entitlement item
                apiInstance.UpdateItemUsingPUT1(entitlementId, entitlementItem);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.UpdateItemUsingPUT1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entitlementId** | **int?**| The id of the entitlement | 
 **entitlementItem** | [**EntitlementItem**](EntitlementItem.md)| The entitlement item object | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetemplateusingput3"></a>
# **UpdateTemplateUsingPUT3**
> void UpdateTemplateUsingPUT3 (string id, ItemTemplateResource template = null)

Update an entitlement template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateTemplateUsingPUT3Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersInventoryApi();
            var id = id_example;  // string | The id of the template
            var template = new ItemTemplateResource(); // ItemTemplateResource | The updated template (optional) 

            try
            {
                // Update an entitlement template
                apiInstance.UpdateTemplateUsingPUT3(id, template);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.UpdateTemplateUsingPUT3: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **template** | [**ItemTemplateResource**](ItemTemplateResource.md)| The updated template | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuserinventorybehaviordatausingput"></a>
# **UpdateUserInventoryBehaviorDataUsingPUT**
> void UpdateUserInventoryBehaviorDataUsingPUT (int? userId, int? id, Object data = null)

Set the behavior data for an inventory entry

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateUserInventoryBehaviorDataUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersInventoryApi();
            var userId = 56;  // int? | The id of the user
            var id = 56;  // int? | The id of the user inventory
            var data = ;  // Object | The data map (optional) 

            try
            {
                // Set the behavior data for an inventory entry
                apiInstance.UpdateUserInventoryBehaviorDataUsingPUT(userId, id, data);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.UpdateUserInventoryBehaviorDataUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The id of the user | 
 **id** | **int?**| The id of the user inventory | 
 **data** | **Object**| The data map | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuserinventoryexpiresusingput"></a>
# **UpdateUserInventoryExpiresUsingPUT**
> void UpdateUserInventoryExpiresUsingPUT (int? userId, int? id, long? timestamp = null)

Set the expiration date

Will change the current grace period for a subscription but not the bill date (possibly even ending before having the chance to re-bill)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateUserInventoryExpiresUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersInventoryApi();
            var userId = 56;  // int? | user_id
            var id = 56;  // int? | The id of the user inventory
            var timestamp = 789;  // long? | The new expiration date as a unix timestamp in seconds. May be null (no body). (optional) 

            try
            {
                // Set the expiration date
                apiInstance.UpdateUserInventoryExpiresUsingPUT(userId, id, timestamp);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.UpdateUserInventoryExpiresUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| user_id | 
 **id** | **int?**| The id of the user inventory | 
 **timestamp** | **long?**| The new expiration date as a unix timestamp in seconds. May be null (no body). | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuserinventorystatususingput"></a>
# **UpdateUserInventoryStatusUsingPUT**
> void UpdateUserInventoryStatusUsingPUT (int? userId, int? id, string inventoryStatus = null)

Set the status for an inventory entry

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateUserInventoryStatusUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersInventoryApi();
            var userId = 56;  // int? | The id of the user
            var id = 56;  // int? | The id of the user inventory
            var inventoryStatus = inventoryStatus_example;  // string | The inventory status object (optional) 

            try
            {
                // Set the status for an inventory entry
                apiInstance.UpdateUserInventoryStatusUsingPUT(userId, id, inventoryStatus);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.UpdateUserInventoryStatusUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The id of the user | 
 **id** | **int?**| The id of the user inventory | 
 **inventoryStatus** | **string**| The inventory status object | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

