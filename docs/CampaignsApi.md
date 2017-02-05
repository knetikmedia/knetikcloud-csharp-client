# IO.Swagger.Api.CampaignsApi

All URIs are relative to *https://integration.knetikcloud.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddChallengesUsingPOST**](CampaignsApi.md#addchallengesusingpost) | **POST** /campaigns/{id}/challenges | Add a challenge to a campaign
[**CreateCampaignTemplateUsingPOST**](CampaignsApi.md#createcampaigntemplateusingpost) | **POST** /campaigns/templates | Create a campaign template
[**CreateCampaignUsingPOST**](CampaignsApi.md#createcampaignusingpost) | **POST** /campaigns | Create a campaign
[**DeleteCampaignTemplateUsingDELETE**](CampaignsApi.md#deletecampaigntemplateusingdelete) | **DELETE** /campaigns/templates/{id} | Delete a campaign template
[**DeleteCampaignUsingDELETE**](CampaignsApi.md#deletecampaignusingdelete) | **DELETE** /campaigns/{id} | Delete a campaign
[**GetCampaignTemplateUsingGET**](CampaignsApi.md#getcampaigntemplateusingget) | **GET** /campaigns/templates/{id} | Get a single campaign template
[**GetCampaignTemplatesUsingGET**](CampaignsApi.md#getcampaigntemplatesusingget) | **GET** /campaigns/templates | List and search campaign templates
[**GetCampaignUsingGET**](CampaignsApi.md#getcampaignusingget) | **GET** /campaigns/{id} | Returns a single campaign
[**GetCampaignsUsingGET**](CampaignsApi.md#getcampaignsusingget) | **GET** /campaigns | List and search campaigns
[**GetChallengesUsingGET**](CampaignsApi.md#getchallengesusingget) | **GET** /campaigns/{id}/challenges | List the challenges associated with a campaign
[**RemoveChallengeUsingDELETE**](CampaignsApi.md#removechallengeusingdelete) | **DELETE** /campaigns/{campaign_id}/challenges/{id} | Remove a challenge from a campaign
[**UpdateCampaignTemplateUsingPUT**](CampaignsApi.md#updatecampaigntemplateusingput) | **PUT** /campaigns/templates/{id} | Update an campaign template
[**UpdateCampaignUsingPUT**](CampaignsApi.md#updatecampaignusingput) | **PUT** /campaigns/{id} | Update a campaign


<a name="addchallengesusingpost"></a>
# **AddChallengesUsingPOST**
> void AddChallengesUsingPOST (long? id, long? challengeId = null)

Add a challenge to a campaign

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddChallengesUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var id = 789;  // long? | The id of the campaign
            var challengeId = 789;  // long? | The id of the challenge (optional) 

            try
            {
                // Add a challenge to a campaign
                apiInstance.AddChallengesUsingPOST(id, challengeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsApi.AddChallengesUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The id of the campaign | 
 **challengeId** | **long?**| The id of the challenge | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcampaigntemplateusingpost"></a>
# **CreateCampaignTemplateUsingPOST**
> TemplateResource CreateCampaignTemplateUsingPOST (TemplateResource campaignTemplateResource = null)

Create a campaign template

Campaign Templates define a type of campaign and the properties they have

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateCampaignTemplateUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var campaignTemplateResource = new TemplateResource(); // TemplateResource | The campaign template resource object (optional) 

            try
            {
                // Create a campaign template
                TemplateResource result = apiInstance.CreateCampaignTemplateUsingPOST(campaignTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsApi.CreateCampaignTemplateUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignTemplateResource** | [**TemplateResource**](TemplateResource.md)| The campaign template resource object | [optional] 

### Return type

[**TemplateResource**](TemplateResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcampaignusingpost"></a>
# **CreateCampaignUsingPOST**
> CampaignResource CreateCampaignUsingPOST (CampaignResource campaignResource = null)

Create a campaign

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateCampaignUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var campaignResource = new CampaignResource(); // CampaignResource | The campaign resource object (optional) 

            try
            {
                // Create a campaign
                CampaignResource result = apiInstance.CreateCampaignUsingPOST(campaignResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsApi.CreateCampaignUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignResource** | [**CampaignResource**](CampaignResource.md)| The campaign resource object | [optional] 

### Return type

[**CampaignResource**](CampaignResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecampaigntemplateusingdelete"></a>
# **DeleteCampaignTemplateUsingDELETE**
> void DeleteCampaignTemplateUsingDELETE (string id, string cascade = null)

Delete a campaign template

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
    public class DeleteCampaignTemplateUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | The value needed to delete used templates (optional) 

            try
            {
                // Delete a campaign template
                apiInstance.DeleteCampaignTemplateUsingDELETE(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsApi.DeleteCampaignTemplateUsingDELETE: " + e.Message );
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

<a name="deletecampaignusingdelete"></a>
# **DeleteCampaignUsingDELETE**
> void DeleteCampaignUsingDELETE (long? id)

Delete a campaign

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteCampaignUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var id = 789;  // long? | The campaign id

            try
            {
                // Delete a campaign
                apiInstance.DeleteCampaignUsingDELETE(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsApi.DeleteCampaignUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The campaign id | 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcampaigntemplateusingget"></a>
# **GetCampaignTemplateUsingGET**
> TemplateResource GetCampaignTemplateUsingGET (string id)

Get a single campaign template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCampaignTemplateUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single campaign template
                TemplateResource result = apiInstance.GetCampaignTemplateUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsApi.GetCampaignTemplateUsingGET: " + e.Message );
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

<a name="getcampaigntemplatesusingget"></a>
# **GetCampaignTemplatesUsingGET**
> PageResourceTemplateResource GetCampaignTemplatesUsingGET (int? size = null, int? page = null, string order = null)

List and search campaign templates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCampaignTemplatesUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search campaign templates
                PageResourceTemplateResource result = apiInstance.GetCampaignTemplatesUsingGET(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsApi.GetCampaignTemplatesUsingGET: " + e.Message );
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

<a name="getcampaignusingget"></a>
# **GetCampaignUsingGET**
> CampaignResource GetCampaignUsingGET (long? id)

Returns a single campaign

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCampaignUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new CampaignsApi();
            var id = 789;  // long? | The campaign id

            try
            {
                // Returns a single campaign
                CampaignResource result = apiInstance.GetCampaignUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsApi.GetCampaignUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The campaign id | 

### Return type

[**CampaignResource**](CampaignResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcampaignsusingget"></a>
# **GetCampaignsUsingGET**
> PageResourceCampaignResource GetCampaignsUsingGET (bool? filterActive = null, int? size = null, int? page = null, string order = null)

List and search campaigns

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCampaignsUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new CampaignsApi();
            var filterActive = true;  // bool? | Filter for campaigns that are active (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search campaigns
                PageResourceCampaignResource result = apiInstance.GetCampaignsUsingGET(filterActive, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsApi.GetCampaignsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterActive** | **bool?**| Filter for campaigns that are active | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourceCampaignResource**](PageResourceCampaignResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchallengesusingget"></a>
# **GetChallengesUsingGET**
> PageResourceChallengeResource GetChallengesUsingGET (long? id)

List the challenges associated with a campaign

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChallengesUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new CampaignsApi();
            var id = 789;  // long? | The campaign id

            try
            {
                // List the challenges associated with a campaign
                PageResourceChallengeResource result = apiInstance.GetChallengesUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsApi.GetChallengesUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The campaign id | 

### Return type

[**PageResourceChallengeResource**](PageResourceChallengeResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removechallengeusingdelete"></a>
# **RemoveChallengeUsingDELETE**
> void RemoveChallengeUsingDELETE (long? campaignId, long? id)

Remove a challenge from a campaign

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemoveChallengeUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var campaignId = 789;  // long? | The campaign id
            var id = 789;  // long? | The challenge id

            try
            {
                // Remove a challenge from a campaign
                apiInstance.RemoveChallengeUsingDELETE(campaignId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsApi.RemoveChallengeUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignId** | **long?**| The campaign id | 
 **id** | **long?**| The challenge id | 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecampaigntemplateusingput"></a>
# **UpdateCampaignTemplateUsingPUT**
> void UpdateCampaignTemplateUsingPUT (string id, TemplateResource campaignTemplateResource = null)

Update an campaign template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateCampaignTemplateUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var id = id_example;  // string | The id of the template
            var campaignTemplateResource = new TemplateResource(); // TemplateResource | The campaign template resource object (optional) 

            try
            {
                // Update an campaign template
                apiInstance.UpdateCampaignTemplateUsingPUT(id, campaignTemplateResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsApi.UpdateCampaignTemplateUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **campaignTemplateResource** | [**TemplateResource**](TemplateResource.md)| The campaign template resource object | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecampaignusingput"></a>
# **UpdateCampaignUsingPUT**
> void UpdateCampaignUsingPUT (long? id, CampaignResource campaignResource = null)

Update a campaign

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateCampaignUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var id = 789;  // long? | The campaign id
            var campaignResource = new CampaignResource(); // CampaignResource | The campaign resource object (optional) 

            try
            {
                // Update a campaign
                apiInstance.UpdateCampaignUsingPUT(id, campaignResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsApi.UpdateCampaignUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The campaign id | 
 **campaignResource** | [**CampaignResource**](CampaignResource.md)| The campaign resource object | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

