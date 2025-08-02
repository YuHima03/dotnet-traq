namespace Traq.Tests.ApiTests
{
    public class ChannelApiTests
    {
        public static TheoryData<string> ChannelPaths => ["gps/times", "random/event"];

        [Fact]
        public async Task GetChannelsAsyncTestAsync()
        {
            var c = ApiClientProvider.SharedClient;
            _ = await c.ChannelApi.GetChannelsAsync();
        }

        [Theory]
        [MemberData(nameof(ChannelPaths))]
        public async Task GetChannelsFromPathAsyncTestAsync(string path)
        {
            var c = ApiClientProvider.SharedClient;
            var list = await c.ChannelApi.GetChannelsAsync(null, path);

            Assert.NotNull(list);
            Assert.NotNull(list.Public);
            Assert.EndsWith(path.TrimEnd(), Assert.Single(list.Public).Name);
        }
    }
}
