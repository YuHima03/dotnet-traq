using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace DotnetTraq.Api.Models
{
    public sealed class UserDetail
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("displayName")]
        [NotNull]
        public string? DisplayName { get; set; }

        [JsonPropertyName("bot")]
        public bool IsBot { get; set; }

        [JsonPropertyName("name")]
        [NotNull]
        public string? Name { get; set; }
    }
}
