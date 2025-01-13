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
using DotnetTraq.Client;
using DotnetTraq.Model;

namespace DotnetTraq.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPublicApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// ユーザーのアイコン画像を取得
        /// </summary>
        /// <remarks>
        /// ユーザーのアイコン画像を取得します。
        /// </remarks>
        /// <exception cref="DotnetTraq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">ユーザー名</param>
        /// <returns>FileParameter</returns>
        FileParameter GetPublicUserIcon(string username);

        /// <summary>
        /// ユーザーのアイコン画像を取得
        /// </summary>
        /// <remarks>
        /// ユーザーのアイコン画像を取得します。
        /// </remarks>
        /// <exception cref="DotnetTraq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">ユーザー名</param>
        /// <returns>ApiResponse of FileParameter</returns>
        ApiResponse<FileParameter> GetPublicUserIconWithHttpInfo(string username);
        /// <summary>
        /// バージョンを取得
        /// </summary>
        /// <remarks>
        /// サーバーバージョン及びサーバーフラグ情報を取得します。
        /// </remarks>
        /// <exception cref="DotnetTraq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ModelVersion</returns>
        ModelVersion GetServerVersion();

        /// <summary>
        /// バージョンを取得
        /// </summary>
        /// <remarks>
        /// サーバーバージョン及びサーバーフラグ情報を取得します。
        /// </remarks>
        /// <exception cref="DotnetTraq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ModelVersion</returns>
        ApiResponse<ModelVersion> GetServerVersionWithHttpInfo();
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPublicApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// ユーザーのアイコン画像を取得
        /// </summary>
        /// <remarks>
        /// ユーザーのアイコン画像を取得します。
        /// </remarks>
        /// <exception cref="DotnetTraq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">ユーザー名</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        System.Threading.Tasks.Task<FileParameter> GetPublicUserIconAsync(string username, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// ユーザーのアイコン画像を取得
        /// </summary>
        /// <remarks>
        /// ユーザーのアイコン画像を取得します。
        /// </remarks>
        /// <exception cref="DotnetTraq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">ユーザー名</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileParameter>> GetPublicUserIconWithHttpInfoAsync(string username, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        /// <summary>
        /// バージョンを取得
        /// </summary>
        /// <remarks>
        /// サーバーバージョン及びサーバーフラグ情報を取得します。
        /// </remarks>
        /// <exception cref="DotnetTraq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ModelVersion</returns>
        System.Threading.Tasks.Task<ModelVersion> GetServerVersionAsync(System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// バージョンを取得
        /// </summary>
        /// <remarks>
        /// サーバーバージョン及びサーバーフラグ情報を取得します。
        /// </remarks>
        /// <exception cref="DotnetTraq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ModelVersion)</returns>
        System.Threading.Tasks.Task<ApiResponse<ModelVersion>> GetServerVersionWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPublicApi : IPublicApiSync, IPublicApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PublicApi : IDisposable, IPublicApi
    {
        private DotnetTraq.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public PublicApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public PublicApi(string basePath)
        {
            this.Configuration = DotnetTraq.Client.Configuration.MergeConfigurations(
                DotnetTraq.Client.GlobalConfiguration.Instance,
                new DotnetTraq.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new DotnetTraq.Client.ApiClient(this.Configuration.BasePath);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = DotnetTraq.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicApi"/> class using Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public PublicApi(DotnetTraq.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = DotnetTraq.Client.Configuration.MergeConfigurations(
                DotnetTraq.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new DotnetTraq.Client.ApiClient(this.Configuration.BasePath);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = DotnetTraq.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public PublicApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicApi"/> class.
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
        public PublicApi(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = DotnetTraq.Client.Configuration.MergeConfigurations(
                DotnetTraq.Client.GlobalConfiguration.Instance,
                new DotnetTraq.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new DotnetTraq.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = DotnetTraq.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicApi"/> class using Configuration object.
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
        public PublicApi(HttpClient client, DotnetTraq.Client.Configuration configuration, HttpClientHandler handler = null)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = DotnetTraq.Client.Configuration.MergeConfigurations(
                DotnetTraq.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new DotnetTraq.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = DotnetTraq.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public PublicApi(DotnetTraq.Client.ISynchronousClient client, DotnetTraq.Client.IAsynchronousClient asyncClient, DotnetTraq.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = DotnetTraq.Client.Configuration.DefaultExceptionFactory;
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
        public DotnetTraq.Client.ApiClient ApiClient { get; set; } = null;

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public DotnetTraq.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public DotnetTraq.Client.ISynchronousClient Client { get; set; }

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
        public DotnetTraq.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public DotnetTraq.Client.ExceptionFactory ExceptionFactory
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
        /// ユーザーのアイコン画像を取得 ユーザーのアイコン画像を取得します。
        /// </summary>
        /// <exception cref="DotnetTraq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">ユーザー名</param>
        /// <returns>FileParameter</returns>
        public FileParameter GetPublicUserIcon(string username)
        {
            DotnetTraq.Client.ApiResponse<FileParameter> localVarResponse = GetPublicUserIconWithHttpInfo(username);
            return localVarResponse.Data;
        }

        /// <summary>
        /// ユーザーのアイコン画像を取得 ユーザーのアイコン画像を取得します。
        /// </summary>
        /// <exception cref="DotnetTraq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">ユーザー名</param>
        /// <returns>ApiResponse of FileParameter</returns>
        public DotnetTraq.Client.ApiResponse<FileParameter> GetPublicUserIconWithHttpInfo(string username)
        {
            // verify the required parameter 'username' is set
            if (username == null)
                throw new DotnetTraq.Client.ApiException(400, "Missing required parameter 'username' when calling PublicApi->GetPublicUserIcon");

            DotnetTraq.Client.RequestOptions localVarRequestOptions = new DotnetTraq.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "image/jpeg",
                "image/gif",
                "image/png"
            };

            var localVarContentType = DotnetTraq.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = DotnetTraq.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("username", DotnetTraq.Client.ClientUtils.ParameterToString(username)); // path parameter

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
            var localVarResponse = this.Client.Get<FileParameter>("/public/icon/{username}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPublicUserIcon", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// ユーザーのアイコン画像を取得 ユーザーのアイコン画像を取得します。
        /// </summary>
        /// <exception cref="DotnetTraq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">ユーザー名</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        public async System.Threading.Tasks.Task<FileParameter> GetPublicUserIconAsync(string username, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            DotnetTraq.Client.ApiResponse<FileParameter> localVarResponse = await GetPublicUserIconWithHttpInfoAsync(username, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// ユーザーのアイコン画像を取得 ユーザーのアイコン画像を取得します。
        /// </summary>
        /// <exception cref="DotnetTraq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">ユーザー名</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        public async System.Threading.Tasks.Task<DotnetTraq.Client.ApiResponse<FileParameter>> GetPublicUserIconWithHttpInfoAsync(string username, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            // verify the required parameter 'username' is set
            if (username == null)
                throw new DotnetTraq.Client.ApiException(400, "Missing required parameter 'username' when calling PublicApi->GetPublicUserIcon");


            DotnetTraq.Client.RequestOptions localVarRequestOptions = new DotnetTraq.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "image/jpeg",
                "image/gif",
                "image/png"
            };


            var localVarContentType = DotnetTraq.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = DotnetTraq.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("username", DotnetTraq.Client.ClientUtils.ParameterToString(username)); // path parameter

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

            var localVarResponse = await this.AsynchronousClient.GetAsync<FileParameter>("/public/icon/{username}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPublicUserIcon", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// バージョンを取得 サーバーバージョン及びサーバーフラグ情報を取得します。
        /// </summary>
        /// <exception cref="DotnetTraq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ModelVersion</returns>
        public ModelVersion GetServerVersion()
        {
            DotnetTraq.Client.ApiResponse<ModelVersion> localVarResponse = GetServerVersionWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// バージョンを取得 サーバーバージョン及びサーバーフラグ情報を取得します。
        /// </summary>
        /// <exception cref="DotnetTraq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ModelVersion</returns>
        public DotnetTraq.Client.ApiResponse<ModelVersion> GetServerVersionWithHttpInfo()
        {
            DotnetTraq.Client.RequestOptions localVarRequestOptions = new DotnetTraq.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = DotnetTraq.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = DotnetTraq.Client.ClientUtils.SelectHeaderAccept(_accepts);
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
            var localVarResponse = this.Client.Get<ModelVersion>("/version", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetServerVersion", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// バージョンを取得 サーバーバージョン及びサーバーフラグ情報を取得します。
        /// </summary>
        /// <exception cref="DotnetTraq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ModelVersion</returns>
        public async System.Threading.Tasks.Task<ModelVersion> GetServerVersionAsync(System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            DotnetTraq.Client.ApiResponse<ModelVersion> localVarResponse = await GetServerVersionWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// バージョンを取得 サーバーバージョン及びサーバーフラグ情報を取得します。
        /// </summary>
        /// <exception cref="DotnetTraq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ModelVersion)</returns>
        public async System.Threading.Tasks.Task<DotnetTraq.Client.ApiResponse<ModelVersion>> GetServerVersionWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {

            DotnetTraq.Client.RequestOptions localVarRequestOptions = new DotnetTraq.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = DotnetTraq.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = DotnetTraq.Client.ClientUtils.SelectHeaderAccept(_accepts);
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<ModelVersion>("/version", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetServerVersion", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
