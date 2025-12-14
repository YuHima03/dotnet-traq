using CommunityToolkit.Diagnostics;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using System;
using System.Net.Http;

namespace Traq
{
    /// <summary>
    /// Provides helper methods for creating instances of <see cref="TraqApiClient"/> configured with <see cref="TraqApiClientOptions"/>.
    /// </summary>
    public static class TraqApiClientHelper
    {
        const string CookieAuthenticationCookieName = "r_session";

        /// <summary>
        /// Creates a new instance of <see cref="TraqApiClient"/> using the specified options.
        /// </summary>
        /// <param name="options">
        /// Options for configuring the <see cref="TraqApiClient"/>.
        /// </param>
        /// <returns>A configured <see cref="TraqApiClient"/> instance ready for use.</returns>
        public static TraqApiClient CreateFromOptions(IReadOnlyTraqApiClientOptions options)
        {
            Guard.IsNotNull(options);
            Guard.IsNotNullOrWhiteSpace(options.BaseAddress);

            var bearerIsAvailable = !string.IsNullOrWhiteSpace(options.BearerAuthToken);
            var cookieIsAvailable = !string.IsNullOrWhiteSpace(options.CookieAuthToken);
            if (!bearerIsAvailable && !cookieIsAvailable)
            {
                return new(new HttpClientRequestAdapter(
                    authenticationProvider: new AnonymousAuthenticationProvider(),
                    httpClient: new(new HttpClientHandler()
                    {
                        AllowAutoRedirect = false,
                        UseCookies = true,
                    }))
                {
                    BaseUrl = options.BaseAddress
                });
            }

            // true when use bearer authentication; otherwise, cookie.
            var useBearer = options.AuthMethodPreference switch
            {
                TraqAuthMethodPreference.PreferBearerAuth => bearerIsAvailable,
                TraqAuthMethodPreference.PreferCookieAuth => !cookieIsAvailable,
                _ => bearerIsAvailable,
            };

            Uri baseAddress = new(options.BaseAddress);
            HttpClientHandler clientHandler = new()
            {
                AllowAutoRedirect = false,
                UseCookies = !useBearer, // Enable when using cookie authentication.
            };
            HttpClient client = new(clientHandler);

            if (useBearer)
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", options.BearerAuthToken);
            }
            else
            {
                clientHandler.CookieContainer.Add(new System.Net.Cookie
                {
                    Domain = baseAddress.Host,
                    HttpOnly = true,
                    Name = CookieAuthenticationCookieName,
                    Path = "/",
                    Secure = baseAddress.Scheme == Uri.UriSchemeHttps,
                    Value = options.CookieAuthToken,
                });
            }
            return new(new HttpClientRequestAdapter(new AnonymousAuthenticationProvider(), httpClient: client) { BaseUrl = options.BaseAddress });
        }
    }
}
