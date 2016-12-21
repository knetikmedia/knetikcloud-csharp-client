# IO.Swagger.Api.InvoicesApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateInvoiceUsingPOST**](InvoicesApi.md#createinvoiceusingpost) | **POST** /invoices | Create an invoice
[**GetInvoiceHistoryUsingGET**](InvoicesApi.md#getinvoicehistoryusingget) | **GET** /invoices | Retrieve invoices
[**GetInvoiceUsingGET**](InvoicesApi.md#getinvoiceusingget) | **GET** /invoices/{id} | Retrieve an invoice
[**GetLogsUsingGET**](InvoicesApi.md#getlogsusingget) | **GET** /invoices/{id}/logs | List invoice logs
[**ListFulFillmentStatusesUsingGET**](InvoicesApi.md#listfulfillmentstatusesusingget) | **GET** /invoices/fulfillment-statuses | Lists available fulfillment statuses
[**ListPaymentStatusesUsingGET**](InvoicesApi.md#listpaymentstatusesusingget) | **GET** /invoices/payment-statuses | Lists available payment statuses
[**PayInvoiceUsingPOST**](InvoicesApi.md#payinvoiceusingpost) | **POST** /invoices/{id}/payments | Trigger payment of an invoice
[**SetItemFulfillmentStatusUsingPUT**](InvoicesApi.md#setitemfulfillmentstatususingput) | **PUT** /invoices/{id}/items/{sku}/fulfillment-status | Set the fulfillment status of an invoice item
[**SetOrderNotesUsingPUT**](InvoicesApi.md#setordernotesusingput) | **PUT** /invoices/{id}/order-notes | Set the order notes of an invoice
[**SetPaymentStatusUsingPUT**](InvoicesApi.md#setpaymentstatususingput) | **PUT** /invoices/{id}/payment-status | Set the payment status of an invoice
[**UpdateBillingInfoUsingPUT**](InvoicesApi.md#updatebillinginfousingput) | **PUT** /invoices/{id}/billing-address | Set or update billing info


<a name="createinvoiceusingpost"></a>
# **CreateInvoiceUsingPOST**
> List<InvoiceResource> CreateInvoiceUsingPOST (InvoiceCreateRequest req = null)

Create an invoice

Create an invoice(s) by providing a cart GUID. Note that there may be multiple invoices created, one per vendor.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateInvoiceUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var req = new InvoiceCreateRequest(); // InvoiceCreateRequest | Invoice to be created (optional) 

            try
            {
                // Create an invoice
                List&lt;InvoiceResource&gt; result = apiInstance.CreateInvoiceUsingPOST(req);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.CreateInvoiceUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **req** | [**InvoiceCreateRequest**](InvoiceCreateRequest.md)| Invoice to be created | [optional] 

### Return type

[**List<InvoiceResource>**](InvoiceResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoicehistoryusingget"></a>
# **GetInvoiceHistoryUsingGET**
> PageResourceInvoiceResource GetInvoiceHistoryUsingGET (int? filterUser = null, string filterEmail = null, string filterFulfillmentStatus = null, string filterPaymentStatus = null, string filterItemName = null, string filterCreatedDate = null, int? size = null, int? page = null, string order = null)

Retrieve invoices

Without INVOICES_ADMIN permission the results are automatically filtered for only the logged in user's invoices. It is recomended however that filter_user be added to avoid issues for admin users accidentally getting additional invoices.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetInvoiceHistoryUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var filterUser = 56;  // int? | The id of a user to get invoices for. Automtically added if not being called with admin permissions. (optional) 
            var filterEmail = filterEmail_example;  // string | Filters invoices by customer's email. Admins only. (optional) 
            var filterFulfillmentStatus = filterFulfillmentStatus_example;  // string | Filters invoices by fulfillment status type. Can be a comma separated list of statuses (optional) 
            var filterPaymentStatus = filterPaymentStatus_example;  // string | Filters invoices by payment status type. Can be a comma separated list of statuses (optional) 
            var filterItemName = filterItemName_example;  // string | Filters invoices by item name containing the given string (optional) 
            var filterCreatedDate = filterCreatedDate_example;  // string | Filters invoices by creation date. Multiple values possible for range search. Format: filter_created_date=OP,ts&... where OP in (GT, LT, GOE, LOE, EQ) and ts is a unix timestamp in seconds. Ex: filter_created_date=GT,1452154258,LT,1554254874 (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // Retrieve invoices
                PageResourceInvoiceResource result = apiInstance.GetInvoiceHistoryUsingGET(filterUser, filterEmail, filterFulfillmentStatus, filterPaymentStatus, filterItemName, filterCreatedDate, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.GetInvoiceHistoryUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterUser** | **int?**| The id of a user to get invoices for. Automtically added if not being called with admin permissions. | [optional] 
 **filterEmail** | **string**| Filters invoices by customer&#39;s email. Admins only. | [optional] 
 **filterFulfillmentStatus** | **string**| Filters invoices by fulfillment status type. Can be a comma separated list of statuses | [optional] 
 **filterPaymentStatus** | **string**| Filters invoices by payment status type. Can be a comma separated list of statuses | [optional] 
 **filterItemName** | **string**| Filters invoices by item name containing the given string | [optional] 
 **filterCreatedDate** | **string**| Filters invoices by creation date. Multiple values possible for range search. Format: filter_created_date&#x3D;OP,ts&amp;... where OP in (GT, LT, GOE, LOE, EQ) and ts is a unix timestamp in seconds. Ex: filter_created_date&#x3D;GT,1452154258,LT,1554254874 | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourceInvoiceResource**](PageResourceInvoiceResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoiceusingget"></a>
# **GetInvoiceUsingGET**
> InvoiceResource GetInvoiceUsingGET (int? id, string postalCode = null)

Retrieve an invoice

The postal code associated with the invoice may be required for security purposes if the invoice has one set and the config postal_code_required is set to true. Send 'none' if the invoice has no postal code.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetInvoiceUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var id = 56;  // int? | The id of the invoice
            var postalCode = postalCode_example;  // string | The postal code of the invoice or 'none'. (optional) 

            try
            {
                // Retrieve an invoice
                InvoiceResource result = apiInstance.GetInvoiceUsingGET(id, postalCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.GetInvoiceUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the invoice | 
 **postalCode** | **string**| The postal code of the invoice or &#39;none&#39;. | [optional] 

### Return type

[**InvoiceResource**](InvoiceResource.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlogsusingget"></a>
# **GetLogsUsingGET**
> PageResourceInvoiceLogEntry GetLogsUsingGET (int? id, int? size = null, int? page = null)

List invoice logs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLogsUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var id = 56;  // int? | The id of the invoice
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // List invoice logs
                PageResourceInvoiceLogEntry result = apiInstance.GetLogsUsingGET(id, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.GetLogsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the invoice | 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceInvoiceLogEntry**](PageResourceInvoiceLogEntry.md)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listfulfillmentstatusesusingget"></a>
# **ListFulFillmentStatusesUsingGET**
> List<string> ListFulFillmentStatusesUsingGET ()

Lists available fulfillment statuses

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListFulFillmentStatusesUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new InvoicesApi();

            try
            {
                // Lists available fulfillment statuses
                List&lt;string&gt; result = apiInstance.ListFulFillmentStatusesUsingGET();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.ListFulFillmentStatusesUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpaymentstatusesusingget"></a>
# **ListPaymentStatusesUsingGET**
> List<string> ListPaymentStatusesUsingGET ()

Lists available payment statuses

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListPaymentStatusesUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new InvoicesApi();

            try
            {
                // Lists available payment statuses
                List&lt;string&gt; result = apiInstance.ListPaymentStatusesUsingGET();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.ListPaymentStatusesUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="payinvoiceusingpost"></a>
# **PayInvoiceUsingPOST**
> void PayInvoiceUsingPOST (int? id, PayBySavedMethodRequest request = null)

Trigger payment of an invoice

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PayInvoiceUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var id = 56;  // int? | The id of the invoice
            var request = new PayBySavedMethodRequest(); // PayBySavedMethodRequest | Payment info (optional) 

            try
            {
                // Trigger payment of an invoice
                apiInstance.PayInvoiceUsingPOST(id, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.PayInvoiceUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the invoice | 
 **request** | [**PayBySavedMethodRequest**](PayBySavedMethodRequest.md)| Payment info | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setitemfulfillmentstatususingput"></a>
# **SetItemFulfillmentStatusUsingPUT**
> void SetItemFulfillmentStatusUsingPUT (int? id, string sku, string status)

Set the fulfillment status of an invoice item

This allows external fulfillment systems to report success or failure. Fulfillment status changes are restricted by a specific flow determining which status can lead to which.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetItemFulfillmentStatusUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var id = 56;  // int? | The id of the invoice
            var sku = sku_example;  // string | The sku of an item in the invoice
            var status = status_example;  // string | The new fulfillment status for the item. Additional options may be available based on configuration.  Allowable values:  'unfulfilled', 'fulfilled', 'not fulfillable', 'failed', 'processing', 'failed_permanent', 'delayed'

            try
            {
                // Set the fulfillment status of an invoice item
                apiInstance.SetItemFulfillmentStatusUsingPUT(id, sku, status);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.SetItemFulfillmentStatusUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the invoice | 
 **sku** | **string**| The sku of an item in the invoice | 
 **status** | **string**| The new fulfillment status for the item. Additional options may be available based on configuration.  Allowable values:  &#39;unfulfilled&#39;, &#39;fulfilled&#39;, &#39;not fulfillable&#39;, &#39;failed&#39;, &#39;processing&#39;, &#39;failed_permanent&#39;, &#39;delayed&#39; | 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setordernotesusingput"></a>
# **SetOrderNotesUsingPUT**
> void SetOrderNotesUsingPUT (int? id, string orderNotes = null)

Set the order notes of an invoice

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetOrderNotesUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var id = 56;  // int? | The id of the invoice
            var orderNotes = orderNotes_example;  // string | Payment status info (optional) 

            try
            {
                // Set the order notes of an invoice
                apiInstance.SetOrderNotesUsingPUT(id, orderNotes);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.SetOrderNotesUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the invoice | 
 **orderNotes** | **string**| Payment status info | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setpaymentstatususingput"></a>
# **SetPaymentStatusUsingPUT**
> void SetPaymentStatusUsingPUT (int? id, InvoicePaymentStatusRequest request = null)

Set the payment status of an invoice

This may trigger fulfillment if setting the status to 'paid'. This is mainly intended to support external payment systems that cannot be incorporated into the payment method system. Payment status changes are restricted by a specific flow determining which status can lead to which.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetPaymentStatusUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var id = 56;  // int? | The id of the invoice
            var request = new InvoicePaymentStatusRequest(); // InvoicePaymentStatusRequest | Payment status info (optional) 

            try
            {
                // Set the payment status of an invoice
                apiInstance.SetPaymentStatusUsingPUT(id, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.SetPaymentStatusUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the invoice | 
 **request** | [**InvoicePaymentStatusRequest**](InvoicePaymentStatusRequest.md)| Payment status info | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebillinginfousingput"></a>
# **UpdateBillingInfoUsingPUT**
> void UpdateBillingInfoUsingPUT (int? id, AddressResource billingInfoRequest = null)

Set or update billing info

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateBillingInfoUsingPUTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: knetik_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var id = 56;  // int? | The id of the invoice
            var billingInfoRequest = new AddressResource(); // AddressResource | Address info (optional) 

            try
            {
                // Set or update billing info
                apiInstance.UpdateBillingInfoUsingPUT(id, billingInfoRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.UpdateBillingInfoUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the invoice | 
 **billingInfoRequest** | [**AddressResource**](AddressResource.md)| Address info | [optional] 

### Return type

void (empty response body)

### Authorization

[knetik_oauth](../README.md#knetik_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

