/* 
 * BombBomb
 *
 * We make it easy to use simple video to build relationships
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
    public interface ITeamsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Creates a Jericho send.
        /// </summary>
        /// <remarks>
        /// Sends email content on behalf of members of a client group. There are two forms this send can take:         Static Email, and Video Prompt. Static emails require only an emailId.         Video Prompts build emails dynamically and require most of the other fields.         You must be an administrator of a Team Account to use this method.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="config">JSON representing a Jericho configuration</param>
        /// <param name="teamId">The ID of the team.</param>
        /// <returns>JerichoConfiguration</returns>
        JerichoConfiguration QueueJerichoSend (JerichoConfiguration config, string teamId);

        /// <summary>
        /// Creates a Jericho send.
        /// </summary>
        /// <remarks>
        /// Sends email content on behalf of members of a client group. There are two forms this send can take:         Static Email, and Video Prompt. Static emails require only an emailId.         Video Prompts build emails dynamically and require most of the other fields.         You must be an administrator of a Team Account to use this method.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="config">JSON representing a Jericho configuration</param>
        /// <param name="teamId">The ID of the team.</param>
        /// <returns>ApiResponse of JerichoConfiguration</returns>
        ApiResponse<JerichoConfiguration> QueueJerichoSendWithHttpInfo (JerichoConfiguration config, string teamId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Creates a Jericho send.
        /// </summary>
        /// <remarks>
        /// Sends email content on behalf of members of a client group. There are two forms this send can take:         Static Email, and Video Prompt. Static emails require only an emailId.         Video Prompts build emails dynamically and require most of the other fields.         You must be an administrator of a Team Account to use this method.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="config">JSON representing a Jericho configuration</param>
        /// <param name="teamId">The ID of the team.</param>
        /// <returns>Task of JerichoConfiguration</returns>
        System.Threading.Tasks.Task<JerichoConfiguration> QueueJerichoSendAsync (JerichoConfiguration config, string teamId);

        /// <summary>
        /// Creates a Jericho send.
        /// </summary>
        /// <remarks>
        /// Sends email content on behalf of members of a client group. There are two forms this send can take:         Static Email, and Video Prompt. Static emails require only an emailId.         Video Prompts build emails dynamically and require most of the other fields.         You must be an administrator of a Team Account to use this method.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="config">JSON representing a Jericho configuration</param>
        /// <param name="teamId">The ID of the team.</param>
        /// <returns>Task of ApiResponse (JerichoConfiguration)</returns>
        System.Threading.Tasks.Task<ApiResponse<JerichoConfiguration>> QueueJerichoSendAsyncWithHttpInfo (JerichoConfiguration config, string teamId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TeamsApi : ITeamsApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TeamsApi(String basePath)
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
        /// Initializes a new instance of the <see cref="TeamsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TeamsApi(Configuration configuration = null)
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
        /// Creates a Jericho send. Sends email content on behalf of members of a client group. There are two forms this send can take:         Static Email, and Video Prompt. Static emails require only an emailId.         Video Prompts build emails dynamically and require most of the other fields.         You must be an administrator of a Team Account to use this method.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="config">JSON representing a Jericho configuration</param>
        /// <param name="teamId">The ID of the team.</param>
        /// <returns>JerichoConfiguration</returns>
        public JerichoConfiguration QueueJerichoSend (JerichoConfiguration config, string teamId)
        {
             ApiResponse<JerichoConfiguration> localVarResponse = QueueJerichoSendWithHttpInfo(config, teamId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Creates a Jericho send. Sends email content on behalf of members of a client group. There are two forms this send can take:         Static Email, and Video Prompt. Static emails require only an emailId.         Video Prompts build emails dynamically and require most of the other fields.         You must be an administrator of a Team Account to use this method.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="config">JSON representing a Jericho configuration</param>
        /// <param name="teamId">The ID of the team.</param>
        /// <returns>ApiResponse of JerichoConfiguration</returns>
        public ApiResponse< JerichoConfiguration > QueueJerichoSendWithHttpInfo (JerichoConfiguration config, string teamId)
        {
            // verify the required parameter 'config' is set
            if (config == null)
                throw new ApiException(400, "Missing required parameter 'config' when calling TeamsApi->QueueJerichoSend");
            // verify the required parameter 'teamId' is set
            if (teamId == null)
                throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsApi->QueueJerichoSend");

            var localVarPath = "/team/{teamId}/jericho";
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
            if (teamId != null) localVarPathParams.Add("teamId", Configuration.ApiClient.ParameterToString(teamId)); // path parameter
            if (config != null && config.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(config); // http body (model) parameter
            }
            else
            {
                localVarPostBody = config; // byte array
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
                Exception exception = ExceptionFactory("QueueJerichoSend", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<JerichoConfiguration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JerichoConfiguration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JerichoConfiguration)));
            
        }

        /// <summary>
        /// Creates a Jericho send. Sends email content on behalf of members of a client group. There are two forms this send can take:         Static Email, and Video Prompt. Static emails require only an emailId.         Video Prompts build emails dynamically and require most of the other fields.         You must be an administrator of a Team Account to use this method.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="config">JSON representing a Jericho configuration</param>
        /// <param name="teamId">The ID of the team.</param>
        /// <returns>Task of JerichoConfiguration</returns>
        public async System.Threading.Tasks.Task<JerichoConfiguration> QueueJerichoSendAsync (JerichoConfiguration config, string teamId)
        {
             ApiResponse<JerichoConfiguration> localVarResponse = await QueueJerichoSendAsyncWithHttpInfo(config, teamId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Creates a Jericho send. Sends email content on behalf of members of a client group. There are two forms this send can take:         Static Email, and Video Prompt. Static emails require only an emailId.         Video Prompts build emails dynamically and require most of the other fields.         You must be an administrator of a Team Account to use this method.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="config">JSON representing a Jericho configuration</param>
        /// <param name="teamId">The ID of the team.</param>
        /// <returns>Task of ApiResponse (JerichoConfiguration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JerichoConfiguration>> QueueJerichoSendAsyncWithHttpInfo (JerichoConfiguration config, string teamId)
        {
            // verify the required parameter 'config' is set
            if (config == null)
                throw new ApiException(400, "Missing required parameter 'config' when calling TeamsApi->QueueJerichoSend");
            // verify the required parameter 'teamId' is set
            if (teamId == null)
                throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsApi->QueueJerichoSend");

            var localVarPath = "/team/{teamId}/jericho";
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
            if (teamId != null) localVarPathParams.Add("teamId", Configuration.ApiClient.ParameterToString(teamId)); // path parameter
            if (config != null && config.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(config); // http body (model) parameter
            }
            else
            {
                localVarPostBody = config; // byte array
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
                Exception exception = ExceptionFactory("QueueJerichoSend", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<JerichoConfiguration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JerichoConfiguration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JerichoConfiguration)));
            
        }

    }
}
