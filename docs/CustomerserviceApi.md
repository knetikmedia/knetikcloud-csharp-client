# IO.Swagger.Api.CustomerserviceApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCustomerUsingPOST**](CustomerserviceApi.md#createcustomerusingpost) | **POST** /customers | Create a customer
[**GetCustomersUsingGET**](CustomerserviceApi.md#getcustomersusingget) | **GET** /customers | List and search customers


<a name="createcustomerusingpost"></a>
# **CreateCustomerUsingPOST**
> void CreateCustomerUsingPOST (CustomerConfig customer)

Create a customer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateCustomerUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CustomerserviceApi();
            var customer = new CustomerConfig(); // CustomerConfig | customer

            try
            {
                // Create a customer
                apiInstance.CreateCustomerUsingPOST(customer);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerserviceApi.CreateCustomerUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customer** | [**CustomerConfig**](CustomerConfig.md)| customer | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomersusingget"></a>
# **GetCustomersUsingGET**
> List<CustomerResource> GetCustomersUsingGET (int? size = null, int? page = null, string order = null)

List and search customers

Get a list of customers with optional filtering

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCustomersUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CustomerserviceApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to 1)

            try
            {
                // List and search customers
                List&lt;CustomerResource&gt; result = apiInstance.GetCustomersUsingGET(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerserviceApi.GetCustomersUsingGET: " + e.Message );
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

[**List<CustomerResource>**](CustomerResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

