# IO.Swagger.Api.TeamsApi

All URIs are relative to *https://dev.api.bombbomb.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelJerichoSend**](TeamsApi.md#canceljerichosend) | **DELETE** /team/{teamId}/jericho/{jerichoId} | Cancel a Jericho Send
[**GetClientGroupAssets**](TeamsApi.md#getclientgroupassets) | **GET** /team/assets/ | Lists team assets
[**GetJerichoSends**](TeamsApi.md#getjerichosends) | **GET** /team/{teamId}/jericho | List Jericho Sends
[**QueueJerichoSend**](TeamsApi.md#queuejerichosend) | **POST** /team/{teamId}/jericho | Creates a Jericho send.


<a name="canceljerichosend"></a>
# **CancelJerichoSend**
> void CancelJerichoSend (string jerichoId)

Cancel a Jericho Send

Cancels a scheduled Jericho send from being sent.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CancelJerichoSendExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi();
            var jerichoId = jerichoId_example;  // string | ID of the Jericho Job to cancel

            try
            {
                // Cancel a Jericho Send
                apiInstance.CancelJerichoSend(jerichoId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.CancelJerichoSend: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jerichoId** | **string**| ID of the Jericho Job to cancel | 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclientgroupassets"></a>
# **GetClientGroupAssets**
> InlineResponse200 GetClientGroupAssets (string assetType, string teamId = null, string autoTagName = null, string pageSize = null, string page = null, string search = null)

Lists team assets

Returns a collection of assets

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientGroupAssetsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi();
            var assetType = assetType_example;  // string | The type of assets.
            var teamId = teamId_example;  // string | The team containing the assets. (optional) 
            var autoTagName = autoTagName_example;  // string | The auto tag name containing the assets. (optional) 
            var pageSize = pageSize_example;  // string | The number of items to retrieve in a single db query. (optional) 
            var page = page_example;  // string | Zero-based index of the page of data to retrieve from the db. (optional) 
            var search = search_example;  // string | Search words. (optional) 

            try
            {
                // Lists team assets
                InlineResponse200 result = apiInstance.GetClientGroupAssets(assetType, teamId, autoTagName, pageSize, page, search);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.GetClientGroupAssets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetType** | **string**| The type of assets. | 
 **teamId** | **string**| The team containing the assets. | [optional] 
 **autoTagName** | **string**| The auto tag name containing the assets. | [optional] 
 **pageSize** | **string**| The number of items to retrieve in a single db query. | [optional] 
 **page** | **string**| Zero-based index of the page of data to retrieve from the db. | [optional] 
 **search** | **string**| Search words. | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjerichosends"></a>
# **GetJerichoSends**
> List<JerichoConfiguration> GetJerichoSends (string teamId)

List Jericho Sends

Lists Jericho sends, both pending and sent.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetJerichoSendsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi();
            var teamId = teamId_example;  // string | The team whose Jericho sends you wish to see.

            try
            {
                // List Jericho Sends
                List&lt;JerichoConfiguration&gt; result = apiInstance.GetJerichoSends(teamId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.GetJerichoSends: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **string**| The team whose Jericho sends you wish to see. | 

### Return type

[**List<JerichoConfiguration>**](JerichoConfiguration.md)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queuejerichosend"></a>
# **QueueJerichoSend**
> JerichoConfiguration QueueJerichoSend (JerichoConfiguration config, string teamId)

Creates a Jericho send.

Sends email content on behalf of members of a client group. There are two forms this send can take:         Static Email, and Video Prompt. Static emails require only an emailId.         Video Prompts build emails dynamically and require most of the other fields.         You must be an administrator of a Team Account to use this method.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QueueJerichoSendExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi();
            var config = new JerichoConfiguration(); // JerichoConfiguration | JSON representing a Jericho configuration
            var teamId = teamId_example;  // string | The ID of the team.

            try
            {
                // Creates a Jericho send.
                JerichoConfiguration result = apiInstance.QueueJerichoSend(config, teamId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.QueueJerichoSend: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **config** | [**JerichoConfiguration**](JerichoConfiguration.md)| JSON representing a Jericho configuration | 
 **teamId** | **string**| The ID of the team. | 

### Return type

[**JerichoConfiguration**](JerichoConfiguration.md)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

