# IO.Swagger.Api.OrdersApi

All URIs are relative to *https://api.bombbomb.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TemplateAssetDelete**](OrdersApi.md#templateassetdelete) | **DELETE** /orders/templates/images | Deletes image from user s3 store


<a name="templateassetdelete"></a>
# **TemplateAssetDelete**
> void TemplateAssetDelete (string fileName)

Deletes image from user s3 store

Deletes image from user s3 store

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TemplateAssetDeleteExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrdersApi();
            var fileName = fileName_example;  // string | Filename for deletion

            try
            {
                // Deletes image from user s3 store
                apiInstance.TemplateAssetDelete(fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.TemplateAssetDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| Filename for deletion | 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

