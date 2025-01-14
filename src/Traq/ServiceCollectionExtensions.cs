using Microsoft.Extensions.DependencyInjection;
using System;

namespace Traq
{
    /// <summary>
    /// Provides extension methods for the <see cref="IServiceCollection"/> interface.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds a singleton service for the <see cref="ITraqApiClient"/> interface with an instance configured by <paramref name="configure"/> to the specified <see cref="IServiceCollection"/>.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to add.</param>
        /// <param name="configure">The configurator for a new instance of the <see cref="ITraqApiClient"/> interface.</param>
        /// <returns></returns>
        public static IServiceCollection AddTraqApiClient(this IServiceCollection services, Action<ITraqApiClientBuilder> configure)
        {
            TraqApiClientBuilder builder = new();
            configure.Invoke(builder);
            return services.AddSingleton<ITraqApiClient>(builder.Build());
        }
    }
}
