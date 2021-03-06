# IO.Swagger.Api.PromptsApi

All URIs are relative to *https://api.bombbomb.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePromptBot**](PromptsApi.md#createpromptbot) | **POST** /prompts/bots | Create a running Prompt Bot for a list
[**CreateVideoEmailPrompt**](PromptsApi.md#createvideoemailprompt) | **POST** /prompt | Prompts user to send a video
[**GetAlternateCampaignContent**](PromptsApi.md#getalternatecampaigncontent) | **GET** /campaign/{campaignId}/content/alternate | List alternate campaign content
[**GetPendingVideoEmailPrompts**](PromptsApi.md#getpendingvideoemailprompts) | **GET** /prompt/pending | List pending prompts
[**GetPromptBots**](PromptsApi.md#getpromptbots) | **GET** /prompts/bots | List Prompt Bots
[**GetPromptCampaigns**](PromptsApi.md#getpromptcampaigns) | **GET** /prompts/{userId}/campaigns | List Prompt Campaigns
[**GetVideoEmailPrompt**](PromptsApi.md#getvideoemailprompt) | **GET** /prompt/{id} | Gets a prompt
[**GetVideoEmailPrompts**](PromptsApi.md#getvideoemailprompts) | **GET** /prompt/ | List prompts
[**RespondToVideoEmailPrompt**](PromptsApi.md#respondtovideoemailprompt) | **POST** /prompt/{id}/response | Respond to a prompt
[**SendPromptImmediately**](PromptsApi.md#sendpromptimmediately) | **POST** /prompt/{id}/sendit | 
[**SyncPromptSubscriptions**](PromptsApi.md#syncpromptsubscriptions) | **POST** /prompts/campaigns/sync | Syncs Campaigns and One to Ones Subscriptions for User
[**UpdatePrompt**](PromptsApi.md#updateprompt) | **PUT** /prompts/{id} | Update Prompt
[**UpdatePromptBot**](PromptsApi.md#updatepromptbot) | **PUT** /prompts/bots/{id} | Update Prompt Bot
[**UpdatePromptCampaign**](PromptsApi.md#updatepromptcampaign) | **PUT** /prompts/campaigns/{clientGroupId} | Update Prompt Campaign
[**UpdatePromptTemplate**](PromptsApi.md#updateprompttemplate) | **PUT** /prompts/{id}/content | Update Prompt Content


<a name="createpromptbot"></a>
# **CreatePromptBot**
> PromptBot CreatePromptBot (string emailId, string name, string subject, string content, string contactFieldValueColumn, string botTypeId, string templateId, string listId = null, string videoId = null, string endDate = null)

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
            var emailId = emailId_example;  // string | The default email to use.
            var name = name_example;  // string | The name of the bot.
            var subject = subject_example;  // string | The subject of the default email.
            var content = content_example;  // string | The content used in the email.
            var contactFieldValueColumn = contactFieldValueColumn_example;  // string | The custom field value column with dates for this bot.
            var botTypeId = botTypeId_example;  // string | The type of bot to create.
            var templateId = templateId_example;  // string | The template used to create the email id.
            var listId = listId_example;  // string | The list id to attach the bot to. (optional) 
            var videoId = videoId_example;  // string | The video used in the email. (optional) 
            var endDate = endDate_example;  // string | The time frame to complete sending to the list. (optional) 

            try
            {
                // Create a running Prompt Bot for a list
                PromptBot result = apiInstance.CreatePromptBot(emailId, name, subject, content, contactFieldValueColumn, botTypeId, templateId, listId, videoId, endDate);
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
 **emailId** | **string**| The default email to use. | 
 **name** | **string**| The name of the bot. | 
 **subject** | **string**| The subject of the default email. | 
 **content** | **string**| The content used in the email. | 
 **contactFieldValueColumn** | **string**| The custom field value column with dates for this bot. | 
 **botTypeId** | **string**| The type of bot to create. | 
 **templateId** | **string**| The template used to create the email id. | 
 **listId** | **string**| The list id to attach the bot to. | [optional] 
 **videoId** | **string**| The video used in the email. | [optional] 
 **endDate** | **string**| The time frame to complete sending to the list. | [optional] 

### Return type

[**PromptBot**](PromptBot.md)

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

<a name="getalternatecampaigncontent"></a>
# **GetAlternateCampaignContent**
> void GetAlternateCampaignContent (string clientGroupId)

List alternate campaign content

Returns a list of alternate campaign content by campaign id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAlternateCampaignContentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PromptsApi();
            var clientGroupId = clientGroupId_example;  // string | Id for the campaign

            try
            {
                // List alternate campaign content
                apiInstance.GetAlternateCampaignContent(clientGroupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PromptsApi.GetAlternateCampaignContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientGroupId** | **string**| Id for the campaign | 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
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
> List<PromptBot> GetPromptBots ()

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
                List&lt;PromptBot&gt; result = apiInstance.GetPromptBots();
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

[**List<PromptBot>**](PromptBot.md)

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
> VideoEmailPrompt RespondToVideoEmailPrompt (string id, string choice, string videoId = null, string emailId = null, string subject = null)

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
            var choice = choice_example;  // string | The users' selection. Can be: WithVideo, WithEmail, Cancel, Restore, Reset, Manual
            var videoId = videoId_example;  // string | The id of the video. (optional) 
            var emailId = emailId_example;  // string | The id of the email. (optional) 
            var subject = subject_example;  // string | The subject of the email (optional) 

            try
            {
                // Respond to a prompt
                VideoEmailPrompt result = apiInstance.RespondToVideoEmailPrompt(id, choice, videoId, emailId, subject);
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
 **choice** | **string**| The users&#39; selection. Can be: WithVideo, WithEmail, Cancel, Restore, Reset, Manual | 
 **videoId** | **string**| The id of the video. | [optional] 
 **emailId** | **string**| The id of the email. | [optional] 
 **subject** | **string**| The subject of the email | [optional] 

### Return type

[**VideoEmailPrompt**](VideoEmailPrompt.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendpromptimmediately"></a>
# **SendPromptImmediately**
> void SendPromptImmediately (string id)



Ignore send date and send the prompt now.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SendPromptImmediatelyExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PromptsApi();
            var id = id_example;  // string | The Id of the prompt

            try
            {
                apiInstance.SendPromptImmediately(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PromptsApi.SendPromptImmediately: " + e.Message );
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

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="syncpromptsubscriptions"></a>
# **SyncPromptSubscriptions**
> void SyncPromptSubscriptions (bool? migrate = null)

Syncs Campaigns and One to Ones Subscriptions for User

Syncs Campaigns and One to Ones Subscriptions for User based on their profile information. The user must be a Prompt Subscriber.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SyncPromptSubscriptionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PromptsApi();
            var migrate = true;  // bool? | After syncing, migrate away from old campaigns. (optional) 

            try
            {
                // Syncs Campaigns and One to Ones Subscriptions for User
                apiInstance.SyncPromptSubscriptions(migrate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PromptsApi.SyncPromptSubscriptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **migrate** | **bool?**| After syncing, migrate away from old campaigns. | [optional] 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateprompt"></a>
# **UpdatePrompt**
> void UpdatePrompt (string id, string sendMechanism = null, string facebookMessage = null, string twitterMessage = null, string videoId = null, string emailId = null, string subject = null, string resetCache = null, string resetEmailContent = null, string status = null)

Update Prompt

Updates a Prompt

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdatePromptExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PromptsApi();
            var id = id_example;  // string | The prompt's id
            var sendMechanism = sendMechanism_example;  // string | The mechanism for the prompt to be sent (optional) 
            var facebookMessage = facebookMessage_example;  // string | The facebook message assigned to the prompt (optional) 
            var twitterMessage = twitterMessage_example;  // string | The twitter message assigned to the prompt (optional) 
            var videoId = videoId_example;  // string | The id of the video. (optional) 
            var emailId = emailId_example;  // string | The id of the email. (optional) 
            var subject = subject_example;  // string | The subject of the email (optional) 
            var resetCache = resetCache_example;  // string | The subject of the email (optional) 
            var resetEmailContent = resetEmailContent_example;  // string | The subject of the email (optional) 
            var status = status_example;  // string | The status of the prompt (optional) 

            try
            {
                // Update Prompt
                apiInstance.UpdatePrompt(id, sendMechanism, facebookMessage, twitterMessage, videoId, emailId, subject, resetCache, resetEmailContent, status);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PromptsApi.UpdatePrompt: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The prompt&#39;s id | 
 **sendMechanism** | **string**| The mechanism for the prompt to be sent | [optional] 
 **facebookMessage** | **string**| The facebook message assigned to the prompt | [optional] 
 **twitterMessage** | **string**| The twitter message assigned to the prompt | [optional] 
 **videoId** | **string**| The id of the video. | [optional] 
 **emailId** | **string**| The id of the email. | [optional] 
 **subject** | **string**| The subject of the email | [optional] 
 **resetCache** | **string**| The subject of the email | [optional] 
 **resetEmailContent** | **string**| The subject of the email | [optional] 
 **status** | **string**| The status of the prompt | [optional] 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepromptbot"></a>
# **UpdatePromptBot**
> PromptBot UpdatePromptBot (string id, string emailId, string name, string subject, string content, string contactFieldValueColumn, string templateId, string listId = null, string videoId = null, string endDate = null, string status = null)

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
            var emailId = emailId_example;  // string | The default email to use.
            var name = name_example;  // string | The name of the bot.
            var subject = subject_example;  // string | The subject of the default email.
            var content = content_example;  // string | The content used in the default email.
            var contactFieldValueColumn = contactFieldValueColumn_example;  // string | The custom field value column with dates for this bot.
            var templateId = templateId_example;  // string | The template used to create the email id.
            var listId = listId_example;  // string | The list id to attach the bot to. (optional) 
            var videoId = videoId_example;  // string | The video used in the default email. (optional) 
            var endDate = endDate_example;  // string | The time frame to complete sending to the list. (optional) 
            var status = status_example;  // string | The status of the bot. (optional) 

            try
            {
                // Update Prompt Bot
                PromptBot result = apiInstance.UpdatePromptBot(id, emailId, name, subject, content, contactFieldValueColumn, templateId, listId, videoId, endDate, status);
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
 **emailId** | **string**| The default email to use. | 
 **name** | **string**| The name of the bot. | 
 **subject** | **string**| The subject of the default email. | 
 **content** | **string**| The content used in the default email. | 
 **contactFieldValueColumn** | **string**| The custom field value column with dates for this bot. | 
 **templateId** | **string**| The template used to create the email id. | 
 **listId** | **string**| The list id to attach the bot to. | [optional] 
 **videoId** | **string**| The video used in the default email. | [optional] 
 **endDate** | **string**| The time frame to complete sending to the list. | [optional] 
 **status** | **string**| The status of the bot. | [optional] 

### Return type

[**PromptBot**](PromptBot.md)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepromptcampaign"></a>
# **UpdatePromptCampaign**
> void UpdatePromptCampaign (string clientGroupId, string brandedTemplateId = null, string personalTemplateId = null, bool? enabled = null, string sendMechanism = null)

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
            var sendMechanism = sendMechanism_example;  // string | The way to send the prompt (optional) 

            try
            {
                // Update Prompt Campaign
                apiInstance.UpdatePromptCampaign(clientGroupId, brandedTemplateId, personalTemplateId, enabled, sendMechanism);
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
 **sendMechanism** | **string**| The way to send the prompt | [optional] 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateprompttemplate"></a>
# **UpdatePromptTemplate**
> void UpdatePromptTemplate (string id, string alternateContentId, string newEmailId, string ogEmailId, string newExampleVideoId)

Update Prompt Content

Updates a Prompt Content

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdatePromptTemplateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PromptsApi();
            var id = id_example;  // string | The prompt's id
            var alternateContentId = alternateContentId_example;  // string | The alternate content id
            var newEmailId = newEmailId_example;  // string | The prompt's new email id
            var ogEmailId = ogEmailId_example;  // string | The prompt's original email id
            var newExampleVideoId = newExampleVideoId_example;  // string | The prompt's new tutorial video id

            try
            {
                // Update Prompt Content
                apiInstance.UpdatePromptTemplate(id, alternateContentId, newEmailId, ogEmailId, newExampleVideoId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PromptsApi.UpdatePromptTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The prompt&#39;s id | 
 **alternateContentId** | **string**| The alternate content id | 
 **newEmailId** | **string**| The prompt&#39;s new email id | 
 **ogEmailId** | **string**| The prompt&#39;s original email id | 
 **newExampleVideoId** | **string**| The prompt&#39;s new tutorial video id | 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

