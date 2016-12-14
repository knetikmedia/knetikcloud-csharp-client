# IO.Swagger.Api.SearchApi

All URIs are relative to *https://devsandbox.knetikcloud.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExternalAddUsingPOST**](SearchApi.md#externaladdusingpost) | **POST** /search/index/{type}/{id} | Add a new object to an index
[**ExternalDeleteAllUsingDELETE**](SearchApi.md#externaldeleteallusingdelete) | **DELETE** /search/index/{type} | Delete all objects in an index
[**ExternalDeleteUsingDELETE**](SearchApi.md#externaldeleteusingdelete) | **DELETE** /search/index/{type}/{id} | Delete an object
[**ExternalRegisterUsingPOST**](SearchApi.md#externalregisterusingpost) | **POST** /search/mappings | Register reference mappings
[**SearchUsingPOST**](SearchApi.md#searchusingpost) | **POST** /search/index/{type} | Search an index


<a name="externaladdusingpost"></a>
# **ExternalAddUsingPOST**
> void ExternalAddUsingPOST (string type, string id, Object _object = null)

Add a new object to an index

Mainly intended for internal use.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExternalAddUsingPOSTExample
    {
        public void main()
        {
            
            var apiInstance = new SearchApi();
            var type = type_example;  // string | The index type
            var id = id_example;  // string | The ID of the object
            var _object = ;  // Object | The object to add (optional) 

            try
            {
                // Add a new object to an index
                apiInstance.ExternalAddUsingPOST(type, id, _object);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.ExternalAddUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| The index type | 
 **id** | **string**| The ID of the object | 
 **_object** | **Object**| The object to add | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="externaldeleteallusingdelete"></a>
# **ExternalDeleteAllUsingDELETE**
> void ExternalDeleteAllUsingDELETE (string type)

Delete all objects in an index

Mainly intended for internal use

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExternalDeleteAllUsingDELETEExample
    {
        public void main()
        {
            
            var apiInstance = new SearchApi();
            var type = type_example;  // string | The index type

            try
            {
                // Delete all objects in an index
                apiInstance.ExternalDeleteAllUsingDELETE(type);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.ExternalDeleteAllUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| The index type | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="externaldeleteusingdelete"></a>
# **ExternalDeleteUsingDELETE**
> void ExternalDeleteUsingDELETE (string type, string id)

Delete an object

Mainly intended for internal use. Requires SEARCH_ADMIN.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExternalDeleteUsingDELETEExample
    {
        public void main()
        {
            
            var apiInstance = new SearchApi();
            var type = type_example;  // string | The index type
            var id = id_example;  // string | The ID of the object to delete

            try
            {
                // Delete an object
                apiInstance.ExternalDeleteUsingDELETE(type, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.ExternalDeleteUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| The index type | 
 **id** | **string**| The ID of the object to delete | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="externalregisterusingpost"></a>
# **ExternalRegisterUsingPOST**
> void ExternalRegisterUsingPOST (List<SearchReferenceMapping> mappings = null)

Register reference mappings

Add a new type mapping to connect data from one index to another, or discover an exsting one. Mainly intended for internal use.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExternalRegisterUsingPOSTExample
    {
        public void main()
        {
            
            var apiInstance = new SearchApi();
            var mappings = new List<SearchReferenceMapping>(); // List<SearchReferenceMapping> | The mappings to add (optional) 

            try
            {
                // Register reference mappings
                apiInstance.ExternalRegisterUsingPOST(mappings);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.ExternalRegisterUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mappings** | [**List<SearchReferenceMapping>**](SearchReferenceMapping.md)| The mappings to add | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchusingpost"></a>
# **SearchUsingPOST**
> PageMapstringobject SearchUsingPOST (string type, Object query = null, int? size = null, int? page = null, string order = null)

Search an index

The body is an ElasticSearch query in JSON format. Please see their <a href='https://www.elastic.co/guide/en/elasticsearch/reference/current/query-dsl.html'>documentation</a> for details on the format and search options. The searchable object's format depends on on the type. See individual search endpoints on other resources for details on their format.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchUsingPOSTExample
    {
        public void main()
        {
            
            var apiInstance = new SearchApi();
            var type = type_example;  // string | The index type
            var query = ;  // Object | The query to be used for the search (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | a comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to 1)

            try
            {
                // Search an index
                PageMapstringobject result = apiInstance.SearchUsingPOST(type, query, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| The index type | 
 **query** | **Object**| The query to be used for the search | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| a comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to 1]

### Return type

[**PageMapstringobject**](PageMapstringobject.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

