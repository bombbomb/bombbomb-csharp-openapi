# IO.Swagger.Api.EmailsApi

All URIs are relative to *https://api.bombbomb.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePrintingPressEmail**](EmailsApi.md#createprintingpressemail) | **POST** /emails/print | Create an Email with Printing Press
[**GetAllTemplatesForCurrentUser**](EmailsApi.md#getalltemplatesforcurrentuser) | **GET** /emails/templates | Get all user templates
[**GetEmailTracking**](EmailsApi.md#getemailtracking) | **GET** /emails/{emailId}/tracking | Get Email Tracking
[**GetEmailTrackingInteractions**](EmailsApi.md#getemailtrackinginteractions) | **GET** /emails/{emailId}/tracking/interactions | Get Email Tracking Interactions
[**GetHourlyEmailTracking**](EmailsApi.md#gethourlyemailtracking) | **GET** /emails/{emailId}/tracking/hourly | Get Hourly Email Tracking
[**GetLiveFireData**](EmailsApi.md#getlivefiredata) | **GET** /emails/livefire | Get livefire feed data
[**GetQuickSendTemplates**](EmailsApi.md#getquicksendtemplates) | **GET** /emails/quicksend/templates | Get all quicksend templates
[**GetTemplateHtmlForTemplateId**](EmailsApi.md#gettemplatehtmlfortemplateid) | **GET** /emails/templates/{templateId}/html | Get the HTML for a given template
[**GetVideoQuickSenderData**](EmailsApi.md#getvideoquicksenderdata) | **GET** /emails/quicksend | Get quicksend data
[**SaveQuickSenderSettings**](EmailsApi.md#savequicksendersettings) | **POST** /emails/quicksend/settings | Save quicksender settings
[**VideoQuickSender**](EmailsApi.md#videoquicksender) | **POST** /emails/quicksend | Send a quicksend email


<a name="createprintingpressemail"></a>
# **CreatePrintingPressEmail**
> void CreatePrintingPressEmail (string templateId, string content, string emailId = null, string videoId = null, string subjectLine = null)

Create an Email with Printing Press

Prints an email using the template id and content to the users account.If a video id is included, it will replace any video placeholders with that video.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreatePrintingPressEmailExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailsApi();
            var templateId = templateId_example;  // string | The template id to be printed.
            var content = content_example;  // string | The content of the email.
            var emailId = emailId_example;  // string | The email id to be printed to. (optional) 
            var videoId = videoId_example;  // string | A video to replace video place holders with. (optional) 
            var subjectLine = subjectLine_example;  // string | The subject line to be printed. (optional) 

            try
            {
                // Create an Email with Printing Press
                apiInstance.CreatePrintingPressEmail(templateId, content, emailId, videoId, subjectLine);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailsApi.CreatePrintingPressEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **string**| The template id to be printed. | 
 **content** | **string**| The content of the email. | 
 **emailId** | **string**| The email id to be printed to. | [optional] 
 **videoId** | **string**| A video to replace video place holders with. | [optional] 
 **subjectLine** | **string**| The subject line to be printed. | [optional] 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalltemplatesforcurrentuser"></a>
# **GetAllTemplatesForCurrentUser**
> void GetAllTemplatesForCurrentUser (bool? quickSendOnly = null)

Get all user templates

Get all templates accessible to the current user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllTemplatesForCurrentUserExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailsApi();
            var quickSendOnly = true;  // bool? | Whether to return only quick send templates. (optional) 

            try
            {
                // Get all user templates
                apiInstance.GetAllTemplatesForCurrentUser(quickSendOnly);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailsApi.GetAllTemplatesForCurrentUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quickSendOnly** | **bool?**| Whether to return only quick send templates. | [optional] 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailtracking"></a>
# **GetEmailTracking**
> void GetEmailTracking (string emailId, string jobId = null)

Get Email Tracking

Get Tracking data for all sends of an Email

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEmailTrackingExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailsApi();
            var emailId = emailId_example;  // string | ID of the email
            var jobId = jobId_example;  // string | ID of the Job (or null for all jobs) (optional) 

            try
            {
                // Get Email Tracking
                apiInstance.GetEmailTracking(emailId, jobId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailsApi.GetEmailTracking: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailId** | **string**| ID of the email | 
 **jobId** | **string**| ID of the Job (or null for all jobs) | [optional] 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailtrackinginteractions"></a>
# **GetEmailTrackingInteractions**
> void GetEmailTrackingInteractions (string emailId, string jobId = null, string interactionType = null, string searchTerm = null)

Get Email Tracking Interactions

Get Contact detail interactions for an Email

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEmailTrackingInteractionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailsApi();
            var emailId = emailId_example;  // string | ID of the email
            var jobId = jobId_example;  // string | ID of the Job (or null for all jobs) (optional) 
            var interactionType = interactionType_example;  // string | Interaction type to order and filter by (optional) 
            var searchTerm = searchTerm_example;  // string | Search term to filer by (optional) 

            try
            {
                // Get Email Tracking Interactions
                apiInstance.GetEmailTrackingInteractions(emailId, jobId, interactionType, searchTerm);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailsApi.GetEmailTrackingInteractions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailId** | **string**| ID of the email | 
 **jobId** | **string**| ID of the Job (or null for all jobs) | [optional] 
 **interactionType** | **string**| Interaction type to order and filter by | [optional] 
 **searchTerm** | **string**| Search term to filer by | [optional] 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethourlyemailtracking"></a>
# **GetHourlyEmailTracking**
> void GetHourlyEmailTracking (string emailId, string jobId = null, string interactionType = null)

Get Hourly Email Tracking

Get Tracking data for an Email,             broken down by the hour and filterable by an Interaction type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetHourlyEmailTrackingExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailsApi();
            var emailId = emailId_example;  // string | ID of the email
            var jobId = jobId_example;  // string | ID of the Job (or null for all jobs) (optional) 
            var interactionType = interactionType_example;  // string | Interaction type to filter by (optional) 

            try
            {
                // Get Hourly Email Tracking
                apiInstance.GetHourlyEmailTracking(emailId, jobId, interactionType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailsApi.GetHourlyEmailTracking: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailId** | **string**| ID of the email | 
 **jobId** | **string**| ID of the Job (or null for all jobs) | [optional] 
 **interactionType** | **string**| Interaction type to filter by | [optional] 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlivefiredata"></a>
# **GetLiveFireData**
> void GetLiveFireData ()

Get livefire feed data

Get the user data for the live fire feed emails

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLiveFireDataExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailsApi();

            try
            {
                // Get livefire feed data
                apiInstance.GetLiveFireData();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailsApi.GetLiveFireData: " + e.Message );
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

<a name="getquicksendtemplates"></a>
# **GetQuickSendTemplates**
> void GetQuickSendTemplates ()

Get all quicksend templates

Get all quicksend templates accessible to the user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetQuickSendTemplatesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailsApi();

            try
            {
                // Get all quicksend templates
                apiInstance.GetQuickSendTemplates();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailsApi.GetQuickSendTemplates: " + e.Message );
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

<a name="gettemplatehtmlfortemplateid"></a>
# **GetTemplateHtmlForTemplateId**
> void GetTemplateHtmlForTemplateId (string templateId, string renderVariables = null)

Get the HTML for a given template

Get the HTML for a given template, with or without rendered variables

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTemplateHtmlForTemplateIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailsApi();
            var templateId = templateId_example;  // string | The id of the template.
            var renderVariables = renderVariables_example;  // string | Whether to render profile variables in the returned HTML. (optional) 

            try
            {
                // Get the HTML for a given template
                apiInstance.GetTemplateHtmlForTemplateId(templateId, renderVariables);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailsApi.GetTemplateHtmlForTemplateId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **string**| The id of the template. | 
 **renderVariables** | **string**| Whether to render profile variables in the returned HTML. | [optional] 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvideoquicksenderdata"></a>
# **GetVideoQuickSenderData**
> void GetVideoQuickSenderData (string message = null, string subject = null, string videoId = null, string templateId = null, string commaDelimEmails = null)

Get quicksend data

Get the user data for quicksender, including templates and lists.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetVideoQuickSenderDataExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailsApi();
            var message = message_example;  // string | A message for the video content. (optional) 
            var subject = subject_example;  // string | A subject for the video content. (optional) 
            var videoId = videoId_example;  // string | A video ID. (optional) 
            var templateId = templateId_example;  // string | A template ID. (optional) 
            var commaDelimEmails = commaDelimEmails_example;  // string | Comma delimited emails (optional) 

            try
            {
                // Get quicksend data
                apiInstance.GetVideoQuickSenderData(message, subject, videoId, templateId, commaDelimEmails);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailsApi.GetVideoQuickSenderData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **message** | **string**| A message for the video content. | [optional] 
 **subject** | **string**| A subject for the video content. | [optional] 
 **videoId** | **string**| A video ID. | [optional] 
 **templateId** | **string**| A template ID. | [optional] 
 **commaDelimEmails** | **string**| Comma delimited emails | [optional] 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savequicksendersettings"></a>
# **SaveQuickSenderSettings**
> void SaveQuickSenderSettings (string alertOnPlay = null, string alertOnOpen = null, string templateId = null)

Save quicksender settings

Save the quicksender notification and default template settings

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SaveQuickSenderSettingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailsApi();
            var alertOnPlay = alertOnPlay_example;  // string | A preference setting for whether or not to notify user on quicksend email video plays. (optional) 
            var alertOnOpen = alertOnOpen_example;  // string | A preference setting for whether or not to notify user on quicksend email opens. (optional) 
            var templateId = templateId_example;  // string | Id of a template to use for this send. A null value means use the default for this user. (optional) 

            try
            {
                // Save quicksender settings
                apiInstance.SaveQuickSenderSettings(alertOnPlay, alertOnOpen, templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailsApi.SaveQuickSenderSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **alertOnPlay** | **string**| A preference setting for whether or not to notify user on quicksend email video plays. | [optional] 
 **alertOnOpen** | **string**| A preference setting for whether or not to notify user on quicksend email opens. | [optional] 
 **templateId** | **string**| Id of a template to use for this send. A null value means use the default for this user. | [optional] 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="videoquicksender"></a>
# **VideoQuickSender**
> void VideoQuickSender (string videoId = null, string emailAddresses = null, string subject = null, string message = null, string listIds = null, int? scheduledSendTimestamp = null, string extendedProperties = null, string templateId = null, string stripHTML = null)

Send a quicksend email

Send a quicksend video email to the list or users provided.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class VideoQuickSenderExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailsApi();
            var videoId = videoId_example;  // string | A guid id for the video. (optional) 
            var emailAddresses = emailAddresses_example;  // string | A semi-colon separated list of email addresses to send to. (optional) 
            var subject = subject_example;  // string | Subject line for the email. (optional) 
            var message = message_example;  // string | Message for the body of the email. (optional) 
            var listIds = listIds_example;  // string | An array of list ids (optional) 
            var scheduledSendTimestamp = 56;  // int? | When to schedule the send (seconds since epoch). null value means send immediately. (optional) 
            var extendedProperties = extendedProperties_example;  // string | Bool value that when checked will send back both emailId as well as extra properties (optional) 
            var templateId = templateId_example;  // string | Id of a template to use for this send. A null value means use the default for this user. (optional) 
            var stripHTML = stripHTML_example;  // string | remove HTML elements (optional) 

            try
            {
                // Send a quicksend email
                apiInstance.VideoQuickSender(videoId, emailAddresses, subject, message, listIds, scheduledSendTimestamp, extendedProperties, templateId, stripHTML);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailsApi.VideoQuickSender: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **string**| A guid id for the video. | [optional] 
 **emailAddresses** | **string**| A semi-colon separated list of email addresses to send to. | [optional] 
 **subject** | **string**| Subject line for the email. | [optional] 
 **message** | **string**| Message for the body of the email. | [optional] 
 **listIds** | **string**| An array of list ids | [optional] 
 **scheduledSendTimestamp** | **int?**| When to schedule the send (seconds since epoch). null value means send immediately. | [optional] 
 **extendedProperties** | **string**| Bool value that when checked will send back both emailId as well as extra properties | [optional] 
 **templateId** | **string**| Id of a template to use for this send. A null value means use the default for this user. | [optional] 
 **stripHTML** | **string**| remove HTML elements | [optional] 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

