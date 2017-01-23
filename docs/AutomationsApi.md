# IO.Swagger.Api.AutomationsApi

All URIs are relative to *https://api.bombbomb.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDripDropStats**](AutomationsApi.md#getdripdropstats) | **GET** /automation/{dripId}/dripdrop/{dripDropId}/stats | Get Automation Email Stats
[**GetDripStats**](AutomationsApi.md#getdripstats) | **GET** /automation/{id}/stats | Get Automation Stats


<a name="getdripdropstats"></a>
# **GetDripDropStats**
> void GetDripDropStats (string dripId, string dripDropId)

Get Automation Email Stats

Get Automation Email Stats

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDripDropStatsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutomationsApi();
            var dripId = dripId_example;  // string | The id of the drip
            var dripDropId = dripDropId_example;  // string | The id of the drip drop

            try
            {
                // Get Automation Email Stats
                apiInstance.GetDripDropStats(dripId, dripDropId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationsApi.GetDripDropStats: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dripId** | **string**| The id of the drip | 
 **dripDropId** | **string**| The id of the drip drop | 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdripstats"></a>
# **GetDripStats**
> void GetDripStats (string id)

Get Automation Stats

Get Automation Stats

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDripStatsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutomationsApi();
            var id = id_example;  // string | The id of the automation

            try
            {
                // Get Automation Stats
                apiInstance.GetDripStats(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationsApi.GetDripStats: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the automation | 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

