# IO.Swagger.Api.IntegrationsApi

All URIs are relative to *https://api.bombbomb.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConnectIntegration**](IntegrationsApi.md#connectintegration) | **POST** /integrations | Activate an integration for a user.
[**DeleteIntegration**](IntegrationsApi.md#deleteintegration) | **DELETE** /integrations | Remove an integration for a user.
[**GetIntegrationHealth**](IntegrationsApi.md#getintegrationhealth) | **GET** /integrations/health/{code} | Get health for a given integration
[**GetIntegrationPageComponents**](IntegrationsApi.md#getintegrationpagecomponents) | **GET** /integrations/pageComponents | Get page components for a given integration
[**SyncUsersIntegratedLists**](IntegrationsApi.md#syncusersintegratedlists) | **GET** /integrations/sync | Synchronize your integration list or lists.


<a name="connectintegration"></a>
# **ConnectIntegration**
> void ConnectIntegration (string code, string key = null, string secret = null, string token = null, string data = null, string overwrite = null)

Activate an integration for a user.

Provide the correct parameters to enable an integration. Required Parameters vary based on the desired          integration. Integrations requiring OAuth will provide the OAuth link that the user must be presented.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConnectIntegrationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IntegrationsApi();
            var code = code_example;  // string | The identifier of the integration.
            var key = key_example;  // string | The key value. (optional) 
            var secret = secret_example;  // string | The secret value. (optional) 
            var token = token_example;  // string | The token value. (optional) 
            var data = data_example;  // string | The data value as JSON. (optional) 
            var overwrite = overwrite_example;  // string | Boolean value to know whether or not to delete the integration if it already exists (optional) 

            try
            {
                // Activate an integration for a user.
                apiInstance.ConnectIntegration(code, key, secret, token, data, overwrite);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.ConnectIntegration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**| The identifier of the integration. | 
 **key** | **string**| The key value. | [optional] 
 **secret** | **string**| The secret value. | [optional] 
 **token** | **string**| The token value. | [optional] 
 **data** | **string**| The data value as JSON. | [optional] 
 **overwrite** | **string**| Boolean value to know whether or not to delete the integration if it already exists | [optional] 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteintegration"></a>
# **DeleteIntegration**
> void DeleteIntegration (string id = null, string code = null)

Remove an integration for a user.

Remove an integration by providing the integration id or integration code. Only provide one of the             parameters.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteIntegrationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IntegrationsApi();
            var id = id_example;  // string | Integration ID (optional) 
            var code = code_example;  // string | Integration Code (optional) 

            try
            {
                // Remove an integration for a user.
                apiInstance.DeleteIntegration(id, code);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.DeleteIntegration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Integration ID | [optional] 
 **code** | **string**| Integration Code | [optional] 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getintegrationhealth"></a>
# **GetIntegrationHealth**
> void GetIntegrationHealth (string code)

Get health for a given integration

Get health for an integration.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetIntegrationHealthExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IntegrationsApi();
            var code = code_example;  // string | The integration code for which to retrieve the information from

            try
            {
                // Get health for a given integration
                apiInstance.GetIntegrationHealth(code);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationHealth: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**| The integration code for which to retrieve the information from | 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getintegrationpagecomponents"></a>
# **GetIntegrationPageComponents**
> void GetIntegrationPageComponents (string integrationName)

Get page components for a given integration

Get all page components for an integration.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetIntegrationPageComponentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IntegrationsApi();
            var integrationName = integrationName_example;  // string | The integration for which to retrieve HTML page components.

            try
            {
                // Get page components for a given integration
                apiInstance.GetIntegrationPageComponents(integrationName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationPageComponents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **integrationName** | **string**| The integration for which to retrieve HTML page components. | 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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

