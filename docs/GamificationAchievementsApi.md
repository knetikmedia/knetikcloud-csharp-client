# IO.Swagger.Api.GamificationAchievementsApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAchievementUsingPOST**](GamificationAchievementsApi.md#createachievementusingpost) | **POST** /achievements | Create a new achievement definition
[**CreateTemplateUsingPOST**](GamificationAchievementsApi.md#createtemplateusingpost) | **POST** /achievements/templates | Create an achievement template
[**DeleteAchievementTemplateUsingDELETE**](GamificationAchievementsApi.md#deleteachievementtemplateusingdelete) | **DELETE** /achievements/templates/{id} | Delete an achievement template
[**DeleteAchievementUsingDELETE**](GamificationAchievementsApi.md#deleteachievementusingdelete) | **DELETE** /achievements/{name} | Delete an achievement definition
[**FindAllByGroupNameUsingGET**](GamificationAchievementsApi.md#findallbygroupnameusingget) | **GET** /achievements/derived/{name} | Get a list of derived achievements
[**GetAchievementTemplateUsingGET**](GamificationAchievementsApi.md#getachievementtemplateusingget) | **GET** /achievements/templates/{id} | Get a single achievement template
[**GetAchievementTemplatesUsingGET**](GamificationAchievementsApi.md#getachievementtemplatesusingget) | **GET** /achievements/templates | List and search achievement templates
[**GetAchievementUsingGET**](GamificationAchievementsApi.md#getachievementusingget) | **GET** /achievements/{name} | Get a single achievement definition
[**GetAchievementsUsingGET**](GamificationAchievementsApi.md#getachievementsusingget) | **GET** /achievements | Get all achievement definitions in the system
[**GetAllUserProgressForAchievementUsingGET**](GamificationAchievementsApi.md#getalluserprogressforachievementusingget) | **GET** /users/achievements/{achievement_name} | Retrieve progress on a given achievement for all users
[**GetAllUserProgressUsingGET**](GamificationAchievementsApi.md#getalluserprogressusingget) | **GET** /users/achievements | Retrieve progress on achievements for all users
[**GetAvailableTriggersUsingGET**](GamificationAchievementsApi.md#getavailabletriggersusingget) | **GET** /achievements/triggers | Get the list of triggers that can be used to trigger an achievement progress update
[**GetUserProgressForAchievementUsingGET**](GamificationAchievementsApi.md#getuserprogressforachievementusingget) | **GET** /users/{user_id}/achievements/{achievement_name} | Retrieve progress on a given achievement for a given user
[**GetUserProgressUsingGET**](GamificationAchievementsApi.md#getuserprogressusingget) | **GET** /users/{user_id}/achievements | Retrieve progress on achievements for a given user
[**UpdateAchievementUsingPUT**](GamificationAchievementsApi.md#updateachievementusingput) | **PUT** /achievements/{name} | Update an achievement definition
[**UpdateProgressUsingPUT**](GamificationAchievementsApi.md#updateprogressusingput) | **PUT** /users/{user_id}/achievements/{achievement_name} | Update or create an achievement progress record for a user
[**UpdateTemplateUsingPUT**](GamificationAchievementsApi.md#updatetemplateusingput) | **PUT** /achievements/templates/{id} | Update an achievement template


<a name="createachievementusingpost"></a>
# **CreateAchievementUsingPOST**
> AchievementDefinitionResource CreateAchievementUsingPOST (AchievementDefinitionResource achievement = null)

Create a new achievement definition

If the definition contains a trigger event name, a BRE rule is created, so that tracking logic is executed when the triggering event occurs. If no trigger event name is specified, the user's achievement status must manually be updated via the API.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateAchievementUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationAchievementsApi();
            var achievement = new AchievementDefinitionResource(); // AchievementDefinitionResource | The achievement definition (optional) 

            try
            {
                // Create a new achievement definition
                AchievementDefinitionResource result = apiInstance.CreateAchievementUsingPOST(achievement);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationAchievementsApi.CreateAchievementUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **achievement** | [**AchievementDefinitionResource**](AchievementDefinitionResource.md)| The achievement definition | [optional] 

### Return type

[**AchievementDefinitionResource**](AchievementDefinitionResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtemplateusingpost"></a>
# **CreateTemplateUsingPOST**
> TemplateResource CreateTemplateUsingPOST (TemplateResource template = null)

Create an achievement template

Achievement templates define a type of achievement and the properties they have

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateTemplateUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationAchievementsApi();
            var template = new TemplateResource(); // TemplateResource | The achievement template to be created (optional) 

            try
            {
                // Create an achievement template
                TemplateResource result = apiInstance.CreateTemplateUsingPOST(template);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationAchievementsApi.CreateTemplateUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **template** | [**TemplateResource**](TemplateResource.md)| The achievement template to be created | [optional] 

### Return type

[**TemplateResource**](TemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteachievementtemplateusingdelete"></a>
# **DeleteAchievementTemplateUsingDELETE**
> void DeleteAchievementTemplateUsingDELETE (string id, string cascade = null)

Delete an achievement template

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
    public class DeleteAchievementTemplateUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationAchievementsApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | The value needed to delete used templates (optional) 

            try
            {
                // Delete an achievement template
                apiInstance.DeleteAchievementTemplateUsingDELETE(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationAchievementsApi.DeleteAchievementTemplateUsingDELETE: " + e.Message );
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
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteachievementusingdelete"></a>
# **DeleteAchievementUsingDELETE**
> void DeleteAchievementUsingDELETE (string name)

Delete an achievement definition

Will also disable the associated generated rule, if any.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAchievementUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationAchievementsApi();
            var name = name_example;  // string | The name of the achievement

            try
            {
                // Delete an achievement definition
                apiInstance.DeleteAchievementUsingDELETE(name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationAchievementsApi.DeleteAchievementUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the achievement | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findallbygroupnameusingget"></a>
# **FindAllByGroupNameUsingGET**
> List<AchievementDefinitionResource> FindAllByGroupNameUsingGET (string name)

Get a list of derived achievements

Used by other services that depend on achievements

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FindAllByGroupNameUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationAchievementsApi();
            var name = name_example;  // string | The name of the derived achievement

            try
            {
                // Get a list of derived achievements
                List&lt;AchievementDefinitionResource&gt; result = apiInstance.FindAllByGroupNameUsingGET(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationAchievementsApi.FindAllByGroupNameUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the derived achievement | 

### Return type

[**List<AchievementDefinitionResource>**](AchievementDefinitionResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getachievementtemplateusingget"></a>
# **GetAchievementTemplateUsingGET**
> TemplateResource GetAchievementTemplateUsingGET (string id)

Get a single achievement template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAchievementTemplateUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationAchievementsApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single achievement template
                TemplateResource result = apiInstance.GetAchievementTemplateUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationAchievementsApi.GetAchievementTemplateUsingGET: " + e.Message );
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
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getachievementtemplatesusingget"></a>
# **GetAchievementTemplatesUsingGET**
> PageResourceTemplateResource GetAchievementTemplatesUsingGET (int? size = null, int? page = null, string order = null)

List and search achievement templates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAchievementTemplatesUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationAchievementsApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search achievement templates
                PageResourceTemplateResource result = apiInstance.GetAchievementTemplatesUsingGET(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationAchievementsApi.GetAchievementTemplatesUsingGET: " + e.Message );
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

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getachievementusingget"></a>
# **GetAchievementUsingGET**
> AchievementDefinitionResource GetAchievementUsingGET (string name)

Get a single achievement definition

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAchievementUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationAchievementsApi();
            var name = name_example;  // string | The name of the achievement

            try
            {
                // Get a single achievement definition
                AchievementDefinitionResource result = apiInstance.GetAchievementUsingGET(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationAchievementsApi.GetAchievementUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the achievement | 

### Return type

[**AchievementDefinitionResource**](AchievementDefinitionResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getachievementsusingget"></a>
# **GetAchievementsUsingGET**
> PageResourceAchievementDefinitionResource GetAchievementsUsingGET (string filterTagset = null, string filterName = null, bool? filterHidden = null, bool? filterDerived = null, int? size = null, int? page = null, string order = null)

Get all achievement definitions in the system

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAchievementsUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationAchievementsApi();
            var filterTagset = filterTagset_example;  // string | Filter for achievements with specified tags (separated by comma) (optional) 
            var filterName = filterName_example;  // string | Filter for achievements whose name contains a string (optional) 
            var filterHidden = true;  // bool? | Filter for achievements that are hidden or not (optional) 
            var filterDerived = true;  // bool? | Filter for achievements that are derived from other services (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to name:ASC)

            try
            {
                // Get all achievement definitions in the system
                PageResourceAchievementDefinitionResource result = apiInstance.GetAchievementsUsingGET(filterTagset, filterName, filterHidden, filterDerived, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationAchievementsApi.GetAchievementsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterTagset** | **string**| Filter for achievements with specified tags (separated by comma) | [optional] 
 **filterName** | **string**| Filter for achievements whose name contains a string | [optional] 
 **filterHidden** | **bool?**| Filter for achievements that are hidden or not | [optional] 
 **filterDerived** | **bool?**| Filter for achievements that are derived from other services | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to name:ASC]

### Return type

[**PageResourceAchievementDefinitionResource**](PageResourceAchievementDefinitionResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalluserprogressforachievementusingget"></a>
# **GetAllUserProgressForAchievementUsingGET**
> PageResourceUserAchievementGroupResource GetAllUserProgressForAchievementUsingGET (string achievementName, bool? filterAchievementDerived = null, string filterAchievementTagset = null, bool? filterAchievementHidden = null, int? size = null, int? page = null)

Retrieve progress on a given achievement for all users

Assets will not be filled in on the resources returned. Use 'Get single achievement progress for user' to retrieve the full resource with assets for a given user as needed.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllUserProgressForAchievementUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationAchievementsApi();
            var achievementName = achievementName_example;  // string | The achievement's name
            var filterAchievementDerived = true;  // bool? | Filter for achievements that are derived from other services (optional) 
            var filterAchievementTagset = filterAchievementTagset_example;  // string | Filter for achievements with specified tags (separated by comma) (optional) 
            var filterAchievementHidden = true;  // bool? | Filter for achievements that are hidden or not (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Retrieve progress on a given achievement for all users
                PageResourceUserAchievementGroupResource result = apiInstance.GetAllUserProgressForAchievementUsingGET(achievementName, filterAchievementDerived, filterAchievementTagset, filterAchievementHidden, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationAchievementsApi.GetAllUserProgressForAchievementUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **achievementName** | **string**| The achievement&#39;s name | 
 **filterAchievementDerived** | **bool?**| Filter for achievements that are derived from other services | [optional] 
 **filterAchievementTagset** | **string**| Filter for achievements with specified tags (separated by comma) | [optional] 
 **filterAchievementHidden** | **bool?**| Filter for achievements that are hidden or not | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceUserAchievementGroupResource**](PageResourceUserAchievementGroupResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalluserprogressusingget"></a>
# **GetAllUserProgressUsingGET**
> PageResourceUserAchievementGroupResource GetAllUserProgressUsingGET (bool? filterAchievementDerived = null, string filterAchievementTagset = null, string filterAchievementName = null, bool? filterAchievementHidden = null, int? size = null, int? page = null)

Retrieve progress on achievements for all users

Assets will not be filled in on the resources returned. Use 'Get single achievement progress for user' to retrieve the full resource with assets for a given user as needed.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllUserProgressUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationAchievementsApi();
            var filterAchievementDerived = true;  // bool? | Filter for achievements that are derived from other services (optional) 
            var filterAchievementTagset = filterAchievementTagset_example;  // string | Filter for achievements with specified tags (separated by comma) (optional) 
            var filterAchievementName = filterAchievementName_example;  // string | Filter for achievements whose name contains a string (optional) 
            var filterAchievementHidden = true;  // bool? | Filter for achievements that are hidden or not (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Retrieve progress on achievements for all users
                PageResourceUserAchievementGroupResource result = apiInstance.GetAllUserProgressUsingGET(filterAchievementDerived, filterAchievementTagset, filterAchievementName, filterAchievementHidden, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationAchievementsApi.GetAllUserProgressUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterAchievementDerived** | **bool?**| Filter for achievements that are derived from other services | [optional] 
 **filterAchievementTagset** | **string**| Filter for achievements with specified tags (separated by comma) | [optional] 
 **filterAchievementName** | **string**| Filter for achievements whose name contains a string | [optional] 
 **filterAchievementHidden** | **bool?**| Filter for achievements that are hidden or not | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceUserAchievementGroupResource**](PageResourceUserAchievementGroupResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getavailabletriggersusingget"></a>
# **GetAvailableTriggersUsingGET**
> List<BreTriggerResource> GetAvailableTriggersUsingGET ()

Get the list of triggers that can be used to trigger an achievement progress update

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAvailableTriggersUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationAchievementsApi();

            try
            {
                // Get the list of triggers that can be used to trigger an achievement progress update
                List&lt;BreTriggerResource&gt; result = apiInstance.GetAvailableTriggersUsingGET();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationAchievementsApi.GetAvailableTriggersUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<BreTriggerResource>**](BreTriggerResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserprogressforachievementusingget"></a>
# **GetUserProgressForAchievementUsingGET**
> UserAchievementGroupResource GetUserProgressForAchievementUsingGET (int? userId, string achievementName)

Retrieve progress on a given achievement for a given user

Assets will not be filled in on the resources returned. Use 'Get a single poll' to retrieve the full resource with assets for a given item as needed.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserProgressForAchievementUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationAchievementsApi();
            var userId = 56;  // int? | The user's id
            var achievementName = achievementName_example;  // string | The achievement's name

            try
            {
                // Retrieve progress on a given achievement for a given user
                UserAchievementGroupResource result = apiInstance.GetUserProgressForAchievementUsingGET(userId, achievementName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationAchievementsApi.GetUserProgressForAchievementUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The user&#39;s id | 
 **achievementName** | **string**| The achievement&#39;s name | 

### Return type

[**UserAchievementGroupResource**](UserAchievementGroupResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserprogressusingget"></a>
# **GetUserProgressUsingGET**
> PageResourceUserAchievementGroupResource GetUserProgressUsingGET (int? userId, bool? filterAchievementDerived = null, string filterAchievementTagset = null, string filterAchievementName = null, bool? filterAchievementHidden = null, int? size = null, int? page = null)

Retrieve progress on achievements for a given user

Assets will not be filled in on the resources returned. Use 'Get a single poll' to retrieve the full resource with assets for a given item as needed.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserProgressUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationAchievementsApi();
            var userId = 56;  // int? | The user's id
            var filterAchievementDerived = true;  // bool? | Filter for achievements that are derived from other services (optional) 
            var filterAchievementTagset = filterAchievementTagset_example;  // string | Filter for achievements with specified tags (separated by comma) (optional) 
            var filterAchievementName = filterAchievementName_example;  // string | Filter for achievements whose name contains a string (optional) 
            var filterAchievementHidden = true;  // bool? | Filter for achievements that are hidden or not (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Retrieve progress on achievements for a given user
                PageResourceUserAchievementGroupResource result = apiInstance.GetUserProgressUsingGET(userId, filterAchievementDerived, filterAchievementTagset, filterAchievementName, filterAchievementHidden, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationAchievementsApi.GetUserProgressUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The user&#39;s id | 
 **filterAchievementDerived** | **bool?**| Filter for achievements that are derived from other services | [optional] 
 **filterAchievementTagset** | **string**| Filter for achievements with specified tags (separated by comma) | [optional] 
 **filterAchievementName** | **string**| Filter for achievements whose name contains a string | [optional] 
 **filterAchievementHidden** | **bool?**| Filter for achievements that are hidden or not | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceUserAchievementGroupResource**](PageResourceUserAchievementGroupResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateachievementusingput"></a>
# **UpdateAchievementUsingPUT**
> void UpdateAchievementUsingPUT (string name, AchievementDefinitionResource achievement = null)

Update an achievement definition

The existing generated rule, if any, will be deleted. A new rule will be created if a trigger event name is specified in the new version.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateAchievementUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationAchievementsApi();
            var name = name_example;  // string | The name of the achievement
            var achievement = new AchievementDefinitionResource(); // AchievementDefinitionResource | The achievement definition (optional) 

            try
            {
                // Update an achievement definition
                apiInstance.UpdateAchievementUsingPUT(name, achievement);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationAchievementsApi.UpdateAchievementUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the achievement | 
 **achievement** | [**AchievementDefinitionResource**](AchievementDefinitionResource.md)| The achievement definition | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateprogressusingput"></a>
# **UpdateProgressUsingPUT**
> UserAchievementGroupResource UpdateProgressUsingPUT (int? userId, string achievementName, AchievementProgressUpdateRequest request = null)

Update or create an achievement progress record for a user

If no progress record yet exists for the user, it will be created. Otherwise it will be updated. If progress meets or exceeds the achievement's max_value it will be marked as earned and a BRE event will be triggered for the <code>BreAchievementEarnedTrigger</code>.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateProgressUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationAchievementsApi();
            var userId = 56;  // int? | The user's id
            var achievementName = achievementName_example;  // string | The achievement's name
            var request = new AchievementProgressUpdateRequest(); // AchievementProgressUpdateRequest | The progress update details (optional) 

            try
            {
                // Update or create an achievement progress record for a user
                UserAchievementGroupResource result = apiInstance.UpdateProgressUsingPUT(userId, achievementName, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationAchievementsApi.UpdateProgressUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The user&#39;s id | 
 **achievementName** | **string**| The achievement&#39;s name | 
 **request** | [**AchievementProgressUpdateRequest**](AchievementProgressUpdateRequest.md)| The progress update details | [optional] 

### Return type

[**UserAchievementGroupResource**](UserAchievementGroupResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetemplateusingput"></a>
# **UpdateTemplateUsingPUT**
> void UpdateTemplateUsingPUT (string id, TemplateResource template = null)

Update an achievement template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateTemplateUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationAchievementsApi();
            var id = id_example;  // string | The id of the template
            var template = new TemplateResource(); // TemplateResource | The updated template (optional) 

            try
            {
                // Update an achievement template
                apiInstance.UpdateTemplateUsingPUT(id, template);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationAchievementsApi.UpdateTemplateUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **template** | [**TemplateResource**](TemplateResource.md)| The updated template | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

