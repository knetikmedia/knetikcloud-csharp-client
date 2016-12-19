# IO.Swagger.Api.MessagingApi

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SendRawEmailUsingPOST**](MessagingApi.md#sendrawemailusingpost) | **POST** /messaging/raw-email | Send a raw email to one or more users
[**SendRawSMSUsingPOST**](MessagingApi.md#sendrawsmsusingpost) | **POST** /messaging/raw-sms | Send a raw SMS
[**SendRawSMSUsingPOST1**](MessagingApi.md#sendrawsmsusingpost1) | **POST** /messaging/templated-sms | Send a new templated SMS
[**SendTemplateEmailUsingPOST**](MessagingApi.md#sendtemplateemailusingpost) | **POST** /messaging/templated-email | Send a templated email to one or more users


<a name="sendrawemailusingpost"></a>
# **SendRawEmailUsingPOST**
> void SendRawEmailUsingPOST (RawEmailResource rawEmailResource = null)

Send a raw email to one or more users

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SendRawEmailUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var rawEmailResource = new RawEmailResource(); // RawEmailResource | The new raw email to be sent (optional) 

            try
            {
                // Send a raw email to one or more users
                apiInstance.SendRawEmailUsingPOST(rawEmailResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.SendRawEmailUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rawEmailResource** | [**RawEmailResource**](RawEmailResource.md)| The new raw email to be sent | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendrawsmsusingpost"></a>
# **SendRawSMSUsingPOST**
> void SendRawSMSUsingPOST (RawSMSResource rawSMSResource = null)

Send a raw SMS

Sends a raw SMS text message to one or more users. User's without registered mobile numbers will be skipped.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SendRawSMSUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var rawSMSResource = new RawSMSResource(); // RawSMSResource | The new raw SMS to be sent (optional) 

            try
            {
                // Send a raw SMS
                apiInstance.SendRawSMSUsingPOST(rawSMSResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.SendRawSMSUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rawSMSResource** | [**RawSMSResource**](RawSMSResource.md)| The new raw SMS to be sent | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendrawsmsusingpost1"></a>
# **SendRawSMSUsingPOST1**
> void SendRawSMSUsingPOST1 (TemplateSMSResource templateSMSResource = null)

Send a new templated SMS

Sends a templated SMS text message to one or more users. User's without registered mobile numbers will be skipped.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SendRawSMSUsingPOST1Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var templateSMSResource = new TemplateSMSResource(); // TemplateSMSResource | The new template SMS to be sent (optional) 

            try
            {
                // Send a new templated SMS
                apiInstance.SendRawSMSUsingPOST1(templateSMSResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.SendRawSMSUsingPOST1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateSMSResource** | [**TemplateSMSResource**](TemplateSMSResource.md)| The new template SMS to be sent | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendtemplateemailusingpost"></a>
# **SendTemplateEmailUsingPOST**
> void SendTemplateEmailUsingPOST (TemplateEmailResource messageResource = null)

Send a templated email to one or more users

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SendTemplateEmailUsingPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var messageResource = new TemplateEmailResource(); // TemplateEmailResource | The new template email to be sent (optional) 

            try
            {
                // Send a templated email to one or more users
                apiInstance.SendTemplateEmailUsingPOST(messageResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.SendTemplateEmailUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageResource** | [**TemplateEmailResource**](TemplateEmailResource.md)| The new template email to be sent | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

