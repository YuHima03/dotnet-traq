using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace DotnetTraq.Api.Models
{
    public sealed class GetChannelsResult
    {
        [JsonPropertyName("public")]
        [NotNull]
        public Channel[]? PublicChannels { get; set; }
    }
}
