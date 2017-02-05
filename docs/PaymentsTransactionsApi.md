# IO.Swagger.Api.PaymentsTransactionsApi

All URIs are relative to *https://integration.knetikcloud.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetTransactionUsingGET**](PaymentsTransactionsApi.md#gettransactionusingget) | **GET** /transactions/{id} | Get the details for a single transaction
[**GetTransactionsUsingGET**](PaymentsTransactionsApi.md#gettransactionsusingget) | **GET** /transactions | List and search transactions
[**RefundTransactionUsingPOST**](PaymentsTransactionsApi.md#refundtransactionusingpost) | **POST** /transactions/{id}/refunds | Refund a payment transaction, in full or in part


<a name="gettransactionusingget"></a>
# **GetTransactionUsingGET**
> TransactionResource GetTransactionUsingGET (int? id)

Get the details for a single transaction

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTransactionUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsTransactionsApi();
            var id = 56;  // int? | id

            try
            {
                // Get the details for a single transaction
                TransactionResource result = apiInstance.GetTransactionUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsTransactionsApi.GetTransactionUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id | 

### Return type

[**TransactionResource**](TransactionResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransactionsusingget"></a>
# **GetTransactionsUsingGET**
> PageResourceTransactionResource GetTransactionsUsingGET (int? filterInvoice = null, int? size = null, int? page = null, string order = null)

List and search transactions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTransactionsUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsTransactionsApi();
            var filterInvoice = 56;  // int? | Filter for transactions from a specific invoice (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search transactions
                PageResourceTransactionResource result = apiInstance.GetTransactionsUsingGET(filterInvoice, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsTransactionsApi.GetTransactionsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterInvoice** | **int?**| Filter for transactions from a specific invoice | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourceTransactionResource**](PageResourceTransactionResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="refundtransactionusingpost"></a>
# **RefundTransactionUsingPOST**
> RefundResource RefundTransactionUsingPOST (int? id, RefundRequest request = null)

Refund a payment transaction, in full or in part

Will not allow for refunding more than the full amount even with multiple partial refunds. Money is refunded to the payment method used to make the original payment. Payment method must support refunds.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RefundTransactionUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsTransactionsApi();
            var id = 56;  // int? | The id of the transaction to refund
            var request = new RefundRequest(); // RefundRequest | Request containing refund details (optional) 

            try
            {
                // Refund a payment transaction, in full or in part
                RefundResource result = apiInstance.RefundTransactionUsingPOST(id, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsTransactionsApi.RefundTransactionUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the transaction to refund | 
 **request** | [**RefundRequest**](RefundRequest.md)| Request containing refund details | [optional] 

### Return type

[**RefundResource**](RefundResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

