# IO.Swagger.Model.PromptSocialPrompt
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
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

