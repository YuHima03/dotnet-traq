using Microsoft.Extensions.Options;

namespace Traq.Tests
{
    internal class ApiClientProvider
    {
        public static TraqApiClient SharedClient { get; }

        static ApiClientProvider()
        {
            var options = Options.Create(new TraqApiClientOptions()
            {
                BaseAddress = "https://q.trap.jp/api/v3",
                BearerAuthToken = "G2DGWpnWxDkQriWcrdKEEg9mtahnlOVBUhqh"
            });
            SharedClient = new(options);
        }
    }
}
