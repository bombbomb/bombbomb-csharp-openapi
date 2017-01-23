# IO.Swagger.Model.VideoEmailPrompt
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The identifier of the prompt. Read Only. | [optional] 
**UserId** | **string** | The prompt&#39;s owner. Read Only. | [optional] 
**TemplateId** | **string** | Optional. The email template to be used in the sent email, if none supplied, the users&#39; default will be applied. | [optional] 
**EmailSubjectLine** | **string** | The subject line of the final email | 
**EmailContent** | **string** | The HTML content of the final email | 
**ThumbnailUrl** | **string** | The URL of a thumbnail image for this prompt | [optional] 
**ToEmailAddresses** | **List&lt;string&gt;** | Email addresses to send the final email to, can be mixed with listIds. | [optional] 
**ToLists** | **List&lt;string&gt;** | List Ids to send the final email to | [optional] 
**JerichoId** | **string** | If sent in a jericho context, this will have the jericho id | [optional] 
**PromptSubject** | **string** | The prompt&#39;s subject line | 
**PromptHtml** | **string** | The suggested script of the prompt. | 
**PromptIntro** | **string** | A paragraph intro statement about the purpose of the email you&#39;re recording a video for. | [optional] 
**ExampleVideoId** | **string** | An example or explanatory video to help the user understand what to say. | [optional] 
**SendWithoutVideo** | **bool?** | Whether to send the email if no video is recorded. If set to require a video, and none is added before the videoDueDate, the prompt is cancelled. | [optional] 
**VideoDueDate** | **DateTime?** | When the video must be recorded by | [optional] 
**ScheduledSendDate** | **DateTime?** | When the final email is scheduled to be sent | 
**VideoId** | **string** | The video that was added to the prompt. Read Only. | [optional] 
**EmailId** | **string** | The email that was created by the prompt Read Only. | [optional] 
**JobId** | **string** | The job sent by the prompt Read Only. | [optional] 
**PromptBotId** | **string** | The bot that created the prompt. | [optional] 
**ClientGroupId** | **string** | The client group campaign that created the prompt. | [optional] 
**Status** | **int?** | The status of the prompt: created &#x3D; 0, sent &#x3D; 10, recorded &#x3D; 20, job_created &#x3D; 30, timed_out &#x3D; 40, declined &#x3D; 50 Read Only | [optional] 
**ApplyTemplate** | **bool?** | Controls whether a user template is applied to the message as it is sent | [optional] 
**CreatedDate** | **DateTime?** | When the email was first sent out | [optional] 
**LastNotified** | **DateTime?** | When the user was last notified about a prompt email waiting for a video | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

