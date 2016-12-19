# IO.Swagger.Api.CategoriesApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCategoryUsingPOST**](CategoriesApi.md#createcategoryusingpost) | **POST** /categories | Create a new category
[**CreateTemplateUsingPOST2**](CategoriesApi.md#createtemplateusingpost2) | **POST** /categories/templates | Create a category template
[**DeleteCategoryUsingDELETE**](CategoriesApi.md#deletecategoryusingdelete) | **DELETE** /categories/{id} | Delete an existing category
[**DeleteTemplateUsingDELETE1**](CategoriesApi.md#deletetemplateusingdelete1) | **DELETE** /categories/templates/{id} | Delete a category template
[**GetArticleTemplatesUsingGET1**](CategoriesApi.md#getarticletemplatesusingget1) | **GET** /categories/templates | List and search category templates
[**GetCategoriesUsingGET1**](CategoriesApi.md#getcategoriesusingget1) | **GET** /categories | List and search categories with optional filters
[**GetCategoryUsingGET1**](CategoriesApi.md#getcategoryusingget1) | **GET** /categories/{id} | Get a single category
[**GetTagsUsingGET**](CategoriesApi.md#gettagsusingget) | **GET** /tags | List all trivia tags in the system
[**GetTemplateUsingGET1**](CategoriesApi.md#gettemplateusingget1) | **GET** /categories/templates/{id} | Get a single category template
[**UpdateCategoryUsingPUT1**](CategoriesApi.md#updatecategoryusingput1) | **PUT** /categories/{id} | Update an existing category
[**UpdateTemplateUsingPUT2**](CategoriesApi.md#updatetemplateusingput2) | **PUT** /categories/templates/{id} | Update a category template


<a name="createcategoryusingpost"></a>
# **CreateCategoryUsingPOST**
> CategoryResource CreateCategoryUsingPOST (CategoryResource category = null)

Create a new category

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateCategoryUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesApi();
            var category = new CategoryResource(); // CategoryResource | The category to create (optional) 

            try
            {
                // Create a new category
                CategoryResource result = apiInstance.CreateCategoryUsingPOST(category);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.CreateCategoryUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **category** | [**CategoryResource**](CategoryResource.md)| The category to create | [optional] 

### Return type

[**CategoryResource**](CategoryResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtemplateusingpost2"></a>
# **CreateTemplateUsingPOST2**
> TemplateResource CreateTemplateUsingPOST2 (TemplateResource template = null)

Create a category template

Templates define a type of category and the properties they have

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateTemplateUsingPOST2Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesApi();
            var template = new TemplateResource(); // TemplateResource | The template to create (optional) 

            try
            {
                // Create a category template
                TemplateResource result = apiInstance.CreateTemplateUsingPOST2(template);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.CreateTemplateUsingPOST2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **template** | [**TemplateResource**](TemplateResource.md)| The template to create | [optional] 

### Return type

[**TemplateResource**](TemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecategoryusingdelete"></a>
# **DeleteCategoryUsingDELETE**
> void DeleteCategoryUsingDELETE (string id)

Delete an existing category

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteCategoryUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesApi();
            var id = id_example;  // string | The id of the category to be deleted

            try
            {
                // Delete an existing category
                apiInstance.DeleteCategoryUsingDELETE(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.DeleteCategoryUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the category to be deleted | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetemplateusingdelete1"></a>
# **DeleteTemplateUsingDELETE1**
> void DeleteTemplateUsingDELETE1 (string id, string cascade = null)

Delete a category template

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
    public class DeleteTemplateUsingDELETE1Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | The value needed to delete used templates (optional) 

            try
            {
                // Delete a category template
                apiInstance.DeleteTemplateUsingDELETE1(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.DeleteTemplateUsingDELETE1: " + e.Message );
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

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getarticletemplatesusingget1"></a>
# **GetArticleTemplatesUsingGET1**
> PageTemplateResource GetArticleTemplatesUsingGET1 (int? size = null, int? page = null, string order = null)

List and search category templates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetArticleTemplatesUsingGET1Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | a comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to 1)

            try
            {
                // List and search category templates
                PageTemplateResource result = apiInstance.GetArticleTemplatesUsingGET1(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.GetArticleTemplatesUsingGET1: " + e.Message );
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
 **order** | **string**| a comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to 1]

### Return type

[**PageTemplateResource**](PageTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcategoriesusingget1"></a>
# **GetCategoriesUsingGET1**
> PageCategoryResource GetCategoriesUsingGET1 (string filterSearch = null, bool? filterActive = null, int? size = null, int? page = null, string order = null)

List and search categories with optional filters

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCategoriesUsingGET1Example
    {
        public void main()
        {
            
            var apiInstance = new CategoriesApi();
            var filterSearch = filterSearch_example;  // string | Filter for categories whose names begin with provided string (optional) 
            var filterActive = true;  // bool? | Filter for categories that are specifically active or inactive (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to 1)

            try
            {
                // List and search categories with optional filters
                PageCategoryResource result = apiInstance.GetCategoriesUsingGET1(filterSearch, filterActive, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.GetCategoriesUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterSearch** | **string**| Filter for categories whose names begin with provided string | [optional] 
 **filterActive** | **bool?**| Filter for categories that are specifically active or inactive | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to 1]

### Return type

[**PageCategoryResource**](PageCategoryResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcategoryusingget1"></a>
# **GetCategoryUsingGET1**
> CategoryResource GetCategoryUsingGET1 (string id)

Get a single category

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCategoryUsingGET1Example
    {
        public void main()
        {
            
            var apiInstance = new CategoriesApi();
            var id = id_example;  // string | The id of the category to retrieve

            try
            {
                // Get a single category
                CategoryResource result = apiInstance.GetCategoryUsingGET1(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.GetCategoryUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the category to retrieve | 

### Return type

[**CategoryResource**](CategoryResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettagsusingget"></a>
# **GetTagsUsingGET**
> Pagestring GetTagsUsingGET (int? size = null, int? page = null, string order = null)

List all trivia tags in the system

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTagsUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new CategoriesApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | a comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to 1)

            try
            {
                // List all trivia tags in the system
                Pagestring result = apiInstance.GetTagsUsingGET(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.GetTagsUsingGET: " + e.Message );
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
 **order** | **string**| a comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to 1]

### Return type

[**Pagestring**](Pagestring.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettemplateusingget1"></a>
# **GetTemplateUsingGET1**
> TemplateResource GetTemplateUsingGET1 (string id)

Get a single category template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTemplateUsingGET1Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single category template
                TemplateResource result = apiInstance.GetTemplateUsingGET1(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.GetTemplateUsingGET1: " + e.Message );
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

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecategoryusingput1"></a>
# **UpdateCategoryUsingPUT1**
> void UpdateCategoryUsingPUT1 (string id, CategoryResource category = null)

Update an existing category

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateCategoryUsingPUT1Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesApi();
            var id = id_example;  // string | The id of the category
            var category = new CategoryResource(); // CategoryResource | The category to update (optional) 

            try
            {
                // Update an existing category
                apiInstance.UpdateCategoryUsingPUT1(id, category);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.UpdateCategoryUsingPUT1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the category | 
 **category** | [**CategoryResource**](CategoryResource.md)| The category to update | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetemplateusingput2"></a>
# **UpdateTemplateUsingPUT2**
> void UpdateTemplateUsingPUT2 (string id, TemplateResource template = null)

Update a category template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateTemplateUsingPUT2Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesApi();
            var id = id_example;  // string | The id of the template
            var template = new TemplateResource(); // TemplateResource | The updated template information (optional) 

            try
            {
                // Update a category template
                apiInstance.UpdateTemplateUsingPUT2(id, template);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.UpdateTemplateUsingPUT2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **template** | [**TemplateResource**](TemplateResource.md)| The updated template information | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

