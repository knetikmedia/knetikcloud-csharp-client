# IO.Swagger.Api.BRERuleEngineEventsApi

All URIs are relative to *https://devsandbox.knetikcloud.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FireEventUsingPOST**](BRERuleEngineEventsApi.md#fireeventusingpost) | **POST** /bre/events | Fire a new event, based on an existing trigger


<a name="fireeventusingpost"></a>
# **FireEventUsingPOST**
> void FireEventUsingPOST (BreEvent breEvent = null, OAuth2Authentication authentication = null)

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
            
            var apiInstance = new BRERuleEngineEventsApi();
            var breEvent = new BreEvent(); // BreEvent | The BRE event object (optional) 
            var authentication = new OAuth2Authentication(); // OAuth2Authentication | The authentication object (optional) 

            try
            {
                // Fire a new event, based on an existing trigger
                apiInstance.FireEventUsingPOST(breEvent, authentication);
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
 **authentication** | [**OAuth2Authentication**](OAuth2Authentication.md)| The authentication object | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

