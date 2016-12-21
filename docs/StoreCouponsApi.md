# IO.Swagger.Api.StoreCouponsApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCouponItemUsingPOST**](StoreCouponsApi.md#createcouponitemusingpost) | **POST** /store/coupons | Create a coupon item
[**CreateCouponTemplateUsingPOST**](StoreCouponsApi.md#createcoupontemplateusingpost) | **POST** /store/coupons/templates | Create a coupon template
[**DeleteCouponItemUsingDELETE**](StoreCouponsApi.md#deletecouponitemusingdelete) | **DELETE** /store/coupons/{id} | Delete a coupon item
[**DeleteCouponTemplateUsingDELETE**](StoreCouponsApi.md#deletecoupontemplateusingdelete) | **DELETE** /store/coupons/templates/{id} | Delete a coupon template
[**GetCouponItemUsingGET**](StoreCouponsApi.md#getcouponitemusingget) | **GET** /store/coupons/{id} | Get a single coupon item
[**GetCouponTemplateUsingGET**](StoreCouponsApi.md#getcoupontemplateusingget) | **GET** /store/coupons/templates/{id} | Get a single coupon template
[**GetCouponTemplatesUsingGET**](StoreCouponsApi.md#getcoupontemplatesusingget) | **GET** /store/coupons/templates | List and search coupon templates
[**UpdateCouponItemUsingPUT**](StoreCouponsApi.md#updatecouponitemusingput) | **PUT** /store/coupons/{id} | Update a coupon item
[**UpdateCouponTemplateUsingPUT**](StoreCouponsApi.md#updatecoupontemplateusingput) | **PUT** /store/coupons/templates/{id} | Update a coupon template


<a name="createcouponitemusingpost"></a>
# **CreateCouponItemUsingPOST**
> CouponItem CreateCouponItemUsingPOST (CouponItem couponItem = null)

Create a coupon item

SKUs have to be unique in the entire store.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateCouponItemUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreCouponsApi();
            var couponItem = new CouponItem(); // CouponItem | The coupon item object (optional) 

            try
            {
                // Create a coupon item
                CouponItem result = apiInstance.CreateCouponItemUsingPOST(couponItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreCouponsApi.CreateCouponItemUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **couponItem** | [**CouponItem**](CouponItem.md)| The coupon item object | [optional] 

### Return type

[**CouponItem**](CouponItem.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcoupontemplateusingpost"></a>
# **CreateCouponTemplateUsingPOST**
> ItemTemplateResource CreateCouponTemplateUsingPOST (ItemTemplateResource couponTemplateResource = null)

Create a coupon template

Coupon Templates define a type of coupon and the properties they have.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateCouponTemplateUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreCouponsApi();
            var couponTemplateResource = new ItemTemplateResource(); // ItemTemplateResource | The new coupon template (optional) 

            try
            {
                // Create a coupon template
                ItemTemplateResource result = apiInstance.CreateCouponTemplateUsingPOST(couponTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreCouponsApi.CreateCouponTemplateUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **couponTemplateResource** | [**ItemTemplateResource**](ItemTemplateResource.md)| The new coupon template | [optional] 

### Return type

[**ItemTemplateResource**](ItemTemplateResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecouponitemusingdelete"></a>
# **DeleteCouponItemUsingDELETE**
> void DeleteCouponItemUsingDELETE (int? id)

Delete a coupon item

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteCouponItemUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreCouponsApi();
            var id = 56;  // int? | The id of the coupon

            try
            {
                // Delete a coupon item
                apiInstance.DeleteCouponItemUsingDELETE(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreCouponsApi.DeleteCouponItemUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the coupon | 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecoupontemplateusingdelete"></a>
# **DeleteCouponTemplateUsingDELETE**
> void DeleteCouponTemplateUsingDELETE (string id, string cascade = null)

Delete a coupon template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteCouponTemplateUsingDELETEExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreCouponsApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | force deleting the template if it's attached to other objects, cascade = detach (optional) 

            try
            {
                // Delete a coupon template
                apiInstance.DeleteCouponTemplateUsingDELETE(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreCouponsApi.DeleteCouponTemplateUsingDELETE: " + e.Message );
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

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcouponitemusingget"></a>
# **GetCouponItemUsingGET**
> CouponItem GetCouponItemUsingGET (int? id)

Get a single coupon item

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCouponItemUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreCouponsApi();
            var id = 56;  // int? | The id of the coupon

            try
            {
                // Get a single coupon item
                CouponItem result = apiInstance.GetCouponItemUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreCouponsApi.GetCouponItemUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the coupon | 

### Return type

[**CouponItem**](CouponItem.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcoupontemplateusingget"></a>
# **GetCouponTemplateUsingGET**
> ItemTemplateResource GetCouponTemplateUsingGET (string id)

Get a single coupon template

Coupon Templates define a type of coupon and the properties they have.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCouponTemplateUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreCouponsApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single coupon template
                ItemTemplateResource result = apiInstance.GetCouponTemplateUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreCouponsApi.GetCouponTemplateUsingGET: " + e.Message );
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

[**ItemTemplateResource**](ItemTemplateResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcoupontemplatesusingget"></a>
# **GetCouponTemplatesUsingGET**
> PageResourceItemTemplateResource GetCouponTemplatesUsingGET (int? size = null, int? page = null, string order = null)

List and search coupon templates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCouponTemplatesUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreCouponsApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search coupon templates
                PageResourceItemTemplateResource result = apiInstance.GetCouponTemplatesUsingGET(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreCouponsApi.GetCouponTemplatesUsingGET: " + e.Message );
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

[**PageResourceItemTemplateResource**](PageResourceItemTemplateResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecouponitemusingput"></a>
# **UpdateCouponItemUsingPUT**
> void UpdateCouponItemUsingPUT (int? id, CouponItem couponItem = null)

Update a coupon item

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateCouponItemUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreCouponsApi();
            var id = 56;  // int? | The id of the coupon
            var couponItem = new CouponItem(); // CouponItem | The coupon item object (optional) 

            try
            {
                // Update a coupon item
                apiInstance.UpdateCouponItemUsingPUT(id, couponItem);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreCouponsApi.UpdateCouponItemUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the coupon | 
 **couponItem** | [**CouponItem**](CouponItem.md)| The coupon item object | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecoupontemplateusingput"></a>
# **UpdateCouponTemplateUsingPUT**
> void UpdateCouponTemplateUsingPUT (string id, ItemTemplateResource couponTemplateResource = null)

Update a coupon template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateCouponTemplateUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreCouponsApi();
            var id = id_example;  // string | The id of the template
            var couponTemplateResource = new ItemTemplateResource(); // ItemTemplateResource | The coupon template resource object (optional) 

            try
            {
                // Update a coupon template
                apiInstance.UpdateCouponTemplateUsingPUT(id, couponTemplateResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreCouponsApi.UpdateCouponTemplateUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **couponTemplateResource** | [**ItemTemplateResource**](ItemTemplateResource.md)| The coupon template resource object | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

