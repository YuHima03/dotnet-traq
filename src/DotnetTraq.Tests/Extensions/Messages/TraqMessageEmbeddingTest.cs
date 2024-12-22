using DotnetTraq.Extensions.Messages;

namespace DotnetTraq.Tests.Extensions.Messages
{
    public class TraqMessageEmbeddingTest
    {
        [Theory]
        [InlineData("@test", "ffffffff-ffff-ffff-ffff-ffffffffffff")]
        public void TryParseHeadTest(string displayText, Guid embeddedId)
        {
            var text = $$"""
                !{"type":"user","raw":"{{displayText}}","id":"{{embeddedId}}"}
                """;
            var cnt = TraqMessageEmbedding.TryParseHead(text, out var embedding);

            Assert.Equal(text.Length, cnt);
            Assert.Equal(EmbeddingType.UserMention, embedding.Type);
            Assert.Equal(displayText, embedding.DisplayText);
            Assert.Equal(embeddedId, embedding.EmbeddedId);
        }
    }
}
