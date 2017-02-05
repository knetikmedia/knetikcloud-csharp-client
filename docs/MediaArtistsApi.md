# IO.Swagger.Api.MediaArtistsApi

All URIs are relative to *https://integration.knetikcloud.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddArtistUsingPOST**](MediaArtistsApi.md#addartistusingpost) | **POST** /media/artists | Adds a new artist in the system
[**CreateArtistTemplateUsingPOST**](MediaArtistsApi.md#createartisttemplateusingpost) | **POST** /media/artists/templates | Create an artist template
[**DeleteArtistTemplateUsingDELETE**](MediaArtistsApi.md#deleteartisttemplateusingdelete) | **DELETE** /media/artists/templates/{id} | Delete an artist template
[**DeleteArtistUsingDELETE**](MediaArtistsApi.md#deleteartistusingdelete) | **DELETE** /media/artists/{id} | Removes an artist from the system IF no resources are attached to it
[**GetArtistTemplateUsingGET**](MediaArtistsApi.md#getartisttemplateusingget) | **GET** /media/artists/templates/{id} | Get a single artist template
[**GetArtistTemplatesUsingGET**](MediaArtistsApi.md#getartisttemplatesusingget) | **GET** /media/artists/templates | List and search artist templates
[**GetArtistUsingGET**](MediaArtistsApi.md#getartistusingget) | **GET** /media/artists/{id} | Loads a specific artist details
[**SearchArtistsUsingGET**](MediaArtistsApi.md#searchartistsusingget) | **GET** /media/artists | Search for artists
[**UpdateArtistTemplateUsingPUT**](MediaArtistsApi.md#updateartisttemplateusingput) | **PUT** /media/artists/templates/{id} | Update an artist template
[**UpdateArtistUsingPUT**](MediaArtistsApi.md#updateartistusingput) | **PUT** /media/artists/{id} | Modifies an artist details


<a name="addartistusingpost"></a>
# **AddArtistUsingPOST**
> ArtistResource AddArtistUsingPOST (ArtistResource artistResource = null)

Adds a new artist in the system

Adds a new artist in the system. Use specific media contributions endpoint to add contributions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddArtistUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaArtistsApi();
            var artistResource = new ArtistResource(); // ArtistResource | The new artist (optional) 

            try
            {
                // Adds a new artist in the system
                ArtistResource result = apiInstance.AddArtistUsingPOST(artistResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaArtistsApi.AddArtistUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **artistResource** | [**ArtistResource**](ArtistResource.md)| The new artist | [optional] 

### Return type

[**ArtistResource**](ArtistResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createartisttemplateusingpost"></a>
# **CreateArtistTemplateUsingPOST**
> TemplateResource CreateArtistTemplateUsingPOST (TemplateResource artistTemplateResource = null)

Create an artist template

Artist Templates define a type of artist and the properties they have

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateArtistTemplateUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaArtistsApi();
            var artistTemplateResource = new TemplateResource(); // TemplateResource | The artist template resource object (optional) 

            try
            {
                // Create an artist template
                TemplateResource result = apiInstance.CreateArtistTemplateUsingPOST(artistTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaArtistsApi.CreateArtistTemplateUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **artistTemplateResource** | [**TemplateResource**](TemplateResource.md)| The artist template resource object | [optional] 

### Return type

[**TemplateResource**](TemplateResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteartisttemplateusingdelete"></a>
# **DeleteArtistTemplateUsingDELETE**
> void DeleteArtistTemplateUsingDELETE (string id, string cascade = null)

Delete an artist template

If cascade = 'detach', it will force delete the template even if it's attached to other objects

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteArtistTemplateUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaArtistsApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | The value needed to delete used templates (optional) 

            try
            {
                // Delete an artist template
                apiInstance.DeleteArtistTemplateUsingDELETE(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaArtistsApi.DeleteArtistTemplateUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **cascade** | **string**| The value needed to delete used templates | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteartistusingdelete"></a>
# **DeleteArtistUsingDELETE**
> void DeleteArtistUsingDELETE (long? id)

Removes an artist from the system IF no resources are attached to it

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteArtistUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaArtistsApi();
            var id = 789;  // long? | The artist id

            try
            {
                // Removes an artist from the system IF no resources are attached to it
                apiInstance.DeleteArtistUsingDELETE(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaArtistsApi.DeleteArtistUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The artist id | 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getartisttemplateusingget"></a>
# **GetArtistTemplateUsingGET**
> TemplateResource GetArtistTemplateUsingGET (string id)

Get a single artist template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetArtistTemplateUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaArtistsApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single artist template
                TemplateResource result = apiInstance.GetArtistTemplateUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaArtistsApi.GetArtistTemplateUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 

### Return type

[**TemplateResource**](TemplateResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getartisttemplatesusingget"></a>
# **GetArtistTemplatesUsingGET**
> PageResourceTemplateResource GetArtistTemplatesUsingGET (int? size = null, int? page = null, string order = null)

List and search artist templates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetArtistTemplatesUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaArtistsApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search artist templates
                PageResourceTemplateResource result = apiInstance.GetArtistTemplatesUsingGET(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaArtistsApi.GetArtistTemplatesUsingGET: " + e.Message );
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

[**PageResourceTemplateResource**](PageResourceTemplateResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getartistusingget"></a>
# **GetArtistUsingGET**
> ArtistResource GetArtistUsingGET (long? id, int? showContributions = null)

Loads a specific artist details

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetArtistUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new MediaArtistsApi();
            var id = 789;  // long? | The artist id
            var showContributions = 56;  // int? | The number of contributions to show fetch (optional) 

            try
            {
                // Loads a specific artist details
                ArtistResource result = apiInstance.GetArtistUsingGET(id, showContributions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaArtistsApi.GetArtistUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The artist id | 
 **showContributions** | **int?**| The number of contributions to show fetch | [optional] 

### Return type

[**ArtistResource**](ArtistResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchartistsusingget"></a>
# **SearchArtistsUsingGET**
> PageResourceArtistResource SearchArtistsUsingGET (string filterArtistsByName = null, int? size = null, int? page = null, string order = null)

Search for artists

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchArtistsUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new MediaArtistsApi();
            var filterArtistsByName = filterArtistsByName_example;  // string | Filter for artists which name *STARTS* with the given string (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // Search for artists
                PageResourceArtistResource result = apiInstance.SearchArtistsUsingGET(filterArtistsByName, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaArtistsApi.SearchArtistsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterArtistsByName** | **string**| Filter for artists which name *STARTS* with the given string | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourceArtistResource**](PageResourceArtistResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateartisttemplateusingput"></a>
# **UpdateArtistTemplateUsingPUT**
> void UpdateArtistTemplateUsingPUT (string id, TemplateResource artistTemplateResource = null)

Update an artist template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateArtistTemplateUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaArtistsApi();
            var id = id_example;  // string | The id of the template
            var artistTemplateResource = new TemplateResource(); // TemplateResource | The artist template resource object (optional) 

            try
            {
                // Update an artist template
                apiInstance.UpdateArtistTemplateUsingPUT(id, artistTemplateResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaArtistsApi.UpdateArtistTemplateUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **artistTemplateResource** | [**TemplateResource**](TemplateResource.md)| The artist template resource object | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateartistusingput"></a>
# **UpdateArtistUsingPUT**
> void UpdateArtistUsingPUT (long? id, ArtistResource artistResource = null)

Modifies an artist details

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateArtistUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaArtistsApi();
            var id = 789;  // long? | The artist id
            var artistResource = new ArtistResource(); // ArtistResource | The new artist (optional) 

            try
            {
                // Modifies an artist details
                apiInstance.UpdateArtistUsingPUT(id, artistResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaArtistsApi.UpdateArtistUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The artist id | 
 **artistResource** | [**ArtistResource**](ArtistResource.md)| The new artist | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

