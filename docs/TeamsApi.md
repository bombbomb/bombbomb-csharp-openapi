# IO.Swagger.Api.TeamsApi

All URIs are relative to *https://api.bombbomb.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddTeamMember**](TeamsApi.md#addteammember) | **POST** /team/{teamId}/member | Add Member to Team
[**AddUsers**](TeamsApi.md#addusers) | **POST** /team/{teamId}/members | Add users to group.
[**AddUsersFromCsv**](TeamsApi.md#addusersfromcsv) | **POST** /team/{teamId}/members/csv | Add members to group from CSV
[**CancelJerichoSend**](TeamsApi.md#canceljerichosend) | **DELETE** /team/{teamId}/jericho/{jerichoId} | Cancel a Jericho Send
[**CreateSubteam**](TeamsApi.md#createsubteam) | **POST** /team/{teamId}/subteam | Add a Subteam
[**DeleteSubteam**](TeamsApi.md#deletesubteam) | **DELETE** /team/{teamId}/subteam | Delete Subteam
[**GetAllClientGroupAssociations**](TeamsApi.md#getallclientgroupassociations) | **GET** /team/associations/ | Lists team associations
[**GetClientGroupAssets**](TeamsApi.md#getclientgroupassets) | **GET** /team/assets/ | Lists team assets
[**GetClientGroupStatistics**](TeamsApi.md#getclientgroupstatistics) | **GET** /team/{teamId}/stats | Get Team statistics
[**GetJerichoSends**](TeamsApi.md#getjerichosends) | **GET** /team/{teamId}/jericho | List Jericho Sends
[**GetJerichoStats**](TeamsApi.md#getjerichostats) | **GET** /team/{teamId}/jericho/{jerichoId}/performance | Gets Jericho performance statistics
[**GetPagedClientGroupMembers**](TeamsApi.md#getpagedclientgroupmembers) | **GET** /team/{teamId}/members | List Team Members
[**GetSubteams**](TeamsApi.md#getsubteams) | **GET** /team/{teamId}/subteam | List Subteams
[**GetTeamPromptAggregateStats**](TeamsApi.md#getteampromptaggregatestats) | **GET** /team/{clientGroupId}/campaign/stats | Get aggregate stats for campaigns
[**GetTeamPromptCampaigns**](TeamsApi.md#getteampromptcampaigns) | **GET** /team/{clientGroupId}/campaign | Get campaigns for team
[**InviteToSocialPromptTeam**](TeamsApi.md#invitetosocialpromptteam) | **POST** /teams/prompt/invite | Invite a list to join the admin&#39;s social prompt team
[**QueueJerichoSend**](TeamsApi.md#queuejerichosend) | **POST** /team/{teamId}/jericho | Creates a Jericho send.
[**RemoveMemberFromTeam**](TeamsApi.md#removememberfromteam) | **DELETE** /team/{teamId}/member/{userId} | Remove Member from Team
[**ResendTeamMemberInvitation**](TeamsApi.md#resendteammemberinvitation) | **POST** /team/{teamId}/{memberUserId}/rewelcome | Resend invite
[**UpdateJerichoPromptSend**](TeamsApi.md#updatejerichopromptsend) | **PUT** /team/{teamId}/jericho/{jerichoId} | Updates the Jericho Prompt Settings
[**UpdateTeam**](TeamsApi.md#updateteam) | **POST** /team/{teamId} | Update a team
[**UpdateTeamMember**](TeamsApi.md#updateteammember) | **PUT** /team/{teamId}/member | Update Member of Team


<a name="addteammember"></a>
# **AddTeamMember**
> string AddTeamMember (string teamId, bool? admin = null, string subgroupIds = null, string userEmail = null, string userId = null)

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
            var admin = true;  // bool? | Set if the user is an admin of this team. (optional) 
            var subgroupIds = subgroupIds_example;  // string | Subgroup IDs to add user to (optional) 
            var userEmail = userEmail_example;  // string | The email of the member being added to the team. (optional) 
            var userId = userId_example;  // string | The user id of the member being added to the team. (optional) 

            try
            {
                // Add Member to Team
                string result = apiInstance.AddTeamMember(teamId, admin, subgroupIds, userEmail, userId);
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
 **admin** | **bool?**| Set if the user is an admin of this team. | [optional] 
 **subgroupIds** | **string**| Subgroup IDs to add user to | [optional] 
 **userEmail** | **string**| The email of the member being added to the team. | [optional] 
 **userId** | **string**| The user id of the member being added to the team. | [optional] 

### Return type

**string**

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addusers"></a>
# **AddUsers**
> void AddUsers (string teamId, string userDetails, string sendWelcomeEmail = null, string subgroupIds = null)

Add users to group.

Add a new or existing user to group.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddUsersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi();
            var teamId = teamId_example;  // string | The team id
            var userDetails = userDetails_example;  // string | Array of emails or objects containing details needed to create user
            var sendWelcomeEmail = sendWelcomeEmail_example;  // string | Whether to send welcome email to new users (optional) 
            var subgroupIds = subgroupIds_example;  // string | Subgroup IDs to add user to (optional) 

            try
            {
                // Add users to group.
                apiInstance.AddUsers(teamId, userDetails, sendWelcomeEmail, subgroupIds);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.AddUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **string**| The team id | 
 **userDetails** | **string**| Array of emails or objects containing details needed to create user | 
 **sendWelcomeEmail** | **string**| Whether to send welcome email to new users | [optional] 
 **subgroupIds** | **string**| Subgroup IDs to add user to | [optional] 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addusersfromcsv"></a>
# **AddUsersFromCsv**
> void AddUsersFromCsv (string teamId, string csvImportId, string map, string sendWelcomeEmail = null, string subgroupIds = null)

Add members to group from CSV

Imports members to a group from a given CSV ID.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddUsersFromCsvExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi();
            var teamId = teamId_example;  // string | The team id
            var csvImportId = csvImportId_example;  // string | ID of the CSV to import
            var map = map_example;  // string | Object to use when mapping import to AccountCreateDetails. Key is property name on details, value is CSV column number.
            var sendWelcomeEmail = sendWelcomeEmail_example;  // string | Whether to send welcome email to new users (optional) 
            var subgroupIds = subgroupIds_example;  // string | Subgroup IDs to add user to (optional) 

            try
            {
                // Add members to group from CSV
                apiInstance.AddUsersFromCsv(teamId, csvImportId, map, sendWelcomeEmail, subgroupIds);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.AddUsersFromCsv: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **string**| The team id | 
 **csvImportId** | **string**| ID of the CSV to import | 
 **map** | **string**| Object to use when mapping import to AccountCreateDetails. Key is property name on details, value is CSV column number. | 
 **sendWelcomeEmail** | **string**| Whether to send welcome email to new users | [optional] 
 **subgroupIds** | **string**| Subgroup IDs to add user to | [optional] 

### Return type

void (empty response body)

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

<a name="getallclientgroupassociations"></a>
# **GetAllClientGroupAssociations**
> void GetAllClientGroupAssociations (string clientId)

Lists team associations

Returns a collection of team associations for a given user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllClientGroupAssociationsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi();
            var clientId = clientId_example;  // string | The clientId requesting group associations.

            try
            {
                // Lists team associations
                apiInstance.GetAllClientGroupAssociations(clientId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.GetAllClientGroupAssociations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| The clientId requesting group associations. | 

### Return type

void (empty response body)

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

<a name="getclientgroupstatistics"></a>
# **GetClientGroupStatistics**
> void GetClientGroupStatistics (string teamId, string memberStatus = null)

Get Team statistics

Get top level statistic data for a Team

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientGroupStatisticsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi();
            var teamId = teamId_example;  // string | The team id
            var memberStatus = memberStatus_example;  // string | The status of members to query for (optional) 

            try
            {
                // Get Team statistics
                apiInstance.GetClientGroupStatistics(teamId, memberStatus);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.GetClientGroupStatistics: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **string**| The team id | 
 **memberStatus** | **string**| The status of members to query for | [optional] 

### Return type

void (empty response body)

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

<a name="getpagedclientgroupmembers"></a>
# **GetPagedClientGroupMembers**
> void GetPagedClientGroupMembers (string teamId, string pageSize, string page, string status = null, string search = null, string orderBy = null, string orderDirection = null)

List Team Members

Get a paginated listing of Team members

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPagedClientGroupMembersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi();
            var teamId = teamId_example;  // string | The team id
            var pageSize = pageSize_example;  // string | Amount of records to return in a page.
            var page = page_example;  // string | The page to return.
            var status = status_example;  // string | The status type to filter by. (optional) 
            var search = search_example;  // string | Filter results with names that match the search term. (optional) 
            var orderBy = orderBy_example;  // string | Key to order results by (optional) 
            var orderDirection = orderDirection_example;  // string | ASC or DESC (optional) 

            try
            {
                // List Team Members
                apiInstance.GetPagedClientGroupMembers(teamId, pageSize, page, status, search, orderBy, orderDirection);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.GetPagedClientGroupMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **string**| The team id | 
 **pageSize** | **string**| Amount of records to return in a page. | 
 **page** | **string**| The page to return. | 
 **status** | **string**| The status type to filter by. | [optional] 
 **search** | **string**| Filter results with names that match the search term. | [optional] 
 **orderBy** | **string**| Key to order results by | [optional] 
 **orderDirection** | **string**| ASC or DESC | [optional] 

### Return type

void (empty response body)

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

<a name="getteampromptaggregatestats"></a>
# **GetTeamPromptAggregateStats**
> void GetTeamPromptAggregateStats (string clientGroupId)

Get aggregate stats for campaigns

Get all the campaigns aggregate stats

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTeamPromptAggregateStatsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi();
            var clientGroupId = clientGroupId_example;  // string | ID of the client group association

            try
            {
                // Get aggregate stats for campaigns
                apiInstance.GetTeamPromptAggregateStats(clientGroupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.GetTeamPromptAggregateStats: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientGroupId** | **string**| ID of the client group association | 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteampromptcampaigns"></a>
# **GetTeamPromptCampaigns**
> void GetTeamPromptCampaigns (string clientGroupId, string searchTerm = null, string currentPage = null)

Get campaigns for team

Get campaigns for the team and their stats

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTeamPromptCampaignsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi();
            var clientGroupId = clientGroupId_example;  // string | ID of the client group association
            var searchTerm = searchTerm_example;  // string | The value to search for in prompt subject (optional) 
            var currentPage = currentPage_example;  // string | The current page (optional) 

            try
            {
                // Get campaigns for team
                apiInstance.GetTeamPromptCampaigns(clientGroupId, searchTerm, currentPage);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.GetTeamPromptCampaigns: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientGroupId** | **string**| ID of the client group association | 
 **searchTerm** | **string**| The value to search for in prompt subject | [optional] 
 **currentPage** | **string**| The current page | [optional] 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invitetosocialpromptteam"></a>
# **InviteToSocialPromptTeam**
> void InviteToSocialPromptTeam (string teamId, string listId)

Invite a list to join the admin's social prompt team

Invite to Social Prompt Team

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InviteToSocialPromptTeamExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi();
            var teamId = teamId_example;  // string | The team id
            var listId = listId_example;  // string | List to invite to the social prompt team.

            try
            {
                // Invite a list to join the admin's social prompt team
                apiInstance.InviteToSocialPromptTeam(teamId, listId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.InviteToSocialPromptTeam: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **string**| The team id | 
 **listId** | **string**| List to invite to the social prompt team. | 

### Return type

void (empty response body)

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

<a name="resendteammemberinvitation"></a>
# **ResendTeamMemberInvitation**
> TeamPublicRepresentation ResendTeamMemberInvitation (string teamId, string memberUserId)

Resend invite

Resend invitation to a member of a team

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ResendTeamMemberInvitationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi();
            var teamId = teamId_example;  // string | The team id
            var memberUserId = memberUserId_example;  // string | The user id of the member being resent an invitation.

            try
            {
                // Resend invite
                TeamPublicRepresentation result = apiInstance.ResendTeamMemberInvitation(teamId, memberUserId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.ResendTeamMemberInvitation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **string**| The team id | 
 **memberUserId** | **string**| The user id of the member being resent an invitation. | 

### Return type

[**TeamPublicRepresentation**](TeamPublicRepresentation.md)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatejerichopromptsend"></a>
# **UpdateJerichoPromptSend**
> void UpdateJerichoPromptSend (string teamId, string jerichoId)

Updates the Jericho Prompt Settings

Updates the prompt settings based on the original email id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateJerichoPromptSendExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi();
            var teamId = teamId_example;  // string | The team id
            var jerichoId = jerichoId_example;  // string | ID of the Jericho job

            try
            {
                // Updates the Jericho Prompt Settings
                apiInstance.UpdateJerichoPromptSend(teamId, jerichoId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.UpdateJerichoPromptSend: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **string**| The team id | 
 **jerichoId** | **string**| ID of the Jericho job | 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateteam"></a>
# **UpdateTeam**
> TeamPublicRepresentation UpdateTeam (string teamId, string name = null, string state = null, bool? subteamsCanAddMembers = null)

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
            var state = state_example;  // string | The status of the login permissions (optional) 
            var subteamsCanAddMembers = true;  // bool? | Updates subteam member adding setting on group (optional) 

            try
            {
                // Update a team
                TeamPublicRepresentation result = apiInstance.UpdateTeam(teamId, name, state, subteamsCanAddMembers);
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
 **state** | **string**| The status of the login permissions | [optional] 
 **subteamsCanAddMembers** | **bool?**| Updates subteam member adding setting on group | [optional] 

### Return type

[**TeamPublicRepresentation**](TeamPublicRepresentation.md)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateteammember"></a>
# **UpdateTeamMember**
> void UpdateTeamMember (string teamId, string userId, bool? admin, string permissionSuiteId = null)

Update Member of Team

Updates a member of a team

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateTeamMemberExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi();
            var teamId = teamId_example;  // string | The team id
            var userId = userId_example;  // string | The user id of the member being added to the team.
            var admin = true;  // bool? | Set if the user is an admin of this team.
            var permissionSuiteId = permissionSuiteId_example;  // string | Set if the user is an admin of this team. (optional) 

            try
            {
                // Update Member of Team
                apiInstance.UpdateTeamMember(teamId, userId, admin, permissionSuiteId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.UpdateTeamMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **string**| The team id | 
 **userId** | **string**| The user id of the member being added to the team. | 
 **admin** | **bool?**| Set if the user is an admin of this team. | 
 **permissionSuiteId** | **string**| Set if the user is an admin of this team. | [optional] 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

