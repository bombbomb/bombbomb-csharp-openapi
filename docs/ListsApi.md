# IO.Swagger.Api.ListsApi

All URIs are relative to *https://api.bombbomb.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ClearList**](ListsApi.md#clearlist) | **PUT** /lists/{listId}/clear | Clear Contacts from List
[**CopyListContacts**](ListsApi.md#copylistcontacts) | **POST** /lists/{listId}/copy | Copy All Contacts from a List
[**SuppressAllInList**](ListsApi.md#suppressallinlist) | **PUT** /lists/{listId}/suppress | Suppress All Contacts from List


<a name="clearlist"></a>
# **ClearList**
> void ClearList (string listId)

Clear Contacts from List

Clears all contacts from a list.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ClearListExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ListsApi();
            var listId = listId_example;  // string | The list to be cleared.

            try
            {
                // Clear Contacts from List
                apiInstance.ClearList(listId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListsApi.ClearList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **string**| The list to be cleared. | 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="copylistcontacts"></a>
# **CopyListContacts**
> void CopyListContacts (string fromListId, string listId)

Copy All Contacts from a List

Copy all contacts from a list.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CopyListContactsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ListsApi();
            var fromListId = fromListId_example;  // string | The list to be cleared.
            var listId = listId_example;  // string | The list to be cleared.

            try
            {
                // Copy All Contacts from a List
                apiInstance.CopyListContacts(fromListId, listId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListsApi.CopyListContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fromListId** | **string**| The list to be cleared. | 
 **listId** | **string**| The list to be cleared. | 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="suppressallinlist"></a>
# **SuppressAllInList**
> void SuppressAllInList (string listId)

Suppress All Contacts from List

Suppresses all contacts in a list.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SuppressAllInListExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ListsApi();
            var listId = listId_example;  // string | The list to be cleared.

            try
            {
                // Suppress All Contacts from List
                apiInstance.SuppressAllInList(listId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListsApi.SuppressAllInList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **string**| The list to be cleared. | 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

