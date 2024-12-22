using DotnetTraq.Extensions.Messages;

namespace DotnetTraq.Tests.Extensions.Messages
{
    public class TraqMessageUrlTest
    {
        [Theory]
        [InlineData("https://q.trap.jp")]
        public void TryParseHeadTest(string urlString)
        {
            var cnt = TraqMessageUrl.TryParseHead(urlString.AsSpan(), out var url);

            Assert.Equal(urlString.StartsWith("//"), url.HasNoScheme);
            Assert.Equal(new Uri(urlString), url.GetUri());
        }
    }
}
