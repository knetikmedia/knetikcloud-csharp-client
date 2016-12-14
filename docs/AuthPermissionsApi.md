# IO.Swagger.Api.AuthPermissionsApi

All URIs are relative to *https://devsandbox.knetikcloud.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePermissionUsingPOST**](AuthPermissionsApi.md#createpermissionusingpost) | **POST** /auth/permissions | Create a new permission
[**DeletePermissionUsingDELETE**](AuthPermissionsApi.md#deletepermissionusingdelete) | **DELETE** /auth/permissions/{permission} | Delete a permission
[**GetPermissionUsingGET**](AuthPermissionsApi.md#getpermissionusingget) | **GET** /auth/permissions/{permission} | Get a single permission
[**GetPermissionUsingGET1**](AuthPermissionsApi.md#getpermissionusingget1) | **GET** /auth/permissions | List and search permissions
[**UpdatePermissionUsingPUT**](AuthPermissionsApi.md#updatepermissionusingput) | **PUT** /auth/permissions/{permission} | Update a permission


<a name="createpermissionusingpost"></a>
# **CreatePermissionUsingPOST**
> PermissionResource CreatePermissionUsingPOST (PermissionResource permissionResource = null)

Create a new permission

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreatePermissionUsingPOSTExample
    {
        public void main()
        {
            
            var apiInstance = new AuthPermissionsApi();
            var permissionResource = new PermissionResource(); // PermissionResource | The permission resource object (optional) 

            try
            {
                // Create a new permission
                PermissionResource result = apiInstance.CreatePermissionUsingPOST(permissionResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthPermissionsApi.CreatePermissionUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **permissionResource** | [**PermissionResource**](PermissionResource.md)| The permission resource object | [optional] 

### Return type

[**PermissionResource**](PermissionResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepermissionusingdelete"></a>
# **DeletePermissionUsingDELETE**
> void DeletePermissionUsingDELETE (string permission, bool? force = null)

Delete a permission

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeletePermissionUsingDELETEExample
    {
        public void main()
        {
            
            var apiInstance = new AuthPermissionsApi();
            var permission = permission_example;  // string | The permission value
            var force = true;  // bool? | If true, removes permission assigned to roles (optional) 

            try
            {
                // Delete a permission
                apiInstance.DeletePermissionUsingDELETE(permission, force);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthPermissionsApi.DeletePermissionUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **permission** | **string**| The permission value | 
 **force** | **bool?**| If true, removes permission assigned to roles | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpermissionusingget"></a>
# **GetPermissionUsingGET**
> PermissionResource GetPermissionUsingGET (string permission)

Get a single permission

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPermissionUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new AuthPermissionsApi();
            var permission = permission_example;  // string | The permission value

            try
            {
                // Get a single permission
                PermissionResource result = apiInstance.GetPermissionUsingGET(permission);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthPermissionsApi.GetPermissionUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **permission** | **string**| The permission value | 

### Return type

[**PermissionResource**](PermissionResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpermissionusingget1"></a>
# **GetPermissionUsingGET1**
> PagePermissionResource GetPermissionUsingGET1 (int? size = null, int? page = null, string order = null)

List and search permissions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPermissionUsingGET1Example
    {
        public void main()
        {
            
            var apiInstance = new AuthPermissionsApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | a comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to 1)

            try
            {
                // List and search permissions
                PagePermissionResource result = apiInstance.GetPermissionUsingGET1(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthPermissionsApi.GetPermissionUsingGET1: " + e.Message );
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

[**PagePermissionResource**](PagePermissionResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepermissionusingput"></a>
# **UpdatePermissionUsingPUT**
> void UpdatePermissionUsingPUT (string permission, PermissionResource permissionResource = null)

Update a permission

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdatePermissionUsingPUTExample
    {
        public void main()
        {
            
            var apiInstance = new AuthPermissionsApi();
            var permission = permission_example;  // string | The permission value
            var permissionResource = new PermissionResource(); // PermissionResource | The permission resource object (optional) 

            try
            {
                // Update a permission
                apiInstance.UpdatePermissionUsingPUT(permission, permissionResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthPermissionsApi.UpdatePermissionUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **permission** | **string**| The permission value | 
 **permissionResource** | [**PermissionResource**](PermissionResource.md)| The permission resource object | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

