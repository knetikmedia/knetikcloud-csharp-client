# IO.Swagger.Api.ContentPollsApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AnswerPollUsingPOST**](ContentPollsApi.md#answerpollusingpost) | **POST** /media/polls/{id}/response | Add your vote to a poll
[**CreatePollTemplateUsingPOST**](ContentPollsApi.md#createpolltemplateusingpost) | **POST** /media/polls/templates | Create a poll template
[**CreatePollUsingPOST**](ContentPollsApi.md#createpollusingpost) | **POST** /media/polls | Create a new poll
[**DeletePollTemplateUsingDELETE**](ContentPollsApi.md#deletepolltemplateusingdelete) | **DELETE** /media/polls/templates/{id} | Delete a poll template
[**DeletePollUsingDELETE**](ContentPollsApi.md#deletepollusingdelete) | **DELETE** /media/polls/{id} | Delete an existing poll
[**GetPollAnswerUsingGET**](ContentPollsApi.md#getpollanswerusingget) | **GET** /media/polls/{id}/response | Get poll answer
[**GetPollTemplateUsingGET**](ContentPollsApi.md#getpolltemplateusingget) | **GET** /media/polls/templates/{id} | Get a single poll template
[**GetPollTemplatesUsingGET**](ContentPollsApi.md#getpolltemplatesusingget) | **GET** /media/polls/templates | List and search poll templates
[**GetPollUsingGET**](ContentPollsApi.md#getpollusingget) | **GET** /media/polls/{id} | Get a single poll
[**GetPollsUsingGET**](ContentPollsApi.md#getpollsusingget) | **GET** /media/polls | List and search polls
[**UpdatePollTemplateUsingPUT**](ContentPollsApi.md#updatepolltemplateusingput) | **PUT** /media/polls/templates/{id} | Update a poll template
[**UpdatePollUsingPUT**](ContentPollsApi.md#updatepollusingput) | **PUT** /media/polls/{id} | Update an existing poll


<a name="answerpollusingpost"></a>
# **AnswerPollUsingPOST**
> PollResponseResource AnswerPollUsingPOST (string id, string answerKey = null)

Add your vote to a poll

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AnswerPollUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContentPollsApi();
            var id = id_example;  // string | The poll id
            var answerKey = answerKey_example;  // string | The answer key (optional) 

            try
            {
                // Add your vote to a poll
                PollResponseResource result = apiInstance.AnswerPollUsingPOST(id, answerKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentPollsApi.AnswerPollUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The poll id | 
 **answerKey** | **string**| The answer key | [optional] 

### Return type

[**PollResponseResource**](PollResponseResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createpolltemplateusingpost"></a>
# **CreatePollTemplateUsingPOST**
> TemplateResource CreatePollTemplateUsingPOST (TemplateResource pollTemplateResource = null)

Create a poll template

Poll templates define a type of poll and the properties they have

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreatePollTemplateUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContentPollsApi();
            var pollTemplateResource = new TemplateResource(); // TemplateResource | The poll template resource object (optional) 

            try
            {
                // Create a poll template
                TemplateResource result = apiInstance.CreatePollTemplateUsingPOST(pollTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentPollsApi.CreatePollTemplateUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pollTemplateResource** | [**TemplateResource**](TemplateResource.md)| The poll template resource object | [optional] 

### Return type

[**TemplateResource**](TemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createpollusingpost"></a>
# **CreatePollUsingPOST**
> PollResource CreatePollUsingPOST (PollResource pollResource = null)

Create a new poll

Polls are blobs of text with titles, a category and assets. Formatting and display of the text is in the hands of the front end.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreatePollUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContentPollsApi();
            var pollResource = new PollResource(); // PollResource | The poll object (optional) 

            try
            {
                // Create a new poll
                PollResource result = apiInstance.CreatePollUsingPOST(pollResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentPollsApi.CreatePollUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pollResource** | [**PollResource**](PollResource.md)| The poll object | [optional] 

### Return type

[**PollResource**](PollResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepolltemplateusingdelete"></a>
# **DeletePollTemplateUsingDELETE**
> void DeletePollTemplateUsingDELETE (string id, string cascade = null)

Delete a poll template

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
    public class DeletePollTemplateUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContentPollsApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | The value needed to delete used templates (optional) 

            try
            {
                // Delete a poll template
                apiInstance.DeletePollTemplateUsingDELETE(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentPollsApi.DeletePollTemplateUsingDELETE: " + e.Message );
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

<a name="deletepollusingdelete"></a>
# **DeletePollUsingDELETE**
> void DeletePollUsingDELETE (string id)

Delete an existing poll

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeletePollUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContentPollsApi();
            var id = id_example;  // string | The poll id

            try
            {
                // Delete an existing poll
                apiInstance.DeletePollUsingDELETE(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentPollsApi.DeletePollUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The poll id | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpollanswerusingget"></a>
# **GetPollAnswerUsingGET**
> PollResponseResource GetPollAnswerUsingGET (string id)

Get poll answer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPollAnswerUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContentPollsApi();
            var id = id_example;  // string | The poll id

            try
            {
                // Get poll answer
                PollResponseResource result = apiInstance.GetPollAnswerUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentPollsApi.GetPollAnswerUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The poll id | 

### Return type

[**PollResponseResource**](PollResponseResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpolltemplateusingget"></a>
# **GetPollTemplateUsingGET**
> TemplateResource GetPollTemplateUsingGET (string id)

Get a single poll template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPollTemplateUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContentPollsApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single poll template
                TemplateResource result = apiInstance.GetPollTemplateUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentPollsApi.GetPollTemplateUsingGET: " + e.Message );
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

<a name="getpolltemplatesusingget"></a>
# **GetPollTemplatesUsingGET**
> PageTemplateResource GetPollTemplatesUsingGET (int? size = null, int? page = null, string order = null)

List and search poll templates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPollTemplatesUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContentPollsApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to 1)

            try
            {
                // List and search poll templates
                PageTemplateResource result = apiInstance.GetPollTemplatesUsingGET(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentPollsApi.GetPollTemplatesUsingGET: " + e.Message );
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
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to 1]

### Return type

[**PageTemplateResource**](PageTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpollusingget"></a>
# **GetPollUsingGET**
> PollResource GetPollUsingGET (string id)

Get a single poll

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPollUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new ContentPollsApi();
            var id = id_example;  // string | The poll id

            try
            {
                // Get a single poll
                PollResource result = apiInstance.GetPollUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentPollsApi.GetPollUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The poll id | 

### Return type

[**PollResource**](PollResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpollsusingget"></a>
# **GetPollsUsingGET**
> PagePollResource GetPollsUsingGET (string filterCategory = null, string filterTagset = null, string filterText = null, int? size = null, int? page = null, string order = null)

List and search polls

Get a list of polls with optional filtering. Assets will not be filled in on the resources returned. Use 'Get a single poll' to retrieve the full resource with assets for a given item as needed.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPollsUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new ContentPollsApi();
            var filterCategory = filterCategory_example;  // string | Filter for polls from a specific category by id (optional) 
            var filterTagset = filterTagset_example;  // string | Filter for polls with specified tags (separated by comma) (optional) 
            var filterText = filterText_example;  // string | Filter for polls whose text contains a string (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to 1)

            try
            {
                // List and search polls
                PagePollResource result = apiInstance.GetPollsUsingGET(filterCategory, filterTagset, filterText, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentPollsApi.GetPollsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterCategory** | **string**| Filter for polls from a specific category by id | [optional] 
 **filterTagset** | **string**| Filter for polls with specified tags (separated by comma) | [optional] 
 **filterText** | **string**| Filter for polls whose text contains a string | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to 1]

### Return type

[**PagePollResource**](PagePollResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepolltemplateusingput"></a>
# **UpdatePollTemplateUsingPUT**
> void UpdatePollTemplateUsingPUT (string id, TemplateResource pollTemplateResource = null)

Update a poll template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdatePollTemplateUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContentPollsApi();
            var id = id_example;  // string | The id of the template
            var pollTemplateResource = new TemplateResource(); // TemplateResource | The poll template resource object (optional) 

            try
            {
                // Update a poll template
                apiInstance.UpdatePollTemplateUsingPUT(id, pollTemplateResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentPollsApi.UpdatePollTemplateUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **pollTemplateResource** | [**TemplateResource**](TemplateResource.md)| The poll template resource object | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepollusingput"></a>
# **UpdatePollUsingPUT**
> void UpdatePollUsingPUT (string id, PollResource pollResource = null)

Update an existing poll

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdatePollUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContentPollsApi();
            var id = id_example;  // string | The poll id
            var pollResource = new PollResource(); // PollResource | The poll object (optional) 

            try
            {
                // Update an existing poll
                apiInstance.UpdatePollUsingPUT(id, pollResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentPollsApi.UpdatePollUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The poll id | 
 **pollResource** | [**PollResource**](PollResource.md)| The poll object | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

