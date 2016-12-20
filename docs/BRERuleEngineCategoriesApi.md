# IO.Swagger.Api.BRERuleEngineCategoriesApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTemplateUsingPOST1**](BRERuleEngineCategoriesApi.md#createtemplateusingpost1) | **POST** /bre/categories/templates | Create a BRE category template
[**DeleteTemplateUsingDELETE**](BRERuleEngineCategoriesApi.md#deletetemplateusingdelete) | **DELETE** /bre/categories/templates/{id} | Delete a BRE category template
[**GetCategoriesUsingGET**](BRERuleEngineCategoriesApi.md#getcategoriesusingget) | **GET** /bre/categories | List categories
[**GetCategoryUsingGET**](BRERuleEngineCategoriesApi.md#getcategoryusingget) | **GET** /bre/categories/{name} | Get a single category
[**GetTemplateUsingGET**](BRERuleEngineCategoriesApi.md#gettemplateusingget) | **GET** /bre/categories/templates/{id} | Get a single BRE category template
[**GetTemplatesUsingGET**](BRERuleEngineCategoriesApi.md#gettemplatesusingget) | **GET** /bre/categories/templates | List and search BRE category templates
[**UpdateCategoryUsingPUT**](BRERuleEngineCategoriesApi.md#updatecategoryusingput) | **PUT** /bre/categories/{name} | Update a category
[**UpdateTemplateUsingPUT1**](BRERuleEngineCategoriesApi.md#updatetemplateusingput1) | **PUT** /bre/categories/templates/{id} | Update a BRE category template


<a name="createtemplateusingpost1"></a>
# **CreateTemplateUsingPOST1**
> TemplateResource CreateTemplateUsingPOST1 (TemplateResource template = null)

Create a BRE category template

Templates define a type of BRE category and the properties they have

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateTemplateUsingPOST1Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineCategoriesApi();
            var template = new TemplateResource(); // TemplateResource | The category template to create (optional) 

            try
            {
                // Create a BRE category template
                TemplateResource result = apiInstance.CreateTemplateUsingPOST1(template);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineCategoriesApi.CreateTemplateUsingPOST1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **template** | [**TemplateResource**](TemplateResource.md)| The category template to create | [optional] 

### Return type

[**TemplateResource**](TemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetemplateusingdelete"></a>
# **DeleteTemplateUsingDELETE**
> void DeleteTemplateUsingDELETE (string id, string cascade = null)

Delete a BRE category template

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
    public class DeleteTemplateUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineCategoriesApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | The value needed to delete used templates (optional) 

            try
            {
                // Delete a BRE category template
                apiInstance.DeleteTemplateUsingDELETE(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineCategoriesApi.DeleteTemplateUsingDELETE: " + e.Message );
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

<a name="getcategoriesusingget"></a>
# **GetCategoriesUsingGET**
> PageBreCategoryResource GetCategoriesUsingGET (int? size = null, int? page = null)

List categories

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCategoriesUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineCategoriesApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // List categories
                PageBreCategoryResource result = apiInstance.GetCategoriesUsingGET(size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineCategoriesApi.GetCategoriesUsingGET: " + e.Message );
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

### Return type

[**PageBreCategoryResource**](PageBreCategoryResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcategoryusingget"></a>
# **GetCategoryUsingGET**
> BreCategoryResource GetCategoryUsingGET (string name)

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
    public class GetCategoryUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineCategoriesApi();
            var name = name_example;  // string | The category name

            try
            {
                // Get a single category
                BreCategoryResource result = apiInstance.GetCategoryUsingGET(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineCategoriesApi.GetCategoryUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The category name | 

### Return type

[**BreCategoryResource**](BreCategoryResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettemplateusingget"></a>
# **GetTemplateUsingGET**
> TemplateResource GetTemplateUsingGET (string id)

Get a single BRE category template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTemplateUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineCategoriesApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single BRE category template
                TemplateResource result = apiInstance.GetTemplateUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineCategoriesApi.GetTemplateUsingGET: " + e.Message );
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

<a name="gettemplatesusingget"></a>
# **GetTemplatesUsingGET**
> PageTemplateResource GetTemplatesUsingGET (int? size = null, int? page = null, string order = null)

List and search BRE category templates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTemplatesUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineCategoriesApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search BRE category templates
                PageTemplateResource result = apiInstance.GetTemplatesUsingGET(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineCategoriesApi.GetTemplatesUsingGET: " + e.Message );
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

[**PageTemplateResource**](PageTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecategoryusingput"></a>
# **UpdateCategoryUsingPUT**
> void UpdateCategoryUsingPUT (string name, BreCategoryResource category = null)

Update a category

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateCategoryUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineCategoriesApi();
            var name = name_example;  // string | The category name
            var category = new BreCategoryResource(); // BreCategoryResource | The updated BRE category information (optional) 

            try
            {
                // Update a category
                apiInstance.UpdateCategoryUsingPUT(name, category);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineCategoriesApi.UpdateCategoryUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The category name | 
 **category** | [**BreCategoryResource**](BreCategoryResource.md)| The updated BRE category information | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetemplateusingput1"></a>
# **UpdateTemplateUsingPUT1**
> void UpdateTemplateUsingPUT1 (string id, TemplateResource template = null)

Update a BRE category template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateTemplateUsingPUT1Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineCategoriesApi();
            var id = id_example;  // string | The id of the template
            var template = new TemplateResource(); // TemplateResource | The updated category template definition (optional) 

            try
            {
                // Update a BRE category template
                apiInstance.UpdateTemplateUsingPUT1(id, template);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineCategoriesApi.UpdateTemplateUsingPUT1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **template** | [**TemplateResource**](TemplateResource.md)| The updated category template definition | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

