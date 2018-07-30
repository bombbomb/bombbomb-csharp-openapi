# IO.Swagger.Api.FilesApi

All URIs are relative to *https://api.bombbomb.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DocHostDelete**](FilesApi.md#dochostdelete) | **DELETE** /files/{docId} | Delete file
[**DocHostGet**](FilesApi.md#dochostget) | **GET** /files/{docId} | Get file
[**DocHostList**](FilesApi.md#dochostlist) | **GET** /files | List all files
[**DocHostUploadV2**](FilesApi.md#dochostuploadv2) | **POST** /files | Upload a file
[**GetHostedImagesPaged**](FilesApi.md#gethostedimagespaged) | **GET** /files/images/paged | Get paged hosted images


<a name="dochostdelete"></a>
# **DocHostDelete**
> void DocHostDelete (string docId)

Delete file

Deletes a users file

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DocHostDeleteExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FilesApi();
            var docId = docId_example;  // string | Id of document

            try
            {
                // Delete file
                apiInstance.DocHostDelete(docId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FilesApi.DocHostDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docId** | **string**| Id of document | 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dochostget"></a>
# **DocHostGet**
> HostedDoc DocHostGet (string docId)

Get file

Get a single file by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DocHostGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FilesApi();
            var docId = docId_example;  // string | Id of document

            try
            {
                // Get file
                HostedDoc result = apiInstance.DocHostGet(docId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FilesApi.DocHostGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docId** | **string**| Id of document | 

### Return type

[**HostedDoc**](HostedDoc.md)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dochostlist"></a>
# **DocHostList**
> List<HostedDoc> DocHostList ()

List all files

List all uploaded user files

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DocHostListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FilesApi();

            try
            {
                // List all files
                List&lt;HostedDoc&gt; result = apiInstance.DocHostList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FilesApi.DocHostList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<HostedDoc>**](HostedDoc.md)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dochostuploadv2"></a>
# **DocHostUploadV2**
> List<HostedDoc> DocHostUploadV2 (string file)

Upload a file

Upload a new file

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DocHostUploadV2Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FilesApi();
            var file = file_example;  // string | The file being uploaded

            try
            {
                // Upload a file
                List&lt;HostedDoc&gt; result = apiInstance.DocHostUploadV2(file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FilesApi.DocHostUploadV2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **string**| The file being uploaded | 

### Return type

[**List<HostedDoc>**](HostedDoc.md)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethostedimagespaged"></a>
# **GetHostedImagesPaged**
> void GetHostedImagesPaged (string pageSize, string page, string search = null)

Get paged hosted images

Get a specific page of uploaded images available to the user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetHostedImagesPagedExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FilesApi();
            var pageSize = pageSize_example;  // string | The number of items to retrieve in a single db query.
            var page = page_example;  // string | Zero-based index of the page of data to retrieve from the db.
            var search = search_example;  // string | Filter results with names that match the search term. (optional) 

            try
            {
                // Get paged hosted images
                apiInstance.GetHostedImagesPaged(pageSize, page, search);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FilesApi.GetHostedImagesPaged: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pageSize** | **string**| The number of items to retrieve in a single db query. | 
 **page** | **string**| Zero-based index of the page of data to retrieve from the db. | 
 **search** | **string**| Filter results with names that match the search term. | [optional] 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

