# IO.Swagger.Api.AccountsApi

All URIs are relative to *https://api.bombbomb.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccountDetails**](AccountsApi.md#accountdetails) | **GET** /accounts | Get account details.
[**CreateAccount**](AccountsApi.md#createaccount) | **POST** /accounts | Create Account
[**GetClientStatistics**](AccountsApi.md#getclientstatistics) | **GET** /accounts/stats | Get Client Statistics
[**GetUserCountry**](AccountsApi.md#getusercountry) | **GET** /accounts/{clientId}/country | Gets user country
[**ResetApiKey**](AccountsApi.md#resetapikey) | **PUT** /accounts/apikey | Reset API key
[**SubscriptionPurchaseAllowed**](AccountsApi.md#subscriptionpurchaseallowed) | **GET** /accounts/purchaseable | Check if subscription purchase allowed.
[**UpdateProfileData**](AccountsApi.md#updateprofiledata) | **POST** /account/profile/ | Add profile information.


<a name="accountdetails"></a>
# **AccountDetails**
> void AccountDetails ()

Get account details.

Get the details of the user's account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountDetailsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi();

            try
            {
                // Get account details.
                apiInstance.AccountDetails();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountDetails: " + e.Message );
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

<a name="createaccount"></a>
# **CreateAccount**
> string CreateAccount (string teamId, string firstName, string lastName, string emailAddress, string companyName, string phone, string country = null, string industry = null, string address = null, string city = null, string postalCode = null, bool? preventWelcomeEmail = null)

Create Account

Creates a new BombBomb account. This method is currently only available to paid seat admins.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateAccountExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi();
            var teamId = teamId_example;  // string | The team id
            var firstName = firstName_example;  // string | First name of the user.
            var lastName = lastName_example;  // string | Last name of the user.
            var emailAddress = emailAddress_example;  // string | Email address of the user.
            var companyName = companyName_example;  // string | Company of the user.
            var phone = phone_example;  // string | Phone number of the user.
            var country = country_example;  // string | Country of the user. (optional) 
            var industry = industry_example;  // string | Industry of the user. (optional) 
            var address = address_example;  // string | Street Address of the user. (optional) 
            var city = city_example;  // string | City of the user. (optional) 
            var postalCode = postalCode_example;  // string | Postal/Zip code of the user. (optional) 
            var preventWelcomeEmail = true;  // bool? | prevent an email with login credentials from being sent to the new account. must be set to 'true' (optional) 

            try
            {
                // Create Account
                string result = apiInstance.CreateAccount(teamId, firstName, lastName, emailAddress, companyName, phone, country, industry, address, city, postalCode, preventWelcomeEmail);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.CreateAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **string**| The team id | 
 **firstName** | **string**| First name of the user. | 
 **lastName** | **string**| Last name of the user. | 
 **emailAddress** | **string**| Email address of the user. | 
 **companyName** | **string**| Company of the user. | 
 **phone** | **string**| Phone number of the user. | 
 **country** | **string**| Country of the user. | [optional] 
 **industry** | **string**| Industry of the user. | [optional] 
 **address** | **string**| Street Address of the user. | [optional] 
 **city** | **string**| City of the user. | [optional] 
 **postalCode** | **string**| Postal/Zip code of the user. | [optional] 
 **preventWelcomeEmail** | **bool?**| prevent an email with login credentials from being sent to the new account. must be set to &#39;true&#39; | [optional] 

### Return type

**string**

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclientstatistics"></a>
# **GetClientStatistics**
> void GetClientStatistics (string clientId = null, bool? refresh = null, string statisticValues = null)

Get Client Statistics

Gets general statics for a Client

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientStatisticsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi();
            var clientId = clientId_example;  // string | Client ID of the account to retrieve. Defaults to yourself. (optional) 
            var refresh = true;  // bool? | Boolean for whether data returned should be from cache or not. (optional) 
            var statisticValues = statisticValues_example;  // string | Array of data that should be returned, used exclusively for cacheless data (optional) 

            try
            {
                // Get Client Statistics
                apiInstance.GetClientStatistics(clientId, refresh, statisticValues);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.GetClientStatistics: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| Client ID of the account to retrieve. Defaults to yourself. | [optional] 
 **refresh** | **bool?**| Boolean for whether data returned should be from cache or not. | [optional] 
 **statisticValues** | **string**| Array of data that should be returned, used exclusively for cacheless data | [optional] 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusercountry"></a>
# **GetUserCountry**
> void GetUserCountry ()

Gets user country

Gets the users country

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserCountryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi();

            try
            {
                // Gets user country
                apiInstance.GetUserCountry();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.GetUserCountry: " + e.Message );
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

<a name="resetapikey"></a>
# **ResetApiKey**
> void ResetApiKey ()

Reset API key

Resets the current user's API key and returns the new key

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ResetApiKeyExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi();

            try
            {
                // Reset API key
                apiInstance.ResetApiKey();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.ResetApiKey: " + e.Message );
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

<a name="subscriptionpurchaseallowed"></a>
# **SubscriptionPurchaseAllowed**
> void SubscriptionPurchaseAllowed ()

Check if subscription purchase allowed.

Check whether the user can purchase a subscription.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SubscriptionPurchaseAllowedExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi();

            try
            {
                // Check if subscription purchase allowed.
                apiInstance.SubscriptionPurchaseAllowed();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.SubscriptionPurchaseAllowed: " + e.Message );
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

<a name="updateprofiledata"></a>
# **UpdateProfileData**
> void UpdateProfileData (string profileData = null)

Add profile information.

Add profile information to this users account

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateProfileDataExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi();
            var profileData = profileData_example;  // string | Profile field information for the account (optional) 

            try
            {
                // Add profile information.
                apiInstance.UpdateProfileData(profileData);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.UpdateProfileData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **profileData** | **string**| Profile field information for the account | [optional] 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

