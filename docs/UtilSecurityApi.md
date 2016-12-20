# IO.Swagger.Api.UtilSecurityApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetUserLocationLogUsingGET**](UtilSecurityApi.md#getuserlocationlogusingget) | **GET** /security/country-log | Returns the authentication log for a user
[**UserUsingGET**](UtilSecurityApi.md#userusingget) | **GET** /me | Returns the authentication token details. Use /users endpoint for detailed user&#39;s info


<a name="getuserlocationlogusingget"></a>
# **GetUserLocationLogUsingGET**
> PageLocationLogResource GetUserLocationLogUsingGET (int? userId = null)

Returns the authentication log for a user

A log entry is recorded everytime a user requests a new token. Standard pagination available

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserLocationLogUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UtilSecurityApi();
            var userId = 56;  // int? | The user id (optional) 

            try
            {
                // Returns the authentication log for a user
                PageLocationLogResource result = apiInstance.GetUserLocationLogUsingGET(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilSecurityApi.GetUserLocationLogUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The user id | [optional] 

### Return type

[**PageLocationLogResource**](PageLocationLogResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userusingget"></a>
# **UserUsingGET**
> TokenDetailsResource UserUsingGET ()

Returns the authentication token details. Use /users endpoint for detailed user's info

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UtilSecurityApi();

            try
            {
                // Returns the authentication token details. Use /users endpoint for detailed user's info
                TokenDetailsResource result = apiInstance.UserUsingGET();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilSecurityApi.UserUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TokenDetailsResource**](TokenDetailsResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

