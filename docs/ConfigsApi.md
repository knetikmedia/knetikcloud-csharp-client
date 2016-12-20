# IO.Swagger.Api.ConfigsApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateConfigUsingPOST**](ConfigsApi.md#createconfigusingpost) | **POST** /configs | Create a new config
[**DeleteConfigUsingDELETE**](ConfigsApi.md#deleteconfigusingdelete) | **DELETE** /configs/{name} | Delete an existing config
[**GetConfigUsingGET**](ConfigsApi.md#getconfigusingget) | **GET** /configs/{name} | Get a single config
[**GetConfigsUsingGET**](ConfigsApi.md#getconfigsusingget) | **GET** /configs | List and search configs
[**UpdateConfigUsingPUT**](ConfigsApi.md#updateconfigusingput) | **PUT** /configs/{name} | Update an existing config


<a name="createconfigusingpost"></a>
# **CreateConfigUsingPOST**
> Config CreateConfigUsingPOST (Config config = null)

Create a new config

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateConfigUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigsApi();
            var config = new Config(); // Config | The config object (optional) 

            try
            {
                // Create a new config
                Config result = apiInstance.CreateConfigUsingPOST(config);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigsApi.CreateConfigUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **config** | [**Config**](Config.md)| The config object | [optional] 

### Return type

[**Config**](Config.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteconfigusingdelete"></a>
# **DeleteConfigUsingDELETE**
> void DeleteConfigUsingDELETE (string name)

Delete an existing config

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteConfigUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigsApi();
            var name = name_example;  // string | The config name

            try
            {
                // Delete an existing config
                apiInstance.DeleteConfigUsingDELETE(name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigsApi.DeleteConfigUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The config name | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconfigusingget"></a>
# **GetConfigUsingGET**
> Config GetConfigUsingGET (string name)

Get a single config

Only configs that are public readable will be shown without admin access

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetConfigUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new ConfigsApi();
            var name = name_example;  // string | The config name

            try
            {
                // Get a single config
                Config result = apiInstance.GetConfigUsingGET(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigsApi.GetConfigUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The config name | 

### Return type

[**Config**](Config.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconfigsusingget"></a>
# **GetConfigsUsingGET**
> PageConfig GetConfigsUsingGET (string filterSearch = null, int? size = null, int? page = null, string order = null)

List and search configs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetConfigsUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new ConfigsApi();
            var filterSearch = filterSearch_example;  // string | Filter for configs whose name contains the given string (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search configs
                PageConfig result = apiInstance.GetConfigsUsingGET(filterSearch, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigsApi.GetConfigsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterSearch** | **string**| Filter for configs whose name contains the given string | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageConfig**](PageConfig.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateconfigusingput"></a>
# **UpdateConfigUsingPUT**
> void UpdateConfigUsingPUT (string name, Config config = null)

Update an existing config

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateConfigUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigsApi();
            var name = name_example;  // string | The config name
            var config = new Config(); // Config | The config object (optional) 

            try
            {
                // Update an existing config
                apiInstance.UpdateConfigUsingPUT(name, config);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigsApi.UpdateConfigUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The config name | 
 **config** | [**Config**](Config.md)| The config object | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

