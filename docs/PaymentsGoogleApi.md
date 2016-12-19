# IO.Swagger.Api.PaymentsGoogleApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HandlePaymentUsingPOST**](PaymentsGoogleApi.md#handlepaymentusingpost) | **POST** /payment/provider/google/payments | Mark an invoice paid with Google


<a name="handlepaymentusingpost"></a>
# **HandlePaymentUsingPOST**
> int? HandlePaymentUsingPOST (GooglePaymentRequest request = null)

Mark an invoice paid with Google

Mark an invoice paid with Google. Verifies signature from Google and treats the developerPayload field inside the json payload as the id of the invoice to pay. Returns the transaction ID if successful.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HandlePaymentUsingPOSTExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentsGoogleApi();
            var request = new GooglePaymentRequest(); // GooglePaymentRequest | The request for paying an invoice through a Google in-app payment (optional) 

            try
            {
                // Mark an invoice paid with Google
                int? result = apiInstance.HandlePaymentUsingPOST(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsGoogleApi.HandlePaymentUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**GooglePaymentRequest**](GooglePaymentRequest.md)| The request for paying an invoice through a Google in-app payment | [optional] 

### Return type

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
