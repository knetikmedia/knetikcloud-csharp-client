# IO.Swagger.Api.UtilBatchApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBatchPOSTUsingPOST**](UtilBatchApi.md#getbatchpostusingpost) | **POST** /batch | Request to run API call given the method, content type, path url, and body of request


<a name="getbatchpostusingpost"></a>
# **GetBatchPOSTUsingPOST**
> void GetBatchPOSTUsingPOST (Batch batch = null)

Request to run API call given the method, content type, path url, and body of request

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBatchPOSTUsingPOSTExample
    {
        public void main()
        {
            
            var apiInstance = new UtilBatchApi();
            var batch = new Batch(); // Batch | The batch object (optional) 

            try
            {
                // Request to run API call given the method, content type, path url, and body of request
                apiInstance.GetBatchPOSTUsingPOST(batch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilBatchApi.GetBatchPOSTUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batch** | [**Batch**](Batch.md)| The batch object | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

