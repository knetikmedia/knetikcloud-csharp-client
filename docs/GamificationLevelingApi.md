# IO.Swagger.Api.GamificationLevelingApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChangeUserLevelExperienceUsingPUT**](GamificationLevelingApi.md#changeuserlevelexperienceusingput) | **PUT** /users/{user_id}/leveling/{name} | Update or create a leveling progress record for a user
[**CreateLevelUsingPOST**](GamificationLevelingApi.md#createlevelusingpost) | **POST** /leveling | Create a level schema
[**DeleteLevelUsingDELETE**](GamificationLevelingApi.md#deletelevelusingdelete) | **DELETE** /leveling/{name} | Delete a level
[**GetAvailableTriggersUsingGET1**](GamificationLevelingApi.md#getavailabletriggersusingget1) | **GET** /leveling/triggers | Get the list of triggers that can be used to trigger a leveling progress update
[**GetLevelUsingGET**](GamificationLevelingApi.md#getlevelusingget) | **GET** /leveling/{name} | Retrieve a particular level
[**GetLevelsUsingGET**](GamificationLevelingApi.md#getlevelsusingget) | **GET** /leveling | List and search levels
[**GetUserLevelUsingGET**](GamificationLevelingApi.md#getuserlevelusingget) | **GET** /users/{user_id}/leveling/{name} | Get a user&#39;s progress for a given level schema
[**GetUserLevelsUsingGET**](GamificationLevelingApi.md#getuserlevelsusingget) | **GET** /users/{user_id}/leveling | Get a user&#39;s progress for all level schemas
[**UpdateLevelUsingPUT**](GamificationLevelingApi.md#updatelevelusingput) | **PUT** /leveling/{name} | Update a level


<a name="changeuserlevelexperienceusingput"></a>
# **ChangeUserLevelExperienceUsingPUT**
> void ChangeUserLevelExperienceUsingPUT (int? userId, string name, int? progress = null)

Update or create a leveling progress record for a user

If no progress record yet exists for the user, it will be created. Otherwise it will be updated. If progress meets or exceeds the level's max_value it will be marked as earned and a BRE event will be triggered for the <code>BreAchievementEarnedTrigger</code>.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ChangeUserLevelExperienceUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationLevelingApi();
            var userId = 56;  // int? | The id of the user
            var name = name_example;  // string | The level schema name
            var progress = 56;  // int? | The current progress amount (optional) 

            try
            {
                // Update or create a leveling progress record for a user
                apiInstance.ChangeUserLevelExperienceUsingPUT(userId, name, progress);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationLevelingApi.ChangeUserLevelExperienceUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The id of the user | 
 **name** | **string**| The level schema name | 
 **progress** | **int?**| The current progress amount | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createlevelusingpost"></a>
# **CreateLevelUsingPOST**
> LevelingResource CreateLevelUsingPOST (LevelingResource level = null)

Create a level schema

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateLevelUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationLevelingApi();
            var level = new LevelingResource(); // LevelingResource | The level schema definition (optional) 

            try
            {
                // Create a level schema
                LevelingResource result = apiInstance.CreateLevelUsingPOST(level);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationLevelingApi.CreateLevelUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **level** | [**LevelingResource**](LevelingResource.md)| The level schema definition | [optional] 

### Return type

[**LevelingResource**](LevelingResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelevelusingdelete"></a>
# **DeleteLevelUsingDELETE**
> void DeleteLevelUsingDELETE (string name)

Delete a level

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteLevelUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationLevelingApi();
            var name = name_example;  // string | The level schema name

            try
            {
                // Delete a level
                apiInstance.DeleteLevelUsingDELETE(name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationLevelingApi.DeleteLevelUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The level schema name | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getavailabletriggersusingget1"></a>
# **GetAvailableTriggersUsingGET1**
> List<BreTriggerResource> GetAvailableTriggersUsingGET1 ()

Get the list of triggers that can be used to trigger a leveling progress update

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAvailableTriggersUsingGET1Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationLevelingApi();

            try
            {
                // Get the list of triggers that can be used to trigger a leveling progress update
                List&lt;BreTriggerResource&gt; result = apiInstance.GetAvailableTriggersUsingGET1();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationLevelingApi.GetAvailableTriggersUsingGET1: " + e.Message );
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
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlevelusingget"></a>
# **GetLevelUsingGET**
> LevelingResource GetLevelUsingGET (string name)

Retrieve a particular level

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLevelUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationLevelingApi();
            var name = name_example;  // string | The level schema name

            try
            {
                // Retrieve a particular level
                LevelingResource result = apiInstance.GetLevelUsingGET(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationLevelingApi.GetLevelUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The level schema name | 

### Return type

[**LevelingResource**](LevelingResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlevelsusingget"></a>
# **GetLevelsUsingGET**
> PageLevelingResource GetLevelsUsingGET (string filterName = null, int? size = null, int? page = null, string order = null)

List and search levels

Get a list of levels schemas with optional filtering

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLevelsUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationLevelingApi();
            var filterName = filterName_example;  // string | Filter for level schemas whose name contains a given string (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to name:ASC)

            try
            {
                // List and search levels
                PageLevelingResource result = apiInstance.GetLevelsUsingGET(filterName, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationLevelingApi.GetLevelsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterName** | **string**| Filter for level schemas whose name contains a given string | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to name:ASC]

### Return type

[**PageLevelingResource**](PageLevelingResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserlevelusingget"></a>
# **GetUserLevelUsingGET**
> UserLevelingResource GetUserLevelUsingGET (int? userId, string name)

Get a user's progress for a given level schema

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserLevelUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationLevelingApi();
            var userId = 56;  // int? | The id of the user
            var name = name_example;  // string | The level schema name

            try
            {
                // Get a user's progress for a given level schema
                UserLevelingResource result = apiInstance.GetUserLevelUsingGET(userId, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationLevelingApi.GetUserLevelUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The id of the user | 
 **name** | **string**| The level schema name | 

### Return type

[**UserLevelingResource**](UserLevelingResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserlevelsusingget"></a>
# **GetUserLevelsUsingGET**
> PageUserLevelingResource GetUserLevelsUsingGET (int? userId)

Get a user's progress for all level schemas

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserLevelsUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationLevelingApi();
            var userId = 56;  // int? | The id of the user

            try
            {
                // Get a user's progress for all level schemas
                PageUserLevelingResource result = apiInstance.GetUserLevelsUsingGET(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationLevelingApi.GetUserLevelsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The id of the user | 

### Return type

[**PageUserLevelingResource**](PageUserLevelingResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatelevelusingput"></a>
# **UpdateLevelUsingPUT**
> void UpdateLevelUsingPUT (string name, LevelingResource newLevel = null)

Update a level

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateLevelUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationLevelingApi();
            var name = name_example;  // string | The level schema name
            var newLevel = new LevelingResource(); // LevelingResource | The level schema definition (optional) 

            try
            {
                // Update a level
                apiInstance.UpdateLevelUsingPUT(name, newLevel);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationLevelingApi.UpdateLevelUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The level schema name | 
 **newLevel** | [**LevelingResource**](LevelingResource.md)| The level schema definition | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

