# com.knetikcloud.Api.CampaignsChallengesApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateChallenge**](CampaignsChallengesApi.md#createchallenge) | **POST** /challenges | Create a challenge
[**CreateChallengeActivity**](CampaignsChallengesApi.md#createchallengeactivity) | **POST** /challenges/{challenge_id}/activities | Create a challenge activity
[**CreateChallengeTemplate**](CampaignsChallengesApi.md#createchallengetemplate) | **POST** /challenges/templates | Create a challenge template
[**DeleteChallenge**](CampaignsChallengesApi.md#deletechallenge) | **DELETE** /challenges/{id} | Delete a challenge
[**DeleteChallengeActivity**](CampaignsChallengesApi.md#deletechallengeactivity) | **DELETE** /challenges/{challenge_id}/activities/{activity_id} | Delete a challenge activity
[**DeleteChallengeEvent**](CampaignsChallengesApi.md#deletechallengeevent) | **DELETE** /challenges/events/{id} | Delete a challenge event
[**DeleteChallengeTemplate**](CampaignsChallengesApi.md#deletechallengetemplate) | **DELETE** /challenges/templates/{id} | Delete a challenge template
[**GetChallenge**](CampaignsChallengesApi.md#getchallenge) | **GET** /challenges/{id} | Retrieve a challenge
[**GetChallengeActivities**](CampaignsChallengesApi.md#getchallengeactivities) | **GET** /challenges/{challenge_id}/activities | List and search challenge activities
[**GetChallengeActivity**](CampaignsChallengesApi.md#getchallengeactivity) | **GET** /challenges/{challenge_id}/activities/{activity_id} | Get a single challenge activity
[**GetChallengeEvent**](CampaignsChallengesApi.md#getchallengeevent) | **GET** /challenges/events/{id} | Retrieve a single challenge event details
[**GetChallengeEvents**](CampaignsChallengesApi.md#getchallengeevents) | **GET** /challenges/events | Retrieve a list of challenge events
[**GetChallengeTemplate**](CampaignsChallengesApi.md#getchallengetemplate) | **GET** /challenges/templates/{id} | Get a single challenge template
[**GetChallengeTemplates**](CampaignsChallengesApi.md#getchallengetemplates) | **GET** /challenges/templates | List and search challenge templates
[**GetChallenges**](CampaignsChallengesApi.md#getchallenges) | **GET** /challenges | Retrieve a list of challenges
[**UpdateChallenge**](CampaignsChallengesApi.md#updatechallenge) | **PUT** /challenges/{id} | Update a challenge
[**UpdateChallengeActivity**](CampaignsChallengesApi.md#updatechallengeactivity) | **PUT** /challenges/{challenge_id}/activities/{activity_id} | Update a challenge activity
[**UpdateChallengeTemplate**](CampaignsChallengesApi.md#updatechallengetemplate) | **PUT** /challenges/templates/{id} | Update a challenge template


<a name="createchallenge"></a>
# **CreateChallenge**
> ChallengeResource CreateChallenge (ChallengeResource challengeResource = null)

Create a challenge

Challenges do not run on their own.  They must be added to a campaign before events will spawn.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateChallengeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var challengeResource = new ChallengeResource(); // ChallengeResource | The challenge resource object (optional) 

            try
            {
                // Create a challenge
                ChallengeResource result = apiInstance.CreateChallenge(challengeResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.CreateChallenge: " + e.Message );
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

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createchallengeactivity"></a>
# **CreateChallengeActivity**
> ChallengeActivityResource CreateChallengeActivity (long? challengeId, ChallengeActivityResource challengeActivityResource = null, bool? validateSettings = null)

Create a challenge activity

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateChallengeActivityExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var challengeId = 789;  // long? | The challenge id
            var challengeActivityResource = new ChallengeActivityResource(); // ChallengeActivityResource | The challenge activity resource object (optional) 
            var validateSettings = true;  // bool? | Whether to validate the settings being sent against the available settings on the base activity. (optional)  (default to false)

            try
            {
                // Create a challenge activity
                ChallengeActivityResource result = apiInstance.CreateChallengeActivity(challengeId, challengeActivityResource, validateSettings);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.CreateChallengeActivity: " + e.Message );
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

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createchallengetemplate"></a>
# **CreateChallengeTemplate**
> TemplateResource CreateChallengeTemplate (TemplateResource challengeTemplateResource = null)

Create a challenge template

Challenge Templates define a type of challenge and the properties they have

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateChallengeTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var challengeTemplateResource = new TemplateResource(); // TemplateResource | The challenge template resource object (optional) 

            try
            {
                // Create a challenge template
                TemplateResource result = apiInstance.CreateChallengeTemplate(challengeTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.CreateChallengeTemplate: " + e.Message );
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

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletechallenge"></a>
# **DeleteChallenge**
> void DeleteChallenge (long? id)

Delete a challenge

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteChallengeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var id = 789;  // long? | The challenge id

            try
            {
                // Delete a challenge
                apiInstance.DeleteChallenge(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.DeleteChallenge: " + e.Message );
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

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletechallengeactivity"></a>
# **DeleteChallengeActivity**
> void DeleteChallengeActivity (long? activityId, long? challengeId)

Delete a challenge activity

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteChallengeActivityExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var activityId = 789;  // long? | The activity id
            var challengeId = 789;  // long? | The challenge id

            try
            {
                // Delete a challenge activity
                apiInstance.DeleteChallengeActivity(activityId, challengeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.DeleteChallengeActivity: " + e.Message );
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

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletechallengeevent"></a>
# **DeleteChallengeEvent**
> void DeleteChallengeEvent (long? id)

Delete a challenge event

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteChallengeEventExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var id = 789;  // long? | The challenge event id

            try
            {
                // Delete a challenge event
                apiInstance.DeleteChallengeEvent(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.DeleteChallengeEvent: " + e.Message );
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

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletechallengetemplate"></a>
# **DeleteChallengeTemplate**
> void DeleteChallengeTemplate (string id, string cascade = null)

Delete a challenge template

If cascade = 'detach', it will force delete the template even if it's attached to other objects

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteChallengeTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | The value needed to delete used templates (optional) 

            try
            {
                // Delete a challenge template
                apiInstance.DeleteChallengeTemplate(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.DeleteChallengeTemplate: " + e.Message );
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

<a name="getchallenge"></a>
# **GetChallenge**
> ChallengeResource GetChallenge (long? id)

Retrieve a challenge

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetChallengeExample
    {
        public void main()
        {
            
            var apiInstance = new CampaignsChallengesApi();
            var id = 789;  // long? | The challenge id

            try
            {
                // Retrieve a challenge
                ChallengeResource result = apiInstance.GetChallenge(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.GetChallenge: " + e.Message );
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

<a name="getchallengeactivities"></a>
# **GetChallengeActivities**
> PageResourceBareChallengeActivityResource GetChallengeActivities (long? challengeId, int? size = null, int? page = null, string order = null)

List and search challenge activities

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetChallengeActivitiesExample
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
                PageResourceBareChallengeActivityResource result = apiInstance.GetChallengeActivities(challengeId, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.GetChallengeActivities: " + e.Message );
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

<a name="getchallengeactivity"></a>
# **GetChallengeActivity**
> ChallengeActivityResource GetChallengeActivity (long? activityId)

Get a single challenge activity

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetChallengeActivityExample
    {
        public void main()
        {
            
            var apiInstance = new CampaignsChallengesApi();
            var activityId = 789;  // long? | The activity id

            try
            {
                // Get a single challenge activity
                ChallengeActivityResource result = apiInstance.GetChallengeActivity(activityId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.GetChallengeActivity: " + e.Message );
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

<a name="getchallengeevent"></a>
# **GetChallengeEvent**
> ChallengeEventResource GetChallengeEvent (long? id)

Retrieve a single challenge event details

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetChallengeEventExample
    {
        public void main()
        {
            
            var apiInstance = new CampaignsChallengesApi();
            var id = 789;  // long? | The challenge event id

            try
            {
                // Retrieve a single challenge event details
                ChallengeEventResource result = apiInstance.GetChallengeEvent(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.GetChallengeEvent: " + e.Message );
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

<a name="getchallengeevents"></a>
# **GetChallengeEvents**
> PageResourceChallengeEventResource GetChallengeEvents (string filterStartDate = null, string filterEndDate = null, bool? filterCampaigns = null, long? filterChallenge = null, int? size = null, int? page = null, string order = null)

Retrieve a list of challenge events

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetChallengeEventsExample
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
                PageResourceChallengeEventResource result = apiInstance.GetChallengeEvents(filterStartDate, filterEndDate, filterCampaigns, filterChallenge, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.GetChallengeEvents: " + e.Message );
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

<a name="getchallengetemplate"></a>
# **GetChallengeTemplate**
> TemplateResource GetChallengeTemplate (string id)

Get a single challenge template

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetChallengeTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single challenge template
                TemplateResource result = apiInstance.GetChallengeTemplate(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.GetChallengeTemplate: " + e.Message );
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

<a name="getchallengetemplates"></a>
# **GetChallengeTemplates**
> PageResourceTemplateResource GetChallengeTemplates (int? size = null, int? page = null, string order = null)

List and search challenge templates

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetChallengeTemplatesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search challenge templates
                PageResourceTemplateResource result = apiInstance.GetChallengeTemplates(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.GetChallengeTemplates: " + e.Message );
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

<a name="getchallenges"></a>
# **GetChallenges**
> PageResourceChallengeResource GetChallenges (bool? filterTemplate = null, bool? filterActiveCampaign = null)

Retrieve a list of challenges

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetChallengesExample
    {
        public void main()
        {
            
            var apiInstance = new CampaignsChallengesApi();
            var filterTemplate = true;  // bool? | Filter for challenges that are not tied to campaigns (templates) (optional) 
            var filterActiveCampaign = true;  // bool? | Filter for challenges that are tied to active campaigns (optional) 

            try
            {
                // Retrieve a list of challenges
                PageResourceChallengeResource result = apiInstance.GetChallenges(filterTemplate, filterActiveCampaign);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.GetChallenges: " + e.Message );
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

<a name="updatechallenge"></a>
# **UpdateChallenge**
> ChallengeResource UpdateChallenge (long? id, ChallengeResource challengeResource = null)

Update a challenge

If the challenge is a copy, changes will propagate to all the related challenges

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateChallengeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var id = 789;  // long? | The challenge id
            var challengeResource = new ChallengeResource(); // ChallengeResource | The challenge resource object (optional) 

            try
            {
                // Update a challenge
                ChallengeResource result = apiInstance.UpdateChallenge(id, challengeResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.UpdateChallenge: " + e.Message );
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

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatechallengeactivity"></a>
# **UpdateChallengeActivity**
> ChallengeActivityResource UpdateChallengeActivity (long? activityId, long? challengeId, ChallengeActivityResource challengeActivityResource = null)

Update a challenge activity

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateChallengeActivityExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var activityId = 789;  // long? | The activity id
            var challengeId = 789;  // long? | The challenge id
            var challengeActivityResource = new ChallengeActivityResource(); // ChallengeActivityResource | The challenge activity resource object (optional) 

            try
            {
                // Update a challenge activity
                ChallengeActivityResource result = apiInstance.UpdateChallengeActivity(activityId, challengeId, challengeActivityResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.UpdateChallengeActivity: " + e.Message );
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

[**ChallengeActivityResource**](ChallengeActivityResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatechallengetemplate"></a>
# **UpdateChallengeTemplate**
> TemplateResource UpdateChallengeTemplate (string id, TemplateResource challengeTemplateResource = null)

Update a challenge template

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateChallengeTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var id = id_example;  // string | The id of the template
            var challengeTemplateResource = new TemplateResource(); // TemplateResource | The challenge template resource object (optional) 

            try
            {
                // Update a challenge template
                TemplateResource result = apiInstance.UpdateChallengeTemplate(id, challengeTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.UpdateChallengeTemplate: " + e.Message );
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

[**TemplateResource**](TemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
