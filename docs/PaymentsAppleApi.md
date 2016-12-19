# IO.Swagger.Api.PaymentsAppleApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**VerifyReceiptUsingPOST**](PaymentsAppleApi.md#verifyreceiptusingpost) | **POST** /payment/provider/apple/receipt | Pay invoice with Apple receipt


<a name="verifyreceiptusingpost"></a>
# **VerifyReceiptUsingPOST**
> string VerifyReceiptUsingPOST (ApplyPaymentRequest request = null)

Pay invoice with Apple receipt

Mark an invoice paid using Apple payment receipt. A receipt will only be accepted once and the details of the transaction must match the invoice, including the product_id matching the sku text of the item in the invoice. Returns the transaction ID if successful.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class VerifyReceiptUsingPOSTExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentsAppleApi();
            var request = new ApplyPaymentRequest(); // ApplyPaymentRequest | The request for paying an invoice through an Apple receipt (optional) 

            try
            {
                // Pay invoice with Apple receipt
                string result = apiInstance.VerifyReceiptUsingPOST(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsAppleApi.VerifyReceiptUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ApplyPaymentRequest**](ApplyPaymentRequest.md)| The request for paying an invoice through an Apple receipt | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

