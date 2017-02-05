# IO.Swagger.Api.MediaModerationApi

All URIs are relative to *https://integration.knetikcloud.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetFlagReportUsingGET**](MediaModerationApi.md#getflagreportusingget) | **GET** /moderation/reports/{id} | Get a flag report
[**GetFlagsReportUsingGET**](MediaModerationApi.md#getflagsreportusingget) | **GET** /moderation/reports | Returns a page of flag reports
[**SetFlagResolutionUsingPUT**](MediaModerationApi.md#setflagresolutionusingput) | **PUT** /moderation/reports/{id} | Update a flag report


<a name="getflagreportusingget"></a>
# **GetFlagReportUsingGET**
> void GetFlagReportUsingGET (long? id)

Get a flag report

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFlagReportUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaModerationApi();
            var id = 789;  // long? | The flag report id

            try
            {
                // Get a flag report
                apiInstance.GetFlagReportUsingGET(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaModerationApi.GetFlagReportUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The flag report id | 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getflagsreportusingget"></a>
# **GetFlagsReportUsingGET**
> PageResourceFlagReportResource GetFlagsReportUsingGET (bool? excludeResolved = null, string filterContext = null, int? size = null, int? page = null)

Returns a page of flag reports

Context can be either a free-form string or a pre-defined context name

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFlagsReportUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaModerationApi();
            var excludeResolved = true;  // bool? | Ignore resolved context (optional)  (default to true)
            var filterContext = filterContext_example;  // string | Filter by moderation context (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Returns a page of flag reports
                PageResourceFlagReportResource result = apiInstance.GetFlagsReportUsingGET(excludeResolved, filterContext, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaModerationApi.GetFlagsReportUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeResolved** | **bool?**| Ignore resolved context | [optional] [default to true]
 **filterContext** | **string**| Filter by moderation context | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceFlagReportResource**](PageResourceFlagReportResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setflagresolutionusingput"></a>
# **SetFlagResolutionUsingPUT**
> void SetFlagResolutionUsingPUT (long? id, FlagReportResource flagReportResource = null)

Update a flag report

Lets you set the resolution of a report. Resolution types is {banned,ignore} in case of 'banned' you will need to pass the reason.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetFlagResolutionUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaModerationApi();
            var id = 789;  // long? | The flag report id
            var flagReportResource = new FlagReportResource(); // FlagReportResource | The new flag report (optional) 

            try
            {
                // Update a flag report
                apiInstance.SetFlagResolutionUsingPUT(id, flagReportResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaModerationApi.SetFlagResolutionUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The flag report id | 
 **flagReportResource** | [**FlagReportResource**](FlagReportResource.md)| The new flag report | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

