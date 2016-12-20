# IO.Swagger.Api.ReportingRevenueApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExecutiveRevenueCountrySalesUsingGET**](ReportingRevenueApi.md#executiverevenuecountrysalesusingget) | **GET** /reporting/revenue/countries/{currency_code} | Get revenue info by country
[**ExecutiveRevenueItemSalesUsingGET**](ReportingRevenueApi.md#executiverevenueitemsalesusingget) | **GET** /reporting/revenue/item-sales/{currency_code} | Get item revenue info
[**ExecutiveRevenueProductSalesUsingGET**](ReportingRevenueApi.md#executiverevenueproductsalesusingget) | **GET** /reporting/revenue/products/{currency_code} | Get revenue info by item
[**ExecutiveRevenueRefundsUsingGET**](ReportingRevenueApi.md#executiverevenuerefundsusingget) | **GET** /reporting/revenue/refunds/{currency_code} | Get refund revenue info
[**ExecutiveRevenueSubscriptionSalesUsingGET**](ReportingRevenueApi.md#executiverevenuesubscriptionsalesusingget) | **GET** /reporting/revenue/subscription-sales/{currency_code} | Get subscription revenue info


<a name="executiverevenuecountrysalesusingget"></a>
# **ExecutiveRevenueCountrySalesUsingGET**
> PageResourceRevenueCountryReportResource ExecutiveRevenueCountrySalesUsingGET (string currencyCode, long? startDate = null, long? endDate = null, int? size = null, int? page = null)

Get revenue info by country

Get basic info about revenue from sales of all types, summed up within a time range and split out by country. Sorted for largest revenue at the top

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExecutiveRevenueCountrySalesUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportingRevenueApi();
            var currencyCode = currencyCode_example;  // string | The code for a currency to get sales data for
            var startDate = 789;  // long? | The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time (optional) 
            var endDate = 789;  // long? | The end of the time range to aggregate, unix timestamp in seconds. Default is end of time (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Get revenue info by country
                PageResourceRevenueCountryReportResource result = apiInstance.ExecutiveRevenueCountrySalesUsingGET(currencyCode, startDate, endDate, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingRevenueApi.ExecutiveRevenueCountrySalesUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currencyCode** | **string**| The code for a currency to get sales data for | 
 **startDate** | **long?**| The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time | [optional] 
 **endDate** | **long?**| The end of the time range to aggregate, unix timestamp in seconds. Default is end of time | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceRevenueCountryReportResource**](PageResourceRevenueCountryReportResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="executiverevenueitemsalesusingget"></a>
# **ExecutiveRevenueItemSalesUsingGET**
> RevenueReportResource ExecutiveRevenueItemSalesUsingGET (string currencyCode, long? startDate = null, long? endDate = null)

Get item revenue info

Get basic info about revenue from sales of items and bundles (not subscriptions, shipping, etc), summed up within a time range

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExecutiveRevenueItemSalesUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportingRevenueApi();
            var currencyCode = currencyCode_example;  // string | The code for a currency to get sales data for
            var startDate = 789;  // long? | The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time (optional) 
            var endDate = 789;  // long? | The end of the time range to aggregate, unix timestamp in seconds. Default is end of time (optional) 

            try
            {
                // Get item revenue info
                RevenueReportResource result = apiInstance.ExecutiveRevenueItemSalesUsingGET(currencyCode, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingRevenueApi.ExecutiveRevenueItemSalesUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currencyCode** | **string**| The code for a currency to get sales data for | 
 **startDate** | **long?**| The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time | [optional] 
 **endDate** | **long?**| The end of the time range to aggregate, unix timestamp in seconds. Default is end of time | [optional] 

### Return type

[**RevenueReportResource**](RevenueReportResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="executiverevenueproductsalesusingget"></a>
# **ExecutiveRevenueProductSalesUsingGET**
> PageResourceRevenueProductReportResource ExecutiveRevenueProductSalesUsingGET (string currencyCode, long? startDate = null, long? endDate = null, int? size = null, int? page = null)

Get revenue info by item

Get basic info about revenue from sales of all types, summed up within a time range and split out by specific item. Sorted for largest revenue at the top

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExecutiveRevenueProductSalesUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportingRevenueApi();
            var currencyCode = currencyCode_example;  // string | The code for a currency to get sales data for
            var startDate = 789;  // long? | The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time (optional) 
            var endDate = 789;  // long? | The end of the time range to aggregate, unix timestamp in seconds. Default is end of time (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Get revenue info by item
                PageResourceRevenueProductReportResource result = apiInstance.ExecutiveRevenueProductSalesUsingGET(currencyCode, startDate, endDate, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingRevenueApi.ExecutiveRevenueProductSalesUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currencyCode** | **string**| The code for a currency to get sales data for | 
 **startDate** | **long?**| The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time | [optional] 
 **endDate** | **long?**| The end of the time range to aggregate, unix timestamp in seconds. Default is end of time | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceRevenueProductReportResource**](PageResourceRevenueProductReportResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="executiverevenuerefundsusingget"></a>
# **ExecutiveRevenueRefundsUsingGET**
> RevenueReportResource ExecutiveRevenueRefundsUsingGET (string currencyCode, long? startDate = null, long? endDate = null)

Get refund revenue info

Get basic info about revenue loss from refunds (for all item types), summed up within a time range.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExecutiveRevenueRefundsUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportingRevenueApi();
            var currencyCode = currencyCode_example;  // string | The code for a currency to get refund data for
            var startDate = 789;  // long? | The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time (optional) 
            var endDate = 789;  // long? | The end of the time range to aggregate, unix timestamp in seconds. Default is end of time (optional) 

            try
            {
                // Get refund revenue info
                RevenueReportResource result = apiInstance.ExecutiveRevenueRefundsUsingGET(currencyCode, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingRevenueApi.ExecutiveRevenueRefundsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currencyCode** | **string**| The code for a currency to get refund data for | 
 **startDate** | **long?**| The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time | [optional] 
 **endDate** | **long?**| The end of the time range to aggregate, unix timestamp in seconds. Default is end of time | [optional] 

### Return type

[**RevenueReportResource**](RevenueReportResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="executiverevenuesubscriptionsalesusingget"></a>
# **ExecutiveRevenueSubscriptionSalesUsingGET**
> RevenueReportResource ExecutiveRevenueSubscriptionSalesUsingGET (string currencyCode, long? startDate = null, long? endDate = null)

Get subscription revenue info

Get basic info about revenue from sales of new subscriptions as well as recurring payemnts, summed up within a time range

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExecutiveRevenueSubscriptionSalesUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportingRevenueApi();
            var currencyCode = currencyCode_example;  // string | The code for a currency to get sales data for
            var startDate = 789;  // long? | The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time (optional) 
            var endDate = 789;  // long? | The end of the time range to aggregate, unix timestamp in seconds. Default is end of time (optional) 

            try
            {
                // Get subscription revenue info
                RevenueReportResource result = apiInstance.ExecutiveRevenueSubscriptionSalesUsingGET(currencyCode, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingRevenueApi.ExecutiveRevenueSubscriptionSalesUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currencyCode** | **string**| The code for a currency to get sales data for | 
 **startDate** | **long?**| The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time | [optional] 
 **endDate** | **long?**| The end of the time range to aggregate, unix timestamp in seconds. Default is end of time | [optional] 

### Return type

[**RevenueReportResource**](RevenueReportResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

