# IO.Swagger.Api.ContactsApi

All URIs are relative to *https://api.bombbomb.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddContactsCSV**](ContactsApi.md#addcontactscsv) | **POST** /contacts/import_csv | Add contacts from a CSV file.
[**AddNewContact**](ContactsApi.md#addnewcontact) | **POST** /contacts/ | Add a contact.
[**AddNewCustomField**](ContactsApi.md#addnewcustomfield) | **POST** /contacts/custom_fields/ | Add custom fields.
[**AddPastedContacts**](ContactsApi.md#addpastedcontacts) | **POST** /contacts/paste | Add pasted contacts.
[**CSVToObject**](ContactsApi.md#csvtoobject) | **POST** /csv-to-object | Format CSV.
[**DeleteContacts**](ContactsApi.md#deletecontacts) | **PUT** /contacts/delete | Delete Contacts
[**GetContactById**](ContactsApi.md#getcontactbyid) | **GET** /contact/{id} | Get Contact Details
[**GetCustomFields**](ContactsApi.md#getcustomfields) | **GET** /contacts/custom_fields/ | Get custom fields.


<a name="addcontactscsv"></a>
# **AddContactsCSV**
> void AddContactsCSV (string mappingData, string listData)

Add contacts from a CSV file.

Add multiple contacts through the upload importer from a CSV file.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddContactsCSVExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var mappingData = mappingData_example;  // string | The info sent for the contacts
            var listData = listData_example;  // string | The info sent with the import for the list

            try
            {
                // Add contacts from a CSV file.
                apiInstance.AddContactsCSV(mappingData, listData);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.AddContactsCSV: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mappingData** | **string**| The info sent for the contacts | 
 **listData** | **string**| The info sent with the import for the list | 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addnewcontact"></a>
# **AddNewContact**
> void AddNewContact (string contactEmail, string contactInfo = null)

Add a contact.

Add a contact to the users list.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddNewContactExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var contactEmail = contactEmail_example;  // string | Email of the new contact we are adding
            var contactInfo = contactInfo_example;  // string | The info sent for this contact (optional) 

            try
            {
                // Add a contact.
                apiInstance.AddNewContact(contactEmail, contactInfo);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.AddNewContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactEmail** | **string**| Email of the new contact we are adding | 
 **contactInfo** | **string**| The info sent for this contact | [optional] 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addnewcustomfield"></a>
# **AddNewCustomField**
> void AddNewCustomField (string fieldName, string fieldType = null)

Add custom fields.

Add a new custom field.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddNewCustomFieldExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var fieldName = fieldName_example;  // string | Custom field name to be added
            var fieldType = fieldType_example;  // string | Custom field type for the field to be added (optional) 

            try
            {
                // Add custom fields.
                apiInstance.AddNewCustomField(fieldName, fieldType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.AddNewCustomField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fieldName** | **string**| Custom field name to be added | 
 **fieldType** | **string**| Custom field type for the field to be added | [optional] 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addpastedcontacts"></a>
# **AddPastedContacts**
> void AddPastedContacts (string contactEmails, string listInfo = null)

Add pasted contacts.

Add the pasted contacts to the users list.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddPastedContactsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var contactEmails = contactEmails_example;  // string | Emails array of the new contacts we are adding
            var listInfo = listInfo_example;  // string | Information about the lists id, recalculations on totals, consent etc (optional) 

            try
            {
                // Add pasted contacts.
                apiInstance.AddPastedContacts(contactEmails, listInfo);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.AddPastedContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactEmails** | **string**| Emails array of the new contacts we are adding | 
 **listInfo** | **string**| Information about the lists id, recalculations on totals, consent etc | [optional] 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="csvtoobject"></a>
# **CSVToObject**
> void CSVToObject (string file)

Format CSV.

Format a CSV file to an object.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CSVToObjectExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var file = file_example;  // string | The CSV file being uploaded

            try
            {
                // Format CSV.
                apiInstance.CSVToObject(file);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.CSVToObject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **string**| The CSV file being uploaded | 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecontacts"></a>
# **DeleteContacts**
> void DeleteContacts (string listId = null, string contactIds = null)

Delete Contacts

Delete all contacts within a list, or provide a comma separated list of contactIds to delete.

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
            var listId = listId_example;  // string | The list of contacts to be deleted. (optional) 
            var contactIds = contactIds_example;  // string | comma separated list of contact ids to delete (optional) 

            try
            {
                // Delete Contacts
                apiInstance.DeleteContacts(listId, contactIds);
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
 **listId** | **string**| The list of contacts to be deleted. | [optional] 
 **contactIds** | **string**| comma separated list of contact ids to delete | [optional] 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontactbyid"></a>
# **GetContactById**
> void GetContactById (string id)

Get Contact Details

Get the contact details

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetContactByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var id = id_example;  // string | Guid for the contact.

            try
            {
                // Get Contact Details
                apiInstance.GetContactById(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.GetContactById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Guid for the contact. | 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomfields"></a>
# **GetCustomFields**
> void GetCustomFields ()

Get custom fields.

Get the current users custom fields.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCustomFieldsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();

            try
            {
                // Get custom fields.
                apiInstance.GetCustomFields();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.GetCustomFields: " + e.Message );
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

