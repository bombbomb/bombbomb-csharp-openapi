# IO.Swagger.Api.EmailsApi

All URIs are relative to *https://api.bombbomb.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePrintingPressEmail**](EmailsApi.md#createprintingpressemail) | **POST** /emails/print | Create an Email with Printing Press
[**GetEmailTracking**](EmailsApi.md#getemailtracking) | **GET** /emails/{emailId}/tracking | Get Email Tracking
[**GetEmailTrackingInteractions**](EmailsApi.md#getemailtrackinginteractions) | **GET** /emails/{emailId}/tracking/interactions | Get Email Tracking Interactions
[**GetHourlyEmailTracking**](EmailsApi.md#gethourlyemailtracking) | **GET** /emails/{emailId}/tracking/hourly | Get Hourly Email Tracking


<a name="createprintingpressemail"></a>
# **CreatePrintingPressEmail**
> void CreatePrintingPressEmail (string templateId, string content, bool? replace, string videoId = null, string subjectLine = null)

Create an Email with Printing Press

Prints an email using the template id and content to the users account.If a video id, is include it will replace any video placeholders with that video.

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
            var replace = true;  // bool? | Set whether to replace video placeholders with video id.
            var videoId = videoId_example;  // string | A video to replace video place holders with. (optional) 
            var subjectLine = subjectLine_example;  // string | The subject line to be printed. (optional) 

            try
            {
                // Create an Email with Printing Press
                apiInstance.CreatePrintingPressEmail(templateId, content, replace, videoId, subjectLine);
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
 **replace** | **bool?**| Set whether to replace video placeholders with video id. | 
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

