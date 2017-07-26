# IO.Swagger.Api.FilesApi

All URIs are relative to *https://api.bombbomb.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DocHostDelete**](FilesApi.md#dochostdelete) | **DELETE** /files | Deletes users file


<a name="dochostdelete"></a>
# **DocHostDelete**
> void DocHostDelete (string docId)

Deletes users file

Deletes the file from the users s3 store

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DocHostDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FilesApi();
            var docId = docId_example;  // string | Id of document

            try
            {
                // Deletes users file
                apiInstance.DocHostDelete(docId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FilesApi.DocHostDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docId** | **string**| Id of document | 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

