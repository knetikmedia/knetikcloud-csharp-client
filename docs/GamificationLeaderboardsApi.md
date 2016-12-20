# IO.Swagger.Api.GamificationLeaderboardsApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetLeaderboardUsingGET**](GamificationLeaderboardsApi.md#getleaderboardusingget) | **GET** /leaderboards/{context_type}/{context_id} | Retrieves leaderboard details and paginated entries
[**GetStrategiesUsingGET**](GamificationLeaderboardsApi.md#getstrategiesusingget) | **GET** /leaderboards/strategies | Get a list of available leaderboard strategy names
[**GetUserRankUsingGET**](GamificationLeaderboardsApi.md#getuserrankusingget) | **GET** /leaderboards/{context_type}/{context_id}/users/{id}/rank | Retrieves a specific user entry with rank


<a name="getleaderboardusingget"></a>
# **GetLeaderboardUsingGET**
> LeaderboardResource GetLeaderboardUsingGET (string contextType, string contextId, int? size = null, int? page = null)

Retrieves leaderboard details and paginated entries

The context type identifies the type of entity (i.e., 'activity') being tracked on the leaderboard. The context ID is the unique ID of the actual entity tracked by the leaderboard.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLeaderboardUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new GamificationLeaderboardsApi();
            var contextType = contextType_example;  // string | The context type for the leaderboard
            var contextId = contextId_example;  // string | The context id for the leaderboard
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Retrieves leaderboard details and paginated entries
                LeaderboardResource result = apiInstance.GetLeaderboardUsingGET(contextType, contextId, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationLeaderboardsApi.GetLeaderboardUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contextType** | **string**| The context type for the leaderboard | 
 **contextId** | **string**| The context id for the leaderboard | 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**LeaderboardResource**](LeaderboardResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstrategiesusingget"></a>
# **GetStrategiesUsingGET**
> List<string> GetStrategiesUsingGET ()

Get a list of available leaderboard strategy names

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStrategiesUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new GamificationLeaderboardsApi();

            try
            {
                // Get a list of available leaderboard strategy names
                List&lt;string&gt; result = apiInstance.GetStrategiesUsingGET();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationLeaderboardsApi.GetStrategiesUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserrankusingget"></a>
# **GetUserRankUsingGET**
> LeaderboardEntryResource GetUserRankUsingGET (string contextType, string contextId, string id)

Retrieves a specific user entry with rank

The context type identifies the type of entity (i.e., 'activity') being tracked on the leaderboard. The context ID is the unique ID of the actual entity tracked by the leaderboard.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserRankUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new GamificationLeaderboardsApi();
            var contextType = contextType_example;  // string | The context type for the leaderboard
            var contextId = contextId_example;  // string | The context id for the leaderboard
            var id = id_example;  // string | The id of a user

            try
            {
                // Retrieves a specific user entry with rank
                LeaderboardEntryResource result = apiInstance.GetUserRankUsingGET(contextType, contextId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationLeaderboardsApi.GetUserRankUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contextType** | **string**| The context type for the leaderboard | 
 **contextId** | **string**| The context id for the leaderboard | 
 **id** | **string**| The id of a user | 

### Return type

[**LeaderboardEntryResource**](LeaderboardEntryResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

