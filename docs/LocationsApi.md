# IO.Swagger.Api.LocationsApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCities**](LocationsApi.md#getcities) | **GET** /location/countries/{country_code_iso3}/states/{state_code}/cities | Get a list of a state&#39;s cities
[**GetCountries1**](LocationsApi.md#getcountries1) | **GET** /location/countries | Get a list of countries
[**GetCountries2**](LocationsApi.md#getcountries2) | **GET** /location/countries/{country_code_iso3}/states | Get a list of a country&#39;s states
[**GetCountryByGeoLocation**](LocationsApi.md#getcountrybygeolocation) | **GET** /location/geolocation/country | Get the iso3 code of your country
[**GetCurrencyByGeoLocation**](LocationsApi.md#getcurrencybygeolocation) | **GET** /location/geolocation/currency | Get the currency information of your country


<a name="getcities"></a>
# **GetCities**
> List<CityResource> GetCities (string countryCodeIso3, string stateCode)

Get a list of a state's cities

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCitiesExample
    {
        public void main()
        {
            
            var apiInstance = new LocationsApi();
            var countryCodeIso3 = countryCodeIso3_example;  // string | The iso3 code of the country
            var stateCode = stateCode_example;  // string | The code of the state

            try
            {
                // Get a list of a state's cities
                List&lt;CityResource&gt; result = apiInstance.GetCities(countryCodeIso3, stateCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationsApi.GetCities: " + e.Message );
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

[**List<CityResource>**](CityResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcountries1"></a>
# **GetCountries1**
> List<CountryResource> GetCountries1 ()

Get a list of countries

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCountries1Example
    {
        public void main()
        {
            
            var apiInstance = new LocationsApi();

            try
            {
                // Get a list of countries
                List&lt;CountryResource&gt; result = apiInstance.GetCountries1();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationsApi.GetCountries1: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<CountryResource>**](CountryResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcountries2"></a>
# **GetCountries2**
> List<StateResource> GetCountries2 (string countryCodeIso3)

Get a list of a country's states

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCountries2Example
    {
        public void main()
        {
            
            var apiInstance = new LocationsApi();
            var countryCodeIso3 = countryCodeIso3_example;  // string | The iso3 code of the country

            try
            {
                // Get a list of a country's states
                List&lt;StateResource&gt; result = apiInstance.GetCountries2(countryCodeIso3);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationsApi.GetCountries2: " + e.Message );
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

[**List<StateResource>**](StateResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcountrybygeolocation"></a>
# **GetCountryByGeoLocation**
> string GetCountryByGeoLocation ()

Get the iso3 code of your country

Determined by geo ip location

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCountryByGeoLocationExample
    {
        public void main()
        {
            
            var apiInstance = new LocationsApi();

            try
            {
                // Get the iso3 code of your country
                string result = apiInstance.GetCountryByGeoLocation();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationsApi.GetCountryByGeoLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcurrencybygeolocation"></a>
# **GetCurrencyByGeoLocation**
> CurrencyResource GetCurrencyByGeoLocation ()

Get the currency information of your country

Determined by geo ip location, currency to country mapping and a fallback setting

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCurrencyByGeoLocationExample
    {
        public void main()
        {
            
            var apiInstance = new LocationsApi();

            try
            {
                // Get the currency information of your country
                CurrencyResource result = apiInstance.GetCurrencyByGeoLocation();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationsApi.GetCurrencyByGeoLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**CurrencyResource**](CurrencyResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

