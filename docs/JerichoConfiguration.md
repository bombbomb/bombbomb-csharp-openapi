# IO.Swagger.Model.JerichoConfiguration
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**ClientGroupId** | **string** |  | [optional] 
**SendDate** | **DateTime?** | When the email should be sent. | [optional] 
**IsPrompt** | **bool?** | Determines whether this is a static or prompted send. | 
**EmailId** | **string** | Static send: The Email to send on behalf of the group members. | [optional] 
**PromptSubject** | **string** | Video Prompt: The subject line prompting the user to record a video. | [optional] 
**PromptBody** | **string** | Video Prompt: The HTML body of the email prompting the user to record a video. | [optional] 
**EmailSubject** | **string** | Video Prompt: The subject line of the final sent email | [optional] 
**EmailBody** | **string** | Video Prompt: The HTML body of the final sent email. | [optional] 
**SendWithoutVideo** | **bool?** | Video Prompt: Whether to send the final email if no video was recorded. | [optional] 
**Status** | **string** | The state of the send. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
