# IO.Swagger.Model.VideoEmailPrompt
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TemplateId** | **string** | Optional. The email template to be used in the sent email, if none supplied, the users&#39; default will be applied. | [optional] 
**EmailSubjectLine** | **string** | The subject line of the final email | [optional] 
**EmailContent** | **string** | The HTML content of the final email | [optional] 
**ContactId** | **string** | Contact Id to send the final email to | [optional] 
**ToLists** | **List&lt;string&gt;** | List Ids to send the final email to | [optional] 
**PromptIntro** | **string** | A paragraph intro statement about the purpose of the email you&#39;re recording a video for. | [optional] 
**ExampleVideoId** | **string** | An example or explanatory video to help the user understand what to say. | [optional] 
**FollowupVideoId** | **string** | An example or explanatory video to help the user understand what to say. | [optional] 
**SendWithoutVideo** | **bool?** | Whether to send the email if no video is recorded. If set to require a video, and none is added before the videoDueDate, the prompt is cancelled. | [optional] 
**VideoDueDate** | **DateTime?** | When the video must be recorded by | [optional] 
**VideoId** | **string** | The video that was added to the prompt. Read Only. | [optional] 
**EmailId** | **string** | The email that was created by the prompt Read Only. | [optional] 
**JobId** | **string** | The job sent by the prompt Read Only. | [optional] 
**PromptBotId** | **string** | The bot that created the prompt. | [optional] 
**ApplyTemplate** | **bool?** | Controls whether a user template is applied to the message as it is sent | [optional] 
**FacebookMessage** | **string** | The facebook message to be passed off to social sender | [optional] 
**TwitterMessage** | **string** | The twitter message to be passed off to social sender | [optional] 
**LinkedinMessage** | **string** | The linkedin message to be passed off to social sender | [optional] 
**AlternateContentId** | **string** | The id for the alternate content id | [optional] 
**Id** | **string** | The identifier of the prompt. Read Only. | [optional] 
**UserId** | **string** | The prompt&#39;s owner. Read Only. | [optional] 
**JerichoId** | **string** | If sent in a jericho context, this will have the jericho id | [optional] 
**PromptSubject** | **string** | The prompt&#39;s subject line | [optional] 
**PromptHtml** | **string** | The suggested script of the prompt. | [optional] 
**ScheduledSendDate** | **DateTime?** | When the final email is scheduled to be sent | [optional] 
**ClientGroupId** | **string** | The client group campaign that created the prompt. | [optional] 
**ThumbnailUrl** | **string** | The URL of a thumbnail image for this prompt | [optional] 
**Status** | **int?** | The status of the prompt: created &#x3D; 0, sent &#x3D; 10, recorded &#x3D; 20, job_created &#x3D; 30, timed_out &#x3D; 40, declined &#x3D; 50 Read Only | [optional] 
**CreatedDate** | **DateTime?** | When the email was first sent out | [optional] 
**LastNotified** | **DateTime?** | When the user was last notified about a prompt email waiting for a video | [optional] 
**SendMechanism** | **DateTime?** | The sendMechanism property | [optional] 
**SendTypes** | **List&lt;string&gt;** | The types of mechanisms this prompt can send. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

