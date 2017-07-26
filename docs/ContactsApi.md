# IO.Swagger.Api.ContactsApi

All URIs are relative to *https://api.bombbomb.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteContacts**](ContactsApi.md#deletecontacts) | **PUT** /contacts/delete | Delete Contacts


<a name="deletecontacts"></a>
# **DeleteContacts**
> void DeleteContacts (string listId)

Delete Contacts

Delete contacts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteContactsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var listId = listId_example;  // string | The list of contacts to be deleted.

            try
            {
                // Delete Contacts
                apiInstance.DeleteContacts(listId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.DeleteContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **string**| The list of contacts to be deleted. | 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

