using System;
using System.Net.Http;

namespace Traq
{
    internal interface IAuthenticationConfigurator
    {
        public void Configure(HttpClientHandler handler, Client.Configuration conf);
    }

    internal sealed class BearerAuthenticationConfigurator(string token) : IAuthenticationConfigurator
    {
        public string Token { get; } = token;

        public void Configure(HttpClientHandler handler, Client.Configuration conf)
        {
            conf.AccessToken = Token;
        }
    }

    internal sealed class CookieAuthenticationConfigurator(string token) : IAuthenticationConfigurator
    {
        public string Token { get; } = token;

        public void Configure(HttpClientHandler handler, Client.Configuration conf)
        {
            Uri baseAddress = new(conf.BasePath);

            handler.CookieContainer.Add(new System.Net.Cookie()
            {
                Domain = new Uri(conf.BasePath).Host,
                HttpOnly = true,
                Name = "r_session",
                Path = "/",
                Secure = baseAddress.Scheme == Uri.UriSchemeHttps,
                Value = Token,
            });
        }
    }
}
