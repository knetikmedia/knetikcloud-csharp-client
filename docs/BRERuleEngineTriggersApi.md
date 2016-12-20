# IO.Swagger.Api.BRERuleEngineTriggersApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTriggerUsingPOST**](BRERuleEngineTriggersApi.md#createtriggerusingpost) | **POST** /bre/triggers | Create a trigger
[**DeleteTriggerUsingDELETE**](BRERuleEngineTriggersApi.md#deletetriggerusingdelete) | **DELETE** /bre/triggers/{event_name} | Delete a trigger
[**GetTriggerUsingGET**](BRERuleEngineTriggersApi.md#gettriggerusingget) | **GET** /bre/triggers/{event_name} | Get a single trigger
[**GetTriggersUsingGET**](BRERuleEngineTriggersApi.md#gettriggersusingget) | **GET** /bre/triggers | List triggers
[**UpdateTriggerUsingPUT**](BRERuleEngineTriggersApi.md#updatetriggerusingput) | **PUT** /bre/triggers/{event_name} | Update a trigger


<a name="createtriggerusingpost"></a>
# **CreateTriggerUsingPOST**
> BreTriggerResource CreateTriggerUsingPOST (BreTriggerResource breTriggerResource = null)

Create a trigger

Customer added triggers will not be fired automatically or have rules associated with them by default. Custom rules must be added to get use from the trigger and it must then be fired from the outside. See the Bre Event services

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateTriggerUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineTriggersApi();
            var breTriggerResource = new BreTriggerResource(); // BreTriggerResource | The BRE trigger resource object (optional) 

            try
            {
                // Create a trigger
                BreTriggerResource result = apiInstance.CreateTriggerUsingPOST(breTriggerResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineTriggersApi.CreateTriggerUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **breTriggerResource** | [**BreTriggerResource**](BreTriggerResource.md)| The BRE trigger resource object | [optional] 

### Return type

[**BreTriggerResource**](BreTriggerResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetriggerusingdelete"></a>
# **DeleteTriggerUsingDELETE**
> void DeleteTriggerUsingDELETE (string eventName)

Delete a trigger

May fail if there are existing rules against it. Cannot delete core triggers

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteTriggerUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineTriggersApi();
            var eventName = eventName_example;  // string | The trigger event name

            try
            {
                // Delete a trigger
                apiInstance.DeleteTriggerUsingDELETE(eventName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineTriggersApi.DeleteTriggerUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventName** | **string**| The trigger event name | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettriggerusingget"></a>
# **GetTriggerUsingGET**
> BreTriggerResource GetTriggerUsingGET (string eventName)

Get a single trigger

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTriggerUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineTriggersApi();
            var eventName = eventName_example;  // string | The trigger event name

            try
            {
                // Get a single trigger
                BreTriggerResource result = apiInstance.GetTriggerUsingGET(eventName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineTriggersApi.GetTriggerUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventName** | **string**| The trigger event name | 

### Return type

[**BreTriggerResource**](BreTriggerResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettriggersusingget"></a>
# **GetTriggersUsingGET**
> PageResourceBreTriggerResource GetTriggersUsingGET (bool? filterSystem = null, string filterCategory = null, string filterName = null, int? size = null, int? page = null)

List triggers

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTriggersUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineTriggersApi();
            var filterSystem = true;  // bool? | Filter for triggers that are system triggers when true, or not when false. Leave off for both mixed (optional) 
            var filterCategory = filterCategory_example;  // string | Filter for triggers that are within a specific category (optional) 
            var filterName = filterName_example;  // string | Filter for triggers that have names containing the given string (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // List triggers
                PageResourceBreTriggerResource result = apiInstance.GetTriggersUsingGET(filterSystem, filterCategory, filterName, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineTriggersApi.GetTriggersUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterSystem** | **bool?**| Filter for triggers that are system triggers when true, or not when false. Leave off for both mixed | [optional] 
 **filterCategory** | **string**| Filter for triggers that are within a specific category | [optional] 
 **filterName** | **string**| Filter for triggers that have names containing the given string | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceBreTriggerResource**](PageResourceBreTriggerResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetriggerusingput"></a>
# **UpdateTriggerUsingPUT**
> void UpdateTriggerUsingPUT (string eventName, BreTriggerResource breTriggerResource = null)

Update a trigger

May fail if new parameters mismatch requirements of existing rules. Cannot update core triggers

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateTriggerUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineTriggersApi();
            var eventName = eventName_example;  // string | The trigger event name
            var breTriggerResource = new BreTriggerResource(); // BreTriggerResource | The BRE trigger resource object (optional) 

            try
            {
                // Update a trigger
                apiInstance.UpdateTriggerUsingPUT(eventName, breTriggerResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineTriggersApi.UpdateTriggerUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventName** | **string**| The trigger event name | 
 **breTriggerResource** | [**BreTriggerResource**](BreTriggerResource.md)| The BRE trigger resource object | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

