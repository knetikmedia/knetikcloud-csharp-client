# IO.Swagger.Api.MediaVideosApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddCommentUsingPOST1**](MediaVideosApi.md#addcommentusingpost1) | **POST** /media/videos/{video_id}/comments | Add a new video comment
[**AddContributorUsingPOST**](MediaVideosApi.md#addcontributorusingpost) | **POST** /media/videos/{video_id}/contributors | Adds a contributor to a video
[**AddDispositionUsingPOST1**](MediaVideosApi.md#adddispositionusingpost1) | **POST** /media/videos/{video_id}/dispositions | Add a new Video disposition
[**AddFlagUsingPOST**](MediaVideosApi.md#addflagusingpost) | **POST** /media/videos/{video_id}/moderation | Add a new flag
[**AddRelatedUsingPOST**](MediaVideosApi.md#addrelatedusingpost) | **POST** /media/videos/{video_id}/related | Adds one or more existing videos as related to this one
[**AddVideoUsingPOST**](MediaVideosApi.md#addvideousingpost) | **POST** /media/videos | Adds a new video in the system
[**AddWhitelistUsingPOST**](MediaVideosApi.md#addwhitelistusingpost) | **POST** /media/videos/{id}/whitelist | Adds a user to a video&#39;s whitelist
[**DeleteCommentUsingDELETE1**](MediaVideosApi.md#deletecommentusingdelete1) | **DELETE** /media/videos/{video_id}/comments/{id} | Delete a video comment
[**DeleteDispositionUsingDELETE1**](MediaVideosApi.md#deletedispositionusingdelete1) | **DELETE** /media/videos/{video_id}/dispositions/{disposition_id} | Delete a video comment
[**DeleteFlagUsingDELETE**](MediaVideosApi.md#deleteflagusingdelete) | **DELETE** /media/videos/{video_id}/moderation | Delete a flag
[**DeleteRelationshipUsingDELETE1**](MediaVideosApi.md#deleterelationshipusingdelete1) | **DELETE** /media/videos/{video_id}/related/{id} | Delete a video&#39;s relationship
[**DeleteVideoUsingDELETE**](MediaVideosApi.md#deletevideousingdelete) | **DELETE** /media/videos/{id} | Removes a video from the system if no resources are attached to it
[**GetCommentsUsingGET1**](MediaVideosApi.md#getcommentsusingget1) | **GET** /media/videos/{video_id}/comments | Returns a page of comments for a video
[**GetDispositionsUsingGET1**](MediaVideosApi.md#getdispositionsusingget1) | **GET** /media/videos/{video_id}/dispositions | Returns a page of dispositions for a video
[**GetRelatedUsingGET**](MediaVideosApi.md#getrelatedusingget) | **GET** /media/videos/{video_id}/related | Returns a page of video relationships
[**GetUserVideosUsingGET**](MediaVideosApi.md#getuservideosusingget) | **GET** /users/{user_id}/videos | Get user videos
[**GetVideoUsingGET**](MediaVideosApi.md#getvideousingget) | **GET** /media/videos/{id} | Loads a specific video details
[**RemoveContributorUsingDELETE**](MediaVideosApi.md#removecontributorusingdelete) | **DELETE** /media/videos/{video_id}/contributors/{id} | Removes a contributor from a video
[**RemoveWhitelistUsingDELETE**](MediaVideosApi.md#removewhitelistusingdelete) | **DELETE** /media/videos/{video_id}/whitelist/{id} | Removes a user from a video&#39;s whitelist
[**SearchVideosUsingGET**](MediaVideosApi.md#searchvideosusingget) | **GET** /media/videos | Search videos using the documented filters
[**UpdateCommentUsingPUT1**](MediaVideosApi.md#updatecommentusingput1) | **PUT** /media/videos/{video_id}/comments/{id}/content | Update video comment content 
[**UpdateRelationshipUsingPUT1**](MediaVideosApi.md#updaterelationshipusingput1) | **PUT** /media/videos/{video_id}/related/{id}/relationship_details | Update a video&#39;s relationship details
[**UpdateVideoUsingPUT**](MediaVideosApi.md#updatevideousingput) | **PUT** /media/videos/{id} | Modifies a video&#39;s details
[**ViewVideoUsingPOST**](MediaVideosApi.md#viewvideousingpost) | **POST** /media/videos/{id}/views | Increment a video&#39;s view count


<a name="addcommentusingpost1"></a>
# **AddCommentUsingPOST1**
> CommentResource AddCommentUsingPOST1 (int? videoId, CommentResource commentResource = null)

Add a new video comment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddCommentUsingPOST1Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var videoId = 56;  // int? | The video id 
            var commentResource = new CommentResource(); // CommentResource | The comment object (optional) 

            try
            {
                // Add a new video comment
                CommentResource result = apiInstance.AddCommentUsingPOST1(videoId, commentResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.AddCommentUsingPOST1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **int?**| The video id  | 
 **commentResource** | [**CommentResource**](CommentResource.md)| The comment object | [optional] 

### Return type

[**CommentResource**](CommentResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcontributorusingpost"></a>
# **AddContributorUsingPOST**
> void AddContributorUsingPOST (long? videoId, ContributionResource contributionResource = null)

Adds a contributor to a video

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddContributorUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var videoId = 789;  // long? | The video id
            var contributionResource = new ContributionResource(); // ContributionResource | The contribution object (optional) 

            try
            {
                // Adds a contributor to a video
                apiInstance.AddContributorUsingPOST(videoId, contributionResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.AddContributorUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **long?**| The video id | 
 **contributionResource** | [**ContributionResource**](ContributionResource.md)| The contribution object | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adddispositionusingpost1"></a>
# **AddDispositionUsingPOST1**
> DispositionResource AddDispositionUsingPOST1 (int? videoId, DispositionResource dispositionResource = null)

Add a new Video disposition

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddDispositionUsingPOST1Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var videoId = 56;  // int? | The video id
            var dispositionResource = new DispositionResource(); // DispositionResource | The disposition object (optional) 

            try
            {
                // Add a new Video disposition
                DispositionResource result = apiInstance.AddDispositionUsingPOST1(videoId, dispositionResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.AddDispositionUsingPOST1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **int?**| The video id | 
 **dispositionResource** | [**DispositionResource**](DispositionResource.md)| The disposition object | [optional] 

### Return type

[**DispositionResource**](DispositionResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addflagusingpost"></a>
# **AddFlagUsingPOST**
> void AddFlagUsingPOST (long? videoId, string reason = null)

Add a new flag

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddFlagUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var videoId = 789;  // long? | The video id
            var reason = reason_example;  // string | The flag reason (optional) 

            try
            {
                // Add a new flag
                apiInstance.AddFlagUsingPOST(videoId, reason);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.AddFlagUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **long?**| The video id | 
 **reason** | **string**| The flag reason | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addrelatedusingpost"></a>
# **AddRelatedUsingPOST**
> VideoRelationshipResource AddRelatedUsingPOST (long? videoId, VideoRelationshipResource videoRelationshipResource = null)

Adds one or more existing videos as related to this one

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddRelatedUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var videoId = 789;  // long? | The video id
            var videoRelationshipResource = new VideoRelationshipResource(); // VideoRelationshipResource | The video relationship object  (optional) 

            try
            {
                // Adds one or more existing videos as related to this one
                VideoRelationshipResource result = apiInstance.AddRelatedUsingPOST(videoId, videoRelationshipResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.AddRelatedUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **long?**| The video id | 
 **videoRelationshipResource** | [**VideoRelationshipResource**](VideoRelationshipResource.md)| The video relationship object  | [optional] 

### Return type

[**VideoRelationshipResource**](VideoRelationshipResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addvideousingpost"></a>
# **AddVideoUsingPOST**
> VideoResource AddVideoUsingPOST (VideoResource videoResource = null)

Adds a new video in the system

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddVideoUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var videoResource = new VideoResource(); // VideoResource | The video object (optional) 

            try
            {
                // Adds a new video in the system
                VideoResource result = apiInstance.AddVideoUsingPOST(videoResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.AddVideoUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoResource** | [**VideoResource**](VideoResource.md)| The video object | [optional] 

### Return type

[**VideoResource**](VideoResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addwhitelistusingpost"></a>
# **AddWhitelistUsingPOST**
> void AddWhitelistUsingPOST (long? id, int? userId = null)

Adds a user to a video's whitelist

Whitelisted users can view video regardless of privacy setting.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddWhitelistUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var id = 789;  // long? | The video id
            var userId = 56;  // int? | The user id (optional) 

            try
            {
                // Adds a user to a video's whitelist
                apiInstance.AddWhitelistUsingPOST(id, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.AddWhitelistUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The video id | 
 **userId** | **int?**| The user id | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecommentusingdelete1"></a>
# **DeleteCommentUsingDELETE1**
> void DeleteCommentUsingDELETE1 (long? videoId, long? id)

Delete a video comment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteCommentUsingDELETE1Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var videoId = 789;  // long? | The video id
            var id = 789;  // long? | The comment id

            try
            {
                // Delete a video comment
                apiInstance.DeleteCommentUsingDELETE1(videoId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.DeleteCommentUsingDELETE1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **long?**| The video id | 
 **id** | **long?**| The comment id | 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedispositionusingdelete1"></a>
# **DeleteDispositionUsingDELETE1**
> void DeleteDispositionUsingDELETE1 (long? dispositionId)

Delete a video comment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteDispositionUsingDELETE1Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var dispositionId = 789;  // long? | The disposition id

            try
            {
                // Delete a video comment
                apiInstance.DeleteDispositionUsingDELETE1(dispositionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.DeleteDispositionUsingDELETE1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dispositionId** | **long?**| The disposition id | 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteflagusingdelete"></a>
# **DeleteFlagUsingDELETE**
> void DeleteFlagUsingDELETE (long? videoId)

Delete a flag

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteFlagUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var videoId = 789;  // long? | The video id

            try
            {
                // Delete a flag
                apiInstance.DeleteFlagUsingDELETE(videoId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.DeleteFlagUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **long?**| The video id | 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterelationshipusingdelete1"></a>
# **DeleteRelationshipUsingDELETE1**
> void DeleteRelationshipUsingDELETE1 (long? videoId, long? id)

Delete a video's relationship

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteRelationshipUsingDELETE1Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var videoId = 789;  // long? | The video id
            var id = 789;  // long? | The relationship id

            try
            {
                // Delete a video's relationship
                apiInstance.DeleteRelationshipUsingDELETE1(videoId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.DeleteRelationshipUsingDELETE1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **long?**| The video id | 
 **id** | **long?**| The relationship id | 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevideousingdelete"></a>
# **DeleteVideoUsingDELETE**
> void DeleteVideoUsingDELETE (long? id)

Removes a video from the system if no resources are attached to it

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteVideoUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var id = 789;  // long? | The video id

            try
            {
                // Removes a video from the system if no resources are attached to it
                apiInstance.DeleteVideoUsingDELETE(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.DeleteVideoUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The video id | 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcommentsusingget1"></a>
# **GetCommentsUsingGET1**
> PageResourceCommentResource GetCommentsUsingGET1 (int? videoId, int? size = null, int? page = null)

Returns a page of comments for a video

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCommentsUsingGET1Example
    {
        public void main()
        {
            
            var apiInstance = new MediaVideosApi();
            var videoId = 56;  // int? | The video id
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Returns a page of comments for a video
                PageResourceCommentResource result = apiInstance.GetCommentsUsingGET1(videoId, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.GetCommentsUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **int?**| The video id | 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceCommentResource**](PageResourceCommentResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdispositionsusingget1"></a>
# **GetDispositionsUsingGET1**
> PageResourceDispositionResource GetDispositionsUsingGET1 (int? videoId, int? size = null, int? page = null)

Returns a page of dispositions for a video

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDispositionsUsingGET1Example
    {
        public void main()
        {
            
            var apiInstance = new MediaVideosApi();
            var videoId = 56;  // int? | The video id
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Returns a page of dispositions for a video
                PageResourceDispositionResource result = apiInstance.GetDispositionsUsingGET1(videoId, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.GetDispositionsUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **int?**| The video id | 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceDispositionResource**](PageResourceDispositionResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrelatedusingget"></a>
# **GetRelatedUsingGET**
> PageResourceVideoRelationshipResource GetRelatedUsingGET (long? videoId, int? size = null, int? page = null)

Returns a page of video relationships

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRelatedUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new MediaVideosApi();
            var videoId = 789;  // long? | The video id
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Returns a page of video relationships
                PageResourceVideoRelationshipResource result = apiInstance.GetRelatedUsingGET(videoId, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.GetRelatedUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **long?**| The video id | 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceVideoRelationshipResource**](PageResourceVideoRelationshipResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuservideosusingget"></a>
# **GetUserVideosUsingGET**
> PageResourceVideoResource GetUserVideosUsingGET (int? userId, bool? excludeFlagged = null, int? size = null, int? page = null)

Get user videos

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserVideosUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var userId = 56;  // int? | The user id
            var excludeFlagged = true;  // bool? | Skip videos that have been flagged by the current user (optional)  (default to true)
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Get user videos
                PageResourceVideoResource result = apiInstance.GetUserVideosUsingGET(userId, excludeFlagged, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.GetUserVideosUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The user id | 
 **excludeFlagged** | **bool?**| Skip videos that have been flagged by the current user | [optional] [default to true]
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceVideoResource**](PageResourceVideoResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvideousingget"></a>
# **GetVideoUsingGET**
> VideoResource GetVideoUsingGET (long? id)

Loads a specific video details

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetVideoUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var id = 789;  // long? | The video id

            try
            {
                // Loads a specific video details
                VideoResource result = apiInstance.GetVideoUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.GetVideoUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The video id | 

### Return type

[**VideoResource**](VideoResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removecontributorusingdelete"></a>
# **RemoveContributorUsingDELETE**
> void RemoveContributorUsingDELETE (long? videoId, int? id)

Removes a contributor from a video

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemoveContributorUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var videoId = 789;  // long? | The video id
            var id = 56;  // int? | The contributor id

            try
            {
                // Removes a contributor from a video
                apiInstance.RemoveContributorUsingDELETE(videoId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.RemoveContributorUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **long?**| The video id | 
 **id** | **int?**| The contributor id | 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removewhitelistusingdelete"></a>
# **RemoveWhitelistUsingDELETE**
> void RemoveWhitelistUsingDELETE (long? videoId, int? id)

Removes a user from a video's whitelist

Remove the user with the id given in the path from the whitelist of users that can view this video regardless of privacy setting.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemoveWhitelistUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var videoId = 789;  // long? | The video id
            var id = 56;  // int? | The user id

            try
            {
                // Removes a user from a video's whitelist
                apiInstance.RemoveWhitelistUsingDELETE(videoId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.RemoveWhitelistUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **long?**| The video id | 
 **id** | **int?**| The user id | 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchvideosusingget"></a>
# **SearchVideosUsingGET**
> PageResourceVideoResource SearchVideosUsingGET (bool? excludeFlagged = null, string filterVideosByUploader = null, string filterCategory = null, string filterTagset = null, string filterVideosByName = null, string filterVideosByContributor = null, string filterVideosByAuthor = null, bool? filterHasAuthor = null, bool? filterHasUploader = null, string filterRelatedTo = null, bool? filterFriends = null, string filterDisposition = null, int? size = null, int? page = null, string order = null)

Search videos using the documented filters

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchVideosUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new MediaVideosApi();
            var excludeFlagged = true;  // bool? | Skip videos that have been flagged by the current user (optional)  (default to true)
            var filterVideosByUploader = filterVideosByUploader_example;  // string | Filter for videos by uploader id (optional) 
            var filterCategory = filterCategory_example;  // string | Filter for videos from a specific category by id (optional) 
            var filterTagset = filterTagset_example;  // string | Filter for videos with specified tags (separated by comma) (optional) 
            var filterVideosByName = filterVideosByName_example;  // string | Filter for videos which name *STARTS* with the given string (optional) 
            var filterVideosByContributor = filterVideosByContributor_example;  // string | Filter for videos with contribution from the artist specified by ID (optional) 
            var filterVideosByAuthor = filterVideosByAuthor_example;  // string | Filter for videos with an artist as author specified by ID (optional) 
            var filterHasAuthor = true;  // bool? | Filter for videos that have an author set if true, or that have no author if false (optional) 
            var filterHasUploader = true;  // bool? | Filter for videos that have an uploader set if true, or that have no uploader if false (optional) 
            var filterRelatedTo = filterRelatedTo_example;  // string | Filter for videos that have designated a particular video as the TO of a relationship. Pattern should match VIDEO_ID or VIDEO_ID:DETAILS to match with a specific details string as well (optional) 
            var filterFriends = true;  // bool? | Filter for videos uploaded by friends. 'true' for friends of the caller (requires user token) or a user id for a specific user's friends (requires VIDEOS_ADMIN permission) (optional) 
            var filterDisposition = filterDisposition_example;  // string | Filter for videos a given user has a given disposition towards. USER_ID:DISPOSITION where USER_ID is the id of the user who has this disposition or 'me' for the caller (requires user token for 'me') and DISPOSITION is the name of the disposition. E.G. filter_disposition=123:like or filter_disposition=me:favorite (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to author:ASC)

            try
            {
                // Search videos using the documented filters
                PageResourceVideoResource result = apiInstance.SearchVideosUsingGET(excludeFlagged, filterVideosByUploader, filterCategory, filterTagset, filterVideosByName, filterVideosByContributor, filterVideosByAuthor, filterHasAuthor, filterHasUploader, filterRelatedTo, filterFriends, filterDisposition, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.SearchVideosUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeFlagged** | **bool?**| Skip videos that have been flagged by the current user | [optional] [default to true]
 **filterVideosByUploader** | **string**| Filter for videos by uploader id | [optional] 
 **filterCategory** | **string**| Filter for videos from a specific category by id | [optional] 
 **filterTagset** | **string**| Filter for videos with specified tags (separated by comma) | [optional] 
 **filterVideosByName** | **string**| Filter for videos which name *STARTS* with the given string | [optional] 
 **filterVideosByContributor** | **string**| Filter for videos with contribution from the artist specified by ID | [optional] 
 **filterVideosByAuthor** | **string**| Filter for videos with an artist as author specified by ID | [optional] 
 **filterHasAuthor** | **bool?**| Filter for videos that have an author set if true, or that have no author if false | [optional] 
 **filterHasUploader** | **bool?**| Filter for videos that have an uploader set if true, or that have no uploader if false | [optional] 
 **filterRelatedTo** | **string**| Filter for videos that have designated a particular video as the TO of a relationship. Pattern should match VIDEO_ID or VIDEO_ID:DETAILS to match with a specific details string as well | [optional] 
 **filterFriends** | **bool?**| Filter for videos uploaded by friends. &#39;true&#39; for friends of the caller (requires user token) or a user id for a specific user&#39;s friends (requires VIDEOS_ADMIN permission) | [optional] 
 **filterDisposition** | **string**| Filter for videos a given user has a given disposition towards. USER_ID:DISPOSITION where USER_ID is the id of the user who has this disposition or &#39;me&#39; for the caller (requires user token for &#39;me&#39;) and DISPOSITION is the name of the disposition. E.G. filter_disposition&#x3D;123:like or filter_disposition&#x3D;me:favorite | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to author:ASC]

### Return type

[**PageResourceVideoResource**](PageResourceVideoResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecommentusingput1"></a>
# **UpdateCommentUsingPUT1**
> void UpdateCommentUsingPUT1 (long? videoId, long? id, string content = null)

Update video comment content 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateCommentUsingPUT1Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var videoId = 789;  // long? | The video id
            var id = 789;  // long? | The comment id
            var content = content_example;  // string | The comment content (optional) 

            try
            {
                // Update video comment content 
                apiInstance.UpdateCommentUsingPUT1(videoId, id, content);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.UpdateCommentUsingPUT1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **long?**| The video id | 
 **id** | **long?**| The comment id | 
 **content** | **string**| The comment content | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterelationshipusingput1"></a>
# **UpdateRelationshipUsingPUT1**
> void UpdateRelationshipUsingPUT1 (long? videoId, long? relationshipId, string details = null)

Update a video's relationship details

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateRelationshipUsingPUT1Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var videoId = 789;  // long? | The video id
            var relationshipId = 789;  // long? | The relationship id
            var details = details_example;  // string | The video relationship details (optional) 

            try
            {
                // Update a video's relationship details
                apiInstance.UpdateRelationshipUsingPUT1(videoId, relationshipId, details);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.UpdateRelationshipUsingPUT1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **long?**| The video id | 
 **relationshipId** | **long?**| The relationship id | 
 **details** | **string**| The video relationship details | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatevideousingput"></a>
# **UpdateVideoUsingPUT**
> void UpdateVideoUsingPUT (long? id, VideoResource videoResource = null)

Modifies a video's details

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateVideoUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var id = 789;  // long? | The video id
            var videoResource = new VideoResource(); // VideoResource | The video object (optional) 

            try
            {
                // Modifies a video's details
                apiInstance.UpdateVideoUsingPUT(id, videoResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.UpdateVideoUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The video id | 
 **videoResource** | [**VideoResource**](VideoResource.md)| The video object | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="viewvideousingpost"></a>
# **ViewVideoUsingPOST**
> void ViewVideoUsingPOST (long? id)

Increment a video's view count

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ViewVideoUsingPOSTExample
    {
        public void main()
        {
            
            var apiInstance = new MediaVideosApi();
            var id = 789;  // long? | The video id

            try
            {
                // Increment a video's view count
                apiInstance.ViewVideoUsingPOST(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.ViewVideoUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The video id | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

