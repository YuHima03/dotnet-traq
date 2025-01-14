using System;
using System.Net.Http;

namespace DotnetTraq
{
    /// <summary>
    /// Represents a client used to access the traQ API.
    /// </summary>
    public interface ITraqApiClient : IDisposable
    {
        /// <summary>
        /// Gets the <see cref="HttpClient"/> for API access.
        /// </summary>
        public HttpClient Client { get; }

        /// <summary>
        /// Gets the <see cref="HttpClientHandler"/> used by the <see cref="Client"/>.
        /// </summary>
        public HttpClientHandler? ClientHandler { get; }

        /// <summary>
        /// Gets the configuration for this client.
        /// </summary>
        public Client.IReadableConfiguration Configuration { get; }

        /// <summary>
        /// Gets the client for Activity API.
        /// </summary>
        public Api.IActivityApi ActivityApi { get; }

        /// <summary>
        /// Gets the client for Authentication API.
        /// </summary>
        public Api.IAuthenticationApi AuthenticationApi { get; }

        /// <summary>
        /// Gets the client for Bot API.
        /// </summary>
        public Api.IBotApi BotApi { get; }

        /// <summary>
        /// Gets the client for Channel API.
        /// </summary>
        public Api.IChannelApi ChannelApi { get; }

        /// <summary>
        /// Gets the client for Clip API.
        /// </summary>
        public Api.IClipApi ClipApi { get; }

        /// <summary>
        /// Gets the client for File API.
        /// </summary>
        public Api.IFileApi FileApi { get; }

        /// <summary>
        /// Gets the client for Group API.
        /// </summary>
        public Api.IGroupApi GroupApi { get; }

        /// <summary>
        /// Gets the client for Me API.
        /// </summary>
        public Api.IMeApi MeApi { get; }

        /// <summary>
        /// Gets the client for Message API.
        /// </summary>
        public Api.IMessageApi MessageApi { get; }

        /// <summary>
        /// Gets the client for Notification API.
        /// </summary>
        public Api.INotificationApi NotificationApi { get; }

        /// <summary>
        /// Gets the client for OAuth2 API.
        /// </summary>
        public Api.IOauth2Api OAuth2Api { get; }

        /// <summary>
        /// Gets the client for Ogp API.
        /// </summary>
        public Api.IOgpApi OgpApi { get; }

        /// <summary>
        /// Gets the client for Pin API.
        /// </summary>
        public Api.IPinApi PinApi { get; }

        /// <summary>
        /// Gets the client for Public API.
        /// </summary>
        public Api.IPublicApi PublicApi { get; }

        /// <summary>
        /// Gets the client for Stamp API.
        /// </summary>
        public Api.IStampApi StampApi { get; }

        /// <summary>
        /// Gets the client for Star API.
        /// </summary>
        public Api.IStarApi StarApi { get; }

        /// <summary>
        /// Gets the client for User API.
        /// </summary>
        public Api.IUserApi UserApi { get; }

        /// <summary>
        /// Gets the client for UserTag API.
        /// </summary>
        public Api.IUserTagApi UserTagApi { get; }

        /// <summary>
        /// Gets the client for Webhook API.
        /// </summary>
        public Api.IWebhookApi WebhookApi { get; }

        /// <summary>
        /// Gets the client for WebRtc API.
        /// </summary>
        public Api.IWebrtcApi WebRtcApi { get; }
    }

    /// <summary>
    /// Represents a client used to access the traQ API.
    /// </summary>
    public sealed class TraqApiClient : ITraqApiClient
    {
        /// <inheritdoc/>
        public HttpClient Client { get; }

        /// <inheritdoc/>
        public HttpClientHandler? ClientHandler { get; }

        /// <inheritdoc/>
        public Client.IReadableConfiguration Configuration { get; }

        #region Lazy initialized APIs

        readonly Lazy<Api.ActivityApi> _activityApi;
        readonly Lazy<Api.AuthenticationApi> _authenticationApi;
        readonly Lazy<Api.BotApi> _botApi;
        readonly Lazy<Api.ChannelApi> _channelApi;
        readonly Lazy<Api.ClipApi> _clipApi;
        readonly Lazy<Api.FileApi> _fileApi;
        readonly Lazy<Api.GroupApi> _groupApi;
        readonly Lazy<Api.MeApi> _meApi;
        readonly Lazy<Api.MessageApi> _messageApi;
        readonly Lazy<Api.NotificationApi> _notificationApi;
        readonly Lazy<Api.Oauth2Api> _oAuth2Api;
        readonly Lazy<Api.OgpApi> _ogpApi;
        readonly Lazy<Api.PinApi> _pinApi;
        readonly Lazy<Api.PublicApi> _publicApi;
        readonly Lazy<Api.StampApi> _stampApi;
        readonly Lazy<Api.StarApi> _starApi;
        readonly Lazy<Api.UserApi> _userApi;
        readonly Lazy<Api.UserTagApi> _userTagApi;
        readonly Lazy<Api.WebhookApi> _webhookApi;
        readonly Lazy<Api.WebrtcApi> _webRtcApi;

        #endregion

        #region APIs

        /// <inheritdoc cref="ITraqApiClient.ActivityApi"/>
        public Api.ActivityApi ActivityApi => _activityApi.Value;

        /// <inheritdoc cref="ITraqApiClient.AuthenticationApi"/>
        public Api.AuthenticationApi AuthenticationApi => _authenticationApi.Value;

        /// <inheritdoc cref="ITraqApiClient.BotApi"/>
        public Api.BotApi BotApi => _botApi.Value;

        /// <inheritdoc cref="ITraqApiClient.ChannelApi"/>
        public Api.ChannelApi ChannelApi => _channelApi.Value;

        /// <inheritdoc cref="ITraqApiClient.ClipApi"/>
        public Api.ClipApi ClipApi => _clipApi.Value;

        /// <inheritdoc cref="ITraqApiClient.FileApi"/>
        public Api.FileApi FileApi => _fileApi.Value;

        /// <inheritdoc cref="ITraqApiClient.GroupApi"/>
        public Api.GroupApi GroupApi => _groupApi.Value;

        /// <inheritdoc cref="ITraqApiClient.MeApi"/>
        public Api.MeApi MeApi => _meApi.Value;

        /// <inheritdoc cref="ITraqApiClient.MessageApi"/>
        public Api.MessageApi MessageApi => _messageApi.Value;

        /// <inheritdoc cref="ITraqApiClient.NotificationApi"/>
        public Api.NotificationApi NotificationApi => _notificationApi.Value;

        /// <inheritdoc cref="ITraqApiClient.OAuth2Api"/>
        public Api.Oauth2Api OAuth2Api => _oAuth2Api.Value;

        /// <inheritdoc cref="ITraqApiClient.OgpApi"/>
        public Api.OgpApi OgpApi => _ogpApi.Value;

        /// <inheritdoc cref="ITraqApiClient.PinApi"/>
        public Api.PinApi PinApi => _pinApi.Value;

        /// <inheritdoc cref="ITraqApiClient.PublicApi"/>
        public Api.PublicApi PublicApi => _publicApi.Value;

        /// <inheritdoc cref="ITraqApiClient.StampApi"/>
        public Api.StampApi StampApi => _stampApi.Value;

        /// <inheritdoc cref="ITraqApiClient.StarApi"/>
        public Api.StarApi StarApi => _starApi.Value;

        /// <inheritdoc cref="ITraqApiClient.UserApi"/>
        public Api.UserApi UserApi => _userApi.Value;

        /// <inheritdoc cref="ITraqApiClient.UserTagApi"/>
        public Api.UserTagApi UserTagApi => _userTagApi.Value;

        /// <inheritdoc cref="ITraqApiClient.WebhookApi"/>
        public Api.WebhookApi WebhookApi => _webhookApi.Value;

        /// <inheritdoc cref="ITraqApiClient.WebRtcApi"/>
        public Api.WebrtcApi WebRtcApi => _webRtcApi.Value;


        Api.IActivityApi ITraqApiClient.ActivityApi => ActivityApi;
        Api.IAuthenticationApi ITraqApiClient.AuthenticationApi => AuthenticationApi;
        Api.IBotApi ITraqApiClient.BotApi => BotApi;
        Api.IChannelApi ITraqApiClient.ChannelApi => ChannelApi;
        Api.IClipApi ITraqApiClient.ClipApi => ClipApi;
        Api.IFileApi ITraqApiClient.FileApi => FileApi;
        Api.IGroupApi ITraqApiClient.GroupApi => GroupApi;
        Api.IMeApi ITraqApiClient.MeApi => MeApi;
        Api.IMessageApi ITraqApiClient.MessageApi => MessageApi;
        Api.INotificationApi ITraqApiClient.NotificationApi => NotificationApi;
        Api.IOauth2Api ITraqApiClient.OAuth2Api => OAuth2Api;
        Api.IOgpApi ITraqApiClient.OgpApi => OgpApi;
        Api.IPinApi ITraqApiClient.PinApi => PinApi;
        Api.IPublicApi ITraqApiClient.PublicApi => PublicApi;
        Api.IStampApi ITraqApiClient.StampApi => StampApi;
        Api.IStarApi ITraqApiClient.StarApi => StarApi;
        Api.IUserApi ITraqApiClient.UserApi => UserApi;
        Api.IUserTagApi ITraqApiClient.UserTagApi => UserTagApi;
        Api.IWebhookApi ITraqApiClient.WebhookApi => WebhookApi;
        Api.IWebrtcApi ITraqApiClient.WebRtcApi => WebRtcApi;

        #endregion

        internal TraqApiClient(HttpClient client, Client.Configuration conf, HttpClientHandler? clientHandler = null)
        {
            Client = client;
            ClientHandler = clientHandler;
            Configuration = conf;

            _activityApi = new(() => new(client, conf, clientHandler));
            _authenticationApi = new(() => new(client, conf, clientHandler));
            _botApi = new(() => new(client, conf, clientHandler));
            _channelApi = new(() => new(client, conf, clientHandler));
            _clipApi = new(() => new(client, conf, clientHandler));
            _fileApi = new(() => new(client, conf, clientHandler));
            _groupApi = new(() => new(client, conf, clientHandler));
            _meApi = new(() => new(client, conf, clientHandler));
            _messageApi = new(() => new(client, conf, clientHandler));
            _notificationApi = new(() => new(client, conf, clientHandler));
            _oAuth2Api = new(() => new(client, conf, clientHandler));
            _ogpApi = new(() => new(client, conf, clientHandler));
            _pinApi = new(() => new(client, conf, clientHandler));
            _publicApi = new(() => new(client, conf, clientHandler));
            _stampApi = new(() => new(client, conf, clientHandler));
            _starApi = new(() => new(client, conf, clientHandler));
            _userApi = new(() => new(client, conf, clientHandler));
            _userTagApi = new(() => new(client, conf, clientHandler));
            _webhookApi = new(() => new(client, conf, clientHandler));
            _webRtcApi = new(() => new(client, conf, clientHandler));
        }
        
        /// <inheritdoc/>
        public void Dispose()
        {
            Client?.Dispose();
            ClientHandler?.Dispose();
        }
    }
}
