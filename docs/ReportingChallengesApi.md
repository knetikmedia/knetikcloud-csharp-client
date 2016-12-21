# IO.Swagger.Api.ReportingChallengesApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetChallengeEventLeaderboardUsingGET**](ReportingChallengesApi.md#getchallengeeventleaderboardusingget) | **GET** /reporting/events/leaderboard | Retrieve a challenge event leaderboard details
[**GetChallengeEventParticipantsUsingGET**](ReportingChallengesApi.md#getchallengeeventparticipantsusingget) | **GET** /reporting/events/participants | Retrieve a challenge event participant details


<a name="getchallengeeventleaderboardusingget"></a>
# **GetChallengeEventLeaderboardUsingGET**
> PageResourceChallengeEventParticipantResource GetChallengeEventLeaderboardUsingGET (long? filterEvent = null)

Retrieve a challenge event leaderboard details

Lists all leaderboard entries with additional user details

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChallengeEventLeaderboardUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportingChallengesApi();
            var filterEvent = 789;  // long? | A sepecific challenge event id (optional) 

            try
            {
                // Retrieve a challenge event leaderboard details
                PageResourceChallengeEventParticipantResource result = apiInstance.GetChallengeEventLeaderboardUsingGET(filterEvent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingChallengesApi.GetChallengeEventLeaderboardUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterEvent** | **long?**| A sepecific challenge event id | [optional] 

### Return type

[**PageResourceChallengeEventParticipantResource**](PageResourceChallengeEventParticipantResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchallengeeventparticipantsusingget"></a>
# **GetChallengeEventParticipantsUsingGET**
> PageResourceChallengeEventParticipantResource GetChallengeEventParticipantsUsingGET (long? filterEvent = null)

Retrieve a challenge event participant details

Lists all user submitted scores sorted by value, including those that do not apear in the leaderboard due to value or aggregation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChallengeEventParticipantsUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportingChallengesApi();
            var filterEvent = 789;  // long? | A sepecific challenge event id (optional) 

            try
            {
                // Retrieve a challenge event participant details
                PageResourceChallengeEventParticipantResource result = apiInstance.GetChallengeEventParticipantsUsingGET(filterEvent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingChallengesApi.GetChallengeEventParticipantsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterEvent** | **long?**| A sepecific challenge event id | [optional] 

### Return type

[**PageResourceChallengeEventParticipantResource**](PageResourceChallengeEventParticipantResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

