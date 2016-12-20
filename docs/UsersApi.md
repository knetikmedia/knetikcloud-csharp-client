# IO.Swagger.Api.UsersApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddTagUsingPOST1**](UsersApi.md#addtagusingpost1) | **POST** /users/{user_id}/tags | Add a tag to a user
[**CreateUserTemplateUsingPOST**](UsersApi.md#createusertemplateusingpost) | **POST** /users/templates | Create a user template
[**DeleteUserTemplateUsingDELETE**](UsersApi.md#deleteusertemplateusingdelete) | **DELETE** /users/templates/{id} | Delete a user template
[**DoPasswordResetUsingPUT**](UsersApi.md#dopasswordresetusingput) | **PUT** /users/{id}/password-reset | Choose a new password after a reset
[**GetTagsUsingGET3**](UsersApi.md#gettagsusingget3) | **GET** /users/{user_id}/tags | List tags for a user
[**GetUserTemplateUsingGET**](UsersApi.md#getusertemplateusingget) | **GET** /users/templates/{id} | Get a single user template
[**GetUserTemplatesUsingGET**](UsersApi.md#getusertemplatesusingget) | **GET** /users/templates | List and search user templates
[**GetUserUsingGET**](UsersApi.md#getuserusingget) | **GET** /users/{id} | Get a single user
[**GetUsersUsingGET**](UsersApi.md#getusersusingget) | **GET** /users | List and search users
[**InitiatePasswordResetUsingPOST**](UsersApi.md#initiatepasswordresetusingpost) | **POST** /users/{id}/password-reset | Reset a user&#39;s password
[**RegisterUserUsingPOST**](UsersApi.md#registeruserusingpost) | **POST** /users | Register a new user
[**RemoveTagUsingDELETE1**](UsersApi.md#removetagusingdelete1) | **DELETE** /users/{user_id}/tags/{tag} | Remove a tag from a user
[**SetPasswordUsingPUT**](UsersApi.md#setpasswordusingput) | **PUT** /users/{id}/password | Set a user&#39;s password
[**UpdateUserTemplateUsingPUT**](UsersApi.md#updateusertemplateusingput) | **PUT** /users/templates/{id} | Update a user template
[**UpdateUserUsingPUT**](UsersApi.md#updateuserusingput) | **PUT** /users/{id} | Update a user&#39;s info


<a name="addtagusingpost1"></a>
# **AddTagUsingPOST1**
> void AddTagUsingPOST1 (int? userId, string tag)

Add a tag to a user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddTagUsingPOST1Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = 56;  // int? | The id of the user
            var tag = tag_example;  // string | tag

            try
            {
                // Add a tag to a user
                apiInstance.AddTagUsingPOST1(userId, tag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.AddTagUsingPOST1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The id of the user | 
 **tag** | **string**| tag | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createusertemplateusingpost"></a>
# **CreateUserTemplateUsingPOST**
> TemplateResource CreateUserTemplateUsingPOST (TemplateResource userTemplateResource = null)

Create a user template

User Templates define a type of user and the properties they have

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateUserTemplateUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userTemplateResource = new TemplateResource(); // TemplateResource | The user template resource object (optional) 

            try
            {
                // Create a user template
                TemplateResource result = apiInstance.CreateUserTemplateUsingPOST(userTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.CreateUserTemplateUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userTemplateResource** | [**TemplateResource**](TemplateResource.md)| The user template resource object | [optional] 

### Return type

[**TemplateResource**](TemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteusertemplateusingdelete"></a>
# **DeleteUserTemplateUsingDELETE**
> void DeleteUserTemplateUsingDELETE (string id, string cascade = null)

Delete a user template

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
    public class DeleteUserTemplateUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | The value needed to delete used templates (optional) 

            try
            {
                // Delete a user template
                apiInstance.DeleteUserTemplateUsingDELETE(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUserTemplateUsingDELETE: " + e.Message );
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
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dopasswordresetusingput"></a>
# **DoPasswordResetUsingPUT**
> void DoPasswordResetUsingPUT (int? id, NewPasswordRequest newPasswordRequest = null)

Choose a new password after a reset

Finish resetting a user's password using the secret provided from the password-reset endpoint.  Password should be in plain text and will be encrypted on receipt. Use SSL for security.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DoPasswordResetUsingPUTExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var id = 56;  // int? | The id of the user
            var newPasswordRequest = new NewPasswordRequest(); // NewPasswordRequest | The new password request object (optional) 

            try
            {
                // Choose a new password after a reset
                apiInstance.DoPasswordResetUsingPUT(id, newPasswordRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DoPasswordResetUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the user | 
 **newPasswordRequest** | [**NewPasswordRequest**](NewPasswordRequest.md)| The new password request object | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettagsusingget3"></a>
# **GetTagsUsingGET3**
> List<string> GetTagsUsingGET3 (int? userId)

List tags for a user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTagsUsingGET3Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = 56;  // int? | The id of the user

            try
            {
                // List tags for a user
                List&lt;string&gt; result = apiInstance.GetTagsUsingGET3(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetTagsUsingGET3: " + e.Message );
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

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusertemplateusingget"></a>
# **GetUserTemplateUsingGET**
> TemplateResource GetUserTemplateUsingGET (string id)

Get a single user template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserTemplateUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single user template
                TemplateResource result = apiInstance.GetUserTemplateUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserTemplateUsingGET: " + e.Message );
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
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusertemplatesusingget"></a>
# **GetUserTemplatesUsingGET**
> PageTemplateResource GetUserTemplatesUsingGET (int? size = null, int? page = null, string order = null)

List and search user templates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserTemplatesUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search user templates
                PageTemplateResource result = apiInstance.GetUserTemplatesUsingGET(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserTemplatesUsingGET: " + e.Message );
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

[**PageTemplateResource**](PageTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserusingget"></a>
# **GetUserUsingGET**
> UserResource GetUserUsingGET (string id)

Get a single user

Additional private info is included as USERS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var id = id_example;  // string | The id of the user or 'me'

            try
            {
                // Get a single user
                UserResource result = apiInstance.GetUserUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the user or &#39;me&#39; | 

### Return type

[**UserResource**](UserResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusersusingget"></a>
# **GetUsersUsingGET**
> PageUserBaseResource GetUsersUsingGET (string filterRole = null, string filterDisplayname = null, string filterEmail = null, string filterFirstname = null, string filterFullname = null, string filterLastname = null, string filterUsername = null, string filterTag = null, string filterGroup = null, int? size = null, int? page = null, string order = null)

List and search users

Additional private info is included as USERS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUsersUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var filterRole = filterRole_example;  // string | Filter for users whose roles has the provided role (optional) 
            var filterDisplayname = filterDisplayname_example;  // string | Filter for users whose display name starts with provided string. (optional) 
            var filterEmail = filterEmail_example;  // string | Filter for users whose email starts with provided string. Requires USERS_ADMIN permission (optional) 
            var filterFirstname = filterFirstname_example;  // string | Filter for users whose first name starts with provided string. Requires USERS_ADMIN permission (optional) 
            var filterFullname = filterFullname_example;  // string | Filter for users whose full name starts with provided string. Requires USERS_ADMIN permission (optional) 
            var filterLastname = filterLastname_example;  // string | Filter for users whose last name starts with provided string. Requires USERS_ADMIN permission (optional) 
            var filterUsername = filterUsername_example;  // string | Filter for users whose username starts with the provided string. Requires USERS_ADMIN permission (optional) 
            var filterTag = filterTag_example;  // string | Filter for users who have a given tag (optional) 
            var filterGroup = filterGroup_example;  // string | Filter for users in a given group, by unique name (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search users
                PageUserBaseResource result = apiInstance.GetUsersUsingGET(filterRole, filterDisplayname, filterEmail, filterFirstname, filterFullname, filterLastname, filterUsername, filterTag, filterGroup, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUsersUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterRole** | **string**| Filter for users whose roles has the provided role | [optional] 
 **filterDisplayname** | **string**| Filter for users whose display name starts with provided string. | [optional] 
 **filterEmail** | **string**| Filter for users whose email starts with provided string. Requires USERS_ADMIN permission | [optional] 
 **filterFirstname** | **string**| Filter for users whose first name starts with provided string. Requires USERS_ADMIN permission | [optional] 
 **filterFullname** | **string**| Filter for users whose full name starts with provided string. Requires USERS_ADMIN permission | [optional] 
 **filterLastname** | **string**| Filter for users whose last name starts with provided string. Requires USERS_ADMIN permission | [optional] 
 **filterUsername** | **string**| Filter for users whose username starts with the provided string. Requires USERS_ADMIN permission | [optional] 
 **filterTag** | **string**| Filter for users who have a given tag | [optional] 
 **filterGroup** | **string**| Filter for users in a given group, by unique name | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageUserBaseResource**](PageUserBaseResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="initiatepasswordresetusingpost"></a>
# **InitiatePasswordResetUsingPOST**
> void InitiatePasswordResetUsingPOST (int? id)

Reset a user's password

A reset code will be generated and a 'forgot_password' BRE event will be fired with that code; this can be routed to the user as needed and submitted to the 'choose a new password' endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InitiatePasswordResetUsingPOSTExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var id = 56;  // int? | The id of the user

            try
            {
                // Reset a user's password
                apiInstance.InitiatePasswordResetUsingPOST(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.InitiatePasswordResetUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the user | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="registeruserusingpost"></a>
# **RegisterUserUsingPOST**
> UserResource RegisterUserUsingPOST (UserResource userResource = null)

Register a new user

Password should be in plain text and will be encrypted on receipt. Use SSL for security

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RegisterUserUsingPOSTExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var userResource = new UserResource(); // UserResource | The user resource object (optional) 

            try
            {
                // Register a new user
                UserResource result = apiInstance.RegisterUserUsingPOST(userResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.RegisterUserUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userResource** | [**UserResource**](UserResource.md)| The user resource object | [optional] 

### Return type

[**UserResource**](UserResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removetagusingdelete1"></a>
# **RemoveTagUsingDELETE1**
> void RemoveTagUsingDELETE1 (int? userId, string tag)

Remove a tag from a user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemoveTagUsingDELETE1Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = 56;  // int? | The id of the user
            var tag = tag_example;  // string | The tag to remove

            try
            {
                // Remove a tag from a user
                apiInstance.RemoveTagUsingDELETE1(userId, tag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.RemoveTagUsingDELETE1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The id of the user | 
 **tag** | **string**| The tag to remove | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setpasswordusingput"></a>
# **SetPasswordUsingPUT**
> void SetPasswordUsingPUT (int? id, string password = null)

Set a user's password

Password should be in plain text and will be encrypted on receipt. Use SSL for security.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetPasswordUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var id = 56;  // int? | The id of the user
            var password = password_example;  // string | The new plain text password (optional) 

            try
            {
                // Set a user's password
                apiInstance.SetPasswordUsingPUT(id, password);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.SetPasswordUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the user | 
 **password** | **string**| The new plain text password | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateusertemplateusingput"></a>
# **UpdateUserTemplateUsingPUT**
> void UpdateUserTemplateUsingPUT (string id, TemplateResource userTemplateResource = null)

Update a user template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateUserTemplateUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var id = id_example;  // string | The id of the template
            var userTemplateResource = new TemplateResource(); // TemplateResource | The user template resource object (optional) 

            try
            {
                // Update a user template
                apiInstance.UpdateUserTemplateUsingPUT(id, userTemplateResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateUserTemplateUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **userTemplateResource** | [**TemplateResource**](TemplateResource.md)| The user template resource object | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuserusingput"></a>
# **UpdateUserUsingPUT**
> void UpdateUserUsingPUT (string id, UserResource userResource = null)

Update a user's info

Password will not be edited on this endpoint, use password specific endpoints.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateUserUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var id = id_example;  // string | The id of the user or 'me'
            var userResource = new UserResource(); // UserResource | The user resource object (optional) 

            try
            {
                // Update a user's info
                apiInstance.UpdateUserUsingPUT(id, userResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateUserUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the user or &#39;me&#39; | 
 **userResource** | [**UserResource**](UserResource.md)| The user resource object | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

