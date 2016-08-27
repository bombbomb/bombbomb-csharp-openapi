# IO.Swagger.Api.PromptsApi

All URIs are relative to *https://dev.api.bombbomb.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateVideoEmailPrompt**](PromptsApi.md#createvideoemailprompt) | **POST** /prompt | Prompts user to send a video
[**GetVideoEmailPrompt**](PromptsApi.md#getvideoemailprompt) | **GET** /prompt/{id} | Gets a prompt
[**RespondToVideoEmailPrompt**](PromptsApi.md#respondtovideoemailprompt) | **POST** /prompt/{id}/response | Respond to a prompt


<a name="createvideoemailprompt"></a>
# **CreateVideoEmailPrompt**
> void CreateVideoEmailPrompt (JerichoConfiguration prompt)

Prompts user to send a video

Sends the account holder an email prompting them to add a video to a scheduled outgoing message. Recipients, content and timing is all preset for the user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateVideoEmailPromptExample
    {
        public void main()
        {
            
            var apiInstance = new PromptsApi();
            var prompt = new JerichoConfiguration(); // JerichoConfiguration | The Video Email Prompt to be created

            try
            {
                // Prompts user to send a video
                apiInstance.CreateVideoEmailPrompt(prompt);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PromptsApi.CreateVideoEmailPrompt: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **prompt** | [**JerichoConfiguration**](JerichoConfiguration.md)| The Video Email Prompt to be created | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvideoemailprompt"></a>
# **GetVideoEmailPrompt**
> void GetVideoEmailPrompt (string id)

Gets a prompt

Gets a prompt

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetVideoEmailPromptExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PromptsApi();
            var id = id_example;  // string | The Id of the prompt

            try
            {
                // Gets a prompt
                apiInstance.GetVideoEmailPrompt(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PromptsApi.GetVideoEmailPrompt: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The Id of the prompt | 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="respondtovideoemailprompt"></a>
# **RespondToVideoEmailPrompt**
> void RespondToVideoEmailPrompt (string id, string choice, string videoId = null)

Respond to a prompt

Respond to a prompt by either adding a video, sending without a video or cancelling the prompt.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RespondToVideoEmailPromptExample
    {
        public void main()
        {
            
            var apiInstance = new PromptsApi();
            var id = id_example;  // string | The id of the prompt.
            var choice = choice_example;  // string | The users' selection. Can be: WithVideo, WithoutVideo, Cancel
            var videoId = videoId_example;  // string | The id of the video. (optional) 

            try
            {
                // Respond to a prompt
                apiInstance.RespondToVideoEmailPrompt(id, choice, videoId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PromptsApi.RespondToVideoEmailPrompt: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the prompt. | 
 **choice** | **string**| The users&#39; selection. Can be: WithVideo, WithoutVideo, Cancel | 
 **videoId** | **string**| The id of the video. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

