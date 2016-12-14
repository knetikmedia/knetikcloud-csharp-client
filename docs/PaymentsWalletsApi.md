# IO.Swagger.Api.PaymentsWalletsApi

All URIs are relative to *https://devsandbox.knetikcloud.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetWalletTotalsUsingGET**](PaymentsWalletsApi.md#getwallettotalsusingget) | **GET** /wallets/totals | Retrieves a summation of wallet balances by currency code
[**GetWalletUsingGET**](PaymentsWalletsApi.md#getwalletusingget) | **GET** /users/{user_id}/wallets/{currency_code} | Returns the user&#39;s wallet for the given currency code
[**GetWalletsUsingGET**](PaymentsWalletsApi.md#getwalletsusingget) | **GET** /users/{user_id}/wallets | List all of a user&#39;s wallets
[**GetWalletsUsingGET1**](PaymentsWalletsApi.md#getwalletsusingget1) | **GET** /wallets | Retrieve a list of wallets across the system
[**TransactionHistoryUsingGET**](PaymentsWalletsApi.md#transactionhistoryusingget) | **GET** /wallets/transactions | Retrieve wallet transactions across the system
[**UpdateBalanceUsingPUT**](PaymentsWalletsApi.md#updatebalanceusingput) | **PUT** /users/{user_id}/wallets/{currency_code}/balance | Updates the balance for a user&#39;s wallet
[**UserTransactionHistoryUsingGET**](PaymentsWalletsApi.md#usertransactionhistoryusingget) | **GET** /users/{user_id}/wallets/{currency_code}/transactions | Retrieve a user&#39;s wallet transactions


<a name="getwallettotalsusingget"></a>
# **GetWalletTotalsUsingGET**
> PageWalletTotalResponse GetWalletTotalsUsingGET ()

Retrieves a summation of wallet balances by currency code

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetWalletTotalsUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentsWalletsApi();

            try
            {
                // Retrieves a summation of wallet balances by currency code
                PageWalletTotalResponse result = apiInstance.GetWalletTotalsUsingGET();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsWalletsApi.GetWalletTotalsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PageWalletTotalResponse**](PageWalletTotalResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwalletusingget"></a>
# **GetWalletUsingGET**
> SimpleWallet GetWalletUsingGET (int? userId, string currencyCode)

Returns the user's wallet for the given currency code

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetWalletUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentsWalletsApi();
            var userId = 56;  // int? | The ID of the user for whom wallet is being retrieved
            var currencyCode = currencyCode_example;  // string | Currency code of the user's wallet

            try
            {
                // Returns the user's wallet for the given currency code
                SimpleWallet result = apiInstance.GetWalletUsingGET(userId, currencyCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsWalletsApi.GetWalletUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The ID of the user for whom wallet is being retrieved | 
 **currencyCode** | **string**| Currency code of the user&#39;s wallet | 

### Return type

[**SimpleWallet**](SimpleWallet.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwalletsusingget"></a>
# **GetWalletsUsingGET**
> List<SimpleWallet> GetWalletsUsingGET (int? userId)

List all of a user's wallets

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetWalletsUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentsWalletsApi();
            var userId = 56;  // int? | The ID of the user for whom wallets are being retrieved

            try
            {
                // List all of a user's wallets
                List&lt;SimpleWallet&gt; result = apiInstance.GetWalletsUsingGET(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsWalletsApi.GetWalletsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The ID of the user for whom wallets are being retrieved | 

### Return type

[**List<SimpleWallet>**](SimpleWallet.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwalletsusingget1"></a>
# **GetWalletsUsingGET1**
> PageSimpleWallet GetWalletsUsingGET1 (int? size = null, int? page = null, string order = null)

Retrieve a list of wallets across the system

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetWalletsUsingGET1Example
    {
        public void main()
        {
            
            var apiInstance = new PaymentsWalletsApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | a comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to 1)

            try
            {
                // Retrieve a list of wallets across the system
                PageSimpleWallet result = apiInstance.GetWalletsUsingGET1(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsWalletsApi.GetWalletsUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| a comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to 1]

### Return type

[**PageSimpleWallet**](PageSimpleWallet.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transactionhistoryusingget"></a>
# **TransactionHistoryUsingGET**
> PageWalletTransactionResource TransactionHistoryUsingGET (int? filterInvoice = null, string filterType = null, long? filterMaxDate = null, long? filterMinDate = null, string filterSign = null, int? filterUserId = null, string filterUsername = null, string filterDetails = null, string filterCurrencyCode = null, int? size = null, int? page = null, string order = null)

Retrieve wallet transactions across the system

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TransactionHistoryUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentsWalletsApi();
            var filterInvoice = 56;  // int? | Filter for transactions from a specific invoice (optional) 
            var filterType = filterType_example;  // string | Filter for transactions with specified type (optional) 
            var filterMaxDate = 789;  // long? | Filter for transactions from no earlier than the specified date as a unix timestamp in seconds (optional) 
            var filterMinDate = 789;  // long? | Filter for transactions from no later than the specified date as a unix timestamp in seconds (optional) 
            var filterSign = filterSign_example;  // string | Filter for transactions with amount with the given sign (optional) 
            var filterUserId = 56;  // int? | Filter for transactions for specific userId (optional) 
            var filterUsername = filterUsername_example;  // string | Filter for transactions for specific username that start with the given string (optional) 
            var filterDetails = filterDetails_example;  // string | Filter for transactions for specific details that start with the given string (optional) 
            var filterCurrencyCode = filterCurrencyCode_example;  // string | Filter for transactions for specific currency code (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to 1)

            try
            {
                // Retrieve wallet transactions across the system
                PageWalletTransactionResource result = apiInstance.TransactionHistoryUsingGET(filterInvoice, filterType, filterMaxDate, filterMinDate, filterSign, filterUserId, filterUsername, filterDetails, filterCurrencyCode, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsWalletsApi.TransactionHistoryUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterInvoice** | **int?**| Filter for transactions from a specific invoice | [optional] 
 **filterType** | **string**| Filter for transactions with specified type | [optional] 
 **filterMaxDate** | **long?**| Filter for transactions from no earlier than the specified date as a unix timestamp in seconds | [optional] 
 **filterMinDate** | **long?**| Filter for transactions from no later than the specified date as a unix timestamp in seconds | [optional] 
 **filterSign** | **string**| Filter for transactions with amount with the given sign | [optional] 
 **filterUserId** | **int?**| Filter for transactions for specific userId | [optional] 
 **filterUsername** | **string**| Filter for transactions for specific username that start with the given string | [optional] 
 **filterDetails** | **string**| Filter for transactions for specific details that start with the given string | [optional] 
 **filterCurrencyCode** | **string**| Filter for transactions for specific currency code | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to 1]

### Return type

[**PageWalletTransactionResource**](PageWalletTransactionResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebalanceusingput"></a>
# **UpdateBalanceUsingPUT**
> WalletTransactionResource UpdateBalanceUsingPUT (int? userId, string currencyCode, WalletAlterRequest request = null)

Updates the balance for a user's wallet

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateBalanceUsingPUTExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentsWalletsApi();
            var userId = 56;  // int? | The ID of the user for whom wallet is being modified
            var currencyCode = currencyCode_example;  // string | Currency code of the user's wallet
            var request = new WalletAlterRequest(); // WalletAlterRequest | The requested balance modification to be made to the user's wallet (optional) 

            try
            {
                // Updates the balance for a user's wallet
                WalletTransactionResource result = apiInstance.UpdateBalanceUsingPUT(userId, currencyCode, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsWalletsApi.UpdateBalanceUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The ID of the user for whom wallet is being modified | 
 **currencyCode** | **string**| Currency code of the user&#39;s wallet | 
 **request** | [**WalletAlterRequest**](WalletAlterRequest.md)| The requested balance modification to be made to the user&#39;s wallet | [optional] 

### Return type

[**WalletTransactionResource**](WalletTransactionResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usertransactionhistoryusingget"></a>
# **UserTransactionHistoryUsingGET**
> PageWalletTransactionResource UserTransactionHistoryUsingGET (int? userId, string currencyCode, string filterType = null, long? filterMaxDate = null, long? filterMinDate = null, string filterSign = null, int? size = null, int? page = null, string order = null)

Retrieve a user's wallet transactions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserTransactionHistoryUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentsWalletsApi();
            var userId = 56;  // int? | The ID of the user for whom wallet transactions are being retrieved
            var currencyCode = currencyCode_example;  // string | Currency code of the user's wallet
            var filterType = filterType_example;  // string | Filter for transactions with specified type (optional) 
            var filterMaxDate = 789;  // long? | Filter for transactions from no earlier than the specified date as a unix timestamp in seconds (optional) 
            var filterMinDate = 789;  // long? | Filter for transactions from no later than the specified date as a unix timestamp in seconds (optional) 
            var filterSign = filterSign_example;  // string | Filter for transactions with amount with the given sign.  Allowable values: ('positive', 'negative') (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to 1)

            try
            {
                // Retrieve a user's wallet transactions
                PageWalletTransactionResource result = apiInstance.UserTransactionHistoryUsingGET(userId, currencyCode, filterType, filterMaxDate, filterMinDate, filterSign, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsWalletsApi.UserTransactionHistoryUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The ID of the user for whom wallet transactions are being retrieved | 
 **currencyCode** | **string**| Currency code of the user&#39;s wallet | 
 **filterType** | **string**| Filter for transactions with specified type | [optional] 
 **filterMaxDate** | **long?**| Filter for transactions from no earlier than the specified date as a unix timestamp in seconds | [optional] 
 **filterMinDate** | **long?**| Filter for transactions from no later than the specified date as a unix timestamp in seconds | [optional] 
 **filterSign** | **string**| Filter for transactions with amount with the given sign.  Allowable values: (&#39;positive&#39;, &#39;negative&#39;) | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to 1]

### Return type

[**PageWalletTransactionResource**](PageWalletTransactionResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

