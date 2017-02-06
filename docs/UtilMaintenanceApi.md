# IO.Swagger.Api.UtilMaintenanceApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteMaintenance**](UtilMaintenanceApi.md#deletemaintenance) | **DELETE** /maintenance | Delete maintenance info
[**GetMaintenance**](UtilMaintenanceApi.md#getmaintenance) | **GET** /maintenance | Get current maintenance info
[**UpdateMaintenance**](UtilMaintenanceApi.md#updatemaintenance) | **POST** /maintenance | Set current maintenance info
[**UpdateMaintenance1**](UtilMaintenanceApi.md#updatemaintenance1) | **PUT** /maintenance | Set current maintenance info


<a name="deletemaintenance"></a>
# **DeleteMaintenance**
> void DeleteMaintenance ()

Delete maintenance info

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteMaintenanceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UtilMaintenanceApi();

            try
            {
                // Delete maintenance info
                apiInstance.DeleteMaintenance();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilMaintenanceApi.DeleteMaintenance: " + e.Message );
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

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmaintenance"></a>
# **GetMaintenance**
> Maintenance GetMaintenance ()

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
    public class GetMaintenanceExample
    {
        public void main()
        {
            
            var apiInstance = new UtilMaintenanceApi();

            try
            {
                // Get current maintenance info
                Maintenance result = apiInstance.GetMaintenance();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilMaintenanceApi.GetMaintenance: " + e.Message );
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
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemaintenance"></a>
# **UpdateMaintenance**
> void UpdateMaintenance (Maintenance maintenance = null)

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
    public class UpdateMaintenanceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UtilMaintenanceApi();
            var maintenance = new Maintenance(); // Maintenance | The maintenance object (optional) 

            try
            {
                // Set current maintenance info
                apiInstance.UpdateMaintenance(maintenance);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilMaintenanceApi.UpdateMaintenance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **maintenance** | [**Maintenance**](Maintenance.md)| The maintenance object | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemaintenance1"></a>
# **UpdateMaintenance1**
> void UpdateMaintenance1 (Maintenance maintenance = null)

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
    public class UpdateMaintenance1Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UtilMaintenanceApi();
            var maintenance = new Maintenance(); // Maintenance | The maintenance object (optional) 

            try
            {
                // Set current maintenance info
                apiInstance.UpdateMaintenance1(maintenance);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilMaintenanceApi.UpdateMaintenance1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **maintenance** | [**Maintenance**](Maintenance.md)| The maintenance object | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

