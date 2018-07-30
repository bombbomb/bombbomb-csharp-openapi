# IO.Swagger.Api.UsersApi

All URIs are relative to *https://api.bombbomb.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetClientContactInformation**](UsersApi.md#getclientcontactinformation) | **GET** /clients/contact/information | Get client contact information.
[**GetUserProfileInfo**](UsersApi.md#getuserprofileinfo) | **GET** /users/profile/information | Get user profile information.


<a name="getclientcontactinformation"></a>
# **GetClientContactInformation**
> void GetClientContactInformation ()

Get client contact information.

Get the client contact information of the user's account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientContactInformationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();

            try
            {
                // Get client contact information.
                apiInstance.GetClientContactInformation();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetClientContactInformation: " + e.Message );
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

<a name="getuserprofileinfo"></a>
# **GetUserProfileInfo**
> void GetUserProfileInfo ()

Get user profile information.

Get the users profile information.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserProfileInfoExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();

            try
            {
                // Get user profile information.
                apiInstance.GetUserProfileInfo();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserProfileInfo: " + e.Message );
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

