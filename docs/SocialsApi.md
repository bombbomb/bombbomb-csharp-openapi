# IO.Swagger.Api.SocialsApi

All URIs are relative to *https://api.bombbomb.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetFacebookPages**](SocialsApi.md#getfacebookpages) | **GET** /socials/facebook/pages | Gets facebook pages
[**GetSocialArticleProperties**](SocialsApi.md#getsocialarticleproperties) | **GET** /socials/properties | Gets the social email properties
[**GetSocialAuthorizations**](SocialsApi.md#getsocialauthorizations) | **GET** /socials/authorizations | Get authorizations for all social integration
[**GetSocialProfileProperties**](SocialsApi.md#getsocialprofileproperties) | **GET** /socials/profile | Gets the profile properties
[**GetSocialStats**](SocialsApi.md#getsocialstats) | **GET** /socials/{promptId}/stats | Get social stats for a prompt
[**PostSocialContent**](SocialsApi.md#postsocialcontent) | **POST** /socials/content | Creates social content
[**UpdateClientGroupSendMechanism**](SocialsApi.md#updateclientgroupsendmechanism) | **PUT** /socials/client/sendMechanism | Gets the auto shares from the client group assoc id
[**UpdateFacebookPages**](SocialsApi.md#updatefacebookpages) | **PUT** /socials/facebook/pages | Updates facebook page Ids
[**UpdateSocialContent**](SocialsApi.md#updatesocialcontent) | **PUT** /socials/content | Updates social content


<a name="getfacebookpages"></a>
# **GetFacebookPages**
> void GetFacebookPages ()

Gets facebook pages

Gets facebook pages by client id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFacebookPagesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialsApi();

            try
            {
                // Gets facebook pages
                apiInstance.GetFacebookPages();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialsApi.GetFacebookPages: " + e.Message );
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

<a name="getsocialarticleproperties"></a>
# **GetSocialArticleProperties**
> void GetSocialArticleProperties (string emailId)

Gets the social email properties

Gets the social email properties

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSocialArticlePropertiesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialsApi();
            var emailId = emailId_example;  // string | This is the email Id for the email url

            try
            {
                // Gets the social email properties
                apiInstance.GetSocialArticleProperties(emailId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialsApi.GetSocialArticleProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailId** | **string**| This is the email Id for the email url | 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsocialauthorizations"></a>
# **GetSocialAuthorizations**
> void GetSocialAuthorizations (string clientGroupId = null)

Get authorizations for all social integration

Get authorizations and autoshares for all social integration and has redirect for user to login

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSocialAuthorizationsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialsApi();
            var clientGroupId = clientGroupId_example;  // string | ID of the client group association (optional) 

            try
            {
                // Get authorizations for all social integration
                apiInstance.GetSocialAuthorizations(clientGroupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialsApi.GetSocialAuthorizations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientGroupId** | **string**| ID of the client group association | [optional] 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsocialprofileproperties"></a>
# **GetSocialProfileProperties**
> void GetSocialProfileProperties (string socialType)

Gets the profile properties

Gets the social profile properties

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSocialProfilePropertiesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialsApi();
            var socialType = socialType_example;  // string | The social type

            try
            {
                // Gets the profile properties
                apiInstance.GetSocialProfileProperties(socialType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialsApi.GetSocialProfileProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **socialType** | **string**| The social type | 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsocialstats"></a>
# **GetSocialStats**
> void GetSocialStats (string promptId)

Get social stats for a prompt

Get social stats for a prompt by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSocialStatsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialsApi();
            var promptId = promptId_example;  // string | ID of the prompt

            try
            {
                // Get social stats for a prompt
                apiInstance.GetSocialStats(promptId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialsApi.GetSocialStats: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **promptId** | **string**| ID of the prompt | 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsocialcontent"></a>
# **PostSocialContent**
> void PostSocialContent (string emailId)

Creates social content

Creates social content for an email

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostSocialContentExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialsApi();
            var emailId = emailId_example;  // string | The email's id

            try
            {
                // Creates social content
                apiInstance.PostSocialContent(emailId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialsApi.PostSocialContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailId** | **string**| The email&#39;s id | 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateclientgroupsendmechanism"></a>
# **UpdateClientGroupSendMechanism**
> void UpdateClientGroupSendMechanism (string sendMechanism, string clientGroupId, string enabled = null)

Gets the auto shares from the client group assoc id

Gets the auto shares from the client group assoc id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateClientGroupSendMechanismExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialsApi();
            var sendMechanism = sendMechanism_example;  // string | The send mechanism for the prompt
            var clientGroupId = clientGroupId_example;  // string | ID of the client group association
            var enabled = enabled_example;  // string | Is the send mechanism enabled? (optional) 

            try
            {
                // Gets the auto shares from the client group assoc id
                apiInstance.UpdateClientGroupSendMechanism(sendMechanism, clientGroupId, enabled);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialsApi.UpdateClientGroupSendMechanism: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sendMechanism** | **string**| The send mechanism for the prompt | 
 **clientGroupId** | **string**| ID of the client group association | 
 **enabled** | **string**| Is the send mechanism enabled? | [optional] 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatefacebookpages"></a>
# **UpdateFacebookPages**
> void UpdateFacebookPages (string pageIds)

Updates facebook page Ids

Updates facebook page Ids to be sent to for prompts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateFacebookPagesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialsApi();
            var pageIds = pageIds_example;  // string | Page Ids for the prompt

            try
            {
                // Updates facebook page Ids
                apiInstance.UpdateFacebookPages(pageIds);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialsApi.UpdateFacebookPages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pageIds** | **string**| Page Ids for the prompt | 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesocialcontent"></a>
# **UpdateSocialContent**
> void UpdateSocialContent (string socialId, string title = null, string description = null, string pictureUrl = null, string suggestedMessage = null)

Updates social content

Updates social content for an email

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateSocialContentExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialsApi();
            var socialId = socialId_example;  // string | The social id
            var title = title_example;  // string | The title for the article (optional) 
            var description = description_example;  // string | The article description (optional) 
            var pictureUrl = pictureUrl_example;  // string | The article picture url (optional) 
            var suggestedMessage = suggestedMessage_example;  // string | The suggested message to use (optional) 

            try
            {
                // Updates social content
                apiInstance.UpdateSocialContent(socialId, title, description, pictureUrl, suggestedMessage);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialsApi.UpdateSocialContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **socialId** | **string**| The social id | 
 **title** | **string**| The title for the article | [optional] 
 **description** | **string**| The article description | [optional] 
 **pictureUrl** | **string**| The article picture url | [optional] 
 **suggestedMessage** | **string**| The suggested message to use | [optional] 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

