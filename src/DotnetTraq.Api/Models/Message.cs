using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace DotnetTraq.Api.Models
{
    public class Message
    {
        [JsonPropertyName("userId")]
        public Guid AuthorId { get; set; }

        [JsonPropertyName("channelId")]
        public Guid ChannelId { get; set; }

        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("content")]
        [NotNull]
        public string? Text { get; set; }
    }
}
