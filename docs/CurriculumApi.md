# IO.Swagger.Api.CurriculumApi

All URIs are relative to *https://api.bombbomb.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCurricula**](CurriculumApi.md#getcurricula) | **GET** /curricula/ | Get Curricula
[**GetUserCurriculumWithProgress**](CurriculumApi.md#getusercurriculumwithprogress) | **GET** /curriculum/getForUserWithProgress | Get Detailed For User


<a name="getcurricula"></a>
# **GetCurricula**
> List<Curriculum> GetCurricula (bool? includeProgress = null)

Get Curricula

Get Curricula, optionally with progress included.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCurriculaExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CurriculumApi();
            var includeProgress = true;  // bool? | Whether to return progress with the curriculum. (optional) 

            try
            {
                // Get Curricula
                List&lt;Curriculum&gt; result = apiInstance.GetCurricula(includeProgress);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CurriculumApi.GetCurricula: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **includeProgress** | **bool?**| Whether to return progress with the curriculum. | [optional] 

### Return type

[**List<Curriculum>**](Curriculum.md)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusercurriculumwithprogress"></a>
# **GetUserCurriculumWithProgress**
> List<CurriculumWithProgress> GetUserCurriculumWithProgress ()

Get Detailed For User

Get all curricula for user including progress for each curriculum.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserCurriculumWithProgressExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CurriculumApi();

            try
            {
                // Get Detailed For User
                List&lt;CurriculumWithProgress&gt; result = apiInstance.GetUserCurriculumWithProgress();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CurriculumApi.GetUserCurriculumWithProgress: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<CurriculumWithProgress>**](CurriculumWithProgress.md)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

