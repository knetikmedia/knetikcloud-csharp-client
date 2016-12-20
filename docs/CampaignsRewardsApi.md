# IO.Swagger.Api.CampaignsRewardsApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateRewardSetUsingPOST**](CampaignsRewardsApi.md#createrewardsetusingpost) | **POST** /rewards | Create a reward set
[**DeleteRewardSetUsingDELETE**](CampaignsRewardsApi.md#deleterewardsetusingdelete) | **DELETE** /rewards/{id} | Delete a reward set
[**GetRewardSetUsingGET**](CampaignsRewardsApi.md#getrewardsetusingget) | **GET** /rewards/{id} | Get a single reward set
[**GetRewardSetsUsingGET**](CampaignsRewardsApi.md#getrewardsetsusingget) | **GET** /rewards | List and search reward sets
[**UpdateRewardSetUsingPUT**](CampaignsRewardsApi.md#updaterewardsetusingput) | **PUT** /rewards/{id} | Update a reward set


<a name="createrewardsetusingpost"></a>
# **CreateRewardSetUsingPOST**
> RewardSetResource CreateRewardSetUsingPOST (RewardSetResource rewardSetResource = null)

Create a reward set

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateRewardSetUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsRewardsApi();
            var rewardSetResource = new RewardSetResource(); // RewardSetResource | The reward set resource object (optional) 

            try
            {
                // Create a reward set
                RewardSetResource result = apiInstance.CreateRewardSetUsingPOST(rewardSetResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsRewardsApi.CreateRewardSetUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rewardSetResource** | [**RewardSetResource**](RewardSetResource.md)| The reward set resource object | [optional] 

### Return type

[**RewardSetResource**](RewardSetResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterewardsetusingdelete"></a>
# **DeleteRewardSetUsingDELETE**
> void DeleteRewardSetUsingDELETE (int? id)

Delete a reward set

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteRewardSetUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsRewardsApi();
            var id = 56;  // int? | The reward id

            try
            {
                // Delete a reward set
                apiInstance.DeleteRewardSetUsingDELETE(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsRewardsApi.DeleteRewardSetUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The reward id | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrewardsetusingget"></a>
# **GetRewardSetUsingGET**
> RewardSetResource GetRewardSetUsingGET (int? id)

Get a single reward set

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRewardSetUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new CampaignsRewardsApi();
            var id = 56;  // int? | The reward id

            try
            {
                // Get a single reward set
                RewardSetResource result = apiInstance.GetRewardSetUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsRewardsApi.GetRewardSetUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The reward id | 

### Return type

[**RewardSetResource**](RewardSetResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrewardsetsusingget"></a>
# **GetRewardSetsUsingGET**
> PageRewardSetResource GetRewardSetsUsingGET (int? size = null, int? page = null, string order = null)

List and search reward sets

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRewardSetsUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new CampaignsRewardsApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search reward sets
                PageRewardSetResource result = apiInstance.GetRewardSetsUsingGET(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsRewardsApi.GetRewardSetsUsingGET: " + e.Message );
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

[**PageRewardSetResource**](PageRewardSetResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterewardsetusingput"></a>
# **UpdateRewardSetUsingPUT**
> void UpdateRewardSetUsingPUT (int? id, RewardSetResource rewardSetResource = null)

Update a reward set

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateRewardSetUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsRewardsApi();
            var id = 56;  // int? | The reward id
            var rewardSetResource = new RewardSetResource(); // RewardSetResource | The reward set resource object (optional) 

            try
            {
                // Update a reward set
                apiInstance.UpdateRewardSetUsingPUT(id, rewardSetResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsRewardsApi.UpdateRewardSetUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The reward id | 
 **rewardSetResource** | [**RewardSetResource**](RewardSetResource.md)| The reward set resource object | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

