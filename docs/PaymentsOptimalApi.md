# IO.Swagger.Api.PaymentsOptimalApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SilentPostUsingPOST**](PaymentsOptimalApi.md#silentpostusingpost) | **POST** /payment/provider/optimal/silent | Initiate silent post with Optimal


<a name="silentpostusingpost"></a>
# **SilentPostUsingPOST**
> string SilentPostUsingPOST (OptimalPaymentRequest request = null)

Initiate silent post with Optimal

Will return the url for a hosted payment endpoint to post to. See Optimal documentation for details.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SilentPostUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsOptimalApi();
            var request = new OptimalPaymentRequest(); // OptimalPaymentRequest | The payment request to initiate (optional) 

            try
            {
                // Initiate silent post with Optimal
                string result = apiInstance.SilentPostUsingPOST(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsOptimalApi.SilentPostUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**OptimalPaymentRequest**](OptimalPaymentRequest.md)| The payment request to initiate | [optional] 

### Return type

**string**

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

