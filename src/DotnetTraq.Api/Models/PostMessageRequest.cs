using System.Text.Json.Serialization;

namespace DotnetTraq.Api.Models
{
    public readonly struct PostMessageRequest
    {
        [JsonPropertyName("embed")]
        public required bool AutoEmbedding { get; init; }

        [JsonPropertyName("content")]
        public required string? Text { get; init; }
    }
}
