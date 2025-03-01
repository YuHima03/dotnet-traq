/*
 * traQ v3
 *
 * traQ v3 API
 *
 * The version of the OpenAPI document: 3.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using Traq.Client;
using Traq.Model;

namespace Traq.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStarApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// チャンネルをスターに追加
        /// </summary>
        /// <remarks>
        /// 指定したチャンネルをスターチャンネルに追加します。 スター済みのチャンネルIDを指定した場合、204を返します。 不正なチャンネルIDを指定した場合、400を返します。
        /// </remarks>
        /// <exception cref="Traq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postStarRequest"> (optional)</param>
        /// <returns></returns>
        void AddMyStar(PostStarRequest? postStarRequest = default(PostStarRequest?));

        /// <summary>
        /// チャンネルをスターに追加
        /// </summary>
        /// <remarks>
        /// 指定したチャンネルをスターチャンネルに追加します。 スター済みのチャンネルIDを指定した場合、204を返します。 不正なチャンネルIDを指定した場合、400を返します。
        /// </remarks>
        /// <exception cref="Traq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postStarRequest"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddMyStarWithHttpInfo(PostStarRequest? postStarRequest = default(PostStarRequest?));
        /// <summary>
        /// スターチャンネルリストを取得
        /// </summary>
        /// <remarks>
        /// 自分がスターしているチャンネルのUUIDの配列を取得します。
        /// </remarks>
        /// <exception cref="Traq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Guid&gt;</returns>
        List<Guid> GetMyStars();

        /// <summary>
        /// スターチャンネルリストを取得
        /// </summary>
        /// <remarks>
        /// 自分がスターしているチャンネルのUUIDの配列を取得します。
        /// </remarks>
        /// <exception cref="Traq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Guid&gt;</returns>
        ApiResponse<List<Guid>> GetMyStarsWithHttpInfo();
        /// <summary>
        /// チャンネルをスターから削除します
        /// </summary>
        /// <remarks>
        /// 既にスターから削除されているチャンネルを指定した場合は204を返します。
        /// </remarks>
        /// <exception cref="Traq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">チャンネルUUID</param>
        /// <returns></returns>
        void RemoveMyStar(Guid channelId);

        /// <summary>
        /// チャンネルをスターから削除します
        /// </summary>
        /// <remarks>
        /// 既にスターから削除されているチャンネルを指定した場合は204を返します。
        /// </remarks>
        /// <exception cref="Traq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">チャンネルUUID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> RemoveMyStarWithHttpInfo(Guid channelId);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStarApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// チャンネルをスターに追加
        /// </summary>
        /// <remarks>
        /// 指定したチャンネルをスターチャンネルに追加します。 スター済みのチャンネルIDを指定した場合、204を返します。 不正なチャンネルIDを指定した場合、400を返します。
        /// </remarks>
        /// <exception cref="Traq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postStarRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddMyStarAsync(PostStarRequest? postStarRequest = default(PostStarRequest?), System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// チャンネルをスターに追加
        /// </summary>
        /// <remarks>
        /// 指定したチャンネルをスターチャンネルに追加します。 スター済みのチャンネルIDを指定した場合、204を返します。 不正なチャンネルIDを指定した場合、400を返します。
        /// </remarks>
        /// <exception cref="Traq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postStarRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddMyStarWithHttpInfoAsync(PostStarRequest? postStarRequest = default(PostStarRequest?), System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        /// <summary>
        /// スターチャンネルリストを取得
        /// </summary>
        /// <remarks>
        /// 自分がスターしているチャンネルのUUIDの配列を取得します。
        /// </remarks>
        /// <exception cref="Traq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;Guid&gt;</returns>
        System.Threading.Tasks.Task<List<Guid>> GetMyStarsAsync(System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// スターチャンネルリストを取得
        /// </summary>
        /// <remarks>
        /// 自分がスターしているチャンネルのUUIDの配列を取得します。
        /// </remarks>
        /// <exception cref="Traq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;Guid&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Guid>>> GetMyStarsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        /// <summary>
        /// チャンネルをスターから削除します
        /// </summary>
        /// <remarks>
        /// 既にスターから削除されているチャンネルを指定した場合は204を返します。
        /// </remarks>
        /// <exception cref="Traq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">チャンネルUUID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task RemoveMyStarAsync(Guid channelId, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// チャンネルをスターから削除します
        /// </summary>
        /// <remarks>
        /// 既にスターから削除されているチャンネルを指定した場合は204を返します。
        /// </remarks>
        /// <exception cref="Traq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">チャンネルUUID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> RemoveMyStarWithHttpInfoAsync(Guid channelId, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStarApi : IStarApiSync, IStarApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class StarApi : IDisposable, IStarApi
    {
        private Traq.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="StarApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public StarApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StarApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public StarApi(string basePath)
        {
            this.Configuration = Traq.Client.Configuration.MergeConfigurations(
                Traq.Client.GlobalConfiguration.Instance,
                new Traq.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new Traq.Client.ApiClient(this.Configuration.BasePath);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = Traq.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StarApi"/> class using Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public StarApi(Traq.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Traq.Client.Configuration.MergeConfigurations(
                Traq.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new Traq.Client.ApiClient(this.Configuration.BasePath);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = Traq.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StarApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public StarApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StarApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public StarApi(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = Traq.Client.Configuration.MergeConfigurations(
                Traq.Client.GlobalConfiguration.Instance,
                new Traq.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new Traq.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = Traq.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StarApi"/> class using Configuration object.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public StarApi(HttpClient client, Traq.Client.Configuration configuration, HttpClientHandler handler = null)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = Traq.Client.Configuration.MergeConfigurations(
                Traq.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new Traq.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = Traq.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StarApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public StarApi(Traq.Client.ISynchronousClient client, Traq.Client.IAsynchronousClient asyncClient, Traq.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Traq.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Disposes resources if they were created by us
        /// </summary>
        public void Dispose()
        {
            this.ApiClient?.Dispose();
        }

        /// <summary>
        /// Holds the ApiClient if created
        /// </summary>
        public Traq.Client.ApiClient ApiClient { get; set; } = null;

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Traq.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Traq.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Traq.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Traq.Client.ExceptionFactory ExceptionFactory
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
        /// チャンネルをスターに追加 指定したチャンネルをスターチャンネルに追加します。 スター済みのチャンネルIDを指定した場合、204を返します。 不正なチャンネルIDを指定した場合、400を返します。
        /// </summary>
        /// <exception cref="Traq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postStarRequest"> (optional)</param>
        /// <returns></returns>
        public void AddMyStar(PostStarRequest? postStarRequest = default(PostStarRequest?))
        {
            AddMyStarWithHttpInfo(postStarRequest);
        }

        /// <summary>
        /// チャンネルをスターに追加 指定したチャンネルをスターチャンネルに追加します。 スター済みのチャンネルIDを指定した場合、204を返します。 不正なチャンネルIDを指定した場合、400を返します。
        /// </summary>
        /// <exception cref="Traq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postStarRequest"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Traq.Client.ApiResponse<Object> AddMyStarWithHttpInfo(PostStarRequest? postStarRequest = default(PostStarRequest?))
        {
            Traq.Client.RequestOptions localVarRequestOptions = new Traq.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = Traq.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Traq.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = postStarRequest;

            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/users/me/stars", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddMyStar", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// チャンネルをスターに追加 指定したチャンネルをスターチャンネルに追加します。 スター済みのチャンネルIDを指定した場合、204を返します。 不正なチャンネルIDを指定した場合、400を返します。
        /// </summary>
        /// <exception cref="Traq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postStarRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddMyStarAsync(PostStarRequest? postStarRequest = default(PostStarRequest?), System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            await AddMyStarWithHttpInfoAsync(postStarRequest, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// チャンネルをスターに追加 指定したチャンネルをスターチャンネルに追加します。 スター済みのチャンネルIDを指定した場合、204を返します。 不正なチャンネルIDを指定した場合、400を返します。
        /// </summary>
        /// <exception cref="Traq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postStarRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Traq.Client.ApiResponse<Object>> AddMyStarWithHttpInfoAsync(PostStarRequest? postStarRequest = default(PostStarRequest?), System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {

            Traq.Client.RequestOptions localVarRequestOptions = new Traq.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };


            var localVarContentType = Traq.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Traq.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = postStarRequest;

            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/users/me/stars", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddMyStar", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// スターチャンネルリストを取得 自分がスターしているチャンネルのUUIDの配列を取得します。
        /// </summary>
        /// <exception cref="Traq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Guid&gt;</returns>
        public List<Guid> GetMyStars()
        {
            Traq.Client.ApiResponse<List<Guid>> localVarResponse = GetMyStarsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// スターチャンネルリストを取得 自分がスターしているチャンネルのUUIDの配列を取得します。
        /// </summary>
        /// <exception cref="Traq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Guid&gt;</returns>
        public Traq.Client.ApiResponse<List<Guid>> GetMyStarsWithHttpInfo()
        {
            Traq.Client.RequestOptions localVarRequestOptions = new Traq.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Traq.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Traq.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<Guid>>("/users/me/stars", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetMyStars", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// スターチャンネルリストを取得 自分がスターしているチャンネルのUUIDの配列を取得します。
        /// </summary>
        /// <exception cref="Traq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;Guid&gt;</returns>
        public async System.Threading.Tasks.Task<List<Guid>> GetMyStarsAsync(System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            Traq.Client.ApiResponse<List<Guid>> localVarResponse = await GetMyStarsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// スターチャンネルリストを取得 自分がスターしているチャンネルのUUIDの配列を取得します。
        /// </summary>
        /// <exception cref="Traq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;Guid&gt;)</returns>
        public async System.Threading.Tasks.Task<Traq.Client.ApiResponse<List<Guid>>> GetMyStarsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {

            Traq.Client.RequestOptions localVarRequestOptions = new Traq.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Traq.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Traq.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<Guid>>("/users/me/stars", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetMyStars", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// チャンネルをスターから削除します 既にスターから削除されているチャンネルを指定した場合は204を返します。
        /// </summary>
        /// <exception cref="Traq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">チャンネルUUID</param>
        /// <returns></returns>
        public void RemoveMyStar(Guid channelId)
        {
            RemoveMyStarWithHttpInfo(channelId);
        }

        /// <summary>
        /// チャンネルをスターから削除します 既にスターから削除されているチャンネルを指定した場合は204を返します。
        /// </summary>
        /// <exception cref="Traq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">チャンネルUUID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Traq.Client.ApiResponse<Object> RemoveMyStarWithHttpInfo(Guid channelId)
        {
            Traq.Client.RequestOptions localVarRequestOptions = new Traq.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = Traq.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Traq.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("channelId", Traq.Client.ClientUtils.ParameterToString(channelId)); // path parameter

            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/users/me/stars/{channelId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RemoveMyStar", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// チャンネルをスターから削除します 既にスターから削除されているチャンネルを指定した場合は204を返します。
        /// </summary>
        /// <exception cref="Traq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">チャンネルUUID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task RemoveMyStarAsync(Guid channelId, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            await RemoveMyStarWithHttpInfoAsync(channelId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// チャンネルをスターから削除します 既にスターから削除されているチャンネルを指定した場合は204を返します。
        /// </summary>
        /// <exception cref="Traq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">チャンネルUUID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Traq.Client.ApiResponse<Object>> RemoveMyStarWithHttpInfoAsync(Guid channelId, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {

            Traq.Client.RequestOptions localVarRequestOptions = new Traq.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };


            var localVarContentType = Traq.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Traq.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("channelId", Traq.Client.ClientUtils.ParameterToString(channelId)); // path parameter

            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/users/me/stars/{channelId}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RemoveMyStar", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
