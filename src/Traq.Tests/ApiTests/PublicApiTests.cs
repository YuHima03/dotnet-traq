namespace Traq.Tests.ApiTests
{
    public class PublicApiTests
    {
        [Fact]
        public async Task GetServerVersionAsyncTestAsync()
        {
            var v = await ApiClientProvider.SharedClient.PublicApi.GetServerVersionAsync();
        }
    }
}
