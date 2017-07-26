# IO.Swagger.Api.AccountsApi

All URIs are relative to *https://api.bombbomb.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccountDetails**](AccountsApi.md#accountdetails) | **GET** /accounts | Get account details.
[**CreateAccount**](AccountsApi.md#createaccount) | **POST** /accounts | Create Account
[**SubscriptionPurchaseAllowed**](AccountsApi.md#subscriptionpurchaseallowed) | **GET** /accounts/purchaseable | Check if subscription purchase allowed.


<a name="accountdetails"></a>
# **AccountDetails**
> void AccountDetails (string email = null, string pw = null, string apiKey = null)

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
            
            var apiInstance = new AccountsApi();
            var email = email_example;  // string | Your login email address (optional) 
            var pw = pw_example;  // string | Your password (optional) 
            var apiKey = apiKey_example;  // string | Your Api Key (optional) 

            try
            {
                // Get account details.
                apiInstance.AccountDetails(email, pw, apiKey);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| Your login email address | [optional] 
 **pw** | **string**| Your password | [optional] 
 **apiKey** | **string**| Your Api Key | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createaccount"></a>
# **CreateAccount**
> string CreateAccount (string teamId, string firstName, string lastName, string emailAddress, string companyName, string phone, string country = null, string industry = null, string address = null, string city = null, string postalCode = null)

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

            try
            {
                // Create Account
                string result = apiInstance.CreateAccount(teamId, firstName, lastName, emailAddress, companyName, phone, country, industry, address, city, postalCode);
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

### Return type

**string**

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptionpurchaseallowed"></a>
# **SubscriptionPurchaseAllowed**
> void SubscriptionPurchaseAllowed (string email = null, string pw = null, string apiKey = null)

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
            
            var apiInstance = new AccountsApi();
            var email = email_example;  // string | Your login email address (optional) 
            var pw = pw_example;  // string | Your password (optional) 
            var apiKey = apiKey_example;  // string | Your Api Key (optional) 

            try
            {
                // Check if subscription purchase allowed.
                apiInstance.SubscriptionPurchaseAllowed(email, pw, apiKey);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| Your login email address | [optional] 
 **pw** | **string**| Your password | [optional] 
 **apiKey** | **string**| Your Api Key | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

