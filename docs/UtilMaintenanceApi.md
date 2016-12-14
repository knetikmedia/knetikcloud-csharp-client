# IO.Swagger.Api.UtilMaintenanceApi

All URIs are relative to *https://devsandbox.knetikcloud.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteUsingDELETE1**](UtilMaintenanceApi.md#deleteusingdelete1) | **DELETE** /maintenance | Remove maintenance info
[**GetUsingGET1**](UtilMaintenanceApi.md#getusingget1) | **GET** /maintenance | Get current maintenance info
[**PostUsingPOST**](UtilMaintenanceApi.md#postusingpost) | **POST** /maintenance | Set current maintenance info
[**PostUsingPUT**](UtilMaintenanceApi.md#postusingput) | **PUT** /maintenance | Set current maintenance info


<a name="deleteusingdelete1"></a>
# **DeleteUsingDELETE1**
> void DeleteUsingDELETE1 ()

Remove maintenance info

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteUsingDELETE1Example
    {
        public void main()
        {
            
            var apiInstance = new UtilMaintenanceApi();

            try
            {
                // Remove maintenance info
                apiInstance.DeleteUsingDELETE1();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilMaintenanceApi.DeleteUsingDELETE1: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusingget1"></a>
# **GetUsingGET1**
> Maintenance GetUsingGET1 ()

Get current maintenance info

Get current maintenance info. 404 if no maintenance.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUsingGET1Example
    {
        public void main()
        {
            
            var apiInstance = new UtilMaintenanceApi();

            try
            {
                // Get current maintenance info
                Maintenance result = apiInstance.GetUsingGET1();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilMaintenanceApi.GetUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Maintenance**](Maintenance.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postusingpost"></a>
# **PostUsingPOST**
> void PostUsingPOST (Maintenance maintenance = null)

Set current maintenance info

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostUsingPOSTExample
    {
        public void main()
        {
            
            var apiInstance = new UtilMaintenanceApi();
            var maintenance = new Maintenance(); // Maintenance | The Maintenance Object (optional) 

            try
            {
                // Set current maintenance info
                apiInstance.PostUsingPOST(maintenance);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilMaintenanceApi.PostUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **maintenance** | [**Maintenance**](Maintenance.md)| The Maintenance Object | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postusingput"></a>
# **PostUsingPUT**
> void PostUsingPUT (Maintenance maintenance = null)

Set current maintenance info

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostUsingPUTExample
    {
        public void main()
        {
            
            var apiInstance = new UtilMaintenanceApi();
            var maintenance = new Maintenance(); // Maintenance | The Maintenance Object (optional) 

            try
            {
                // Set current maintenance info
                apiInstance.PostUsingPUT(maintenance);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilMaintenanceApi.PostUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **maintenance** | [**Maintenance**](Maintenance.md)| The Maintenance Object | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

