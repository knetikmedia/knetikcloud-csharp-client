# com.knetikcloud.Api.Reporting_UsageApi

All URIs are relative to *https://jsapi-integration.us-east-1.elasticbeanstalk.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetUsageByDay**](Reporting_UsageApi.md#getusagebyday) | **GET** /reporting/usage/day | Returns aggregated endpoint usage information by day
[**GetUsageByHour**](Reporting_UsageApi.md#getusagebyhour) | **GET** /reporting/usage/hour | Returns aggregated endpoint usage information by hour
[**GetUsageByMinute**](Reporting_UsageApi.md#getusagebyminute) | **GET** /reporting/usage/minute | Returns aggregated endpoint usage information by minute
[**GetUsageByMonth**](Reporting_UsageApi.md#getusagebymonth) | **GET** /reporting/usage/month | Returns aggregated endpoint usage information by month
[**GetUsageByYear**](Reporting_UsageApi.md#getusagebyyear) | **GET** /reporting/usage/year | Returns aggregated endpoint usage information by year
[**GetUsageEndpoints**](Reporting_UsageApi.md#getusageendpoints) | **GET** /reporting/usage/endpoints | Returns list of endpoints called (method and url)


<a name="getusagebyday"></a>
# **GetUsageByDay**
> PageResourceUsageInfo GetUsageByDay (long? startDate, long? endDate, bool? combineEndpoints = null, string method = null, string url = null, int? size = null, int? page = null)

Returns aggregated endpoint usage information by day

<b>Permissions Needed:</b> USAGE_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUsageByDayExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Reporting_UsageApi();
            var startDate = 789;  // long? | The beginning of the range being requested, unix timestamp in seconds
            var endDate = 789;  // long? | The ending of the range being requested, unix timestamp in seconds
            var combineEndpoints = true;  // bool? | Whether to combine counts from different endpoint. Removes the url and method from the result object (optional)  (default to false)
            var method = method_example;  // string | Filter for a certain endpoint method.  Must include url as well to work (optional) 
            var url = url_example;  // string | Filter for a certain endpoint.  Must include method as well to work (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Returns aggregated endpoint usage information by day
                PageResourceUsageInfo result = apiInstance.GetUsageByDay(startDate, endDate, combineEndpoints, method, url, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Reporting_UsageApi.GetUsageByDay: " + e.Message );
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
 **method** | **string**| Filter for a certain endpoint method.  Must include url as well to work | [optional] 
 **url** | **string**| Filter for a certain endpoint.  Must include method as well to work | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceUsageInfo**](PageResourceUsageInfo.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusagebyhour"></a>
# **GetUsageByHour**
> PageResourceUsageInfo GetUsageByHour (long? startDate, long? endDate, bool? combineEndpoints = null, string method = null, string url = null, int? size = null, int? page = null)

Returns aggregated endpoint usage information by hour

<b>Permissions Needed:</b> USAGE_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUsageByHourExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Reporting_UsageApi();
            var startDate = 789;  // long? | The beginning of the range being requested, unix timestamp in seconds
            var endDate = 789;  // long? | The ending of the range being requested, unix timestamp in seconds
            var combineEndpoints = true;  // bool? | Whether to combine counts from different endpoint. Removes the url and method from the result object (optional)  (default to false)
            var method = method_example;  // string | Filter for a certain endpoint method.  Must include url as well to work (optional) 
            var url = url_example;  // string | Filter for a certain endpoint.  Must include method as well to work (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Returns aggregated endpoint usage information by hour
                PageResourceUsageInfo result = apiInstance.GetUsageByHour(startDate, endDate, combineEndpoints, method, url, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Reporting_UsageApi.GetUsageByHour: " + e.Message );
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
 **method** | **string**| Filter for a certain endpoint method.  Must include url as well to work | [optional] 
 **url** | **string**| Filter for a certain endpoint.  Must include method as well to work | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceUsageInfo**](PageResourceUsageInfo.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusagebyminute"></a>
# **GetUsageByMinute**
> PageResourceUsageInfo GetUsageByMinute (long? startDate, long? endDate, bool? combineEndpoints = null, string method = null, string url = null, int? size = null, int? page = null)

Returns aggregated endpoint usage information by minute

<b>Permissions Needed:</b> USAGE_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUsageByMinuteExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Reporting_UsageApi();
            var startDate = 789;  // long? | The beginning of the range being requested, unix timestamp in seconds
            var endDate = 789;  // long? | The ending of the range being requested, unix timestamp in seconds
            var combineEndpoints = true;  // bool? | Whether to combine counts from different endpoint. Removes the url and method from the result object (optional)  (default to false)
            var method = method_example;  // string | Filter for a certain endpoint method.  Must include url as well to work (optional) 
            var url = url_example;  // string | Filter for a certain endpoint.  Must include method as well to work (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Returns aggregated endpoint usage information by minute
                PageResourceUsageInfo result = apiInstance.GetUsageByMinute(startDate, endDate, combineEndpoints, method, url, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Reporting_UsageApi.GetUsageByMinute: " + e.Message );
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
 **method** | **string**| Filter for a certain endpoint method.  Must include url as well to work | [optional] 
 **url** | **string**| Filter for a certain endpoint.  Must include method as well to work | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceUsageInfo**](PageResourceUsageInfo.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusagebymonth"></a>
# **GetUsageByMonth**
> PageResourceUsageInfo GetUsageByMonth (long? startDate, long? endDate, bool? combineEndpoints = null, string method = null, string url = null, int? size = null, int? page = null)

Returns aggregated endpoint usage information by month

<b>Permissions Needed:</b> USAGE_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUsageByMonthExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Reporting_UsageApi();
            var startDate = 789;  // long? | The beginning of the range being requested, unix timestamp in seconds
            var endDate = 789;  // long? | The ending of the range being requested, unix timestamp in seconds
            var combineEndpoints = true;  // bool? | Whether to combine counts from different endpoint. Removes the url and method from the result object (optional)  (default to false)
            var method = method_example;  // string | Filter for a certain endpoint method.  Must include url as well to work (optional) 
            var url = url_example;  // string | Filter for a certain endpoint.  Must include method as well to work (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Returns aggregated endpoint usage information by month
                PageResourceUsageInfo result = apiInstance.GetUsageByMonth(startDate, endDate, combineEndpoints, method, url, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Reporting_UsageApi.GetUsageByMonth: " + e.Message );
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
 **method** | **string**| Filter for a certain endpoint method.  Must include url as well to work | [optional] 
 **url** | **string**| Filter for a certain endpoint.  Must include method as well to work | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceUsageInfo**](PageResourceUsageInfo.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusagebyyear"></a>
# **GetUsageByYear**
> PageResourceUsageInfo GetUsageByYear (long? startDate, long? endDate, bool? combineEndpoints = null, string method = null, string url = null, int? size = null, int? page = null)

Returns aggregated endpoint usage information by year

<b>Permissions Needed:</b> USAGE_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUsageByYearExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Reporting_UsageApi();
            var startDate = 789;  // long? | The beginning of the range being requested, unix timestamp in seconds
            var endDate = 789;  // long? | The ending of the range being requested, unix timestamp in seconds
            var combineEndpoints = true;  // bool? | Whether to combine counts from different endpoints. Removes the url and method from the result object (optional)  (default to false)
            var method = method_example;  // string | Filter for a certain endpoint method.  Must include url as well to work (optional) 
            var url = url_example;  // string | Filter for a certain endpoint.  Must include method as well to work (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Returns aggregated endpoint usage information by year
                PageResourceUsageInfo result = apiInstance.GetUsageByYear(startDate, endDate, combineEndpoints, method, url, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Reporting_UsageApi.GetUsageByYear: " + e.Message );
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
 **combineEndpoints** | **bool?**| Whether to combine counts from different endpoints. Removes the url and method from the result object | [optional] [default to false]
 **method** | **string**| Filter for a certain endpoint method.  Must include url as well to work | [optional] 
 **url** | **string**| Filter for a certain endpoint.  Must include method as well to work | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceUsageInfo**](PageResourceUsageInfo.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusageendpoints"></a>
# **GetUsageEndpoints**
> List<string> GetUsageEndpoints (long? startDate, long? endDate)

Returns list of endpoints called (method and url)

<b>Permissions Needed:</b> USAGE_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUsageEndpointsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Reporting_UsageApi();
            var startDate = 789;  // long? | The beginning of the range being requested, unix timestamp in seconds
            var endDate = 789;  // long? | The ending of the range being requested, unix timestamp in seconds

            try
            {
                // Returns list of endpoints called (method and url)
                List&lt;string&gt; result = apiInstance.GetUsageEndpoints(startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Reporting_UsageApi.GetUsageEndpoints: " + e.Message );
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

### Return type

**List<string>**

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

