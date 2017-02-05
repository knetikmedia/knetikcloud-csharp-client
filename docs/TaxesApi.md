# IO.Swagger.Api.TaxesApi

All URIs are relative to *https://integration.knetikcloud.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTaxUsingPOST**](TaxesApi.md#createtaxusingpost) | **POST** /tax/countries/{country_code_iso3}/states | Create a tax
[**DeleteTaxUsingDELETE**](TaxesApi.md#deletetaxusingdelete) | **DELETE** /tax/countries/{country_code_iso3} | Delete an existing tax
[**DeleteTaxUsingDELETE1**](TaxesApi.md#deletetaxusingdelete1) | **DELETE** /tax/countries/{country_code_iso3}/states/{state_code} | Delete an existing tax
[**GetAllTaxesUsingGET**](TaxesApi.md#getalltaxesusingget) | **GET** /tax/states | List and search taxes across all countries
[**GetTaxUsingGET**](TaxesApi.md#gettaxusingget) | **GET** /tax/countries/{country_code_iso3} | Get a single tax
[**GetTaxUsingGET1**](TaxesApi.md#gettaxusingget1) | **GET** /tax/countries/{country_code_iso3}/states/{state_code} | Get a single tax
[**GetTaxesUsingGET**](TaxesApi.md#gettaxesusingget) | **GET** /tax/countries | List and search taxes
[**GetTaxesUsingGET1**](TaxesApi.md#gettaxesusingget1) | **GET** /tax/countries/{country_code_iso3}/states | List and search taxes within a country
[**UpdateTaxUsingPOST**](TaxesApi.md#updatetaxusingpost) | **POST** /tax/countries | Create a tax
[**UpdateTaxUsingPUT**](TaxesApi.md#updatetaxusingput) | **PUT** /tax/countries/{country_code_iso3} | Create or update a tax
[**UpdateTaxUsingPUT1**](TaxesApi.md#updatetaxusingput1) | **PUT** /tax/countries/{country_code_iso3}/states/{state_code} | Create or update a tax


<a name="createtaxusingpost"></a>
# **CreateTaxUsingPOST**
> void CreateTaxUsingPOST (string countryCodeIso3, StateTaxResource taxResource = null)

Create a tax

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateTaxUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TaxesApi();
            var countryCodeIso3 = countryCodeIso3_example;  // string | The iso3 code of the country
            var taxResource = new StateTaxResource(); // StateTaxResource | The tax object (optional) 

            try
            {
                // Create a tax
                apiInstance.CreateTaxUsingPOST(countryCodeIso3, taxResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaxesApi.CreateTaxUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **countryCodeIso3** | **string**| The iso3 code of the country | 
 **taxResource** | [**StateTaxResource**](StateTaxResource.md)| The tax object | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetaxusingdelete"></a>
# **DeleteTaxUsingDELETE**
> void DeleteTaxUsingDELETE (string countryCodeIso3)

Delete an existing tax

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteTaxUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TaxesApi();
            var countryCodeIso3 = countryCodeIso3_example;  // string | The iso3 code of the country

            try
            {
                // Delete an existing tax
                apiInstance.DeleteTaxUsingDELETE(countryCodeIso3);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaxesApi.DeleteTaxUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **countryCodeIso3** | **string**| The iso3 code of the country | 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetaxusingdelete1"></a>
# **DeleteTaxUsingDELETE1**
> void DeleteTaxUsingDELETE1 (string countryCodeIso3, string stateCode)

Delete an existing tax

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteTaxUsingDELETE1Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TaxesApi();
            var countryCodeIso3 = countryCodeIso3_example;  // string | The iso3 code of the country
            var stateCode = stateCode_example;  // string | The code of the state

            try
            {
                // Delete an existing tax
                apiInstance.DeleteTaxUsingDELETE1(countryCodeIso3, stateCode);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaxesApi.DeleteTaxUsingDELETE1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **countryCodeIso3** | **string**| The iso3 code of the country | 
 **stateCode** | **string**| The code of the state | 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalltaxesusingget"></a>
# **GetAllTaxesUsingGET**
> PageResourceStateTaxResource GetAllTaxesUsingGET (int? size = null, int? page = null, string order = null)

List and search taxes across all countries

Get a list of taxes

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllTaxesUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new TaxesApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to name:ASC)

            try
            {
                // List and search taxes across all countries
                PageResourceStateTaxResource result = apiInstance.GetAllTaxesUsingGET(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaxesApi.GetAllTaxesUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to name:ASC]

### Return type

[**PageResourceStateTaxResource**](PageResourceStateTaxResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettaxusingget"></a>
# **GetTaxUsingGET**
> CountryTaxResource GetTaxUsingGET (string countryCodeIso3)

Get a single tax

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTaxUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new TaxesApi();
            var countryCodeIso3 = countryCodeIso3_example;  // string | The iso3 code of the country

            try
            {
                // Get a single tax
                CountryTaxResource result = apiInstance.GetTaxUsingGET(countryCodeIso3);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaxesApi.GetTaxUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **countryCodeIso3** | **string**| The iso3 code of the country | 

### Return type

[**CountryTaxResource**](CountryTaxResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettaxusingget1"></a>
# **GetTaxUsingGET1**
> StateTaxResource GetTaxUsingGET1 (string countryCodeIso3, string stateCode)

Get a single tax

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTaxUsingGET1Example
    {
        public void main()
        {
            
            var apiInstance = new TaxesApi();
            var countryCodeIso3 = countryCodeIso3_example;  // string | The iso3 code of the country
            var stateCode = stateCode_example;  // string | The code of the state

            try
            {
                // Get a single tax
                StateTaxResource result = apiInstance.GetTaxUsingGET1(countryCodeIso3, stateCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaxesApi.GetTaxUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **countryCodeIso3** | **string**| The iso3 code of the country | 
 **stateCode** | **string**| The code of the state | 

### Return type

[**StateTaxResource**](StateTaxResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettaxesusingget"></a>
# **GetTaxesUsingGET**
> PageResourceCountryTaxResource GetTaxesUsingGET (int? size = null, int? page = null, string order = null)

List and search taxes

Get a list of taxes

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTaxesUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new TaxesApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to name:ASC)

            try
            {
                // List and search taxes
                PageResourceCountryTaxResource result = apiInstance.GetTaxesUsingGET(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaxesApi.GetTaxesUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to name:ASC]

### Return type

[**PageResourceCountryTaxResource**](PageResourceCountryTaxResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettaxesusingget1"></a>
# **GetTaxesUsingGET1**
> PageResourceStateTaxResource GetTaxesUsingGET1 (string countryCodeIso3, int? size = null, int? page = null, string order = null)

List and search taxes within a country

Get a list of taxes

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTaxesUsingGET1Example
    {
        public void main()
        {
            
            var apiInstance = new TaxesApi();
            var countryCodeIso3 = countryCodeIso3_example;  // string | The iso3 code of the country
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to name:ASC)

            try
            {
                // List and search taxes within a country
                PageResourceStateTaxResource result = apiInstance.GetTaxesUsingGET1(countryCodeIso3, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaxesApi.GetTaxesUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **countryCodeIso3** | **string**| The iso3 code of the country | 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to name:ASC]

### Return type

[**PageResourceStateTaxResource**](PageResourceStateTaxResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetaxusingpost"></a>
# **UpdateTaxUsingPOST**
> void UpdateTaxUsingPOST (CountryTaxResource taxResource = null)

Create a tax

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateTaxUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TaxesApi();
            var taxResource = new CountryTaxResource(); // CountryTaxResource | The tax object (optional) 

            try
            {
                // Create a tax
                apiInstance.UpdateTaxUsingPOST(taxResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaxesApi.UpdateTaxUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taxResource** | [**CountryTaxResource**](CountryTaxResource.md)| The tax object | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetaxusingput"></a>
# **UpdateTaxUsingPUT**
> void UpdateTaxUsingPUT (string countryCodeIso3, CountryTaxResource taxResource = null)

Create or update a tax

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateTaxUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TaxesApi();
            var countryCodeIso3 = countryCodeIso3_example;  // string | The iso3 code of the country
            var taxResource = new CountryTaxResource(); // CountryTaxResource | The tax object (optional) 

            try
            {
                // Create or update a tax
                apiInstance.UpdateTaxUsingPUT(countryCodeIso3, taxResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaxesApi.UpdateTaxUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **countryCodeIso3** | **string**| The iso3 code of the country | 
 **taxResource** | [**CountryTaxResource**](CountryTaxResource.md)| The tax object | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetaxusingput1"></a>
# **UpdateTaxUsingPUT1**
> void UpdateTaxUsingPUT1 (string countryCodeIso3, string stateCode, StateTaxResource taxResource = null)

Create or update a tax

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateTaxUsingPUT1Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TaxesApi();
            var countryCodeIso3 = countryCodeIso3_example;  // string | The iso3 code of the country
            var stateCode = stateCode_example;  // string | The code of the state
            var taxResource = new StateTaxResource(); // StateTaxResource | The tax object (optional) 

            try
            {
                // Create or update a tax
                apiInstance.UpdateTaxUsingPUT1(countryCodeIso3, stateCode, taxResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaxesApi.UpdateTaxUsingPUT1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **countryCodeIso3** | **string**| The iso3 code of the country | 
 **stateCode** | **string**| The code of the state | 
 **taxResource** | [**StateTaxResource**](StateTaxResource.md)| The tax object | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

