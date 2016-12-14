# IO.Swagger.Api.LocationsApi

All URIs are relative to *https://devsandbox.knetikcloud.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CitiesUsingGET**](LocationsApi.md#citiesusingget) | **GET** /location/countries/{country_code_iso3}/states/{state_code}/cities | Get a list of a state&#39;s cities
[**CountriesUsingGET**](LocationsApi.md#countriesusingget) | **GET** /location/countries | Get a list of countries
[**GetCurrencyByGeoLocationUsingGET**](LocationsApi.md#getcurrencybygeolocationusingget) | **GET** /location/geolocation/currency | Get the currency information of your country
[**GetGeoLocationCountryUsingGET**](LocationsApi.md#getgeolocationcountryusingget) | **GET** /location/geolocation/country | Get the iso3 code of your country
[**StatesUsingGET**](LocationsApi.md#statesusingget) | **GET** /location/countries/{country_code_iso3}/states | Get a list of a country&#39;s states


<a name="citiesusingget"></a>
# **CitiesUsingGET**
> List<CityResource> CitiesUsingGET (string countryCodeIso3, string stateCode)

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
    public class CitiesUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new LocationsApi();
            var countryCodeIso3 = countryCodeIso3_example;  // string | The iso3 code of the country
            var stateCode = stateCode_example;  // string | The code of the state

            try
            {
                // Get a list of a state's cities
                List&lt;CityResource&gt; result = apiInstance.CitiesUsingGET(countryCodeIso3, stateCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationsApi.CitiesUsingGET: " + e.Message );
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
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="countriesusingget"></a>
# **CountriesUsingGET**
> List<CountryResource> CountriesUsingGET ()

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
    public class CountriesUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new LocationsApi();

            try
            {
                // Get a list of countries
                List&lt;CountryResource&gt; result = apiInstance.CountriesUsingGET();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationsApi.CountriesUsingGET: " + e.Message );
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
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcurrencybygeolocationusingget"></a>
# **GetCurrencyByGeoLocationUsingGET**
> CurrencyResource GetCurrencyByGeoLocationUsingGET ()

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
    public class GetCurrencyByGeoLocationUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new LocationsApi();

            try
            {
                // Get the currency information of your country
                CurrencyResource result = apiInstance.GetCurrencyByGeoLocationUsingGET();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationsApi.GetCurrencyByGeoLocationUsingGET: " + e.Message );
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
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgeolocationcountryusingget"></a>
# **GetGeoLocationCountryUsingGET**
> string GetGeoLocationCountryUsingGET ()

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
    public class GetGeoLocationCountryUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new LocationsApi();

            try
            {
                // Get the iso3 code of your country
                string result = apiInstance.GetGeoLocationCountryUsingGET();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationsApi.GetGeoLocationCountryUsingGET: " + e.Message );
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
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="statesusingget"></a>
# **StatesUsingGET**
> List<StateResource> StatesUsingGET (string countryCodeIso3)

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
    public class StatesUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new LocationsApi();
            var countryCodeIso3 = countryCodeIso3_example;  // string | The iso3 code of the country

            try
            {
                // Get a list of a country's states
                List&lt;StateResource&gt; result = apiInstance.StatesUsingGET(countryCodeIso3);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationsApi.StatesUsingGET: " + e.Message );
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
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

