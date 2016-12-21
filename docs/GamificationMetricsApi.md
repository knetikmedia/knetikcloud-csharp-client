# IO.Swagger.Api.GamificationMetricsApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddMetricUsingPOST**](GamificationMetricsApi.md#addmetricusingpost) | **POST** /metrics | Add a metric


<a name="addmetricusingpost"></a>
# **AddMetricUsingPOST**
> void AddMetricUsingPOST (MetricResource metric = null)

Add a metric

Post a new score/stat for an activity occurrence without ending the occurrence itself

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddMetricUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationMetricsApi();
            var metric = new MetricResource(); // MetricResource | The new metric (optional) 

            try
            {
                // Add a metric
                apiInstance.AddMetricUsingPOST(metric);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationMetricsApi.AddMetricUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **metric** | [**MetricResource**](MetricResource.md)| The new metric | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

