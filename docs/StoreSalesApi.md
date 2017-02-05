# IO.Swagger.Api.StoreSalesApi

All URIs are relative to *https://integration.knetikcloud.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCatalogSaleUsingPOST**](StoreSalesApi.md#createcatalogsaleusingpost) | **POST** /store/sales | Create a sale
[**DeleteCatalogSaleUsingDELETE**](StoreSalesApi.md#deletecatalogsaleusingdelete) | **DELETE** /store/sales/{id} | Delete a sale
[**GetCatalogSaleUsingGET**](StoreSalesApi.md#getcatalogsaleusingget) | **GET** /store/sales/{id} | Get a single sale
[**GetCatalogSalesUsingGET**](StoreSalesApi.md#getcatalogsalesusingget) | **GET** /store/sales | List and search sales
[**UpdateCatalogSaleUsingPUT**](StoreSalesApi.md#updatecatalogsaleusingput) | **PUT** /store/sales/{id} | Update a sale


<a name="createcatalogsaleusingpost"></a>
# **CreateCatalogSaleUsingPOST**
> CatalogSale CreateCatalogSaleUsingPOST (CatalogSale catalogSale = null)

Create a sale

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateCatalogSaleUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreSalesApi();
            var catalogSale = new CatalogSale(); // CatalogSale | The catalog sale object (optional) 

            try
            {
                // Create a sale
                CatalogSale result = apiInstance.CreateCatalogSaleUsingPOST(catalogSale);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreSalesApi.CreateCatalogSaleUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **catalogSale** | [**CatalogSale**](CatalogSale.md)| The catalog sale object | [optional] 

### Return type

[**CatalogSale**](CatalogSale.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecatalogsaleusingdelete"></a>
# **DeleteCatalogSaleUsingDELETE**
> void DeleteCatalogSaleUsingDELETE (int? id)

Delete a sale

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteCatalogSaleUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreSalesApi();
            var id = 56;  // int? | The id of the sale

            try
            {
                // Delete a sale
                apiInstance.DeleteCatalogSaleUsingDELETE(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreSalesApi.DeleteCatalogSaleUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the sale | 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcatalogsaleusingget"></a>
# **GetCatalogSaleUsingGET**
> CatalogSale GetCatalogSaleUsingGET (int? id)

Get a single sale

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCatalogSaleUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreSalesApi();
            var id = 56;  // int? | The id of the sale

            try
            {
                // Get a single sale
                CatalogSale result = apiInstance.GetCatalogSaleUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreSalesApi.GetCatalogSaleUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the sale | 

### Return type

[**CatalogSale**](CatalogSale.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcatalogsalesusingget"></a>
# **GetCatalogSalesUsingGET**
> PageResourceCatalogSale GetCatalogSalesUsingGET (int? size = null, int? page = null, string order = null)

List and search sales

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCatalogSalesUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreSalesApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search sales
                PageResourceCatalogSale result = apiInstance.GetCatalogSalesUsingGET(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreSalesApi.GetCatalogSalesUsingGET: " + e.Message );
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
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourceCatalogSale**](PageResourceCatalogSale.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecatalogsaleusingput"></a>
# **UpdateCatalogSaleUsingPUT**
> void UpdateCatalogSaleUsingPUT (int? id, CatalogSale catalogSale = null)

Update a sale

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateCatalogSaleUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreSalesApi();
            var id = 56;  // int? | The id of the sale
            var catalogSale = new CatalogSale(); // CatalogSale | The catalog sale object (optional) 

            try
            {
                // Update a sale
                apiInstance.UpdateCatalogSaleUsingPUT(id, catalogSale);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreSalesApi.UpdateCatalogSaleUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the sale | 
 **catalogSale** | [**CatalogSale**](CatalogSale.md)| The catalog sale object | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

