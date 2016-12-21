# IO.Swagger.Api.StoreShoppingCartsApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddDiscountUsingPOST**](StoreShoppingCartsApi.md#adddiscountusingpost) | **POST** /carts/{id}/discounts | Adds a coupon to the cart
[**AddItemUsingPOST**](StoreShoppingCartsApi.md#additemusingpost) | **POST** /carts/{id}/items | Add an item to the cart
[**AssignCartUsingPUT**](StoreShoppingCartsApi.md#assigncartusingput) | **PUT** /carts/{id}/owner | Sets the owner of a cart if none is set already
[**CheckShippableUsingGET**](StoreShoppingCartsApi.md#checkshippableusingget) | **GET** /carts/{id}/shippable | Returns whether a cart requires shipping
[**CreateCartUsingPOST**](StoreShoppingCartsApi.md#createcartusingpost) | **POST** /carts | Creates a new cart from scratch
[**GetCartUsingGET**](StoreShoppingCartsApi.md#getcartusingget) | **GET** /carts/{id} | Returns the cart with the given GUID
[**GetCountriesUsingGET**](StoreShoppingCartsApi.md#getcountriesusingget) | **GET** /carts/{id}/countries | Get the list of available shipping countries per vendor
[**ModifyShippingAddressUsingPUT**](StoreShoppingCartsApi.md#modifyshippingaddressusingput) | **PUT** /carts/{id}/shipping-address | Modifies or sets the order shipping address
[**RemoveDiscountUsingDELETE**](StoreShoppingCartsApi.md#removediscountusingdelete) | **DELETE** /carts/{id}/discounts/{code} | Removes a coupon from the cart
[**SearchCartsUsingGET**](StoreShoppingCartsApi.md#searchcartsusingget) | **GET** /carts | Get a list of carts
[**SetCartCurrencyUsingPUT**](StoreShoppingCartsApi.md#setcartcurrencyusingput) | **PUT** /carts/{id}/currency | Sets the currency to use for the cart
[**UpdateItemUsingPUT**](StoreShoppingCartsApi.md#updateitemusingput) | **PUT** /carts/{id}/items | Changes the quantity of an item already in the cart


<a name="adddiscountusingpost"></a>
# **AddDiscountUsingPOST**
> void AddDiscountUsingPOST (string id, SkuRequest skuRequest = null)

Adds a coupon to the cart

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddDiscountUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreShoppingCartsApi();
            var id = id_example;  // string | The id of the cart
            var skuRequest = new SkuRequest(); // SkuRequest | The request of the sku (optional) 

            try
            {
                // Adds a coupon to the cart
                apiInstance.AddDiscountUsingPOST(id, skuRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreShoppingCartsApi.AddDiscountUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the cart | 
 **skuRequest** | [**SkuRequest**](SkuRequest.md)| The request of the sku | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemusingpost"></a>
# **AddItemUsingPOST**
> void AddItemUsingPOST (string id, CartItemRequest cartItemRequest = null)

Add an item to the cart

Currently, carts cannot contain virtual and real currency items at the same time. Furthermore, the API only support a single virtual item at the moment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddItemUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreShoppingCartsApi();
            var id = id_example;  // string | The id of the cart
            var cartItemRequest = new CartItemRequest(); // CartItemRequest | The cart item request object (optional) 

            try
            {
                // Add an item to the cart
                apiInstance.AddItemUsingPOST(id, cartItemRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreShoppingCartsApi.AddItemUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the cart | 
 **cartItemRequest** | [**CartItemRequest**](CartItemRequest.md)| The cart item request object | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assigncartusingput"></a>
# **AssignCartUsingPUT**
> void AssignCartUsingPUT (string id, int? userId = null)

Sets the owner of a cart if none is set already

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AssignCartUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreShoppingCartsApi();
            var id = id_example;  // string | The id of the cart
            var userId = 56;  // int? | The id of the user (optional) 

            try
            {
                // Sets the owner of a cart if none is set already
                apiInstance.AssignCartUsingPUT(id, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreShoppingCartsApi.AssignCartUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the cart | 
 **userId** | **int?**| The id of the user | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkshippableusingget"></a>
# **CheckShippableUsingGET**
> CartShippableResponse CheckShippableUsingGET (string id)

Returns whether a cart requires shipping

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CheckShippableUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreShoppingCartsApi();
            var id = id_example;  // string | The id of the cart

            try
            {
                // Returns whether a cart requires shipping
                CartShippableResponse result = apiInstance.CheckShippableUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreShoppingCartsApi.CheckShippableUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the cart | 

### Return type

[**CartShippableResponse**](CartShippableResponse.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcartusingpost"></a>
# **CreateCartUsingPOST**
> string CreateCartUsingPOST (int? owner = null, string currencyCode = null)

Creates a new cart from scratch

You don't have to have a user to create a cart but the API requires authentication to checkout

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateCartUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreShoppingCartsApi();
            var owner = 56;  // int? | Set the owner of a cart. If not specified, defaults to the calling user's id. If specified and is not the calling user's id, SHOPPING_CARTS_ADMIN permission is required (optional) 
            var currencyCode = currencyCode_example;  // string | Set the currency for the cart, by currency code. May be disallowed by site settings. (optional) 

            try
            {
                // Creates a new cart from scratch
                string result = apiInstance.CreateCartUsingPOST(owner, currencyCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreShoppingCartsApi.CreateCartUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **int?**| Set the owner of a cart. If not specified, defaults to the calling user&#39;s id. If specified and is not the calling user&#39;s id, SHOPPING_CARTS_ADMIN permission is required | [optional] 
 **currencyCode** | **string**| Set the currency for the cart, by currency code. May be disallowed by site settings. | [optional] 

### Return type

**string**

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcartusingget"></a>
# **GetCartUsingGET**
> Cart GetCartUsingGET (string id)

Returns the cart with the given GUID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCartUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreShoppingCartsApi();
            var id = id_example;  // string | The id of the cart

            try
            {
                // Returns the cart with the given GUID
                Cart result = apiInstance.GetCartUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreShoppingCartsApi.GetCartUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the cart | 

### Return type

[**Cart**](Cart.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcountriesusingget"></a>
# **GetCountriesUsingGET**
> SampleCountriesResponse GetCountriesUsingGET (string id)

Get the list of available shipping countries per vendor

Since a cart can have multiple vendors with different shipping options, the countries are broken down by vendors. Please see notes about the response object as the fields are variable.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCountriesUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreShoppingCartsApi();
            var id = id_example;  // string | The id of the cart

            try
            {
                // Get the list of available shipping countries per vendor
                SampleCountriesResponse result = apiInstance.GetCountriesUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreShoppingCartsApi.GetCountriesUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the cart | 

### Return type

[**SampleCountriesResponse**](SampleCountriesResponse.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="modifyshippingaddressusingput"></a>
# **ModifyShippingAddressUsingPUT**
> void ModifyShippingAddressUsingPUT (string id, CartShippingAddressRequest cartShippingAddressRequest = null)

Modifies or sets the order shipping address

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ModifyShippingAddressUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreShoppingCartsApi();
            var id = id_example;  // string | The id of the cart
            var cartShippingAddressRequest = new CartShippingAddressRequest(); // CartShippingAddressRequest | The cart shipping address request object (optional) 

            try
            {
                // Modifies or sets the order shipping address
                apiInstance.ModifyShippingAddressUsingPUT(id, cartShippingAddressRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreShoppingCartsApi.ModifyShippingAddressUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the cart | 
 **cartShippingAddressRequest** | [**CartShippingAddressRequest**](CartShippingAddressRequest.md)| The cart shipping address request object | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removediscountusingdelete"></a>
# **RemoveDiscountUsingDELETE**
> void RemoveDiscountUsingDELETE (string id, string code)

Removes a coupon from the cart

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemoveDiscountUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreShoppingCartsApi();
            var id = id_example;  // string | The id of the cart
            var code = code_example;  // string | The SKU code of the coupon to remove

            try
            {
                // Removes a coupon from the cart
                apiInstance.RemoveDiscountUsingDELETE(id, code);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreShoppingCartsApi.RemoveDiscountUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the cart | 
 **code** | **string**| The SKU code of the coupon to remove | 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchcartsusingget"></a>
# **SearchCartsUsingGET**
> PageResourceCartSummary SearchCartsUsingGET (int? filterOwnerId = null, int? size = null, int? page = null, string order = null)

Get a list of carts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchCartsUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreShoppingCartsApi();
            var filterOwnerId = 56;  // int? | Filter by the id of the owner (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // Get a list of carts
                PageResourceCartSummary result = apiInstance.SearchCartsUsingGET(filterOwnerId, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreShoppingCartsApi.SearchCartsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterOwnerId** | **int?**| Filter by the id of the owner | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourceCartSummary**](PageResourceCartSummary.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setcartcurrencyusingput"></a>
# **SetCartCurrencyUsingPUT**
> void SetCartCurrencyUsingPUT (string id, string currencyCode = null)

Sets the currency to use for the cart

May be disallowed by site settings.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetCartCurrencyUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreShoppingCartsApi();
            var id = id_example;  // string | The id of the cart
            var currencyCode = currencyCode_example;  // string | The code of the currency (optional) 

            try
            {
                // Sets the currency to use for the cart
                apiInstance.SetCartCurrencyUsingPUT(id, currencyCode);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreShoppingCartsApi.SetCartCurrencyUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the cart | 
 **currencyCode** | **string**| The code of the currency | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateitemusingput"></a>
# **UpdateItemUsingPUT**
> void UpdateItemUsingPUT (string id, CartItemRequest cartItemRequest = null)

Changes the quantity of an item already in the cart

A quantity of zero will remove the item from the cart altogether.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateItemUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreShoppingCartsApi();
            var id = id_example;  // string | The id of the cart
            var cartItemRequest = new CartItemRequest(); // CartItemRequest | The cart item request object (optional) 

            try
            {
                // Changes the quantity of an item already in the cart
                apiInstance.UpdateItemUsingPUT(id, cartItemRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreShoppingCartsApi.UpdateItemUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the cart | 
 **cartItemRequest** | [**CartItemRequest**](CartItemRequest.md)| The cart item request object | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

