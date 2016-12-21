# IO.Swagger.Api.CampaignsChallengesApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateChallengeActivityUsingPOST**](CampaignsChallengesApi.md#createchallengeactivityusingpost) | **POST** /challenges/{challenge_id}/activities | Create a challenge activity
[**CreateChallengeTemplateUsingPOST**](CampaignsChallengesApi.md#createchallengetemplateusingpost) | **POST** /challenges/templates | Create a challenge template
[**CreateChallengeUsingPOST**](CampaignsChallengesApi.md#createchallengeusingpost) | **POST** /challenges | Create a challenge
[**DeleteChallengeActivityUsingDELETE**](CampaignsChallengesApi.md#deletechallengeactivityusingdelete) | **DELETE** /challenges/{challenge_id}/activities/{activity_id} | Delete a challenge activity
[**DeleteChallengeEventUsingDELETE**](CampaignsChallengesApi.md#deletechallengeeventusingdelete) | **DELETE** /challenges/events/{id} | Delete a challenge event
[**DeleteChallengeTemplateUsingDELETE**](CampaignsChallengesApi.md#deletechallengetemplateusingdelete) | **DELETE** /challenges/templates/{id} | Delete a challenge template
[**DeleteChallengeUsingDELETE**](CampaignsChallengesApi.md#deletechallengeusingdelete) | **DELETE** /challenges/{id} | Delete a challenge
[**GetActivitiesUsingGET1**](CampaignsChallengesApi.md#getactivitiesusingget1) | **GET** /challenges/{challenge_id}/activities | List and search challenge activities
[**GetChallengeActivityUsingGET**](CampaignsChallengesApi.md#getchallengeactivityusingget) | **GET** /challenges/{challenge_id}/activities/{activity_id} | Get a single challenge activity
[**GetChallengeEventUsingGET**](CampaignsChallengesApi.md#getchallengeeventusingget) | **GET** /challenges/events/{id} | Retrieve a single challenge event details
[**GetChallengeEventssUsingGET**](CampaignsChallengesApi.md#getchallengeeventssusingget) | **GET** /challenges/events | Retrieve a list of challenge events
[**GetChallengeTemplateUsingGET**](CampaignsChallengesApi.md#getchallengetemplateusingget) | **GET** /challenges/templates/{id} | Get a single challenge template
[**GetChallengeTemplatesUsingGET**](CampaignsChallengesApi.md#getchallengetemplatesusingget) | **GET** /challenges/templates | List and search challenge templates
[**GetChallengeUsingGET**](CampaignsChallengesApi.md#getchallengeusingget) | **GET** /challenges/{id} | Retrieve a single challenge details
[**GetChallengesUsingGET1**](CampaignsChallengesApi.md#getchallengesusingget1) | **GET** /challenges | Retrieve a list of challenges
[**UpdateChallengeActivityUsingPUT**](CampaignsChallengesApi.md#updatechallengeactivityusingput) | **PUT** /challenges/{challenge_id}/activities/{activity_id} | Update a challenge activity
[**UpdateChallengeTemplateUsingPUT**](CampaignsChallengesApi.md#updatechallengetemplateusingput) | **PUT** /challenges/templates/{id} | Update a challenge template
[**UpdateChallengeUsingPUT**](CampaignsChallengesApi.md#updatechallengeusingput) | **PUT** /challenges/{id} | Update a challenge&#39;s information


<a name="createchallengeactivityusingpost"></a>
# **CreateChallengeActivityUsingPOST**
> ChallengeActivityResource CreateChallengeActivityUsingPOST (long? challengeId, ChallengeActivityResource challengeActivityResource = null, bool? validateSettings = null)

Create a challenge activity

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateChallengeActivityUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var challengeId = 789;  // long? | The challenge id
            var challengeActivityResource = new ChallengeActivityResource(); // ChallengeActivityResource | The challenge activity resource object (optional) 
            var validateSettings = true;  // bool? | Whether to validate the settings being sent against the available settings on the base activity. (optional)  (default to false)

            try
            {
                // Create a challenge activity
                ChallengeActivityResource result = apiInstance.CreateChallengeActivityUsingPOST(challengeId, challengeActivityResource, validateSettings);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.CreateChallengeActivityUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **challengeId** | **long?**| The challenge id | 
 **challengeActivityResource** | [**ChallengeActivityResource**](ChallengeActivityResource.md)| The challenge activity resource object | [optional] 
 **validateSettings** | **bool?**| Whether to validate the settings being sent against the available settings on the base activity. | [optional] [default to false]

### Return type

[**ChallengeActivityResource**](ChallengeActivityResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createchallengetemplateusingpost"></a>
# **CreateChallengeTemplateUsingPOST**
> TemplateResource CreateChallengeTemplateUsingPOST (TemplateResource challengeTemplateResource = null)

Create a challenge template

Challenge Templates define a type of challenge and the properties they have

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateChallengeTemplateUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var challengeTemplateResource = new TemplateResource(); // TemplateResource | The challenge template resource object (optional) 

            try
            {
                // Create a challenge template
                TemplateResource result = apiInstance.CreateChallengeTemplateUsingPOST(challengeTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.CreateChallengeTemplateUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **challengeTemplateResource** | [**TemplateResource**](TemplateResource.md)| The challenge template resource object | [optional] 

### Return type

[**TemplateResource**](TemplateResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createchallengeusingpost"></a>
# **CreateChallengeUsingPOST**
> ChallengeResource CreateChallengeUsingPOST (ChallengeResource challengeResource = null)

Create a challenge

Challenges do not run on their own.  They must be added to a campaign before events will spawn.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateChallengeUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var challengeResource = new ChallengeResource(); // ChallengeResource | The challenge resource object (optional) 

            try
            {
                // Create a challenge
                ChallengeResource result = apiInstance.CreateChallengeUsingPOST(challengeResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.CreateChallengeUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **challengeResource** | [**ChallengeResource**](ChallengeResource.md)| The challenge resource object | [optional] 

### Return type

[**ChallengeResource**](ChallengeResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletechallengeactivityusingdelete"></a>
# **DeleteChallengeActivityUsingDELETE**
> void DeleteChallengeActivityUsingDELETE (long? activityId, long? challengeId)

Delete a challenge activity

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteChallengeActivityUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var activityId = 789;  // long? | The activity id
            var challengeId = 789;  // long? | The challenge id

            try
            {
                // Delete a challenge activity
                apiInstance.DeleteChallengeActivityUsingDELETE(activityId, challengeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.DeleteChallengeActivityUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **activityId** | **long?**| The activity id | 
 **challengeId** | **long?**| The challenge id | 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletechallengeeventusingdelete"></a>
# **DeleteChallengeEventUsingDELETE**
> void DeleteChallengeEventUsingDELETE (long? id)

Delete a challenge event

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteChallengeEventUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var id = 789;  // long? | The challenge event id

            try
            {
                // Delete a challenge event
                apiInstance.DeleteChallengeEventUsingDELETE(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.DeleteChallengeEventUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The challenge event id | 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletechallengetemplateusingdelete"></a>
# **DeleteChallengeTemplateUsingDELETE**
> void DeleteChallengeTemplateUsingDELETE (string id, string cascade = null)

Delete a challenge template

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
    public class DeleteChallengeTemplateUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | The value needed to delete used templates (optional) 

            try
            {
                // Delete a challenge template
                apiInstance.DeleteChallengeTemplateUsingDELETE(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.DeleteChallengeTemplateUsingDELETE: " + e.Message );
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

<a name="deletechallengeusingdelete"></a>
# **DeleteChallengeUsingDELETE**
> void DeleteChallengeUsingDELETE (long? id)

Delete a challenge

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteChallengeUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var id = 789;  // long? | The challenge id

            try
            {
                // Delete a challenge
                apiInstance.DeleteChallengeUsingDELETE(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.DeleteChallengeUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The challenge id | 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getactivitiesusingget1"></a>
# **GetActivitiesUsingGET1**
> PageResourceBareChallengeActivityResource GetActivitiesUsingGET1 (long? challengeId, int? size = null, int? page = null, string order = null)

List and search challenge activities

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetActivitiesUsingGET1Example
    {
        public void main()
        {
            
            var apiInstance = new CampaignsChallengesApi();
            var challengeId = 789;  // long? | The challenge id
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search challenge activities
                PageResourceBareChallengeActivityResource result = apiInstance.GetActivitiesUsingGET1(challengeId, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.GetActivitiesUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **challengeId** | **long?**| The challenge id | 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourceBareChallengeActivityResource**](PageResourceBareChallengeActivityResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchallengeactivityusingget"></a>
# **GetChallengeActivityUsingGET**
> ChallengeActivityResource GetChallengeActivityUsingGET (long? activityId)

Get a single challenge activity

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChallengeActivityUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new CampaignsChallengesApi();
            var activityId = 789;  // long? | The activity id

            try
            {
                // Get a single challenge activity
                ChallengeActivityResource result = apiInstance.GetChallengeActivityUsingGET(activityId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.GetChallengeActivityUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **activityId** | **long?**| The activity id | 

### Return type

[**ChallengeActivityResource**](ChallengeActivityResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchallengeeventusingget"></a>
# **GetChallengeEventUsingGET**
> ChallengeEventResource GetChallengeEventUsingGET (long? id)

Retrieve a single challenge event details

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChallengeEventUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new CampaignsChallengesApi();
            var id = 789;  // long? | The challenge event id

            try
            {
                // Retrieve a single challenge event details
                ChallengeEventResource result = apiInstance.GetChallengeEventUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.GetChallengeEventUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The challenge event id | 

### Return type

[**ChallengeEventResource**](ChallengeEventResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchallengeeventssusingget"></a>
# **GetChallengeEventssUsingGET**
> PageResourceChallengeEventResource GetChallengeEventssUsingGET (string filterStartDate = null, string filterEndDate = null, bool? filterCampaigns = null, long? filterChallenge = null, int? size = null, int? page = null, string order = null)

Retrieve a list of challenge events

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChallengeEventssUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new CampaignsChallengesApi();
            var filterStartDate = filterStartDate_example;  // string | A comma separated string without spaces.  First value is the operator to search on, second value is the event start date, a unix timestamp in seconds.  Allowed operators: (GT, LT, EQ, GOE, LOE). (optional) 
            var filterEndDate = filterEndDate_example;  // string | A comma separated string without spaces.  First value is the operator to search on, second value is the event end date, a unix timestamp in seconds.  Allowed operators: (GT, LT, EQ, GOE, LOE). (optional) 
            var filterCampaigns = true;  // bool? | check only for events from currently running campaigns (optional) 
            var filterChallenge = 789;  // long? | check only for events from the challenge specified by id (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // Retrieve a list of challenge events
                PageResourceChallengeEventResource result = apiInstance.GetChallengeEventssUsingGET(filterStartDate, filterEndDate, filterCampaigns, filterChallenge, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.GetChallengeEventssUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterStartDate** | **string**| A comma separated string without spaces.  First value is the operator to search on, second value is the event start date, a unix timestamp in seconds.  Allowed operators: (GT, LT, EQ, GOE, LOE). | [optional] 
 **filterEndDate** | **string**| A comma separated string without spaces.  First value is the operator to search on, second value is the event end date, a unix timestamp in seconds.  Allowed operators: (GT, LT, EQ, GOE, LOE). | [optional] 
 **filterCampaigns** | **bool?**| check only for events from currently running campaigns | [optional] 
 **filterChallenge** | **long?**| check only for events from the challenge specified by id | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourceChallengeEventResource**](PageResourceChallengeEventResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchallengetemplateusingget"></a>
# **GetChallengeTemplateUsingGET**
> TemplateResource GetChallengeTemplateUsingGET (string id)

Get a single challenge template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChallengeTemplateUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single challenge template
                TemplateResource result = apiInstance.GetChallengeTemplateUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.GetChallengeTemplateUsingGET: " + e.Message );
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

<a name="getchallengetemplatesusingget"></a>
# **GetChallengeTemplatesUsingGET**
> PageResourceTemplateResource GetChallengeTemplatesUsingGET (int? size = null, int? page = null, string order = null)

List and search challenge templates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChallengeTemplatesUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search challenge templates
                PageResourceTemplateResource result = apiInstance.GetChallengeTemplatesUsingGET(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.GetChallengeTemplatesUsingGET: " + e.Message );
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

<a name="getchallengeusingget"></a>
# **GetChallengeUsingGET**
> ChallengeResource GetChallengeUsingGET (long? id)

Retrieve a single challenge details

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChallengeUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new CampaignsChallengesApi();
            var id = 789;  // long? | The challenge id

            try
            {
                // Retrieve a single challenge details
                ChallengeResource result = apiInstance.GetChallengeUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.GetChallengeUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The challenge id | 

### Return type

[**ChallengeResource**](ChallengeResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchallengesusingget1"></a>
# **GetChallengesUsingGET1**
> PageResourceChallengeResource GetChallengesUsingGET1 (bool? filterTemplate = null, bool? filterActiveCampaign = null)

Retrieve a list of challenges

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChallengesUsingGET1Example
    {
        public void main()
        {
            
            var apiInstance = new CampaignsChallengesApi();
            var filterTemplate = true;  // bool? | Filter for challenges that are not tied to campaigns (templates) (optional) 
            var filterActiveCampaign = true;  // bool? | Filter for challenges that are tied to active campaigns (optional) 

            try
            {
                // Retrieve a list of challenges
                PageResourceChallengeResource result = apiInstance.GetChallengesUsingGET1(filterTemplate, filterActiveCampaign);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.GetChallengesUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterTemplate** | **bool?**| Filter for challenges that are not tied to campaigns (templates) | [optional] 
 **filterActiveCampaign** | **bool?**| Filter for challenges that are tied to active campaigns | [optional] 

### Return type

[**PageResourceChallengeResource**](PageResourceChallengeResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatechallengeactivityusingput"></a>
# **UpdateChallengeActivityUsingPUT**
> void UpdateChallengeActivityUsingPUT (long? activityId, long? challengeId, ChallengeActivityResource challengeActivityResource = null)

Update a challenge activity

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateChallengeActivityUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var activityId = 789;  // long? | The activity id
            var challengeId = 789;  // long? | The challenge id
            var challengeActivityResource = new ChallengeActivityResource(); // ChallengeActivityResource | The challenge activity resource object (optional) 

            try
            {
                // Update a challenge activity
                apiInstance.UpdateChallengeActivityUsingPUT(activityId, challengeId, challengeActivityResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.UpdateChallengeActivityUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **activityId** | **long?**| The activity id | 
 **challengeId** | **long?**| The challenge id | 
 **challengeActivityResource** | [**ChallengeActivityResource**](ChallengeActivityResource.md)| The challenge activity resource object | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatechallengetemplateusingput"></a>
# **UpdateChallengeTemplateUsingPUT**
> void UpdateChallengeTemplateUsingPUT (string id, TemplateResource challengeTemplateResource = null)

Update a challenge template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateChallengeTemplateUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var id = id_example;  // string | The id of the template
            var challengeTemplateResource = new TemplateResource(); // TemplateResource | The challenge template resource object (optional) 

            try
            {
                // Update a challenge template
                apiInstance.UpdateChallengeTemplateUsingPUT(id, challengeTemplateResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.UpdateChallengeTemplateUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **challengeTemplateResource** | [**TemplateResource**](TemplateResource.md)| The challenge template resource object | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatechallengeusingput"></a>
# **UpdateChallengeUsingPUT**
> ChallengeResource UpdateChallengeUsingPUT (long? id, ChallengeResource challengeResource = null)

Update a challenge's information

If the challenge is a copy, changes will propagate to all the related challenges

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateChallengeUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var id = 789;  // long? | The challenge id
            var challengeResource = new ChallengeResource(); // ChallengeResource | The challenge resource object (optional) 

            try
            {
                // Update a challenge's information
                ChallengeResource result = apiInstance.UpdateChallengeUsingPUT(id, challengeResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.UpdateChallengeUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The challenge id | 
 **challengeResource** | [**ChallengeResource**](ChallengeResource.md)| The challenge resource object | [optional] 

### Return type

[**ChallengeResource**](ChallengeResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

