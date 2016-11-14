# IO.Swagger.Api.TeamsApi

All URIs are relative to *https://api.bombbomb.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddTeamMember**](TeamsApi.md#addteammember) | **POST** /team/{teamId}/member | Add Member to Team
[**CancelJerichoSend**](TeamsApi.md#canceljerichosend) | **DELETE** /team/{teamId}/jericho/{jerichoId} | Cancel a Jericho Send
[**CreateSubteam**](TeamsApi.md#createsubteam) | **POST** /team/{teamId}/subteam | Add a Subteam
[**DeleteSubteam**](TeamsApi.md#deletesubteam) | **DELETE** /team/{teamId}/subteam | Delete Subteam
[**GetClientGroupAssets**](TeamsApi.md#getclientgroupassets) | **GET** /team/assets/ | Lists team assets
[**GetJerichoSends**](TeamsApi.md#getjerichosends) | **GET** /team/{teamId}/jericho | List Jericho Sends
[**GetJerichoStats**](TeamsApi.md#getjerichostats) | **GET** /team/{teamId}/jericho/{jerichoId}/performance | Gets Jericho performance statistics
[**GetSubteams**](TeamsApi.md#getsubteams) | **GET** /team/{teamId}/subteam | List Subteams
[**QueueJerichoSend**](TeamsApi.md#queuejerichosend) | **POST** /team/{teamId}/jericho | Creates a Jericho send.
[**RemoveMemberFromTeam**](TeamsApi.md#removememberfromteam) | **DELETE** /team/{teamId}/member/{userId} | Remove Member from Team
[**UpdateTeam**](TeamsApi.md#updateteam) | **POST** /team/{teamId} | Update a team


<a name="addteammember"></a>
# **AddTeamMember**
> string AddTeamMember (string teamId, string userId = null, string userEmail = null, bool? admin = null)

Add Member to Team

Adds a member to a team.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddTeamMemberExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi();
            var teamId = teamId_example;  // string | The team id
            var userId = userId_example;  // string | The user id of the member being added to the team. (optional) 
            var userEmail = userEmail_example;  // string | The email of the member being added to the team. (optional) 
            var admin = true;  // bool? | Set if the user is an admin of this team. (optional) 

            try
            {
                // Add Member to Team
                string result = apiInstance.AddTeamMember(teamId, userId, userEmail, admin);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.AddTeamMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **string**| The team id | 
 **userId** | **string**| The user id of the member being added to the team. | [optional] 
 **userEmail** | **string**| The email of the member being added to the team. | [optional] 
 **admin** | **bool?**| Set if the user is an admin of this team. | [optional] 

### Return type

**string**

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsubteam"></a>
# **CreateSubteam**
> TeamPublicRepresentation CreateSubteam (string teamId, string name)

Add a Subteam

Adds a subteam to a parent team

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateSubteamExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi();
            var teamId = teamId_example;  // string | The team id
            var name = name_example;  // string | The subteam's name.

            try
            {
                // Add a Subteam
                TeamPublicRepresentation result = apiInstance.CreateSubteam(teamId, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.CreateSubteam: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **string**| The team id | 
 **name** | **string**| The subteam&#39;s name. | 

### Return type

[**TeamPublicRepresentation**](TeamPublicRepresentation.md)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesubteam"></a>
# **DeleteSubteam**
> string DeleteSubteam (string teamId, string subteamId)

Delete Subteam

Deletes a subteam

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteSubteamExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi();
            var teamId = teamId_example;  // string | The team id
            var subteamId = subteamId_example;  // string | The subteam you wish to delete.

            try
            {
                // Delete Subteam
                string result = apiInstance.DeleteSubteam(teamId, subteamId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.DeleteSubteam: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **string**| The team id | 
 **subteamId** | **string**| The subteam you wish to delete. | 

### Return type

**string**

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
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

 - **Content-Type**: application/x-www-form-urlencoded
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

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjerichostats"></a>
# **GetJerichoStats**
> JerichoPerformance GetJerichoStats (string jerichoId, string teamId)

Gets Jericho performance statistics

Returns an aggregate view of the performance of a Jericho send

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetJerichoStatsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi();
            var jerichoId = jerichoId_example;  // string | ID of the Jericho job
            var teamId = teamId_example;  // string | ID of team through which Jericho was sent

            try
            {
                // Gets Jericho performance statistics
                JerichoPerformance result = apiInstance.GetJerichoStats(jerichoId, teamId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.GetJerichoStats: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jerichoId** | **string**| ID of the Jericho job | 
 **teamId** | **string**| ID of team through which Jericho was sent | 

### Return type

[**JerichoPerformance**](JerichoPerformance.md)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubteams"></a>
# **GetSubteams**
> List<TeamPublicRepresentation> GetSubteams (string teamId)

List Subteams

Returns a collection of subteams for a parent team

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSubteamsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi();
            var teamId = teamId_example;  // string | The team id

            try
            {
                // List Subteams
                List&lt;TeamPublicRepresentation&gt; result = apiInstance.GetSubteams(teamId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.GetSubteams: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **string**| The team id | 

### Return type

[**List<TeamPublicRepresentation>**](TeamPublicRepresentation.md)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removememberfromteam"></a>
# **RemoveMemberFromTeam**
> string RemoveMemberFromTeam (string teamId, string userId)

Remove Member from Team

Removes a member from a team.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemoveMemberFromTeamExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi();
            var teamId = teamId_example;  // string | The team id
            var userId = userId_example;  // string | The user id of the member being removed.

            try
            {
                // Remove Member from Team
                string result = apiInstance.RemoveMemberFromTeam(teamId, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.RemoveMemberFromTeam: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **string**| The team id | 
 **userId** | **string**| The user id of the member being removed. | 

### Return type

**string**

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateteam"></a>
# **UpdateTeam**
> TeamPublicRepresentation UpdateTeam (string teamId, string name = null)

Update a team

Update fields on a team

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateTeamExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi();
            var teamId = teamId_example;  // string | The team id
            var name = name_example;  // string | The name of the team (optional) 

            try
            {
                // Update a team
                TeamPublicRepresentation result = apiInstance.UpdateTeam(teamId, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.UpdateTeam: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **string**| The team id | 
 **name** | **string**| The name of the team | [optional] 

### Return type

[**TeamPublicRepresentation**](TeamPublicRepresentation.md)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

