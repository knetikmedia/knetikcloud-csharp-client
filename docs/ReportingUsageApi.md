# IO.Swagger.Api.ReportingUsageApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetUsageByDayUsingGET**](ReportingUsageApi.md#getusagebydayusingget) | **GET** /reporting/usage/day | Returns aggregated endpoint usage information by the day
[**GetUsageByHourUsingGET**](ReportingUsageApi.md#getusagebyhourusingget) | **GET** /reporting/usage/hour | Returns aggregated endpoint usage information by hour
[**GetUsageByMinuteUsingGET**](ReportingUsageApi.md#getusagebyminuteusingget) | **GET** /reporting/usage/minute | Returns aggregated endpoint usage information by minute
[**GetUsageByMonthUsingGET**](ReportingUsageApi.md#getusagebymonthusingget) | **GET** /reporting/usage/month | Returns aggregated endpoint usage information by month
[**GetUsageByYearUsingGET**](ReportingUsageApi.md#getusagebyyearusingget) | **GET** /reporting/usage/year | Returns aggregated endpoint usage information by year


<a name="getusagebydayusingget"></a>
# **GetUsageByDayUsingGET**
> PageResourceUsageInfo GetUsageByDayUsingGET (long? startDate, long? endDate, bool? combineEndpoints = null, int? size = null, int? page = null)

Returns aggregated endpoint usage information by the day

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUsageByDayUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportingUsageApi();
            var startDate = 789;  // long? | The beginning of the range being requested, unix timestamp in seconds
            var endDate = 789;  // long? | The ending of the range being requested, unix timestamp in seconds
            var combineEndpoints = true;  // bool? | Whether to combine counts from different endpoint. Removes the url and method from the result object (optional)  (default to false)
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Returns aggregated endpoint usage information by the day
                PageResourceUsageInfo result = apiInstance.GetUsageByDayUsingGET(startDate, endDate, combineEndpoints, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingUsageApi.GetUsageByDayUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **long?**| The beginning of the range being requested, unix timestamp in seconds | 
 **endDate** | **long?**| The ending of the range being requested, unix timestamp in seconds | 
 **combineEndpoints** | **bool?**| Whether to combine counts from different endpoint. Removes the url and method from the result object | [optional] [default to false]
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceUsageInfo**](PageResourceUsageInfo.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusagebyhourusingget"></a>
# **GetUsageByHourUsingGET**
> PageResourceUsageInfo GetUsageByHourUsingGET (long? startDate, long? endDate, bool? combineEndpoints = null, int? size = null, int? page = null)

Returns aggregated endpoint usage information by hour

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUsageByHourUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportingUsageApi();
            var startDate = 789;  // long? | The beginning of the range being requested, unix timestamp in seconds
            var endDate = 789;  // long? | The ending of the range being requested, unix timestamp in seconds
            var combineEndpoints = true;  // bool? | Whether to combine counts from different endpoint. Removes the url and method from the result object (optional)  (default to false)
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Returns aggregated endpoint usage information by hour
                PageResourceUsageInfo result = apiInstance.GetUsageByHourUsingGET(startDate, endDate, combineEndpoints, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingUsageApi.GetUsageByHourUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **long?**| The beginning of the range being requested, unix timestamp in seconds | 
 **endDate** | **long?**| The ending of the range being requested, unix timestamp in seconds | 
 **combineEndpoints** | **bool?**| Whether to combine counts from different endpoint. Removes the url and method from the result object | [optional] [default to false]
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceUsageInfo**](PageResourceUsageInfo.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusagebyminuteusingget"></a>
# **GetUsageByMinuteUsingGET**
> PageResourceUsageInfo GetUsageByMinuteUsingGET (long? startDate, long? endDate, bool? combineEndpoints = null, int? size = null, int? page = null)

Returns aggregated endpoint usage information by minute

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUsageByMinuteUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportingUsageApi();
            var startDate = 789;  // long? | The beginning of the range being requested, unix timestamp in seconds
            var endDate = 789;  // long? | The ending of the range being requested, unix timestamp in seconds
            var combineEndpoints = true;  // bool? | Whether to combine counts from different endpoint. Removes the url and method from the result object (optional)  (default to false)
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Returns aggregated endpoint usage information by minute
                PageResourceUsageInfo result = apiInstance.GetUsageByMinuteUsingGET(startDate, endDate, combineEndpoints, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingUsageApi.GetUsageByMinuteUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **long?**| The beginning of the range being requested, unix timestamp in seconds | 
 **endDate** | **long?**| The ending of the range being requested, unix timestamp in seconds | 
 **combineEndpoints** | **bool?**| Whether to combine counts from different endpoint. Removes the url and method from the result object | [optional] [default to false]
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceUsageInfo**](PageResourceUsageInfo.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusagebymonthusingget"></a>
# **GetUsageByMonthUsingGET**
> PageResourceUsageInfo GetUsageByMonthUsingGET (long? startDate, long? endDate, bool? combineEndpoints = null, int? size = null, int? page = null)

Returns aggregated endpoint usage information by month

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUsageByMonthUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportingUsageApi();
            var startDate = 789;  // long? | The beginning of the range being requested, unix timestamp in seconds
            var endDate = 789;  // long? | The ending of the range being requested, unix timestamp in seconds
            var combineEndpoints = true;  // bool? | Whether to combine counts from different endpoint. Removes the url and method from the result object (optional)  (default to false)
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Returns aggregated endpoint usage information by month
                PageResourceUsageInfo result = apiInstance.GetUsageByMonthUsingGET(startDate, endDate, combineEndpoints, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingUsageApi.GetUsageByMonthUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **long?**| The beginning of the range being requested, unix timestamp in seconds | 
 **endDate** | **long?**| The ending of the range being requested, unix timestamp in seconds | 
 **combineEndpoints** | **bool?**| Whether to combine counts from different endpoint. Removes the url and method from the result object | [optional] [default to false]
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceUsageInfo**](PageResourceUsageInfo.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusagebyyearusingget"></a>
# **GetUsageByYearUsingGET**
> PageResourceUsageInfo GetUsageByYearUsingGET (long? startDate, long? endDate, bool? combineEndpoints = null, int? size = null, int? page = null)

Returns aggregated endpoint usage information by year

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUsageByYearUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportingUsageApi();
            var startDate = 789;  // long? | The beginning of the range being requested, unix timestamp in seconds
            var endDate = 789;  // long? | The ending of the range being requested, unix timestamp in seconds
            var combineEndpoints = true;  // bool? | Whether to combine counts from different endpoint. Removes the url and method from the result object (optional)  (default to false)
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Returns aggregated endpoint usage information by year
                PageResourceUsageInfo result = apiInstance.GetUsageByYearUsingGET(startDate, endDate, combineEndpoints, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingUsageApi.GetUsageByYearUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **long?**| The beginning of the range being requested, unix timestamp in seconds | 
 **endDate** | **long?**| The ending of the range being requested, unix timestamp in seconds | 
 **combineEndpoints** | **bool?**| Whether to combine counts from different endpoint. Removes the url and method from the result object | [optional] [default to false]
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceUsageInfo**](PageResourceUsageInfo.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

