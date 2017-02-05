# IO.Swagger.Api.DispositionsApi

All URIs are relative to *https://integration.knetikcloud.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddDispositionUsingPOST**](DispositionsApi.md#adddispositionusingpost) | **POST** /dispositions | Add a new disposition. 
[**DeleteDispositionUsingDELETE**](DispositionsApi.md#deletedispositionusingdelete) | **DELETE** /dispositions/{id} | Delete a disposition
[**GetDispositionCountUsingGET**](DispositionsApi.md#getdispositioncountusingget) | **GET** /dispositions/count | Returns a list of disposition counts
[**GetDispositionUsingGET**](DispositionsApi.md#getdispositionusingget) | **GET** /dispositions/{id} | Returns a disposition
[**GetDispositionsUsingGET**](DispositionsApi.md#getdispositionsusingget) | **GET** /dispositions | Returns a page of dispositions


<a name="adddispositionusingpost"></a>
# **AddDispositionUsingPOST**
> DispositionResource AddDispositionUsingPOST (DispositionResource disposition = null)

Add a new disposition. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddDispositionUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DispositionsApi();
            var disposition = new DispositionResource(); // DispositionResource | The new disposition record (optional) 

            try
            {
                // Add a new disposition. 
                DispositionResource result = apiInstance.AddDispositionUsingPOST(disposition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DispositionsApi.AddDispositionUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **disposition** | [**DispositionResource**](DispositionResource.md)| The new disposition record | [optional] 

### Return type

[**DispositionResource**](DispositionResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedispositionusingdelete"></a>
# **DeleteDispositionUsingDELETE**
> void DeleteDispositionUsingDELETE (long? id)

Delete a disposition

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteDispositionUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DispositionsApi();
            var id = 789;  // long? | The id of the disposition record

            try
            {
                // Delete a disposition
                apiInstance.DeleteDispositionUsingDELETE(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DispositionsApi.DeleteDispositionUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The id of the disposition record | 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdispositioncountusingget"></a>
# **GetDispositionCountUsingGET**
> List<DispositionCount> GetDispositionCountUsingGET (string filterContext = null, string filterOwner = null)

Returns a list of disposition counts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDispositionCountUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new DispositionsApi();
            var filterContext = filterContext_example;  // string | Filter for dispositions within a context type (games, articles, polls, etc). Optionally with a specific id like filter_context=video:47 (optional) 
            var filterOwner = filterOwner_example;  // string | Filter for dispositions from a specific user by id or 'me' (optional) 

            try
            {
                // Returns a list of disposition counts
                List&lt;DispositionCount&gt; result = apiInstance.GetDispositionCountUsingGET(filterContext, filterOwner);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DispositionsApi.GetDispositionCountUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterContext** | **string**| Filter for dispositions within a context type (games, articles, polls, etc). Optionally with a specific id like filter_context&#x3D;video:47 | [optional] 
 **filterOwner** | **string**| Filter for dispositions from a specific user by id or &#39;me&#39; | [optional] 

### Return type

[**List<DispositionCount>**](DispositionCount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdispositionusingget"></a>
# **GetDispositionUsingGET**
> DispositionResource GetDispositionUsingGET (long? id)

Returns a disposition

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDispositionUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new DispositionsApi();
            var id = 789;  // long? | The id of the disposition record

            try
            {
                // Returns a disposition
                DispositionResource result = apiInstance.GetDispositionUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DispositionsApi.GetDispositionUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The id of the disposition record | 

### Return type

[**DispositionResource**](DispositionResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdispositionsusingget"></a>
# **GetDispositionsUsingGET**
> PageResourceDispositionResource GetDispositionsUsingGET (string filterContext = null, string filterOwner = null, int? size = null, int? page = null, string order = null)

Returns a page of dispositions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDispositionsUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new DispositionsApi();
            var filterContext = filterContext_example;  // string | Filter for dispositions within a context type (games, articles, polls, etc). Optionally with a specific id like filter_context=video:47 (optional) 
            var filterOwner = filterOwner_example;  // string | Filter for dispositions from a specific user by id or 'me' (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // Returns a page of dispositions
                PageResourceDispositionResource result = apiInstance.GetDispositionsUsingGET(filterContext, filterOwner, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DispositionsApi.GetDispositionsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterContext** | **string**| Filter for dispositions within a context type (games, articles, polls, etc). Optionally with a specific id like filter_context&#x3D;video:47 | [optional] 
 **filterOwner** | **string**| Filter for dispositions from a specific user by id or &#39;me&#39; | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourceDispositionResource**](PageResourceDispositionResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

