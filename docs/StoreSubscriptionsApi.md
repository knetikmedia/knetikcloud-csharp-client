# IO.Swagger.Api.StoreSubscriptionsApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSubscriptionTemplateUsingPOST**](StoreSubscriptionsApi.md#createsubscriptiontemplateusingpost) | **POST** /subscriptions/templates | Create a subscription template
[**CreateSubscriptionUsingPOST**](StoreSubscriptionsApi.md#createsubscriptionusingpost) | **POST** /subscriptions | Creates a subscription item and associated plans
[**DeletePlanUsingDELETE**](StoreSubscriptionsApi.md#deleteplanusingdelete) | **DELETE** /subscriptions/{id}/plans/{plan_id} | Delete a subscription plan
[**DeleteSubscriptionTemplateUsingDELETE**](StoreSubscriptionsApi.md#deletesubscriptiontemplateusingdelete) | **DELETE** /subscriptions/templates/{id} | Delete a subscription template
[**GetSubscriptionTemplateUsingGET**](StoreSubscriptionsApi.md#getsubscriptiontemplateusingget) | **GET** /subscriptions/templates/{id} | Get a single subscription template
[**GetSubscriptionTemplatesUsingGET**](StoreSubscriptionsApi.md#getsubscriptiontemplatesusingget) | **GET** /subscriptions/templates | List and search subscription templates
[**GetSubscriptionUsingGET**](StoreSubscriptionsApi.md#getsubscriptionusingget) | **GET** /subscriptions/{id} | Retrieve a single subscription item and associated plans
[**ListSubscriptionsUsingGET**](StoreSubscriptionsApi.md#listsubscriptionsusingget) | **GET** /subscriptions | List available subscription items and associated plans
[**ProcessUsingPOST**](StoreSubscriptionsApi.md#processusingpost) | **POST** /subscriptions/process | Processes subscriptions and charge dues
[**UpdateSubscriptionTemplateUsingPUT**](StoreSubscriptionsApi.md#updatesubscriptiontemplateusingput) | **PUT** /subscriptions/templates/{id} | Update a subscription template
[**UpdateSubscriptionUsingPUT**](StoreSubscriptionsApi.md#updatesubscriptionusingput) | **PUT** /subscriptions/{id} | Updates a subscription item and associated plans


<a name="createsubscriptiontemplateusingpost"></a>
# **CreateSubscriptionTemplateUsingPOST**
> SubscriptionTemplateResource CreateSubscriptionTemplateUsingPOST (SubscriptionTemplateResource subscriptionTemplateResource = null)

Create a subscription template

Subscription Templates define a type of subscription and the properties they have.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateSubscriptionTemplateUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreSubscriptionsApi();
            var subscriptionTemplateResource = new SubscriptionTemplateResource(); // SubscriptionTemplateResource | The new subscription template (optional) 

            try
            {
                // Create a subscription template
                SubscriptionTemplateResource result = apiInstance.CreateSubscriptionTemplateUsingPOST(subscriptionTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreSubscriptionsApi.CreateSubscriptionTemplateUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subscriptionTemplateResource** | [**SubscriptionTemplateResource**](SubscriptionTemplateResource.md)| The new subscription template | [optional] 

### Return type

[**SubscriptionTemplateResource**](SubscriptionTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsubscriptionusingpost"></a>
# **CreateSubscriptionUsingPOST**
> SubscriptionResource CreateSubscriptionUsingPOST (SubscriptionResource subscriptionResource = null)

Creates a subscription item and associated plans

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateSubscriptionUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreSubscriptionsApi();
            var subscriptionResource = new SubscriptionResource(); // SubscriptionResource | The subscription to be created (optional) 

            try
            {
                // Creates a subscription item and associated plans
                SubscriptionResource result = apiInstance.CreateSubscriptionUsingPOST(subscriptionResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreSubscriptionsApi.CreateSubscriptionUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subscriptionResource** | [**SubscriptionResource**](SubscriptionResource.md)| The subscription to be created | [optional] 

### Return type

[**SubscriptionResource**](SubscriptionResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteplanusingdelete"></a>
# **DeletePlanUsingDELETE**
> void DeletePlanUsingDELETE (int? id, string planId)

Delete a subscription plan

Must not be locked or a migration target

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeletePlanUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreSubscriptionsApi();
            var id = 56;  // int? | The id of the subscription
            var planId = planId_example;  // string | The id of the plan

            try
            {
                // Delete a subscription plan
                apiInstance.DeletePlanUsingDELETE(id, planId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreSubscriptionsApi.DeletePlanUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the subscription | 
 **planId** | **string**| The id of the plan | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesubscriptiontemplateusingdelete"></a>
# **DeleteSubscriptionTemplateUsingDELETE**
> void DeleteSubscriptionTemplateUsingDELETE (string id, string cascade = null)

Delete a subscription template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteSubscriptionTemplateUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreSubscriptionsApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | force deleting the template if it's attached to other objects, cascade = detach (optional) 

            try
            {
                // Delete a subscription template
                apiInstance.DeleteSubscriptionTemplateUsingDELETE(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreSubscriptionsApi.DeleteSubscriptionTemplateUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **cascade** | **string**| force deleting the template if it&#39;s attached to other objects, cascade &#x3D; detach | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscriptiontemplateusingget"></a>
# **GetSubscriptionTemplateUsingGET**
> SubscriptionTemplateResource GetSubscriptionTemplateUsingGET (string id)

Get a single subscription template

Subscription Templates define a type of subscription and the properties they have.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSubscriptionTemplateUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreSubscriptionsApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single subscription template
                SubscriptionTemplateResource result = apiInstance.GetSubscriptionTemplateUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreSubscriptionsApi.GetSubscriptionTemplateUsingGET: " + e.Message );
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

[**SubscriptionTemplateResource**](SubscriptionTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscriptiontemplatesusingget"></a>
# **GetSubscriptionTemplatesUsingGET**
> PageSubscriptionTemplateResource GetSubscriptionTemplatesUsingGET (int? size = null, int? page = null, string order = null)

List and search subscription templates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSubscriptionTemplatesUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreSubscriptionsApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to 1)

            try
            {
                // List and search subscription templates
                PageSubscriptionTemplateResource result = apiInstance.GetSubscriptionTemplatesUsingGET(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreSubscriptionsApi.GetSubscriptionTemplatesUsingGET: " + e.Message );
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
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to 1]

### Return type

[**PageSubscriptionTemplateResource**](PageSubscriptionTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscriptionusingget"></a>
# **GetSubscriptionUsingGET**
> SubscriptionResource GetSubscriptionUsingGET (int? id)

Retrieve a single subscription item and associated plans

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSubscriptionUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new StoreSubscriptionsApi();
            var id = 56;  // int? | The id of the subscription

            try
            {
                // Retrieve a single subscription item and associated plans
                SubscriptionResource result = apiInstance.GetSubscriptionUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreSubscriptionsApi.GetSubscriptionUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the subscription | 

### Return type

[**SubscriptionResource**](SubscriptionResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsubscriptionsusingget"></a>
# **ListSubscriptionsUsingGET**
> PageSubscriptionResource ListSubscriptionsUsingGET (int? size = null, int? page = null, string order = null)

List available subscription items and associated plans

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListSubscriptionsUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new StoreSubscriptionsApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to 1)

            try
            {
                // List available subscription items and associated plans
                PageSubscriptionResource result = apiInstance.ListSubscriptionsUsingGET(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreSubscriptionsApi.ListSubscriptionsUsingGET: " + e.Message );
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
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to 1]

### Return type

[**PageSubscriptionResource**](PageSubscriptionResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="processusingpost"></a>
# **ProcessUsingPOST**
> void ProcessUsingPOST ()

Processes subscriptions and charge dues

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProcessUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreSubscriptionsApi();

            try
            {
                // Processes subscriptions and charge dues
                apiInstance.ProcessUsingPOST();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreSubscriptionsApi.ProcessUsingPOST: " + e.Message );
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

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesubscriptiontemplateusingput"></a>
# **UpdateSubscriptionTemplateUsingPUT**
> void UpdateSubscriptionTemplateUsingPUT (string id, SubscriptionTemplateResource subscriptionTemplateResource = null)

Update a subscription template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateSubscriptionTemplateUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreSubscriptionsApi();
            var id = id_example;  // string | The id of the template
            var subscriptionTemplateResource = new SubscriptionTemplateResource(); // SubscriptionTemplateResource | The subscription template resource object (optional) 

            try
            {
                // Update a subscription template
                apiInstance.UpdateSubscriptionTemplateUsingPUT(id, subscriptionTemplateResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreSubscriptionsApi.UpdateSubscriptionTemplateUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **subscriptionTemplateResource** | [**SubscriptionTemplateResource**](SubscriptionTemplateResource.md)| The subscription template resource object | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesubscriptionusingput"></a>
# **UpdateSubscriptionUsingPUT**
> void UpdateSubscriptionUsingPUT (int? id, SubscriptionResource subscriptionResource = null)

Updates a subscription item and associated plans

Will not remove plans left out

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateSubscriptionUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreSubscriptionsApi();
            var id = 56;  // int? | The id of the subscription
            var subscriptionResource = new SubscriptionResource(); // SubscriptionResource | The subscription resource object (optional) 

            try
            {
                // Updates a subscription item and associated plans
                apiInstance.UpdateSubscriptionUsingPUT(id, subscriptionResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreSubscriptionsApi.UpdateSubscriptionUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the subscription | 
 **subscriptionResource** | [**SubscriptionResource**](SubscriptionResource.md)| The subscription resource object | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

