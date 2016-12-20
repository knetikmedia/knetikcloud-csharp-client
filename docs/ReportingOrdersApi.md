# IO.Swagger.Api.ReportingOrdersApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDailyInvoicesUsingGET**](ReportingOrdersApi.md#getdailyinvoicesusingget) | **GET** /reporting/orders/count/{currency_code} | Retrieve invoice counts aggregated by time ranges


<a name="getdailyinvoicesusingget"></a>
# **GetDailyInvoicesUsingGET**
> PageAggregateInvoiceReportResource GetDailyInvoicesUsingGET (string currencyCode, string granularity = null, string filterPaymentStatus = null, string filterFulfillmentStatus = null, long? startDate = null, long? endDate = null)

Retrieve invoice counts aggregated by time ranges

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDailyInvoicesUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportingOrdersApi();
            var currencyCode = currencyCode_example;  // string | The code for a currency to get sales data for
            var granularity = granularity_example;  // string | The time duration to aggregate by (optional)  (default to day)
            var filterPaymentStatus = filterPaymentStatus_example;  // string | A payment status to filter results by, can be a comma separated list (optional) 
            var filterFulfillmentStatus = filterFulfillmentStatus_example;  // string | An invoice fulfillment status to filter results by, can be a comma separated list (optional) 
            var startDate = 789;  // long? | The start of the time range to return, unix timestamp in seconds. Default is beginning of time (optional) 
            var endDate = 789;  // long? | The end of the time range to return, unix timestamp in seconds. Default is end of time (optional) 

            try
            {
                // Retrieve invoice counts aggregated by time ranges
                PageAggregateInvoiceReportResource result = apiInstance.GetDailyInvoicesUsingGET(currencyCode, granularity, filterPaymentStatus, filterFulfillmentStatus, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingOrdersApi.GetDailyInvoicesUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currencyCode** | **string**| The code for a currency to get sales data for | 
 **granularity** | **string**| The time duration to aggregate by | [optional] [default to day]
 **filterPaymentStatus** | **string**| A payment status to filter results by, can be a comma separated list | [optional] 
 **filterFulfillmentStatus** | **string**| An invoice fulfillment status to filter results by, can be a comma separated list | [optional] 
 **startDate** | **long?**| The start of the time range to return, unix timestamp in seconds. Default is beginning of time | [optional] 
 **endDate** | **long?**| The end of the time range to return, unix timestamp in seconds. Default is end of time | [optional] 

### Return type

[**PageAggregateInvoiceReportResource**](PageAggregateInvoiceReportResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

