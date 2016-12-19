# IO.Swagger.Api.CurrenciesApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCurrencyUsingPOST**](CurrenciesApi.md#createcurrencyusingpost) | **POST** /currencies | Create a currency
[**DeleteCurrencyUsingDELETE**](CurrenciesApi.md#deletecurrencyusingdelete) | **DELETE** /currencies/{code} | Delete a currency
[**GetCurrenciesUsingGET**](CurrenciesApi.md#getcurrenciesusingget) | **GET** /currencies | List and search currencies
[**GetCurrencyUsingGET**](CurrenciesApi.md#getcurrencyusingget) | **GET** /currencies/{code} | Get a single currency
[**UpdateCurrencyUsingPUT**](CurrenciesApi.md#updatecurrencyusingput) | **PUT** /currencies/{code} | Update a currency


<a name="createcurrencyusingpost"></a>
# **CreateCurrencyUsingPOST**
> CurrencyResource CreateCurrencyUsingPOST (CurrencyResource currency = null)

Create a currency

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateCurrencyUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CurrenciesApi();
            var currency = new CurrencyResource(); // CurrencyResource | The currency object (optional) 

            try
            {
                // Create a currency
                CurrencyResource result = apiInstance.CreateCurrencyUsingPOST(currency);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CurrenciesApi.CreateCurrencyUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | [**CurrencyResource**](CurrencyResource.md)| The currency object | [optional] 

### Return type

[**CurrencyResource**](CurrencyResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecurrencyusingdelete"></a>
# **DeleteCurrencyUsingDELETE**
> void DeleteCurrencyUsingDELETE (string code)

Delete a currency

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteCurrencyUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CurrenciesApi();
            var code = code_example;  // string | The currency code

            try
            {
                // Delete a currency
                apiInstance.DeleteCurrencyUsingDELETE(code);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CurrenciesApi.DeleteCurrencyUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**| The currency code | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcurrenciesusingget"></a>
# **GetCurrenciesUsingGET**
> PageCurrencyResource GetCurrenciesUsingGET (bool? filterEnabledCurrencies = null, string filterType = null, int? size = null, int? page = null, string order = null)

List and search currencies

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCurrenciesUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new CurrenciesApi();
            var filterEnabledCurrencies = true;  // bool? | Filter for alternate currencies setup explicitely in system config (optional) 
            var filterType = filterType_example;  // string | Filter currencies by type.  Allowable values: ('virtual', 'real') (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to 1)

            try
            {
                // List and search currencies
                PageCurrencyResource result = apiInstance.GetCurrenciesUsingGET(filterEnabledCurrencies, filterType, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CurrenciesApi.GetCurrenciesUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterEnabledCurrencies** | **bool?**| Filter for alternate currencies setup explicitely in system config | [optional] 
 **filterType** | **string**| Filter currencies by type.  Allowable values: (&#39;virtual&#39;, &#39;real&#39;) | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to 1]

### Return type

[**PageCurrencyResource**](PageCurrencyResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcurrencyusingget"></a>
# **GetCurrencyUsingGET**
> CurrencyResource GetCurrencyUsingGET (string code)

Get a single currency

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCurrencyUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new CurrenciesApi();
            var code = code_example;  // string | The currency code

            try
            {
                // Get a single currency
                CurrencyResource result = apiInstance.GetCurrencyUsingGET(code);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CurrenciesApi.GetCurrencyUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**| The currency code | 

### Return type

[**CurrencyResource**](CurrencyResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecurrencyusingput"></a>
# **UpdateCurrencyUsingPUT**
> void UpdateCurrencyUsingPUT (string code, CurrencyResource currency = null)

Update a currency

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateCurrencyUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CurrenciesApi();
            var code = code_example;  // string | The currency code
            var currency = new CurrencyResource(); // CurrencyResource | The currency object (optional) 

            try
            {
                // Update a currency
                apiInstance.UpdateCurrencyUsingPUT(code, currency);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CurrenciesApi.UpdateCurrencyUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**| The currency code | 
 **currency** | [**CurrencyResource**](CurrencyResource.md)| The currency object | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

