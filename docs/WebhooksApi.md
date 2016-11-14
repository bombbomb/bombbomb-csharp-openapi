# IO.Swagger.Api.WebhooksApi

All URIs are relative to *https://api.bombbomb.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddWebHook**](WebhooksApi.md#addwebhook) | **POST** /webhook | Add Webhook
[**DeleteWebHook**](WebhooksApi.md#deletewebhook) | **DELETE** /webhook/{hookId} | Deletes Webhook
[**GetWebHooks**](WebhooksApi.md#getwebhooks) | **GET** /webhook/ | Lists Webhooks
[**ListWebHookEvents**](WebhooksApi.md#listwebhookevents) | **GET** /webhook/events | Describe WebHook Events
[**SendWebhookExample**](WebhooksApi.md#sendwebhookexample) | **POST** /webhook/test | Sends test Webhook


<a name="addwebhook"></a>
# **AddWebHook**
> BBWebHook AddWebHook (string hookUrl)

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
                BBWebHook result = apiInstance.AddWebHook(hookUrl);
                Debug.WriteLine(result);
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

[**BBWebHook**](BBWebHook.md)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletewebhook"></a>
# **DeleteWebHook**
> string DeleteWebHook (string hookId)

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
                string result = apiInstance.DeleteWebHook(hookId);
                Debug.WriteLine(result);
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

**string**

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhooks"></a>
# **GetWebHooks**
> List<BBWebHook> GetWebHooks ()

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
                List&lt;BBWebHook&gt; result = apiInstance.GetWebHooks();
                Debug.WriteLine(result);
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

[**List<BBWebHook>**](BBWebHook.md)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listwebhookevents"></a>
# **ListWebHookEvents**
> void ListWebHookEvents ()

Describe WebHook Events

Returns example Webhook events for each kind of possible event.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListWebHookEventsExample
    {
        public void main()
        {
            
            var apiInstance = new WebhooksApi();

            try
            {
                // Describe WebHook Events
                apiInstance.ListWebHookEvents();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.ListWebHookEvents: " + e.Message );
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
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

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

