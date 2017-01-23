# IO.Swagger.Api.PromptsApi

All URIs are relative to *https://api.bombbomb.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePromptBot**](PromptsApi.md#createpromptbot) | **POST** /prompts/bots | Create a running Prompt Bot for a list
[**CreateVideoEmailPrompt**](PromptsApi.md#createvideoemailprompt) | **POST** /prompt | Prompts user to send a video
[**GetPendingVideoEmailPrompts**](PromptsApi.md#getpendingvideoemailprompts) | **GET** /prompt/pending | List pending prompts
[**GetPromptBots**](PromptsApi.md#getpromptbots) | **GET** /prompts/bots | List Prompt Bots
[**GetPromptCampaigns**](PromptsApi.md#getpromptcampaigns) | **GET** /prompts/campaigns | List Prompt Campaigns
[**GetVideoEmailPrompt**](PromptsApi.md#getvideoemailprompt) | **GET** /prompt/{id} | Gets a prompt
[**GetVideoEmailPrompts**](PromptsApi.md#getvideoemailprompts) | **GET** /prompt/ | List prompts
[**RespondToVideoEmailPrompt**](PromptsApi.md#respondtovideoemailprompt) | **POST** /prompt/{id}/response | Respond to a prompt
[**UpdatePromptBot**](PromptsApi.md#updatepromptbot) | **PUT** /prompts/bots/{id} | Update Prompt Bot
[**UpdatePromptCampaign**](PromptsApi.md#updatepromptcampaign) | **PUT** /prompts/campaigns/{id} | Update Prompt Campaign


<a name="createpromptbot"></a>
# **CreatePromptBot**
> PromptBotBot CreatePromptBot (string listId, string emailId, string endDate, string promptSubject, string promptBody, string botTypeId, string templateId)

Create a running Prompt Bot for a list

Creates a Prompt Bot that sends emails to contacts on a list over the span of time defined.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreatePromptBotExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PromptsApi();
            var listId = listId_example;  // string | The list id to attach the bot to.
            var emailId = emailId_example;  // string | The default email to use.
            var endDate = endDate_example;  // string | The time frame to complete sending to the list.
            var promptSubject = promptSubject_example;  // string | The prompt subject.
            var promptBody = promptBody_example;  // string | The prompt script.
            var botTypeId = botTypeId_example;  // string | The type of bot to create.
            var templateId = templateId_example;  // string | The template used to create the email id.

            try
            {
                // Create a running Prompt Bot for a list
                PromptBotBot result = apiInstance.CreatePromptBot(listId, emailId, endDate, promptSubject, promptBody, botTypeId, templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PromptsApi.CreatePromptBot: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **string**| The list id to attach the bot to. | 
 **emailId** | **string**| The default email to use. | 
 **endDate** | **string**| The time frame to complete sending to the list. | 
 **promptSubject** | **string**| The prompt subject. | 
 **promptBody** | **string**| The prompt script. | 
 **botTypeId** | **string**| The type of bot to create. | 
 **templateId** | **string**| The template used to create the email id. | 

### Return type

[**PromptBotBot**](PromptBotBot.md)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createvideoemailprompt"></a>
# **CreateVideoEmailPrompt**
> VideoEmailPrompt CreateVideoEmailPrompt (VideoEmailPrompt prompt)

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
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PromptsApi();
            var prompt = new VideoEmailPrompt(); // VideoEmailPrompt | The Video Email Prompt to be created

            try
            {
                // Prompts user to send a video
                VideoEmailPrompt result = apiInstance.CreateVideoEmailPrompt(prompt);
                Debug.WriteLine(result);
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
 **prompt** | [**VideoEmailPrompt**](VideoEmailPrompt.md)| The Video Email Prompt to be created | 

### Return type

[**VideoEmailPrompt**](VideoEmailPrompt.md)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpendingvideoemailprompts"></a>
# **GetPendingVideoEmailPrompts**
> List<VideoEmailPrompt> GetPendingVideoEmailPrompts ()

List pending prompts

Returns a list of prompts that have not been sent yet, and can still be customized.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPendingVideoEmailPromptsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PromptsApi();

            try
            {
                // List pending prompts
                List&lt;VideoEmailPrompt&gt; result = apiInstance.GetPendingVideoEmailPrompts();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PromptsApi.GetPendingVideoEmailPrompts: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<VideoEmailPrompt>**](VideoEmailPrompt.md)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpromptbots"></a>
# **GetPromptBots**
> List<PromptBotBot> GetPromptBots ()

List Prompt Bots

Returns a list of all Prompt Bots for the user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPromptBotsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PromptsApi();

            try
            {
                // List Prompt Bots
                List&lt;PromptBotBot&gt; result = apiInstance.GetPromptBots();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PromptsApi.GetPromptBots: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<PromptBotBot>**](PromptBotBot.md)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpromptcampaigns"></a>
# **GetPromptCampaigns**
> void GetPromptCampaigns ()

List Prompt Campaigns

Returns a list of all Prompt Campaigns for the user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPromptCampaignsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PromptsApi();

            try
            {
                // List Prompt Campaigns
                apiInstance.GetPromptCampaigns();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PromptsApi.GetPromptCampaigns: " + e.Message );
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

<a name="getvideoemailprompt"></a>
# **GetVideoEmailPrompt**
> VideoEmailPrompt GetVideoEmailPrompt (string id)

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
                VideoEmailPrompt result = apiInstance.GetVideoEmailPrompt(id);
                Debug.WriteLine(result);
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

[**VideoEmailPrompt**](VideoEmailPrompt.md)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvideoemailprompts"></a>
# **GetVideoEmailPrompts**
> List<VideoEmailPrompt> GetVideoEmailPrompts ()

List prompts

Returns a list of all prompts.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetVideoEmailPromptsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PromptsApi();

            try
            {
                // List prompts
                List&lt;VideoEmailPrompt&gt; result = apiInstance.GetVideoEmailPrompts();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PromptsApi.GetVideoEmailPrompts: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<VideoEmailPrompt>**](VideoEmailPrompt.md)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="respondtovideoemailprompt"></a>
# **RespondToVideoEmailPrompt**
> VideoEmailPrompt RespondToVideoEmailPrompt (string id, string choice, string videoId = null, string emailId = null)

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
            var choice = choice_example;  // string | The users' selection. Can be: WithVideo, WithEmail, Cancel
            var videoId = videoId_example;  // string | The id of the video. (optional) 
            var emailId = emailId_example;  // string | The id of the video. (optional) 

            try
            {
                // Respond to a prompt
                VideoEmailPrompt result = apiInstance.RespondToVideoEmailPrompt(id, choice, videoId, emailId);
                Debug.WriteLine(result);
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
 **choice** | **string**| The users&#39; selection. Can be: WithVideo, WithEmail, Cancel | 
 **videoId** | **string**| The id of the video. | [optional] 
 **emailId** | **string**| The id of the video. | [optional] 

### Return type

[**VideoEmailPrompt**](VideoEmailPrompt.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepromptbot"></a>
# **UpdatePromptBot**
> PromptBotBot UpdatePromptBot (string id, string emailId = null, string endDate = null, string status = null)

Update Prompt Bot

Updates a Prompt Bot's settings.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdatePromptBotExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PromptsApi();
            var id = id_example;  // string | The bot id.
            var emailId = emailId_example;  // string | The default email to use. (optional) 
            var endDate = endDate_example;  // string | The time frame to complete sending to the list. (optional) 
            var status = status_example;  // string | The status of the bot. (optional) 

            try
            {
                // Update Prompt Bot
                PromptBotBot result = apiInstance.UpdatePromptBot(id, emailId, endDate, status);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PromptsApi.UpdatePromptBot: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The bot id. | 
 **emailId** | **string**| The default email to use. | [optional] 
 **endDate** | **string**| The time frame to complete sending to the list. | [optional] 
 **status** | **string**| The status of the bot. | [optional] 

### Return type

[**PromptBotBot**](PromptBotBot.md)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepromptcampaign"></a>
# **UpdatePromptCampaign**
> void UpdatePromptCampaign (string clientGroupId, string brandedTemplateId = null, string personalTemplateId = null, bool? enabled = null)

Update Prompt Campaign

Updates a Prompt Campaign's Settings

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdatePromptCampaignExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PromptsApi();
            var clientGroupId = clientGroupId_example;  // string | The client group of the campaign.
            var brandedTemplateId = brandedTemplateId_example;  // string | The template to use for branded feel emails. (optional) 
            var personalTemplateId = personalTemplateId_example;  // string | The template to use for personal feel emails. (optional) 
            var enabled = true;  // bool? | Set whether the user is able to start receiving prompts. (optional) 

            try
            {
                // Update Prompt Campaign
                apiInstance.UpdatePromptCampaign(clientGroupId, brandedTemplateId, personalTemplateId, enabled);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PromptsApi.UpdatePromptCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientGroupId** | **string**| The client group of the campaign. | 
 **brandedTemplateId** | **string**| The template to use for branded feel emails. | [optional] 
 **personalTemplateId** | **string**| The template to use for personal feel emails. | [optional] 
 **enabled** | **bool?**| Set whether the user is able to start receiving prompts. | [optional] 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

