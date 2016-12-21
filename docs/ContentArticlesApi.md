# IO.Swagger.Api.ContentArticlesApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateArticleTemplateUsingPOST**](ContentArticlesApi.md#createarticletemplateusingpost) | **POST** /content/articles/templates | Create an article template
[**CreateArticleUsingPOST**](ContentArticlesApi.md#createarticleusingpost) | **POST** /content/articles | Create a new article
[**DeleteArticleTemplateUsingDELETE**](ContentArticlesApi.md#deletearticletemplateusingdelete) | **DELETE** /content/articles/templates/{id} | Delete an article template
[**DeleteArticleUsingDELETE**](ContentArticlesApi.md#deletearticleusingdelete) | **DELETE** /content/articles/{id} | Delete an existing article
[**GetArticleTemplateUsingGET**](ContentArticlesApi.md#getarticletemplateusingget) | **GET** /content/articles/templates/{id} | Get a single article template
[**GetArticleTemplatesUsingGET**](ContentArticlesApi.md#getarticletemplatesusingget) | **GET** /content/articles/templates | List and search article templates
[**GetArticleUsingGET**](ContentArticlesApi.md#getarticleusingget) | **GET** /content/articles/{id} | Get a single article
[**GetArticlesUsingGET**](ContentArticlesApi.md#getarticlesusingget) | **GET** /content/articles | List and search articles
[**UpdateArticleTemplateUsingPUT**](ContentArticlesApi.md#updatearticletemplateusingput) | **PUT** /content/articles/templates/{id} | Update an article template
[**UpdateArticleUsingPUT**](ContentArticlesApi.md#updatearticleusingput) | **PUT** /content/articles/{id} | Update an existing article


<a name="createarticletemplateusingpost"></a>
# **CreateArticleTemplateUsingPOST**
> TemplateResource CreateArticleTemplateUsingPOST (TemplateResource articleTemplateResource = null)

Create an article template

Article Templates define a type of article and the properties they have

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateArticleTemplateUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContentArticlesApi();
            var articleTemplateResource = new TemplateResource(); // TemplateResource | The article template resource object (optional) 

            try
            {
                // Create an article template
                TemplateResource result = apiInstance.CreateArticleTemplateUsingPOST(articleTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentArticlesApi.CreateArticleTemplateUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **articleTemplateResource** | [**TemplateResource**](TemplateResource.md)| The article template resource object | [optional] 

### Return type

[**TemplateResource**](TemplateResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createarticleusingpost"></a>
# **CreateArticleUsingPOST**
> ArticleResource CreateArticleUsingPOST (ArticleResource articleResource = null)

Create a new article

Articles are blobs of text with titles, a category and assets. Formatting and display of the text is in the hands of the front end.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateArticleUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContentArticlesApi();
            var articleResource = new ArticleResource(); // ArticleResource | The new article (optional) 

            try
            {
                // Create a new article
                ArticleResource result = apiInstance.CreateArticleUsingPOST(articleResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentArticlesApi.CreateArticleUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **articleResource** | [**ArticleResource**](ArticleResource.md)| The new article | [optional] 

### Return type

[**ArticleResource**](ArticleResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletearticletemplateusingdelete"></a>
# **DeleteArticleTemplateUsingDELETE**
> void DeleteArticleTemplateUsingDELETE (string id, string cascade = null)

Delete an article template

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
    public class DeleteArticleTemplateUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContentArticlesApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | The value needed to delete used templates (optional) 

            try
            {
                // Delete an article template
                apiInstance.DeleteArticleTemplateUsingDELETE(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentArticlesApi.DeleteArticleTemplateUsingDELETE: " + e.Message );
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

<a name="deletearticleusingdelete"></a>
# **DeleteArticleUsingDELETE**
> void DeleteArticleUsingDELETE (string id)

Delete an existing article

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteArticleUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContentArticlesApi();
            var id = id_example;  // string | The article id

            try
            {
                // Delete an existing article
                apiInstance.DeleteArticleUsingDELETE(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentArticlesApi.DeleteArticleUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The article id | 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getarticletemplateusingget"></a>
# **GetArticleTemplateUsingGET**
> TemplateResource GetArticleTemplateUsingGET (string id)

Get a single article template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetArticleTemplateUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContentArticlesApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single article template
                TemplateResource result = apiInstance.GetArticleTemplateUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentArticlesApi.GetArticleTemplateUsingGET: " + e.Message );
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

<a name="getarticletemplatesusingget"></a>
# **GetArticleTemplatesUsingGET**
> PageResourceTemplateResource GetArticleTemplatesUsingGET (int? size = null, int? page = null, string order = null)

List and search article templates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetArticleTemplatesUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContentArticlesApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search article templates
                PageResourceTemplateResource result = apiInstance.GetArticleTemplatesUsingGET(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentArticlesApi.GetArticleTemplatesUsingGET: " + e.Message );
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

<a name="getarticleusingget"></a>
# **GetArticleUsingGET**
> ArticleResource GetArticleUsingGET (string id)

Get a single article

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetArticleUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new ContentArticlesApi();
            var id = id_example;  // string | The article id

            try
            {
                // Get a single article
                ArticleResource result = apiInstance.GetArticleUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentArticlesApi.GetArticleUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The article id | 

### Return type

[**ArticleResource**](ArticleResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getarticlesusingget"></a>
# **GetArticlesUsingGET**
> PageResourceArticleResource GetArticlesUsingGET (string filterCategory = null, string filterTagset = null, string filterTitle = null, int? size = null, int? page = null, string order = null)

List and search articles

Get a list of articles with optional filtering. Assets will not be filled in on the resources returned. Use 'Get a single article' to retrieve the full resource with assets for a given item as needed.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetArticlesUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new ContentArticlesApi();
            var filterCategory = filterCategory_example;  // string | Filter for articles from a specific category by id (optional) 
            var filterTagset = filterTagset_example;  // string | Filter for articles with specified tags (separated by comma) (optional) 
            var filterTitle = filterTitle_example;  // string | Filter for articles whose title contains a string (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search articles
                PageResourceArticleResource result = apiInstance.GetArticlesUsingGET(filterCategory, filterTagset, filterTitle, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentArticlesApi.GetArticlesUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterCategory** | **string**| Filter for articles from a specific category by id | [optional] 
 **filterTagset** | **string**| Filter for articles with specified tags (separated by comma) | [optional] 
 **filterTitle** | **string**| Filter for articles whose title contains a string | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourceArticleResource**](PageResourceArticleResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatearticletemplateusingput"></a>
# **UpdateArticleTemplateUsingPUT**
> void UpdateArticleTemplateUsingPUT (string id, TemplateResource articleTemplateResource = null)

Update an article template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateArticleTemplateUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContentArticlesApi();
            var id = id_example;  // string | The id of the template
            var articleTemplateResource = new TemplateResource(); // TemplateResource | The article template resource object (optional) 

            try
            {
                // Update an article template
                apiInstance.UpdateArticleTemplateUsingPUT(id, articleTemplateResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentArticlesApi.UpdateArticleTemplateUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **articleTemplateResource** | [**TemplateResource**](TemplateResource.md)| The article template resource object | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatearticleusingput"></a>
# **UpdateArticleUsingPUT**
> void UpdateArticleUsingPUT (string id, ArticleResource articleResource = null)

Update an existing article

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateArticleUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContentArticlesApi();
            var id = id_example;  // string | The article id
            var articleResource = new ArticleResource(); // ArticleResource | The article object (optional) 

            try
            {
                // Update an existing article
                apiInstance.UpdateArticleUsingPUT(id, articleResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentArticlesApi.UpdateArticleUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The article id | 
 **articleResource** | [**ArticleResource**](ArticleResource.md)| The article object | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

