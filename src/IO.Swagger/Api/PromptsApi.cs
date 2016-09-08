/* 
 * BombBomb
 *
 * We make it easy to build relationships using simple videos.
 *
 * OpenAPI spec version: 2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPromptsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Prompts user to send a video
        /// </summary>
        /// <remarks>
        /// Sends the account holder an email prompting them to add a video to a scheduled outgoing message. Recipients, content and timing is all preset for the user.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="prompt">The Video Email Prompt to be created</param>
        /// <returns>VideoEmailPrompt</returns>
        VideoEmailPrompt CreateVideoEmailPrompt (VideoEmailPrompt prompt);

        /// <summary>
        /// Prompts user to send a video
        /// </summary>
        /// <remarks>
        /// Sends the account holder an email prompting them to add a video to a scheduled outgoing message. Recipients, content and timing is all preset for the user.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="prompt">The Video Email Prompt to be created</param>
        /// <returns>ApiResponse of VideoEmailPrompt</returns>
        ApiResponse<VideoEmailPrompt> CreateVideoEmailPromptWithHttpInfo (VideoEmailPrompt prompt);
        /// <summary>
        /// Gets a prompt
        /// </summary>
        /// <remarks>
        /// Gets a prompt
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Id of the prompt</param>
        /// <returns>VideoEmailPrompt</returns>
        VideoEmailPrompt GetVideoEmailPrompt (string id);

        /// <summary>
        /// Gets a prompt
        /// </summary>
        /// <remarks>
        /// Gets a prompt
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Id of the prompt</param>
        /// <returns>ApiResponse of VideoEmailPrompt</returns>
        ApiResponse<VideoEmailPrompt> GetVideoEmailPromptWithHttpInfo (string id);
        /// <summary>
        /// Respond to a prompt
        /// </summary>
        /// <remarks>
        /// Respond to a prompt by either adding a video, sending without a video or cancelling the prompt.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the prompt.</param>
        /// <param name="choice">The users&#39; selection. Can be: WithVideo, WithoutVideo, Cancel</param>
        /// <param name="videoId">The id of the video. (optional)</param>
        /// <returns>VideoEmailPrompt</returns>
        VideoEmailPrompt RespondToVideoEmailPrompt (string id, string choice, string videoId = null);

        /// <summary>
        /// Respond to a prompt
        /// </summary>
        /// <remarks>
        /// Respond to a prompt by either adding a video, sending without a video or cancelling the prompt.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the prompt.</param>
        /// <param name="choice">The users&#39; selection. Can be: WithVideo, WithoutVideo, Cancel</param>
        /// <param name="videoId">The id of the video. (optional)</param>
        /// <returns>ApiResponse of VideoEmailPrompt</returns>
        ApiResponse<VideoEmailPrompt> RespondToVideoEmailPromptWithHttpInfo (string id, string choice, string videoId = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Prompts user to send a video
        /// </summary>
        /// <remarks>
        /// Sends the account holder an email prompting them to add a video to a scheduled outgoing message. Recipients, content and timing is all preset for the user.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="prompt">The Video Email Prompt to be created</param>
        /// <returns>Task of VideoEmailPrompt</returns>
        System.Threading.Tasks.Task<VideoEmailPrompt> CreateVideoEmailPromptAsync (VideoEmailPrompt prompt);

        /// <summary>
        /// Prompts user to send a video
        /// </summary>
        /// <remarks>
        /// Sends the account holder an email prompting them to add a video to a scheduled outgoing message. Recipients, content and timing is all preset for the user.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="prompt">The Video Email Prompt to be created</param>
        /// <returns>Task of ApiResponse (VideoEmailPrompt)</returns>
        System.Threading.Tasks.Task<ApiResponse<VideoEmailPrompt>> CreateVideoEmailPromptAsyncWithHttpInfo (VideoEmailPrompt prompt);
        /// <summary>
        /// Gets a prompt
        /// </summary>
        /// <remarks>
        /// Gets a prompt
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Id of the prompt</param>
        /// <returns>Task of VideoEmailPrompt</returns>
        System.Threading.Tasks.Task<VideoEmailPrompt> GetVideoEmailPromptAsync (string id);

        /// <summary>
        /// Gets a prompt
        /// </summary>
        /// <remarks>
        /// Gets a prompt
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Id of the prompt</param>
        /// <returns>Task of ApiResponse (VideoEmailPrompt)</returns>
        System.Threading.Tasks.Task<ApiResponse<VideoEmailPrompt>> GetVideoEmailPromptAsyncWithHttpInfo (string id);
        /// <summary>
        /// Respond to a prompt
        /// </summary>
        /// <remarks>
        /// Respond to a prompt by either adding a video, sending without a video or cancelling the prompt.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the prompt.</param>
        /// <param name="choice">The users&#39; selection. Can be: WithVideo, WithoutVideo, Cancel</param>
        /// <param name="videoId">The id of the video. (optional)</param>
        /// <returns>Task of VideoEmailPrompt</returns>
        System.Threading.Tasks.Task<VideoEmailPrompt> RespondToVideoEmailPromptAsync (string id, string choice, string videoId = null);

        /// <summary>
        /// Respond to a prompt
        /// </summary>
        /// <remarks>
        /// Respond to a prompt by either adding a video, sending without a video or cancelling the prompt.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the prompt.</param>
        /// <param name="choice">The users&#39; selection. Can be: WithVideo, WithoutVideo, Cancel</param>
        /// <param name="videoId">The id of the video. (optional)</param>
        /// <returns>Task of ApiResponse (VideoEmailPrompt)</returns>
        System.Threading.Tasks.Task<ApiResponse<VideoEmailPrompt>> RespondToVideoEmailPromptAsyncWithHttpInfo (string id, string choice, string videoId = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PromptsApi : IPromptsApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PromptsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PromptsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Prompts user to send a video Sends the account holder an email prompting them to add a video to a scheduled outgoing message. Recipients, content and timing is all preset for the user.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="prompt">The Video Email Prompt to be created</param>
        /// <returns>VideoEmailPrompt</returns>
        public VideoEmailPrompt CreateVideoEmailPrompt (VideoEmailPrompt prompt)
        {
             ApiResponse<VideoEmailPrompt> localVarResponse = CreateVideoEmailPromptWithHttpInfo(prompt);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Prompts user to send a video Sends the account holder an email prompting them to add a video to a scheduled outgoing message. Recipients, content and timing is all preset for the user.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="prompt">The Video Email Prompt to be created</param>
        /// <returns>ApiResponse of VideoEmailPrompt</returns>
        public ApiResponse< VideoEmailPrompt > CreateVideoEmailPromptWithHttpInfo (VideoEmailPrompt prompt)
        {
            // verify the required parameter 'prompt' is set
            if (prompt == null)
                throw new ApiException(400, "Missing required parameter 'prompt' when calling PromptsApi->CreateVideoEmailPrompt");

            var localVarPath = "/prompt";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (prompt != null && prompt.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(prompt); // http body (model) parameter
            }
            else
            {
                localVarPostBody = prompt; // byte array
            }

            // authentication (BBOAuth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateVideoEmailPrompt", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VideoEmailPrompt>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VideoEmailPrompt) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VideoEmailPrompt)));
            
        }

        /// <summary>
        /// Prompts user to send a video Sends the account holder an email prompting them to add a video to a scheduled outgoing message. Recipients, content and timing is all preset for the user.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="prompt">The Video Email Prompt to be created</param>
        /// <returns>Task of VideoEmailPrompt</returns>
        public async System.Threading.Tasks.Task<VideoEmailPrompt> CreateVideoEmailPromptAsync (VideoEmailPrompt prompt)
        {
             ApiResponse<VideoEmailPrompt> localVarResponse = await CreateVideoEmailPromptAsyncWithHttpInfo(prompt);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Prompts user to send a video Sends the account holder an email prompting them to add a video to a scheduled outgoing message. Recipients, content and timing is all preset for the user.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="prompt">The Video Email Prompt to be created</param>
        /// <returns>Task of ApiResponse (VideoEmailPrompt)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VideoEmailPrompt>> CreateVideoEmailPromptAsyncWithHttpInfo (VideoEmailPrompt prompt)
        {
            // verify the required parameter 'prompt' is set
            if (prompt == null)
                throw new ApiException(400, "Missing required parameter 'prompt' when calling PromptsApi->CreateVideoEmailPrompt");

            var localVarPath = "/prompt";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (prompt != null && prompt.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(prompt); // http body (model) parameter
            }
            else
            {
                localVarPostBody = prompt; // byte array
            }

            // authentication (BBOAuth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateVideoEmailPrompt", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VideoEmailPrompt>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VideoEmailPrompt) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VideoEmailPrompt)));
            
        }

        /// <summary>
        /// Gets a prompt Gets a prompt
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Id of the prompt</param>
        /// <returns>VideoEmailPrompt</returns>
        public VideoEmailPrompt GetVideoEmailPrompt (string id)
        {
             ApiResponse<VideoEmailPrompt> localVarResponse = GetVideoEmailPromptWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets a prompt Gets a prompt
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Id of the prompt</param>
        /// <returns>ApiResponse of VideoEmailPrompt</returns>
        public ApiResponse< VideoEmailPrompt > GetVideoEmailPromptWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PromptsApi->GetVideoEmailPrompt");

            var localVarPath = "/prompt/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

            // authentication (BBOAuth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetVideoEmailPrompt", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VideoEmailPrompt>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VideoEmailPrompt) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VideoEmailPrompt)));
            
        }

        /// <summary>
        /// Gets a prompt Gets a prompt
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Id of the prompt</param>
        /// <returns>Task of VideoEmailPrompt</returns>
        public async System.Threading.Tasks.Task<VideoEmailPrompt> GetVideoEmailPromptAsync (string id)
        {
             ApiResponse<VideoEmailPrompt> localVarResponse = await GetVideoEmailPromptAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets a prompt Gets a prompt
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Id of the prompt</param>
        /// <returns>Task of ApiResponse (VideoEmailPrompt)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VideoEmailPrompt>> GetVideoEmailPromptAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PromptsApi->GetVideoEmailPrompt");

            var localVarPath = "/prompt/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

            // authentication (BBOAuth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetVideoEmailPrompt", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VideoEmailPrompt>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VideoEmailPrompt) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VideoEmailPrompt)));
            
        }

        /// <summary>
        /// Respond to a prompt Respond to a prompt by either adding a video, sending without a video or cancelling the prompt.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the prompt.</param>
        /// <param name="choice">The users&#39; selection. Can be: WithVideo, WithoutVideo, Cancel</param>
        /// <param name="videoId">The id of the video. (optional)</param>
        /// <returns>VideoEmailPrompt</returns>
        public VideoEmailPrompt RespondToVideoEmailPrompt (string id, string choice, string videoId = null)
        {
             ApiResponse<VideoEmailPrompt> localVarResponse = RespondToVideoEmailPromptWithHttpInfo(id, choice, videoId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Respond to a prompt Respond to a prompt by either adding a video, sending without a video or cancelling the prompt.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the prompt.</param>
        /// <param name="choice">The users&#39; selection. Can be: WithVideo, WithoutVideo, Cancel</param>
        /// <param name="videoId">The id of the video. (optional)</param>
        /// <returns>ApiResponse of VideoEmailPrompt</returns>
        public ApiResponse< VideoEmailPrompt > RespondToVideoEmailPromptWithHttpInfo (string id, string choice, string videoId = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PromptsApi->RespondToVideoEmailPrompt");
            // verify the required parameter 'choice' is set
            if (choice == null)
                throw new ApiException(400, "Missing required parameter 'choice' when calling PromptsApi->RespondToVideoEmailPrompt");

            var localVarPath = "/prompt/{id}/response";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (videoId != null) localVarFormParams.Add("videoId", Configuration.ApiClient.ParameterToString(videoId)); // form parameter
            if (choice != null) localVarFormParams.Add("choice", Configuration.ApiClient.ParameterToString(choice)); // form parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RespondToVideoEmailPrompt", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VideoEmailPrompt>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VideoEmailPrompt) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VideoEmailPrompt)));
            
        }

        /// <summary>
        /// Respond to a prompt Respond to a prompt by either adding a video, sending without a video or cancelling the prompt.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the prompt.</param>
        /// <param name="choice">The users&#39; selection. Can be: WithVideo, WithoutVideo, Cancel</param>
        /// <param name="videoId">The id of the video. (optional)</param>
        /// <returns>Task of VideoEmailPrompt</returns>
        public async System.Threading.Tasks.Task<VideoEmailPrompt> RespondToVideoEmailPromptAsync (string id, string choice, string videoId = null)
        {
             ApiResponse<VideoEmailPrompt> localVarResponse = await RespondToVideoEmailPromptAsyncWithHttpInfo(id, choice, videoId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Respond to a prompt Respond to a prompt by either adding a video, sending without a video or cancelling the prompt.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the prompt.</param>
        /// <param name="choice">The users&#39; selection. Can be: WithVideo, WithoutVideo, Cancel</param>
        /// <param name="videoId">The id of the video. (optional)</param>
        /// <returns>Task of ApiResponse (VideoEmailPrompt)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VideoEmailPrompt>> RespondToVideoEmailPromptAsyncWithHttpInfo (string id, string choice, string videoId = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PromptsApi->RespondToVideoEmailPrompt");
            // verify the required parameter 'choice' is set
            if (choice == null)
                throw new ApiException(400, "Missing required parameter 'choice' when calling PromptsApi->RespondToVideoEmailPrompt");

            var localVarPath = "/prompt/{id}/response";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (videoId != null) localVarFormParams.Add("videoId", Configuration.ApiClient.ParameterToString(videoId)); // form parameter
            if (choice != null) localVarFormParams.Add("choice", Configuration.ApiClient.ParameterToString(choice)); // form parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RespondToVideoEmailPrompt", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VideoEmailPrompt>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VideoEmailPrompt) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VideoEmailPrompt)));
            
        }

    }
}