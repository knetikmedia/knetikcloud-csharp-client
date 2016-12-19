# IO.Swagger.Api.ContentCommentsApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddCommentUsingPOST**](ContentCommentsApi.md#addcommentusingpost) | **POST** /comments | Add a new comment
[**DeleteCommentUsingDELETE**](ContentCommentsApi.md#deletecommentusingdelete) | **DELETE** /comments/{id} | Delete a comment
[**GetCommentUsingGET**](ContentCommentsApi.md#getcommentusingget) | **GET** /comments/{id} | Returns a comment by comment id
[**GetCommentsUsingGET**](ContentCommentsApi.md#getcommentsusingget) | **GET** /comments | Returns a page of comments
[**SearchCommentsUsingPOST**](ContentCommentsApi.md#searchcommentsusingpost) | **POST** /comments/search | Search the comment index
[**UpdateCommentUsingPUT**](ContentCommentsApi.md#updatecommentusingput) | **PUT** /comments/{id}/content | Update comment content


<a name="addcommentusingpost"></a>
# **AddCommentUsingPOST**
> CommentResource AddCommentUsingPOST (CommentResource commentResource = null)

Add a new comment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddCommentUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContentCommentsApi();
            var commentResource = new CommentResource(); // CommentResource | The comment to be added (optional) 

            try
            {
                // Add a new comment
                CommentResource result = apiInstance.AddCommentUsingPOST(commentResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentCommentsApi.AddCommentUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **commentResource** | [**CommentResource**](CommentResource.md)| The comment to be added | [optional] 

### Return type

[**CommentResource**](CommentResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecommentusingdelete"></a>
# **DeleteCommentUsingDELETE**
> void DeleteCommentUsingDELETE (long? id)

Delete a comment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteCommentUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContentCommentsApi();
            var id = 789;  // long? | The comment id

            try
            {
                // Delete a comment
                apiInstance.DeleteCommentUsingDELETE(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentCommentsApi.DeleteCommentUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The comment id | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcommentusingget"></a>
# **GetCommentUsingGET**
> CommentResource GetCommentUsingGET (long? id)

Returns a comment by comment id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCommentUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new ContentCommentsApi();
            var id = 789;  // long? | The comment id

            try
            {
                // Returns a comment by comment id
                CommentResource result = apiInstance.GetCommentUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentCommentsApi.GetCommentUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The comment id | 

### Return type

[**CommentResource**](CommentResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcommentsusingget"></a>
# **GetCommentsUsingGET**
> PageCommentResource GetCommentsUsingGET (string context, int? contextId, int? size = null, int? page = null)

Returns a page of comments

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCommentsUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new ContentCommentsApi();
            var context = context_example;  // string | Get comments by context type
            var contextId = 56;  // int? | Get comments by context id
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Returns a page of comments
                PageCommentResource result = apiInstance.GetCommentsUsingGET(context, contextId, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentCommentsApi.GetCommentsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **context** | **string**| Get comments by context type | 
 **contextId** | **int?**| Get comments by context id | 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageCommentResource**](PageCommentResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchcommentsusingpost"></a>
# **SearchCommentsUsingPOST**
> CommentSearch SearchCommentsUsingPOST (Object query = null, int? size = null, int? page = null)

Search the comment index

The body is an ElasticSearch query json. Please see their <a href='https://www.elastic.co/guide/en/elasticsearch/reference/current/index.html'>documentation</a> for details on the format and search options

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchCommentsUsingPOSTExample
    {
        public void main()
        {
            
            var apiInstance = new ContentCommentsApi();
            var query = ;  // Object | The search query (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Search the comment index
                CommentSearch result = apiInstance.SearchCommentsUsingPOST(query, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentCommentsApi.SearchCommentsUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | **Object**| The search query | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**CommentSearch**](CommentSearch.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecommentusingput"></a>
# **UpdateCommentUsingPUT**
> void UpdateCommentUsingPUT (long? id, string content = null)

Update comment content

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateCommentUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContentCommentsApi();
            var id = 789;  // long? | The comment id
            var content = content_example;  // string | The comment content (optional) 

            try
            {
                // Update comment content
                apiInstance.UpdateCommentUsingPUT(id, content);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentCommentsApi.UpdateCommentUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The comment id | 
 **content** | **string**| The comment content | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

