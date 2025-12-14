using CommunityToolkit.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using System;

namespace Traq
{
    /// <summary>
    /// Provides extension methods for <see cref="IServiceCollection"/> to register the <see cref="TraqApiClient"/>.
    /// </summary>
    public static class ServiceCollectionExtension
    {
        /// <summary>
        /// Adds a singleton instance of the <see cref="TraqApiClient"/> class to the service collection.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to add.</param>
        public static IServiceCollection AddTraqApiClient(this IServiceCollection services)
        {
            Guard.IsNotNull(services);
            services.TryAddSingleton(sp => TraqApiClientHelper.CreateFromOptions(sp.GetRequiredService<IOptions<TraqApiClientOptions>>().Value));
            return services;
        }

        /// <summary>
        /// Add a singleton instance of the <see cref="TraqApiClient"/> class configured by the <paramref name="configureOptions"/> to the service collection.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to add.</param>
        /// <param name="configureOptions">The action to configure the options.</param>
        public static IServiceCollection AddTraqApiClient(this IServiceCollection services, Action<TraqApiClientOptions> configureOptions)
        {
            Guard.IsNotNull(services);
            Guard.IsNotNull(configureOptions);
            return services
                .Configure(configureOptions)
                .AddTraqApiClient();
        }

        /// <summary>
        /// Add a singleton instance of the <see cref="TraqApiClient"/> class configured by the <paramref name="configureOptions"/> to the service collection.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to add.</param>
        /// <param name="configureOptions">The action to configure the options.</param>
        public static IServiceCollection AddTraqApiClient(this IServiceCollection services, Action<IServiceProvider, TraqApiClientOptions> configureOptions)
        {
            Guard.IsNotNull(services);
            Guard.IsNotNull(configureOptions);
            return services
                .AddSingleton<IConfigureOptions<TraqApiClientOptions>>(sp => new ConfigureOptions<TraqApiClientOptions>(options => configureOptions(sp, options)))
                .AddTraqApiClient();
        }
    }
}
