using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace DotnetTraq.Api.Models
{
    public sealed class User
    {
        [JsonPropertyName("displayName")]
        [NotNull]
        public string? DisplayName { get; set; }

        [JsonPropertyName("iconFileId")]
        public Guid IconFileId { get; set; }

        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("bot")]
        public bool IsBot { get; set; }

        [JsonPropertyName("name")]
        [NotNull]
        public string? Name { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
