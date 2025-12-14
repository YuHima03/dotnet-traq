using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Traq
{
    /// <summary>
    /// Represents a preference of authentication method for the traQ API.
    /// </summary>
    public enum TraqAuthMethodPreference
    {
        /// <summary>
        /// Preference is not specified.
        /// </summary>
        NotSpecified = 0,

        /// <summary>
        /// Prefer bearer authentication.
        /// </summary>
        PreferBearerAuth,

        /// <summary>
        /// Prefer cookie authentication.
        /// </summary>
        PreferCookieAuth,
    }

    /// <summary>
    /// Represents read-only options for the <see cref="TraqApiClient"/> service.
    /// </summary>
    public interface IReadOnlyTraqApiClientOptions
    {
        /// <summary>
        /// Gets the preference of authentication method for the traQ API.
        /// </summary>
        /// <returns>The preference of authentication method for the traQ API.</returns>
        public abstract TraqAuthMethodPreference AuthMethodPreference { get; }

        /// <summary>
        /// Gets the base address of the traQ API.
        /// </summary>
        /// <returns>
        /// The base address of the traQ API.
        /// </returns>
        public abstract string BaseAddress { get; }

        /// <summary>
        /// Gets the token used in bearer authentication to access the traQ API.
        /// </summary>
        /// <returns>The token used in bearer authentication to access the traQ API.</returns>
        public abstract string? BearerAuthToken { get; }

        /// <summary>
        /// Gets the token used in cookie authentication to access the traQ API.
        /// </summary>
        /// <returns>The token used in cookie authentication to access the traQ API.</returns>
        public abstract string? CookieAuthToken { get; }
    }

    /// <summary>
    /// Options for the <see cref="TraqApiClient"/> service.
    /// </summary>
    public sealed class TraqApiClientOptions : IReadOnlyTraqApiClientOptions
    {
        /// <summary>
        /// Gets or sets the preference of authentication method for the traQ API.
        /// </summary>
        /// <remarks>
        /// If the value is set to <see cref="TraqAuthMethodPreference.NotSpecified"/>, this method tries to use bearer authentication in preference.
        /// </remarks>
        /// <value>The preference of authentication method for the traQ API.</value>
        public TraqAuthMethodPreference AuthMethodPreference { get; set; } = TraqAuthMethodPreference.NotSpecified;

        /// <summary>
        /// Gets or sets the base address of the traQ API.
        /// </summary>
        /// <value>
        /// The base address of the traQ API.
        /// </value>
        /// <exception cref="UriFormatException"></exception>
        public string BaseAddress
        {
            get => _baseAddressString;

            set
            {
                if (value == _baseAddressString)
                {
                    return;
                }
                _baseAddressUriCached = null;
                if (string.IsNullOrWhiteSpace(value))
                {
                    _baseAddressString = string.Empty;
                }
                else
                {
                    var address = value.AsSpan().Trim();
                    _baseAddressString = address.EndsWith("/")
                        ? ((value.Length == address.Length) ? value : address.ToString())
                        : StringExtension.Concat(address, "/");

                    if (!Uri.IsWellFormedUriString(_baseAddressString, UriKind.Absolute))
                    {
                        ThrowHelper.ThrowUriFormatException("The provided base address is not a valid absolute URI.");
                    }
                }
            }
        }
        string _baseAddressString = string.Empty;

        /// <summary>
        /// Gets the base address of the traQ API as an instance of the <see cref="Uri"/> class.
        /// </summary>
        /// <returns>The base address of the traQ API. The value is <see langword="null"/> when <see cref="BaseAddress"/> is null, empty or consists of only white-space characters.</returns>
        public Uri? BaseAddressUri
        {
            get
            {
                if (_baseAddressString == string.Empty)
                {
                    return null;
                }
                else if (_baseAddressUriCached is not null)
                {
                    return _baseAddressUriCached;
                }
                return _baseAddressUriCached = new Uri(_baseAddressString, UriKind.Absolute);
            }
        }
        Uri? _baseAddressUriCached = null;

        /// <summary>
        /// Gets or sets the token used in bearer authentication to access the traQ API.
        /// </summary>
        /// <value>The token used in bearer authentication to access the traQ API.</value>
        public string? BearerAuthToken { get; set; } = null;

        /// <summary>
        /// Gets or sets the token used in cookie authentication to access the traQ API.
        /// </summary>
        /// <value>The token used in cookie authentication to access the traQ API.</value>
        public string? CookieAuthToken { get; set; } = null;
    }

    file static class StringExtension
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Concat(ReadOnlySpan<char> s0, ReadOnlySpan<char> s1)
        {
#if NET
            return string.Concat(s0, s1);
#else
            Span<char> s = stackalloc char[s0.Length + s1.Length];
            s0.CopyTo(s);
#if NETSTANDARD2_1_OR_GREATER
            s1.CopyTo(s[s0.Length..]);
            return new(s);
#else
            s1.CopyTo(s.Slice(s0.Length));
            return s.ToString();
#endif
#endif
        }
    }

    file static class ThrowHelper
    {
#if NETSTANDARD2_1_OR_GREATER
        [DoesNotReturn]
#endif
        public static void ThrowUriFormatException(string message)
        {
            throw new UriFormatException(message);
        }
    }
}
