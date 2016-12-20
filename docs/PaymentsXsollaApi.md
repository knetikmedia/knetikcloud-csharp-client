# IO.Swagger.Api.PaymentsXsollaApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTokenUrlUsingPOST**](PaymentsXsollaApi.md#createtokenurlusingpost) | **POST** /payment/provider/xsolla/payment | Create a payment token that should be used to forward the user to Xsolla so they can complete payment
[**ReceiveNotificationUsingPOST**](PaymentsXsollaApi.md#receivenotificationusingpost) | **POST** /payment/provider/xsolla/notifications | Receives payment response from Xsolla


<a name="createtokenurlusingpost"></a>
# **CreateTokenUrlUsingPOST**
> string CreateTokenUrlUsingPOST (XsollaPaymentRequest request = null)

Create a payment token that should be used to forward the user to Xsolla so they can complete payment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateTokenUrlUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsXsollaApi();
            var request = new XsollaPaymentRequest(); // XsollaPaymentRequest | The payment request to be sent to XSolla (optional) 

            try
            {
                // Create a payment token that should be used to forward the user to Xsolla so they can complete payment
                string result = apiInstance.CreateTokenUrlUsingPOST(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsXsollaApi.CreateTokenUrlUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**XsollaPaymentRequest**](XsollaPaymentRequest.md)| The payment request to be sent to XSolla | [optional] 

### Return type

**string**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="receivenotificationusingpost"></a>
# **ReceiveNotificationUsingPOST**
> void ReceiveNotificationUsingPOST ()

Receives payment response from Xsolla

Only used by XSolla to call back to JSAPI after processing user payment action

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReceiveNotificationUsingPOSTExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentsXsollaApi();

            try
            {
                // Receives payment response from Xsolla
                apiInstance.ReceiveNotificationUsingPOST();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsXsollaApi.ReceiveNotificationUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

