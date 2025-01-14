using System.Net.Http;

namespace DotnetTraq
{
    /// <summary>
    /// Represents a client used to access the traQ API.
    /// </summary>
    public interface ITraqApiClient
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

        internal TraqApiClient(HttpClient client, Client.Configuration conf, HttpClientHandler? clientHandler = null)
        {
            Client = client;
            ClientHandler = clientHandler;
            Configuration = conf;
        }
    }
}
