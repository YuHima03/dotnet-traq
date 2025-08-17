using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Runtime.CompilerServices;

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TraqApiClient CreateFromOptions(IReadOnlyTraqApiClientOptions options)
        {
            ArgumentNullException.ThrowIfNull(options);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(options.BaseAddress);

            var bearerIsAvailable = !string.IsNullOrWhiteSpace(options.BearerAuthToken);
            var cookieIsAvailable = !string.IsNullOrWhiteSpace(options.CookieAuthToken);
            if (!bearerIsAvailable && !cookieIsAvailable)
            {
                ThrowHelper.ThrowInvalidOperationException("At least one authentication method must be available.");
            }

            // true when use bearer authentication; otherwise, cookie.
            var authenticationMethod = options.AuthMethodPreference switch
            {
                TraqAuthMethodPreference.PreferBearerAuth => bearerIsAvailable,
                TraqAuthMethodPreference.PreferCookieAuth => !cookieIsAvailable,
                _ => bearerIsAvailable,
            };

            Uri baseAddress = new(options.BaseAddress);
            HttpClientHandler clientHandler = new()
            {
                AllowAutoRedirect = false,
                UseCookies = !authenticationMethod, // Enable when using cookie authentication.
            };
            HttpClient client = new(clientHandler)
            {
                BaseAddress = baseAddress
            };

            if (authenticationMethod)
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
            return new(new HttpClientRequestAdapter(new AnonymousAuthenticationProvider(), httpClient: client));
        }
    }

    file static class ThrowHelper
    {
        [DoesNotReturn]
        public static void ThrowInvalidOperationException(string message)
        {
            throw new InvalidOperationException(message);
        }
    }
}
