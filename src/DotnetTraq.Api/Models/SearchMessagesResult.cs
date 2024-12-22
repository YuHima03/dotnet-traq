using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace DotnetTraq.Api.Models
{
    public class SearchMessagesResult
    {
        [JsonPropertyName("totalHits")]
        public int HitCount { get; set; }

        [JsonPropertyName("hits")]
        [NotNull]
        public Message[]? Messages { get; set; }
    }
}
