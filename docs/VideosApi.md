# IO.Swagger.Api.VideosApi

All URIs are relative to *https://api.bombbomb.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetVideoEncodingStatus**](VideosApi.md#getvideoencodingstatus) | **GET** /videos/{videoId}/status | Video Encoding Status
[**GetVideoRecorder**](VideosApi.md#getvideorecorder) | **GET** /videos/live/getRecorder | Get Live Video Recorder HTML
[**MarkLiveRecordingComplete**](VideosApi.md#markliverecordingcomplete) | **POST** /videos/live/markComplete | Completes a live recording
[**SignUpload**](VideosApi.md#signupload) | **POST** /video/signedUpload | Generate Signed Url
[**UpdateVideoThumbnailV2**](VideosApi.md#updatevideothumbnailv2) | **PUT** /videos/thumbnail | Upload thumbnail


<a name="getvideoencodingstatus"></a>
# **GetVideoEncodingStatus**
> VideoEncodingStatusResponse GetVideoEncodingStatus (string videoId)

Video Encoding Status

Get information about the current state of encoding for a given video id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetVideoEncodingStatusExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosApi();
            var videoId = videoId_example;  // string | The video's id.

            try
            {
                // Video Encoding Status
                VideoEncodingStatusResponse result = apiInstance.GetVideoEncodingStatus(videoId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VideosApi.GetVideoEncodingStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **string**| The video&#39;s id. | 

### Return type

[**VideoEncodingStatusResponse**](VideoEncodingStatusResponse.md)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvideorecorder"></a>
# **GetVideoRecorder**
> VideoRecorderMethodResponse GetVideoRecorder (int? width = null, string videoId = null)

Get Live Video Recorder HTML

Returns an object with a number of properties to help you put a video recorder on your site.         This is to be used in conjunction with the VideoRecordedLive call one the user has confirmed in your UI that         the video is how they want it.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetVideoRecorderExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosApi();
            var width = 56;  // int? | The width of the recorder to present. (optional) 
            var videoId = videoId_example;  // string | The id of the video to record (optional) 

            try
            {
                // Get Live Video Recorder HTML
                VideoRecorderMethodResponse result = apiInstance.GetVideoRecorder(width, videoId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VideosApi.GetVideoRecorder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **width** | **int?**| The width of the recorder to present. | [optional] 
 **videoId** | **string**| The id of the video to record | [optional] 

### Return type

[**VideoRecorderMethodResponse**](VideoRecorderMethodResponse.md)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="markliverecordingcomplete"></a>
# **MarkLiveRecordingComplete**
> VideoPublicRepresentation MarkLiveRecordingComplete (string videoId, string filename, string title)

Completes a live recording

Used in conjunction with the live recorder method to mark a video recording as complete.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MarkLiveRecordingCompleteExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosApi();
            var videoId = videoId_example;  // string | The id of the video to mark as done.
            var filename = filename_example;  // string | The filename that was chosen as the final video.
            var title = title_example;  // string | The title to give the video

            try
            {
                // Completes a live recording
                VideoPublicRepresentation result = apiInstance.MarkLiveRecordingComplete(videoId, filename, title);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VideosApi.MarkLiveRecordingComplete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **string**| The id of the video to mark as done. | 
 **filename** | **string**| The filename that was chosen as the final video. | 
 **title** | **string**| The title to give the video | 

### Return type

[**VideoPublicRepresentation**](VideoPublicRepresentation.md)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signupload"></a>
# **SignUpload**
> string SignUpload (SignUploadRequest policy, bool? v4 = null)

Generate Signed Url

Generates a signed url to be used for video uploads.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SignUploadExample
    {
        public void main()
        {
            var apiInstance = new VideosApi();
            var policy = new SignUploadRequest(); // SignUploadRequest | The policy to sign
            var v4 = true;  // bool? | Whether to do v4 signing (optional) 

            try
            {
                // Generate Signed Url
                string result = apiInstance.SignUpload(policy, v4);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VideosApi.SignUpload: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **policy** | [**SignUploadRequest**](SignUploadRequest.md)| The policy to sign | 
 **v4** | **bool?**| Whether to do v4 signing | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatevideothumbnailv2"></a>
# **UpdateVideoThumbnailV2**
> void UpdateVideoThumbnailV2 (string videoId, string thumbnail, bool? custom = null)

Upload thumbnail

Upload a new video thumbnail

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateVideoThumbnailV2Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: BBOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosApi();
            var videoId = videoId_example;  // string | The id of the video
            var thumbnail = thumbnail_example;  // string | The thumbnail being uploaded
            var custom = true;  // bool? | The default email to use. (optional) 

            try
            {
                // Upload thumbnail
                apiInstance.UpdateVideoThumbnailV2(videoId, thumbnail, custom);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VideosApi.UpdateVideoThumbnailV2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **string**| The id of the video | 
 **thumbnail** | **string**| The thumbnail being uploaded | 
 **custom** | **bool?**| The default email to use. | [optional] 

### Return type

void (empty response body)

### Authorization

[BBOAuth2](../README.md#BBOAuth2)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

