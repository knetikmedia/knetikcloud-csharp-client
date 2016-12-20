# IO.Swagger.Api.ActivitiesApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CompleteActivityOccurrenceUsingPUT**](ActivitiesApi.md#completeactivityoccurrenceusingput) | **PUT** /activity-occurrences/{activity_occurrence_id}/status | Updated the status of an activity occurrence
[**CreateActivityOccurrenceUsingPOST**](ActivitiesApi.md#createactivityoccurrenceusingpost) | **POST** /activity-occurrences | Create a new activity occurrence
[**CreateActivityUsingPOST**](ActivitiesApi.md#createactivityusingpost) | **POST** /activities | Create an activity
[**DeleteActivityUsingDELETE**](ActivitiesApi.md#deleteactivityusingdelete) | **DELETE** /activities/{id} | Delete an activity
[**GetActivitiesUsingGET**](ActivitiesApi.md#getactivitiesusingget) | **GET** /activities | List activity definitions
[**GetActivityUsingGET**](ActivitiesApi.md#getactivityusingget) | **GET** /activities/{id} | Get a single activity
[**PostResultsUsingPOST**](ActivitiesApi.md#postresultsusingpost) | **POST** /activity-occurrences/{activity_occurrence_id}/results | Sets the status of an activity occurrence to FINISHED and logs metrics
[**UpdateActivityUsingPUT**](ActivitiesApi.md#updateactivityusingput) | **PUT** /activities/{id} | Update an activity


<a name="completeactivityoccurrenceusingput"></a>
# **CompleteActivityOccurrenceUsingPUT**
> void CompleteActivityOccurrenceUsingPUT (long? activityOccurrenceId, string activityCccurrenceStatus = null)

Updated the status of an activity occurrence

If setting to 'FINISHED' you must POST to /results instead to record the metrics and get synchronous reward results

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CompleteActivityOccurrenceUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActivitiesApi();
            var activityOccurrenceId = 789;  // long? | The id of the activity occurrence
            var activityCccurrenceStatus = activityCccurrenceStatus_example;  // string | The activity occurrence status object (optional) 

            try
            {
                // Updated the status of an activity occurrence
                apiInstance.CompleteActivityOccurrenceUsingPUT(activityOccurrenceId, activityCccurrenceStatus);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivitiesApi.CompleteActivityOccurrenceUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **activityOccurrenceId** | **long?**| The id of the activity occurrence | 
 **activityCccurrenceStatus** | **string**| The activity occurrence status object | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createactivityoccurrenceusingpost"></a>
# **CreateActivityOccurrenceUsingPOST**
> ActivityOccurrenceResource CreateActivityOccurrenceUsingPOST (bool? test = null, ActivityOccurrenceResource activityOccurrenceResource = null)

Create a new activity occurrence

Has to enforce extra rules if not used as an admin

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateActivityOccurrenceUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActivitiesApi();
            var test = true;  // bool? | if true, indicates that the occurrence should NOT be created. This can be used to test for eligibility and valid settings (optional)  (default to false)
            var activityOccurrenceResource = new ActivityOccurrenceResource(); // ActivityOccurrenceResource | The activity occurrence object (optional) 

            try
            {
                // Create a new activity occurrence
                ActivityOccurrenceResource result = apiInstance.CreateActivityOccurrenceUsingPOST(test, activityOccurrenceResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivitiesApi.CreateActivityOccurrenceUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **test** | **bool?**| if true, indicates that the occurrence should NOT be created. This can be used to test for eligibility and valid settings | [optional] [default to false]
 **activityOccurrenceResource** | [**ActivityOccurrenceResource**](ActivityOccurrenceResource.md)| The activity occurrence object | [optional] 

### Return type

[**ActivityOccurrenceResource**](ActivityOccurrenceResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createactivityusingpost"></a>
# **CreateActivityUsingPOST**
> ActivityResource CreateActivityUsingPOST (ActivityResource activityResource = null)

Create an activity

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateActivityUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActivitiesApi();
            var activityResource = new ActivityResource(); // ActivityResource | The activity resource object (optional) 

            try
            {
                // Create an activity
                ActivityResource result = apiInstance.CreateActivityUsingPOST(activityResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivitiesApi.CreateActivityUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **activityResource** | [**ActivityResource**](ActivityResource.md)| The activity resource object | [optional] 

### Return type

[**ActivityResource**](ActivityResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteactivityusingdelete"></a>
# **DeleteActivityUsingDELETE**
> void DeleteActivityUsingDELETE (long? id)

Delete an activity

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteActivityUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActivitiesApi();
            var id = 789;  // long? | The id of the activity

            try
            {
                // Delete an activity
                apiInstance.DeleteActivityUsingDELETE(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivitiesApi.DeleteActivityUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The id of the activity | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getactivitiesusingget"></a>
# **GetActivitiesUsingGET**
> PageBareActivityResource GetActivitiesUsingGET (bool? filterTemplate = null, int? size = null, int? page = null, string order = null)

List activity definitions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetActivitiesUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new ActivitiesApi();
            var filterTemplate = true;  // bool? | Filter for activities that are templates, or specifically not if false (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List activity definitions
                PageBareActivityResource result = apiInstance.GetActivitiesUsingGET(filterTemplate, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivitiesApi.GetActivitiesUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterTemplate** | **bool?**| Filter for activities that are templates, or specifically not if false | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageBareActivityResource**](PageBareActivityResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getactivityusingget"></a>
# **GetActivityUsingGET**
> ActivityResource GetActivityUsingGET (long? id)

Get a single activity

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetActivityUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new ActivitiesApi();
            var id = 789;  // long? | The id of the activity

            try
            {
                // Get a single activity
                ActivityResource result = apiInstance.GetActivityUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivitiesApi.GetActivityUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The id of the activity | 

### Return type

[**ActivityResource**](ActivityResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postresultsusingpost"></a>
# **PostResultsUsingPOST**
> ActivityOccurrenceResults PostResultsUsingPOST (long? activityOccurrenceId, ActivityOccurrenceResults activityOccurrenceResults = null)

Sets the status of an activity occurrence to FINISHED and logs metrics

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostResultsUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActivitiesApi();
            var activityOccurrenceId = 789;  // long? | The id of the activity occurrence
            var activityOccurrenceResults = new ActivityOccurrenceResults(); // ActivityOccurrenceResults | The activity occurrence object (optional) 

            try
            {
                // Sets the status of an activity occurrence to FINISHED and logs metrics
                ActivityOccurrenceResults result = apiInstance.PostResultsUsingPOST(activityOccurrenceId, activityOccurrenceResults);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivitiesApi.PostResultsUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **activityOccurrenceId** | **long?**| The id of the activity occurrence | 
 **activityOccurrenceResults** | [**ActivityOccurrenceResults**](ActivityOccurrenceResults.md)| The activity occurrence object | [optional] 

### Return type

[**ActivityOccurrenceResults**](ActivityOccurrenceResults.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateactivityusingput"></a>
# **UpdateActivityUsingPUT**
> void UpdateActivityUsingPUT (long? id, ActivityResource activityResource = null)

Update an activity

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateActivityUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActivitiesApi();
            var id = 789;  // long? | The id of the activity
            var activityResource = new ActivityResource(); // ActivityResource | The activity resource object (optional) 

            try
            {
                // Update an activity
                apiInstance.UpdateActivityUsingPUT(id, activityResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivitiesApi.UpdateActivityUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The id of the activity | 
 **activityResource** | [**ActivityResource**](ActivityResource.md)| The activity resource object | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

