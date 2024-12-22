using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace DotnetTraq.Api.Models
{
    public sealed class GetChannelFromPathResult
    {
        [JsonPropertyName("public")]
        [NotNull]
        public Channel? PublicChannel { get; set; }
    }
}
