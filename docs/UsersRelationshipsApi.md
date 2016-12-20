# IO.Swagger.Api.UsersRelationshipsApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddRelationshipUsingPOST**](UsersRelationshipsApi.md#addrelationshipusingpost) | **POST** /users/relationships | Create a user relationship
[**DeleteRelationshipUsingDELETE**](UsersRelationshipsApi.md#deleterelationshipusingdelete) | **DELETE** /users/relationships/{id} | Delete a user relationship
[**GetRelationshipUsingGET**](UsersRelationshipsApi.md#getrelationshipusingget) | **GET** /users/relationships/{id} | Get a user relationship
[**GetRelationshipsUsingGET**](UsersRelationshipsApi.md#getrelationshipsusingget) | **GET** /users/relationships | Get a list of user relationships
[**UpdateRelationshipUsingPUT**](UsersRelationshipsApi.md#updaterelationshipusingput) | **PUT** /users/relationships/{id} | Update a user relationship


<a name="addrelationshipusingpost"></a>
# **AddRelationshipUsingPOST**
> UserRelationshipResource AddRelationshipUsingPOST (UserRelationshipResource relationship = null)

Create a user relationship

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddRelationshipUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersRelationshipsApi();
            var relationship = new UserRelationshipResource(); // UserRelationshipResource | The new relationship (optional) 

            try
            {
                // Create a user relationship
                UserRelationshipResource result = apiInstance.AddRelationshipUsingPOST(relationship);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersRelationshipsApi.AddRelationshipUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **relationship** | [**UserRelationshipResource**](UserRelationshipResource.md)| The new relationship | [optional] 

### Return type

[**UserRelationshipResource**](UserRelationshipResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterelationshipusingdelete"></a>
# **DeleteRelationshipUsingDELETE**
> void DeleteRelationshipUsingDELETE (long? id)

Delete a user relationship

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteRelationshipUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersRelationshipsApi();
            var id = 789;  // long? | The id of the relationship

            try
            {
                // Delete a user relationship
                apiInstance.DeleteRelationshipUsingDELETE(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersRelationshipsApi.DeleteRelationshipUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The id of the relationship | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrelationshipusingget"></a>
# **GetRelationshipUsingGET**
> UserRelationshipResource GetRelationshipUsingGET (long? id)

Get a user relationship

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRelationshipUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersRelationshipsApi();
            var id = 789;  // long? | The id of the relationship

            try
            {
                // Get a user relationship
                UserRelationshipResource result = apiInstance.GetRelationshipUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersRelationshipsApi.GetRelationshipUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The id of the relationship | 

### Return type

[**UserRelationshipResource**](UserRelationshipResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrelationshipsusingget"></a>
# **GetRelationshipsUsingGET**
> PageUserRelationshipResource GetRelationshipsUsingGET ()

Get a list of user relationships

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRelationshipsUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersRelationshipsApi();

            try
            {
                // Get a list of user relationships
                PageUserRelationshipResource result = apiInstance.GetRelationshipsUsingGET();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersRelationshipsApi.GetRelationshipsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PageUserRelationshipResource**](PageUserRelationshipResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterelationshipusingput"></a>
# **UpdateRelationshipUsingPUT**
> UserRelationshipResource UpdateRelationshipUsingPUT (long? id, UserRelationshipResource relationship = null)

Update a user relationship

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateRelationshipUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersRelationshipsApi();
            var id = 789;  // long? | The id of the relationship
            var relationship = new UserRelationshipResource(); // UserRelationshipResource | The new relationship (optional) 

            try
            {
                // Update a user relationship
                UserRelationshipResource result = apiInstance.UpdateRelationshipUsingPUT(id, relationship);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersRelationshipsApi.UpdateRelationshipUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The id of the relationship | 
 **relationship** | [**UserRelationshipResource**](UserRelationshipResource.md)| The new relationship | [optional] 

### Return type

[**UserRelationshipResource**](UserRelationshipResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

