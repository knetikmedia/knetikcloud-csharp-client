# IO.Swagger.Api.UsersFriendshipsApi

All URIs are relative to *https://integration.knetikcloud.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddFriendUsingPOST**](UsersFriendshipsApi.md#addfriendusingpost) | **POST** /users/{user_id}/friends/{id} | Add a friend
[**ConnectUsingTokenUsingPOST**](UsersFriendshipsApi.md#connectusingtokenusingpost) | **POST** /users/{user_id}/friends/tokens | Redeem friendship token
[**GetFriendsUsingGET**](UsersFriendshipsApi.md#getfriendsusingget) | **GET** /users/{user_id}/friends | Get friends list
[**GetInviteTokenUsingGET**](UsersFriendshipsApi.md#getinvitetokenusingget) | **GET** /users/{user_id}/invite-token | Returns the invite token
[**GetInvitesUsingGET**](UsersFriendshipsApi.md#getinvitesusingget) | **GET** /users/{user_id}/invites | Get pending invites
[**RemoveFriendUsingDELETE**](UsersFriendshipsApi.md#removefriendusingdelete) | **DELETE** /users/{user_id}/friends/{id} | Remove or decline a friend


<a name="addfriendusingpost"></a>
# **AddFriendUsingPOST**
> void AddFriendUsingPOST (string userId, int? id)

Add a friend

As a user, either creates or confirm a pending request. As an admin, call this endpoint twice while inverting the IDs to create a confirmed friendship.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddFriendUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersFriendshipsApi();
            var userId = userId_example;  // string | The id of the user or 'me' if logged in
            var id = 56;  // int? | The id of the user to befriend

            try
            {
                // Add a friend
                apiInstance.AddFriendUsingPOST(userId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersFriendshipsApi.AddFriendUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the user or &#39;me&#39; if logged in | 
 **id** | **int?**| The id of the user to befriend | 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="connectusingtokenusingpost"></a>
# **ConnectUsingTokenUsingPOST**
> void ConnectUsingTokenUsingPOST (string userId, string token = null)

Redeem friendship token

Immediately connects the requested user with the user mapped by the provided invite token

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConnectUsingTokenUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersFriendshipsApi();
            var userId = userId_example;  // string | The id of the user or 'me' if logged in
            var token = token_example;  // string | The invite token (optional) 

            try
            {
                // Redeem friendship token
                apiInstance.ConnectUsingTokenUsingPOST(userId, token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersFriendshipsApi.ConnectUsingTokenUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the user or &#39;me&#39; if logged in | 
 **token** | **string**| The invite token | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfriendsusingget"></a>
# **GetFriendsUsingGET**
> PageResourceSimpleUserResource GetFriendsUsingGET (string userId, int? size = null, int? page = null, string order = null)

Get friends list

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFriendsUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersFriendshipsApi();
            var userId = userId_example;  // string | The id of the user or 'me'
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // Get friends list
                PageResourceSimpleUserResource result = apiInstance.GetFriendsUsingGET(userId, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersFriendshipsApi.GetFriendsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the user or &#39;me&#39; | 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourceSimpleUserResource**](PageResourceSimpleUserResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvitetokenusingget"></a>
# **GetInviteTokenUsingGET**
> string GetInviteTokenUsingGET (string userId)

Returns the invite token

This is a unique invite token that allows direct connection to the request user.  Exposing that token presents privacy issues if the token is leaked. Use friend request flow instead if confirmation is required

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetInviteTokenUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersFriendshipsApi();
            var userId = userId_example;  // string | The id of the user or 'me' if logged in

            try
            {
                // Returns the invite token
                string result = apiInstance.GetInviteTokenUsingGET(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersFriendshipsApi.GetInviteTokenUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the user or &#39;me&#39; if logged in | 

### Return type

**string**

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvitesusingget"></a>
# **GetInvitesUsingGET**
> PageResourceSimpleUserResource GetInvitesUsingGET (string userId, int? size = null, int? page = null, string order = null)

Get pending invites

Invites that the specified user received

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetInvitesUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersFriendshipsApi();
            var userId = userId_example;  // string | The id of the user or 'me'
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // Get pending invites
                PageResourceSimpleUserResource result = apiInstance.GetInvitesUsingGET(userId, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersFriendshipsApi.GetInvitesUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the user or &#39;me&#39; | 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourceSimpleUserResource**](PageResourceSimpleUserResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removefriendusingdelete"></a>
# **RemoveFriendUsingDELETE**
> void RemoveFriendUsingDELETE (string userId, int? id)

Remove or decline a friend

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemoveFriendUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersFriendshipsApi();
            var userId = userId_example;  // string | The id of the user or 'me' if logged in
            var id = 56;  // int? | The id of the user to befriend

            try
            {
                // Remove or decline a friend
                apiInstance.RemoveFriendUsingDELETE(userId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersFriendshipsApi.RemoveFriendUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the user or &#39;me&#39; if logged in | 
 **id** | **int?**| The id of the user to befriend | 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

