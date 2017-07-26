# IO.Swagger.Api.SocialsApi

All URIs are relative to *https://api.bombbomb.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSocialArticleProperties**](SocialsApi.md#getsocialarticleproperties) | **GET** /socials/properties | Gets the social email properties
[**GetSocialAutoShares**](SocialsApi.md#getsocialautoshares) | **GET** /socials/shares | Gets the auto shares from the client group assoc id
[**GetSocialPermissions**](SocialsApi.md#getsocialpermissions) | **GET** /socials/permissions | Get permissions for social integration
[**GetSocialStatus**](SocialsApi.md#getsocialstatus) | **GET** /socials/states | Gets the social state
[**UpdateSocialAutoShares**](SocialsApi.md#updatesocialautoshares) | **PUT** /socials/shares | Gets the auto shares from the client group assoc id
[**UpdateSocialMessage**](SocialsApi.md#updatesocialmessage) | **PUT** /socials/message | Sets the users social message to what they typed in
[**UpdateSocialStatus**](SocialsApi.md#updatesocialstatus) | **PUT** /socials/state | Updates the social state for the object


<a name="getsocialarticleproperties"></a>
# **GetSocialArticleProperties**
> void GetSocialArticleProperties (string jerichoId, string emailId, string originatorId)

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
            var jerichoId = jerichoId_example;  // string | associated jericho Id
            var emailId = emailId_example;  // string | This is the email Id for the email url
            var originatorId = originatorId_example;  // string | This is the originator Id

            try
            {
                // Gets the social email properties
                apiInstance.GetSocialArticleProperties(jerichoId, emailId, originatorId);
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
 **jerichoId** | **string**| associated jericho Id | 
 **emailId** | **string**| This is the email Id for the email url | 
 **originatorId** | **string**| This is the originator Id | 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsocialautoshares"></a>
# **GetSocialAutoShares**
> void GetSocialAutoShares (string clientGroupId)

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
    public class GetSocialAutoSharesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialsApi();
            var clientGroupId = clientGroupId_example;  // string | ID of the client group association

            try
            {
                // Gets the auto shares from the client group assoc id
                apiInstance.GetSocialAutoShares(clientGroupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialsApi.GetSocialAutoShares: " + e.Message );
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

<a name="getsocialpermissions"></a>
# **GetSocialPermissions**
> void GetSocialPermissions (string socialType)

Get permissions for social integration

Get permissions for social integration and has redirect for user to login

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSocialPermissionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialsApi();
            var socialType = socialType_example;  // string | Type of social integration

            try
            {
                // Get permissions for social integration
                apiInstance.GetSocialPermissions(socialType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialsApi.GetSocialPermissions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **socialType** | **string**| Type of social integration | 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsocialstatus"></a>
# **GetSocialStatus**
> void GetSocialStatus (string originatorId)

Gets the social state

Gets the social state

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSocialStatusExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialsApi();
            var originatorId = originatorId_example;  // string | associated originatorId

            try
            {
                // Gets the social state
                apiInstance.GetSocialStatus(originatorId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialsApi.GetSocialStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **originatorId** | **string**| associated originatorId | 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesocialautoshares"></a>
# **UpdateSocialAutoShares**
> void UpdateSocialAutoShares (string autoShare, string clientGroupId)

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
    public class UpdateSocialAutoSharesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialsApi();
            var autoShare = autoShare_example;  // string | The social share that will auto share to
            var clientGroupId = clientGroupId_example;  // string | ID of the client group association

            try
            {
                // Gets the auto shares from the client group assoc id
                apiInstance.UpdateSocialAutoShares(autoShare, clientGroupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialsApi.UpdateSocialAutoShares: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **autoShare** | **string**| The social share that will auto share to | 
 **clientGroupId** | **string**| ID of the client group association | 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesocialmessage"></a>
# **UpdateSocialMessage**
> void UpdateSocialMessage (string message, string originatorId)

Sets the users social message to what they typed in

Sets the users social message to what they typed in

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateSocialMessageExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialsApi();
            var message = message_example;  // string | The social message the user typed in
            var originatorId = originatorId_example;  // string | The parent id tied to the social share

            try
            {
                // Sets the users social message to what they typed in
                apiInstance.UpdateSocialMessage(message, originatorId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialsApi.UpdateSocialMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **message** | **string**| The social message the user typed in | 
 **originatorId** | **string**| The parent id tied to the social share | 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesocialstatus"></a>
# **UpdateSocialStatus**
> void UpdateSocialStatus (string state, string originatorId)

Updates the social state for the object

Updates the social state for the object

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateSocialStatusExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialsApi();
            var state = state_example;  // string | The state to set to
            var originatorId = originatorId_example;  // string | The parent id tied to the social share

            try
            {
                // Updates the social state for the object
                apiInstance.UpdateSocialStatus(state, originatorId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialsApi.UpdateSocialStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **state** | **string**| The state to set to | 
 **originatorId** | **string**| The parent id tied to the social share | 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

