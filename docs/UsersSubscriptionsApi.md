# IO.Swagger.Api.UsersSubscriptionsApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSubscriptionDetailsUsingGET**](UsersSubscriptionsApi.md#getsubscriptiondetailsusingget) | **GET** /users/{user_id}/subscriptions/{inventory_id} | Get details about a user&#39;s subscription
[**GetSubscriptionDetailsUsingGET1**](UsersSubscriptionsApi.md#getsubscriptiondetailsusingget1) | **GET** /users/{user_id}/subscriptions | Get details about a user&#39;s subscriptions
[**ReactivateUsingPOST**](UsersSubscriptionsApi.md#reactivateusingpost) | **POST** /users/{user_id}/subscriptions/{inventory_id}/reactivate | Reactivate a subscription and charge fee
[**SetBillDateUsingPUT**](UsersSubscriptionsApi.md#setbilldateusingput) | **PUT** /users/{user_id}/subscriptions/{inventory_id}/bill-date | Set a new date to bill a subscription on
[**SetPaymentMethodUsingPUT**](UsersSubscriptionsApi.md#setpaymentmethodusingput) | **PUT** /users/{user_id}/subscriptions/{inventory_id}/payment-method | Set the payment method to use for a subscription
[**SetStatusUsingPUT**](UsersSubscriptionsApi.md#setstatususingput) | **PUT** /users/{user_id}/subscriptions/{inventory_id}/status | Set the status of a subscription
[**SetUserPlanUsingPUT**](UsersSubscriptionsApi.md#setuserplanusingput) | **PUT** /users/{user_id}/subscriptions/{inventory_id}/plan | Set a new subscription plan for a user


<a name="getsubscriptiondetailsusingget"></a>
# **GetSubscriptionDetailsUsingGET**
> InventorySubscriptionResource GetSubscriptionDetailsUsingGET (int? userId, int? inventoryId)

Get details about a user's subscription

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSubscriptionDetailsUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersSubscriptionsApi();
            var userId = 56;  // int? | The id of the user
            var inventoryId = 56;  // int? | The id of the user's inventory

            try
            {
                // Get details about a user's subscription
                InventorySubscriptionResource result = apiInstance.GetSubscriptionDetailsUsingGET(userId, inventoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersSubscriptionsApi.GetSubscriptionDetailsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The id of the user | 
 **inventoryId** | **int?**| The id of the user&#39;s inventory | 

### Return type

[**InventorySubscriptionResource**](InventorySubscriptionResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscriptiondetailsusingget1"></a>
# **GetSubscriptionDetailsUsingGET1**
> List<InventorySubscriptionResource> GetSubscriptionDetailsUsingGET1 (int? userId)

Get details about a user's subscriptions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSubscriptionDetailsUsingGET1Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersSubscriptionsApi();
            var userId = 56;  // int? | The id of the user

            try
            {
                // Get details about a user's subscriptions
                List&lt;InventorySubscriptionResource&gt; result = apiInstance.GetSubscriptionDetailsUsingGET1(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersSubscriptionsApi.GetSubscriptionDetailsUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The id of the user | 

### Return type

[**List<InventorySubscriptionResource>**](InventorySubscriptionResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reactivateusingpost"></a>
# **ReactivateUsingPOST**
> InvoiceResource ReactivateUsingPOST (int? userId, int? inventoryId, ReactivateSubscriptionRequest reactivateSubscriptionRequest = null)

Reactivate a subscription and charge fee

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReactivateUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersSubscriptionsApi();
            var userId = 56;  // int? | The id of the user
            var inventoryId = 56;  // int? | The id of the user's inventory
            var reactivateSubscriptionRequest = new ReactivateSubscriptionRequest(); // ReactivateSubscriptionRequest | The reactivate subscription request object inventory (optional) 

            try
            {
                // Reactivate a subscription and charge fee
                InvoiceResource result = apiInstance.ReactivateUsingPOST(userId, inventoryId, reactivateSubscriptionRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersSubscriptionsApi.ReactivateUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The id of the user | 
 **inventoryId** | **int?**| The id of the user&#39;s inventory | 
 **reactivateSubscriptionRequest** | [**ReactivateSubscriptionRequest**](ReactivateSubscriptionRequest.md)| The reactivate subscription request object inventory | [optional] 

### Return type

[**InvoiceResource**](InvoiceResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setbilldateusingput"></a>
# **SetBillDateUsingPUT**
> void SetBillDateUsingPUT (int? userId, int? inventoryId, long? billDate)

Set a new date to bill a subscription on

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetBillDateUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersSubscriptionsApi();
            var userId = 56;  // int? | The id of the user
            var inventoryId = 56;  // int? | The id of the user's inventory
            var billDate = 789;  // long? | The new bill date. Unix timestamp in seconds

            try
            {
                // Set a new date to bill a subscription on
                apiInstance.SetBillDateUsingPUT(userId, inventoryId, billDate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersSubscriptionsApi.SetBillDateUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The id of the user | 
 **inventoryId** | **int?**| The id of the user&#39;s inventory | 
 **billDate** | **long?**| The new bill date. Unix timestamp in seconds | 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setpaymentmethodusingput"></a>
# **SetPaymentMethodUsingPUT**
> void SetPaymentMethodUsingPUT (int? userId, int? inventoryId, int? paymentMethodId = null)

Set the payment method to use for a subscription

May send null to use floating default

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetPaymentMethodUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersSubscriptionsApi();
            var userId = 56;  // int? | The id of the user
            var inventoryId = 56;  // int? | The id of the user's inventory
            var paymentMethodId = 56;  // int? | The id of the payment method (optional) 

            try
            {
                // Set the payment method to use for a subscription
                apiInstance.SetPaymentMethodUsingPUT(userId, inventoryId, paymentMethodId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersSubscriptionsApi.SetPaymentMethodUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The id of the user | 
 **inventoryId** | **int?**| The id of the user&#39;s inventory | 
 **paymentMethodId** | **int?**| The id of the payment method | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setstatususingput"></a>
# **SetStatusUsingPUT**
> void SetStatusUsingPUT (int? userId, int? inventoryId, string status)

Set the status of a subscription

The body is a json string (put in quotes) that should match a desired invoice status type. Note that the new status may be blocked if the system is not configured to allow the current status to be changed to the new, to enforce proper flow. The default options for statuses are shown below but may be altered for special use cases

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetStatusUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersSubscriptionsApi();
            var userId = 56;  // int? | The id of the user
            var inventoryId = 56;  // int? | The id of the user's inventory
            var status = status_example;  // string | The new status for the subscription. Actual options may differ from the indicated set if the invoice status type data has been altered.  Allowable values: ('current', 'canceled', 'stopped', 'payment_failed', 'suspended')

            try
            {
                // Set the status of a subscription
                apiInstance.SetStatusUsingPUT(userId, inventoryId, status);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersSubscriptionsApi.SetStatusUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The id of the user | 
 **inventoryId** | **int?**| The id of the user&#39;s inventory | 
 **status** | **string**| The new status for the subscription. Actual options may differ from the indicated set if the invoice status type data has been altered.  Allowable values: (&#39;current&#39;, &#39;canceled&#39;, &#39;stopped&#39;, &#39;payment_failed&#39;, &#39;suspended&#39;) | 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setuserplanusingput"></a>
# **SetUserPlanUsingPUT**
> void SetUserPlanUsingPUT (int? userId, int? inventoryId, string planId = null)

Set a new subscription plan for a user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetUserPlanUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersSubscriptionsApi();
            var userId = 56;  // int? | The id of the user
            var inventoryId = 56;  // int? | The id of the user's inventory
            var planId = planId_example;  // string | The id of the new plan. Must be from the same subscription (optional) 

            try
            {
                // Set a new subscription plan for a user
                apiInstance.SetUserPlanUsingPUT(userId, inventoryId, planId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersSubscriptionsApi.SetUserPlanUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The id of the user | 
 **inventoryId** | **int?**| The id of the user&#39;s inventory | 
 **planId** | **string**| The id of the new plan. Must be from the same subscription | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

