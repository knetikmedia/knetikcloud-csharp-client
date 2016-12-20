# IO.Swagger.Api.PaymentsStripeApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCustomerUsingPOST1**](PaymentsStripeApi.md#createcustomerusingpost1) | **POST** /payment/provider/stripe/payment-methods | Create a Stripe payment method for a user
[**PayInvoiceUsingPOST1**](PaymentsStripeApi.md#payinvoiceusingpost1) | **POST** /payment/provider/stripe/payments | Pay with a single use token


<a name="createcustomerusingpost1"></a>
# **CreateCustomerUsingPOST1**
> PaymentMethodResource CreateCustomerUsingPOST1 (StripeCreatePaymentMethod request = null)

Create a Stripe payment method for a user

Stores customer information and creates a payment method that can be used to pay invoices through the payments endpoints.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateCustomerUsingPOST1Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsStripeApi();
            var request = new StripeCreatePaymentMethod(); // StripeCreatePaymentMethod | The request to create a Stripe customer with payment info (optional) 

            try
            {
                // Create a Stripe payment method for a user
                PaymentMethodResource result = apiInstance.CreateCustomerUsingPOST1(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsStripeApi.CreateCustomerUsingPOST1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**StripeCreatePaymentMethod**](StripeCreatePaymentMethod.md)| The request to create a Stripe customer with payment info | [optional] 

### Return type

[**PaymentMethodResource**](PaymentMethodResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="payinvoiceusingpost1"></a>
# **PayInvoiceUsingPOST1**
> void PayInvoiceUsingPOST1 (StripePaymentRequest request = null)

Pay with a single use token

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PayInvoiceUsingPOST1Example
    {
        public void main()
        {
            
            var apiInstance = new PaymentsStripeApi();
            var request = new StripePaymentRequest(); // StripePaymentRequest | The request to pay an invoice (optional) 

            try
            {
                // Pay with a single use token
                apiInstance.PayInvoiceUsingPOST1(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsStripeApi.PayInvoiceUsingPOST1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**StripePaymentRequest**](StripePaymentRequest.md)| The request to pay an invoice | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

