# IO.Swagger.Api.AuthRolesApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssignClientRolesUsingPUT**](AuthRolesApi.md#assignclientrolesusingput) | **PUT** /auth/clients/{client_key}/roles | Set roles for a client
[**AssignPermissionsUsingPUT**](AuthRolesApi.md#assignpermissionsusingput) | **PUT** /auth/roles/{role}/permissions | Set permissions for a role
[**AssignUserRolesExternalUsingPUT**](AuthRolesApi.md#assignuserrolesexternalusingput) | **PUT** /auth/users/{user_id}/roles | Set roles for a user
[**CreateRoleUsingPOST**](AuthRolesApi.md#createroleusingpost) | **POST** /auth/roles | Create a new role
[**DeleteRoleUsingDELETE**](AuthRolesApi.md#deleteroleusingdelete) | **DELETE** /auth/roles/{role} | Delete a role
[**GetClientRolesUsingGET**](AuthRolesApi.md#getclientrolesusingget) | **GET** /auth/clients/{client_key}/roles | Get roles for a client
[**GetRoleUsingGET**](AuthRolesApi.md#getroleusingget) | **GET** /auth/roles/{role} | Get a single role
[**GetRolesUsingGET**](AuthRolesApi.md#getrolesusingget) | **GET** /auth/roles | List and search roles
[**GetUserRolesUsingGET**](AuthRolesApi.md#getuserrolesusingget) | **GET** /auth/users/{user_id}/roles | Get roles for a user
[**UpdateRoleUsingPUT**](AuthRolesApi.md#updateroleusingput) | **PUT** /auth/roles/{role} | Update a role


<a name="assignclientrolesusingput"></a>
# **AssignClientRolesUsingPUT**
> void AssignClientRolesUsingPUT (string clientKey, List<string> rolesList = null)

Set roles for a client

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AssignClientRolesUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthRolesApi();
            var clientKey = clientKey_example;  // string | The client key
            var rolesList = ;  // List<string> | The list of unique roles (optional) 

            try
            {
                // Set roles for a client
                apiInstance.AssignClientRolesUsingPUT(clientKey, rolesList);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthRolesApi.AssignClientRolesUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientKey** | **string**| The client key | 
 **rolesList** | **List&lt;string&gt;**| The list of unique roles | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assignpermissionsusingput"></a>
# **AssignPermissionsUsingPUT**
> void AssignPermissionsUsingPUT (string role, List<string> permissionsList = null)

Set permissions for a role

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AssignPermissionsUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthRolesApi();
            var role = role_example;  // string | The role value
            var permissionsList = ;  // List<string> | The list of unique permissions (optional) 

            try
            {
                // Set permissions for a role
                apiInstance.AssignPermissionsUsingPUT(role, permissionsList);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthRolesApi.AssignPermissionsUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| The role value | 
 **permissionsList** | **List&lt;string&gt;**| The list of unique permissions | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assignuserrolesexternalusingput"></a>
# **AssignUserRolesExternalUsingPUT**
> void AssignUserRolesExternalUsingPUT (int? userId, List<string> rolesList = null)

Set roles for a user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AssignUserRolesExternalUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthRolesApi();
            var userId = 56;  // int? | The user's id
            var rolesList = ;  // List<string> | The list of unique roles (optional) 

            try
            {
                // Set roles for a user
                apiInstance.AssignUserRolesExternalUsingPUT(userId, rolesList);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthRolesApi.AssignUserRolesExternalUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The user&#39;s id | 
 **rolesList** | **List&lt;string&gt;**| The list of unique roles | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createroleusingpost"></a>
# **CreateRoleUsingPOST**
> RoleResource CreateRoleUsingPOST (RoleResource roleResource = null)

Create a new role

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateRoleUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthRolesApi();
            var roleResource = new RoleResource(); // RoleResource | The role resource object (optional) 

            try
            {
                // Create a new role
                RoleResource result = apiInstance.CreateRoleUsingPOST(roleResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthRolesApi.CreateRoleUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleResource** | [**RoleResource**](RoleResource.md)| The role resource object | [optional] 

### Return type

[**RoleResource**](RoleResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteroleusingdelete"></a>
# **DeleteRoleUsingDELETE**
> void DeleteRoleUsingDELETE (string role, bool? force = null)

Delete a role

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteRoleUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthRolesApi();
            var role = role_example;  // string | The role value
            var force = true;  // bool? | If true, removes role from users/clients (optional) 

            try
            {
                // Delete a role
                apiInstance.DeleteRoleUsingDELETE(role, force);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthRolesApi.DeleteRoleUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| The role value | 
 **force** | **bool?**| If true, removes role from users/clients | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclientrolesusingget"></a>
# **GetClientRolesUsingGET**
> List<RoleResource> GetClientRolesUsingGET (string clientKey)

Get roles for a client

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientRolesUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthRolesApi();
            var clientKey = clientKey_example;  // string | The client key

            try
            {
                // Get roles for a client
                List&lt;RoleResource&gt; result = apiInstance.GetClientRolesUsingGET(clientKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthRolesApi.GetClientRolesUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientKey** | **string**| The client key | 

### Return type

[**List<RoleResource>**](RoleResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getroleusingget"></a>
# **GetRoleUsingGET**
> RoleResource GetRoleUsingGET (string role)

Get a single role

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRoleUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthRolesApi();
            var role = role_example;  // string | The role value

            try
            {
                // Get a single role
                RoleResource result = apiInstance.GetRoleUsingGET(role);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthRolesApi.GetRoleUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| The role value | 

### Return type

[**RoleResource**](RoleResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrolesusingget"></a>
# **GetRolesUsingGET**
> PageRoleResource GetRolesUsingGET (int? size = null, int? page = null, string order = null)

List and search roles

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRolesUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthRolesApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | a comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to 1)

            try
            {
                // List and search roles
                PageRoleResource result = apiInstance.GetRolesUsingGET(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthRolesApi.GetRolesUsingGET: " + e.Message );
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
 **order** | **string**| a comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to 1]

### Return type

[**PageRoleResource**](PageRoleResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserrolesusingget"></a>
# **GetUserRolesUsingGET**
> List<RoleResource> GetUserRolesUsingGET (int? userId)

Get roles for a user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserRolesUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthRolesApi();
            var userId = 56;  // int? | The user's id

            try
            {
                // Get roles for a user
                List&lt;RoleResource&gt; result = apiInstance.GetUserRolesUsingGET(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthRolesApi.GetUserRolesUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The user&#39;s id | 

### Return type

[**List<RoleResource>**](RoleResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateroleusingput"></a>
# **UpdateRoleUsingPUT**
> void UpdateRoleUsingPUT (string role, RoleResource roleResource = null)

Update a role

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateRoleUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthRolesApi();
            var role = role_example;  // string | The role value
            var roleResource = new RoleResource(); // RoleResource | The role resource object (optional) 

            try
            {
                // Update a role
                apiInstance.UpdateRoleUsingPUT(role, roleResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthRolesApi.UpdateRoleUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| The role value | 
 **roleResource** | [**RoleResource**](RoleResource.md)| The role resource object | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

