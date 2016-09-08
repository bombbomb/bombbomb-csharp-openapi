# IO.Swagger - the C# library for the BombBomb

We make it easy to build relationships using simple videos.

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 2.0.20679
- SDK version: 1.0.0
- Build date: 2016-09-08T21:59:20.076Z
- Build package: class io.swagger.codegen.languages.CSharpClientCodegen

## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

The DLLs included in the package may not be the latest version. We recommned using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.Swagger.Api;
using IO.Swagger.Client;
using Model;
```

## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PromptsApi();
            var prompt = new VideoEmailPrompt(); // VideoEmailPrompt | The Video Email Prompt to be created

            try
            {
                // Prompts user to send a video
                VideoEmailPrompt result = apiInstance.CreateVideoEmailPrompt(prompt);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PromptsApi.CreateVideoEmailPrompt: " + e.Message );
            }
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.bombbomb.com/v2*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*PromptsApi* | [**CreateVideoEmailPrompt**](docs/PromptsApi.md#createvideoemailprompt) | **POST** /prompt | Prompts user to send a video
*PromptsApi* | [**GetVideoEmailPrompt**](docs/PromptsApi.md#getvideoemailprompt) | **GET** /prompt/{id} | Gets a prompt
*PromptsApi* | [**RespondToVideoEmailPrompt**](docs/PromptsApi.md#respondtovideoemailprompt) | **POST** /prompt/{id}/response | Respond to a prompt
*TeamsApi* | [**CancelJerichoSend**](docs/TeamsApi.md#canceljerichosend) | **DELETE** /team/{teamId}/jericho/{jerichoId} | Cancel a Jericho Send
*TeamsApi* | [**GetClientGroupAssets**](docs/TeamsApi.md#getclientgroupassets) | **GET** /team/assets/ | Lists team assets
*TeamsApi* | [**GetJerichoSends**](docs/TeamsApi.md#getjerichosends) | **GET** /team/{teamId}/jericho | List Jericho Sends
*TeamsApi* | [**GetJerichoStats**](docs/TeamsApi.md#getjerichostats) | **GET** /team/{teamId}/jericho/{jerichoId}/performance | Gets Jericho performance statistics
*TeamsApi* | [**QueueJerichoSend**](docs/TeamsApi.md#queuejerichosend) | **POST** /team/{teamId}/jericho | Creates a Jericho send.
*UtilitiesApi* | [**CreateOAuthClient**](docs/UtilitiesApi.md#createoauthclient) | **POST** /oauthclient | Create an OAuth Client
*UtilitiesApi* | [**DeleteOAuthClient**](docs/UtilitiesApi.md#deleteoauthclient) | **DELETE** /oauthclient/{id} | Delete an OAuth Client
*UtilitiesApi* | [**GetOAuthClients**](docs/UtilitiesApi.md#getoauthclients) | **GET** /oauthclient | Lists OAuth Clients
*UtilitiesApi* | [**GetSpec**](docs/UtilitiesApi.md#getspec) | **GET** /spec | Describes this api
*WebhooksApi* | [**AddWebHook**](docs/WebhooksApi.md#addwebhook) | **POST** /webhook | Add Webhook
*WebhooksApi* | [**DeleteWebHook**](docs/WebhooksApi.md#deletewebhook) | **DELETE** /webhook/{hookId} | Deletes Webhook
*WebhooksApi* | [**GetWebHooks**](docs/WebhooksApi.md#getwebhooks) | **GET** /webhook/ | Lists Webhooks
*WebhooksApi* | [**SendWebhookExample**](docs/WebhooksApi.md#sendwebhookexample) | **POST** /webhook/test | Sends test Webhook


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.BBWebHook](docs/BBWebHook.md)
 - [Model.InlineResponse200](docs/InlineResponse200.md)
 - [Model.InlineResponse200Items](docs/InlineResponse200Items.md)
 - [Model.JerichoConfiguration](docs/JerichoConfiguration.md)
 - [Model.JerichoPerformance](docs/JerichoPerformance.md)
 - [Model.ModelString](docs/ModelString.md)
 - [Model.OAuthClient](docs/OAuthClient.md)
 - [Model.VideoEmailPrompt](docs/VideoEmailPrompt.md)


## Documentation for Authorization

### BBOAuth2

- **Type**: OAuth
- **Flow**: implicit
- **Authorization URL**: https://app.bombbomb.com/auth/authorize
- **Scopes**: 
  - all:manage: Manage All
  - all:read: Read All
  - email:manage: Manage Email
  - email:read: Read Email
  - video:manage: Manage Video
  - video:read: Read Video
  - contact:manage: Manage Contact
  - contact:read: Read Contact
  - automation:manage: Manage Automation
  - automation:read: Read Automation
  - form:manage: Manage Form
  - form:read: Read Form
  - team:manage: Manage Team
  - team:read: Read Team
  - settings:manage: Manage Settings

