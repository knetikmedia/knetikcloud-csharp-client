# IO.Swagger.Api.PaymentsApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePaymentMethodUsingPOST**](PaymentsApi.md#createpaymentmethodusingpost) | **POST** /users/{user_id}/payment-methods | Create a new payment method for a user
[**DeletePaymentMethodUsingDELETE**](PaymentsApi.md#deletepaymentmethodusingdelete) | **DELETE** /users/{user_id}/payment-methods/{id} | Delete an existing payment method for a user
[**GetPaymentMethodUsingGET**](PaymentsApi.md#getpaymentmethodusingget) | **GET** /users/{user_id}/payment-methods/{id} | Get a single payment method for a user
[**GetPaymentMethodsUsingGET**](PaymentsApi.md#getpaymentmethodsusingget) | **GET** /users/{user_id}/payment-methods | Get all payment methods for a user
[**PaymentAuthorizationUsingPOST**](PaymentsApi.md#paymentauthorizationusingpost) | **POST** /payment/authorizations | Authorize payment of an invoice for later capture
[**PaymentCaptureUsingPOST**](PaymentsApi.md#paymentcaptureusingpost) | **POST** /payment/authorizations/{id}/capture | Capture an existing invoice payment authorization
[**UpdatePaymentMethodUsingPUT**](PaymentsApi.md#updatepaymentmethodusingput) | **PUT** /users/{user_id}/payment-methods/{id} | Update an existing payment method for a user


<a name="createpaymentmethodusingpost"></a>
# **CreatePaymentMethodUsingPOST**
> PaymentMethodResource CreatePaymentMethodUsingPOST (int? userId, PaymentMethodResource paymentMethod = null)

Create a new payment method for a user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreatePaymentMethodUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsApi();
            var userId = 56;  // int? | ID of the user for whom the payment method is being created
            var paymentMethod = new PaymentMethodResource(); // PaymentMethodResource | Payment method being created (optional) 

            try
            {
                // Create a new payment method for a user
                PaymentMethodResource result = apiInstance.CreatePaymentMethodUsingPOST(userId, paymentMethod);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.CreatePaymentMethodUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| ID of the user for whom the payment method is being created | 
 **paymentMethod** | [**PaymentMethodResource**](PaymentMethodResource.md)| Payment method being created | [optional] 

### Return type

[**PaymentMethodResource**](PaymentMethodResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepaymentmethodusingdelete"></a>
# **DeletePaymentMethodUsingDELETE**
> void DeletePaymentMethodUsingDELETE (int? userId, int? id)

Delete an existing payment method for a user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeletePaymentMethodUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsApi();
            var userId = 56;  // int? | ID of the user for whom the payment method is being updated
            var id = 56;  // int? | ID of the payment method being deleted

            try
            {
                // Delete an existing payment method for a user
                apiInstance.DeletePaymentMethodUsingDELETE(userId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.DeletePaymentMethodUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| ID of the user for whom the payment method is being updated | 
 **id** | **int?**| ID of the payment method being deleted | 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpaymentmethodusingget"></a>
# **GetPaymentMethodUsingGET**
> PaymentMethodResource GetPaymentMethodUsingGET (int? userId, int? id)

Get a single payment method for a user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPaymentMethodUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsApi();
            var userId = 56;  // int? | ID of the user for whom the payment method is being retrieved
            var id = 56;  // int? | ID of the payment method being retrieved

            try
            {
                // Get a single payment method for a user
                PaymentMethodResource result = apiInstance.GetPaymentMethodUsingGET(userId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.GetPaymentMethodUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| ID of the user for whom the payment method is being retrieved | 
 **id** | **int?**| ID of the payment method being retrieved | 

### Return type

[**PaymentMethodResource**](PaymentMethodResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpaymentmethodsusingget"></a>
# **GetPaymentMethodsUsingGET**
> List<PaymentMethodResource> GetPaymentMethodsUsingGET (int? userId, int? size = null, int? page = null, string order = null)

Get all payment methods for a user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPaymentMethodsUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsApi();
            var userId = 56;  // int? | ID of the user for whom the payment methods are being retrieved
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | a comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // Get all payment methods for a user
                List&lt;PaymentMethodResource&gt; result = apiInstance.GetPaymentMethodsUsingGET(userId, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.GetPaymentMethodsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| ID of the user for whom the payment methods are being retrieved | 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| a comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**List<PaymentMethodResource>**](PaymentMethodResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="paymentauthorizationusingpost"></a>
# **PaymentAuthorizationUsingPOST**
> PaymentAuthorizationResource PaymentAuthorizationUsingPOST (PaymentAuthorizationResource request = null)

Authorize payment of an invoice for later capture

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PaymentAuthorizationUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsApi();
            var request = new PaymentAuthorizationResource(); // PaymentAuthorizationResource | Payment authorization request (optional) 

            try
            {
                // Authorize payment of an invoice for later capture
                PaymentAuthorizationResource result = apiInstance.PaymentAuthorizationUsingPOST(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.PaymentAuthorizationUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**PaymentAuthorizationResource**](PaymentAuthorizationResource.md)| Payment authorization request | [optional] 

### Return type

[**PaymentAuthorizationResource**](PaymentAuthorizationResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="paymentcaptureusingpost"></a>
# **PaymentCaptureUsingPOST**
> void PaymentCaptureUsingPOST (int? id)

Capture an existing invoice payment authorization

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PaymentCaptureUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsApi();
            var id = 56;  // int? | ID of the payment authorization to capture

            try
            {
                // Capture an existing invoice payment authorization
                apiInstance.PaymentCaptureUsingPOST(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.PaymentCaptureUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of the payment authorization to capture | 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepaymentmethodusingput"></a>
# **UpdatePaymentMethodUsingPUT**
> void UpdatePaymentMethodUsingPUT (int? userId, int? id, PaymentMethodResource paymentMethod = null)

Update an existing payment method for a user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdatePaymentMethodUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsApi();
            var userId = 56;  // int? | ID of the user for whom the payment method is being updated
            var id = 56;  // int? | ID of the payment method being updated
            var paymentMethod = new PaymentMethodResource(); // PaymentMethodResource | The updated payment method data (optional) 

            try
            {
                // Update an existing payment method for a user
                apiInstance.UpdatePaymentMethodUsingPUT(userId, id, paymentMethod);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.UpdatePaymentMethodUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| ID of the user for whom the payment method is being updated | 
 **id** | **int?**| ID of the payment method being updated | 
 **paymentMethod** | [**PaymentMethodResource**](PaymentMethodResource.md)| The updated payment method data | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

