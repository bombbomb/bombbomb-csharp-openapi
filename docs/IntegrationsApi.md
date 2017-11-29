# IO.Swagger.Api.IntegrationsApi

All URIs are relative to *https://api.bombbomb.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SyncUsersIntegratedLists**](IntegrationsApi.md#syncusersintegratedlists) | **GET** /integrations/sync | Synchronize your integration list or lists.


<a name="syncusersintegratedlists"></a>
# **SyncUsersIntegratedLists**
> string SyncUsersIntegratedLists (string integrationId = null)

Synchronize your integration list or lists.

Synchronize your integration contact list with the service you are integrated with. If no integration code is provided, all integrations will be synchronized.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SyncUsersIntegratedListsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IntegrationsApi();
            var integrationId = integrationId_example;  // string | The integration to sync lists for. All integrations will sync if nothing is provided. (optional) 

            try
            {
                // Synchronize your integration list or lists.
                string result = apiInstance.SyncUsersIntegratedLists(integrationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.SyncUsersIntegratedLists: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **integrationId** | **string**| The integration to sync lists for. All integrations will sync if nothing is provided. | [optional] 

### Return type

**string**

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

