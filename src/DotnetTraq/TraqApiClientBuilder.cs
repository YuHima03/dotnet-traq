using System;
using System.Net.Http;

namespace DotnetTraq
{
    /// <summary>
    /// Provides methods to build configured <see cref="ITraqApiClient"/>s.
    /// </summary>
    public interface ITraqApiClientBuilder
    {
        /// <summary>
        /// Creates a new instance that implements <see cref="ITraqApiClient"/> interface based on the configuration.
        /// </summary>
        /// <returns>The new instance that implements <see cref="ITraqApiClient"/> interface.</returns>
        public ITraqApiClient Build();

        /// /// <summary>
        /// Sets a base address for API access.
        /// </summary>
        /// <param name="baseAddress">The base address for API access.</param>
        /// <returns></returns>
        public ITraqApiClientBuilder SetBaseAddress(string baseAddress);

        /// <summary>
        /// Specifies that instances from the <see cref="ITraqApiClientBuilder"/> should use bearer authentication with a specified token.
        /// </summary>
        /// <param name="token">The token for bearer authentication.</param>
        /// <returns></returns>
        public ITraqApiClientBuilder UseCookieAuthentication(string token);

        /// <summary>
        /// Specifies that instances from the <see cref="ITraqApiClientBuilder"/> should use cookie authentication with a specified token.
        /// </summary>
        /// <param name="token">The token for cookie authentication.</param>
        /// <returns></returns>
        public ITraqApiClientBuilder UseBearerAuthentication(string token);
    }

    /// <summary>
    /// Provides methods to build configured <see cref="TraqApiClient"/>s.
    /// </summary>
    public sealed class TraqApiClientBuilder : ITraqApiClientBuilder
    {
        IAuthenticationConfigurator? _auth;
        string? _baseAddress;

        readonly HttpClientHandler _clientHandler = new();
        readonly Client.Configuration _conf = new();

        /// <summary>
        /// Creates a new instance of the <see cref="TraqApiClient"/> class based on the configuration.
        /// </summary>
        /// <returns>The new instance of the <see cref="TraqApiClient"/> class.</returns>
        /// <exception cref="Exception">The value of a required property is null.</exception>
        public TraqApiClient Build()
        {
            HttpClientHandler clientHandler = _clientHandler;
            HttpClient client = new(clientHandler);
            Client.Configuration conf = _conf;

            if (_baseAddress is null)
            {
                throw new Exception("Base-address must be set.");
            }

            conf.BasePath = _baseAddress;
            conf.DateTimeFormat = "O";
            _auth?.Configure(clientHandler, conf);

            return new(client, conf, clientHandler);
        }

        ITraqApiClient ITraqApiClientBuilder.Build() => Build();

        /// <inheritdoc cref="ITraqApiClientBuilder.SetBaseAddress(string)"/>
        public TraqApiClientBuilder SetBaseAddress(string baseAddress)
        {
            _baseAddress = baseAddress;
            return this;
        }

        ITraqApiClientBuilder ITraqApiClientBuilder.SetBaseAddress(string baseUri) => SetBaseAddress(baseUri);

        /// <summary>
        /// Specifies that instances from the <see cref="TraqApiClientBuilder"/> should use bearer authentication with a specified token.
        /// </summary>
        /// <param name="token">The token for bearer authentication.</param>
        /// <returns></returns>
        public TraqApiClientBuilder UseBearerAuthentication(string token)
        {
            _auth = new BearerAuthenticationConfigurator(token);
            return this;
        }

        ITraqApiClientBuilder ITraqApiClientBuilder.UseBearerAuthentication(string token) => UseBearerAuthentication(token);

        /// <summary>
        /// Specifies that instances from the <see cref="TraqApiClientBuilder"/> should use cookie authentication with a specified token.
        /// </summary>
        /// <param name="token">The token for cookie authentication.</param>
        /// <returns></returns>
        public TraqApiClientBuilder UseCookieAuthentication(string token)
        {
            _auth = new CookieAuthenticationConfigurator(token);
            return this;
        }

        ITraqApiClientBuilder ITraqApiClientBuilder.UseCookieAuthentication(string token) => UseCookieAuthentication(token);
    }
}
