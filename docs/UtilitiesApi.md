# IO.Swagger.Api.UtilitiesApi

All URIs are relative to *https://api.bombbomb.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateOAuthClient**](UtilitiesApi.md#createoauthclient) | **POST** /oauthclient | Create an OAuth Client
[**DeleteOAuthClient**](UtilitiesApi.md#deleteoauthclient) | **DELETE** /oauthclient/{id} | Delete an OAuth Client
[**GetOAuthClients**](UtilitiesApi.md#getoauthclients) | **GET** /oauthclient | Lists OAuth Clients
[**GetSpec**](UtilitiesApi.md#getspec) | **GET** /spec | Describes this api


<a name="createoauthclient"></a>
# **CreateOAuthClient**
> OAuthClient CreateOAuthClient (string name, string redirectUri)

Create an OAuth Client

Creates an OAuth Client managed by the user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateOAuthClientExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UtilitiesApi();
            var name = name_example;  // string | The name of the OAuth client. e.g. MyCrm DEV, or MyCrm PROD
            var redirectUri = redirectUri_example;  // string | The URI to direct the client to after logging in.

            try
            {
                // Create an OAuth Client
                OAuthClient result = apiInstance.CreateOAuthClient(name, redirectUri);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilitiesApi.CreateOAuthClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the OAuth client. e.g. MyCrm DEV, or MyCrm PROD | 
 **redirectUri** | **string**| The URI to direct the client to after logging in. | 

### Return type

[**OAuthClient**](OAuthClient.md)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteoauthclient"></a>
# **DeleteOAuthClient**
> void DeleteOAuthClient (string id)

Delete an OAuth Client

Deletes an OAuth Client managed by the user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteOAuthClientExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UtilitiesApi();
            var id = id_example;  // string | The id of the OAuth Client

            try
            {
                // Delete an OAuth Client
                apiInstance.DeleteOAuthClient(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilitiesApi.DeleteOAuthClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the OAuth Client | 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoauthclients"></a>
# **GetOAuthClients**
> List<OAuthClient> GetOAuthClients ()

Lists OAuth Clients

Enumerates OAuth Clients managed by the user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOAuthClientsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UtilitiesApi();

            try
            {
                // Lists OAuth Clients
                List&lt;OAuthClient&gt; result = apiInstance.GetOAuthClients();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilitiesApi.GetOAuthClients: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<OAuthClient>**](OAuthClient.md)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getspec"></a>
# **GetSpec**
> void GetSpec ()

Describes this api

Describes methods available through the API.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSpecExample
    {
        public void main()
        {
            var apiInstance = new UtilitiesApi();

            try
            {
                // Describes this api
                apiInstance.GetSpec();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilitiesApi.GetSpec: " + e.Message );
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

