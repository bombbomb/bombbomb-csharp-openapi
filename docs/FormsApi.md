# IO.Swagger.Api.FormsApi

All URIs are relative to *https://api.bombbomb.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetFormTrackingAsCsv**](FormsApi.md#getformtrackingascsv) | **GET** /forms/{id}/tracking/export | Get csv


<a name="getformtrackingascsv"></a>
# **GetFormTrackingAsCsv**
> void GetFormTrackingAsCsv (string id)

Get csv

Get form tracking as csv

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFormTrackingAsCsvExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FormsApi();
            var id = id_example;  // string | Id of the form

            try
            {
                // Get csv
                apiInstance.GetFormTrackingAsCsv(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FormsApi.GetFormTrackingAsCsv: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Id of the form | 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

