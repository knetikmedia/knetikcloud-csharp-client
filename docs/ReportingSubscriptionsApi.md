# IO.Swagger.Api.ReportingSubscriptionsApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListBillingReportsUsingGET**](ReportingSubscriptionsApi.md#listbillingreportsusingget) | **GET** /reporting/subscription | Get a list of available subscription reports in most recent first order


<a name="listbillingreportsusingget"></a>
# **ListBillingReportsUsingGET**
> PageBillingReport ListBillingReportsUsingGET (int? size = null, int? page = null)

Get a list of available subscription reports in most recent first order

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListBillingReportsUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportingSubscriptionsApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Get a list of available subscription reports in most recent first order
                PageBillingReport result = apiInstance.ListBillingReportsUsingGET(size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingSubscriptionsApi.ListBillingReportsUsingGET: " + e.Message );
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

### Return type

[**PageBillingReport**](PageBillingReport.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

