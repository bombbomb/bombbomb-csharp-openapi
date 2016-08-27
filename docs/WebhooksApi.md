# IO.Swagger.Api.WebhooksApi

All URIs are relative to *https://dev.api.bombbomb.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddWebHook**](WebhooksApi.md#addwebhook) | **POST** /webhook | Add Webhook
[**DeleteWebHook**](WebhooksApi.md#deletewebhook) | **DELETE** /webhook/{hookId} | Deletes Webhook
[**GetWebHooks**](WebhooksApi.md#getwebhooks) | **GET** /webhook/ | Lists Webhooks
[**SendWebhookExample**](WebhooksApi.md#sendwebhookexample) | **POST** /webhook/test | Sends test Webhook


<a name="addwebhook"></a>
# **AddWebHook**
> void AddWebHook (string hookUrl)

Add Webhook

Idempotently adds a Webhook url

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddWebHookExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebhooksApi();
            var hookUrl = hookUrl_example;  // string | The Url of your listener

            try
            {
                // Add Webhook
                apiInstance.AddWebHook(hookUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.AddWebHook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hookUrl** | **string**| The Url of your listener | 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletewebhook"></a>
# **DeleteWebHook**
> void DeleteWebHook (string hookId)

Deletes Webhook

Deletes a Webhook

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteWebHookExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebhooksApi();
            var hookId = hookId_example;  // string | The id of the webhook to delete

            try
            {
                // Deletes Webhook
                apiInstance.DeleteWebHook(hookId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.DeleteWebHook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hookId** | **string**| The id of the webhook to delete | 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhooks"></a>
# **GetWebHooks**
> void GetWebHooks ()

Lists Webhooks

Lists all registered Webhooks

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetWebHooksExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebhooksApi();

            try
            {
                // Lists Webhooks
                apiInstance.GetWebHooks();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.GetWebHooks: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendwebhookexample"></a>
# **SendWebhookExample**
> void SendWebhookExample ()

Sends test Webhook

Triggers a test webhook to be sent to your endpoints.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SendWebhookExampleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebhooksApi();

            try
            {
                // Sends test Webhook
                apiInstance.SendWebhookExample();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.SendWebhookExample: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

