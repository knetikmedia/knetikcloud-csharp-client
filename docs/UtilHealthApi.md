# IO.Swagger.Api.UtilHealthApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetHealthInfoUsingGET**](UtilHealthApi.md#gethealthinfousingget) | **GET** /health | Get health info


<a name="gethealthinfousingget"></a>
# **GetHealthInfoUsingGET**
> Object GetHealthInfoUsingGET ()

Get health info

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetHealthInfoUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new UtilHealthApi();

            try
            {
                // Get health info
                Object result = apiInstance.GetHealthInfoUsingGET();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilHealthApi.GetHealthInfoUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

