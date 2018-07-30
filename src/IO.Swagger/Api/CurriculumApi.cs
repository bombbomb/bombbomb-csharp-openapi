/* 
 * BombBomb
 *
 * We make it easy to build relationships using simple videos.
 *
 * OpenAPI spec version: 2.0.831
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
    public interface ICurriculumApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get Curricula
        /// </summary>
        /// <remarks>
        /// Get Curricula, optionally with progress included.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeProgress">Whether to return progress with the curriculum. (optional)</param>
        /// <returns>List&lt;Curriculum&gt;</returns>
        List<Curriculum> GetCurricula (bool? includeProgress = null);

        /// <summary>
        /// Get Curricula
        /// </summary>
        /// <remarks>
        /// Get Curricula, optionally with progress included.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeProgress">Whether to return progress with the curriculum. (optional)</param>
        /// <returns>ApiResponse of List&lt;Curriculum&gt;</returns>
        ApiResponse<List<Curriculum>> GetCurriculaWithHttpInfo (bool? includeProgress = null);
        /// <summary>
        /// Get Detailed For User
        /// </summary>
        /// <remarks>
        /// Get all curricula for user including progress for each curriculum.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;CurriculumWithProgress&gt;</returns>
        List<CurriculumWithProgress> GetUserCurriculumWithProgress ();

        /// <summary>
        /// Get Detailed For User
        /// </summary>
        /// <remarks>
        /// Get all curricula for user including progress for each curriculum.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;CurriculumWithProgress&gt;</returns>
        ApiResponse<List<CurriculumWithProgress>> GetUserCurriculumWithProgressWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get Curricula
        /// </summary>
        /// <remarks>
        /// Get Curricula, optionally with progress included.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeProgress">Whether to return progress with the curriculum. (optional)</param>
        /// <returns>Task of List&lt;Curriculum&gt;</returns>
        System.Threading.Tasks.Task<List<Curriculum>> GetCurriculaAsync (bool? includeProgress = null);

        /// <summary>
        /// Get Curricula
        /// </summary>
        /// <remarks>
        /// Get Curricula, optionally with progress included.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeProgress">Whether to return progress with the curriculum. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Curriculum&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Curriculum>>> GetCurriculaAsyncWithHttpInfo (bool? includeProgress = null);
        /// <summary>
        /// Get Detailed For User
        /// </summary>
        /// <remarks>
        /// Get all curricula for user including progress for each curriculum.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;CurriculumWithProgress&gt;</returns>
        System.Threading.Tasks.Task<List<CurriculumWithProgress>> GetUserCurriculumWithProgressAsync ();

        /// <summary>
        /// Get Detailed For User
        /// </summary>
        /// <remarks>
        /// Get all curricula for user including progress for each curriculum.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;CurriculumWithProgress&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<CurriculumWithProgress>>> GetUserCurriculumWithProgressAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CurriculumApi : ICurriculumApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CurriculumApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CurriculumApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurriculumApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CurriculumApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
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
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
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
        /// Get Curricula Get Curricula, optionally with progress included.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeProgress">Whether to return progress with the curriculum. (optional)</param>
        /// <returns>List&lt;Curriculum&gt;</returns>
        public List<Curriculum> GetCurricula (bool? includeProgress = null)
        {
             ApiResponse<List<Curriculum>> localVarResponse = GetCurriculaWithHttpInfo(includeProgress);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Curricula Get Curricula, optionally with progress included.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeProgress">Whether to return progress with the curriculum. (optional)</param>
        /// <returns>ApiResponse of List&lt;Curriculum&gt;</returns>
        public ApiResponse< List<Curriculum> > GetCurriculaWithHttpInfo (bool? includeProgress = null)
        {

            var localVarPath = "/curricula/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (includeProgress != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "includeProgress", includeProgress)); // query parameter

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
                Exception exception = ExceptionFactory("GetCurricula", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Curriculum>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Curriculum>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Curriculum>)));
        }

        /// <summary>
        /// Get Curricula Get Curricula, optionally with progress included.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeProgress">Whether to return progress with the curriculum. (optional)</param>
        /// <returns>Task of List&lt;Curriculum&gt;</returns>
        public async System.Threading.Tasks.Task<List<Curriculum>> GetCurriculaAsync (bool? includeProgress = null)
        {
             ApiResponse<List<Curriculum>> localVarResponse = await GetCurriculaAsyncWithHttpInfo(includeProgress);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Curricula Get Curricula, optionally with progress included.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeProgress">Whether to return progress with the curriculum. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Curriculum&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Curriculum>>> GetCurriculaAsyncWithHttpInfo (bool? includeProgress = null)
        {

            var localVarPath = "/curricula/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (includeProgress != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "includeProgress", includeProgress)); // query parameter

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
                Exception exception = ExceptionFactory("GetCurricula", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Curriculum>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Curriculum>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Curriculum>)));
        }

        /// <summary>
        /// Get Detailed For User Get all curricula for user including progress for each curriculum.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;CurriculumWithProgress&gt;</returns>
        public List<CurriculumWithProgress> GetUserCurriculumWithProgress ()
        {
             ApiResponse<List<CurriculumWithProgress>> localVarResponse = GetUserCurriculumWithProgressWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Detailed For User Get all curricula for user including progress for each curriculum.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;CurriculumWithProgress&gt;</returns>
        public ApiResponse< List<CurriculumWithProgress> > GetUserCurriculumWithProgressWithHttpInfo ()
        {

            var localVarPath = "/curriculum/getForUserWithProgress";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


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
                Exception exception = ExceptionFactory("GetUserCurriculumWithProgress", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<CurriculumWithProgress>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CurriculumWithProgress>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CurriculumWithProgress>)));
        }

        /// <summary>
        /// Get Detailed For User Get all curricula for user including progress for each curriculum.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;CurriculumWithProgress&gt;</returns>
        public async System.Threading.Tasks.Task<List<CurriculumWithProgress>> GetUserCurriculumWithProgressAsync ()
        {
             ApiResponse<List<CurriculumWithProgress>> localVarResponse = await GetUserCurriculumWithProgressAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Detailed For User Get all curricula for user including progress for each curriculum.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;CurriculumWithProgress&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<CurriculumWithProgress>>> GetUserCurriculumWithProgressAsyncWithHttpInfo ()
        {

            var localVarPath = "/curriculum/getForUserWithProgress";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


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
                Exception exception = ExceptionFactory("GetUserCurriculumWithProgress", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<CurriculumWithProgress>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CurriculumWithProgress>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CurriculumWithProgress>)));
        }

    }
}
