using System.Text.Json.Serialization;

namespace DotnetTraq.Api.Models
{
    public struct PostStampRequest
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }
    }
}
