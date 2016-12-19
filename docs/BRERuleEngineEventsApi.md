# IO.Swagger.Api.BRERuleEngineEventsApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FireEventUsingPOST**](BRERuleEngineEventsApi.md#fireeventusingpost) | **POST** /bre/events | Fire a new event, based on an existing trigger


<a name="fireeventusingpost"></a>
# **FireEventUsingPOST**
> void FireEventUsingPOST (BreEvent breEvent = null)

Fire a new event, based on an existing trigger

Parameters within the event must match names and types from the trigger. Actual rule execution is asynchornous.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FireEventUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineEventsApi();
            var breEvent = new BreEvent(); // BreEvent | The BRE event object (optional) 

            try
            {
                // Fire a new event, based on an existing trigger
                apiInstance.FireEventUsingPOST(breEvent);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineEventsApi.FireEventUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **breEvent** | [**BreEvent**](BreEvent.md)| The BRE event object | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
