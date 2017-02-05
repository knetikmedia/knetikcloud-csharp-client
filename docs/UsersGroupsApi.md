# IO.Swagger.Api.UsersGroupsApi

All URIs are relative to *https://integration.knetikcloud.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddGroupUsingPOST**](UsersGroupsApi.md#addgroupusingpost) | **POST** /users/groups | Adds a new group in the system
[**AddMemberUsingPOST**](UsersGroupsApi.md#addmemberusingpost) | **POST** /users/groups/{unique_name}/members | Adds a new member to the group
[**CreateGroupTemplateUsingPOST**](UsersGroupsApi.md#creategrouptemplateusingpost) | **POST** /users/groups/templates | Create a group template
[**DeleteGroupMemberUsingDELETE**](UsersGroupsApi.md#deletegroupmemberusingdelete) | **DELETE** /users/groups/{unique_name}/members/{user_id} | Removes a user from a group
[**DeleteGroupTemplateUsingDELETE**](UsersGroupsApi.md#deletegrouptemplateusingdelete) | **DELETE** /users/groups/templates/{id} | Delete a group template
[**DeleteGroupUsingDELETE**](UsersGroupsApi.md#deletegroupusingdelete) | **DELETE** /users/groups/{unique_name} | Removes a group from the system IF no resources are attached to it
[**GetGroupListUsingGET**](UsersGroupsApi.md#getgrouplistusingget) | **GET** /users/{user_id}/groups | List groups a user is in
[**GetGroupMemberUsingGET**](UsersGroupsApi.md#getgroupmemberusingget) | **GET** /users/groups/{unique_name}/members/{user_id} | Get a user from a group
[**GetGroupTemplateUsingGET**](UsersGroupsApi.md#getgrouptemplateusingget) | **GET** /users/groups/templates/{id} | Get a single group template
[**GetGroupTemplatesUsingGET**](UsersGroupsApi.md#getgrouptemplatesusingget) | **GET** /users/groups/templates | List and search group templates
[**GetGroupUsingGET**](UsersGroupsApi.md#getgroupusingget) | **GET** /users/groups/{unique_name} | Loads a specific group&#39;s details
[**SearchGroupsUsingGET**](UsersGroupsApi.md#searchgroupsusingget) | **GET** /users/groups/{unique_name}/members | Lists members of the group
[**SearchGroupsUsingGET1**](UsersGroupsApi.md#searchgroupsusingget1) | **GET** /users/groups | List and search groups
[**UpdateGroupTemplateUsingPUT**](UsersGroupsApi.md#updategrouptemplateusingput) | **PUT** /users/groups/templates/{id} | Update a group template
[**UpdateGroupUsingPUT**](UsersGroupsApi.md#updategroupusingput) | **PUT** /users/groups/{unique_name} | Modifies a group&#39;s details
[**UpdateMemberStatusUsingPUT**](UsersGroupsApi.md#updatememberstatususingput) | **PUT** /users/groups/{unique_name}/members/{user_id}/status | Change a user&#39;s status


<a name="addgroupusingpost"></a>
# **AddGroupUsingPOST**
> GroupResource AddGroupUsingPOST (GroupResource groupResource = null)

Adds a new group in the system

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddGroupUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersGroupsApi();
            var groupResource = new GroupResource(); // GroupResource | The new group (optional) 

            try
            {
                // Adds a new group in the system
                GroupResource result = apiInstance.AddGroupUsingPOST(groupResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersGroupsApi.AddGroupUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupResource** | [**GroupResource**](GroupResource.md)| The new group | [optional] 

### Return type

[**GroupResource**](GroupResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addmemberusingpost"></a>
# **AddMemberUsingPOST**
> GroupMemberResource AddMemberUsingPOST (string uniqueName, GroupMemberResource username)

Adds a new member to the group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddMemberUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersGroupsApi();
            var uniqueName = uniqueName_example;  // string | The group unique name
            var username = new GroupMemberResource(); // GroupMemberResource | The username of a user to add to the group

            try
            {
                // Adds a new member to the group
                GroupMemberResource result = apiInstance.AddMemberUsingPOST(uniqueName, username);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersGroupsApi.AddMemberUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uniqueName** | **string**| The group unique name | 
 **username** | [**GroupMemberResource**](GroupMemberResource.md)| The username of a user to add to the group | 

### Return type

[**GroupMemberResource**](GroupMemberResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creategrouptemplateusingpost"></a>
# **CreateGroupTemplateUsingPOST**
> TemplateResource CreateGroupTemplateUsingPOST (TemplateResource groupTemplateResource = null)

Create a group template

Group Templates define a type of group and the properties they have

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateGroupTemplateUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersGroupsApi();
            var groupTemplateResource = new TemplateResource(); // TemplateResource | The group template resource object (optional) 

            try
            {
                // Create a group template
                TemplateResource result = apiInstance.CreateGroupTemplateUsingPOST(groupTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersGroupsApi.CreateGroupTemplateUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupTemplateResource** | [**TemplateResource**](TemplateResource.md)| The group template resource object | [optional] 

### Return type

[**TemplateResource**](TemplateResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegroupmemberusingdelete"></a>
# **DeleteGroupMemberUsingDELETE**
> void DeleteGroupMemberUsingDELETE (string uniqueName, int? userId)

Removes a user from a group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteGroupMemberUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersGroupsApi();
            var uniqueName = uniqueName_example;  // string | The group unique name
            var userId = 56;  // int? | The id of the user to remove

            try
            {
                // Removes a user from a group
                apiInstance.DeleteGroupMemberUsingDELETE(uniqueName, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersGroupsApi.DeleteGroupMemberUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uniqueName** | **string**| The group unique name | 
 **userId** | **int?**| The id of the user to remove | 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegrouptemplateusingdelete"></a>
# **DeleteGroupTemplateUsingDELETE**
> void DeleteGroupTemplateUsingDELETE (string id, string cascade = null)

Delete a group template

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
    public class DeleteGroupTemplateUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersGroupsApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | The value needed to delete used templates (optional) 

            try
            {
                // Delete a group template
                apiInstance.DeleteGroupTemplateUsingDELETE(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersGroupsApi.DeleteGroupTemplateUsingDELETE: " + e.Message );
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

<a name="deletegroupusingdelete"></a>
# **DeleteGroupUsingDELETE**
> void DeleteGroupUsingDELETE (string uniqueName)

Removes a group from the system IF no resources are attached to it

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteGroupUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersGroupsApi();
            var uniqueName = uniqueName_example;  // string | The group unique name

            try
            {
                // Removes a group from the system IF no resources are attached to it
                apiInstance.DeleteGroupUsingDELETE(uniqueName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersGroupsApi.DeleteGroupUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uniqueName** | **string**| The group unique name | 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgrouplistusingget"></a>
# **GetGroupListUsingGET**
> List<string> GetGroupListUsingGET (int? userId)

List groups a user is in

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetGroupListUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new UsersGroupsApi();
            var userId = 56;  // int? | The id of the user

            try
            {
                // List groups a user is in
                List&lt;string&gt; result = apiInstance.GetGroupListUsingGET(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersGroupsApi.GetGroupListUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The id of the user | 

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupmemberusingget"></a>
# **GetGroupMemberUsingGET**
> GroupMemberResource GetGroupMemberUsingGET (string uniqueName, int? userId)

Get a user from a group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetGroupMemberUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new UsersGroupsApi();
            var uniqueName = uniqueName_example;  // string | The group unique name
            var userId = 56;  // int? | The id of the user

            try
            {
                // Get a user from a group
                GroupMemberResource result = apiInstance.GetGroupMemberUsingGET(uniqueName, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersGroupsApi.GetGroupMemberUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uniqueName** | **string**| The group unique name | 
 **userId** | **int?**| The id of the user | 

### Return type

[**GroupMemberResource**](GroupMemberResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgrouptemplateusingget"></a>
# **GetGroupTemplateUsingGET**
> TemplateResource GetGroupTemplateUsingGET (string id)

Get a single group template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetGroupTemplateUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersGroupsApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single group template
                TemplateResource result = apiInstance.GetGroupTemplateUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersGroupsApi.GetGroupTemplateUsingGET: " + e.Message );
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

<a name="getgrouptemplatesusingget"></a>
# **GetGroupTemplatesUsingGET**
> PageResourceTemplateResource GetGroupTemplatesUsingGET (int? size = null, int? page = null, string order = null)

List and search group templates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetGroupTemplatesUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersGroupsApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | a comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search group templates
                PageResourceTemplateResource result = apiInstance.GetGroupTemplatesUsingGET(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersGroupsApi.GetGroupTemplatesUsingGET: " + e.Message );
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
 **order** | **string**| a comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourceTemplateResource**](PageResourceTemplateResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupusingget"></a>
# **GetGroupUsingGET**
> GroupResource GetGroupUsingGET (string uniqueName)

Loads a specific group's details

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetGroupUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new UsersGroupsApi();
            var uniqueName = uniqueName_example;  // string | The group unique name

            try
            {
                // Loads a specific group's details
                GroupResource result = apiInstance.GetGroupUsingGET(uniqueName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersGroupsApi.GetGroupUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uniqueName** | **string**| The group unique name | 

### Return type

[**GroupResource**](GroupResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchgroupsusingget"></a>
# **SearchGroupsUsingGET**
> PageResourceGroupMemberResource SearchGroupsUsingGET (string uniqueName, int? size = null, int? page = null, string order = null)

Lists members of the group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchGroupsUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new UsersGroupsApi();
            var uniqueName = uniqueName_example;  // string | The group unique name
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // Lists members of the group
                PageResourceGroupMemberResource result = apiInstance.SearchGroupsUsingGET(uniqueName, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersGroupsApi.SearchGroupsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uniqueName** | **string**| The group unique name | 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourceGroupMemberResource**](PageResourceGroupMemberResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchgroupsusingget1"></a>
# **SearchGroupsUsingGET1**
> PageResourceGroupResource SearchGroupsUsingGET1 (int? size = null, int? page = null, string order = null)

List and search groups

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchGroupsUsingGET1Example
    {
        public void main()
        {
            
            var apiInstance = new UsersGroupsApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to name:ASC)

            try
            {
                // List and search groups
                PageResourceGroupResource result = apiInstance.SearchGroupsUsingGET1(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersGroupsApi.SearchGroupsUsingGET1: " + e.Message );
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
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to name:ASC]

### Return type

[**PageResourceGroupResource**](PageResourceGroupResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategrouptemplateusingput"></a>
# **UpdateGroupTemplateUsingPUT**
> void UpdateGroupTemplateUsingPUT (string id, TemplateResource groupTemplateResource = null)

Update a group template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateGroupTemplateUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersGroupsApi();
            var id = id_example;  // string | The id of the template
            var groupTemplateResource = new TemplateResource(); // TemplateResource | The group template resource object (optional) 

            try
            {
                // Update a group template
                apiInstance.UpdateGroupTemplateUsingPUT(id, groupTemplateResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersGroupsApi.UpdateGroupTemplateUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **groupTemplateResource** | [**TemplateResource**](TemplateResource.md)| The group template resource object | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategroupusingput"></a>
# **UpdateGroupUsingPUT**
> void UpdateGroupUsingPUT (string uniqueName, GroupResource groupResource = null)

Modifies a group's details

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateGroupUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersGroupsApi();
            var uniqueName = uniqueName_example;  // string | The group unique name
            var groupResource = new GroupResource(); // GroupResource | The updated group (optional) 

            try
            {
                // Modifies a group's details
                apiInstance.UpdateGroupUsingPUT(uniqueName, groupResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersGroupsApi.UpdateGroupUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uniqueName** | **string**| The group unique name | 
 **groupResource** | [**GroupResource**](GroupResource.md)| The updated group | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatememberstatususingput"></a>
# **UpdateMemberStatusUsingPUT**
> void UpdateMemberStatusUsingPUT (string uniqueName, int? userId, string status)

Change a user's status

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateMemberStatusUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersGroupsApi();
            var uniqueName = uniqueName_example;  // string | The group unique name
            var userId = 56;  // int? | The user id of the member to modify
            var status = status_example;  // string | The new status for the user

            try
            {
                // Change a user's status
                apiInstance.UpdateMemberStatusUsingPUT(uniqueName, userId, status);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersGroupsApi.UpdateMemberStatusUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uniqueName** | **string**| The group unique name | 
 **userId** | **int?**| The user id of the member to modify | 
 **status** | **string**| The new status for the user | 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

