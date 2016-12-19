# IO.Swagger.Api.AWSS3Api

All URIs are relative to *https://localhost:8080/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PreSignUrlUsingGET**](AWSS3Api.md#presignurlusingget) | **GET** /amazon/s3/signedposturl | Get a signed S3 URL


<a name="presignurlusingget"></a>
# **PreSignUrlUsingGET**
> AmazonS3Activity PreSignUrlUsingGET (string filename = null, string contentType = null)

Get a signed S3 URL

Requires the file name and file content type (i.e., 'video/mpeg')

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PreSignUrlUsingGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AWSS3Api();
            var filename = filename_example;  // string | The file name (optional) 
            var contentType = contentType_example;  // string | The content type (optional) 

            try
            {
                // Get a signed S3 URL
                AmazonS3Activity result = apiInstance.PreSignUrlUsingGET(filename, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AWSS3Api.PreSignUrlUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filename** | **string**| The file name | [optional] 
 **contentType** | **string**| The content type | [optional] 

### Return type

[**AmazonS3Activity**](AmazonS3Activity.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

