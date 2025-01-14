﻿using System;
using System.Net.Http;

namespace DotnetTraq
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
            handler.CookieContainer.Add(new System.Net.Cookie()
            {
                Domain = new Uri(conf.BasePath).Host,
                HttpOnly = true,
                Name = "r_session",
                Path = "/",
                Secure = true,
                Value = Token,
            });
        }
    }
}